-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 28, 2022 at 10:28 AM
-- Server version: 10.4.21-MariaDB
-- PHP Version: 7.3.31

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `pembayaran_spp`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbladm`
--

CREATE TABLE `tbladm` (
  `idadm` int(11) NOT NULL,
  `namaadm` varchar(45) CHARACTER SET utf8 NOT NULL,
  `passw` varchar(45) CHARACTER SET utf8 NOT NULL,
  `tlpadm` bigint(40) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbladm`
--

INSERT INTO `tbladm` (`idadm`, `namaadm`, `passw`, `tlpadm`) VALUES
(12, 'yxe', 'wangy', 1212121111),
(22, 'yaszzzz', 'asdasdasa121', 12412547341),
(777, 'iyas', 'horo', 8951700);

-- --------------------------------------------------------

--
-- Table structure for table `tblsiswa`
--

CREATE TABLE `tblsiswa` (
  `nis` int(40) NOT NULL,
  `namawa` varchar(40) CHARACTER SET utf8 NOT NULL,
  `tahun` varchar(40) CHARACTER SET utf8 NOT NULL,
  `jenis_Kelamin` varchar(40) CHARACTER SET utf8 NOT NULL,
  `alamat` varchar(90) CHARACTER SET utf8 NOT NULL,
  `wali` varchar(40) CHARACTER SET utf8 NOT NULL,
  `no_telp` bigint(40) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tblsiswa`
--

INSERT INTO `tblsiswa` (`nis`, `namawa`, `tahun`, `jenis_Kelamin`, `alamat`, `wali`, `no_telp`) VALUES
(1212, 'iyasz', '28 May 2022', 'Laki Laki', 'kahuripan', 'amat', 893423523),
(9999, 'muhammad ilyasa', '28 May 2022', 'Laki Laki', 'kkkkll', 'lllll', 987655);

-- --------------------------------------------------------

--
-- Table structure for table `tblspp`
--

CREATE TABLE `tblspp` (
  `no_kw` int(50) NOT NULL,
  `tgl_kw` varchar(50) CHARACTER SET utf8 NOT NULL,
  `bulan` varchar(50) CHARACTER SET utf8 NOT NULL,
  `nis` int(50) NOT NULL,
  `jumlah` int(50) NOT NULL,
  `keterangan` varchar(50) CHARACTER SET utf8 NOT NULL,
  `id_adm` int(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tblspp`
--

INSERT INTO `tblspp` (`no_kw`, `tgl_kw`, `bulan`, `nis`, `jumlah`, `keterangan`, `id_adm`) VALUES
(2222, '28 May 2022', 'feb', 1212, 15, 'absen', 22);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbladm`
--
ALTER TABLE `tbladm`
  ADD PRIMARY KEY (`idadm`);

--
-- Indexes for table `tblsiswa`
--
ALTER TABLE `tblsiswa`
  ADD PRIMARY KEY (`nis`);

--
-- Indexes for table `tblspp`
--
ALTER TABLE `tblspp`
  ADD PRIMARY KEY (`no_kw`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
