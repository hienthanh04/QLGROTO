
CREATE DATABASE QUANLIGARA
GO

USE QUANLIGARA
GO

-- TAO BANG, KHOA CHINH, KHOA NGOAI --

-- 1. XE
create table XE(
	BienSo varchar(10),
	TenChuXe nvarchar(50),
	HieuXe varchar(20),
	DiaChi nvarchar(50),
	DienThoai varchar(50),
	Email varchar(50),
	TienNo money,
	NgayTiepNhan smalldatetime,
	constraint PK_XE primary key(BienSo)
)
GO

-- 2. HIEU XE
create table HIEUXE(
	HieuXe varchar(20)
	constraint PK_HIEUXE primary key(HieuXe)
)
GO

-- 3. PHIEU SUA CHUA
create table PHIEUSUACHUA(
	MaPSC char(10),
	BienSo varchar(10),
	NgaySuaChua smalldatetime,
	TongTien money
	constraint PK_PHIEUSUACHUA primary key(MaPSC)
)
GO

-- 4. CHI TIET PHIEU SUA CHUA
create table CT_PSC(
	MaPSC char(10),
	NoiDung nvarchar(200),
	MaVTPT char(10),
	TenVTPT nvarchar(50),
	SoLuong int,
	DonGia money,
	MaTienCong char(10),
	TienCong money,
	ThanhTien money,
)
GO

-- 5. PHU TUNG
create table PHUTUNG(
	MaVTPT char(10),
	TenVTPT nvarchar(50),
	SoLuongTon int,
	DonGia money,
	constraint PK_PHUTUNG primary key(MaVTPT)
)
GO

-- 6. TIEN CONG
create table TIENCONG(
	MaTienCong char(10),
	NoiDung nvarchar(200),
	TienCong money
	constraint PK_TIENCONG primary key(MaTienCong)
)
GO

-- 7. QUY DINH 
create table QUYDINH(
    SoXeSuaChuaToiDa INT,
    TiLeLai FLOAT,
    SoLuongHieuXe INT, 
    SoLoaiVTPT INT,
    SoLoaiTienCong INT, 
	CONSTRAINT PK_QUYDINH PRIMARY KEY(SoXeSuaChuaToiDa)
)
GO

-- 8. PHIEU THU TIEN
create table PHIEUTHUTIEN(
	MaPTT char(10),
	BienSo varchar(10),
	NgayThuTien smalldatetime,
	SoTienThu money
	constraint PK_PHIEUTHUTIEN primary key(MaPTT)
)
GO

-- 13. PHIEU NHAP KHO VAT TU PHU CTUNG
create table PHIEUNHAPKHOVTPT(
	
	MaNKVTPT char(10),
	NgayNhap smalldatetime
	constraint PK_PHIEUNHAPKHOVTPT primary key(MaNKVTPT)
)
GO

-- 14. CHI TIET PHIEU NHAP KHO VAT TU PHU TUNG
create table CT_PNKVTPT(
	MaNKVTPT char(10),
	MaVTPT char(10),
	TenVTPT nvarchar(50),
	SoLuong int,
	GiaNhap money
	
)
GO

CREATE TABLE NHANVIEN
(
	TenDangNhap nvarchar(20),
	MatKhau char(20),
	TenNV nvarchar(50),
	DienThoai varchar(50),
	Email varchar(50),
	DiaChi nvarchar(50),
	ChucVu nvarchar(50)
	constraint PK_NHANVIEN primary key(TenDangNhap)
)
GO

CREATE TABLE CHUCVU
(
	ChucVu nvarchar(50)
	constraint PK_CHUCVU primary key (ChucVu)
)
GO

-- TAO KHOA NGOAI
-- 1. BANG XE
alter table XE add constraint FK_XE foreign key(HieuXe) references HIEUXE(HieuXe)

-- 2. BANG PHIEU SUA CHUA
alter table PHIEUSUACHUA add constraint FK_PHIEUSUACHUA foreign key(BienSo) references XE(BienSo)

-- 3. BANG CHI TIET PHIEU SUA CHUA
alter table CT_PSC add constraint FK1_CT_PSC foreign key(MaPSC) references PHIEUSUACHUA(MaPSC)
alter table CT_PSC add constraint FK2_CT_PSC foreign key(MaVTPT) references PHUTUNG(MaVTPT)
alter table CT_PSC add constraint FK3_CT_PSC foreign key(MaTienCong) references TIENCONG(MaTienCong)

-- 4. BANG PHIEU THU TIEN
alter table PHIEUTHUTIEN add constraint FK_PHIEUTHUTIEN foreign key(BienSo) references XE(BienSo)


ALTER TABLE CT_PNKVTPT
ADD CONSTRAINT FK1_CT_PNKVTPT foreign key (MaNKVTPT) references PHIEUNHAPKHOVTPT (MaNKVTPT)
GO
ALTER TABLE CT_PNKVTPT
add constraint FK2_CT_PNKVTPT foreign key(MaVTPT) references PHUTUNG(MaVTPT)
GO
ALTER TABLE NHANVIEN
add constraint FK_NHANVIEN foreign key(ChucVu) references CHUCVU(ChucVu)
GO
CREATE FUNCTION [dbo].[fuConvertToUnsign1] ( @strInput NVARCHAR(4000) ) RETURNS NVARCHAR(4000) AS BEGIN IF @strInput IS NULL RETURN @strInput IF @strInput = '' RETURN @strInput DECLARE @RT NVARCHAR(4000) DECLARE @SIGN_CHARS NCHAR(136) DECLARE @UNSIGN_CHARS NCHAR (136) SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208) SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' DECLARE @COUNTER int DECLARE @COUNTER1 int SET @COUNTER = 1 WHILE (@COUNTER <=LEN(@strInput)) BEGIN SET @COUNTER1 = 1 WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) BEGIN IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) BEGIN IF @COUNTER=1 SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) ELSE SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) BREAK END SET @COUNTER1 = @COUNTER1 +1 END SET @COUNTER = @COUNTER +1 END SET @strInput = replace(@strInput,' ','-') RETURN @strInput END

GO

CREATE PROC DANGNHAP @username nvarchar(10), @password char(20)
AS
BEGIN
	SELECT TenDangNhap, MatKhau, ChucVu FROM NHANVIEN WHERE CAST(TenDangNhap AS varbinary(100)) = CAST(@username AS varbinary(100)) AND CAST(MatKhau AS varbinary(100)) = CAST(@password AS varbinary(100))
END
GO

create trigger tr_SoXeSuaChuaToiDaTrongNgay on XE for insert
as
	declare @SoXeToiDa int = (select SoXeSuaChuaToiDa from QUYDINH)
	if (select count(distinct BienSo) 
		from XE where Convert(date,NgayTiepNhan) = Convert(date, getdate())) > @SoXeToiDa
		Begin
			print N'Vượt quá số lượng xe sửa chữa tối đa trong ngày!'
			Rollback Tran
		End
go

CREATE TRIGGER tr_GioiHanHieuXe
ON HIEUXE
FOR INSERT
AS
BEGIN
    DECLARE @SoLuongToiDa INT;

    -- Lấy số lượng hiệu xe tối đa từ bảng QUYDINH
    SELECT TOP 1 @SoLuongToiDa = SoLuongHieuXe FROM QUYDINH;

    -- Đếm tổng số hiệu xe sau khi insert (gồm cả bản ghi mới)
    DECLARE @TongSoHieuXe INT;
    SELECT @TongSoHieuXe = COUNT(*) FROM HIEUXE;

    -- Nếu vượt quá số lượng tối đa, rollback và thông báo lỗi
    IF @TongSoHieuXe > @SoLuongToiDa
    BEGIN
        RAISERROR(N'Vượt quá số lượng hiệu xe tối đa được phép!', 16, 1);
        ROLLBACK TRANSACTION;
    END
END;
GO

CREATE TRIGGER tr_GioiHanTienCong
ON TIENCONG
FOR INSERT
AS
BEGIN
    DECLARE @SoToiDa INT;
    SELECT TOP 1 @SoToiDa = SoLoaiTienCong FROM QUYDINH;

    DECLARE @SoLoaiHienTai INT;
    SELECT @SoLoaiHienTai = COUNT(*) FROM TIENCONG;

    IF @SoLoaiHienTai > @SoToiDa
    BEGIN
        RAISERROR(N'Vượt quá số loại tiền công tối đa!', 16, 1);
        ROLLBACK TRANSACTION;
    END
END;
GO

CREATE TRIGGER tr_GioiHanPhuTung
ON PHUTUNG
FOR INSERT
AS
BEGIN
    DECLARE @SoToiDa INT;
    SELECT TOP 1 @SoToiDa = SoLoaiVTPT FROM QUYDINH;

    DECLARE @SoLoaiHienTai INT;
    SELECT @SoLoaiHienTai = COUNT(*) FROM PHUTUNG;

    IF @SoLoaiHienTai > @SoToiDa
    BEGIN
        RAISERROR(N'Vượt quá số loại vật tư phụ tùng tối đa!', 16, 1);
        ROLLBACK TRANSACTION;
    END
END;
GO


CREATE PROC BAOCAOTON 
@thang int, @nam int
AS 
BEGIN
((SELECT MaVTPT, TenVTPT, SUM(SoLuong) AS PhatSinh, 0 AS SuDung FROM CT_PNKVTPT C, PHIEUNHAPKHOVTPT P  
WHERE P.MaNKVTPT = C.MaNKVTPT AND MONTH(P.NgayNhap) = @thang AND YEAR(P.NgayNhap) = @nam AND MaVTPT NOT IN 
(SELECT T1.MaVTPT FROM
(SELECT MaVTPT, TenVTPT, SUM(SoLuong) AS PhatSinh, 0 AS SuDung FROM CT_PNKVTPT C, PHIEUNHAPKHOVTPT P  
WHERE P.MaNKVTPT = C.MaNKVTPT AND MONTH(P.NgayNhap) = @thang AND YEAR(P.NgayNhap) = @nam
GROUP BY MaVTPT, TenVTPT)  T1
JOIN
(SELECT MaVTPT, TenVTPT, 0 AS PhatSinh, SUM(SoLuong) AS SuDung FROM CT_PSC C, PHIEUSUACHUA P  
WHERE P.MaPSC = C.MaPSC AND MONTH(P.NgaySuaChua) = @thang AND YEAR(P.NgaySuaChua) = @nam
GROUP BY MaVTPT, TenVTPT) T2
ON T1.MaVTPT = T2.MaVTPT)
GROUP BY MaVTPT, TenVTPT))
UNION
(SELECT MaVTPT, TenVTPT, 0 AS PhatSinh, SUM(SoLuong) AS SuDung FROM CT_PSC C, PHIEUSUACHUA P  
WHERE P.MaPSC = C.MaPSC AND MONTH(P.NgaySuaChua) = @thang AND YEAR(P.NgaySuaChua) = @nam AND MaVTPT
NOT IN (SELECT T1.MaVTPT FROM
(SELECT MaVTPT, TenVTPT, SUM(SoLuong) AS PhatSinh, 0 AS SuDung FROM CT_PNKVTPT C, PHIEUNHAPKHOVTPT P  
WHERE P.MaNKVTPT = C.MaNKVTPT AND MONTH(P.NgayNhap) = @thang AND YEAR(P.NgayNhap) = @nam
GROUP BY MaVTPT, TenVTPT)  T1
JOIN
(SELECT MaVTPT, TenVTPT, 0 AS PhatSinh, SUM(SoLuong) AS SuDung FROM CT_PSC C, PHIEUSUACHUA P  
WHERE P.MaPSC = C.MaPSC AND MONTH(P.NgaySuaChua) = @thang AND YEAR(P.NgaySuaChua) = @nam
GROUP BY MaVTPT, TenVTPT) T2
ON T1.MaVTPT = T2.MaVTPT)
GROUP BY MaVTPT, TenVTPT)



UNION

(SELECT T1.MaVTPT, T1.TenVTPT, T1.PHATSINH, T2.SUDUNG FROM
(SELECT MaVTPT, TenVTPT, SUM(SoLuong) AS PHATSINH, 0 AS SUDUNG FROM CT_PNKVTPT C, PHIEUNHAPKHOVTPT P  
WHERE P.MaNKVTPT = C.MaNKVTPT AND MONTH(P.NgayNhap) = @thang AND YEAR(P.NgayNhap) = @nam
GROUP BY MaVTPT, TenVTPT)  T1
JOIN
(SELECT MaVTPT, TenVTPT, 0 AS PHATSINH, SUM(SoLuong) AS SUDUNG FROM CT_PSC C, PHIEUSUACHUA P  
WHERE P.MaPSC = C.MaPSC AND MONTH(P.NgaySuaChua) = @thang AND YEAR(P.NgaySuaChua) = @nam
GROUP BY MaVTPT, TenVTPT) T2
ON T1.MaVTPT = T2.MaVTPT)
END

