/*
SQLyog Ultimate v9.50 
MySQL - 5.5.5-10.1.13-MariaDB : Database - db_jualtunai
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`db_jualtunai` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `db_jualtunai`;

/*Table structure for table `tb_barang` */

DROP TABLE IF EXISTS `tb_barang`;

CREATE TABLE `tb_barang` (
  `kode` varchar(32) NOT NULL,
  `nama` varchar(256) NOT NULL DEFAULT '',
  `kategori` varchar(256) NOT NULL DEFAULT '',
  `satuan` varchar(256) NOT NULL DEFAULT '',
  `hargabeli` int(11) NOT NULL DEFAULT '0',
  `hargajual` int(11) NOT NULL DEFAULT '0',
  `jumlah` int(11) NOT NULL DEFAULT '0',
  `laba` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`kode`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Data for the table `tb_barang` */

insert  into `tb_barang`(`kode`,`nama`,`kategori`,`satuan`,`hargabeli`,`hargajual`,`jumlah`,`laba`) values ('B00001','Chais','Beverages','10 boxes x 20 bags',18000,19800,82,1800),('B00002','Chang','Beverages','24 - 12 oz bottles',19000,20900,44,1900),('B00003','Aniseed Syrup','Condiments','12 - 550 ml bottles',10000,11000,78,1000),('B00004','Chef Anton\'s Cajun Seasoning','Condiments','48 - 6 oz jars',22000,24200,57,2200),('B00005','Chef Anton\'s Gumbo Mix','Condiments','36 boxes',21000,23100,51,2100),('B00006','Grandma\'s Boysenberry Spread','Condiments','12 - 8 oz jars',25000,27500,91,2500),('B00007','Uncle Bob\'s Organic Dried Pears','Produce','12 - 1 lb pkgs.',30000,33000,95,3000),('B00008','Northwoods Cranberry Sauce','Condiments','12 - 12 oz jars',40000,44000,4,4000),('B00009','Mishi Kobe Niku','Meat/Poultry','18 - 500 g pkgs.',97000,106700,36,9700),('B00010','Ikura','Seafood','12 - 200 ml jars',31000,34100,66,3100),('B00011','Queso Cabrales','Dairy Products','1 kg pkg.',21000,23100,23,2100),('B00012','Queso Manchego La Pastora','Dairy Products','10 - 500 g pkgs.',38000,41800,18,3800),('B00013','Konbu','Seafood','2 kg box',6000,6600,21,600),('B00014','Tofu','Produce','40 - 100 g pkgs.',23000,25300,49,2300),('B00015','Genen Shouyu','Condiments','24 - 250 ml bottles',16000,17600,85,1600),('B00016','Pavlova','Confections','32 - 500 g boxes',17000,18700,75,1700),('B00017','Alice Mutton','Meat/Poultry','20 - 1 kg tins',39000,42900,20,3900),('B00018','Carnarvon Tigers','Seafood','16 kg pkg.',63000,69300,76,6300),('B00019','Teatime Chocolate Biscuits','Confections','10 boxes x 12 pieces',9000,9900,20,900),('B00020','Sir Rodney\'s Marmalade','Confections','30 gift boxes',81000,89100,72,8100),('B00021','Sir Rodney\'s Scones','Confections','24 pkgs. x 4 pieces',10000,11000,99,1000),('B00022','Gustaf\'s Knäckebröd','Grains/Cereals','24 - 500 g pkgs.',21000,23100,79,2100),('B00023','Tunnbröd','Grains/Cereals','12 - 250 g pkgs.',9000,9900,97,900),('B00024','Guaraná Fantástica','Beverages','12 - 355 ml cans',5000,5500,48,500),('B00025','NuNuCa Nuß-Nougat-Creme','Confections','20 - 450 g glasses',14000,15400,49,1400),('B00026','Gumbär Gummibärchen','Confections','100 - 250 g bags',31000,34100,2,3100),('B00027','Schoggi Schokolade','Confections','100 - 100 g pieces',44000,48400,61,4400),('B00028','Rössle Sauerkraut','Produce','25 - 825 g cans',46000,50600,100,4600),('B00029','Thüringer Rostbratwurst','Meat/Poultry','50 bags x 30 sausgs.',124000,136400,17,12400),('B00030','Nord-Ost Matjeshering','Seafood','10 - 200 g glasses',26000,28600,85,2600),('B00031','Gorgonzola Telino','Dairy Products','12 - 100 g pkgs',13000,14300,75,1300),('B00032','Mascarpone Fabioli','Dairy Products','24 - 200 g pkgs.',32000,35200,20,3200),('B00033','Geitost','Dairy Products','500 g',3000,3300,74,300),('B00034','Sasquatch Ale','Beverages','24 - 12 oz bottles',14000,15400,8,1400),('B00035','Steeleye Stout','Beverages','24 - 12 oz bottles',18000,19800,22,1800),('B00036','Inlagd Sill','Seafood','24 - 250 g jars',19000,20900,83,1900),('B00037','Gravad lax','Seafood','12 - 500 g pkgs.',26000,28600,51,2600),('B00038','Côte de Blaye','Beverages','12 - 75 cl bottles',264000,290400,5,26400),('B00039','Chartreuse verte','Beverages','750 cc per bottle',18000,19800,73,1800),('B00040','Boston Crab Meat','Seafood','24 - 4 oz tins',18000,19800,49,1800),('B00041','Jack\'s New England Clam Chowder','Seafood','12 - 12 oz cans',10000,11000,28,1000),('B00042','Singaporean Hokkien Fried Mee','Grains/Cereals','32 - 1 kg pkgs.',14000,15400,93,1400),('B00043','Ipoh Coffee','Beverages','16 - 500 g tins',46000,50600,81,4600),('B00044','Gula Malacca','Condiments','20 - 2 kg bags',19000,20900,24,1900),('B00045','Røgede sild','Seafood','1k pkg.',10000,11000,79,1000),('B00046','Spegesild','Seafood','4 - 450 g glasses',12000,13200,24,1200),('B00047','Zaanse koeken','Confections','10 - 4 oz boxes',10000,11000,82,1000),('B00048','Chocolade','Confections','10 pkgs.',13000,14300,39,1300),('B00049','Maxilaku','Confections','24 - 50 g pkgs.',20000,22000,47,2000),('B00050','Valkoinen suklaa','Confections','12 - 100 g bars',16000,17600,18,1600),('B00051','Manjimup Dried Apples','Produce','50 - 300 g pkgs.',53000,58300,48,5300),('B00052','Filo Mix','Grains/Cereals','16 - 2 kg boxes',7000,7700,86,700),('B00053','Perth Pasties','Meat/Poultry','48 pieces',33000,36300,86,3300),('B00054','Tourtière','Meat/Poultry','16 pies',7000,7700,72,700),('B00055','Pâté chinois','Meat/Poultry','24 boxes x 2 pies',24000,26400,3,2400),('B00056','Gnocchi di nonna Alice','Grains/Cereals','24 - 250 g pkgs.',38000,41800,99,3800),('B00057','Ravioli Angelo','Grains/Cereals','24 - 250 g pkgs.',20000,22000,88,2000),('B00058','Escargots de Bourgogne','Seafood','24 pieces',13000,14300,40,1300),('B00059','Raclette Courdavault','Dairy Products','5 kg pkg.',55000,60500,36,5500),('B00060','Camembert Pierrot','Dairy Products','15 - 300 g rounds',34000,37400,62,3400),('B00061','Sirop d\'érable','Condiments','24 - 500 ml bottles',29000,31900,100,2900),('B00062','Tarte au sucre','Confections','48 pies',49000,53900,13,4900),('B00063','Vegie-spread','Condiments','15 - 625 g jars',44000,48400,66,4400),('B00064','Wimmers gute Semmelknödel','Grains/Cereals','20 bags x 4 pieces',33000,36300,92,3300),('B00065','Louisiana Fiery Hot Pepper Sauce','Condiments','32 - 8 oz bottles',21000,23100,62,2100),('B00066','Louisiana Hot Spiced Okra','Condiments','24 - 8 oz jars',17000,18700,32,1700),('B00067','Laughing Lumberjack Lager','Beverages','24 - 12 oz bottles',14000,15400,73,1400),('B00068','Scottish Longbreads','Confections','10 boxes x 8 pieces',13000,14300,71,1300),('B00069','Gudbrandsdalsost','Dairy Products','10 kg pkg.',36000,39600,34,3600),('B00070','Outback Lager','Beverages','24 - 355 ml bottles',15000,16500,57,1500),('B00071','Fløtemysost','Dairy Products','10 - 500 g pkgs.',22000,24200,83,2200),('B00072','Mozzarella di Giovanni','Dairy Products','24 - 200 g pkgs.',35000,38500,43,3500),('B00073','Röd Kaviar','Seafood','24 - 150 g jars',15000,16500,69,1500),('B00074','Longlife Tofu','Produce','5 kg pkg.',10000,11000,14,1000),('B00075','Rhönbräu Klosterbier','Beverages','24 - 0.5 l bottles',8000,8800,64,800),('B00076','Lakkalikööri','Beverages','500 ml',18000,19800,80,1800),('B00077','Original Frankfurter grüne Soße','Condiments','12 boxes',13000,14300,4,1300);

/*Table structure for table `tb_detailjual` */

DROP TABLE IF EXISTS `tb_detailjual`;

CREATE TABLE `tb_detailjual` (
  `faktur` varchar(256) NOT NULL,
  `tanggal` date NOT NULL DEFAULT '0000-00-00',
  `kode` varchar(256) NOT NULL DEFAULT '',
  `nama` varchar(256) NOT NULL DEFAULT '',
  `jumlah` int(11) NOT NULL DEFAULT '0',
  `satuan` varchar(256) NOT NULL DEFAULT '',
  `hargajual` int(11) NOT NULL DEFAULT '0',
  `total` int(11) NOT NULL DEFAULT '0',
  `laba` int(11) NOT NULL DEFAULT '0',
  `operator` varchar(256) NOT NULL DEFAULT ''
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Data for the table `tb_detailjual` */

insert  into `tb_detailjual`(`faktur`,`tanggal`,`kode`,`nama`,`jumlah`,`satuan`,`hargajual`,`total`,`laba`,`operator`) values ('TR-20140903-0001','2014-09-03','BR001','Rinso',5,'Biji',12000,60000,10000,'Master'),('TR-20140903-0001','2014-09-03','BR012','Daia',2,'Biji',2000,4000,2000,'Master'),('TR-20140903-0002','2014-09-03','BR001','Rinso',1,'Biji',11500,11500,1500,'Master'),('TR-20140903-0002','2014-09-03','BR001','Rinso',1,'Biji',11500,11500,1500,'Master'),('TR-20140903-0002','2014-09-03','BR012','Daia',1,'Biji',2000,2000,1000,'Master'),('TR-20140904-0001','2014-09-04','BR012','Daia',1,'Biji',2000,2000,1000,'master'),('TR-20140904-0001','2014-09-04','BR012','Daia',1,'Biji',2000,2000,1000,'master'),('TR-20140904-0002','2014-09-04','BR012','Daia',1,'Biji',2000,2000,1000,'master'),('TR-20140904-0002','2014-09-04','BR001','Rinso',1,'Biji',11500,11500,1500,'master'),('TR-20140904-0003','2014-09-04','BR001','Rinso',1,'Biji',11500,11500,1500,'master'),('TR-20140904-0003','2014-09-04','BR012','Daia',1,'Biji',2000,2000,1000,'master'),('TR-20140904-0003','2014-09-04','BR001','Rinso',1,'Biji',11500,11500,1500,'master'),('TR-20140928-0001','2014-09-28','BR001','Rinso',1,'Biji',11500,11500,1500,'master'),('TR-20140928-0001','2014-09-28','BR012','Daia',2,'Biji',2000,4000,2000,'master'),('TR-20140929-0001','2014-09-29','BR00002','Rinso Cair',10,'Biji',1200,12000,2000,'master'),('TR-20140929-0002','2014-09-29','BR00002','Rinso Cair',7,'Biji',1200,8400,1400,'master'),('TR-20140929-0003','2014-09-29','BR001','Rinso',20,'Biji',11500,230000,228000,'master'),('TR-20140929-0004','2014-09-29','BR001','Rinso',1,'Biji',11500,11500,11400,'master'),('TR-20140929-0004','2014-09-29','BR012','Daia',1,'Biji',2000,2000,1900,'master'),('TR-20140930-0001','2014-09-30','BR00001','Aqua 600 ml',1,'Botol',2500,2500,500,'master'),('TR-20140930-0001','2014-09-30','BR00002','Rinso Cair',1,'Sachet',1200,1200,200,'master'),('TR-20140930-0001','2014-09-30','BR00003','Pond White Beauty',1,'Pcs',20000,20000,2000,'master'),('TR-20140930-0002','2014-09-30','BR00001','Aqua 600 ml',1,'Botol',2500,2500,500,'master'),('TR-20140930-0003','2014-09-30','BR00002','Rinso Cair',1,'Sachet',1200,1200,200,'master'),('TR-20141216-0001','2014-12-16','BR00001','Aqua 600 ml',1,'Botol',2500,2500,500,'master'),('TR-20161025-0001','2016-10-25','B00005','Chef Anton\'s Gumbo Mix',2,'36 boxes',23100,46200,4200,'master'),('TR-20161025-0001','2016-10-25','B00002','Chang',1,'24 - 12 oz bottles',20900,20900,1900,'master'),('TR-20161025-0001','2016-10-25','B00004','Chef Anton\'s Cajun Seasoning',1,'48 - 6 oz jars',24200,24200,2200,'master');

/*Table structure for table `tb_jual` */

DROP TABLE IF EXISTS `tb_jual`;

CREATE TABLE `tb_jual` (
  `faktur` varchar(32) NOT NULL,
  `tanggal` date NOT NULL DEFAULT '0000-00-00',
  `jam` time NOT NULL DEFAULT '00:00:00',
  `grandtotal` int(11) NOT NULL DEFAULT '0',
  `tunai` int(11) NOT NULL DEFAULT '0',
  `kembali` int(11) NOT NULL DEFAULT '0',
  `operator` varchar(256) NOT NULL DEFAULT '',
  `laba` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`faktur`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Data for the table `tb_jual` */

insert  into `tb_jual`(`faktur`,`tanggal`,`jam`,`grandtotal`,`tunai`,`kembali`,`operator`,`laba`) values ('TR-20140902-0001','2014-09-02','15:49:12',64000,70000,6000,'Master',12000),('TR-20140903-0001','2014-09-03','16:38:54',11500,12000,500,'Master',1500),('TR-20140903-0002','2014-09-03','17:09:45',13500,15000,1500,'Master',2500),('TR-20140904-0001','2014-09-04','05:32:51',4000,5000,1000,'master',2000),('TR-20140904-0002','2014-09-04','05:36:56',13500,14000,500,'master',2500),('TR-20140904-0003','2014-09-04','05:51:40',25000,25000,0,'master',4000),('TR-20140928-0001','2014-09-28','08:22:27',15500,20000,4500,'master',3500),('TR-20140929-0001','2014-09-29','13:06:42',12000,15000,3000,'master',2000),('TR-20140929-0002','2014-09-29','13:07:49',8400,10000,1600,'master',1400),('TR-20140929-0003','2014-09-29','15:20:35',230000,230000,0,'master',228000),('TR-20140929-0004','2014-09-29','15:21:17',13500,15000,1500,'master',13300),('TR-20140930-0001','2014-09-30','10:23:41',23700,25000,1300,'master',2700),('TR-20140930-0002','2014-09-30','10:27:38',2500,2500,0,'master',500),('TR-20140930-0003','2014-09-30','10:28:31',1200,1500,300,'master',200),('TR-20141216-0001','2014-12-16','19:45:12',2500,5000,2500,'master',500),('TR-20161025-0001','2016-10-25','15:27:47',91300,100000,8700,'master',8300);

/*Table structure for table `tb_kas` */

DROP TABLE IF EXISTS `tb_kas`;

CREATE TABLE `tb_kas` (
  `faktur` varchar(255) NOT NULL,
  `tanggal` date NOT NULL DEFAULT '0000-00-00',
  `jenis` varchar(255) NOT NULL DEFAULT 'pemasukan',
  `kategori` varchar(255) NOT NULL DEFAULT 'penjualan',
  `pemasukan` int(11) NOT NULL DEFAULT '0',
  `pengeluaran` int(11) NOT NULL DEFAULT '0',
  `keterangan` varchar(255) NOT NULL DEFAULT '-',
  `operator` varchar(255) NOT NULL DEFAULT '-',
  PRIMARY KEY (`faktur`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Data for the table `tb_kas` */

insert  into `tb_kas`(`faktur`,`tanggal`,`jenis`,`kategori`,`pemasukan`,`pengeluaran`,`keterangan`,`operator`) values ('TR-20140929-0002','2014-09-29','Pemasukan','Penjualan',8400,0,'Penjualan: TR-20140929-0002','master'),('KAS-20140929-00001','2014-09-29','Pemasukan','Pendapatan Lain-lain',10000,0,'dapet uang di jalan','master'),('KAS-20140929-00002','2014-09-29','Pengeluaran','Listrik',0,170000,'Listrik bulan september','master'),('TR-20140929-0003','2014-09-29','Pemasukan','Penjualan',230000,0,'Penjualan: TR-20140929-0003','master'),('TR-20140929-0004','2014-09-29','Pemasukan','Penjualan',13500,0,'Penjualan: TR-20140929-0004','master'),('TR-20140930-0001','2014-09-30','Pemasukan','Penjualan',23700,0,'Penjualan: TR-20140930-0001','master'),('TR-20140930-0002','2014-09-30','Pemasukan','Penjualan',2500,0,'Penjualan: TR-20140930-0002','master'),('TR-20140930-0003','2014-09-30','Pemasukan','Penjualan',1200,0,'Penjualan: TR-20140930-0003','master'),('TR-20141216-0001','2014-12-16','Pemasukan','Penjualan',2500,0,'Penjualan: TR-20141216-0001','master'),('TR-20161025-0001','2016-10-25','Pemasukan','Penjualan',91300,0,'Penjualan: TR-20161025-0001','master');

/*Table structure for table `tb_kategorikas` */

DROP TABLE IF EXISTS `tb_kategorikas`;

CREATE TABLE `tb_kategorikas` (
  `kategori` varchar(255) NOT NULL,
  `jenis` varchar(255) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Data for the table `tb_kategorikas` */

insert  into `tb_kategorikas`(`kategori`,`jenis`) values ('Listrik','pengeluaran'),('PDAM','pengeluaran'),('Pendapatan Lain-lain','pemasukan');

/*Table structure for table `tb_option` */

DROP TABLE IF EXISTS `tb_option`;

CREATE TABLE `tb_option` (
  `option_name` varchar(256) NOT NULL,
  `option_value` varchar(256) NOT NULL DEFAULT '',
  PRIMARY KEY (`option_name`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Data for the table `tb_option` */

insert  into `tb_option`(`option_name`,`option_value`) values ('header1','Nama Toko Anda aaa'),('header2','Jl. Abcdefghijklm No. 1234567'),('header3','Telp. 1234567890 Kota Anda'),('footer1','Periksa barang sebelum dibeli'),('footer2','Barang yang sudah dibeli'),('footer3','tidak bisa ditukar atau dikembalikan');

/*Table structure for table `tb_terms` */

DROP TABLE IF EXISTS `tb_terms`;

CREATE TABLE `tb_terms` (
  `term_name` varchar(255) NOT NULL,
  `term_taxonomy` varchar(255) NOT NULL DEFAULT 'kategori'
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Data for the table `tb_terms` */

insert  into `tb_terms`(`term_name`,`term_taxonomy`) values ('Confections','kategori'),('Condiments','kategori'),('Beverages','kategori'),('Biji','satuan'),('Kardus','satuan'),('Pcs','satuan'),('Sachet','satuan'),('Botol','satuan'),('Dairy Products','kategori'),('Grains/Cereals','kategori'),('Meat/Poultry','kategori'),('Produce','kategori'),('Seafood','kategori');

/*Table structure for table `tb_user` */

DROP TABLE IF EXISTS `tb_user`;

CREATE TABLE `tb_user` (
  `user` varchar(32) NOT NULL,
  `pass` varchar(32) NOT NULL DEFAULT '',
  `status` int(1) NOT NULL DEFAULT '0',
  `frmbrg` int(1) NOT NULL DEFAULT '0',
  `frmkat` int(1) NOT NULL DEFAULT '0',
  `frmsat` int(1) NOT NULL DEFAULT '0',
  `frmjual` int(1) NOT NULL DEFAULT '0',
  `frmlap` int(1) NOT NULL DEFAULT '0',
  `frmkas` int(1) NOT NULL DEFAULT '0',
  `frmpass` int(1) NOT NULL DEFAULT '0',
  `frmset` int(1) NOT NULL DEFAULT '0',
  PRIMARY KEY (`user`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Data for the table `tb_user` */

insert  into `tb_user`(`user`,`pass`,`status`,`frmbrg`,`frmkat`,`frmsat`,`frmjual`,`frmlap`,`frmkas`,`frmpass`,`frmset`) values ('master','',1,1,1,1,1,1,1,1,1),('shift1','',1,1,0,0,0,0,0,0,0),('shift2','',1,1,1,1,1,1,0,1,1);

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
