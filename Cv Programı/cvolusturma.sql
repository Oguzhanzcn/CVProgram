-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 09 May 2017, 00:18:57
-- Sunucu sürümü: 5.7.14
-- PHP Sürümü: 5.6.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `cvolusturma`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `cvbilgileri`
--

CREATE TABLE `cvbilgileri` (
  `id` int(255) NOT NULL,
  `tckno` varchar(11) NOT NULL,
  `ad` varchar(30) CHARACTER SET latin5 NOT NULL,
  `soyad` varchar(30) CHARACTER SET latin5 NOT NULL,
  `telNo` varchar(20) NOT NULL,
  `calismaDurumu` varchar(6) CHARACTER SET latin5 NOT NULL,
  `yas` int(11) NOT NULL,
  `dogumYeriUyrugu` varchar(50) CHARACTER SET latin5 NOT NULL,
  `Askerlikdurum` varchar(20) CHARACTER SET latin5 NOT NULL,
  `Ehliyet` varchar(10) CHARACTER SET latin5 NOT NULL,
  `email` varchar(30) CHARACTER SET latin5 NOT NULL,
  `medeniDurum` varchar(10) CHARACTER SET latin5 NOT NULL,
  `basvurulanAlan` varchar(70) CHARACTER SET latin5 NOT NULL,
  `lise` varchar(20) CHARACTER SET latin5 NOT NULL,
  `universite` varchar(30) CHARACTER SET latin5 NOT NULL,
  `uniNot` float NOT NULL,
  `liseNot` int(100) NOT NULL,
  `uniBolum` varchar(30) CHARACTER SET latin5 NOT NULL,
  `yabanciDil` varchar(100) CHARACTER SET latin5 NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Tablo döküm verisi `cvbilgileri`
--

INSERT INTO `cvbilgileri` (`id`, `tckno`, `ad`, `soyad`, `telNo`, `calismaDurumu`, `yas`, `dogumYeriUyrugu`, `Askerlikdurum`, `Ehliyet`, `email`, `medeniDurum`, `basvurulanAlan`, `lise`, `universite`, `uniNot`, `liseNot`, `uniBolum`, `yabanciDil`) VALUES
(16, '22222222222', 'oguzhan', 'ozcan', '(222) 222-2222', 'HAYIR', 21, 'Bakirköy/TC', 'Tecilli', 'B1', 'oguzhanozcan39@hotmail.com', 'Bekar', 'IT,AR-GE', 'Lüleburgaz Lisesi', 'Trakya üni.', 3.04, 84, 'Bilgisayar Müh.', 'Ingilizce:iyi'),
(20, '22222222222', 'oguzhan', 'ozcan', '(222) 222-2222', 'HAYIR', 21, 'Bakirköy/TC', 'Tecilli', 'B1', 'oguzhanozcan39@hotmail.com', 'Bekar', 'IT,AR-GE', 'Lüleburgaz Lisesi', 'Trakya üni.', 3.04, 84, 'Bilgisayar Müh.', 'Ingilizce:iyi');

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `cvbilgileri`
--
ALTER TABLE `cvbilgileri`
  ADD PRIMARY KEY (`id`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `cvbilgileri`
--
ALTER TABLE `cvbilgileri`
  MODIFY `id` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
