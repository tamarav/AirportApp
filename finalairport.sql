-- MySQL dump 10.13  Distrib 5.7.9, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: airport_db
-- ------------------------------------------------------
-- Server version	5.7.10-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `airline_company`
--

DROP TABLE IF EXISTS `airline_company`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `airline_company` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(45) NOT NULL,
  `country` varchar(45) NOT NULL,
  `address` varchar(45) DEFAULT NULL,
  `telephone` varchar(45) DEFAULT NULL,
  `email` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `airline_company`
--

LOCK TABLES `airline_company` WRITE;
/*!40000 ALTER TABLE `airline_company` DISABLE KEYS */;
INSERT INTO `airline_company` VALUES (1,'Serbian Airlines','Serbia','Majke Jugovica 32',NULL,'mj@cz.rs'),(2,'Yugoslavia air','Serbia','Trg Republike','0038711624583391','yugo@air.rs'),(3,'Suhoj','Russia','Putin street','','suhoj@su.rus'),(6,'Swiss airline1','Switcherland','Zurich','+4176785215','swissair@gmail.zh'),(7,'swiss air','switcerland','zurich','','swiss@air.zh'),(10,'Unese','Sta','Da ','Se ','Unese');
/*!40000 ALTER TABLE `airline_company` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `airplane`
--

DROP TABLE IF EXISTS `airplane`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `airplane` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(45) NOT NULL,
  `number_of_seats` int(11) DEFAULT NULL,
  `airline_company_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_airplane_airline_company1_idx` (`airline_company_id`),
  CONSTRAINT `fk_airplane_airline_company1` FOREIGN KEY (`airline_company_id`) REFERENCES `airline_company` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=19 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `airplane`
--

LOCK TABLES `airplane` WRITE;
/*!40000 ALTER TABLE `airplane` DISABLE KEYS */;
INSERT INTO `airplane` VALUES (1,'Jugo Koral Airplane',5,1),(2,'Suhoj su-37',1,3),(3,'haaaaaaaaaaaa',2,2),(18,'probe',222,7);
/*!40000 ALTER TABLE `airplane` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `fly`
--

DROP TABLE IF EXISTS `fly`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `fly` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `destination` varchar(45) NOT NULL,
  `start_point` varchar(45) NOT NULL,
  `departure_time` datetime NOT NULL,
  `landing_time` datetime NOT NULL,
  `airplane_id` int(11) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_fly_airplane_idx` (`airplane_id`),
  CONSTRAINT `fk_fly_airplane` FOREIGN KEY (`airplane_id`) REFERENCES `airplane` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `fly`
--

LOCK TABLES `fly` WRITE;
/*!40000 ALTER TABLE `fly` DISABLE KEYS */;
INSERT INTO `fly` VALUES (1,'Moscow','Antatanaravie','2016-11-22 22:33:45','2016-11-23 22:33:45',1),(3,'Beograd','Banja Luka','2017-11-22 12:00:00','2017-11-22 12:45:00',18);
/*!40000 ALTER TABLE `fly` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `user` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(16) NOT NULL,
  `password` char(16) NOT NULL,
  `create_time` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` VALUES (1,'tamara','123456','2016-01-15 20:54:57'),(2,'dgajvdbhbk','1111','2016-01-19 19:21:49'),(3,'boris','kagawa21','2016-01-20 18:01:35');
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-01-24 19:15:43
