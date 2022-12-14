--TRIGGER về số lượng nhân viên bộ phận khi thêm hoặc xóa, cập nhật 1 nhân viên

--Thêm, xóa nhân viên
CREATE TRIGGER tg_ThemXoaNhanVien
ON NhanVien
AFTER INSERT, DELETE
AS
BEGIN
	IF EXISTS (SELECT * FROM inserted)
	BEGIN
		UPDATE BOPHAN
		SET SoLuongNV = ISNULL(SoLuongNV,0) + 1
		WHERE MaBP = (SELECT MaBP FROM inserted)
	END
	ELSE IF EXISTS(SELECT * FROM deleted)
	BEGIN
		UPDATE BOPHAN
		SET SoLuongNV = SoLuongNV - 1
		WHERE MaBP = (SELECT MaBP FROM deleted)
	END
END

--Cập nhật nhân viên
GO
CREATE TRIGGER tg_CapNhatNhanVien
ON NhanVien
AFTER UPDATE
AS
BEGIN
	IF(UPDATE(MaBp))
	BEGIN
		UPDATE BOPHAN
		SET SoLuongNV = ISNULL(SoLuongNV, 0) + 1
		WHERE MaBP = (SELECT MaBP FROM inserted)
		UPDATE BOPHAN
		SET SoLuongNV = SoLuongNV - 1
		WHERE MaBP = (SELECT MaBP FROM deleted)
	END
END



--TRIGGER đặt xóa dịch vụ cập nhật tiền trong hóa đơn

GO
CREATE TRIGGER tg_DatXoaDichVu
ON DATDICHVU
AFTER INSERT, DELETE
AS
BEGIN
	IF EXISTS (SELECT * FROM inserted)
	BEGIN
		UPDATE HOADON
		SET ThanhTien = ISNULL(ThanhTien, 0) + (SELECT DonGia FROM DICHVU WHERE MaDV = (SELECT MaDV FROM inserted))
		WHERE MaTiec = (SELECT MaTiec FROM inserted)
	END
	ELSE IF EXISTS(SELECT * FROM deleted)
	BEGIN
		IF EXISTS( SELECT * FROM HOADON WHERE MaTiec in (SELECT MaTiec FROM deleted))
		BEGIN
			UPDATE HOADON
			SET ThanhTien = ISNULL(ThanhTien, 0) - (SELECT DonGia FROM DICHVU WHERE MaDV = (SELECT MaDV FROM deleted))
			WHERE MaTiec = (SELECT MaTiec FROM deleted)
		END
	END
END



--Đặt hoặc xóa 1 món ăn thì tiền trong hóa đơn tự động tăng
GO
CREATE  TRIGGER tg_DatXoaMonAn
ON DATMONAN
AFTER INSERT, DELETE
AS
BEGIN
	IF EXISTS (SELECT * FROM inserted)
	BEGIN
		UPDATE HOADON
		SET ThanhTien = ISNULL(ThanhTien, 0) + ((SELECT DonGia FROM MONAN WHERE MaMA = (SELECT MaMA FROM inserted)) * (SELECT SoLuong FROM inserted))
		WHERE MaTiec = (SELECT MaTiec FROM inserted)
		UPDATE DATMONAN
		SET ThanhTien = (SELECT DonGia FROM MONAN WHERE MaMA = (SELECT MaMA FROM inserted)) * (SELECT SoLuong FROM inserted)
		WHERE MaTiec =(SELECT MaTiec FROM inserted) AND MaMA = (SELECT MaMA FROM inserted)
	END
	ELSE IF EXISTS(SELECT * FROM deleted)
	BEGIN
		IF EXISTS( SELECT * FROM HOADON WHERE MaTiec in (SELECT MaTiec FROM deleted))
		BEGIN
			UPDATE HOADON
			SET ThanhTien = ISNULL(ThanhTien, 0) - ((SELECT DonGia FROM MONAN WHERE MaMA = (SELECT MaMA FROM deleted)) * (SELECT SoLuong FROM deleted))
			WHERE MaTiec = (SELECT MaTiec FROM deleted)
		END
	END
END
GO



--Khi cập nhật số lượng món ăn đặt
CREATE TRIGGER tg_CapNhatDatMon
ON DATMONAN
AFTER UPDATE
AS
BEGIN
	IF (UPDATE(SoLuong))
	BEGIN
		UPDATE HOADON
		SET ThanhTien = ISNULL(ThanhTien, 0) + ((SELECT DonGia FROM MONAN WHERE MaMA = (SELECT MaMA FROM inserted)) 
						* ((SELECT SoLuong FROM inserted) - (SELECT SoLuong FROM deleted)))
		WHERE MaTiec = (SELECT MaTiec FROM inserted)
		UPDATE DATMONAN
		SET ThanhTien = (SELECT DonGia FROM MONAN WHERE MaMA = (SELECT MaMA FROM inserted)) * (SELECT SoLuong FROM inserted)
		WHERE MaTiec =(SELECT MaTiec FROM inserted) AND MaMA = (SELECT MaMA FROM inserted)
	END
END



--TRIGGER 1 sảnh chỉ được đặt 1 tiệc duy nhất vào cùng 1 thời gian và phải đặt trước 7 ngày
GO
ALTER TRIGGER tg_DatSanhTiec
ON DATTIEC
AFTER UPDATE
AS
BEGIN
	IF(UPDATE(NgayToChuc) OR UPDATE(Buoi) OR UPDATE(MaSanh))
	BEGIN
		IF(DATEDIFF(DAY, GETDATE(), (SELECT NgayToChuc FROM inserted)) < 7)
		BEGIN
			RAISERROR (N'ERROR1: Bạn phải đặt tiệc trước ít nhất 7 ngày! Bạn vui lòng chọn thời điểm khác', 16, 10)
			ROLLBACK TRANSACTION
		END
		ELSE
		BEGIN
			IF EXISTS (SELECT * FROM DATTIEC WHERE MaTiec != (SELECT MaTiec FROM inserted)
												AND NgayToChuc = (SELECT NgayToChuc FROM inserted)
												AND MaSanh = (SELECT MaSanh FROM inserted)
												AND  Buoi = (SELECT Buoi FROM inserted))
			BEGIN
				RAISERROR (N'ERROR2: Vào thời điểm này sảnh này đã có người đặt! Bạn vui lòng chọn thời điểm khác', 16, 10)
				ROLLBACK TRANSACTION
			END
			ELSE
			BEGIN
				UPDATE HOADON
				SET ThanhTien = ISNULL(ThanhTien, 0) - (SELECT DonGia FROM Sanh WHERE MaSanh = (SELECT MaSanh FROM deleted))
				WHERE MaTiec = (SELECT MaTiec FROM inserted)
				UPDATE HOADON
				SET ThanhTien = ISNULL(ThanhTien, 0) + (SELECT DonGia FROM Sanh WHERE MaSanh = (SELECT MaSanh FROM inserted))
				WHERE MaTiec = (SELECT MaTiec FROM inserted)	
			END
		END
	END
END


--CONSTRAINT
--Tên dịch vụ là duy nhất

ALTER TABLE DichVu
ADD CONSTRAINT UC_TenDV UNIQUE (TenDV)

--Tên món ăn là duy nhất
ALTER TABLE MONAN
ADD CONSTRAINT UC_TenMA UNIQUE (TenMA)

--Tên bộ phận là duy nhất
ALTER TABLE BOPHAN 
ADD CONSTRAINT UC_TenBP UNIQUE (TenBP)

--1 tiệc chỉ có 1 hóa đơn
ALTER TABLE HOADON
ADD CONSTRAINT UC_MaTiec UNIQUE (MaTiec)

