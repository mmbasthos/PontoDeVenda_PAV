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
-- Table structure for table `item_compra`
--

DROP TABLE IF EXISTS `item_compra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `item_compra` (
  `id_item_compra` int NOT NULL AUTO_INCREMENT,
  `Compra_id_compra` int NOT NULL,
  `Produto_id_produto` int NOT NULL,
  `quantidade_compra` int DEFAULT NULL,
  `valor_unitario_compra` decimal(10,2) DEFAULT NULL,
  `total_item_compra` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`id_item_compra`,`Compra_id_compra`),
  KEY `fk_Compra_has_Produto_Produto1_idx` (`Produto_id_produto`),
  KEY `fk_Compra_has_Produto_Compra1_idx` (`Compra_id_compra`),
  CONSTRAINT `fk_Compra_has_Produto_Compra1` FOREIGN KEY (`Compra_id_compra`) REFERENCES `compra` (`id_compra`),
  CONSTRAINT `fk_Compra_has_Produto_Produto1` FOREIGN KEY (`Produto_id_produto`) REFERENCES `produto` (`id_produto`)
) ENGINE=InnoDB AUTO_INCREMENT=101 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `item_compra`
--

LOCK TABLES `item_compra` WRITE;
/*!40000 ALTER TABLE `item_compra` DISABLE KEYS */;
INSERT INTO `item_compra` VALUES (1,11,34,1,3.00,3.00),(2,12,65,4,4.50,18.00),(3,13,43,1,4.50,4.50),(4,14,43,1,4.50,4.50),(5,14,43,1,4.50,4.50),(6,14,41,1,2.50,2.50),(7,14,41,1,2.50,2.50),(8,15,34,1,3.00,3.00),(9,15,34,1,3.00,3.00),(10,15,34,1,3.00,3.00),(11,16,34,1,3.00,3.00),(12,16,34,3,3.00,9.00),(13,17,34,1,3.00,3.00),(14,18,43,1,4.50,4.50),(15,18,45,1,12.00,12.00),(16,19,34,1,3.00,3.00),(17,20,34,1,3.00,3.00),(18,20,34,1,3.00,3.00),(19,20,34,1,3.00,3.00),(20,20,34,1,3.00,3.00),(21,21,43,1,4.50,4.50),(22,21,43,1,4.50,4.50),(23,23,54,4,2.50,10.00),(24,24,23,1,50.00,50.00),(25,25,7,1,5.00,5.00),(26,25,7,1,5.00,5.00),(27,26,7,1,5.00,5.00),(28,26,8,1,4.50,4.50),(29,27,7,6,5.00,30.00),(30,28,87,1,3.50,3.50),(31,28,87,1,3.50,3.50),(32,29,8,1,4.50,4.50),(33,30,34,1,3.00,3.00),(34,31,34,1,3.00,3.00),(35,32,43,1,4.50,4.50),(38,35,7,1,5.00,5.00),(39,36,7,1,5.00,5.00),(40,36,7,1,5.00,5.00),(41,37,43,1,4.50,4.50),(42,38,45,1,12.00,12.00),(43,39,9,1,1.00,1.00),(44,41,54,1,2.50,2.50),(45,42,43,1,4.50,4.50),(46,43,54,1,2.50,2.50),(47,44,34,1,3.00,3.00),(48,45,34,1,3.00,3.00),(49,46,43,1,4.50,4.50),(50,47,53,1,1.50,1.50),(51,48,32,1,6.00,6.00),(52,49,32,1,6.00,6.00),(53,50,32,1,6.00,6.00),(54,51,43,1,4.50,4.50),(55,52,43,1,4.50,4.50),(56,53,23,1,50.00,50.00),(57,54,32,1,6.00,6.00),(58,55,54,1,2.50,2.50),(59,56,34,1,3.00,3.00),(60,57,34,1,3.00,3.00),(61,58,44,1,6.00,6.00),(62,59,7,5,5.00,25.00),(63,60,45,1,12.00,12.00),(64,61,7,7,5.00,35.00),(65,62,34,1,3.00,3.00),(66,63,45,1,12.00,12.00),(67,64,45,1,12.00,12.00),(68,65,45,1,12.00,12.00),(69,66,34,1,3.00,3.00),(70,67,34,1,3.00,3.00),(71,68,34,1,3.00,3.00),(72,68,34,4,3.00,12.00),(73,69,43,1,4.50,4.50),(74,70,34,1,3.00,3.00),(75,71,34,1,3.00,3.00),(76,72,8,1,4.50,4.50),(77,73,67,1,5.00,5.00),(78,74,89,1,6.50,6.50),(79,75,8,1,4.50,4.50),(80,76,23,1,50.00,50.00),(81,77,25,1,2.75,2.75),(82,78,32,1,6.00,6.00),(83,79,67,6,5.00,30.00),(84,80,78,1,2.00,2.00),(85,81,34,1,3.00,3.00),(86,81,34,1,3.00,3.00),(87,82,54,1,2.50,2.50),(88,83,43,3,4.50,13.50),(89,84,43,3,4.50,13.50),(90,85,43,1,4.50,4.50),(91,86,34,1,3.00,3.00),(92,87,34,1,3.00,3.00),(93,88,34,3,3.00,9.00),(94,89,32,1,6.00,6.00),(95,89,54,4,2.50,10.00),(96,90,43,4,4.50,18.00),(97,90,45,4,12.00,48.00),(98,91,34,6,3.00,18.00),(99,92,43,8,4.50,36.00),(100,93,23,4,50.00,200.00);
/*!40000 ALTER TABLE `item_compra` ENABLE KEYS */;
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
