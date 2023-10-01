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
-- Table structure for table `form_pagamento_venda`
--

DROP TABLE IF EXISTS `form_pagamento_venda`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `form_pagamento_venda` (
  `valor_forma_pagamento` decimal(10,2) DEFAULT NULL,
  `Forma_Pagamento_id_forma_pagamento` int NOT NULL AUTO_INCREMENT,
  `Venda_id_venda` int NOT NULL,
  PRIMARY KEY (`Forma_Pagamento_id_forma_pagamento`,`Venda_id_venda`),
  KEY `fk_Form_Pagamento_Venda_Forma_Pagamento1_idx` (`Forma_Pagamento_id_forma_pagamento`),
  KEY `fk_Form_Pagamento_Venda_Venda1_idx` (`Venda_id_venda`),
  CONSTRAINT `fk_Form_Pagamento_Venda_Forma_Pagamento1` FOREIGN KEY (`Forma_Pagamento_id_forma_pagamento`) REFERENCES `forma_pagamento` (`id_forma_pagamento`),
  CONSTRAINT `fk_Form_Pagamento_Venda_Venda1` FOREIGN KEY (`Venda_id_venda`) REFERENCES `venda` (`id_venda`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `form_pagamento_venda`
--

LOCK TABLES `form_pagamento_venda` WRITE;
/*!40000 ALTER TABLE `form_pagamento_venda` DISABLE KEYS */;
/*!40000 ALTER TABLE `form_pagamento_venda` ENABLE KEYS */;
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
