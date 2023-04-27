



-- Tạo cơ sở dữ liệu QLTruongTHPT
CREATE DATABASE QuanLyTuongTHPT;

-- Sử dụng cơ sở dữ liệu QLTruongTHPT
USE QuanLyTuongTHPT;

-- Tạo bảng sơ yếu lý lịch


CREATE TABLE SoYeuLyLich (
    MaHS Nchar(5) FOREIGN KEY REFERENCES QuanLyHocSinh(MaHs),
    HoTen NVARCHAR(50),
    NgaySinh DATE,
    GioiTinh NVARCHAR(10),
    NoiSinh NVARCHAR(50),
    QueQuan NVARCHAR(50),
    DanToc NVARCHAR(50),
    QuocTich NVARCHAR(50),
    TonGiao NVARCHAR(50),
    TPXuatThan NVARCHAR(50),
    NgayVaoDoan DATE,
    NgayVaoDang DATE,
    NoiThuongTru NVARCHAR(100),
    XaPhuong NVARCHAR(50),
    QuanHuyen NVARCHAR(50),
    TinhThanhPho NVARCHAR(50),
    DoiTuongCS NVARCHAR(50),
    DoiTuongTroCap NVARCHAR(50),
    NhomDT NVARCHAR(50),
    DienThoaiNhaRieng NVARCHAR(20),
    DienThoaiCaNhan NVARCHAR(20),
    Email NVARCHAR(50),
    SoCMND NVARCHAR(20),
    DiaChiBaoTin NVARCHAR(100),
    NoiOHienNay NVARCHAR(100),
	primary key(MaHs)
);
Go
CREATE PROCEDURE TimKiemHS
    @TenHS NVARCHAR(50)
AS
BEGIN
    SELECT * FROM SoYeuLyLich
    WHERE HoTen LIKE '%' + @TenHS + '%'
END



go
-- tạo thủ tục Thêm sơ yếu lý lịch
CREATE PROCEDURE ThemSinhVien(
    @MaHS Nchar(5),
    @HoTen NVARCHAR(50),
    @NgaySinh DATE,
    @GioiTinh NVARCHAR(10),
    @NoiSinh NVARCHAR(50),
    @QueQuan NVARCHAR(50),
    @DanToc NVARCHAR(50),
    @QuocTich NVARCHAR(50),
    @TonGiao NVARCHAR(50),
    @TPXuatThan NVARCHAR(50),
    @NgayVaoDoan DATE,
    @NgayVaoDang DATE,
    @NoiThuongTru NVARCHAR(100),
    @XaPhuong NVARCHAR(50),
    @QuanHuyen NVARCHAR(50),
    @TinhThanhPho NVARCHAR(50),
    @DoiTuongCS NVARCHAR(50),
    @DoiTuongTroCap NVARCHAR(50),
    @NhomDT NVARCHAR(50),
    @DienThoaiNhaRieng NVARCHAR(20),
    @DienThoaiCaNhan NVARCHAR(20),
    @Email NVARCHAR(50),
    @SoCMND NVARCHAR(20),
    @DiaChiBaoTin NVARCHAR(100),
    @NoiOHienNay NVARCHAR(100)
) AS
BEGIN
    INSERT INTO SoYeuLyLich (MaHS, HoTen, NgaySinh, GioiTinh, NoiSinh, QueQuan, DanToc, QuocTich, TonGiao, TPXuatThan, NgayVaoDoan, NgayVaoDang, NoiThuongTru, XaPhuong, QuanHuyen, TinhThanhPho, DoiTuongCS, DoiTuongTroCap, NhomDT, DienThoaiNhaRieng, DienThoaiCaNhan, Email, SoCMND, DiaChiBaoTin, NoiOHienNay)
    VALUES (@MaHS, @HoTen, @NgaySinh, @GioiTinh, @NoiSinh, @QueQuan, @DanToc, @QuocTich, @TonGiao, @TPXuatThan, @NgayVaoDoan, @NgayVaoDang, @NoiThuongTru, @XaPhuong, @QuanHuyen, @TinhThanhPho, @DoiTuongCS, @DoiTuongTroCap, @NhomDT, @DienThoaiNhaRieng, @DienThoaiCaNhan, @Email, @SoCMND, @DiaChiBaoTin, @NoiOHienNay)
END


-- tạo thủ tục Sửa sơ yếu lý lịch
Go

CREATE PROCEDURE SuaSinhVien(
    @MaHS Nchar(5),
    @HoTen NVARCHAR(50),
    @NgaySinh DATE,
    @GioiTinh NVARCHAR(10),
    @NoiSinh NVARCHAR(50),
    @QueQuan NVARCHAR(50),
    @DanToc NVARCHAR(50),
	@QuocTich NVARCHAR(50),
	@TonGiao NVARCHAR(50),
	@TPXuatThan NVARCHAR(50),
	@NgayVaoDoan DATE,
	@NgayVaoDang DATE,
	@NoiThuongTru NVARCHAR(100),
	@XaPhuong NVARCHAR(50),
	@QuanHuyen NVARCHAR(50),
	@TinhThanhPho NVARCHAR(50),
	@DoiTuongCS NVARCHAR(50),
	@DoiTuongTroCap NVARCHAR(50),
	@NhomDT NVARCHAR(50),
	@DienThoaiNhaRieng NVARCHAR(20),
	@DienThoaiCaNhan NVARCHAR(20),
	@Email NVARCHAR(50),
	@SoCMND NVARCHAR(20),
	@DiaChiBaoTin NVARCHAR(100),
	@NoiOHienNay NVARCHAR(100)
	) AS
	BEGIN
	UPDATE SoYeuLyLich
	SET HoTen = @HoTen,
	NgaySinh = @NgaySinh,
	GioiTinh = @GioiTinh,
	NoiSinh = @NoiSinh,
	QueQuan = @QueQuan,
	DanToc = @DanToc,
	QuocTich = @QuocTich,
	TonGiao = @TonGiao,
	TPXuatThan = @TPXuatThan,
	NgayVaoDoan = @NgayVaoDoan,
	NgayVaoDang = @NgayVaoDang,
	NoiThuongTru = @NoiThuongTru,
	XaPhuong = @XaPhuong,
	QuanHuyen = @QuanHuyen,
	TinhThanhPho = @TinhThanhPho,
	DoiTuongCS = @DoiTuongCS,
	DoiTuongTroCap = @DoiTuongTroCap,
	NhomDT = @NhomDT,
	DienThoaiNhaRieng = @DienThoaiNhaRieng,
	DienThoaiCaNhan = @DienThoaiCaNhan,
	Email = @Email,
	SoCMND = @SoCMND,
	DiaChiBaoTin = @DiaChiBaoTin,
	NoiOHienNay = @NoiOHienNay
	WHERE MaHS = @MaHS
END

-- thủ tục xóa sơ yếu lý lịch
Go
CREATE PROCEDURE XemThongTinSinhVien
    @MaHS Nchar(5)
AS
BEGIN
    SELECT * FROM SoYeuLyLich WHERE MaHS = @MaHS
END


go
alter PROCEDURE XemThongTinAllSV
AS
BEGIN
    SELECT * FROM SoYeuLyLich
END
go



go

CREATE PROCEDURE XoaSinhVien(
@MaHS Nchar(5)
) AS
BEGIN
DELETE FROM SoYeuLyLich
WHERE MaHS = @MaHS
END

Go
-- bảng quản lý lớp
CREATE TABLE QuanLyLop (
    MaLop NCHAR(5) PRIMARY KEY,
    TenLop NVARCHAR(50) NOT NULL,
    TrangThai NVARCHAR(20) NOT NULL,
    GhiChu NVARCHAR(100)
)

go
CREATE PROCEDURE TimKiemLop 
    @TenLop NVARCHAR(50)
AS
BEGIN
    SELECT * FROM QuanLyLop
    WHERE TenLop LIKE '%' + @TenLop + '%'
END
go
exec TimKiemLop @Tenlop = N'oto'


go
CREATE PROCEDURE ThemLopMoi
	@MaLop NCHAR(5),
    @TenLop NVARCHAR(50),
    @TrangThai NVARCHAR(20),
    @GhiChu NVARCHAR(100)
AS
BEGIN
    INSERT INTO QuanLyLop(MaLop,TenLop, TrangThai, GhiChu)
    VALUES (@MaLop,@TenLop, @TrangThai, @GhiChu)
END
go

CREATE PROCEDURE SuaThongTinLop
    @MaLop NCHAR(5),
    @TenLop NVARCHAR(50),
    @TrangThai NVARCHAR(20),
    @GhiChu NVARCHAR(100)
AS
BEGIN
    UPDATE QuanLyLop
    SET TenLop = @TenLop, TrangThai = @TrangThai, GhiChu = @GhiChu
    WHERE MaLop = @MaLop
END
go
CREATE PROCEDURE XoaLop
    @MaLop NCHAR(5)
AS
BEGIN
    DELETE FROM QuanLyLop WHERE MaLop = @MaLop
END

go
CREATE PROCEDURE XemDanhSachLop
AS
BEGIN
    SELECT * FROM QuanLyLop
END
go
-- bảng quản lý học sinh


go

CREATE TABLE QuanLyHocSinh (
    MaHS Nchar(5) PRIMARY KEY,
    TenHS NVARCHAR(50),
    Tuoi INT,
    MaLop NCHAR(5) FOREIGN KEY REFERENCES QuanLyLop(MaLop),
    TrangThai NVARCHAR(20)
);
go

CREATE PROCEDURE TimKiemHocSinh
    @TenHS NVARCHAR(50)
AS
BEGIN
    SELECT *
    FROM QuanLyHocSinh
    WHERE TenHS LIKE '%' + @TenHS + '%'
END




go
alter PROCEDURE ThemHocSinh
    @MaHS Nchar(5),
    @TenHS NVARCHAR(50),
    @Tuoi INT,
    @MaLop NCHAR(5),
    @TrangThai NVARCHAR(20)
AS
BEGIN
    INSERT INTO QuanLyHocSinh (MaHS, TenHS, Tuoi, MaLop, TrangThai)
    VALUES (@MaHS, @TenHS, @Tuoi, @MaLop, @TrangThai)
END
go
CREATE PROCEDURE XoaHocSinh
    @MaHS Nchar(5)
AS
BEGIN
    DELETE FROM QuanLyHocSinh WHERE MaHS = @MaHS
END
go
ALTER PROCEDURE SuaThongTinHocSinh
    @MaHS Nchar(5),
    @TenHS NVARCHAR(50),
    @Tuoi INT,
    @MaLop NCHAR(5),
    @TrangThai NVARCHAR(20)
AS
BEGIN
    UPDATE QuanLyHocSinh SET 
        TenHS = @TenHS,
        Tuoi = @Tuoi,
        MaLop = @MaLop,
        TrangThai = @TrangThai
    WHERE MaHS = @MaHS
END
go
alter PROCEDURE XemThongTinHocSinh   
AS
BEGIN
    SELECT * FROM QuanLyHocSinh
END
go


create table MonHoc(
	MaHP NCHAR(5) primary key,
	TenHP NVARCHAR(50)
)


go


CREATE TABLE XemLichHoc (
    MaHP NCHAR(5) FOREIGN key REFERENCES MonHoc(MaHP),
    TenHP NVARCHAR(50),
    MaLop Nchar(5) FOREIGN key REFERENCES QuanLyLop(MaLop),
    CaHoc NVARCHAR(10),
    Thu NVARCHAR(10),
    TenGV NVARCHAR(50),
    LichHoc NVARCHAR(50),
    TenLop NVARCHAR(50),
    PRIMARY KEY (MaHP,MaLop)
)
go


alter PROCEDURE TimKienLichHoc
    @TenHP NVARCHAR(50)
AS
BEGIN
    SELECT * 
    FROM XemLichHoc 
    WHERE TenHP LIKE '%' + @TenHP + '%'
END

go

SELECT * FROM XemLichHoc
go
CREATE PROCEDURE XuatLichHoc(@MaLop NCHAR(5))
AS
BEGIN
    SELECT MaHP, TenHP, MaLop, CaHoc, Thu, TenGV, LichHoc, TenLop
    FROM XemLichHoc
    WHERE MaLop = @MaLop
END

exec XuatLichHoc @MaLop = 'LH001'

go
delete XemLichHoc

insert into XemLichHoc values
('HP001',N'Hệ thống thông tin quản lý','LH001',N'Sáng-Tối',N'Thứ 2',N'Lê Thị Huyền Trang',N'Thứ 2(T1-3)&Thứ 2(T4-6)',N'Tòa nhà POLYCO-401'),
('HP002',N'Lập trình .NET','LH001',N'Sáng-Chiều',N'Thứ 3',N'Trần Nguyên Hoàng',N'Thứ 3(T1-3)&Thứ 3(T10-12)',N'Tòa nhà EAUT-206'),
('HP003',N'Lập trình mạng','LH001',N'Sáng-Tối',N'Thứ 4',N'Nguyễn Hữu Phương',N'Thứ 4(T1-3)&Thứ 4(T14-16)',N'Tòa nhà POLYCO-401'),
('HP004',N'Phân tích và thiết kế hệ thống','LH001',N'Sáng',N'Thứ 5',N'Nguyễn Hải Bình',N'Thứ 5(T1-3)&Thứ 5(T4-6)',N'Tòa nhà EAUT-205'),
('HP005',N'Tiếng anh CN','LH001',N'Sáng-Chiều',N'Thứ 6',N'Giáp Thị An',N'Thứ 6(T1-3)&Thứ 6(T10-12)',N'Tòa nhà Đinh Trọng Dật-401'),
('HP006',N'Tư tưởng Hồ Chí Minh','LH001',N'Sáng',N'Thứ 7',N'Trịnh Thanh Hải',N'Thứ 7(T1-3)&Thứ 7(T4-6)',N'Tòa nhà EAUT-204'),
('HP007',N'Xác suất thống kê','LH001',N'Sáng',N'Thứ 7',N'Võ Duy Hoàng',N'Thứ 7(T1-3)&Thứ 7(T4-6)',N'Tòa nhà Đinh Trọng Dật-402')


exec XemThongTinLichHoc




go
alter PROCEDURE XemThongTinLichHoc
AS
BEGIN
    SELECT * FROM XemLichHoc
end
go
exec XemThongTinLichHoc

go

CREATE PROCEDURE SuaThongTinLichHoc
    @MaHP Nchar(5),
    @MaLop Nchar(5),
    @TenHP NVARCHAR(50),
    @CaHoc NVARCHAR(10),
    @Thu NVARCHAR(10),
    @TenGV NVARCHAR(50),
    @LichHoc NVARCHAR(50),
    @TenLop NVARCHAR(50)
AS
BEGIN
    UPDATE XemLichHoc SET 
        TenHP = @TenHP,
        CaHoc = @CaHoc,
        Thu = @Thu,
        TenGV = @TenGV,
        LichHoc = @LichHoc,
        TenLop = @TenLop
    WHERE MaHP = @MaHP AND MaLop = @MaLop
END

go

drop table QuanLyGiaoVien
CREATE TABLE QuanLyGiaoVien (
    MaGV Nchar(5) PRIMARY KEY,
    TenGV NVARCHAR(50),
    Tuoi INT,
    MaLop Nchar(5),
    TrangThai NVARCHAR(20),
    MaHP NCHAR(5) FOREIGN key REFERENCES MonHoc(MaHP),
    FOREIGN KEY (MaLop) REFERENCES QuanLyLop(MaLop)
);
go
CREATE PROCEDURE TimKiemGVTheoTen
    @TenGV NVARCHAR(50)
AS
BEGIN
    SELECT *
    FROM QuanLyGiaoVien
    WHERE TenGV LIKE '%' + @TenGV + '%'
END

go
INSERT INTO QuanLyGiaoVien
VALUES ('GV001', 'Nguyen Van A', 35, 'LH001', 'Dang giang day', 'HP001'),
		('GV002', 'Tran Thi B', 28, 'LH002', 'Nghi viec', 'HP002');


go
ALTER PROCEDURE ThemGiaoVien
    @MaGV Nchar(5),
    @TenGV NVARCHAR(50),
    @Tuoi INT,
    @MaLop Nchar(5),
    @TrangThai nVARCHAR(20),
    @MaHP NCHAR(5)
AS
BEGIN
    INSERT INTO QuanLyGiaoVien (MaGV, TenGV, Tuoi, MaLop, TrangThai, MaHP)
    VALUES (@MaGV, @TenGV, @Tuoi, @MaLop, @TrangThai, @MaHP)
END

go

alter PROCEDURE SuaThongTinGiaoVien
    @MaGV Nchar(5),
    @TenGV nVARCHAR(50),
    @Tuoi INT,
    @MaLop Nchar(5),
    @TrangThai nVARCHAR(20),
    @MaHP NCHAR(5)
AS
BEGIN
    UPDATE QuanLyGiaoVien
    SET TenGV = @TenGV, Tuoi = @Tuoi, MaLop = @MaLop, TrangThai = @TrangThai, MaHP = @MaHP
    WHERE MaGV = @MaGV
END

EXEC SuaThongTinGiaoVien @MAGV = 'GV002' ,@TenGV = N'adbsh' ,@Tuoi=8, @MaLop = 'lh002', @TrangThai = N'nghi viec', @MaHP = 'HP002'
go

CREATE PROCEDURE XoaGiaoVien
    @MaGV Nchar(5)
AS
BEGIN
    DELETE FROM QuanLyGiaoVien
    WHERE MaGV = @MaGV
END

go

CREATE PROCEDURE XemThongTinGiaoVien
AS
BEGIN
    SELECT *
    FROM QuanLyGiaoVien
END
go
drop table QuanLyDiemSo
go

CREATE PROCEDURE TimKiemDiemTheoTenHS
    @TenHS NVARCHAR(50)
AS
BEGIN
    SELECT qlds.MaDS, qlds.MaHP, qlds.MaHs, qlds.TenHP, qlds.DiemSo, qlds.HocKy, qlds.NamHoc
    FROM QuanLyDiemSo qlds
    INNER JOIN QuanLyHocSinh qlhs ON qlds.MaHs = qlhs.MaHS
    WHERE qlhs.TenHS LIKE '%' + @TenHS + '%'
END



go
CREATE TABLE QuanLyDiemSo (
MaDS INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
MaHP NCHAR(5) NOT NULL,
MaHs Nchar(5) NOT NULL,
TenHP NVARCHAR(50) NOT NULL,
DiemSo FLOAT NOT NULL,
HocKy NVARCHAR(255) NOT NULL,
NamHoc NVARCHAR(255) NOT NULL,
--PRIMARY KEY (DiemSo),
FOREIGN KEY (MaHP) REFERENCES MonHoc(MaHP),
FOREIGN KEY (MaHs) REFERENCES QuanLyHocSinh(MaHs),

);
SELECT AVG(DiemSo) as DiemTrungBinh
FROM QuanLyDiemSo;

go

ALTER PROCEDURE DiemSoTrungBinh
    @MaHS NCHAR(5),
    @HocKy NVARCHAR(255),
    @NamHoc NVARCHAR(255)
AS
BEGIN
    SELECT 
        QuanLyDiemSo.MaHP,
        QuanLyHocSinh.MaHS,
		QuanLyHocSinh.TenHS,
        QuanLyDiemSo.DiemSo,
		QuanLyDiemSo.TenHP,
        QuanLyDiemSo.HocKy,
        QuanLyDiemSo.NamHoc,
        
        AVG(QuanLyDiemSo.DiemSo) OVER (PARTITION BY QuanLyHocSinh.MaHS) AS 'DiemTB'
    FROM 
        QuanLyDiemSo
        JOIN QuanLyHocSinh ON QuanLyHocSinh.MaHS = QuanLyDiemSo.MaHs
    WHERE 
        QuanLyDiemSo.MaHs = @MaHS 
        AND QuanLyDiemSo.HocKy = @HocKy 
        AND QuanLyDiemSo.NamHoc = @NamHoc
END;


exec DiemSoTrungBinh @Mahs = 'HS001', @HocKy = N'Học Kỳ 1',@NamHoc = N'2020-2021'



go
CREATE PROCEDURE SelectAllWithAvgScore
AS
BEGIN
    SELECT *, AVG(DiemSo) OVER(PARTITION BY MaHs) AS DiemTrungBinh
    FROM QuanLyDiemSo
END

go
exec SelectAllWithAvgScore
go

drop trigger TRG_QuanLyDiemSo_Insert

-- trigger sai không theo ý muốn không sử dụng được 
alter TRIGGER TRG_QuanLyDiemSo_Insert
ON QuanLyDiemSo
INSTEAD OF INSERT
AS
BEGIN
    -- Check for duplicate record
    IF EXISTS (
        SELECT 1 FROM QuanLyDiemSo 
        WHERE MaHS IN (SELECT MaHS FROM inserted)
        AND MaHP IN (SELECT MaHP FROM inserted)
    )
    BEGIN
        RAISERROR ('Không thể thêm điểm cho một học sinh đã có điểm môn học này!', 16, 1)
        ROLLBACK TRANSACTION
        RETURN
    END
    
    -- Insert new record
    INSERT INTO QuanLyDiemSo (MaHP, MaHS, TenHP, DiemSo, HocKy, NamHoc)
    SELECT MaHP, MaHS, TenHP, DiemSo, HocKy, NamHoc FROM inserted;
END;




go
drop proc ThemDiemSo
go
-- thủ tục chưa kiểm tra đã có điểm hay chưa
--ALTER PROCEDURE ThemDiemSo
--@MaHP NCHAR(5),
--@MaHS Nchar(5),
--@TenHP NVARCHAR(50),
--@DiemSo FLOAT,
--@HocKy NVARCHAR(255),
--@NamHoc NVARCHAR(255)
--AS
--BEGIN
--INSERT INTO QuanLyDiemSo (MaHP, MaHs, TenHP, DiemSo, HocKy, NamHoc)
--VALUES (@MaHP, @MaHS, @TenHP, @DiemSo, @HocKy, @NamHoc);
--END;
go
alter PROCEDURE ThemDiemSo
    @MaHP NCHAR(5),
    @MaHS NCHAR(5),
    @TenHP NVARCHAR(50),
    @DiemSo FLOAT,
    @HocKy NVARCHAR(255),
    @NamHoc NVARCHAR(255)
AS
BEGIN
    INSERT INTO QuanLyDiemSo (MaHP, MaHS, TenHP, DiemSo, HocKy, NamHoc)
    VALUES 
        (@MaHP, @MaHS, @TenHP, @DiemSo, @HocKy, @NamHoc)  
END


	
go

ALTER PROCEDURE SuaDiemSo
@MaHP NCHAR(5),
@MaHS Nchar(5),
@TenHP NVARCHAR(50),
@DiemSo FLOAT,
@HocKy NVARCHAR(255),
@NamHoc NVARCHAR(255)
AS
BEGIN
UPDATE QuanLyDiemSo
SET TenHP = @TenHP,
DiemSo = @DiemSo,
HocKy = @HocKy,
NamHoc = @NamHoc
WHERE MaHP = @MaHP AND MaHs = @MaHS and TenHP =@TenHP;
END;


go

ALTER PROCEDURE XoaDiemSo
    @MaHP NCHAR(5),
    @MaHS NCHAR(5),
    @TenHP NVARCHAR(50)
AS
BEGIN
    -- Kiểm tra xem điểm số có tồn tại không
    IF NOT EXISTS (SELECT * FROM QuanLyDiemSo WHERE MaHP = @MaHP AND MaHS = @MaHS AND TenHP = @TenHP)
    BEGIN
        RAISERROR('Không tìm thấy điểm số', 16, 1)
        RETURN
    END

    -- Xóa điểm số
    DELETE FROM QuanLyDiemSo WHERE MaHP = @MaHP AND MaHS = @MaHS AND TenHP = @TenHP
END


exec XoaDiemSo @MaHP = 'HP001', @MAHS= 'HS001', @TENHP = 'MonHocKhac'

go
-- Xem thông tin tất cả các bản ghi trong bảng QuanLyDiemSo
CREATE PROCEDURE XemDiemSo
AS
BEGIN
SELECT *
FROM QuanLyDiemSo;
END;
go

exec XemDiemSo


-- Xem thông tin bản ghi cụ thể trong bảng QuanLyDiemSo
--CREATE PROCEDURE XemChiTietDiemSo
--@MaHocPhan INT,
--@MaHocSinh INT
--AS
--BEGIN
--SELECT *
--FROM QuanLyDiemSo
--WHERE MaHocPhan = @MaHocPhan AND MaHocSinh = @MaHocSinh;
--END;



go

CREATE PROCEDURE BaoCaoSoYeuLyLich
    @MaHS Nchar(5)
AS
BEGIN
    SELECT * FROM SoYeuLyLich WHERE MaHS = @MaHS
END

go

drop PROCEDURE XuatLichHoc
    @MaLop Nchar(5)
AS
BEGIN
    SELECT 
        mh.MaHP AS 'Mã học phần',
        mh.TenHP AS 'Tên học phần',
        ql.TenLop AS 'Tên lớp',
        xlh.CaHoc AS 'Ca học',
        xlh.Thu AS 'Thứ',
        gv.TenGV AS 'Tên giáo viên',
        xlh.LichHoc AS 'Lịch học'
    FROM 
        XemLichHoc xlh
        JOIN MonHoc mh ON xlh.MaHP = mh.MaHP
        JOIN QuanLyLop ql ON xlh.MaLop = ql.MaLop
        JOIN QuanLyGiaoVien gv ON xlh.MaHP = gv.MaHP AND xlh.MaLop = gv.MaLop
    WHERE 
        xlh.MaLop = @MaLop
END

exec XuatLichHoc @malop = 'lh001'
go
CREATE PROCEDURE XuatDiemSinhVien
    @MaHS Nchar(5)
AS
BEGIN
    SELECT qhs.MaHS, qhs.TenHS, qmh.MaHP, qmh.TenHP, qds.DiemSo, qds.HocKy, qds.NamHoc
    FROM QuanLyHocSinh qhs
    JOIN QuanLyDiemSo qds ON qhs.MaHS = qds.MaHs
    JOIN MonHoc qmh ON qds.MaHP = qmh.MaHP
    WHERE qhs.MaHS = @MaHS
END

go

exec XemThongTinSinhVien @MaHs = 'Hs001'
go

exec ThemSinhVien @MaHS = 'HS003', @HoTen = N'ĐỖ TUẤN ANH', @NgaySinh = '2003-03-16', @GioiTinh =N'NAM', @NoiSinh=N'HÀ NỘI', @QueQuan = N'HÀ NỘI', @DanToc = N'KINH', @QuocTich = N'HÀ NỘI', @TonGiao = N'1',
@TPXuatThan = N'NONE', @NgayVaoDoan='2003-03-16', @NgayVaoDang='2003-03-16', @NoiThuongTru = N'HÀ NỘI', 
@XaPhuong = N'NAM TỪ LIÊM', @QuanHuyen = N'NHỔN', @TinhThanhPho = N'HÀ NỘI', @DoiTuongCS = '', 
@DoiTuongTroCap='', @NhomDT='', @DienThoaiNhaRieng='', @DienThoaiCaNhan='', @Email='', @SoCMND='', 
@DiaChiBaoTin='', @NoiOHienNay=''


go

alter PROCEDURE GetSYLLHS (
	@MaHS NCHAR(5)
)
AS
BEGIN
	SELECT s.MaHS, s.HoTen, s.NgaySinh, s.GioiTinh, s.NoiSinh, s.QueQuan, s.DanToc, s.QuocTich, s.TonGiao, s.TPXuatThan, s.NgayVaoDoan, s.NgayVaoDang, s.NoiThuongTru, s.XaPhuong, s.QuanHuyen, s.TinhThanhPho, s.DoiTuongCS, s.DoiTuongTroCap, s.NhomDT, s.DienThoaiNhaRieng, s.DienThoaiCaNhan, s.Email, s.SoCMND, s.DiaChiBaoTin, s.NoiOHienNay, m.ImageData
	FROM SoYeuLyLich s
	INNER JOIN MyImages m ON s.MaHS = m.MaHs
	WHERE s.MaHS = @MaHS
END
go
exec GetSYLLHS @MaHs = HS001
GO

EXEC GetSYLLHS @MaHs = 'HS002'
go



CREATE TABLE MyImages
(
MaHs NCHAR(5) Foreign KEY references SoYeuLyLich(MaHs),
ImageName VARCHAR(50),
ImageData IMAGE
)

go
INSERT INTO MyImages (MaHs, ImageName, ImageData)
VALUES ('HS001', 'Tiến Anh', (SELECT BulkColumn FROM OPENROWSET(BULK 'D:\ALL_EAUT\LAPTRINH.NET\BÀITậpLớn\DemoProject.NET\DemoProject.NET\Resources\iconstuden.jpg', SINGLE_BLOB) AS x))

INSERT INTO MyImages (MaHs, ImageName, ImageData)
VALUES ('HS002', 'Tuấn Anh', (SELECT BulkColumn FROM OPENROWSET(BULK 'D:\ALL_EAUT\LAPTRINH.NET\BÀITậpLớn\DemoProject.NET\DemoProject.NET\Resources\teacher.jpg', SINGLE_BLOB) AS x))

go

go

-- có thời gian sẽ triển khai thêm cho người dùng đưa ảnh mình vào--
CREATE PROCEDURE AddImage
    @MaHs NCHAR(5),
    @ImageName VARCHAR(50),
    @ImageData IMAGE
AS
BEGIN
    INSERT INTO MyImages (MaHs, ImageName, ImageData)
    VALUES (@MaHs, @ImageName, @ImageData)
END


go


