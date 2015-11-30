/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='-05:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

DROP DATABASE IF EXISTS `gestionnairebd`;

CREATE SCHEMA `gestionnairebd`;

USE `gestionnairebd`;


SET SQL_SAFE_UPDATES = 0;
SET GLOBAL event_scheduler = ON;

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
  `ISBN` varchar(45)  NULL,
  `EANcode` varchar(45)  NULL,
   `UPCcode` varchar(45)  NULL,
  `Title` varchar(255) NOT NULL,
  `Author` varchar(45)  NULL,
  `Publishier` varchar(45)  NULL,
  `Language` varchar(45)  NULL,
   `Categorie` varchar(45)  NULL,
   `PageCpt` int(11),
  `Price` double NOT NULL,
	`NewOwnerId` int(11)  ,
   `IsTransactionDone` bool,
  `timeCreated` datetime DEFAULT NULL,
  `FK_bookcondition` int(11) NOT NULL,
  `FK_transactionType` int(11) NOT NULL,
  `FK_transactionStatus` int(11) NOT NULL,
  `FK_cooperativeid` int(11) NOT NULL,
  `timeReserved` datetime DEFAULT NULL,
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


INSERT INTO `gestionnairebd`.`transactiontype` (`PK_id`, `Name`) VALUES ('1', 'For sale');
INSERT INTO `gestionnairebd`.`transactiontype` (`PK_id`, `Name`) VALUES ('2', 'For exhange');

INSERT INTO `gestionnairebd`.`transactionstatus` (`PK_id`, `Name`) VALUES ('1', 'Waiting for deposit');
INSERT INTO `gestionnairebd`.`transactionstatus` (`PK_id`, `Name`) VALUES ('2', 'On sale');
INSERT INTO `gestionnairebd`.`transactionstatus` (`PK_id`, `Name`) VALUES ('3', 'Reserved');
INSERT INTO `gestionnairebd`.`transactionstatus` (`PK_id`, `Name`) VALUES ('4', 'waiting for pick up');
INSERT INTO `gestionnairebd`.`transactionstatus` (`PK_id`, `Name`) VALUES ('5', 'In transit');

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
    IN eancode VARCHAR(45),
    IN upccode VARCHAR(45),
    IN title varchar(255),
    IN author VARCHAR(45),
    IN publishier VARCHAR(45),
    IN blanguage VARCHAR(45),
     IN categorie VARCHAR(45),
     IN pageCpt int(11),
    IN price double,
    IN fk_bootcondition int(11),
     IN fk_transactionType int(11),
     IN fk_cooperativeid int(11))
BEGIN
INSERT INTO `gestionnairebd`.`book` (`ISBN`, `EANcode`, `UPCcode`, `Title`, `Author`, `Publishier`, `Language`, `Categorie` ,`PageCpt`, `Price`, `NewOwnerId` , `IsTransactionDone` ,`timeCreated`, `FK_bookcondition`, `FK_transactionType`,`FK_transactionStatus`,`FK_cooperativeid`) 
        VALUES (isbn,eancode,upccode, title, author, publishier, blanguage, categorie, pageCpt, price, NULL , FALSE , now(), fk_bootcondition,fk_transactionType,1,fk_cooperativeid);

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
/*!50003 DROP PROCEDURE IF EXISTS `RetrieveBooksByCoopId` */;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `RetrieveBooksByCoopId`(
		in coop_id int(11))
BEGIN
	select book.* ,  
		transactiontype.Name as transactionType,
		bookcondition.Description as conditionDescription,
		transactionstatus.Name as transactionStatus,
        cooperative.Name as coopName
    from gestionnairebd.book , 
		gestionnairebd.transactiontype ,
		gestionnairebd.bookcondition ,
		gestionnairebd.transactionstatus,
        gestionnairebd.cooperative
	WHERE book.FK_bookcondition = bookcondition.PK_id
		and book.FK_transactionType = transactiontype.PK_id 
        and book.FK_transactionStatus = transactionstatus.PK_id
         and book.FK_cooperativeid = cooperative.PK_id 
         and book.FK_cooperativeid = coop_id;
END ;;



DELIMITER ;
/*!50003 DROP PROCEDURE IF EXISTS `RetrieveAllBooks` */;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `RetrieveAllBooks`()
BEGIN
	select book.* ,  
		transactiontype.Name as transactionType,
		bookcondition.Description as conditionDescription,
		transactionstatus.Name as transactionStatus,
        cooperative.Name as coopName
    from gestionnairebd.book , 
		gestionnairebd.transactiontype ,
		gestionnairebd.bookcondition ,
		gestionnairebd.transactionstatus,
        gestionnairebd.cooperative
	WHERE book.FK_bookcondition = bookcondition.PK_id
		and book.FK_transactionType = transactiontype.PK_id 
        and book.FK_transactionStatus = transactionstatus.PK_id
         and book.FK_cooperativeid = cooperative.PK_id;
END ;;


DELIMITER ;
/*!50003 DROP PROCEDURE IF EXISTS `RetrieveAllBooksWaitingForPickupByCoop` */;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `RetrieveAllBooksWaitingForPickupByCoop`(
		in coop_id int(11))
BEGIN
	select book.* ,  
		transactiontype.Name as transactionType,
		bookcondition.Description as conditionDescription,
		transactionstatus.Name as transactionStatus,
        cooperative.Name as coopName
    from gestionnairebd.book , 
		gestionnairebd.transactiontype ,
		gestionnairebd.bookcondition ,
		gestionnairebd.transactionstatus,
        gestionnairebd.cooperative
	WHERE book.FK_bookcondition = bookcondition.PK_id
		and book.FK_transactionType = transactiontype.PK_id 
        and book.FK_transactionStatus = 4
         and book.FK_cooperativeid = cooperative.PK_id 
          and book.FK_cooperativeid = coop_id;
END ;;

DELIMITER ;
/*!50003 DROP PROCEDURE IF EXISTS `RetrieveLast10BookOnSale` */;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `RetrieveLast10BookOnSale`()
BEGIN
	select book.* ,  
		transactiontype.Name as transactionType,
		bookcondition.Description as conditionDescription,
		transactionstatus.Name as transactionStatus,
        cooperative.Name as coopName
    from gestionnairebd.book , 
		gestionnairebd.transactiontype ,
		gestionnairebd.bookcondition ,
		gestionnairebd.transactionstatus,
        gestionnairebd.cooperative
	WHERE book.FK_bookcondition = bookcondition.PK_id
		and book.FK_transactionType = transactiontype.PK_id 
        and book.FK_transactionStatus = transactionstatus.PK_id
         and book.FK_cooperativeid = cooperative.PK_id
         and book.FK_transactionStatus = 2
         ORDER BY book.`PK_id` DESC limit 10;
         
END ;;

DELIMITER ;
/*!50003 DROP PROCEDURE IF EXISTS `RetrieveBooksBySellerId` */;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `RetrieveBooksBySellerId`(
		in client_id int(11) )
BEGIN
	select book.* ,  
		transactiontype.Name as transactionType,
		bookcondition.Description as conditionDescription,
		transactionstatus.Name as transactionStatus,
         cooperative.Name as coopName
    from gestionnairebd.book , 
		gestionnairebd.user_book , 
		gestionnairebd.transactiontype ,
		gestionnairebd.bookcondition ,
		gestionnairebd.transactionstatus,
         gestionnairebd.cooperative
	WHERE  user_book.FK_user_id = client_id 
		and  book.PK_id = user_book.FK_book_id
		and book.FK_bookcondition = bookcondition.PK_id
		and book.FK_transactionType = transactiontype.PK_id 
        and book.FK_transactionStatus = transactionstatus.PK_id
         and book.FK_cooperativeid = cooperative.PK_id;
END ;;

DELIMITER ;
/*!50003 DROP PROCEDURE IF EXISTS `SearchBook` */;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `SearchBook`(
		in bookTitle varchar(50),
        in bookIsbn varchar(50),
        in bookAuthor varchar(50),
        in bookUpc varchar(50))
BEGIN
	select book.* ,  
		transactiontype.Name as transactionType,
		bookcondition.Description as conditionDescription,
		transactionstatus.Name as transactionStatus,
        cooperative.Name as coopName
    from gestionnairebd.book , 
		gestionnairebd.transactiontype ,
		gestionnairebd.bookcondition ,
		gestionnairebd.transactionstatus,
          gestionnairebd.cooperative
		WHERE  book.Title LIKE bookTitle
        and book.ISBN LIKE bookIsbn
        and book.Author LIKE bookAuthor
        and book.UPCcode LIKE bookUpc
		and book.FK_bookcondition = bookcondition.PK_id
		and book.FK_transactionType = transactiontype.PK_id 
        and book.FK_transactionStatus = transactionstatus.PK_id
        and book.FK_cooperativeid = cooperative.PK_id
        and book.FK_transactionStatus = 2;
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
/*!50003 DROP PROCEDURE IF EXISTS `ReserveSpecificBook` */;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `ReserveSpecificBook`(
		in client_id int(11),
        in book_id int(11))
BEGIN
	UPDATE `gestionnairebd`.`book`
    SET 
		`NewOwnerId`= client_id,
        `FK_transactionStatus`='3',
        `timeReserved`=now()
     WHERE `book`.`PK_id`= book_id ;
END ;;

DELIMITER ;
/*!50003 DROP PROCEDURE IF EXISTS `ValidateSpecificBookCondition` */;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `ValidateSpecificBookCondition`(
        in book_id int(11))
BEGIN
	UPDATE `gestionnairebd`.`book`
    SET 
        `FK_transactionStatus`='2'
     WHERE `book`.`PK_id`= book_id ;
END ;;


DELIMITER ;
/*!50003 DROP PROCEDURE IF EXISTS `UpdateSpecificBookCondition` */;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `UpdateSpecificBookCondition`(
        in book_id int(11),
        in fk_condition_id int(11))
BEGIN
	UPDATE `gestionnairebd`.`book`
    SET 
        `FK_transactionStatus`= fk_condition_id
     WHERE `book`.`PK_id`= book_id ;
END ;;

DELIMITER ;
/*!50003 DROP PROCEDURE IF EXISTS `RemoveSpecificBook` */;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `RemoveSpecificBook`(
        in book_id int(11))
BEGIN
	DELETE FROM `gestionnairebd`.`book` WHERE `PK_id`=book_id;

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



DELIMITER ;;
CREATE 
	EVENT `UpdateOutdateReservedObject` 
	ON SCHEDULE EVERY 1 minute 
	DO BEGIN	
    UPDATE `gestionnairebd`.`book`
    SET 
        `FK_transactionStatus`='2',
        `timeReserved`=null
     WHERE timestampdiff(minute,`book`.timeReserved,now()) > 3;
END ;;

