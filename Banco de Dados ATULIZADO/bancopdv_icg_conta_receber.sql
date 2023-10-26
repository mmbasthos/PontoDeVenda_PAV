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
-- Table structure for table `conta_receber`
--

DROP TABLE IF EXISTS `conta_receber`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `conta_receber` (
  `id_conta_receber` int NOT NULL AUTO_INCREMENT,
  `descricao_receber` varchar(200) DEFAULT NULL,
  `data_lancamento` date DEFAULT NULL,
  `data_vencimento` date DEFAULT NULL,
  `valor_total` decimal(10,2) DEFAULT NULL,
  `valor_recebido` decimal(10,2) DEFAULT NULL,
  `data_recebimento` date DEFAULT NULL,
  `valor_recebimento` decimal(10,2) DEFAULT NULL,
  `Cliente_id_cliente` int NOT NULL,
  PRIMARY KEY (`id_conta_receber`),
  KEY `fk_Conta_Receber_Cliente1_idx` (`Cliente_id_cliente`),
  CONSTRAINT `fk_Conta_Receber_Cliente1` FOREIGN KEY (`Cliente_id_cliente`) REFERENCES `cliente` (`id_cliente`)
) ENGINE=InnoDB AUTO_INCREMENT=34 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `conta_receber`
--

LOCK TABLES `conta_receber` WRITE;
/*!40000 ALTER TABLE `conta_receber` DISABLE KEYS */;
INSERT INTO `conta_receber` VALUES (1,'parcela','2023-10-24','2023-10-24',0.00,0.00,'2023-10-24',0.00,1),(2,'parcela','2023-10-24','2023-10-24',0.00,0.00,'2023-10-24',0.00,1),(3,'parcela','2023-10-24','2023-10-24',0.00,0.00,'2023-10-24',0.00,1),(4,'Parcela1','2023-10-24','2023-10-24',63.00,0.00,'2023-10-24',31.50,1),(5,'Parcela2','2023-10-24','2023-11-23',63.00,0.00,'2023-10-24',31.50,1),(6,'Parcela1','2023-10-24','2023-10-24',50.00,0.00,'2023-10-24',12.50,1),(7,'Parcela2','2023-10-24','2023-11-23',50.00,0.00,'2023-10-24',12.50,1),(8,'Parcela3','2023-10-24','2023-12-23',50.00,0.00,'2023-10-24',12.50,1),(9,'Parcela4','2023-10-24','2024-01-22',50.00,0.00,'2023-10-24',12.50,1),(10,'Parcela1','2023-10-24','2023-10-24',0.00,0.00,'2023-10-24',0.00,1),(11,'Parcela2','2023-10-24','2023-11-23',0.00,0.00,'2023-10-24',0.00,1),(12,'Parcela3','2023-10-24','2023-12-23',0.00,0.00,'2023-10-24',0.00,1),(13,'Parcela4','2023-10-24','2024-01-22',0.00,0.00,'2023-10-24',0.00,1),(14,'Parcela5','2023-10-24','2024-02-21',0.00,0.00,'2023-10-24',0.00,1),(15,'Parcela6','2023-10-24','2024-03-22',0.00,0.00,'2023-10-24',0.00,1),(16,'Parcela7','2023-10-24','2024-04-21',0.00,0.00,'2023-10-24',0.00,1),(17,'Parcela8','2023-10-24','2024-05-21',0.00,0.00,'2023-10-24',0.00,1),(18,'Parcela9','2023-10-24','2024-06-20',0.00,0.00,'2023-10-24',0.00,1),(19,'Parcela10','2023-10-24','2024-07-20',0.00,0.00,'2023-10-24',0.00,1),(20,'Parcela1','2023-10-24','2023-10-24',49.50,0.00,'2023-10-24',6.19,1),(21,'Parcela2','2023-10-24','2023-11-23',49.50,0.00,'2023-10-24',6.19,1),(22,'Parcela3','2023-10-24','2023-12-23',49.50,0.00,'2023-10-24',6.19,1),(23,'Parcela4','2023-10-24','2024-01-22',49.50,0.00,'2023-10-24',6.19,1),(24,'Parcela5','2023-10-24','2024-02-21',49.50,0.00,'2023-10-24',6.19,1),(25,'Parcela6','2023-10-24','2024-03-22',49.50,0.00,'2023-10-24',6.19,1),(26,'Parcela7','2023-10-24','2024-04-21',49.50,0.00,'2023-10-24',6.19,1),(27,'Parcela8','2023-10-24','2024-05-21',49.50,0.00,'2023-10-24',6.19,1),(28,'Parcela1','2023-10-24','2023-10-24',6.00,0.00,'2023-10-24',2.00,1),(29,'Parcela2','2023-10-24','2023-11-23',6.00,0.00,'2023-10-24',2.00,1),(30,'Parcela3','2023-10-24','2023-12-23',6.00,0.00,'2023-10-24',2.00,1),(31,'Parcela1','2023-10-24','2023-10-24',3.00,0.00,'2023-10-24',1.00,63),(32,'Parcela2','2023-10-24','2023-11-23',3.00,0.00,'2023-10-24',1.00,63),(33,'Parcela3','2023-10-24','2023-12-23',3.00,0.00,'2023-10-24',1.00,63);
/*!40000 ALTER TABLE `conta_receber` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-10-25 22:02:01
