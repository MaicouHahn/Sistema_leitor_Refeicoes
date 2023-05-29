-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 28/05/2023 às 22:51
-- Versão do servidor: 10.4.28-MariaDB
-- Versão do PHP: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `testetoken`
--

-- --------------------------------------------------------

--
-- Estrutura para tabela `administradores`
--

CREATE TABLE `administradores` (
  `idadm` int(11) NOT NULL,
  `usuario` varchar(255) NOT NULL,
  `senha` varchar(255) NOT NULL,
  `nome` varchar(255) NOT NULL,
  `sobrenome` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `administradores`
--

INSERT INTO `administradores` (`idadm`, `usuario`, `senha`, `nome`, `sobrenome`) VALUES
(1, 'Maicou', '123', 'Maicou', 'Fortuna');

-- --------------------------------------------------------

--
-- Estrutura para tabela `cadastro`
--

CREATE TABLE `cadastro` (
  `matricula` varchar(20) NOT NULL,
  `nome` varchar(50) NOT NULL,
  `sobrenome` varchar(50) NOT NULL,
  `telefone` varchar(15) NOT NULL,
  `email` varchar(50) NOT NULL,
  `token` varchar(50) NOT NULL,
  `datacadastro` date NOT NULL DEFAULT curdate(),
  `serie` varchar(25) DEFAULT '1º Ano'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `cadastro`
--

INSERT INTO `cadastro` (`matricula`, `nome`, `sobrenome`, `telefone`, `email`, `token`, `datacadastro`, `serie`) VALUES
('#123456', 'Maicou', 'Hahn', '11111', 'adsasd@gmail.com', '3361F6B9', '2023-05-28', '1º Ano'),
('1112234', 'qwe', 'qqq', '111111111', 'adasda@sadas', '#658854', '2023-05-27', '2º Ano'),
('123159', 'asdasd', '12312312', '12312313123222', 'asdasdasd@asdad', '#569987', '2023-05-27', '1º Ano'),
('123332211', 'vraulissom', 'bronze', '1111', 'vrau@gmail.com', '#598745', '2023-05-27', '1º Ano'),
('1234', 'a', 'a', 'a', 'a', '#1234321', '2023-05-28', '3º Ano'),
('12343221', 'Jurema', 'Friburgo', '1112223334', 'Jurema@gmail.com', '#489752', '0001-01-01', '1º Ano'),
('123456', 'Elena', 'Alves', '123456', 'elena@gmail.com', '#556987', '2023-05-27', '1º Ano'),
('789645', 'asdasd', 'asdasd', 'asdas', 'adsa', '#669988', '2023-05-27', '1º Ano'),
('8965899', 'Maicou', 'Hahn', '159654', 'aasda@gmail.com', '#569887', '2023-05-27', '3º Ano'),
('asd', 'asd', 'asd', 'asd', 'sd', 'asd', '2023-05-27', '1º Ano'),
('sad', 'Kauany', 'Sartor', 'sd', 'asd', 'C380F1AC', '2023-05-28', '1º Ano');

-- --------------------------------------------------------

--
-- Estrutura para tabela `pedidosdodia`
--

CREATE TABLE `pedidosdodia` (
  `datadodia` date NOT NULL DEFAULT curdate(),
  `matricula` varchar(50) NOT NULL,
  `tickets` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Despejando dados para a tabela `pedidosdodia`
--

INSERT INTO `pedidosdodia` (`datadodia`, `matricula`, `tickets`) VALUES
('2023-05-28', 'sad', 1);

--
-- Índices para tabelas despejadas
--

--
-- Índices de tabela `administradores`
--
ALTER TABLE `administradores`
  ADD PRIMARY KEY (`idadm`);

--
-- Índices de tabela `cadastro`
--
ALTER TABLE `cadastro`
  ADD PRIMARY KEY (`matricula`);

--
-- Índices de tabela `pedidosdodia`
--
ALTER TABLE `pedidosdodia`
  ADD KEY `matricula` (`matricula`);

--
-- AUTO_INCREMENT para tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `administradores`
--
ALTER TABLE `administradores`
  MODIFY `idadm` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Restrições para tabelas despejadas
--

--
-- Restrições para tabelas `pedidosdodia`
--
ALTER TABLE `pedidosdodia`
  ADD CONSTRAINT `pedidosdodia_ibfk_1` FOREIGN KEY (`matricula`) REFERENCES `cadastro` (`matricula`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
