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
-- Table structure for table `form_pagamento_compra`
--

DROP TABLE IF EXISTS `form_pagamento_compra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `form_pagamento_compra` (
  `valor_forma_pagamento` decimal(10,0) DEFAULT NULL,
  `Compra_id_compra` int NOT NULL,
  `Forma_Pagamento_id_forma_pagamento` int NOT NULL,
  PRIMARY KEY (`Compra_id_compra`,`Forma_Pagamento_id_forma_pagamento`),
  KEY `Forma_Pagamento_id_forma_pagamento_idx` (`Forma_Pagamento_id_forma_pagamento`),
  KEY `Compra_id_compra_idx` (`Compra_id_compra`),
  CONSTRAINT `Compra_id_compra` FOREIGN KEY (`Compra_id_compra`) REFERENCES `compra` (`id_compra`),
  CONSTRAINT `Forma_Pagamento_id_forma_pagamento` FOREIGN KEY (`Forma_Pagamento_id_forma_pagamento`) REFERENCES `forma_pagamento` (`id_forma_pagamento`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `form_pagamento_compra`
--

LOCK TABLES `form_pagamento_compra` WRITE;
/*!40000 ALTER TABLE `form_pagamento_compra` DISABLE KEYS */;
INSERT INTO `form_pagamento_compra` VALUES (5,21,1),(10,23,1),(50,24,1),(10,25,1),(10,26,1),(30,27,1),(0,34,1),(5,35,1),(5,37,1),(12,38,1),(1,39,1),(0,40,1),(3,41,1),(5,42,1),(3,43,1),(3,44,1),(3,45,1),(5,46,1),(2,47,1),(6,48,1),(6,49,1),(6,50,1),(5,51,1),(5,52,1),(50,53,1),(6,54,1),(3,55,1),(3,56,1),(3,57,2),(6,58,1),(25,59,1),(12,60,1),(35,61,1),(3,62,1),(12,63,1),(12,64,1),(12,65,1),(3,66,1),(3,67,2),(15,68,3),(5,69,3),(3,70,1),(3,71,1),(5,72,1),(5,73,3),(7,74,3),(5,75,4),(50,76,1),(3,77,1),(6,78,1),(30,79,1),(2,80,1),(6,81,1),(3,82,1),(14,83,2),(14,84,1),(5,85,1),(9,88,2),(16,89,2),(66,90,2),(18,91,5),(36,92,5),(200,93,5);
/*!40000 ALTER TABLE `form_pagamento_compra` ENABLE KEYS */;
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
