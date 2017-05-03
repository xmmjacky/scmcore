/*
Navicat MySQL Data Transfer

Source Server         : HY
Source Server Version : 50621
Source Host           : localhost:3306
Source Database       : dapperextensionsdemo

Target Server Type    : MYSQL
Target Server Version : 50621
File Encoding         : 65001

Date: 2016-06-28 14:01:51
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for userinfo
-- ----------------------------
DROP TABLE IF EXISTS `userinfo`;
CREATE TABLE `userinfo` (
  `Id` int(11) DEFAULT NULL,
  `UserId` int(255) DEFAULT NULL,
  `Sex` int(255) DEFAULT NULL,
  `Name` varchar(255) DEFAULT NULL,
  `CardId` int(11) DEFAULT NULL,
  `Age` int(11) DEFAULT NULL,
  `Email` varchar(255) DEFAULT NULL,
  `Mobile` varchar(255) DEFAULT NULL,
  `Remark` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of userinfo
-- ----------------------------

-- ----------------------------
-- Table structure for users
-- ----------------------------
DROP TABLE IF EXISTS `users`;
CREATE TABLE `users` (
  `UserId` int(11) NOT NULL AUTO_INCREMENT,
  `LoginName` varchar(50) DEFAULT NULL,
  `Password` varchar(50) DEFAULT NULL,
  `Status` int(11) DEFAULT NULL,
  `CreateTime` datetime DEFAULT NULL,
  `UpdateTime` datetime DEFAULT NULL,
  `Remark` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`UserId`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of users
-- ----------------------------
INSERT INTO `users` VALUES ('1', '1', '1', '1', '2016-01-01 00:00:00', '2016-01-01 00:00:00', '');
INSERT INTO `users` VALUES ('2', '2', '2', '2', '2016-01-01 00:00:00', '2016-01-01 00:00:00', null);
