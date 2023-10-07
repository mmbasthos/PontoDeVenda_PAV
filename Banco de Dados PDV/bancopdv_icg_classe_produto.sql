-- MySQL dump 10.13  Distrib 8.0.34, for Win64 (x86_64)
--
-- Host: localhost    Database: bancopdv_icg
-- ------------------------------------------------------
-- Server version	8.0.33

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `classe_produto`
--

DROP TABLE IF EXISTS `classe_produto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `classe_produto` (
  `id_classe` int NOT NULL AUTO_INCREMENT,
  `nome_classe` varchar(255) NOT NULL,
  PRIMARY KEY (`id_classe`)
) ENGINE=InnoDB AUTO_INCREMENT=73 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `classe_produto`
--

LOCK TABLES `classe_produto` WRITE;
/*!40000 ALTER TABLE `classe_produto` DISABLE KEYS */;
INSERT INTO `classe_produto` VALUES (39,'Industrial'),(40,'Enlatados'),(41,'Produtos de Limpeza'),(42,'Produtos de Higiene Pessoal'),(43,'Eletrônicos'),(44,'Roupas e Acessórios'),(45,'Calçados'),(46,'Móveis e Decoração'),(47,'Artigos de Papelaria'),(48,'Brinquedos e Jogos'),(49,'Ferramentas e Equipamentos'),(50,'Livros e Revistas'),(51,'Produtos para Animais'),(52,'Produtos de Jardinagem'),(53,'Material Esportivo'),(54,'Produtos de Beleza'),(55,'Suplementos Alimentares'),(56,'Equipamentos de Cozinha'),(57,'Artigos de Cama, Mesa e Banho'),(58,'Produtos de Informática'),(59,'Frutas e Vegetais'),(60,'Carnes e Aves'),(61,'Peixes e Frutos do Mar'),(62,'Laticínios e Ovos'),(63,'Pães e Produtos de Padaria'),(64,'Bebidas Não Alcoólicas'),(65,'Bebidas Alcoólicas'),(66,'Produtos de Confeitaria'),(67,'Açougue'),(69,'Produtos Orgânicos'),(70,'Produtos Sem Glúten'),(71,'Produtos Sem Lactose'),(72,'Sorvetes e Sobremesas Geladas');
/*!40000 ALTER TABLE `classe_produto` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-10-01 16:17:30
