CREATE DATABASE QLBongDa
GO
USE QLBongDa
--drop database QLBongDa
--Nhà tài trợ
GO
CREATE TABLE Tbl_NHATAITRO(
MaNTT NVARCHAR(10) PRIMARY KEY,
TenNTT NVARCHAR(255),
SDT INT)
--Đội bóng
GO
CREATE TABLE Tbl_DOIBONG(
MaDB NVARCHAR(10) PRIMARY KEY,
TenDB NVARCHAR(255),
DiaChi NVARCHAR(255),
MaNTT NVARCHAR(10) FOREIGN KEY REFERENCES Tbl_NHATAITRO(MaNTT))
--Trọng tài
GO
CREATE TABLE Tbl_TRONGTAI(
MaTT NVARCHAR(10) PRIMARY KEY,
TenTT NVARCHAR(255),
NgaySinh date,
QuocTich NVARCHAR(100))
--Ban huấn luyện
GO
CREATE TABLE Tbl_BANHUANLUYEN(
MaBHL NVARCHAR(10) PRIMARY KEY,
TenBHL NVARCHAR(255),
ChucVu NVARCHAR(100),
MaDB NVARCHAR(10) FOREIGN KEY REFERENCES Tbl_DOIBONG(MaDB))
--Cầu thủ
GO
CREATE TABLE Tbl_CAUTHU(
MaCT NVARCHAR(10) PRIMARY KEY,
TenCT NVARCHAR(255),
ViTri NVARCHAR(100),
SoAo INT,
MaDB NVARCHAR(10) FOREIGN KEY REFERENCES Tbl_DOIBONG(MaDB))
--Sân vận động
GO
CREATE TABLE Tbl_SVD(
MaSVD NVARCHAR(10) PRIMARY KEY,
TenSVD NVARCHAR(100),
SucChua INT,
DiaChi NVARCHAR(100))
--Lịch thi đấu
GO 
CREATE TABLE Tbl_LICHTHIDAU(
MaTD NVARCHAR(10) PRIMARY KEY,
MaDB NVARCHAR(10) FOREIGN KEY REFERENCES Tbl_DOIBONG(MaDB),
MaSVD NVARCHAR(10) FOREIGN KEY REFERENCES Tbl_SVD(MaSVD),
MaTT NVARCHAR(10) FOREIGN KEY REFERENCES Tbl_TRONGTAI(MaTT),
Doi1 NVARCHAR(255),
Doi2 NVARCHAR(255),
NgayThiDau date,
GioTD Time not null)
ALTER TABLE Tbl_LICHTHIDAU
ADD CONSTRAINT DF_Tbl_LICHTHIDAU_MaDB DEFAULT 'DEFAULT_VALUE' FOR MaDB;
--Bàn thắng
GO
CREATE TABLE Tbl_BANTHANG(
MaBT NVARCHAR(10) PRIMARY KEY,
MaCT NVARCHAR(10) FOREIGN KEY REFERENCES Tbl_CAUTHU(MaCT),
LoaiBT NVARCHAR(100),
ThoiDiem Time,
MaDB NVARCHAR(10) FOREIGN KEY REFERENCES Tbl_DOIBONG(MaDB),
MaTD NVARCHAR(10) FOREIGN KEY REFERENCES Tbl_LICHTHIDAU(MaTD));
--Thẻ phạt
GO
CREATE TABLE Tbl_THEPHAT(
MaTP  NVARCHAR(10) PRIMARY KEY,
TenTP	NVARCHAR(100),
ThoiDiem TIME,
MaCT NVARCHAR(10) FOREIGN KEY REFERENCES Tbl_CAUTHU(MaCT),
MaDB NVARCHAR(10) FOREIGN KEY REFERENCES Tbl_DOIBONG(MaDB),
MaTD NVARCHAR(10)FOREIGN KEY REFERENCES Tbl_LICHTHIDAU(MaTD))
--Kết quả thi đấu
GO
CREATE TABLE Tbl_KQTHIDAU(
MaKQ NVARCHAR(10) PRIMARY KEY,
MaTD NVARCHAR(10) FOREIGN KEY REFERENCES Tbl_LICHTHIDAU(MaTD),
Doi1 NVARCHAR(255),
Doi2 NVARCHAR(255),
SoThePhatDoi1 INT not null,
SoThePhatDoi2 INT not null,
SoBTDoi1 INT not null,
SoBTDoi2 INT not null)
--drop table Tbl_KQTHIDAU
GO
CREATE TABLE Tbl_BXH(
MaDB NVARCHAR(10) PRIMARY KEY FOREIGN KEY REFERENCES Tbl_DOIBONG(MaDB),
SoTranThang int,
SoTranHoa int,
SoTranThua int,
SoBanThang int,
SoBanThua int,
Diem int)







SET DATEFORMAT dmy;
-- Thêm dữ liệu vào bảng Tbl_NHATAITRO
GO
INSERT INTO Tbl_NHATAITRO (MaNTT, TenNTT, SDT) VALUES 
    ('NTT001', N'Coca-Cola Việt Nam', 123456789),
    ('NTT002', N'PepsiCo Việt Nam', 987654321),
    ('NTT003', N'Vinamilk', 456123789),
    ('NTT004', N'Nestlé Việt Nam', 789456123),
    ('NTT005', N'Suntory Pepsico Việt Nam', 321654987),
    ('NTT006', N'Tân Hiệp Phát', 987321654),
    ('NTT007', N'Red Bull Việt Nam', 456789123),
    ('NTT008', N'Nước khoáng Lavie', 789123456),
    ('NTT009', N'Orangina', 654987321),
    ('NTT010', N'Aquafina Việt Nam', 123789456);

GO
INSERT INTO Tbl_TRONGTAI (MaTT, TenTT, NgaySinh, QuocTich) VALUES 
    ('TT001', N'Đặng Thanh Hạ ', '1990-01-01', N'Việt Nam'),
    ('TT002', N'Dương Văn Hiền', '1985-03-15', N'Việt Nam'),
    ('TT003', N'Võ Minh Trí ', '1982-07-20', N'Việt Nam'),
    ('TT004', N'Phùng Đình Dũng ', '1978-05-10', N'Việt Nam'),
    ('TT005', N'Đinh Văn Dũng', '1989-12-05', N'Việt Nam'),
    ('TT006', N'Nguyễn Đức Vũ', '1980-09-25', N'Việt Nam'),
    ('TT007', N'Nguyễn Hiền Triết ', '1975-11-30', N'Việt Nam'),
    ('TT008', N'Ngô Duy Lân', '1987-04-18', N'Việt Nam'),
    ('TT009', N'Hoàng Ngọc Hà', '1992-08-12', N'Việt Nam'),
    ('TT010', N'Nguyễn Mạnh Hải ', '1983-06-22', N'Việt Nam');
GO
-- Thêm dữ liệu vào bảng Tbl_DOIBONG
-- Thêm dữ liệu vào bảng Tbl_DOIBONG
INSERT INTO Tbl_DOIBONG (MaDB, TenDB, DiaChi, MaNTT) VALUES 
    ('DB001', N'Công An Hà Nội', N'Thủ Dầu Một, tỉnh Bình Dương', N'NTT001'),
    ('DB002', N'Hà Nội FC', N'Số 9 Trịnh Hoài Đức – Đống Đa – Hà Nội', N'NTT001'),
    ('DB003', N'Viettel FC', N'789 Đường LMN', N'NTT002'),
    ('DB004', N'Thanh Hóa', N'37 Lê Quý Đôn, Ba Đình, TP Thanh Hóa', N'NTT004'),
    ('DB005', N'Nam Định', N'27 Đặng Xuân Thiều, Tp Nam Định, tỉnh Nam Định.', N'NTT003'),
    ('DB006', N'Hải Phòng', N'Số 17 Lạch Tray, Ngô Quyền,Hải Phòng', N'NTT001'),
    ('DB007', N'Bình Định', N'236B Lê Hồng Phong - TP Quy Nhơn', N'NTT002'),
    ('DB008', N'Sông Lam Nghệ An', N'số 6 Đào Tấn, Tp Vinh, Nghệ An', N'NTT002'),
    ('DB009', N'Hoàng Anh Gia Lai', N'22 Quang Trung, đường Tây Sơn, Pleiku, Gia Lai', N'NTT002'),
	('DB010', N'Khánh Hòa', N'Đường Yersin, Vạn Thạnh, TP Nha Trang, Khánh Hòa', N'NTT001'),
	('DB011', N'Bình Dương', N'Đường 30/4, Đại lộ Bình Dương, TP Thủ Dầu Một, Bình Dương', N'NTT001'),
	('DB012', N'TP.HCM', N'30 Nguyễn Kim, P6, Q10, TPHCM', N'NTT001'),
	('DB013', N'Quảng Nam', N'Tổ 8 phường Hòa Hưng, TP Tam Kỳ, Quảng Nam', N'NTT001'),
    ('DB014', N'Bình Định', N'236B Lê Hồng Phong - TP Quy Nhơn', N'NTT001');
GO
-- Thêm dữ liệu vào bảng Tbl_BANHUANLUYEN
INSERT INTO Tbl_BANHUANLUYEN (MaBHL, TenBHL, ChucVu, MaDB) VALUES 
    ('BHL001', N'Kiatisuk Senamuang', N'HLV trưởng', 'DB001'),
    ('BHL002', N'Daiki Iwamasa', N'HLV trưởng', 'DB002'),
    ('BHL003', N'Nguyễn Đức Thắng', N'HLV trưởng', 'DB003'),
    ('BHL004', N'Popov Velizar Emilov', N'HLV trưởng', 'DB004'),
    ('BHL005', N'Vũ Hồng Việt', N'HLV trưởng', 'DB005'),
    ('BHL006', N'Chu Đình Nghiêm', N'HLV trưởng', 'DB006'),
    ('BHL007', N'Bùi Đoàn Quang Huy', N'HLV trưởng', 'DB007'),
    ('BHL008', N'Phạm Anh Tuấn', N'HLV trưởng', 'DB008'),
    ('BHL009', N'Vũ Tiến Thành', N'HLV trưởng', 'DB009'),
	('BHL010', N'Trần Trọng Bình', N'HLV trưởng', 'DB010'),
    ('BHL011', N'Lê Huỳnh Đức', N'HLV trưởng', 'DB011'),
    ('BHL012', N'Phùng Thanh Phương', N'HLV trưởng', 'DB012'),
	('BHL013', N'Văn Sỹ Sơn', N'HLV trưởng', 'DB013'),
	('BHL014', N'Bùi Đoàn Quang Huy', N'HLV trưởng', 'DB014');

	-- Thêm dữ liệu vào bảng tbl_SVD
GO
INSERT INTO Tbl_SVD (MaSVD, TenSVD, SucChua, DiaChi) VALUES 
    ('SVD001', N'SVĐ Hàng Đẫy', 19500, N'Số 9 Trịnh Hoài Đức, P. Cát Linh, Q. Đống Đa, TP Hà Nội'),
    ('SVD002', N'SVĐ Thanh Hóa', 14000, N'37 Lê Quý Đôn, Ba Đình, TP Thanh Hóa, Thanh Hóa.'),
    ('SVD003', N'SVĐ Hàng Đẫy', 19500, N'Số 9 Trịnh Hoài Đức, P. Cát Linh, Q. Đống Đa, TP Hà Nội'),
    ('SVD004', N'SVĐ Lạch Tray', 30000, N'Số 17 Lạch Tray, Ngô Quyền,Hải Phòng'),
    ('SVD005', N'SVĐ Bình Dương', 15000, N' Đường 30/4, Đại lộ Bình Dương, TP Thủ Dầu Một, Bình Dương'),
	('SVD006', N'SVĐ Pleiku', 10000, N'22 Quang Trung, đường Tây Sơn, Pleiku, Gia Lai'),
    ('SVD007', N'SVĐ Quảng Nam', 15000, N'Tổ 8 phường Hòa Hưng, TP Tam Kỳ, Quảng Nam'),
    ('SVD008', N'SVĐ Hà Tĩnh', 10000, N'Số 5 đường Nguyễn Biểu, P.Nam Hà, Hà Tĩnh'),
	('SVD009', N'SVĐ 19/8 Nha Trang ', 18000 , N'Đường Yersin, Vạn Thạnh, TP Nha Trang, Khánh Hòa'),
    ('SVD010', N'SVĐ Quy Nhơn', 16000, N'236B Lê Hồng Phong - TP Quy Nhơn'),
    ('SVD011', N'SVĐ Vinh', 20000 , N'Số 5 đường Nguyễn Biểu, P.Nam Hà, Hà Tĩnh'),
	('SVD012', N'SVĐ Thiên Trường ', 22000, N'Số 5 Đặng Xuân Thiều, phường Vị Hoàng, TP Nam Định, Nam Định'),
	('SVD013', N'SVĐ Thống Nhất', 15000, N'30 Nguyễn Kim, P6, Q10, TPHCM'),
	('SVD014', N'SVĐ Hàng Đẫy', 19500, N'Số 9 Trịnh Hoài Đức, P. Cát Linh, Q. Đống Đa, TP Hà Nội');

INSERT INTO Tbl_CAUTHU (MaCT, TenCT, ViTri, SoAo, MaDB) VALUES 
--DB001
    ('CT001', N'Filip Nguyen', N'GK', 1, 'DB001'),
    ('CT002', N'Huỳnh Tấn Sinh', N'CB', 7, 'DB001'),
	('CT003', N'Hồ Tấn Tài', N'RB', 5, 'DB001'),   
    ('CT004', N'Đoàn Văn Hậu', N'CDM', 9, 'DB001'),
	('CT005', N'Trương Văn Thiết', N'CAM', 6, 'DB001'),
    ('CT006', N'Lê Phạm Thành Long', N'LB', 8, 'DB001'),
	('CT007', N'Hoàng Văn Toản', N'CF', 11, 'DB001'),
    ('CT008', N'Bùi Tiến Dụng', N'RW', 14, 'DB001'),
	('CT009', N'Fialho De Aquino Junior Janioi', N'CM', 4, 'DB001'),
    ('CT010', N'Hồ Ngọc Thắng', N'CM', 3, 'DB001'),
	('CT011', N'Nguyễn Quang Hải', N'GK', 19, 'DB001'),

--DB002
	('CT012', N'Nguyễn Văn Hoàng', N'GK', 1, 'DB002'),
    ('CT013', N'Đậu Văn Toàn', N'CAM', 8, 'DB002'),
	('CT014', N'Đỗ Duy Mạnh', N'RW', 5, 'DB002'),   
    ('CT015', N'Nguyễn Văn Quyết', N'ST', 9, 'DB002'),
	('CT016', N'Nguyễn Thành Chung', N'RW', 6, 'DB002'),
    ('CT017', N'Nguyễn Hai Long', N'CAM', 14, 'DB002'),
	('CT018', N'Ryan Ha', N'ST', 84, 'DB002'),
    ('CT019', N'Vũ Đình Hai', N'CDM', 14, 'DB002'),
	('CT020', N'Đào Văn Nam', N'CAM', 4, 'DB002'),
    ('CT021', N'Lê Văn Xuân', N'LW', 3, 'DB002'),
	('CT022', N'Tagueu Tadjo Diederrick Joel', N'ST', 91, 'DB002'),
--DB003
	('CT023', N'Nguyễn Văn Hoàng', N'GK', 1, 'DB003'),
    ('CT024', N'Đậu Văn Toàn', N'LW', 8, 'DB003'),
	('CT025', N'Đỗ Duy Mạnh', N'RW', 5, 'DB003'),   
    ('CT026', N'Nguyễn Văn Quyết', N'ST', 9, 'DB003'),
	('CT027', N'Nguyễn Thành Chung', N'RW', 6, 'DB003'),
--DB004
    ('CT028', N'Nguyễn Hai Long', N'LB', 14, 'DB004'),
	('CT029', N'Ryan Ha', N'ST', 84, 'DB004'),
    ('CT030', N'Vũ Đình Hai', N'RW', 14, 'DB004'),
	('CT031', N'Đào Văn Nam', N'LW', 4, 'DB004'),
    ('CT032', N'Lê Văn Xuân', N'LW', 3, 'DB004'),
	('CT033', N'Tagueu Tadjo Diederrick Joel', N'CF', 19, 'DB004'),

--DB005
	('CT034', N'Đinh Xuân Khải', N'ST', 2, 'DB005'),
    ('CT035', N'Dương Thanh Hào', N'CB', 3, 'DB005'),
	('CT036', N'Lucas Alves de Araujo', N'GK', 4, 'DB005'),   
    ('CT037', N'Nguyễn Văn Toàn', N'ST', 9, 'DB005'),
	('CT038', N'Trần Nguyên Mạnh', N'CDM', 26, 'DB005'),

--DB006
    ('CT039', N'Mpande Joseph Mbolimbo', N'Tiền đạo	', 7, 'DB006'),
	('CT040', N'Dương Văn Khoa', N'RB', 20, 'DB006'),

--DB007
	('CT041', N'Đặng Văn Lâm', N'CM', 1, 'DB007'),
    ('CT042', N'Trần Đình Trọng', N'LW', 12, 'DB007'),

--DB008
    ('CT043', N'Phan Xuân Đại', N'ST', 21, 'DB008'),
	('CT044', N'Phan Bá Quyền', N'GK', 19, 'DB008'),

--DB009
	('CT045', N'Huỳnh Tấn Tài', N'ST', 17, 'DB009'),
    ('CT046', N'Đinh Thanh Bình', N'LW', 9, 'DB009'),

--DB0010
    ('CT047', N'Nguyễn Thành Nhân', N'GK', 7, 'DB010'),
	('CT048', N'Leazard Watz Landy', N'LB', 22, 'DB010'),

--DB0011
	('CT049', N'Quế Ngọc Hải', N'RW', 3, 'DB011'),
    ('CT050', N'Trần Đình Khương', N'LW', 22, 'DB011'),
--DB0012
    ('CT051', N'Nguyễn Minh Tùng', N'LB',5, 'DB012'),
	('CT052', N'Timite Cheick Aymar', N'CAM', 10, 'DB012'),

--DB0013
	('CT053', N'Nguyễn Văn Công', N'ST', 1, 'DB013'),
    ('CT054', N'Phan Thanh Hậu', N'GK', 8, 'DB013'),


--DB0014
    ('CT055', N'Nguyễn Vũ Linh', N'GK', 12, 'DB014'),
	('CT056', N'Nguyễn Trọng Hoàng', N'ST', 89, 'DB014')



------------------------Them Du lieu Bang Lich Thi Dau---------------------------------
GO
Insert into Tbl_LICHTHIDAU(MaTD,MaDB,MaSVD,MaTT,Doi1,Doi2,NgayThiDau,GioTD) values
                          ('TD001',null,'SVD001','TT001','DB001','DB002','2024-05-1','15:30:00'),
						  ('TD002',null,'SVD002','TT002','DB003','DB004','2024-05-1','16:30:00'),
						  ('TD003',null,'SVD003','TT003','DB005','DB006','2024-05-1','17:30:00'),
						  ('TD004',null,'SVD004','TT004','DB007','DB008','2024-05-5','15:30:00'),
						  ('TD005',null,'SVD005','TT005','DB001','DB003','2024-05-5','16:30:00'),
						  ('TD006',null,'SVD006','TT006','DB009','DB010','2024-05-5','17:30:00'),
						  ('TD007',null,'SVD007','TT007','DB011','DB012','2024-05-10','15:30:00'),
						  ('TD008',null,'SVD008','TT001','DB013','DB014','2024-05-10','16:30:00'),
						  ('TD009',null,'SVD009','TT002','DB014','DB008','2024-05-10','17:30:00')
GO
INSERT INTO Tbl_BXH (MaDB, SoTranThang, SoTranHoa, SoTranThua, SoBanThang, SoBanThua, Diem)
SELECT MaDB, 0, 0, 0, 0, 0, 0 
FROM Tbl_DOIBONG;
--------------------------------STORE-------------------------------------------
--Trigger cho thu tuc CapNhatDoiBong vao BXH
GO
CREATE TRIGGER Trigger_ThemDoiBongMoi
ON Tbl_DOIBONG
AFTER INSERT
AS
BEGIN
    -- Insert dữ liệu mới vào bảng xếp hạng
    INSERT INTO Tbl_BXH (MaDB, SoTranThang, SoTranHoa, SoTranThua, SoBanThang, SoBanThua, Diem)
    SELECT 
        MaDB, 
        0, 
        0, 
        0, 
        0, 
        0, 
        0 
    FROM inserted;
END;
---Cầu thủ trong đội bóng
GO
CREATE PROC SP_LayCauthuDoibong
	@MaDB NVARCHAR(10)
AS
BEGIN
	SELECT	
		db.TenDB AS 'Tên Đội Bóng',
		ct.MaCT AS 'Mã Cầu Thủ',
		ct.TenCT AS 'Tên Cầu Thủ',
		ct.ViTri AS 'Vị Trí Cầu Thủ',
		ct.SoAo AS 'Số Áo'
	FROM Tbl_DOIBONG db
	INNER JOIN Tbl_CAUTHU ct ON db.MaDB = ct.MaDB
	WHERE db.MaDB = @MaDB;
END;
------Lấy DS nhà tài trợ-----------
GO
CREATE PROCEDURE sp_LayDSNTTDB
AS
BEGIN
    SELECT 
        ntt.MaNTT AS 'Mã NTT',
        ntt.TenNTT AS 'Tên nhà tài trợ',
        db.TenDB AS 'Tên đội bóng'
    FROM 
        Tbl_NHATAITRO ntt
    LEFT JOIN 
        Tbl_DOIBONG db ON ntt.MaNTT = db.MaNTT;
END;
-------Lấy DS Sân Vận Động--------
GO
CREATE PROC sp_LayDSSVD
AS
BEGIN
	SELECT
		MaSVD AS 'Mã SVD',
		TenSVD AS 'Tên SVD',
		SucChua AS 'Sức Chứa',
		DiaChi AS 'Địa Chỉ'
	FROM Tbl_SVD;
END;
-----------------------------Lịch thi đấu--------------------------------------
GO
CREATE PROCEDURE sp_LichThiDau
AS
BEGIN
    SELECT 
        db1.TenDB AS 'Tên Đội 1',
        db2.TenDB 'Tên Đội 2',
        svd.TenSVD AS 'Sân Vận Động',
        tt.TenTT AS 'Trọng Tài',
        NgayThiDau AS 'Ngày Thi Đấu',
        GioTD AS 'Giờ Thi Đấu'
    FROM 
        Tbl_LICHTHIDAU lich
    INNER JOIN 
        Tbl_DOIBONG db1 ON lich.Doi1 = db1.MaDB
    INNER JOIN 
        Tbl_DOIBONG db2 ON lich.Doi2 = db2.MaDB
    INNER JOIN 
        Tbl_SVD svd ON lich.MaSVD = svd.MaSVD
    INNER JOIN 
        Tbl_TRONGTAI tt ON lich.MaTT = tt.MaTT;
END;
exec sp_LichThiDau
------------------------Kết quả thi đấu---------------------------------------
GO
CREATE PROCEDURE sp_KetQuaThiDau
AS
BEGIN
    SELECT 
        LH.NgayThiDau,
        LH.GioTD,
        SV.TenSVD ,
        DB1.TenDB,
        DB2.TenDB,
        KQ.SoThePhatDoi1,
        KQ.SoThePhatDoi2,
        KQ.SoBTDoi1,
        KQ.SoBTDoi2
    FROM 
        Tbl_LICHTHIDAU AS LH
    INNER JOIN 
        Tbl_SVD AS SV ON LH.MaSVD = SV.MaSVD
    INNER JOIN 
        Tbl_KQTHIDAU AS KQ ON LH.MaTD = KQ.MaTD
    INNER JOIN 
        Tbl_DOIBONG AS DB1 ON LH.Doi1 = DB1.MaDB
    INNER JOIN 
        Tbl_DOIBONG AS DB2 ON LH.Doi2 = DB2.MaDB
END;
----------------------------------------------------------------------------------------------------------
--drop proc sp_LayBXH
GO
CREATE PROCEDURE sp_CapNhatBXH
AS
BEGIN
    UPDATE Tbl_BXH
    SET SoTranThang = (SELECT COUNT(*) FROM 
                            (SELECT Doi1 AS MaDB, SoBTDoi1, SoBTDoi2 FROM Tbl_KQTHIDAU
                             UNION ALL
                             SELECT Doi2 AS MaDB, SoBTDoi2, SoBTDoi1 FROM Tbl_KQTHIDAU) AS KQ
                       WHERE Tbl_BXH.MaDB = KQ.MaDB AND KQ.SoBTDoi1 > KQ.SoBTDoi2),
        SoTranThua = (SELECT COUNT(*) FROM 
                            (SELECT Doi1 AS MaDB, SoBTDoi1, SoBTDoi2 FROM Tbl_KQTHIDAU
                             UNION ALL
                             SELECT Doi2 AS MaDB, SoBTDoi2, SoBTDoi1 FROM Tbl_KQTHIDAU) AS KQ
                      WHERE Tbl_BXH.MaDB = KQ.MaDB AND KQ.SoBTDoi1 < KQ.SoBTDoi2),
        SoTranHoa = (SELECT COUNT(*) FROM 
                            (SELECT Doi1 AS MaDB, SoBTDoi1, SoBTDoi2 FROM Tbl_KQTHIDAU
                             UNION ALL
                             SELECT Doi2 AS MaDB, SoBTDoi2, SoBTDoi1 FROM Tbl_KQTHIDAU) AS KQ
                     WHERE Tbl_BXH.MaDB = KQ.MaDB AND KQ.SoBTDoi1 = KQ.SoBTDoi2),
        Diem = ((SELECT COUNT(*) * 3 FROM 
                            (SELECT Doi1 AS MaDB, SoBTDoi1, SoBTDoi2 FROM Tbl_KQTHIDAU
                             UNION ALL
                             SELECT Doi2 AS MaDB, SoBTDoi2, SoBTDoi1 FROM Tbl_KQTHIDAU) AS KQ
                 WHERE Tbl_BXH.MaDB = KQ.MaDB AND KQ.SoBTDoi1 > KQ.SoBTDoi2) +
                (SELECT COUNT(*) FROM 
                            (SELECT Doi1 AS MaDB, SoBTDoi1, SoBTDoi2 FROM Tbl_KQTHIDAU
                             UNION ALL
                             SELECT Doi2 AS MaDB, SoBTDoi2, SoBTDoi1 FROM Tbl_KQTHIDAU) AS KQ
                 WHERE Tbl_BXH.MaDB = KQ.MaDB AND KQ.SoBTDoi1 = KQ.SoBTDoi2)),
        SoBanThang = (SELECT SUM(Goals) FROM 
                            (SELECT Doi1 AS MaDB, SoBTDoi1 AS Goals FROM Tbl_KQTHIDAU
                             UNION ALL
                             SELECT Doi2 AS MaDB, SoBTDoi2 AS Goals FROM Tbl_KQTHIDAU) AS KQ
                       WHERE Tbl_BXH.MaDB = KQ.MaDB),
        SoBanThua = (SELECT SUM(Goals) FROM 
                            (SELECT Doi1 AS MaDB, SoBTDoi2 AS Goals FROM Tbl_KQTHIDAU
                             UNION ALL
                             SELECT Doi2 AS MaDB, SoBTDoi1 AS Goals FROM Tbl_KQTHIDAU) AS KQ
                      WHERE Tbl_BXH.MaDB = KQ.MaDB)
    FROM Tbl_BXH;
END;
---Hàm TRIGGER TỰ CẬP NHẬP-----------
GO
	CREATE TRIGGER tr_CapNhatBXH_CapNhatDiem
	ON Tbl_KQTHIDAU
	AFTER INSERT, UPDATE, DELETE -- Trigger sẽ được kích hoạt sau các thao tác INSERT, UPDATE, DELETE trên bảng Tbl_KQTHIDAU
	AS
BEGIN
    EXEC sp_CapNhatBXH; -- Gọi thủ tục CapNhatBXH để cập nhật bảng BXH sau khi có thay đổi trong bảng KQTHIDAU
END;
----Hàm Sắp Xếp BXH-------------
GO
CREATE PROCEDURE sp_SapXepBXH_GiamDanDiem
AS
BEGIN
    SELECT   
        bxh.MaDB AS 'Mã Đội Bóng',
		db.TenDB AS 'Tên Đội Bóng',
        bxh.SoTranThang AS 'Số Trận Thắng',
        bxh.SoTranHoa AS 'Số Trận Hòa',
        bxh.SoTranThua AS 'Số Trận Thua',
        bxh.SoBanThang AS 'Số Bàn Thắng',
        bxh.SoBanThua AS 'Số Bàn Thua',
        bxh.Diem AS 'Điểm'
    FROM Tbl_BXH bxh
    INNER JOIN Tbl_DOIBONG db ON bxh.MaDB = db.MaDB
    ORDER BY bxh.Diem DESC;
END;

--Top 5 Cầu Thủ ghi nhiều bàn nhất
--chạy DB xog chạy Top5caauf thù ghi bàn -> trigger sắp xếp bảng xếp bạng
GO
CREATE PROCEDURE Top5CauThuGhiBan
AS
BEGIN
    SELECT TOP 5 
        C.TenCT AS 'TenCauThu',
        D.TenDB AS 'TenDoiBong',
        COUNT(B.MaBT) AS 'SoBanThang'
    FROM 
        Tbl_BANTHANG B
    INNER JOIN 
        Tbl_CAUTHU C ON B.MaCT = C.MaCT
    INNER JOIN 
        Tbl_DOIBONG D ON B.MaDB = D.MaDB
    GROUP BY 
        C.TenCT, D.TenDB
    ORDER BY 
        COUNT(B.MaBT) DESC;
END;
-- Tạo Trigger cho thủ tục SapXepBXH_GiamDanDiem
--Chạy db xong nhớ chạy phần này để được tự động cập nhật BXH
GO
CREATE TRIGGER tr_SapXepBXH_GiamDanDiem
ON Tbl_BXH
AFTER INSERT, UPDATE, DELETE -- Trigger sẽ được kích hoạt sau các thao tác INSERT, UPDATE, DELETE trên bảng Tbl_BXH
AS
BEGIN
    EXEC sp_SapXepBXH_GiamDanDiem; -- Gọi thủ tục SapXepBXH_GiamDanDiem để sắp xếp BXH sau khi có thay đổi trong bảng BXH
END;


EXEC Top5CauThuGhiBan;


