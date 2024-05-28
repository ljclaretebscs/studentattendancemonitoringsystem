-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 21, 2023 at 12:27 PM
-- Server version: 10.4.27-MariaDB
-- PHP Version: 8.2.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `studentattendancesystemdb`
--

-- --------------------------------------------------------

--
-- Table structure for table `addstudenttbl`
--

CREATE TABLE `addstudenttbl` (
  `ID` int(255) NOT NULL,
  `Student_ID` varchar(50) NOT NULL,
  `Student_Full_Name` varchar(150) NOT NULL,
  `FirstName` varchar(50) NOT NULL,
  `MiddleName` varchar(50) NOT NULL,
  `LastName` varchar(50) NOT NULL,
  `Address` varchar(255) NOT NULL,
  `Section` varchar(70) NOT NULL,
  `Year_Level` varchar(50) NOT NULL,
  `Gender` varchar(15) NOT NULL,
  `Name_of_Contact_Person` varchar(150) NOT NULL,
  `Phone_Number` varchar(20) NOT NULL,
  `Facilitator` varchar(150) NOT NULL,
  `Qrcode` longblob NOT NULL,
  `Student_Picture` longblob NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `adminusertbl`
--

CREATE TABLE `adminusertbl` (
  `ID` int(255) NOT NULL,
  `Username` varchar(50) NOT NULL,
  `Password` varchar(50) NOT NULL,
  `Facilitator_FullName` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `adminusertbl`
--

INSERT INTO `adminusertbl` (`ID`, `Username`, `Password`, `Facilitator_FullName`) VALUES
(2, 'Admin', '751cb3f4aa17c36186f4856c8982bf27', 'Mary Ann Carao');

-- --------------------------------------------------------

--
-- Table structure for table `attendancetbl`
--

CREATE TABLE `attendancetbl` (
  `Attendance_No` int(255) NOT NULL,
  `TimeIn` varchar(70) NOT NULL,
  `TimeOut` varchar(70) NOT NULL,
  `Attendance_Date` varchar(100) NOT NULL,
  `Student_Name` varchar(150) NOT NULL,
  `Student_ID` varchar(100) NOT NULL,
  `Section` varchar(70) NOT NULL,
  `Year_Level` varchar(70) NOT NULL,
  `Facilitator` varchar(150) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `sectiontbl`
--

CREATE TABLE `sectiontbl` (
  `Section` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `yearleveltbl`
--

CREATE TABLE `yearleveltbl` (
  `Year_Level` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `addstudenttbl`
--
ALTER TABLE `addstudenttbl`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `Student_ID` (`Student_ID`);

--
-- Indexes for table `adminusertbl`
--
ALTER TABLE `adminusertbl`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `Username` (`Username`);

--
-- Indexes for table `attendancetbl`
--
ALTER TABLE `attendancetbl`
  ADD PRIMARY KEY (`Attendance_No`);

--
-- Indexes for table `sectiontbl`
--
ALTER TABLE `sectiontbl`
  ADD PRIMARY KEY (`Section`);

--
-- Indexes for table `yearleveltbl`
--
ALTER TABLE `yearleveltbl`
  ADD PRIMARY KEY (`Year_Level`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `addstudenttbl`
--
ALTER TABLE `addstudenttbl`
  MODIFY `ID` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `adminusertbl`
--
ALTER TABLE `adminusertbl`
  MODIFY `ID` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `attendancetbl`
--
ALTER TABLE `attendancetbl`
  MODIFY `Attendance_No` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
