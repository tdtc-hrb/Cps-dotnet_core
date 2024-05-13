-- phpMyAdmin SQL Dump
-- version 4.9.10
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Generation Time: Jan 02, 2023 at 03:30 AM
-- Server version: 8.0.31
-- PHP Version: 7.1.33

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `pubs`
--

-- --------------------------------------------------------

--
-- Table structure for table `arrivestation`
--

CREATE TABLE `arrivestation` (
  `id` int NOT NULL,
  `name` varchar(30) DEFAULT NULL,
  `description` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `arrivestation`
--

INSERT INTO `arrivestation` (`id`, `name`, `description`) VALUES
(1000, 'flej', '富拉尔基发电总厂'),
(1001, 'lfrd', '龙凤热电厂'),
(1002, 'sxmz', '三喜玛子热电厂');

-- --------------------------------------------------------

--
-- Table structure for table `breedcoal`
--

CREATE TABLE `breedcoal` (
  `id` int NOT NULL,
  `name` varchar(30) DEFAULT NULL,
  `description` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `breedcoal`
--

INSERT INTO `breedcoal` (`id`, `name`, `description`) VALUES
(1000, 'hm', '混煤');

-- --------------------------------------------------------

--
-- Table structure for table `dispatchtemporary`
--

CREATE TABLE `dispatchtemporary` (
  `total_weight` decimal(9,3) DEFAULT NULL,
  `weight` decimal(9,3) DEFAULT NULL,
  `car_model` varchar(25) DEFAULT NULL,
  `car_number` varchar(25) NOT NULL,
  `carry_weight` decimal(9,3) DEFAULT NULL,
  `self_weight` decimal(9,3) DEFAULT NULL,
  `pl_weight` decimal(9,3) DEFAULT NULL,
  `breed_id` int DEFAULT NULL,
  `past_date` date DEFAULT NULL,
  `past_time` varchar(25) DEFAULT NULL,
  `arrive_id` int DEFAULT NULL,
  `consist` int DEFAULT NULL,
  `lot_id` int NOT NULL,
  `is_obsoleted` bit(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `dispatchtemporary`
--

INSERT INTO `dispatchtemporary` (`total_weight`, `weight`, `car_model`, `car_number`, `carry_weight`, `self_weight`, `pl_weight`, `breed_id`, `past_date`, `past_time`, `arrive_id`, `consist`, `lot_id`, `is_obsoleted`) VALUES
('23.040', '23.000', 'C61', '4307157', '61.000', '23.000', '-60.960', 1000, '2006-03-08', '13:37:59', 1001, 0, 1, b'0'),
('21.520', '23.000', 'C61', '4306258', '61.000', '23.000', '-62.480', 1000, '2006-03-08', '14:03:06', 1000, 0, 2, b'0');

-- --------------------------------------------------------

--
-- Table structure for table `lotnumber`
--

CREATE TABLE `lotnumber` (
  `id` int NOT NULL,
  `weightstation_id` int DEFAULT NULL,
  `coupler_number` int DEFAULT NULL,
  `status_id` int NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;

--
-- Dumping data for table `lotnumber`
--

INSERT INTO `lotnumber` (`id`, `weightstation_id`, `coupler_number`, `status_id`) VALUES
(1, 1001, 1, 0),
(2, 1000, 1, 0),
(3, 1000, 2, 1),
(4, 1001, 2, 1);

-- --------------------------------------------------------

--
-- Table structure for table `lotnumstatuses`
--

CREATE TABLE `lotnumstatuses` (
  `id` int NOT NULL,
  `name` varchar(30) NOT NULL,
  `description` varchar(120) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `weightstation`
--

CREATE TABLE `weightstation` (
  `id` int NOT NULL,
  `name` varchar(30) DEFAULT NULL,
  `description` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `weightstation`
--

INSERT INTO `weightstation` (`id`, `name`, `description`) VALUES
(1000, '铁北', '检斤站'),
(1001, '露天矿', '检斤站'),
(1002, '十二井', '十二井检斤站'),
(1003, '三斜井', '三斜井检斤站');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `arrivestation`
--
ALTER TABLE `arrivestation`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `breedcoal`
--
ALTER TABLE `breedcoal`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `dispatchtemporary`
--
ALTER TABLE `dispatchtemporary`
  ADD PRIMARY KEY (`lot_id`,`car_number`);

--
-- Indexes for table `lotnumber`
--
ALTER TABLE `lotnumber`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `lotnumstatuses`
--
ALTER TABLE `lotnumstatuses`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `weightstation`
--
ALTER TABLE `weightstation`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `arrivestation`
--
ALTER TABLE `arrivestation`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1003;

--
-- AUTO_INCREMENT for table `breedcoal`
--
ALTER TABLE `breedcoal`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1001;

--
-- AUTO_INCREMENT for table `lotnumber`
--
ALTER TABLE `lotnumber`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `lotnumstatuses`
--
ALTER TABLE `lotnumstatuses`
  MODIFY `id` int NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `weightstation`
--
ALTER TABLE `weightstation`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=1004;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
