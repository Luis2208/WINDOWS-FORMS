# WINDOWS-FORMS
Proyecto Escolar realizado para un amigo, para entregar el dia 11/06/2020.
Está hecho C# Windows Forms y MySQL.
-----------------------------------------------------------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------------------------------------------------------
SE ADJUNTA SCRIPT DE BASE DE DATOS A CONTINUACIÓN}

-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 02-06-2020 a las 17:28:25
-- Versión del servidor: 10.4.8-MariaDB
-- Versión de PHP: 7.3.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `tienda_salch`
--
CREATE DATABASE IF NOT EXISTS `tienda_salch` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `tienda_salch`;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `producto`
--

CREATE TABLE `producto` (
  `CodigoProducto` int(11) NOT NULL,
  `Nombre` varchar(100) NOT NULL,
  `Categoria` varchar(100) NOT NULL,
  `Precio` decimal(7,2) NOT NULL,
  `Cantidad` int(100) NOT NULL,
  `Descripcion` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `producto`
--

INSERT INTO `producto` (`CodigoProducto`, `Nombre`, `Categoria`, `Precio`, `Cantidad`, `Descripcion`) VALUES
(2, 'Queso Lala', 'Queso.', '56.00', 4, 'muy rico');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE `usuarios` (
  `CodUsuario` int(11) NOT NULL,
  `NomUsuario` varchar(30) NOT NULL,
  `ApeUsuario` varchar(30) NOT NULL,
  `CiudUsuario` varchar(100) NOT NULL,
  `Correo` varchar(30) NOT NULL,
  `Telefono` varchar(30) NOT NULL,
  `ClaveUsuario` varchar(30) NOT NULL,
  `Perfil` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`CodUsuario`, `NomUsuario`, `ApeUsuario`, `CiudUsuario`, `Correo`, `Telefono`, `ClaveUsuario`, `Perfil`) VALUES
(3, 'Aguero', 'Maravilla', 'Torreón', 'aguero@gmail.com', '569-789-1233', '78910', 'Administrador'),
(5, 'Danna', 'Aguero', 'Torreón', 'aguero2@gmail.com', '787-986-7895', '12345', 'Usuario');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `venta`
--

CREATE TABLE `venta` (
  `Cliente` int(11) NOT NULL,
  `Nombre` varchar(100) NOT NULL,
  `Categoria` varchar(100) NOT NULL,
  `Descripcion` varchar(100) NOT NULL,
  `Precio` decimal(7,2) NOT NULL,
  `Cantidad` int(100) NOT NULL,
  `Total` decimal(7,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `venta`
--

INSERT INTO `venta` (`Cliente`, `Nombre`, `Categoria`, `Descripcion`, `Precio`, `Cantidad`, `Total`) VALUES
(42, 'Queso', 'Queso.', 'Muy rico', '7.00', 3, '69.00'),
(45, 'Yoghurt', 'Empacados.', 'Mora fresa', '8.00', 3, '39.00'),
(119, 'Queso', 'Queso.', 'Muy rico', '7.00', 4, '52.00'),
(344, 'Queso', 'Queso.', 'Muy rico', '7.00', 3, '45.00'),
(551, 'Yogu', 'Carnes Frías.', 'muy rico', '3.00', 3, '25.00'),
(564, 'Queso Lala', 'Queso.', 'muy rico', '56.00', 4, '224.00'),
(706, 'Yogu', 'Carnes Frías.', 'muy rico', '3.00', 3, '73.00');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `producto`
--
ALTER TABLE `producto`
  ADD PRIMARY KEY (`CodigoProducto`);

--
-- Indices de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  ADD PRIMARY KEY (`CodUsuario`);

--
-- Indices de la tabla `venta`
--
ALTER TABLE `venta`
  ADD PRIMARY KEY (`Cliente`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `producto`
--
ALTER TABLE `producto`
  MODIFY `CodigoProducto` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `usuarios`
--
ALTER TABLE `usuarios`
  MODIFY `CodUsuario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
