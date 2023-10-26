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
  `Forma_Pagamento_id_forma_pagamento` int NOT NULL,
  `Venda_id_venda` int NOT NULL,
  PRIMARY KEY (`Forma_Pagamento_id_forma_pagamento`,`Venda_id_venda`),
  KEY `fk_Form_Pagamento_Venda_Forma_Pagamento1_idx` (`Forma_Pagamento_id_forma_pagamento`),
  KEY `fk_Form_Pagamento_Venda_Venda1` (`Venda_id_venda`),
  CONSTRAINT `fk_Form_Pagamento_Venda_Forma_Pagamento1` FOREIGN KEY (`Forma_Pagamento_id_forma_pagamento`) REFERENCES `forma_pagamento` (`id_forma_pagamento`),
  CONSTRAINT `fk_Form_Pagamento_Venda_Venda1` FOREIGN KEY (`Venda_id_venda`) REFERENCES `venda` (`id_venda`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `form_pagamento_venda`
--

LOCK TABLES `form_pagamento_venda` WRITE;
/*!40000 ALTER TABLE `form_pagamento_venda` DISABLE KEYS */;
INSERT INTO `form_pagamento_venda` VALUES (36.00,1,69),(34.50,1,70),(70.50,1,71),(24.00,1,72),(10.00,1,73),(27.00,1,74),(48.00,1,76),(12.50,1,77),(2.50,1,78),(12.00,1,80),(12.00,1,81),(12.00,1,82),(5.00,1,83),(4.50,1,85),(4.50,1,86),(3.00,1,87),(5.00,1,88),(3.00,1,89),(22.50,1,90),(55.50,1,92),(3.00,1,93),(10.00,1,103),(202.50,1,112),(42.00,1,113),(80.00,1,114),(4.50,1,115),(9.00,1,119),(22.50,1,120),(1261.50,1,138),(8.00,1,140),(3.00,1,141),(4.50,1,143),(4.50,1,145),(4.50,1,147),(4.50,1,149),(4.50,1,151),(50.00,1,153),(50.00,1,155),(4.50,1,157),(3.00,1,159),(100.00,1,161),(4.50,1,163),(3.00,1,165),(3.00,1,167),(9.75,1,169),(3.50,1,171),(4.50,1,173),(50.00,1,175),(4.50,1,177),(4.50,1,179),(4.50,1,180),(6.00,1,182),(6.00,1,184),(3.00,1,185),(9.00,1,186),(6.00,1,187),(7.00,1,196),(4.50,1,197),(4.50,1,206),(2.50,1,207),(4.50,1,208),(7.50,1,210),(12.00,1,214),(3.00,1,221),(16.00,1,223),(3.00,1,225),(4.50,1,226),(5.00,1,228),(10.00,1,230),(3.00,1,231),(4.50,1,232),(3.00,1,233),(2.50,1,234),(4.50,1,236),(0.00,1,237),(4.50,1,239),(3.00,1,243),(5.00,1,244),(28.50,1,245),(0.00,1,248),(4.50,1,249),(3.00,1,250),(2.50,1,252),(2.00,1,253),(13.50,1,254),(3.00,1,255),(108.00,1,256),(9.00,1,258),(4.50,1,259),(82.00,1,260),(5.00,1,261),(36.00,1,262),(3.00,1,263),(3.00,1,264),(12.00,1,266),(3.00,1,267),(3.00,1,272),(3.00,1,273),(3.00,1,274),(3.00,1,278),(50.00,1,280),(12.00,1,282),(30.00,1,283),(15.00,1,284),(3.00,1,286),(12.00,1,287),(3.00,1,288),(4.50,1,289),(197.00,1,290),(3.00,1,291),(50.00,1,292),(50.00,1,293),(6.00,1,294),(22.50,1,295),(3.00,1,297),(9.00,1,298),(50.00,1,299),(9.00,1,301),(1250.00,1,303),(7.50,1,308),(20.00,1,309),(4.50,1,313),(4.50,1,314),(4.50,1,315),(2.50,1,316),(4.50,1,317),(4.50,1,318),(50.00,1,319),(4.50,1,320),(6.00,1,321),(3.00,1,322),(3.00,1,323),(3.00,1,324),(3.00,1,325),(50.00,1,326),(2.50,1,327),(3.00,1,328),(4.50,1,329),(2.50,1,330),(3.00,1,331),(3.00,1,332),(4.50,1,333),(12.00,1,334),(100.00,1,335),(4.50,1,336),(4.50,1,337),(63.00,1,338),(3.00,1,339),(50.00,1,340),(3.00,1,341),(15.00,1,344),(3.00,1,351),(6.00,1,355),(12.00,2,251),(6.00,2,268),(9.00,2,271),(4.50,2,285),(3.00,2,306),(3.00,2,311),(48.00,3,76),(17.50,3,91),(1.50,3,257),(3.00,3,269),(50.00,3,277),(2.00,3,281),(4.50,4,265),(12.00,4,270),(3.00,4,275),(6.00,4,276),(9.00,4,302),(4.50,4,304),(54.50,4,307),(15.00,5,310),(3.00,5,312),(0.00,5,342),(49.50,5,345),(6.00,5,350),(3.00,5,356);
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

-- Dump completed on 2023-10-25 22:02:02
