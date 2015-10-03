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

DROP DATABASE IF EXISTS `gestionnairebd`;

CREATE SCHEMA `gestionnairebd`;

USE `gestionnairebd`;

DROP TABLE IF EXISTS `cooperative`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cooperative` (
  `PK_id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(100) DEFAULT NULL,
  `Adress`varchar(100) DEFAULT NULL,
   `Contactinfo`varchar(100) DEFAULT NULL,
  PRIMARY KEY (`PK_id`),
  UNIQUE KEY `PK_id_UNIQUE` (`PK_id`)
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

DROP TABLE IF EXISTS `bookcondition`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `bookcondition` (
  `PK_id` int(11) NOT NULL AUTO_INCREMENT,
  `Description` varchar(100) DEFAULT NULL,
  `reduction` int(11) DEFAULT NULL,
  PRIMARY KEY (`PK_id`),
  UNIQUE KEY `PK_id_UNIQUE` (`PK_id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;



DROP TABLE IF EXISTS `transactionstatus`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `transactionstatus` (
  `PK_id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(45) NOT NULL,
  PRIMARY KEY (`PK_id`),
  UNIQUE KEY `PK_id_UNIQUE` (`PK_id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;



DROP TABLE IF EXISTS `transactiontype`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `transactiontype` (
  `PK_id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(45) NOT NULL,
  PRIMARY KEY (`PK_id`),
  UNIQUE KEY `PK_id_UNIQUE` (`PK_id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;



DROP TABLE IF EXISTS `usertype`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usertype` (
  `PK_id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(45) NOT NULL,
  PRIMARY KEY (`PK_id`),
  UNIQUE KEY `PK_id_UNIQUE` (`PK_id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;






DROP TABLE IF EXISTS `book`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `book` (
  `PK_id` int(11) NOT NULL AUTO_INCREMENT,
  `ISBN` varchar(45) NOT NULL,
  `Title` varchar(255) NOT NULL,
  `Author` varchar(45)  NULL,
  `Publishier` varchar(45)  NULL,
  `Language` varchar(45)  NULL,
   `Categorie` varchar(45)  NULL,
  `Price` int(11) NOT NULL,
	`NewOwnerId` int(11)  ,
   `IsTransactionDone` bool,
  `timeCreated` datetime DEFAULT NULL,
  `FK_bookcondition` int(11) NOT NULL,
  `FK_transactionType` int(11) NOT NULL,
  `FK_transactionStatus` int(11) NOT NULL,
  `FK_cooperativeid` int(11) NOT NULL,
  PRIMARY KEY (`PK_id`),
  UNIQUE KEY `PK_id_UNIQUE` (`PK_id`),  
  KEY `BookCondition` (`FK_bookcondition`),
  KEY `TransactionType` (`FK_transactionType`),
  KEY `TransactionStatus` (`FK_bookcondition`),
  CONSTRAINT `BookCondition` FOREIGN KEY (`FK_bookcondition`) REFERENCES `bookcondition` (`PK_id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `TransactionType` FOREIGN KEY (`FK_transactionType`) REFERENCES `transactiontype` (`PK_id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `TransactionStatus` FOREIGN KEY (`FK_bookcondition`) REFERENCES `bookcondition` (`PK_id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=1  DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;



DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `user` (
  `PK_id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(45) NOT NULL,
  `Phone` varchar(45) NOT NULL,
  `Password` varchar(128) NOT NULL,
  `Username` varchar(45) NOT NULL,
  `FK_usertype_id` int(11) NOT NULL,
  `Email` varchar(45) NOT NULL,
   `FK_coop_ref` int(11) NULL,
  PRIMARY KEY (`PK_id`),
  UNIQUE INDEX `Username_UNIQUE` (`Username`),
  UNIQUE KEY `PK_id_UNIQUE` (`PK_id`),
  KEY `FK_id_idx` (`FK_usertype_id`),
  CONSTRAINT `userType` FOREIGN KEY (`FK_usertype_id`) REFERENCES `usertype` (`PK_id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=1 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;





DROP TABLE IF EXISTS `user_book`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `user_book` (
  `FK_user_id` int(11) NOT NULL,
  `FK_book_id` int(11) NOT NULL,
  KEY `FK_userID` (`FK_user_id`),
  KEY `FK_BookID` (`FK_book_id`),
  CONSTRAINT `FK_BookID` FOREIGN KEY (`FK_book_id`) REFERENCES `book` (`PK_id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
   CONSTRAINT `FK_userID` FOREIGN KEY (`FK_user_id`) REFERENCES `user` (`PK_id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;








INSERT INTO `gestionnairebd`.`usertype` (`PK_id`, `Name`) VALUES ('1', 'Client');
INSERT INTO `gestionnairebd`.`usertype` (`PK_id`, `Name`) VALUES ('2', 'Admin');

INSERT INTO `gestionnairebd`.`bookcondition` (`PK_id`, `Description`, `reduction`) VALUES ('1', 'Brand new', '0');
INSERT INTO `gestionnairebd`.`bookcondition` (`PK_id`, `Description`, `reduction`) VALUES ('2', 'Minimal wear', '25');
INSERT INTO `gestionnairebd`.`bookcondition` (`PK_id`, `Description`, `reduction`) VALUES ('3', 'Good', '50');
INSERT INTO `gestionnairebd`.`bookcondition` (`PK_id`, `Description`, `reduction`) VALUES ('4', 'Poor', '75');


INSERT INTO `gestionnairebd`.`transactiontype` (`PK_id`, `Name`) VALUES ('1', 'In sale');
INSERT INTO `gestionnairebd`.`transactiontype` (`PK_id`, `Name`) VALUES ('2', 'In exhange');

INSERT INTO `gestionnairebd`.`transactionstatus` (`PK_id`, `Name`) VALUES ('1', 'Waiting for deposit');
INSERT INTO `gestionnairebd`.`transactionstatus` (`PK_id`, `Name`) VALUES ('2', 'Live');
INSERT INTO `gestionnairebd`.`transactionstatus` (`PK_id`, `Name`) VALUES ('3', 'Reserved');
INSERT INTO `gestionnairebd`.`transactionstatus` (`PK_id`, `Name`) VALUES ('4', 'waiting for pick up');

INSERT INTO `gestionnairebd`.`cooperative` (`PK_id`, `Name`, `Adress`, `Contactinfo`) VALUES ('1', 'Coopérative ETS', '231 something', '231 442 1234');

INSERT INTO `gestionnairebd`.`user` (`PK_id`, `Name`, `Phone`, `Password`, `Username`, `FK_usertype_id`, `Email`,`FK_coop_ref`) VALUES ('1', 'GodClient ', '4189999999', 'ee26b0dd4af7e749aa1a8ee3c10ae9923f618980772e473f8819a5d4940e0db27ac185f8a0e1d5f84f88bc887fd67b143732c304cc5fa9ad8e6f57f50028a8ff', 'test', '1', 'god@paradise.god',0);
INSERT INTO `gestionnairebd`.`user` (`PK_id`, `Name`, `Phone`, `Password`, `Username`, `FK_usertype_id`, `Email` , `FK_coop_ref`) VALUES ('2', 'GodAdmin ', '4189999999', 'ee26b0dd4af7e749aa1a8ee3c10ae9923f618980772e473f8819a5d4940e0db27ac185f8a0e1d5f84f88bc887fd67b143732c304cc5fa9ad8e6f57f50028a8ff', 'test1', '2', 'god@paradise.god' ,1);







DELIMITER ;
/*!50003 DROP PROCEDURE IF EXISTS `RegisterUser` */;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `RegisterUser`(
	IN name VARCHAR(45),
    IN phone VARCHAR(45),
    IN username VARCHAR(45),
    IN password VARCHAR(128),
    IN email VARCHAR(45),
    IN fk_usertypeid INT(11),
    IN fk_coop_ref INT(11))
BEGIN
	INSERT INTO `gestionnairebd`.`user` (`Name`, `Phone`, `Password`, `Username`, `FK_usertype_id`, `Email` , user.FK_coop_ref)
   VALUES( name, phone, password,username, fk_usertypeid,email,fk_coop_ref) ; 
   
END ;;


DELIMITER ;
/*!50003 DROP PROCEDURE IF EXISTS `RegisterAdminWithCoop` */;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `RegisterAdminWithCoop`(
	IN name VARCHAR(45),
    IN phone VARCHAR(45),
    IN username VARCHAR(45),
    IN password VARCHAR(128),
    IN email VARCHAR(45),
	IN fk_usertypeid INT(11),
    IN coopName VARCHAR(45),
    IN coopAdress VARCHAR(45),
    IN coopContactInfo VARCHAR(45))
BEGIN
    INSERT INTO `gestionnairebd`.`cooperative` ( `Name`, `Adress`, `Contactinfo`) VALUES ( coopName, coopAdress, coopContactInfo);     
	call gestionnairebd.RegisterUser(name, phone, username, password, email, 2 ,LAST_INSERT_ID());
END ;;

DELIMITER ;
/*!50003 DROP PROCEDURE IF EXISTS `RegisterNewBook` */;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `RegisterNewBook`(
	IN bookSellerId int(11),
	IN isbn VARCHAR(45),
    IN title varchar(255),
    IN author VARCHAR(45),
    IN publishier VARCHAR(45),
    IN blanguage VARCHAR(45),
     IN categorie VARCHAR(45),
    IN price int(11),
    IN fk_bootcondition int(11),
     IN fk_transactionType int(11))
BEGIN
INSERT INTO `gestionnairebd`.`book` (`ISBN`, `Title`, `Author`, `Publishier`, `Language`, `Categorie` , `Price`, `NewOwnerId` , `IsTransactionDone` ,`timeCreated`, `FK_bookcondition`, `FK_transactionType`,`FK_transactionStatus`,`FK_cooperativeid`) 
        VALUES (isbn, title, author, publishier, blanguage, categorie , price, NULL , FALSE , now(), fk_bootcondition,fk_transactionType,1,1);

INSERT INTO `gestionnairebd`.`user_book` (`FK_user_id`, `FK_book_id`) VALUES (bookSellerId, LAST_INSERT_ID());
END ;;




DELIMITER ;
/*!50003 DROP PROCEDURE IF EXISTS `GetTransactionType` */;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetTransactionType`()
BEGIN
	select * from gestionnairebd.transactiontype;
END ;;

DELIMITER ;
/*!50003 DROP PROCEDURE IF EXISTS `GetTransactionType` */;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetTransactionType`()
BEGIN
	select * from gestionnairebd.transactiontype;
END ;;

DELIMITER ;
/*!50003 DROP PROCEDURE IF EXISTS `GetTransactionStatus` */;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetTransactionStatus`()
BEGIN
	select * from gestionnairebd.transactionstatus;
END ;;

DELIMITER ;
/*!50003 DROP PROCEDURE IF EXISTS `GetUserType` */;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetUserType`()
BEGIN
	select * from gestionnairebd.usertype;
END ;;

DELIMITER ;
/*!50003 DROP PROCEDURE IF EXISTS `GetBookCondition` */;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `GetBookCondition`()
BEGIN
	select * from gestionnairebd.bookcondition;
END ;;





DELIMITER ;
/*!50003 DROP PROCEDURE IF EXISTS `RetrieveSpecificUser` */;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `RetrieveSpecificUser`(
		in client_id int(11) )
BEGIN
	select user.PK_Id , user.Name , user.Phone , user.Username, user.Email , usertype.Name ,usertype.PK_id , user.FK_coop_ref
	from gestionnairebd.user , gestionnairebd.usertype
	WHERE  user.PK_Id = client_id AND user.FK_usertype_id =  usertype.PK_Id ;
END ;;

DELIMITER ;
/*!50003 DROP PROCEDURE IF EXISTS `RetrieveCooperatives` */;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `RetrieveCooperatives`()
BEGIN
	select * from gestionnairebd.cooperative;
END ;;

DELIMITER ;
/*!50003 DROP PROCEDURE IF EXISTS `RetrieveSpecificCooperative` */;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `RetrieveSpecificCooperative`(
		in coop_id int(11) )
BEGIN
	select *
	from gestionnairebd.cooperative
	WHERE   gestionnairebd.cooperative.PK_id = coop_id;
END ;;




DELIMITER ;
/*!50003 DROP PROCEDURE IF EXISTS `ValidateUserCrendentials` */;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `ValidateUserCrendentials`(	
	IN userPassword VARCHAR(128),
    IN username VARCHAR(45))
BEGIN
 select user.PK_id as id from gestionnairebd.user where user.username = username and user.password =userPassword ;
END ;;
