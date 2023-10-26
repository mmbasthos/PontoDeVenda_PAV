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
-- Table structure for table `fornecedor`
--

DROP TABLE IF EXISTS `fornecedor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `fornecedor` (
  `id_fornecedor` int NOT NULL AUTO_INCREMENT,
  `nome_fornecedor` varchar(45) DEFAULT NULL,
  `cpf_cnpj_fornecedor` varchar(45) DEFAULT NULL,
  `logradouro_fornecedor` varchar(45) DEFAULT NULL,
  `numero_logradouro_fornecedor` varchar(45) DEFAULT NULL,
  `complemento_fornecedor` varchar(45) DEFAULT NULL,
  `bairro_fornecedor` varchar(45) DEFAULT NULL,
  `cidade_fornecedor` varchar(45) DEFAULT NULL,
  `estado_fornecedor` varchar(45) DEFAULT NULL,
  `cep_fornecedor` varchar(45) DEFAULT NULL,
  `telefone_fornecedor` varchar(45) DEFAULT NULL,
  `email_fornecedor` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id_fornecedor`)
) ENGINE=InnoDB AUTO_INCREMENT=47 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `fornecedor`
--

LOCK TABLES `fornecedor` WRITE;
/*!40000 ALTER TABLE `fornecedor` DISABLE KEYS */;
INSERT INTO `fornecedor` VALUES (16,'The Coca-Cola Company','12345678900001','Rua das Amoreiras','123','Sala 101','Centro','São Paulo','SP','01234-567','(11) 9876-5432','info@coca-cola.com'),(17,'Ambev S.A.','98765432100001','Avenida Brasil','456','Loja 202','Centro','Rio de Janeiro','RJ','89012-345','(21) 1234-5678','sac@ambev.com.br'),(18,'PepsiCo Inc.','1122334455667788','Avenida Paulista','789','Andar 15','Bela Vista','São Paulo','SP','04567-890','(11) 3456-7890','info@pepsico.com'),(19,'Nestlé S.A.','9988776655443322','Rua do Comércio','101','Bloco C','Centro','Belo Horizonte','MG','30123-456','(31) 2345-6789','contact@nestle.com'),(20,'Heineken N.V.','66554433221100','Rua das Palmeiras','202','Sala 303','Centro','Salvador','BA','40020-300','(71) 9876-5432','info@heineken.com'),(21,'Pernod Ricard SA','7766554433221100','Avenida das Flores','303','Bloco B','Jardim','Curitiba','PR','80040-100','(41) 3456-7890','contact@pernod-ricard.com'),(22,'Diageo plc','8899776655443322','Rua do Porto','404','Sala 505','Centro','Recife','PE','50030-320','(81) 2345-6789','contact@diageo.com.br'),(23,'Danone S.A.','112233445566778899','Rua das Frutas','10','Loja 5','Centro','São Paulo','SP','01234-567','(11) 9876-5432','sac@danone.com'),(24,'JBS S.A.','998877665544332211','Avenida do Boi','123','Frigorífico 3','Bairro Novo','Goiânia','GO','74000-000','(62) 3456-7890','contato@jbs.com.br'),(25,'Unilever PLC','776655443322110000','Rua dos Sabonetes','456','Andar 2','Centro','Belo Horizonte','MG','30123-456','(31) 2345-6789','contato@unilever.com'),(26,'Carrefour Brasil','88997766554433221100','Avenida das Compras','789','Sala 303','Centro','São Paulo','SP','01234-567','(11) 3456-7890','sac@carrefour.com.br'),(27,'Bunge Ltda.','776655443322110022','Rua dos Grãos','202','Bloco A','Centro','Porto Alegre','RS','90000-000','(51) 2345-6789','contato@bunge.com'),(28,'Nestlé Purina PetCare','99887766554433221100','Rua dos Animais','404','Setor de Pets','Centro','Brasília','DF','70000-000','(61) 2345-6789','contato@purina.com'),(29,'Procter & Gamble','88997766554433221100','Avenida das Marcas','505','Sala 606','Centro','São Paulo','SP','01234-567','(11) 3456-7890','contato@pg.com'),(30,'Mondelez International','99887766554433221100','Rua dos Chocolates','303','Fábrica 1','Centro','Curitiba','PR','80000-000','(41) 2345-6789','contato@mondelez.com'),(31,'Sadia S.A.','112233445566778899','Avenida das Aves','1','Frigorífico 1','Bairro Novo','Chapecó','SC','89812-345','(49) 2345-6789','sac@sadia.com.br'),(32,'Alpargatas S.A.','998877665544332211','Rua das Sandálias','101','Loja 3','Centro','São Paulo','SP','01234-567','(11) 3456-7890','contato@alpargatas.com.br'),(33,'Panco Indústrias Alimentícias Ltda.','776655443322110022','Rua dos Panetones','202','Setor de Produção','Centro','Campinas','SP','13000-000','(19) 2345-6789','contato@panco.com'),(34,'O Boticário Comércio e Indústria Ltda.','99887766554433221100','Avenida das Fragrâncias','505','Sala 606','Centro','Curitiba','PR','80000-000','(41) 2345-6789','contato@oboticario.com.br'),(35,'Ypê Indústria Química S.A.','99887766554433221100','Rua das Limpezas','303','Fábrica 1','Centro','Araçatuba','SP','16000-000','(18) 2345-6789','contato@ype.com.br'),(36,'Casas Bahia Ltda.','112233445566778899','Avenida das Ofertas','1','Loja 101','Centro','São Caetano do Sul','SP','09510-100','(11) 2345-6789','sac@casasbahia.com.br'),(37,'Companhia Brasileira de Distribuição','998877665544332211','Rua dos Supermercados','101','Setor de Compras','Centro','São Paulo','SP','01234-567','(11) 3456-7890','contato@extra.com.br'),(38,'Magazine Luiza S.A.','776655443322110022','Avenida das Lojas','202','Bloco B','Centro','Franca','SP','14400-000','(16) 2345-6789','contato@magazineluiza.com.br'),(39,'Lojas Renner S.A.','99887766554433221100','Rua da Moda','505','Sala 606','Centro','Porto Alegre','RS','90000-000','(51) 2345-6789','contato@renner.com.br'),(40,'Oi S.A.','99887766554433221100','Avenida das Comunicações','505','Sala 606','Centro','Rio de Janeiro','RJ','20000-000','(21) 2345-6789','contato@oi.com.br'),(41,'Gourmet Delights','12.345.678/0001-01','Rua dos Sabores','123','Sala 101','Bairro Gourmet','São Paulo','SP','01234-567','(11) 9876-5432','gourmet.delights@email.com'),(42,'Fresh Harvest','98.765.432/0001-02','Avenida das Frutas','456','Andar 2','Bairro Fresco','Rio de Janeiro','RJ','89012-345','(21) 1234-5678','fresh.harvest@email.com'),(43,'Tech Innovators','45.678.901/0001-03','Rua da Inovação','789','Sala 303','Bairro Tech','São Paulo','SP','04567-890','(11) 2345-6789','tech.innovators@email.com'),(44,'Future Gadgets','23.456.789/0001-04','Avenida das Novidades','101','Bloco B','Bairro Futuro','Rio de Janeiro','RJ','45678-901','(21) 9876-5432','future.gadgets@email.com'),(45,'Chic Styles','34.567.890/0001-05','Rua da Moda','202','Loja 1','Bairro Fashion','São Paulo','SP','05678-901','(11) 3456-7890','chic.styles@email.com'),(46,'Trendy Creations','56.789.012/0001-06','Avenida das Tendências','303','Andar 2','Bairro Trend','Rio de Janeiro','RJ','67890-123','(21) 2345-6789','trendy.creations@email.com');
/*!40000 ALTER TABLE `fornecedor` ENABLE KEYS */;
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
