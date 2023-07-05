CREATE DATABASE PRN211_GroupProject
GO

USE PRN211_GroupProject
GO

CREATE TABLE Users(
	username varchar(10) PRIMARY KEY,
	password varchar(20),
	fullName nvarchar(30),
	gender BIT,
	createdAt Date
)
GO

CREATE TABLE PlayList(
	id int IDENTITY(1,1) PRIMARY KEY,
	name nvarchar(50),
	createdAt Date,
	description nvarchar(255)
)
GO

CREATE TABLE Song(
	id int IDENTITY(1,1) PRIMARY KEY,
	name nvarchar(50),
	singer nvarchar(30),
	YOP int,
	path varchar(255)
)
GO

CREATE TABLE PlayList_Song(
	play_list_id int,
	song_id int,
	PRIMARY KEY (play_list_id, song_id),
	FOREIGN KEY (play_list_id) REFERENCES PlayList(id),
	FOREIGN KEY (song_id) REFERENCES Song(id)
)
GO

INSERT INTO Song (name, singer, YOP, path) VALUES (N'Vài câu nói có khiến người thay đổi', 'Grey D x tlinh', 2022, 'D:\\PRN211_GroupProject\\PRN211_GroupProject\\assets\\songs\\1.mp3');
INSERT INTO Song (name, singer, YOP, path) VALUES (N'Dành cho em', 'Hoàng Dũng x Orange', 2023, 'D:\\PRN211_GroupProject\\PRN211_GroupProject\\assets\\songs\\2.mp3');
INSERT INTO Song (name, singer, YOP, path) VALUES (N'Nghe như tình yêu', 'MCK', 2023, 'D:\\PRN211_GroupProject\\PRN211_GroupProject\\assets\\songs\\3.mp3');
INSERT INTO Song (name, singer, YOP, path) VALUES (N'Đìu Anh Luôn Giữ Kín Trong Tym', 'MCK x tlinh', 2022,'D:\\PRN211_GroupProject\\PRN211_GroupProject\\assets\\songs\\4.mp3');
INSERT INTO Song (name, singer, YOP, path) VALUES (N'Nếu lúc đó', 'tlinh', 2023, 'D:\\PRN211_GroupProject\\PRN211_GroupProject\\assets\\songs\\5.mp3');
INSERT INTO Song (name, singer, YOP, path) VALUES (N'Đâu ai cần', 'Wxrdie', 2022, 'D:\\PRN211_GroupProject\\PRN211_GroupProject\\assets\\songs\\6.mp3');
INSERT INTO Song (name, singer, YOP, path) VALUES (N'Harder', 'Wxrdie', 2021, 'D:\\PRN211_GroupProject\\PRN211_GroupProject\\assets\\songs\\7.mp3');

INSERT INTO PlayList (name, createdAt, description) VALUES (N'PlayList nghe vào những ngày mưa', '2023-07-04', N'Nếu lúc đó em không buông tay, Nếu lúc đó anh không lung lay');
INSERT INTO PlayList (name, createdAt, description) VALUES (N'PlayList động lực', '2023-07-04', N'Tất cả chúng mày đều bị điên hết rồi, tất cả kịch bản đã được biên hết rồi');