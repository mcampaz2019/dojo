CREATE DATABASE  IF NOT EXISTS `seattle_trails` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `seattle_trails`;
-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: localhost    Database: seattle_trails
-- ------------------------------------------------------
-- Server version	5.7.21-log

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
-- Table structure for table `trail`
--

DROP TABLE IF EXISTS `trail`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `trail` (
  `TrailId` int(11) NOT NULL AUTO_INCREMENT,
  `TrailName` varchar(45) DEFAULT NULL,
  `Description` text,
  `Length` float DEFAULT NULL,
  `ElevationGain` float DEFAULT NULL,
  `MaxElevation` float DEFAULT NULL,
  `Longitude` float DEFAULT NULL,
  `Latitude` float DEFAULT NULL,
  `TrailMap` longtext,
  `CreatedAt` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `UpdatedAt` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `trailcol` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`TrailId`),
  UNIQUE KEY `idtrail_UNIQUE` (`TrailId`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `trail`
--

LOCK TABLES `trail` WRITE;
/*!40000 ALTER TABLE `trail` DISABLE KEYS */;
INSERT INTO `trail` VALUES (1,'Chelan Butte','CENTRAL CASCADES -- ENTIAT MOUNTAINS/LAKE CHELAN: A moderate hike up the side of Chelan Butte and across the top of the ridge promises outstanding views of the Columbia Plateau, Columbia River, Lake Chelan and surrounding areas. ',7.46,2500,3835,-120.01,47.831,'https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d21437.411777315185!2d-120.05119101845195!3d47.807106941967376!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x549b9a40718d3735%3A0xcb95881dc7b24f97!2sChelan+Butte!5e0!3m2!1sen!2sus!4v1564932539033!5m2!1sen!2sus','2019-08-04 15:29:46','2019-08-04 15:29:46',NULL),(2,'Lake Of The Angels','OLYMPIC PENINSULA -- HOOD CANAL: Tucked high in the mountains of the Olympic Peninsula, in the appropriately named Valley of Heaven is a breathtaking lake -- the Lake of the Angels. The heavenly goal is accessed by a trail built for more mortal interests. Keep in mind though; if you tackle this trail, it\'s devilishly difficult. In some places, it requires a vertical climb where falling is not an option. Be prepared, both physically and mentally, for this challenging hike.',7,3400,4950,-123.235,47.584,'https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d21518.818287768576!2d-123.29517611860832!3d47.609561850550456!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x5491d77cfabb9cbd%3A0x8fb2f5631156d778!2sLake+of+the+Angels!5e0!3m2!1sen!2sus!4v1564932460711!5m2!1sen!2sus','2019-08-04 15:29:46','2019-08-04 15:29:46',NULL),(3,'Norse Peak','MOUNT RAINIER AREA -- CHINOOK PASS - HWY 410: A steep, yet surprisingly comfortable climb to views of Mount Adams, Mount Rainier, Mount Hood, Glacier Peak, and the Olympics. ',10,2900,6856,-121.483,46.9644,'https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d21785.98866918842!2d-121.46954401912025!3d46.956805707343605!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x5490b6edbb4ebfd9%3A0xd31fbde6b3c56900!2sNorse+Peak!5e0!3m2!1sen!2sus!4v1564932393575!5m2!1sen!2sus','2019-08-04 15:29:46','2019-08-04 15:29:46',NULL),(4,'Craft Island','PUGET SOUND AND ISLANDS -- SEATTLE-TACOMA AREA: Take a short hike to the best views of the Skagit flats and the bay, as well as the Cascades to the east, the Olympics to the west, and Rainier to the south. ',2,50,80,-122.472,48.3546,'https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d21211.298486798918!2d-122.49017177467626!3d48.352600421419666!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x5485668866cf7c99%3A0xc5968c73801e776!2sCraft+Island!5e0!3m2!1sen!2sus!4v1564932326842!5m2!1sen!2sus','2019-08-04 15:29:46','2019-08-04 15:29:46',NULL),(5,'Mount Teneriffe','SNOQUALMIE REGION -- NORTH BEND AREA: Mountains to Sound Greenway did this road to trail conversion in order to create a more sustainable, safer route for hikers to a summit on the I-90 corridor. Hike through second- and third-growth forest, pass a lovely waterfall, and enjoy a slightly less-crowded trail than the nearby Mount Si.',13,3800,4585,-121.71,47.4869,'https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d9069.91943725628!2d-121.7226986421977!3d47.48011016913818!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x54907e462fc85925%3A0xbc80ea67c6641e28!2sMount+Teneriffe+Trailhead!5e0!3m2!1sen!2sus!4v1564937944102!5m2!1sen!2sus','2019-08-04 17:00:19','2019-08-04 17:00:19',NULL),(9,'The Enchantments','CENTRAL CASCADES -- LEAVENWORTH AREA: The Enchantment Lakes are an alpine wonderland of pristine lakes set among polished granite, soaring peaks, blazing larches, and ambling mountain goats. Widely regarded as the crown jewel of hiking in Washington, this trail exceeds even the wildest of superlatives.',36,4500,7800,-120.821,47.5279,'https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2696.583568260614!2d-120.82143298346868!3d47.4785439048071!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x549a4460de83c0f1%3A0x802384bbed5406d9!2sThe+Enchantments!5e0!3m2!1sen!2sus!4v1564937819473!5m2!1sen!2sus','2019-08-04 17:00:19','2019-08-04 17:00:19',NULL);
/*!40000 ALTER TABLE `trail` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-08-04 10:11:21
