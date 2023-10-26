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
-- Table structure for table `movimento_caixa`
--

DROP TABLE IF EXISTS `movimento_caixa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `movimento_caixa` (
  `id_movimento_caixa` int NOT NULL AUTO_INCREMENT,
  `data_movimento` date DEFAULT NULL,
  `hora_movimento` time DEFAULT NULL,
  `descricao_movimento` varchar(60) DEFAULT NULL,
  `tipo_movimento` varchar(45) DEFAULT NULL,
  `valor_movimento` decimal(10,2) DEFAULT NULL,
  `Caixa_id_caixa` int NOT NULL,
  `formapagamento` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id_movimento_caixa`,`Caixa_id_caixa`),
  KEY `fk_Movimento_Caixa_Caixa1_idx` (`Caixa_id_caixa`),
  CONSTRAINT `fk_Movimento_Caixa_Caixa1` FOREIGN KEY (`Caixa_id_caixa`) REFERENCES `caixa` (`id_caixa`)
) ENGINE=InnoDB AUTO_INCREMENT=134 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `movimento_caixa`
--

LOCK TABLES `movimento_caixa` WRITE;
/*!40000 ALTER TABLE `movimento_caixa` DISABLE KEYS */;
INSERT INTO `movimento_caixa` VALUES (60,'2023-10-23','21:23:28','Venda','E',30.00,315,'Espécie'),(61,'2023-10-23','21:23:42','Compra','S',2.00,315,'Espécie'),(62,'2023-10-23','21:59:46','Venda','E',2.00,315,'PIX'),(63,'2023-10-23','22:00:03','Compra','S',6.00,315,'Espécie'),(64,'2023-10-23','22:00:19','Venda','E',6.00,315,'Espécie'),(65,'2023-10-23','22:01:39','Venda','E',6.00,316,'Espécie'),(66,'2023-10-23','22:07:10','Venda','E',6.00,316,'Espécie'),(67,'2023-10-23','22:08:11','Venda','E',6.00,317,'Espécie'),(68,'2023-10-23','22:09:01','Venda','E',6.00,317,'Espécie'),(69,'2023-10-23','22:09:43','Venda','E',6.00,317,'Espécie'),(70,'2023-10-23','22:11:32','Venda','E',6.00,317,'Espécie'),(71,'2023-10-23','22:12:23','Venda','E',6.00,317,'Espécie'),(72,'2023-10-23','22:14:27','Venda','E',6.00,318,'Espécie'),(73,'2023-10-23','22:15:34','Venda','E',6.00,318,'Espécie'),(74,'2023-10-23','22:17:17','Venda','E',6.00,319,'Espécie'),(75,'2023-10-23','22:19:49','Venda','E',6.00,319,'Espécie'),(76,'2023-10-23','22:20:05','Compra','S',2.50,319,'Espécie'),(77,'2023-10-23','22:25:46','Venda','E',2.50,319,'Espécie'),(78,'2023-10-23','22:28:32','Venda','E',9.00,319,'Espécie'),(79,'2023-10-23','22:29:22','Venda','E',9.00,320,'Cartão de Débito'),(80,'2023-10-23','22:29:35','Compra','S',13.50,320,'PIX'),(81,'2023-10-23','22:55:46','Venda','E',1250.00,320,'Espécie'),(82,'2023-10-23','22:55:56','Venda','E',4.50,320,'Cartão de Débito'),(83,'2023-10-23','23:03:19','Compra','S',13.50,321,'Espécie'),(84,'2023-10-23','23:05:24','Venda','E',3.00,322,'PIX'),(85,'2023-10-23','23:05:43','Compra','S',4.50,322,'Espécie'),(86,'2023-10-24','10:05:42','Compra','S',9.00,325,'PIX'),(87,'2023-10-24','10:07:41','Compra','S',16.00,326,'PIX'),(88,'2023-10-24','10:11:34','Compra','S',66.00,327,'PIX'),(89,'2023-10-24','10:12:18','Venda','E',54.50,327,'Cartão de Débito'),(90,'2023-10-24','10:12:33','Venda','E',7.50,327,'Espécie'),(91,'2023-10-24','10:14:04','Venda','E',20.00,328,'Espécie'),(92,'2023-10-24','17:30:58','Venda','E',15.00,330,'Crediário Indis.'),(93,'2023-10-24','17:32:19','Venda','E',3.00,330,'PIX'),(94,'2023-10-24','17:34:38','Venda','E',3.00,331,'Crediário Indis.'),(95,'2023-10-24','17:35:27','Venda','E',4.50,331,'Espécie'),(96,'2023-10-24','17:40:15','Venda','E',4.50,331,'Espécie'),(97,'2023-10-24','17:40:59','Venda','E',4.50,331,'Espécie'),(98,'2023-10-24','17:43:39','Venda','E',2.50,331,'Espécie'),(99,'2023-10-24','17:46:29','Venda','E',4.50,331,'Espécie'),(100,'2023-10-24','17:48:15','Venda','E',4.50,332,'Espécie'),(101,'2023-10-24','18:05:30','Venda','E',50.00,332,'Espécie'),(102,'2023-10-24','18:09:57','Venda','E',4.50,332,'Espécie'),(103,'2023-10-24','18:12:19','Venda','E',6.00,332,'Espécie'),(104,'2023-10-24','18:13:20','Venda','E',3.00,332,'Espécie'),(105,'2023-10-24','18:13:31','Venda','E',3.00,332,'Espécie'),(106,'2023-10-24','18:14:46','Venda','E',3.00,332,'Espécie'),(107,'2023-10-24','18:16:57','Venda','E',3.00,332,'Espécie'),(108,'2023-10-24','18:19:23','Venda','E',50.00,332,'Espécie'),(109,'2023-10-24','18:20:17','Venda','E',2.50,332,'Espécie'),(110,'2023-10-24','18:20:46','Venda','E',3.00,332,'Espécie'),(111,'2023-10-24','18:22:07','Venda','E',4.50,332,'Espécie'),(112,'2023-10-24','18:23:26','Venda','E',2.50,332,'Espécie'),(113,'2023-10-24','18:26:51','Venda','E',3.00,332,'Espécie'),(114,'2023-10-24','18:31:35','Venda','E',3.00,332,'Espécie'),(115,'2023-10-24','18:34:03','Venda','E',4.50,332,'Espécie'),(116,'2023-10-24','18:39:45','Venda','E',12.00,332,'Espécie'),(117,'2023-10-24','18:50:21','Venda','E',100.00,333,'Espécie'),(118,'2023-10-24','18:54:48','Venda','E',4.50,333,'Espécie'),(119,'2023-10-24','19:03:43','Venda','E',4.50,333,'Espécie'),(120,'2023-10-24','19:04:10','Venda','E',63.00,333,'Espécie'),(121,'2023-10-24','19:08:42','Venda','E',3.00,333,'Espécie'),(122,'2023-10-24','19:11:28','Venda','E',50.00,333,'Espécie'),(123,'2023-10-24','19:40:00','Venda','E',3.00,333,'Espécie'),(124,'2023-10-24','19:41:30','Venda','E',0.00,333,'Crediário'),(125,'2023-10-24','19:43:55','Venda','E',15.00,334,'Espécie'),(126,'2023-10-24','19:44:11','Venda','E',49.50,334,'Crediário'),(127,'2023-10-24','19:51:00','Venda','E',6.00,336,'Crediário'),(128,'2023-10-24','19:54:23','Venda','E',3.00,336,'Espécie'),(129,'2023-10-24','20:08:30','Venda','E',6.00,336,'Espécie'),(130,'2023-10-24','20:08:47','Venda','E',3.00,336,'Crediário'),(131,'2023-10-24','20:09:55','Compra','S',18.00,337,'Crediário'),(132,'2023-10-24','20:12:26','Compra','S',36.00,337,'Crediário'),(133,'2023-10-24','20:15:47','Compra','S',200.00,337,'Crediário');
/*!40000 ALTER TABLE `movimento_caixa` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-10-25 22:02:02
