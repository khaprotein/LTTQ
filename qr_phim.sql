drop database QuanlyDoanhthuphim
create database QuanlyDoanhthuphim

use QuanlyDoanhthuphim

create table Phim(
	madon varchar(10) primary key,
	tenphim nvarchar(255),
	quocgia nvarchar(50),
	theloai nvarchar(20),
	NCC datetime ,
	dotuoi int 
);

create table phim2d(
	madon varchar(10) primary key,
	tendon varchar(5),
	PTGD float,
	FOREIGN KEY (madon) REFERENCES Phim(madon)
);

create table phim3d(
	madon varchar(10) primary key,
	tendon varchar(5),
	PTDB float,
	FOREIGN KEY (madon) REFERENCES Phim(madon)
);

-- Insert d? li?u vào b?ng Phim
INSERT INTO Phim (madon, tenphim, quocgia, theloai, NCC, dotuoi)
VALUES ('P001', N'TenPhim1', N'QuocGia1', N'TheLoai1', '2023-01-01', 18),
('P002', N'TenPhim2', N'QuocGia2', N'TheLoai2', '2023-01-02', 12);

-- Insert d? li?u vào b?ng phim2d
INSERT INTO phim2d (madon, PTGD)
VALUES ('P001', 1.5);

-- Insert d? li?u vào b?ng phim3d
INSERT INTO phim3d (madon, PTDB)
VALUES ('P002', 2.0);

