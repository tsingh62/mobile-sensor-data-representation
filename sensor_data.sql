-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 03, 2017 at 04:07 AM
-- Server version: 5.7.14
-- PHP Version: 5.6.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `sensor_data`
--

-- --------------------------------------------------------

--
-- Table structure for table `web_health`
--

CREATE TABLE `web_health` (
  `light_record` float DEFAULT NULL,
  `light_realtime` float DEFAULT NULL,
  `acc_recordx` float DEFAULT NULL,
  `acc_recordy` float DEFAULT NULL,
  `acc_recordz` float DEFAULT NULL,
  `acc_realtimex` float DEFAULT NULL,
  `acc_realtimey` float DEFAULT NULL,
  `acc_realtimez` float DEFAULT NULL,
  `mag_recordx` int(11) DEFAULT NULL,
  `mag_recordy` int(11) DEFAULT NULL,
  `mag_recordz` int(11) DEFAULT NULL,
  `mag_realtimex` int(11) DEFAULT NULL,
  `mag_realtimey` int(11) DEFAULT NULL,
  `mag_realtimez` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `web_health`
--

INSERT INTO `web_health` (`light_record`, `light_realtime`, `acc_recordx`, `acc_recordy`, `acc_recordz`, `acc_realtimex`, `acc_realtimey`, `acc_realtimez`, `mag_recordx`, `mag_recordy`, `mag_recordz`, `mag_realtimex`, `mag_realtimey`, `mag_realtimez`) VALUES
(1, 0.9, 0.334567, 0.543368, 0.998765, 0.45568, 9.5509, 0.456778, NULL, NULL, NULL, 1, NULL, NULL);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
