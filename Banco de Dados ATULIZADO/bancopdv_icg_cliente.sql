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
-- Table structure for table `cliente`
--

DROP TABLE IF EXISTS `cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cliente` (
  `id_cliente` int NOT NULL AUTO_INCREMENT,
  `nome_cliente` varchar(60) NOT NULL,
  `cpf_cnpj_cliente` varchar(45) NOT NULL,
  `logradouro_cliente` varchar(45) NOT NULL,
  `numero_logradouro_cliente` varchar(45) NOT NULL,
  `complemento_cliente` varchar(45) NOT NULL,
  `bairro_cliente` varchar(45) NOT NULL,
  `cidade_cliente` varchar(45) NOT NULL,
  `estado_cliente` varchar(45) NOT NULL,
  `cep_cliente` varchar(45) NOT NULL,
  `telefone_cliente` varchar(45) NOT NULL,
  `email_cliente` varchar(45) NOT NULL,
  PRIMARY KEY (`id_cliente`)
) ENGINE=InnoDB AUTO_INCREMENT=66 DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cliente`
--

LOCK TABLES `cliente` WRITE;
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
INSERT INTO `cliente` VALUES (1,'Cliente Não Identificado','00000000000','Endereço Não Informado','','','','','','','',''),(4,'Lúcia Mendes ','123.456.789-00','Rua das Flores','123','Apto 101','Jardim Primavera','São Paulo','SP','01234-567','(11) 9876-5432','lucia.mendes@email.com'),(5,'Rafael Silva Souza','987.654.321-00','Avenida Central','456','Casa 2','Centro','Rio de Janeiro','RJ','89012-345','(21) 1234-5678','rafael.silva@email.com'),(6,'Maria Santos','111.222.333-00','Rua dos Sabores','789','Andar 3','Bairro Novo','Salvador','BA','40020-300','(71) 9876-5432','maria.santos@email.com'),(7,'Luiz Carlos','444.555.666-00','Avenida das Árvores','101','Bloco C','Centro','Belo Horizonte','MG','30123-456','(31) 2345-6789','luiz.carlos@email.com'),(8,'Fernanda Lima','777.888.999-00','Rua das Ondas','202','Sala 303','Praia Azul','Fortaleza','CE','60000-000','(85) 3456-7890','fernanda.lima@email.com'),(11,'José Santos','111.222.333-00','Rua das Artes','101','Bloco A','Centro','Florianópolis','SC','88000-000','(48) 2345-6789','jose.santos@email.com'),(12,'Amanda Costa','333.444.555-00','Avenida das Cores','505','Bloco B','Jardim Primavera','São Paulo','SP','01234-567','(11) 9876-5432','amanda.costa@email.com'),(13,'Rodrigo Pereira','666.777.888-00','Rua das Letras','202','Bloco B','Centro','São Caetano do Sul','SP','09510-100','(11) 2345-6789','rodrigo.pereira@email.com'),(14,'Carlos Oliveira','555.666.777-00','Rua das Folhas','303','Bloco A','Centro','Porto Alegre','RS','90000-000','(51) 2345-6789','carlos.oliveira@email.com'),(16,'José Santos','111.222.333-00','Rua das Artes','101','Bloco A','Centro','Florianópolis','SC','88000-000','(48) 2345-6789','jose.santos@email.com'),(18,'Rodrigo Pereira','666.777.888-00','Rua das Letras','202','Bloco B','Centro','São Caetano do Sul','SP','09510-100','(11) 2345-6789','rodrigo.pereira@email.com'),(19,'Luciana Oliveira','555.666.777-00','Rua das Folhas','303','Bloco A','Centro','Porto Alegre','RS','90000-000','(51) 2345-6789','luciana.oliveira@email.com'),(20,'Marcos Silva','888.999.000-00','Avenida das Pedras','404','Bloco A','Bairro Novo','Curitiba','PR','80000-000','(41) 2345-6789','marcos.silva@email.com'),(21,'Ana Santos','111.222.333-00','Rua das Artes','101','Bloco A','Centro','Florianópolis','SC','88000-000','(48) 2345-6789','ana.santos@email.com'),(22,'Renato Costa','333.444.555-00','Avenida das Cores','505','Bloco B','Jardim Primavera','São Paulo','SP','01234-567','(11) 9876-5432','renato.costa@email.com'),(23,'Mariana Pereira','666.777.888-00','Rua das Letras','202','Bloco B','Centro','São Caetano do Sul','SP','09510-100','(11) 2345-6789','mariana.pereira@email.com'),(24,'Lucas Oliveira','555.666.777-00','Rua das Folhas','303','Bloco C','Centro','Porto Alegre','RS','90000-000','(51) 2345-6789','lucas.oliveira@email.com'),(25,'Vanessa Silva','888.999.000-00','Avenida das Pedras','404','Bloco C','Bairro Novo','Curitiba','PR','80000-000','(41) 2345-6789','vanessa.silva@email.com'),(26,'Paulo Santos','111.222.333-00','Rua das Artes','101','Bloco C','Centro','Florianópolis','SC','88000-000','(48) 2345-6789','paulo.santos@email.com'),(27,'Beatriz Costa','333.444.555-00','Avenida das Cores','505','Bloco C','Jardim Primavera','São Paulo','SP','01234-567','(11) 9876-5432','beatriz.costa@email.com'),(28,'Rafael Pereira','666.777.888-00','Rua das Letras','202','Bloco C','Centro','São Caetano do Sul','SP','09510-100','(11) 2345-6789','rafael.pereira@email.com'),(29,'Fernanda Oliveira','555.666.777-00','Rua das Folhas','303','Bloco C','Centro','Porto Alegre','RS','90000-000','(51) 2345-6789','fernanda.oliveira@email.com'),(30,'Marcos Silva','888.999.000-00','Avenida das Pedras','404','Bloco C','Bairro Novo','Curitiba','PR','80000-000','(41) 2345-6789','marcos.silva@email.com'),(31,'Luciana Santos','111.222.333-00','Rua das Artes','101','Bloco C','Centro','Florianópolis','SC','88000-000','(48) 2345-6789','luciana.santos@email.com'),(32,'Roberto Costa','333.444.555-00','Avenida das Cores','505','Bloco C','Jardim Primavera','São Paulo','SP','01234-567','(11) 9876-5432','roberto.costa@email.com'),(33,'Patrícia Pereira','666.777.888-00','Rua das Letras','202','Bloco C','Centro','São Caetano do Sul','SP','09510-100','(11) 2345-6789','patricia.pereira@email.com'),(34,'Carlos Oliveira','555.666.777-00','Rua das Flores','303','Bloco A','Centro','São Paulo','SP','01521-000','(11) 5555-5555','carlos@email.com'),(35,'Amanda Silva','888.999.000-00','Avenida Paulista','404','Bloco A','Bela Vista','São Paulo','SP','01310-100','(11) 4444-4444','amanda@email.com'),(36,'Fernando Santos','111.222.333-00','Rua Augusta','101','Bloco A','Consolação','São Paulo','SP','01305-000','(11) 3333-3333','fernando@email.com'),(37,'Mariana Costa','333.444.555-00','Rua Oscar Freire','505','Bloco B','Cerqueira César','São Paulo','SP','01426-001','(11) 2222-2222','mariana@email.com'),(38,'Pedro Pereira','666.777.888-00','Alameda Santos','202','Bloco B','Jardim Paulista','São Paulo','SP','01418-000','(11) 1111-1111','pedro@email.com'),(39,'Luana Oliveira','555.666.777-00','Rua Bela Cintra','303','Bloco C','Consolação','São Paulo','SP','01415-000','(11) 6666-6666','luana@email.com'),(40,'Rafaela Silva','888.999.000-00','Avenida Rebouças','404','Bloco C','Jardim Paulista','São Paulo','SP','05402-000','(11) 7777-7777','rafaela@email.com'),(41,'Isabella Lima','555.666.777-00','Rua Visconde de Pirajá','303','Bloco A','Ipanema','Rio de Janeiro','RJ','22410-003','(21) 5555-5555','isabella@email.com'),(42,'Leonardo Oliveira','888.999.000-00','Avenida Ataulfo de Paiva','404','Bloco A','Leblon','Rio de Janeiro','RJ','22440-032','(21) 4444-4444','leonardo@email.com'),(43,'Thiago Silva','111.222.333-00','Rua Farme de Amoedo','101','Bloco A','Ipanema','Rio de Janeiro','RJ','22420-020','(21) 3333-3333','thiago@email.com'),(44,'Luiza Costa','333.444.555-00','Rua Dias Ferreira','505','Bloco B','Leblon','Rio de Janeiro','RJ','22431-050','(21) 2222-2222','luiza@email.com'),(45,'Mateus Pereira','666.777.888-00','Rua Vinícius de Moraes','202','Bloco B','Ipanema','Rio de Janeiro','RJ','22411-010','(21) 1111-1111','mateus@email.com'),(46,'Lucas Oliveira','555.666.777-00','Rua Visconde de Caravelas','303','Bloco C','Botafogo','Rio de Janeiro','RJ','22271-022','(21) 6666-6666','lucas@email.com'),(47,'Marcela Silva','888.999.000-00','Rua São Clemente','404','Bloco C','Botafogo','Rio de Janeiro','RJ','22260-001','(21) 7777-7777','marcela@email.com'),(48,'Isabella Lima','555.666.777-00','Rua Visconde de Pirajá','303','Bloco A','Ipanema','Rio de Janeiro','RJ','22410-003','(21) 5555-5555','isabella@email.com'),(49,'Leonardo Oliveira','888.999.000-00','Avenida Ataulfo de Paiva','404','Bloco A','Leblon','Rio de Janeiro','RJ','22440-032','(21) 4444-4444','leonardo@email.com'),(50,'Thiago Silva','111.222.333-00','Rua Farme de Amoedo','101','Bloco A','Ipanema','Rio de Janeiro','RJ','22420-020','(21) 3333-3333','thiago@email.com'),(51,'Luiza Costa','333.444.555-00','Rua Dias Ferreira','505','Bloco B','Leblon','Rio de Janeiro','RJ','22431-050','(21) 2222-2222','luiza@email.com'),(52,'Mateus Pereira','666.777.888-00','Rua Vinícius de Moraes','202','Bloco B','Ipanema','Rio de Janeiro','RJ','22411-010','(21) 1111-1111','mateus@email.com'),(53,'Lucas Oliveira','555.666.777-00','Rua Visconde de Caravelas','303','Bloco C','Botafogo','Rio de Janeiro','RJ','22271-022','(21) 6666-6666','lucas@email.com'),(54,'Marcela Silva','888.999.000-00','Rua São Clemente','404','Bloco C','Botafogo','Rio de Janeiro','RJ','22260-001','(21) 7777-7777','marcela@email.com'),(55,'Maria Oliveira','555.666.777-00','Rua do Imperador','303','Bloco A','Centro','Petrópolis','RJ','25620-000','(24) 5555-5555','maria@email.com'),(56,'Paulo Silva','888.999.000-00','Avenida Koeler','404','Bloco A','Centro','Petrópolis','RJ','25620-000','(24) 4444-4444','paulo@email.com'),(57,'Luciana Santos','111.222.333-00','Rua Montecaseros','101','Bloco A','Centro','Petrópolis','RJ','25620-000','(24) 3333-3333','luciana@email.com'),(58,'Rafael Costa','333.444.555-00','Rua Barão do Amazonas','505','Bloco B','Centro','Petrópolis','RJ','25620-000','(24) 2222-2222','rafael@email.com'),(59,'Mariana Pereira','666.777.888-00','Rua Teresa','202','Bloco B','Alto da Serra','Petrópolis','RJ','25620-000','(24) 1111-1111','mariana@email.com'),(60,'asd','','','','','','','AM','','',''),(61,'alex','','','','','','','PI','','',''),(62,'Alexandre Sabbadom','16815613798','23','23','23','23','23','AP','23','23','23'),(63,'alex','123','123','123','123','123','123','AL','123','1231','123'),(64,'Alexandre de Moraes','4244445','123','11','123','123','123','BA','42122','123','lx'),(65,'Talita','09753962770','Travess Joao','11','casa','Caxambu','Petropolis','RJ','25615055','2490909090','talita@gmail.com');
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;
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
