-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 12, 2026 at 08:36 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `attendance_central`
--

-- --------------------------------------------------------

--
-- Table structure for table `central_attendance`
--

CREATE TABLE `central_attendance` (
  `id` int(11) NOT NULL,
  `record_uuid` varchar(50) NOT NULL,
  `student_id` varchar(20) NOT NULL,
  `firstname` varchar(100) NOT NULL,
  `lastname` varchar(100) NOT NULL,
  `attendance_date` date NOT NULL,
  `time_in` time DEFAULT NULL,
  `time_out` time DEFAULT NULL,
  `status` varchar(20) NOT NULL,
  `branch_code` varchar(10) NOT NULL,
  `received_at` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `central_attendance`
--

INSERT INTO `central_attendance` (`id`, `record_uuid`, `student_id`, `firstname`, `lastname`, `attendance_date`, `time_in`, `time_out`, `status`, `branch_code`, `received_at`) VALUES
(1, 'b9a31a17-2d65-46e3-8361-2a12cadb53dc', '1579-23', 'Bianca Adrienne', 'Dollente', '2026-03-13', '02:36:12', '02:36:30', 'Present', 'A', '2026-03-13 02:49:06'),
(2, '679ed791-c1ae-4c6c-8f65-97cbc5f262d0', '1599-23', 'Lorene Mikyle', 'Valencia', '2026-03-13', '02:52:17', '02:52:55', 'Present', 'B', '2026-03-13 02:53:01'),
(3, 'acab94a2-1157-4190-998b-1154a4962104', '1585-23', 'Ronan Justine', 'Ga', '2026-03-13', '02:54:51', '02:55:14', 'Present', 'C', '2026-03-13 02:55:21'),
(4, '3c1e7079-22c4-4d8e-8ca4-5789ae00c0b5', '1599-23', 'Lorene Mikyle', 'Valencia', '2026-03-13', '03:03:23', '03:03:42', 'Present', 'A', '2026-03-13 03:04:06');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `central_attendance`
--
ALTER TABLE `central_attendance`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `record_uuid` (`record_uuid`),
  ADD UNIQUE KEY `uq_student_day_branch` (`student_id`,`attendance_date`,`branch_code`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `central_attendance`
--
ALTER TABLE `central_attendance`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
