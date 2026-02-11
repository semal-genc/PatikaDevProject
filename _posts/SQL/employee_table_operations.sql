-- 1.test veritabanınızda employee isimli sütun bilgileri id(INTEGER), name VARCHAR(50), birthday DATE, email VARCHAR(100) olan bir tablo oluşturalım.
CREATE TABLE employee (
	id SERIAL PRIMARY KEY,
	name VARCHAR(50) NOT NULL,
	birthdate DATE,
	email VARCHAR(100)
);


-- 2.Oluşturduğumuz employee tablosuna 'Mockaroo' servisini kullanarak 50 adet veri ekleyelim.
insert into employee (name, birthdate, email) values ('Willette Mesant', '1979-05-17', 'wmesant0@hatena.ne.jp');
insert into employee (name, birthdate, email) values ('Catina Teare', '1949-02-04', null);
insert into employee (name, birthdate, email) values ('Tailor MacGraith', '1995-02-07', 'tmacgraith2@squidoo.com');
insert into employee (name, birthdate, email) values ('Fanchon Coleshill', '1971-11-12', null);
insert into employee (name, birthdate, email) values ('Lind Perree', '1948-06-15', 'lperree4@imgur.com');
insert into employee (name, birthdate, email) values ('Lisette Tape', null, 'ltape5@hexun.com');
insert into employee (name, birthdate, email) values ('Hyman Wardlaw', null, 'hwardlaw6@microsoft.com');
insert into employee (name, birthdate, email) values ('Clemens Devons', '1988-07-01', 'cdevons7@about.com');
insert into employee (name, birthdate, email) values ('Cesya Middup', '1906-06-20', 'cmiddup8@craigslist.org');
insert into employee (name, birthdate, email) values ('Grove Seaborne', '1960-11-11', 'gseaborne9@sphinn.com');
insert into employee (name, birthdate, email) values ('Angelita Accum', '1969-03-09', 'aaccuma@uol.com.br');
insert into employee (name, birthdate, email) values ('Angelika Heasly', '1901-10-01', 'aheaslyb@360.cn');
insert into employee (name, birthdate, email) values ('Tanny Dukelow', '1946-09-03', 'tdukelowc@163.com');
insert into employee (name, birthdate, email) values ('Susy Deakan', '1948-10-29', 'sdeakand@census.gov');
insert into employee (name, birthdate, email) values ('Drucy Bramham', '1994-02-10', 'dbramhame@qq.com');
insert into employee (name, birthdate, email) values ('Pete Innis', null, 'pinnisf@etsy.com');
insert into employee (name, birthdate, email) values ('Adriane Mathon', '1926-07-27', 'amathong@storify.com');
insert into employee (name, birthdate, email) values ('Mickie Hanscome', null, 'mhanscomeh@naver.com');
insert into employee (name, birthdate, email) values ('Marena Krysiak', '1925-09-20', 'mkrysiaki@thetimes.co.uk');
insert into employee (name, birthdate, email) values ('Max Larwell', '1965-09-21', 'mlarwellj@furl.net');
insert into employee (name, birthdate, email) values ('Malory Fransemai', '1949-06-28', 'mfransemaik@stanford.edu');
insert into employee (name, birthdate, email) values ('Urbain Tillyer', null, 'utillyerl@google.it');
insert into employee (name, birthdate, email) values ('Gianna Humphrys', '1990-03-27', 'ghumphrysm@irs.gov');
insert into employee (name, birthdate, email) values ('Dorice Jeanin', '2008-01-03', 'djeaninn@nytimes.com');
insert into employee (name, birthdate, email) values ('Tarah Bairnsfather', '1999-07-12', 'tbairnsfathero@alexa.com');
insert into employee (name, birthdate, email) values ('Haskel Gini', '2005-02-18', 'hginip@sourceforge.net');
insert into employee (name, birthdate, email) values ('Angel Bullier', null, 'abullierq@uiuc.edu');
insert into employee (name, birthdate, email) values ('Glynis Birkin', '1946-04-23', 'gbirkinr@scribd.com');
insert into employee (name, birthdate, email) values ('Minerva Dymoke', '1994-04-17', 'mdymokes@yolasite.com');
insert into employee (name, birthdate, email) values ('Marketa Evans', '1992-11-25', 'mevanst@theglobeandmail.com');
insert into employee (name, birthdate, email) values ('Friederike Chowne', '1918-01-16', 'fchowneu@epa.gov');
insert into employee (name, birthdate, email) values ('Gerardo Safe', '1977-02-04', 'gsafev@washington.edu');
insert into employee (name, birthdate, email) values ('Genna McKevin', '1970-01-17', 'gmckevinw@engadget.com');
insert into employee (name, birthdate, email) values ('Sara Brimfield', '1908-03-02', null);
insert into employee (name, birthdate, email) values ('Lurline Beazley', '1956-06-04', 'lbeazleyy@joomla.org');
insert into employee (name, birthdate, email) values ('Byrom Boyda', null, 'bboydaz@prnewswire.com');
insert into employee (name, birthdate, email) values ('Rebeca Alesbrook', '1972-12-17', 'ralesbrook10@imdb.com');
insert into employee (name, birthdate, email) values ('Marilyn Davoren', null, 'mdavoren11@exblog.jp');
insert into employee (name, birthdate, email) values ('Talyah Girvan', '1985-08-18', 'tgirvan12@engadget.com');
insert into employee (name, birthdate, email) values ('Rivalee Laurant', null, 'rlaurant13@engadget.com');
insert into employee (name, birthdate, email) values ('Sollie Robeiro', null, 'srobeiro14@mapquest.com');
insert into employee (name, birthdate, email) values ('Travis Rollett', '1915-05-02', 'trollett15@icio.us');
insert into employee (name, birthdate, email) values ('Sharity Batram', '1977-07-15', 'sbatram16@ifeng.com');
insert into employee (name, birthdate, email) values ('Madella Boustred', '1957-03-17', null);
insert into employee (name, birthdate, email) values ('Amara Bourtoumieux', null, 'abourtoumieux18@wikipedia.org');
insert into employee (name, birthdate, email) values ('Vitia Flori', '1968-02-29', 'vflori19@google.it');
insert into employee (name, birthdate, email) values ('Mackenzie Bentham3', null, 'mbentham1a@tmall.com');
insert into employee (name, birthdate, email) values ('Patrice Ferrie', '2004-04-14', 'pferrie1b@com.com');
insert into employee (name, birthdate, email) values ('Radcliffe Pilkinton', '2002-04-29', 'rpilkinton1c@dropbox.com');
insert into employee (name, birthdate, email) values ('Diandra Titcomb', null, 'dtitcomb1d@artisteer.com');


-- 3.Sütunların her birine göre diğer sütunları güncelleyecek 5 adet UPDATE işlemi yapalım.
UPDATE employee
SET name = 'Test Updated'
WHERE id IN (11,12,17,27,45)
RETURNING *;


-- 4.Sütunların her birine göre ilgili satırı silecek 5 adet DELETE işlemi yapalım.
DELETE FROM employee
WHERE name = 'Test Updated';
