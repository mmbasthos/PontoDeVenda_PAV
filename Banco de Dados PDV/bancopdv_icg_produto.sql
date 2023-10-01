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
-- Table structure for table `produto`
--

DROP TABLE IF EXISTS `produto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `produto` (
  `id_produto` int NOT NULL AUTO_INCREMENT,
  `Fornecedor_id_fornecedor` int NOT NULL,
  `nome_produto` varchar(60) DEFAULT NULL,
  `quantidade_produto` int DEFAULT NULL,
  `preco_produto` decimal(10,2) DEFAULT NULL,
  `id_classe` int NOT NULL,
  PRIMARY KEY (`id_produto`,`id_classe`),
  KEY `fk_Produto_Fornecedor1_idx` (`Fornecedor_id_fornecedor`),
  KEY `fk_Produto_classe_produto1_idx` (`id_classe`),
  CONSTRAINT `fk_Produto_classe_produto1` FOREIGN KEY (`id_classe`) REFERENCES `classe_produto` (`id_classe`),
  CONSTRAINT `fk_Produto_Fornecedor1` FOREIGN KEY (`Fornecedor_id_fornecedor`) REFERENCES `fornecedor` (`id_fornecedor`)
) ENGINE=InnoDB AUTO_INCREMENT=132 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `produto`
--

LOCK TABLES `produto` WRITE;
/*!40000 ALTER TABLE `produto` DISABLE KEYS */;
INSERT INTO `produto` VALUES (7,16,'Coca-Cola 2L',40,5.00,64),(8,17,'Guaraná Antarctica 2L',35,4.50,64),(9,20,'Água Mineral 500ml',100,1.00,64),(10,43,'Smartphone Modelo X',20,1200.00,43),(11,44,'Tablet Modelo Y',15,800.00,43),(12,45,'Camiseta Estampada',50,25.00,44),(13,46,'Bolsa de Couro',30,50.00,44),(14,16,'Máquina de Envase Automático',10,5000.00,39),(15,19,'Misturador Industrial',8,8000.00,39),(16,24,'Embaladora a Vácuo',5,12000.00,39),(18,17,'Guaraná Antarctica 2L',35,4.50,64),(19,20,'Água Mineral 500ml',100,1.00,64),(20,43,'Smartphone Modelo X',20,1200.00,43),(21,44,'Tablet Modelo Y',15,800.00,43),(22,45,'Camiseta Estampada',50,25.00,44),(23,46,'Bolsa de Couro',30,50.00,44),(24,16,'Maçãs',50,3.50,59),(25,17,'Bananas',60,2.75,59),(26,19,'Tomates',40,4.00,59),(27,24,'Peito de Frango',30,8.50,60),(28,31,'Coxa de Frango',25,7.75,60),(29,34,'Alcatra',20,12.00,60),(30,23,'Salmão Fresco',15,20.00,61),(31,24,'Camarão Congelado',18,15.75,61),(32,31,'Atum em Lata',40,6.00,61),(33,19,'Queijo Mussarela',20,8.50,62),(34,25,'Leite Integral',50,3.00,62),(35,29,'Ovos (dúzia)',30,4.50,62),(36,26,'Pão Francês',80,1.50,63),(37,36,'Bolo de Chocolate',10,15.00,63),(38,37,'Croissant',25,2.00,63),(39,16,'Maçãs',50,3.50,59),(40,16,'Arroz Integral',30,5.00,40),(41,16,'Biscoitos de Chocolate',40,2.50,40),(42,17,'Bananas',60,2.75,59),(43,17,'Aveia em Flocos',25,4.50,40),(44,17,'Granola',20,6.00,40),(45,28,'Azeite de Oliva Extra Virgem',15,12.00,40),(46,18,'Feijão Preto',40,4.00,40),(47,18,'Pão de Forma Integral',30,3.00,63),(48,19,'Tomates',40,4.00,59),(49,19,'Leite Condensado',20,3.50,40),(50,19,'Cookies de Aveia',35,3.00,40),(51,20,'Cenouras',50,2.00,59),(52,20,'Iogurte Natural',30,3.00,40),(53,20,'Barra de Cereal',45,1.50,40),(54,21,'Abacaxi',40,2.50,59),(55,21,'Molho de Tomate',25,2.00,39),(56,21,'Barras de Cereais',30,2.00,40),(57,22,'Laranjas',50,3.00,59),(58,22,'Massa de Lasanha',15,4.00,39),(59,22,'Chips de Batata Doce',30,3.50,40),(60,23,'Kiwi',40,3.50,59),(61,23,'Sopas Instantâneas',20,2.50,40),(62,23,'Mix de Castanhas',25,6.50,40),(63,24,'Peito de Frango',30,8.50,60),(64,24,'Molho de Pimenta',25,2.00,39),(65,24,'Geleia de Frutas',25,4.50,40),(66,16,'Maçãs (Fruit Delight)',50,3.50,59),(67,16,'Arroz Integral (Nature Grain)',30,5.00,40),(68,16,'Biscoitos de Chocolate (Sweet Treats)',40,2.50,40),(69,17,'Bananas (Fruit Delight)',60,2.75,59),(70,17,'Aveia em Flocos (Healthy Harvest)',25,4.50,40),(71,17,'Granola (Nature Boost)',20,6.00,40),(72,18,'Azeite de Oliva Extra Virgem (Olive Elegance)',15,12.00,39),(73,18,'Feijão Preto (Brazilian Harvest)',40,4.00,40),(74,18,'Pão de Forma Integral (Healthy Slice)',30,3.00,63),(75,19,'Tomates (Fresh Harvest)',40,4.00,59),(76,19,'Leite Condensado (Sweet Essence)',20,3.50,40),(77,19,'Cookies de Aveia (Nature Delight)',35,3.00,40),(78,20,'Cenouras (Fresh Harvest)',50,2.00,59),(79,20,'Iogurte Natural (Pro Health)',30,3.00,40),(80,20,'Barra de Cereal (Nutri Crunch)',45,1.50,40),(81,21,'Abacaxi (Fresh Harvest)',40,2.50,59),(82,21,'Molho de Tomate (Sauce Master)',25,2.00,39),(83,21,'Barras de Cereais (Nutri Boost)',30,2.00,40),(84,22,'Laranjas (Fresh Harvest)',50,3.00,59),(85,22,'Massa de Lasanha (Pasta Paradise)',15,4.00,39),(86,22,'Chips de Batata Doce (Crisp Delight)',30,3.50,40),(87,23,'Kiwi (Fresh Harvest)',40,3.50,59),(88,23,'Sopas Instantâneas (Quick Fix)',20,2.50,40),(89,23,'Mix de Castanhas (Nutty Mix)',25,6.50,40),(90,24,'Peito de Frango (Protein Power)',30,8.50,60),(91,24,'Molho de Pimenta (Spicy Flare)',25,2.00,39),(92,24,'Geleia de Frutas (Fruit Fusion)',25,4.50,40),(94,16,'Pepsi 2L',35,4.50,64),(95,17,'Guaraná Antarctica 2L',35,4.50,64),(96,17,'Fanta Laranja 2L',30,4.00,64),(97,18,'Aguaviva 1L',50,2.50,64),(98,18,'Sprite 2L',40,4.00,64),(99,19,'Nestea 1.5L',30,3.50,64),(100,19,'Sukita Uva 2L',30,3.50,64),(101,20,'Heineken Long Neck',25,2.75,65),(102,20,'Budweiser Long Neck',20,3.00,65),(103,21,'Absolut Vodka 750ml',15,50.00,65),(104,21,'Johnnie Walker Black Label 750ml',10,70.00,65),(105,22,'Chivas Regal 12 Anos 750ml',10,65.00,65),(106,22,'Baileys Irish Cream 750ml',12,45.00,65),(107,23,'Água de Coco 500ml',50,2.00,64),(108,23,'Suco de Laranja Integral 1L',40,4.00,64),(109,24,'Vinho Tinto Seco 750ml',20,30.00,65),(110,24,'Vinho Branco Suave 750ml',18,28.00,65),(111,25,'Leite de Coco 200ml',60,1.50,64),(112,25,'Chá Mate Leão 1L',45,2.00,64),(113,16,'Coca-Cola 600ml',50,3.50,64),(115,16,'Coca-Cola 5L (Galão)',20,12.00,64),(116,17,'Guaraná Antarctica 600ml',45,3.00,64),(117,17,'Guaraná Antarctica 2L',35,4.50,64),(118,17,'Guaraná Antarctica 5L (Galão)',15,10.00,64),(119,18,'Aguaviva 500ml',60,1.75,64),(120,18,'Aguaviva 1L',50,2.50,64),(121,18,'Aguaviva 5L (Galão)',25,8.00,64),(122,19,'Nestea 330ml',40,2.00,64),(123,19,'Nestea 1.5L',30,3.50,64),(124,19,'Nestea 5L (Galão)',20,7.00,64),(125,20,'Red Bull 250ml',40,6.00,64),(126,20,'Red Bull 473ml',30,8.00,64),(127,20,'Red Bull 1L (Galão)',15,15.00,64),(128,21,'Monster Energy 355ml',50,5.50,64),(129,21,'Monster Energy 473ml',40,6.50,64),(130,21,'Monster Energy 1L (Galão)',20,12.00,64),(131,16,'Revista Veja',340,750.00,50);
/*!40000 ALTER TABLE `produto` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-10-01 16:17:31
