-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 16, 2022 at 11:52 AM
-- Server version: 5.7.14
-- PHP Version: 5.6.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `iverciusistema`
--

DELIMITER $$
--
-- Procedures
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `VisiStudentai` ()  NO SQL
SELECT * FROM studentas$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `ID` int(11) NOT NULL,
  `name` varchar(50) COLLATE cp1257_lithuanian_ci DEFAULT NULL,
  `password` varchar(255) COLLATE cp1257_lithuanian_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=cp1257 COLLATE=cp1257_lithuanian_ci;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`ID`, `name`, `password`) VALUES
(1, 'root', '123');

-- --------------------------------------------------------

--
-- Table structure for table `dalykas`
--

CREATE TABLE `dalykas` (
  `dalykoID` int(11) NOT NULL,
  `pavadinimas` varchar(255) COLLATE cp1257_lithuanian_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=cp1257 COLLATE=cp1257_lithuanian_ci;

--
-- Dumping data for table `dalykas`
--

INSERT INTO `dalykas` (`dalykoID`, `pavadinimas`) VALUES
(1, 'SOM'),
(2, 'DBP'),
(3, 'Teisė'),
(4, 'Vadyba'),
(5, 'ŽKSP');

-- --------------------------------------------------------

--
-- Table structure for table `destytojas`
--

CREATE TABLE `destytojas` (
  `dėstytojoID` int(11) NOT NULL,
  `Vardas` varchar(255) COLLATE cp1257_lithuanian_ci DEFAULT NULL,
  `pavarde` varchar(255) COLLATE cp1257_lithuanian_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=cp1257 COLLATE=cp1257_lithuanian_ci;

--
-- Dumping data for table `destytojas`
--

INSERT INTO `destytojas` (`dėstytojoID`, `Vardas`, `pavarde`) VALUES
(1, 'Kęstas', 'Tavulionis'),
(2, 'Vaidas', 'Igoris'),
(3, 'Raimondas', 'Greitis'),
(4, 'geraldas', 'Medis');

-- --------------------------------------------------------

--
-- Table structure for table `grupe`
--

CREATE TABLE `grupe` (
  `grupesID` int(11) NOT NULL,
  `pavadinimas` varchar(255) COLLATE cp1257_lithuanian_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=cp1257 COLLATE=cp1257_lithuanian_ci;

--
-- Dumping data for table `grupe`
--

INSERT INTO `grupe` (`grupesID`, `pavadinimas`) VALUES
(1, 'PI21A'),
(2, 'PI21B'),
(8, 'PI21S'),
(9, 'PI20B');

-- --------------------------------------------------------

--
-- Table structure for table `modulis`
--

CREATE TABLE `modulis` (
  `modulioID` int(11) NOT NULL,
  `dalykoID` int(11) DEFAULT NULL,
  `dėstytojoID` int(11) DEFAULT NULL,
  `grupesID` int(11) DEFAULT NULL,
  `pavadinimas` varchar(255) COLLATE cp1257_lithuanian_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=cp1257 COLLATE=cp1257_lithuanian_ci;

--
-- Dumping data for table `modulis`
--

INSERT INTO `modulis` (`modulioID`, `dalykoID`, `dėstytojoID`, `grupesID`, `pavadinimas`) VALUES
(1, 1, 2, 1, 'SOM'),
(2, 3, 4, 2, 'Teisė'),
(3, 4, 2, 1, 'Vadyba'),
(4, 5, 1, 3, 'ŽKSP');

-- --------------------------------------------------------

--
-- Table structure for table `pazymys`
--

CREATE TABLE `pazymys` (
  `pažymioID` int(11) NOT NULL,
  `reikšmė` int(11) DEFAULT NULL,
  `studentoID` int(11) DEFAULT NULL,
  `modulioID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=cp1257 COLLATE=cp1257_lithuanian_ci;

-- --------------------------------------------------------

--
-- Table structure for table `studentas`
--

CREATE TABLE `studentas` (
  `studentoID` int(11) NOT NULL,
  `grupesID` int(11) DEFAULT NULL,
  `vardas` varchar(255) COLLATE cp1257_lithuanian_ci DEFAULT NULL,
  `pavarde` varchar(255) COLLATE cp1257_lithuanian_ci DEFAULT NULL
) ENGINE=InnoDB AVG_ROW_LENGTH=4096 DEFAULT CHARSET=cp1257 COLLATE=cp1257_lithuanian_ci;

--
-- Dumping data for table `studentas`
--

INSERT INTO `studentas` (`studentoID`, `grupesID`, `vardas`, `pavarde`) VALUES
(1, 1, 'Linas', 'Mackevicius'),
(2, 1, 'Nojus', 'Kolosovas'),
(3, 2, 'Rokas', 'Stankevicius'),
(4, 2, 'Mantas', 'Daublys'),
(6, 9, 'JOnas', 'Jonaitis');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `dalykas`
--
ALTER TABLE `dalykas`
  ADD PRIMARY KEY (`dalykoID`);

--
-- Indexes for table `destytojas`
--
ALTER TABLE `destytojas`
  ADD PRIMARY KEY (`dėstytojoID`);

--
-- Indexes for table `grupe`
--
ALTER TABLE `grupe`
  ADD PRIMARY KEY (`grupesID`);

--
-- Indexes for table `modulis`
--
ALTER TABLE `modulis`
  ADD PRIMARY KEY (`modulioID`),
  ADD KEY `FK_modulis_dėstytojas_dėstytojoID` (`dėstytojoID`),
  ADD KEY `FK_modulis_dalykas_dalykoID` (`dalykoID`);

--
-- Indexes for table `pazymys`
--
ALTER TABLE `pazymys`
  ADD PRIMARY KEY (`pažymioID`),
  ADD KEY `FK_pažymys_modulis_modulioID` (`modulioID`),
  ADD KEY `FK_pazymys_studentas_studentoID` (`studentoID`);

--
-- Indexes for table `studentas`
--
ALTER TABLE `studentas`
  ADD PRIMARY KEY (`studentoID`),
  ADD KEY `grupesID` (`grupesID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `admin`
--
ALTER TABLE `admin`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `grupe`
--
ALTER TABLE `grupe`
  MODIFY `grupesID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
--
-- AUTO_INCREMENT for table `modulis`
--
ALTER TABLE `modulis`
  MODIFY `modulioID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `studentas`
--
ALTER TABLE `studentas`
  MODIFY `studentoID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `modulis`
--
ALTER TABLE `modulis`
  ADD CONSTRAINT `FK_modulis_dalykas_dalykoID` FOREIGN KEY (`dalykoID`) REFERENCES `dalykas` (`dalykoID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `FK_modulis_dėstytojas_dėstytojoID` FOREIGN KEY (`dėstytojoID`) REFERENCES `destytojas` (`dėstytojoID`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `pazymys`
--
ALTER TABLE `pazymys`
  ADD CONSTRAINT `FK_pazymys_studentas_studentoID` FOREIGN KEY (`studentoID`) REFERENCES `studentas` (`studentoID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `FK_pažymys_modulis_modulioID` FOREIGN KEY (`modulioID`) REFERENCES `modulis` (`modulioID`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `studentas`
--
ALTER TABLE `studentas`
  ADD CONSTRAINT `studentas_ibfk_1` FOREIGN KEY (`grupesID`) REFERENCES `grupe` (`grupesID`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
