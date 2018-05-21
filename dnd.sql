-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Servidor: localhost:3306
-- Tiempo de generación: 21-05-2018 a las 03:24:16
-- Versión del servidor: 5.7.20
-- Versión de PHP: 7.1.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `dnd`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `personaje`
--

CREATE TABLE `personaje` (
  `id` bigint(255) NOT NULL,
  `nombre` text NOT NULL,
  `raza` varchar(255) NOT NULL,
  `fuerza` int(255) NOT NULL,
  `destreza` int(255) NOT NULL,
  `constitucion` int(255) NOT NULL,
  `inteligencia` int(255) NOT NULL,
  `sabiduria` int(255) NOT NULL,
  `carisma` int(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `personaje`
--

INSERT INTO `personaje` (`id`, `nombre`, `raza`, `fuerza`, `destreza`, `constitucion`, `inteligencia`, `sabiduria`, `carisma`) VALUES
(5, 'Yon', 'Enano', 17, 16, 11, 22, 13, 12),
(6, 'Legolas', 'Elfo', 9, 18, 7, 14, 11, 0),
(7, 'Gimley', 'Enano', 19, 18, 17, 12, 11, 12),
(10, 'Aragorn', 'Humano', 23, 12, 4, 31, 21, 0),
(15, 'Frodo', 'Mediano', 6, 4, 0, 3, 8, 0),
(16, 'Sam', 'Mediano', 8, 6, 7, 5, 4, 0),
(17, 'yon', 'Gnomo', 5, 8, 6, 7, 3, 0),
(19, 'Pedro', 'Humano', 7, 9, 6, 4, 9, 0),
(21, 'Matame Camion', 'Elfo', 3, 9, 7, 5, 3, 0),
(22, 'lzkjhjkh', 'Elfo', 8, 6, 0, 0, 5, 5),
(23, 'todo ok?', 'Mediano', 98, 100, 25, 56, 26, 88),
(24, 'pruebakdjsa', 'Elfo', 8, 9, 5, 7, 8, 3),
(26, 'Yon', 'Elfo', 6, 8, 9, 8, 4, 66),
(27, 'terminado!!!!', 'Orco', 8, 6, 8, 4, 6, 7),
(28, 'AAAAA', 'Orco', 8, 8, 9, 5, 34, 0);

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `personaje`
--
ALTER TABLE `personaje`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `personaje`
--
ALTER TABLE `personaje`
  MODIFY `id` bigint(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=29;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
