-- MySQL dump 10.13  Distrib 5.5.27, for Win32 (x86)
--
-- Host: localhost    Database: newdatabase
-- ------------------------------------------------------
-- Server version	5.5.27

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
-- Current Database: `newdatabase`
--

CREATE DATABASE /*!32312 IF NOT EXISTS*/ `newdatabase` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `newdatabase`;

--
-- Table structure for table `balance`
--

DROP TABLE IF EXISTS `balance`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `balance` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `date` date NOT NULL,
  `checkno` varchar(100) NOT NULL DEFAULT 'CASH',
  `checkdate` date NOT NULL,
  `payee` varchar(1025) NOT NULL,
  `particulars` varchar(1025) NOT NULL,
  `type` text NOT NULL,
  `deposit` decimal(11,2) NOT NULL,
  `withdraw` decimal(11,2) NOT NULL,
  `amount` decimal(11,2) NOT NULL,
  `timein` varchar(500) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=1315 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `balance`
--

LOCK TABLES `balance` WRITE;
/*!40000 ALTER TABLE `balance` DISABLE KEYS */;

INSERT INTO `balance` (`id`, `date`, `checkno`, `checkdate`, `payee`, `particulars`, `type`, `deposit`, `withdraw`, `amount`, `timein`) VALUES
(689, '2013-03-20', '', '2013-03-20', 'Erick Jayson Correa', 'Balance as of March 20, 2013', 'Deposit', '316559.41', '', '316559.41', ''),
(690, '2013-03-20', '288801', '2013-03-20', 'Elison Barcelo', 'Elison Disbursement', 'Withdraw', '', '8836.18', '307723.23', ''),
(691, '2013-03-20', '288802', '2013-03-20', 'Elison Barcelo', 'Amazon Web', 'Withdraw', '', '8998.85', '298724.38', ''),
(692, '2013-03-26', '288816', '2013-03-26', 'Elison Barcelo', 'Reimbursement of Sir Elison', 'Withdraw', '', '13442.16', '285282.22', ''),
(693, '2013-03-26', '288817', '2013-03-26', 'Elison Barcelo', 'Electric Bill 0-402 Yarlie Lim', 'Withdraw', '', '153979.20', '131303.02', ''),
(694, '2013-03-26', '', '2013-03-26', 'Vigattin Inc.', 'Bank Transfer from ANTZ', 'Deposit', '200000', '', '331303.02', ''),
(695, '2013-03-27', '288818', '2013-03-27', 'Erick Jayson Correa', 'Salary March 15,2013', 'Withdraw', '', '91808.75', '239494.27', ''),
(696, '2013-03-27', '', '2013-03-27', 'Vigattin Inc.', 'INT', 'Deposit', '21.10', '', '239515.37', ''),
(697, '2013-03-27', '', '2013-03-27', 'Vigattin Inc.', 'WT', 'Withdraw', '', '4.22', '239511.15', ''),
(698, '2013-04-02', '288806', '2013-04-02', 'CCT & Sons Development Inc.', 'Rental Fee for the month of March', 'Withdraw', '', '32000', '207511.15', ''),
(699, '2013-04-02', '288805', '2013-04-02', 'CCT & Sons Development Inc.', 'Rental - Feb. 2013 & Jan. 2014', 'Withdraw', '', '64000', '143511.15', ''),
(700, '2013-04-02', '288804', '2013-04-02', 'CCT & Sons Development Inc.', 'Security Deposit (CCT & Sons)', 'Withdraw', '', '89719.62', '53791.53', ''),
(701, '2013-04-12', '288819', '2013-04-12', 'Elison Barcelo', 'Reimbursement of Sir Elison', 'Withdraw', '', '13246.02', '40545.51', ''),
(702, '2013-04-15', '', '2013-04-15', 'Vigattin Inc.', 'Bank Transfer from ANTZ', 'Deposit', '150000', '', '190545.51', ''),
(703, '2013-04-15', '288820', '2013-04-15', 'Eric Jayson Correa', 'Salary April 1-15,2013', 'Withdraw', '', '95938.03', '94607.48', ''),
(704, '2013-04-17', '288821', '2013-04-17', 'Elison Barcelo', 'P.C.', 'Withdraw', '', '44000', '50607.48', ''),
(705, '2013-04-22', '288822', '2013-04-22', 'Erick Jayson Correa', 'Amazons', 'Withdraw', '', '9812.37', '40795.11', ''),
(706, '2013-04-26', '288825', '2013-04-26', 'Elison Barcelo', 'Reimbursement of Sir Elison', 'Withdraw', '', '13904.15', '26890.96', ''),
(708, '2013-04-29', '288823', '2013-04-29', 'Innove Communications Inc.', 'Globe Bill (Feb-March)', 'Withdraw', '', '5998', '20892.96', ''),
(709, '2013-04-30', '', '2013-04-30', 'Vigattin Inc.', 'Bank Transfer from ANTZ', 'Deposit', '120000', '', '140892.96', ''),
(710, '2013-04-30', '288826', '2013-04-30', 'Erick Jayson Correa', 'Salary (April 16-30,2013)', 'Withdraw', '', '105379.35', '35513.61', ''),
(711, '2013-04-30', '288824', '2013-04-30', 'Innove Communications Inc.', 'Globe Bill (Mar-Apr)', 'Withdraw', '', '4411.80', '31101.81', ''),
(712, '2013-04-30', '', '2013-04-30', 'Vigattin Inc.', 'INT', 'Deposit', '9.99', '', '31111.8', ''),
(713, '2013-04-30', '', '2013-04-30', 'Vigattin Inc.', 'WT', 'Withdraw', '', '2.00', '31109.8', ''),
(714, '2013-05-02', '', '2013-05-02', 'Vigattin Inc.', 'ZBD', 'Withdraw', '', '1000', '30109.8', ''),
(715, '2013-05-02', '', '2013-05-02', 'Vigattin Inc.', 'ZBD', 'Withdraw', '', '200', '29909.8', ''),
(716, '2013-05-02', '', '2013-05-02', 'Vigattin Inc.', 'ZBD', 'Withdraw', '', '1000', '28909.8', ''),
(717, '2013-05-02', '', '2013-05-02', 'Vigattin Inc.', 'ZBD', 'Withdraw', '', '200', '28709.8', ''),
(718, '2013-05-03', '', '2013-05-03', 'Vigattin Inc.', 'ZBD', 'Withdraw', '', '1000', '27709.8', ''),
(719, '2013-05-03', '', '2013-05-03', 'Vigattin Inc.', 'ZBD', 'Withdraw', '', '1000', '26709.8', ''),
(720, '2013-05-03', '288827', '2013-05-03', 'Erick Jayson Correa', 'Reimbursement of Sir Elison', 'Withdraw', '', '13417.59', '13292.21', ''),
(721, '2013-05-06', '', '2013-05-06', 'Vigattin Inc.', 'Change for the purchase of 8 PC', 'Deposit', '5500', '', '18792.21', ''),
(722, '2013-05-06', '', '2013-05-06', 'Vigattin Inc.', 'Bank Transfer from ANTZ', 'Deposit', '100000', '', '118792.21', ''),
(723, '2013-05-10', '288830', '2013-05-10', 'Erick Jayson Correa', 'Reimbursement of Sir Elison', 'Withdraw', '', '13951.02', '104841.19', ''),
(724, '2013-05-10', '288829', '2013-05-10', 'CCT & Sons Development Inc.', 'Electric Bill (April)', 'Withdraw', '', '16344.09', '88497.1', ''),
(725, '2013-05-14', '288828', '2013-05-14', 'CCT & Sons Development Inc.', 'Electric Bill (Jan - Mar)', 'Withdraw', '', '17777.17', '70719.93', ''),
(727, '2013-05-14', '288807', '2013-05-14', 'CCT & Sons Development Inc.', 'Rental Fee for the month of April', 'Withdraw', '', '32000', '38719.93', ''),
(728, '2013-05-14', '288808', '2013-05-14', 'CCT & Sons Development Inc.', 'Rental Fee for the month of May', 'Withdraw', '', '32000', '6719.93', ''),
(729, '2013-05-15', '', '2013-05-15', 'Vigattin Inc.', 'Bank Transfer from ANTZ', 'Deposit', '100000', '', '106719.93', ''),
(730, '2013-05-15', '288831', '2013-05-15', 'Erick Jayson Correa', 'Salary (May 1 - 15, 2013)', 'Withdraw', '', '100048.75', '6671.18', ''),
(731, '2013-05-20', '', '2013-05-20', 'Vigattin Inc.', 'Deposit', 'Deposit', '50000', '', '56671.18', ''),
(732, '2013-05-22', '288832', '2013-05-22', 'TransRadio Broadcasting Corporation', 'Vigattin Radio (Feb. 5 to Mar. 4, 2013)', 'Withdraw', '', '30000', '26671.18', ''),
(733, '2013-05-23', '288833', '2013-05-23', 'Erick Jayson Correa', 'Reimbursement of Sir Elison', 'Withdraw', '', '11991.33', '14679.85', ''),
(734, '2013-05-27', '', '2013-05-27', 'Vigattin Inc.', 'Bank Transfer from ANTZ', 'Deposit', '50000', '', '64679.85', ''),
(735, '2013-05-27', '288835', '2013-05-27', 'Elison Barcelo', 'Amazon', 'Withdraw', '', '13375.13', '51304.72', ''),
(736, '2013-05-31', '', '2013-05-31', 'Vigattin Inc.', 'Bank Transfer from ANTZ', 'Deposit', '120000', '', '171304.72', ''),
(737, '2013-05-31', '288836', '2013-05-31', 'Erick Jayson Correa', 'Salary (May 16 - 31, 2013)', 'Withdraw', '', '113805.20', '57499.52', ''),
(738, '2013-05-31', '', '2013-05-31', 'Vigattin Inc.', 'Deposit', 'Deposit', '8.30', '', '57507.82', ''),
(739, '2013-05-31', '', '2013-05-31', 'Vigattin Inc.', 'WT', 'Withdraw', '', '1.66', '57506.16', ''),
(740, '2013-06-03', '288809', '2013-06-03', 'CCT & Sons Development Inc.', 'Rental Fee for the month of June', 'Withdraw', '', '32000', '25506.16', ''),
(741, '2013-06-05', '288838', '2013-06-05', 'Erick Jayson Correa', 'Reimbursement of Sir Elison', 'Withdraw', '', '5353.27', '20152.89', ''),
(742, '2013-06-06', '288837', '2013-06-06', 'Innove Communications Inc.', 'Globe Bill (April - May)', 'Withdraw', '', '2006.37', '18146.52', ''),
(743, '2013-06-10', '288834', '2013-06-10', 'CCT & Sons Development Inc.', 'Water Bill (Apr. 3 - May 3, 2013)', 'Withdraw', '', '1636.47', '16510.05', ''),
(744, '2013-06-19', '', '2013-06-19', 'Vigattin Inc.', 'Bank Transfer from ANTZ', 'Deposit', '150000', '', '166510.05', ''),
(745, '2013-06-19', '288840', '2013-06-19', 'Erick Jayson Correa', 'Reimbursement of Sir Elison', 'Withdraw', '', '11992.63', '154517.42', ''),
(746, '2013-06-21', '288839', '2013-06-21', 'Erick Jayson Correa', 'Salary (June 1 - 14, 2013)', 'Withdraw', '', '103960.98', '50556.44', ''),
(747, '2013-06-24', '288845', '2013-06-24', 'Erick Jayson Correa', 'PayPal AngelHack', 'Withdraw', '', '216.24', '50340.2', ''),
(748, '2013-06-24', '288843', '2013-06-24', 'Elison Barcelo', 'Amazon Web Services', 'Withdraw', '', '13214.49', '37125.71', ''),
(749, '2013-06-24', '288844', '2013-06-24', 'Erick Jayson Correa', 'GoDaddy.com', 'Withdraw', '', '1779.62', '35346.09', ''),
(750, '2013-06-25', '288841', '2013-06-25', 'CCT & Sons Development Inc.', 'Water Bill (May 3 - June 3, 2013)', 'Withdraw', '', '1603.54', '33742.55', ''),
(751, '2013-06-25', '288842', '2013-06-25', 'CCT & Sons Development Inc.', 'Electric Bill (May)', 'Withdraw', '', '19007.09', '14735.46', ''),
(752, '2013-06-26', '288846', '2013-06-26', 'Innove Communications Inc.', 'Globe Bill (May - June)', 'Withdraw', '', '2068.64', '12666.82', ''),
(754, '2013-06-27', '288847', '2013-06-27', 'Erick Jayson Correa', 'Reimbursement of Sir Elison', 'Withdraw', '', '7581.19', '5085.63', ''),
(755, '2013-06-28', '', '2013-06-28', 'Vigattin Inc.', 'Bank Transfer from ANTZ', 'Deposit', '100000', '', '105085.63', ''),
(756, '2013-06-28', '288848', '2013-06-28', 'Erick Jayson Correa', 'Salary (June 15 - 28, 2013)', 'Withdraw', '', '94756.34', '10329.29', ''),
(757, '2013-06-28', '', '2013-06-28', 'Vigattin Inc.', 'SC', 'Withdraw', '', '500', '9829.29', ''),
(758, '2013-06-28', '', '2013-06-28', 'Vigattin Inc.', 'Deposit', 'Deposit', '4.33', '', '9833.62', ''),
(759, '2013-06-28', '', '2013-06-28', 'Vigattin Inc.', 'WT', 'Withdraw', '', '0.87', '9832.7500000001', ''),
(760, '2013-07-01', '', '07/01/2013', 'Vigattin Inc.', 'Bank Transfer from ANTZ', 'Deposit', '50000', '', '59832.75', ''),
(761, '2013-07-01', '288810', '2013-07-01', 'CCT & Sons Development Inc.', 'Rental Fee for the month of July', 'Withdraw', '', '32000', '27832.75', ''),
(762, '2013-07-03', '', '2013-07-03', 'Vigattin Inc.', 'Bank Transfer from ANTZ', 'Deposit', '50000', '', '77832.75', ''),
(763, '2013-07-03', '288849', '2013-07-03', 'Vigattin Inc.', 'Payment to DragonPay', 'Withdraw', '', '25000', '52832.75', ''),
(764, '2013-07-11', '288850', '2013-07-11', 'Erick Jayson Correa', 'Reimbursement of Sir Elison', 'Withdraw', '', '8117.50', '44715.25', ''),
(765, '2013-07-15', '288853', '2013-07-15', 'Erick Jayson Correa', 'Cash Advance of Vigattin Employees', 'Withdraw', '', '15000', '29715.25', ''),
(766, '2013-07-16', '', '2013-07-16', 'Vigattin Inc.', 'Bank Transfer from ANTZ', 'Deposit', '100000', '', '129715.25', ''),
(767, '2013-07-16', '288854', '2013-07-16', 'Erick Jayson Correa', 'Salary (June 29 - July 15, 2013)', 'Withdraw', '', '95799.11', '33916.14', ''),
(768, '2013-07-16', '288852', '2013-07-16', 'Bayan Telecommunications Inc.', 'Bayantel', 'Withdraw', '', '6276.38', '27639.76', ''),
(769, '2013-07-16', '288851', '2013-07-16', 'CCT & Sons Development Inc.', 'Water Bill (June 3 - July 3, 2013)', 'Withdraw', '', '1170.84', '26468.92', ''),
(770, '07/24/2013', '', '07/24/2013', 'Vigattin Inc.', 'Bank Transfer from ANTZ', 'Deposit', '40000', '', '66468.92', ''),
(771, '2013-07-24', '288856', '2013-07-24', 'Erick Jayson Correa', 'Reimbursement of Sir Elison', 'Withdraw', '', '6204.40', '60264.52', ''),
(772, '2013-07-24', '288855', '2013-07-24', 'Elison Barcelo', 'Amazon Web Services', 'Withdraw', '', '21583.65', '38680.87', ''),
(773, '2013-07-26', '288858', '2013-07-26', 'Erick Jayson Correa', 'Cash Advance of Vigattin Employees', 'Withdraw', '', '3100', '35580.87', ''),
(774, '2013-07-26', '288857', '2013-07-26', 'Erick Jayson Correa', 'Reimbursement of Sir Elison', 'Withdraw', '', '10536.31', '25044.56', ''),
(775, '2013-07-31', '', '2013-07-31', 'Vigattin Inc.', 'Bank Transfer from ANTZ', 'Deposit', '100000', '', '125044.56', ''),
(776, '2013-07-31', '288859', '2013-07-31', 'Erick Jayson Correa', 'Salary (July 16-31, 2013)', 'Withdraw', '', '107977.16', '17067.4', ''),
(777, '2013-07-31', '', '2013-07-31', 'Vigattin Inc.', 'Service Charge', 'Withdraw', '', '500', '16567.4', ''),
(778, '2013-07-31', '', '2013-07-31', 'Vigattin Inc.', 'Deposit (INT)', 'Deposit', '2.89', '', '16570.29', ''),
(779, '2013-07-31', '', '2013-07-31', 'Vigattin Inc.', 'WT', 'Withdraw', '', '0.58', '16569.71', ''),
(780, '2013-08-01', '', '2013-08-01', 'Vigattin Inc.', 'Bank Transfer from ANTZ', 'Deposit', '50000', '', '66569.71', ''),
(781, '2013-08-05', '288811', '2013-08-05', 'CCT & Sons Development Inc.', 'Rental Fee for the month of August', 'Withdraw', '', '32000', '34569.71', ''),
(783, '2013-08-07', '288861', '2013-08-07', 'Erick Jayson Correa', 'Reimbursement of Sir Elison', 'Withdraw', '', '8316.86', '26252.85', ''),
(784, '2013-08-07', '288860', '2013-08-07', 'TransRadio Broadcasting Corporation', 'Vigattin Radio (Mar. 5 to Apr. 4, 2013)', 'Withdraw', '', '25000', '1252.85', ''),
(785, '2013-08-16', '', '2013-08-16', 'Vigattin Inc.', 'Bank Transfer from ANTZ', 'Deposit', '150000', '', '151252.85', ''),
(786, '2013-08-16', '288863', '2013-08-16', 'Erick Jayson Correa', 'Salary (August 1-15, 2013)', 'Withdraw', '', '118423.10', '32829.75', ''),
(787, '2013-08-16', '288864', '2013-08-16', 'Erick Jayson Correa', 'Reimbursement of Sir Elison', 'Withdraw', '', '3981.86', '28847.89', ''),
(788, '2013-08-23', '288866', '2013-08-23', 'Erick Jayson Correa', 'Reimbursement of Sir Elison', 'Withdraw', '', '8512.97', '20334.92', ''),
(789, '2013-08-23', '288865', '2013-08-23', 'Innove Communications Inc.', 'Globe Bill (July to August)', 'Withdraw', '', '4590', '15744.92', ''),
(790, '2013-08-27', '', '2013-08-27', 'Vigattin Inc.', 'Bank Transfer from ANTZ', 'Deposit', '50000', '', '65744.92', ''),
(791, '2013-08-27', '288868', '2013-08-27', 'Erick Jayson Correa', 'GoDaddy.com', 'Withdraw', '', '6329.35', '59415.57', ''),
(792, '2013-08-27', '288867', '2013-08-27', 'Elison Barcelo', 'Amazon Web Services', 'Withdraw', '', '19371.01', '40044.56', ''),
(793, '2013-08-28', '288862', '2013-08-28', 'Elison Barcelo', 'Payment to Sir Randy for the Purchase of Rackspace Cloud', 'Withdraw', '', '7148.65', '32895.91', ''),
(794, '2013-08-30', '', '2013-08-30', 'Vigattin Inc.', 'Bank Transfer from ANTZ', 'Deposit', '120000', '', '152895.91', ''),
(795, '2013-08-30', '288872', '2013-08-30', 'Erick Jayson Correa', 'Salary (August 16-30, 2013)', 'Withdraw', '', '93263.71', '59632.2', ''),
(796, '2013-08-30', '288871', '2013-08-30', 'Bayan Telecommunications Inc.', 'Bayantel', 'Withdraw', '', '11997.96', '47634.24', ''),
(797, '2013-08-30', '', '2013-08-30', 'Vigattin Inc.', 'Service Charge', 'Withdraw', '', '500', '47134.24', ''),
(798, '2013-08-30', '', '2013-08-30', 'Vigattin Inc.', 'Deposit', 'Deposit', '1.82', '', '47136.06', ''),
(799, '2013-08-30', '', '2013-08-30', 'Vigattin Inc.', 'WT', 'Withdraw', '', '0.36', '47135.7', ''),
(800, '2013-09-02', '', '2013-09-02', 'Vigattin Inc.', 'Bank Transfer from ANTZ', 'Deposit', '50000', '', '97135.7', ''),
(801, '2013-09-02', '288812', '2013-09-02', 'CCT & Sons Development Inc.', ' Rental Fee for the month of Sept.', 'Withdraw', '', '32000', '65135.7', ''),
(802, '2013-09-05', '288870', '2013-09-05', 'CCT & Sons Development Inc.', 'Water Bill (July 3 - August 3, 2013)', 'Withdraw', '', '907.95', '64227.75', ''),
(803, '2013-09-05', '288869', '2013-09-05', 'CCT & Sons Development Inc.', 'Electric Bill (June)', 'Withdraw', '', '16137.07', '48090.68', ''),
(804, '2013-09-06', '', '2013-09-06', 'Erick Jayson Correa', 'Payment from DragonPay', 'Deposit', '225', '', '48315.68', ''),
(806, '2013-09-06', '288873', '2013-09-06', 'Erick Jayson Correa', 'Reimbursement of Sir Elison', 'Withdraw', '', '9300.21', '39015.47', ''),
(807, '2013-09-09', '288874', '2013-09-09', 'Erick Jayson Correa', 'Payment to Load Expenses and Salary of Maam Keem', 'Withdraw', '', '2974.60', '36040.87', ''),
(808, '2013-09-12', '288876', '2013-09-12', 'Erick Jayson Correa', 'Salary of Maam Mary', 'Withdraw', '', '4462.90', '31577.97', ''),
(809, '2013-09-13', '', '2013-09-13', 'Erick Jayson Correa', 'Payment from DragonPay', 'Deposit', '2765', '', '34342.97', ''),
(810, '2013-09-13', '', '2013-09-13', 'Erick Jayson Correa', 'Payment from DragonPay', 'Deposit', '186.20', '', '34529.17', ''),
(811, '2013-09-13', '', '2013-09-13', 'Vigattin Inc.', 'Bank Transfer from ANTZ', 'Deposit', '100000', '', '134529.17', ''),
(812, '2013-09-13', '288878', '2013-09-13', 'Erick Jayson Correa', 'Prepaid Load and Daily Expense', 'Withdraw', '', '5308.20', '129220.97', ''),
(813, '2013-09-13', '288877', '2013-09-13', 'Erick Jayson Correa', 'Salary (August 31 - September 13, 2013)', 'Withdraw', '', '81215.69', '48005.28', ''),
(814, '2013-09-16', '288875', '2013-09-16', 'Elison Barcelo', 'Payment to Merchant (Jacobs Shawarma)', 'Withdraw', '', '423.20', '47582.08', ''),
(815, '2013-09-19', '288879', '2013-09-19', 'Genelus B. Alberto', 'Payment to Merchant (Best Finds Store)', 'Withdraw', '', '3748', '43834.08', ''),
(816, '2013-09-20', '', '2013-09-20', 'Erick Jayson Correa', 'Payment from DragonPay', 'Deposit', '2740', '', '46574.08', ''),
(817, '2013-09-20', '', '2013-09-20', 'Erick Jayson Correa', 'Payment from DragonPay', 'Deposit', '46.55', '', '46620.63', ''),
(818, '2013-09-20', '288881', '2013-09-20', 'Erick Jayson Correa', 'Reimbursement of Sir Elison', 'Withdraw', '', '8380', '38240.629999999', ''),
(819, '2013-09-24', '288882', '2013-09-24', 'Elison Barcelo', 'Amazon Web Services & Facebook Ads', 'Withdraw', '', '15128.64', '23111.989999999', ''),
(820, '2013-09-26', '288883', '2013-09-26', 'Innove Communications Inc.', 'Globe Bill (August to September)', 'Withdraw', '', '2295', '20816.989999999', ''),
(821, '2013-09-27', '', '2013-09-27', 'Erick Jayson Correa', 'Remittance from DragonPay', 'Deposit', '269', '', '21085.989999999', ''),
(822, '2013-09-27', '288884', '2013-09-27', 'Erick Jayson Correa', 'Reimbursement of Sir Elison', 'Withdraw', '', '3295.15', '17790.839999999', ''),
(823, '2013-09-27', '288880', '2013-09-27', 'CCT & Sons Development Inc.', 'Electric Bill for July', 'Withdraw', '', '11323.61', '6467.229999999', ''),
(824, '2013-09-30', '288885', '2013-09-30', 'Hridesh Parwani', 'Remittance to AOIP (VigattinDeals)', 'Withdraw', '', '286.18', '6181.0499999995', ''),
(825, '2013-09-30', '', '2013-09-30', 'Vigattin Inc.', 'Bank Transfer from ANTZ', 'Deposit', '100000', '', '106181.05', ''),
(826, '2013-09-30', '288888', '2013-09-30', 'Erick Jayson Correa', 'Salary (Sept. 14-30, 2013)', 'Withdraw', '', '96854.96', '9326.09', ''),
(827, '2013-09-30', '288890', '2013-09-30', 'Elison Barcelo', 'Sir Christians Professional Fee', 'Withdraw', '', '1850', '7476.0899999994', ''),
(828, '2013-09-30', '288889', '2013-09-30', 'Erick Jayson Correa', 'Prepaid Load Expenses', 'Withdraw', '', '1545', '5931.0899999994', ''),
(829, '2013-09-30', '', '2013-09-30', 'Vigattin Inc.', 'Service Charge', 'Withdraw', '', '500', '5431.0899999994', ''),
(830, '2013-09-30', '', '2013-09-30', 'Vigattin Inc.', 'Deposit', 'Deposit', '1.33', '', '5432.4199999994', ''),
(831, '2013-09-30', '', '2013-09-30', 'Vigattin Inc.', 'WT', 'Withdraw', '', '0.27', '5432.1499999995', ''),
(832, '2013-10-01', '', '2013-10-01', 'Vigattin Inc.', 'Bank Transfer from ANTZ', 'Deposit', '50000', '', '55432.149999999', ''),
(833, '2013-10-01', '288813', '2013-10-01', 'CCT & Sons Development Inc.', 'Rental Fee for the month of Oct.', 'Withdraw', '', '32000', '23432.149999999', ''),
(834, '2013-10-03', '288886', '2013-10-03', 'Gracielli Olivera Bauzon', 'Remittance to Hubgets Merchandising (VigattinDeals)', 'Withdraw', '', '223', '23209.149999999', ''),
(835, '2013-10-03', '288891', '2013-10-03', 'Gracielli Olivera Bauzon', 'Remittance to Hubgets Merchandising (VigattinDeals)', 'Withdraw', '', '223', '22986.149999999', ''),
(836, '2013-10-04', '', '2013-10-04', 'Vigattin Inc.', 'ZBD', 'Withdraw', '', '700', '22286.149999999', ''),
(837, '2013-10-07', '288894', '2013-10-07', 'Hridesh Parwani', 'Remittance to Sir Raj (Vigattindeals)', 'Withdraw', '', '531.36', '21754.789999999', ''),
(838, '2013-10-08', '', '2013-10-08', 'Vigattin Inc.', 'Bank Transfer from ANTZ', 'Deposit', '50000', '', '71754.79', ''),
(839, '2013-10-08', '288896', '2013-10-08', 'Erick Jayson Correa', 'Reimbursement of Sir Elison', 'Withdraw', '', '5516.90', '66237.89', ''),
(840, '2013-10-08', '288895', '2013-10-08', 'Genelus B. Alberto', 'Remittance to Best Finds Store (Vigattindeals)', 'Withdraw', '', '1299', '64938.89', ''),
(841, '2013-10-11', '', '2013-10-11', 'Erick Jayson Correa', 'Payment from DragonPay', 'Deposit', '1484', '', '66422.89', ''),
(842, '2013-10-11', '288897', '2013-10-11', 'Erick Jayson Correa', 'Reimbursement of Sir Elison & Prepaid load Expense', 'Withdraw', '', '6302.21', '60120.68', ''),
(843, '2013-10-14', '', '2013-10-14', 'Vigattin Inc.', 'Bank Transfer from ANTZ', 'Deposit', '100000', '', '160120.68', ''),
(844, '2013-10-14', '288898', '2013-10-14', 'Elison Barcelo', 'Amazon Web Services', 'Withdraw', '', '19492.80', '140627.88', ''),
(845, '2013-10-14', '288899', '2013-10-14', 'Erick Jayson Correa', 'Salary (October 1-15, 2013)', 'Withdraw', '', '99698.68', '40929.2', ''),
(846, '2013-10-18', '288900', '2013-10-18', 'Bayan Telecommunications Inc.', 'Bayantel (August to September)', 'Withdraw', '', '6498.99', '34430.21', ''),
(847, '2013-10-18', '330301', '2013-10-18', 'Erick Jayson Correa', 'Reimbursement of Sir Elison', 'Withdraw', '', '7453.20', '26977.009999999', ''),
(848, '2013-10-21', '', '2013-10-21', 'Vigattin Inc.', 'Bank Transfer from ANTZ', 'Deposit', '30000', '', '56977.009999999', ''),
(849, '2013-10-22', '330302', '2013-10-22', 'TransRadio Broadcasting Corporation', 'Vigattin Radio (Apr. 5 to May 4, 2013)', 'Withdraw', '', '25000', '31977.009999999', ''),
(850, '2013-10-24', '', '2013-10-24', 'Vigattin Inc.', 'Bank Transfer from ANTZ', 'Deposit', '100000', '', '131977.01', ''),
(851, '2013-10-24', '330303', '2013-10-24', 'Erick Jayson Correa', 'Facebook Ads', 'Withdraw', '', '41719.44', '90257.57', ''),
(852, '2013-10-25', '', '2013-10-25', 'Vigattin Inc.', 'CM', 'Deposit', '739', '', '90996.569999999', ''),
(853, '2013-10-25', '', '2013-10-25', 'Vigattin Inc.', 'CM', 'Deposit', '93.10', '', '91089.669999999', ''),
(854, '2013-10-25', '330305', '2013-10-25', 'Erick Jayson Correa', 'Reimbursement of Sir Elison', 'Withdraw', '', '7649.75', '83439.919999999', ''),
(855, '2013-10-25', '330306', '2013-10-25', 'Erick Jayson Correa', 'Prepaid Load Expenses', 'Withdraw', '', '1930', '81509.919999999', ''),
(856, '2013-10-29', '330304', '2013-10-29', 'TransRadio Broadcasting Corporation', 'Vigattin Radio (May 5 to June 4, 2013)', 'Withdraw', '', '50000', '31509.919999999', ''),
(857, '2013-10-31', '', '2013-10-31', 'Vigattin Inc.', 'CM', 'Deposit', '1097', '', '32606.919999999', ''),
(858, '2013-10-31', '', '2013-10-31', 'Vigattin Inc.', 'Bank Transfer from ANTZ', 'Deposit', '101633.29', '', '134240.21', ''),
(859, '2013-10-31', '330307', '2013-10-31', 'Erick Jayson Correa', 'Salary (October 15-30, 2013)', 'Withdraw', '', '101633.29', '32606.92', ''),
(860, '2013-10-31', '330308', '2013-10-31', 'Erick Jayson Correa', 'Intellectual Property Office', 'Withdraw', '', '2121', '30485.919999999', ''),
(861, '2013-10-31', '330309', '2013-10-31', 'Erick Jayson Correa', 'Reimbursement of Sir Elison', 'Withdraw', '', '5453.11', '25032.809999999', ''),
(862, '2013-10-31', '288892', '2013-10-31', 'CCT & Sons Development Inc.', 'Water Bill (August 3 - September 3, 2013)', 'Withdraw', '', '889.13', '24143.68', ''),
(863, '2013-10-31', '288893', '2013-10-31', 'CCT & Sons Development Inc.', 'Electric Bill (August 2013)', 'Withdraw', '', '18260.27', '5883.41', ''),
(864, '2013-10-31', '', '2013-10-31', 'Vigattin Inc.', 'Service Charge', 'Withdraw', '', '500', '5383.4099999997', ''),
(865, '2013-10-31', '', '2013-10-31', 'Vigattin Inc.', 'Deposit', 'Deposit', '5.81', '', '5389.2199999997', ''),
(866, '2013-10-31', '', '2013-10-31', 'Vigattin Inc.', 'WT', 'Withdraw', '', '1.16', '5388.0599999997', ''),
(867, '2013-11-04', '', '2013-11-04', 'Vigattin Inc.', 'ZBD', 'Withdraw', '', '1000', '4388.0599999996', ''),
(868, '2013-11-04', '', '2013-11-04', 'Vigattin Inc.', 'ZBD', 'Withdraw', '', '200', '4188.0599999996', ''),
(869, '2013-11-05', '', '2013-11-05', 'Vigattin Inc.', 'ZBD', 'Withdraw', '', '1000', '3188.0599999996', ''),
(870, '2013-11-06', '', '2013-11-06', 'Vigattin Inc.', 'Bank Transfer from ANTZ', 'Deposit', '50000', '', '53188.06', ''),
(871, '2013-11-08', '', '2013-11-08', 'Erick Jayson Correa', 'Remittance from DragonPay', 'Deposit', '1247', '', '54435.06', ''),
(872, '2013-11-08', '330310', '2013-11-08', 'Erick Jayson Correa', 'Reimbursement of Sir Elison', 'Withdraw', '', '7064.44', '47370.62', ''),
(873, '2013-11-08', '330311', '2013-11-08', 'Erick Jayson Correa', 'Prepaid Load Expenses', 'Withdraw', '', '1816', '45554.62', ''),
(874, '2013-11-08', '288814', '2013-11-08', 'CCT & Sons Development Inc.', 'Rental Fee for the month of Nov.', 'Withdraw', '', '32000', '13554.62', ''),
(875, '2013-11-15', '', '2013-11-15', 'Erick Jayson Correa', 'Remittance from DragonPay', 'Deposit', '439', '', '13993.62', ''),
(876, '2013-11-15', '', '2013-11-15', 'Vigattin Inc.', 'Bank Transfer from ANTZ', 'Deposit', '100000', '', '113993.62', ''),
(877, '2013-11-15', '330315', '2013-11-15', 'Erick Jayson Correa', 'Salary (Nov. 1-15, 2013)', 'Withdraw', '', '85487.45', '28506.17', ''),
(878, '2013-11-15', '330314', '2013-11-15', 'Maria Imelda C. Magtira', 'Remittance to MICM Shoes', 'Withdraw', '', '530', '27976.169999999', ''),
(880, '2013-11-15', '330313', '2013-11-15', 'Gale Manalili', 'Remittance to Mary Pauline Salon (Vito Cruz Branch)', 'Withdraw', '', '599.20', '27376.969999999', ''),
(881, '2013-11-19', '330312', '2013-11-19', 'Kurt Bryan L. Tan', 'Remittance to Giorgio Trading', 'Withdraw', '', '279.20', '27097.769999999', ''),
(883, '2013-11-20', '330319', '2013-11-20', 'Erick Jayson Correa', 'Reimbursement of Sir Elison', 'Withdraw', '', '3966.50', '23131.269999999', ''),
(884, '2013-11-21', '330321', '2013-11-21', 'Erick Jayson Correa', 'Prepaid Load Expenses', 'Withdraw', '', '2546', '20585.269999999', ''),
(885, '2013-11-22', '', '2013-11-22', 'Erick Jayson Correa', 'Remittance from DragonPay', 'Deposit', '6716', '', '27301.269999999', ''),
(886, '2013-11-22', '330317', '2013-11-22', 'Royal Lake Entertainment Inc.', 'Remittance to Royal Lake Entertainment Inc.', 'Withdraw', '', '920', '26381.269999999', ''),
(887, '2013-11-22', '330316', '2013-11-22', 'Royal Lake Entertainment Inc.', 'Remittance to Royal Lake Entertainment Inc.', 'Withdraw', '', '5980', '20401.269999999', ''),
(888, '2013-11-25', '', '2013-11-25', 'Vigattin Inc.', 'Bank Transfer from ANTZ', 'Deposit', '100000', '', '120401.27', ''),
(889, '2013-11-25', '330322', '2013-11-25', 'Erick Jayson Correa', 'Amazon Web Services and Facebook Ads', 'Withdraw', '', '33654.31', '86746.96', ''),
(890, '2013-11-26', '330331', '2013-11-26', 'Bayan Telecommunications Inc.', 'Bayantel Internet and Landline Services', 'Withdraw', '', '5499', '81247.959999999', ''),
(891, '2013-11-26', '330323', '2013-11-26', 'Enrico B. Reyes', 'Professional Fee of Sir Rico', 'Withdraw', '', '2000', '79247.959999999', ''),
(892, '2013-11-27', '330320', '2013-11-27', 'TransRadio Broadcasting Corporation', 'Vigattin Radio (Aug. 5 to Sept. 4, 2013)', 'Withdraw', '', '25000', '54247.959999999', ''),
(893, '2013-11-28', '330330', '2013-11-28', 'Innove Communications Inc.', 'Globe Internet and Landline Services', 'Withdraw', '', '4590', '49657.959999999', ''),
(894, '11/29/2013', '', '11/29/2013', 'Vigattin Inc.', 'CM', 'Deposit', '7725', '', '57382.959999999', ''),
(895, '11/29/2013', '', '11/29/2013', 'Vigattin Inc.', 'CM', 'Deposit', '677.35', '', '58060.309999999', ''),
(896, '11/29/2013', '330326', '11/29/2013', 'Maria Imelda C. Magtira', 'Remittance to MICM Shoes', 'Withdraw', '', '1510', '56550.309999999', ''),
(897, '11/29/2013', '330329', '11/29/2013', 'Gracielli Olivera Bauzon', 'Remittance to Hubgets Merchandising (VigattinDeals)', 'Withdraw', '', '359.20', '56191.109999999', ''),
(898, '11/29/2013', '330325', '11/29/2013', ' Leah P. Fortaleza', 'Remittance to Mary Pauline Salon (Vito Cruz Branch)', 'Withdraw', '', '599.20', '55591.909999999', ''),
(899, '11/29/2013', '330328', '11/29/2013', 'MNO Boutique', 'Remittance to MNO Boutique', 'Withdraw', '', '319.20', '55272.709999999', ''),
(900, '11/29/2013', '330338', '11/29/2013', 'Erick Jayson Correa', 'Reimbursement of Sir Elison', 'Withdraw', '', '9901.50', '45371.209999999', ''),
(901, '11/29/2013', '', '11/29/2013', 'Vigattin Inc.', 'Bank Transfer from ANTZ', 'Deposit', '320000', '', '365371.21', ''),
(902, '11/29/2013', '330337', '11/29/2013', 'Erick Jayson Correa', 'Salary (Nov. 16 - 30, 2013)', 'Withdraw', '', '94991.29', '270379.92', ''),
(903, '11/29/2013', '', '11/29/2013', 'Vigattin Inc.', 'Service Charge', 'Withdraw', '', '500', '269879.92', ''),
(904, '11/29/2013', '', '11/29/2013', 'Vigattin Inc.', 'Deposit', 'Deposit', '4.08', '', '269884', ''),
(905, '11/29/2013', '', '11/29/2013', 'Vigattin Inc.', 'WT', 'Withdraw', '', '0.82', '269883.18', ''),
(906, '12/02/2013', '', '12/02/2013', 'Vigattin Inc.', 'Bank Transfer from ANTZ', 'Deposit', '50000', '', '319883.18', ''),
(907, '12/02/2013', '330327', '12/02/2013', 'Leah Camille Sabinosa', 'Remittance to Nailville', 'Withdraw', '', '309.60', '319573.58', ''),
(908, '12/02/2013', '330324', '12/02/2013', 'Kurt Bryan L. Tan', 'Remittance to Giorgio Trading', 'Withdraw', '', '279.20', '319294.38', ''),
(909, '12/02/2013', '330333', '12/02/2013', 'CCT & Sons Development Inc.', 'Water Bill (9/3/13 to 10/3/13)', 'Withdraw', '', '856.03', '318438.35', ''),
(910, '12/02/2013', '330335', '12/02/2013', 'CCT & Sons Development Inc.', 'Water Bill (10/3/13 to 11/3/13)', 'Withdraw', '', '898.58', '317539.77', ''),
(911, '12/02/2013', '330334', '12/02/2013', 'CCT & Sons Development Inc.', 'Electric Bill (October 2013)', 'Withdraw', '', '12248.39', '305291.38', ''),
(912, '12/02/2013', '330332', '12/02/2013', 'CCT & Sons Development Inc.', 'Electric Bill (September 2013)', 'Withdraw', '', '14208.60', '291082.78', ''),
(913, '12/03/2013', '330336', '12/03/2013', 'Royal Lake Entertainment Inc.', 'Payment to Royal Lake Spa (500 pcs. vouchers at P408 each)', 'Withdraw', '', '204000', '87082.78', ''),
(914, '12/05/2013', '', '12/05/2013', 'Erick Jayson Correa', 'Paypal', 'Deposit', '12155.04', '', '99237.819999998', ''),
(915, '12/06/2013', '330339', '12/06/2013', 'Erick Jayson Correa', 'Prepaid Load Expenses', 'Withdraw', '', '3050', '96187.819999998', ''),
(916, '12/06/2013', '330340', '12/06/2013', 'Erick Jayson Correa', 'Reimbursement of Sir Elison', 'Withdraw', '', '5544.20', '90643.619999998', ''),
(917, '12/06/2013', '330342', '12/06/2013', 'MNO Boutique', 'Remittance to MNO Boutique', 'Withdraw', '', '239.20', '90404.419999998', ''),
(918, '12/09/2013', '', '12/09/2013', 'Vigattin Inc.', 'Hotel Sogo GC (Cash Deposit)', 'Deposit', '846', '', '91250.419999998', ''),
(919, '12/09/2013', '', '12/09/2013', 'Vigattin Inc.', 'Hotel Sogo GC (Cash Deposit)', 'Deposit', '846', '', '92096.419999998', ''),
(920, '12/10/2013', '330341', '12/10/2013', 'Ricky B. Bincal', 'Remittance to PerfumesPh', 'Withdraw', '', '1800', '90296.419999998', ''),
(921, '12/13/2013', '', '12/13/2013', 'Vigattin Inc.', 'Remittance from DragonPay', 'Deposit', '4277', '', '94573.419999998', ''),
(922, '12/13/2013', '330343', '12/13/2013', 'Erick Jayson Correa', 'Payment to NB Megacard (Calling Cards)', 'Withdraw', '', '1750', '92823.419999998', ''),
(923, '12/13/2013', '330346', '12/13/2013', 'Erick Jayson Correa', 'Reimbursement of Sir Elison', 'Withdraw', '', '14717.25', '78106.169999998', ''),
(924, '12/13/2013', '', '12/13/2013', 'Vigattin Inc.', 'Payment to 2 Hotel Sogo GC', 'Deposit', '1692', '', '79798.169999998', ''),
(925, '12/02/2013', '', '12/13/2013', 'Vigattin Inc.', 'Payment to 6 Vouchers of Royal Lake (from Antz)', 'Deposit', '3120', '', '82918.169999998', ''),
(926, '12/13/2013', '', '12/13/2013', 'Vigattin Inc.', 'Bank Transfer from ANTZ', 'Deposit', '100000', '', '182918.17', ''),
(927, '12/13/2013', '330347', '12/13/2013', 'Erick Jayson Correa', 'Salary (Nov. 30 - Dec. 13, 2013)', 'Withdraw', '', '96151.83', '86766.34', ''),
(928, '12/13/2013', '330348', '12/13/2013', 'Erick Jayson Correa', 'Prepaid Load Expenses', 'Withdraw', '', '1325', '85441.339999998', ''),
(929, '12/16/2013', '', '12/16/2013', 'Vigattin Inc.', 'Deposit', 'Deposit', '2080', '', '87521.339999998', ''),
(930, '12/16/2013', '330345', '12/16/2013', 'Phil. Creations Inc', 'Remittance to PCI', 'Withdraw', '', '835.50', '86685.839999998', ''),
(931, '12/16/2013', '330344', '12/16/2013', 'Ricky B. Bincal', 'Remittance to PerfumesPh', 'Withdraw', '', '3350', '83335.839999998', ''),
(932, '12/18/2013', '330349', '12/18/2013', 'TransRadio Broadcasting Corporation', 'Vigattin Radio (Sept. 5 to Oct. 4, 2013)', 'Withdraw', '', '25000', '58335.839999998', ''),
(933, '12/19/2013', '330351', '12/19/2013', 'Erick Jayson Correa', 'Amazon Web Services and Facebook Ads', 'Withdraw', '', '35281.88', '23053.959999998', ''),
(934, '12/19/2013', '330350', '12/19/2013', 'Genelus B. Alberto', 'Remittance to Best Finds Store (Vigattindeals)', 'Withdraw', '', '1700', '21353.959999998', ''),
(935, '12/20/2013', '', '12/20/2013', 'Vigattin Inc.', 'CM', 'Deposit', '18732', '', '40085.959999998', ''),
(936, '12/20/2013', '330355', '12/20/2013', 'Erick Jayson Correa', 'Reimbursement of Sir Elison', 'Withdraw', '', '5682.29', '34403.669999998', ''),
(937, '12/26/2013', '330352', '12/26/2013', 'Teresita A. Tan', 'Remittance to Right Harvest International Inc.', 'Withdraw', '', '400', '34003.669999998', ''),
(938, '12/27/2013', '', '12/27/2013', 'Vigattin Inc.', 'CM', 'Deposit', '26313', '', '60316.669999998', ''),
(939, '12/27/2013', '', '12/27/2013', 'Vigattin Inc.', 'Bank Transfer from ANTZ', 'Deposit', '150000', '', '210316.67', ''),
(940, '12/27/2013', '330363', '12/27/2013', 'Bayan Telecommunications Inc.', 'Bayantel and Landline Services', 'Withdraw', '', '5499', '204817.67', ''),
(941, '12/27/2013', '330364', '12/27/2013', 'Innove Communications Inc.', 'Globe Internet and Landline Services', 'Withdraw', '', '2295', '202522.67', ''),
(943, '12/27/2013', '330365', '12/27/2013', 'Ricky B. Bincal', 'Remittance to PerfumesPh', 'Withdraw', '', '4300', '198222.67', ''),
(944, '12/27/2013', '', '12/27/2013', 'Vigattin Inc.', 'CM', 'Deposit', '4300', '', '202522.67', ''),
(945, '12/27/2013', '330359', '12/27/2013', 'Gale Manalili', 'Remittance to Mary Pauline Salon (Kamias Branch)', 'Withdraw', '', '599.20', '201923.47', ''),
(946, '12/27/2013', '330360', '12/27/2013', 'Belinda R. Ferrer', 'Remittance to Mary Pauline Salon (Buendia-Pasay Branch)', 'Withdraw', '', '599.20', '201324.27', ''),
(947, '12/27/2013', '330362', '12/27/2013', 'Erick Jayson Correa', 'Prepaid Load Expenses', 'Withdraw', '', '2254', '199070.27', ''),
(948, '12/27/2013', '330358', '12/27/2013', 'Gracielli Olivera Bauzon', 'Remittance to Hubgets Merchandising', 'Withdraw', '', '3510.40', '195559.87', ''),
(950, '12/27/2013', ' 330361', '12/27/2013', 'Erick Jayson Correa', 'Salary (Dec.2013)', 'Withdraw', '', '89922.70', '105637.17', ''),
(951, '12/27/2013', '330353', '12/27/2013', 'Jacqueline Lim', 'Remittance to Pichapies Corner', 'Withdraw', '', '225', '105412.17', ''),
(952, '12/27/2013', '330354', '12/27/2013', 'MaÃ±a Asian Sensational Spa', 'Remittance to MaÃ±a Asian Sensational Spa', 'Withdraw', '', '477.60', '104934.57', ''),
(953, '12/27/2013', '', '12/27/2013', 'Vigattin Inc.', 'Deposit', 'Deposit', '18.07', '', '104952.64', ''),
(955, '12/27/2013', '', '12/27/2013', 'Vigattin Inc.', 'WT', 'Withdraw', '', '3.61', '104949.03', ''),
(956, '01/02/2014', '288815', '01/02/2014', 'CCT & Sons Development Inc.', 'Rental Fee for the month of Dec.', 'Withdraw', '', '32000', '72949.03', ''),
(957, '01/03/2014', '', '01/03/2014', 'Vigattin Inc.', 'CM', 'Deposit', '6241', '', '79190.029999997', ''),
(958, '01/03/2014', '', '01/03/2014', 'Vigattin Inc.', 'DEPN', 'Deposit', '1899', '', '81089.029999997', ''),
(959, '01/06/2014', '330367', '01/06/2014', 'Gracielli Olivera Bauzon', 'Remittance to Hubgets Merchandising', 'Withdraw', '', '199.20', '80889.829999997', ''),
(960, '01/06/2014', '330366', '01/06/2014', 'Josephine Arceo                                                                                     ', 'Remittance to Pink2Pink', 'Withdraw', '', '298.50', '80591.329999997', ''),
(961, '01/06/2014', '', '01/06/2014', 'Vigattin Inc.', 'CM', 'Deposit', '1000', '', '81591.329999997', ''),
(962, '01/06/2014', '330373', '01/06/2014', 'Lara Jill A. Saldivar', 'Remittance to The Lax Shoppe', 'Withdraw', '', '1600', '79991.329999997', ''),
(971, '01/07/2014', '330369', '01/07/2014', 'Erick Jayson Correa', 'Professional Fee of Mr. Den Macaranas (Dec. 7, 14, 21, 28, 2013)', 'Withdraw', '', '5000', '74991.329999997', ''),
(973, '01/07/2014', '330372', '01/07/2014', 'Erick Jayson Correa', 'Reimbursement of Sir Elison', 'Withdraw', '', '10123.65', '64867.679999997', ''),
(974, '01/07/2014', '330371', '01/07/2014', 'Erick Jayson Correa', 'Prepaid Load Expenses', 'Withdraw', '', '1600', '63267.679999997', ''),
(975, '01/07/2014', '330368', '01/07/2014', 'Ricky B. Bincal', 'Remittance to PerfumesPh', 'Withdraw', '', '7550', '55717.679999997', ''),
(976, '01/09/2014', '', '01/09/2014', 'Vigattin Inc.', 'DEPN', 'Deposit', '1040', '', '56757.679999997', ''),
(977, '01/09/2014', '330370', '01/09/2014', 'TransRadio Broadcasting Corporation', 'Vigattin Radio (Oct. 5 to Nov. 4, 2013)', 'Withdraw', '', '25000', '31757.679999997', ''),
(978, '01/10/2014', '', '01/10/2014', 'Vigattin Inc.', 'CM', 'Deposit', '4615', '', '36372.679999997', ''),
(979, '01/10/2014', '330376', '01/10/2014', 'Jasmin A. Ortega', 'Remittance to Nail Axis Hand and Foot Spa', 'Withdraw', '', '318.40', '36054.279999997', ''),
(980, '01/10/2014', '330405', '01/10/2014', 'Erick Jayson Correa', 'Reimbursement of Sir Elison', 'Withdraw', '', '13251.25', '22803.029999997', ''),
(981, '01/10/2014', '330406', '01/10/2014', 'Erick Jayson Correa', 'Prepaid Load Expenses', 'Withdraw', '', '2416', '20387.029999997', ''),
(982, '01/10/2014', '', '01/10/2014', 'Vigattin Inc.', 'CM', 'Deposit', '126337.14', '', '146724.17', ''),
(983, '01/10/2014', '0330357', '01/10/2014', 'Gigabuilt Cons. Corp. ', 'Reimbursement of Sir Yarlie', 'Withdraw', '', '116337.14', '30387.03', ''),
(984, '01/13/2014', '330378', '01/13/2014', 'CCT & Sons Development Inc.', 'Water Bill (Nov. 3 - Dec, 3, 2013)', 'Withdraw', '', '1749.63', '28637.399999997', ''),
(985, '01/13/2014', '330377', '01/13/2014', 'CCT & Sons Development Inc.', 'Electric Bill (Nov. 1 -30, 2013)', 'Withdraw', '', '12848.93', '15788.469999998', ''),
(986, '01/16/2014', '', '01/16/2014', 'Vigattin Inc.', 'Bank Transfer from ANTZ', 'Deposit', '110000', '', '125788.47', ''),
(988, '01/16/2014', '330408', '01/16/2014', 'Erick Jayson Correa', 'Salary (January - 15, 2014)', 'Withdraw', '', '102083.33', '23705.14', ''),
(989, '01/16/2014', '330407', '01/16/2014', 'Erick Jayson Correa', 'Payment to NB Megacard', 'Withdraw', '', '3975', '19730.139999997', ''),
(990, '01/17/2014', '', '01/17/2014', 'Vigattin Inc.', 'CM', 'Deposit', '10458', '', '30188.139999997', ''),
(991, '01/17/2014', '', '01/17/2014', 'Vigattin Inc.', 'CM', 'Deposit', '472.15', '', '30660.289999997', ''),
(992, '01/22/2014', '', '01/22/2014', 'Vigattin Inc.', 'DEPN', 'Deposit', '12200', '', '42860.289999997', ''),
(993, '01/22/2014', '330414', '01/22/2014', 'Samuel A. So, Jr.', 'Remittance to La Carmela de Boracay', 'Withdraw', '', '10200', '32660.289999997', ''),
(995, '01/22/2014', '330375', '01/22/2014', 'Leah Camille Sabinosa', 'Remittance to Nailville', 'Withdraw', '', '130.20', '32530.089999997', ''),
(996, '01/22/2014', '330412', '01/22/2014', 'Erick Jayson Correa', 'Prepaid Load Expenses', 'Withdraw', '', '2310', '30220.089999997', ''),
(997, '01/22/2014', '', '01/22/2014', 'Vigattin Inc.', 'ZBD', 'Withdraw', '', '118.20', '30101.889999997', ''),
(998, '01/22/2014', '330411', '01/22/2014', 'Yenom Marketing Corporation', 'Payment to Yenom Marketing Corporation', 'Withdraw', '', '2244.90', '27856.989999997', ''),
(999, '01/23/2014', '330413', '01/23/2014', 'Kurt Bryan L. Tan', 'Remittance to Giorgio Trading', 'Withdraw', '', '558.40', '27298.589999997', ''),
(1000, '01/24/2014', '', '01/24/2014', 'Vigattin Inc.', 'CM', 'Deposit', '9899', '', '37197.589999997', ''),
(1001, '01/24/2014', '330417', '01/24/2014', 'Teresita A. Tan', 'Remittance to Right Harvest International Inc', 'Withdraw', '', '400', '36797.589999997', ''),
(1002, '01/24/2014', '330416', '01/24/2014', 'MNO Boutique', 'Remittance to MNO Boutique', 'Withdraw', '', '439.20', '36358.389999997', ''),
(1003, '01/24/2014', '330415', '01/24/2014', 'Erick Jayson Correa', 'Reimbursement of Sir Elison', 'Withdraw', '', '8995.31', '27363.079999997', ''),
(1004, '01/24/2014', '', '01/24/2014', 'Vigattin Inc.', 'DEPN', 'Deposit', '4680', '', '32043.079999997', ''),
(1005, '01/27/2014', '', '01/27/2014', 'Vigattin Inc.', 'DEPN', 'Deposit', '5912', '', '37955.079999997', ''),
(1006, '01/27/2014', '', '01/27/2014', 'Vigattin Inc.', 'Bank Transfer from ANTZ', 'Deposit', '80000', '', '117955.08', ''),
(1007, '01/27/2014', '330421', '01/27/2014', 'Erick Jayson Correa', 'Facebook Ads, Amazon Web Services and Domain', 'Withdraw', '', '46499.49', '71455.59', ''),
(1008, '01/27/2014', '330420', '01/27/2014', 'Erick Jayson Correa', 'Prepaid Load Expenses', 'Withdraw', '', '1656', '69799.589999997', ''),
(1010, '01/27/2014', '330418', '01/27/2014', 'Gladys M. Armas', 'Remittance to Mary Pauline Salon Coronet', 'Withdraw', '', '1198.40', '68601.189999997', ''),
(1011, '01/28/2014', '330442', '01/28/2014', 'Samuel A. So, Jr.', 'Remittance to La Carmela de Boracay', 'Withdraw', '', '5100', '63501.189999997', ''),
(1012, '01/28/2014', '330379', '01/28/2014', 'CCT & Sons Development Inc.', 'Additional Security Deposit', 'Withdraw', '', '4485.99', '59015.199999997', ''),
(1013, '01/29/2014', '', '01/29/2014', 'Vigattin Inc.', 'DEPN', 'Deposit', '8868', '', '67883.199999996', ''),
(1014, '01/29/2014', '330429', '01/29/2014', 'Innove Communications Inc.', 'Globe Internet and Landline Services', 'Withdraw', '', '2295', '65588.199999996', ''),
(1015, '01/29/2014', '330430', '01/29/2014', 'Erick Jayson Correa', 'Globe Internet and Landline Services', 'Withdraw', '', '4365.50', '61222.699999996', ''),
(1016, '01/29/2014', '330428', '01/29/2014', 'Samuel A. So, Jr.', 'Remittance to La Carmela de Boracay', 'Withdraw', '', '7650', '53572.699999996', ''),
(1017, '01/29/2014', '330431', '01/29/2014', 'Erick Jayson Correa', 'Reimbursement of Sir Yarlie', 'Withdraw', '', '7408.06', '46164.639999996', ''),
(1018, '01/29/2014', '', '01/29/2014', 'Vigattin Inc.', 'Bank Transfer from ANTZ', 'Deposit', '16615.05', '', '62779.689999996', ''),
(1019, '01/30/2014', '', '01/30/2014', 'Vigattin Inc.', 'CM', 'Deposit', '1291', '', '64070.689999996', ''),
(1020, '01/30/2014', '', '01/30/2014', 'Vigattin Inc.', 'CM', 'Deposit', '418', '', '64488.689999996', ''),
(1021, '01/30/2014', '330424', '01/30/2014', 'Jasmin A. Ortega', 'Remittance to Nail Axis Hand and Foot Spa', 'Withdraw', '', '239.20', '64249.489999996', ''),
(1022, '01/30/2014', '330427', '01/30/2014', 'Maria Imelda C. Magtira', 'Remittance to MICM', 'Withdraw', '', '1060', '63189.489999996', ''),
(1023, '01/30/2014', '', '01/30/2014', 'Vigattin Inc.', 'Bank Transfer from ANTZ', 'Deposit', '130000', '', '193189.49', ''),
(1024, '01/30/2014', '330433', '01/30/2014', 'Erick Jayson Correa', 'Prepaid Load Expenses', 'Withdraw', '', '2130', '191059.49', ''),
(1025, '01/30/2014', '330432', '01/30/2014', 'Erick Jayson Correa', 'Salary (January 16-30, 2014)', 'Withdraw', '', '97227.50', '93831.99', ''),
(1026, '01/30/2014', '330425', '01/30/2014', 'Bayan Telecommunications Inc.', 'Bayantel Internet and Landline Services', 'Withdraw', '', '8398.96', '85433.029999996', ''),
(1027, '01/30/2014', '330419', '01/30/2014', 'TransRadio Broadcasting Corporation', 'Vigattin Radio (Nov. 5 to Dec. 4, 2013)', 'Withdraw', '', '25000', '60433.029999997', ''),
(1028, '01/30/2014', '', '01/30/2014', 'Vigattin Inc.', 'Deposit', 'Deposit', '6.63', '', '60439.659999997', ''),
(1029, '01/30/2014', '', '01/30/2014', 'Vigattin Inc.', 'WT', 'Withdraw', '', '1.33', '60438.329999996', ''),
(1030, '02/03/2014', '330434', '02/03/2014', 'Erick Jayson Correa', 'Mayors Permit 2014', 'Withdraw', '', '12972', '47466.329999996', ''),
(1031, '02/03/2014', '', '02/03/2014', 'Vigattin Inc.', 'Bank Transfer from ANTZ', 'Deposit', '50000', '', '97466.329999996', ''),
(1032, '02/03/2014', '330426', '02/03/2014', 'Naneth H. Leonardo', 'Remittance to Monaka Clothing & Accessories', 'Withdraw', '', '351.12', '97115.209999996', ''),
(1033, '02/03/2014', '330423', '02/03/2014', 'Ricky B. Bincal', 'Remittance to PerfumesPh', 'Withdraw', '', '1800', '95315.209999996', ''),
(1034, '02/03/2014', '330380', '02/03/2014', 'CCT & Sons Development Inc.', 'Rental Fee (February 1 - 28, 2014)', 'Withdraw', '', '33600', '61715.209999996', ''),
(1035, '02/03/2014', '330381', '02/03/2014', 'CCT & Sons Development Inc.', 'Rental Fee (January 1 - 31, 2017)', 'Withdraw', '', '37044', '24671.209999996', ''),
(1036, '02/04/2014', '330410', '02/04/2014', 'Marion O. Laroza', 'Remittance to P&D Facial Care & Spa', 'Withdraw', '', '111.75', '24559.459999996', ''),
(1037, '02/05/2014', '', '02/05/2014', 'Vigattin Inc.', 'DEPN', 'Deposit', '500', '', '25059.459999996', ''),
(1038, '02/05/2014', '', '02/05/2014', 'Vigattin Inc.', 'Deposit', 'Deposit', '450', '', '25509.459999996', ''),
(1039, '02/06/2013', '', '02/06/2014', 'Vigattin Inc.', 'DEPN', 'Deposit', '5912', '', '31421.459999996', ''),
(1040, '02/06/2013', '', '02/06/2014', 'Vigattin Inc.', 'DEPN', 'Deposit', '11824', '', '43245.459999996', ''),
(1041, '02/06/2013', '330440', '02/06/2014', 'Samuel A. So, Jr.', 'Remittance to La Carmela de Boracay', 'Withdraw', '', '10200', '33045.459999996', ''),
(1042, '02/06/2013', '330422', '02/06/2014', 'Samuel A. So, Jr.', 'Remittance to La Carmela de Boracay', 'Withdraw', '', '5100', '27945.459999996', ''),
(1043, '02/07/2014', '', '02/07/2014', 'Vigattin Inc.', 'CM', 'Deposit', '1568', '', '29513.459999996', ''),
(1044, '02/07/2014', '330438', '02/07/2014', 'Gladys M. Armas', 'Remittance to Mary Pauline Salon Coronet', 'Withdraw', '', '599.20', '28914.259999996', ''),
(1045, '02/07/2014', '330435', '02/07/2014', 'Leah Camille Sabinosa', 'Remittance to Nailville', 'Withdraw', '', '390.60', '28523.659999996', ''),
(1046, '02/07/2014', '330441', '02/07/2014', 'Erick Jayson Correa', 'Prepaid Load Expenses', 'Withdraw', '', '2376', '26147.659999996', ''),
(1047, '02/07/2014', '330436', '02/07/2014', 'Josephine Arceo                                                                                     ', 'Remittance to Pink2Pink', 'Withdraw', '', '4784.25', '21363.409999996', ''),
(1048, '02/07/2014', '330437', '02/07/2014', 'Jasmin A. Ortega', 'Remittance to Nail Axis Hand and Foot Spa', 'Withdraw', '', '478.40', '20885.009999996', ''),
(1049, '02/07/2014', '330443', '02/07/2014', 'Erick Jayson Correa', 'Reimbursement of Sir Elison', 'Withdraw', '', '9440.50', '11444.509999996', ''),
(1052, '02/10/2014', '330439', '02/10/2014', 'May Fernando', 'Remittance to Manila Venetian Hotel', 'Withdraw', '', '2554.20', '8890.309999996', ''),
(1053, '02/12/2014', '0330446', '02/12/2014', 'Erick Jayson Correa', 'Refund for 7 Royal Lake Voucher of Mr. Christopher Dela Torre (520/voucher less Payment Gateway)', 'Withdraw', '', '3620', '5270.3099999959', ''),
(1054, '02/14/2014', '', '02/14/2014', 'Vigattin Inc.', 'CM', 'Deposit', '5103', '', '10373.309999996', ''),
(1055, '02/14/2014', '', '02/14/2014', 'Vigattin Inc.', 'Bank Transfer from ANTZ', 'Deposit', '115000', '', '125373.31', ''),
(1056, '02/14/2014', '0330449', '02/14/2014', 'Erick Jayson Correa', 'Salary (Jan. 31- Feb. 14,2014)', 'Withdraw', '', '102905.96', '22467.35', ''),
(1057, '02/14/2014', '330448', '02/14/2014', 'Erick Jayson Correa', 'Remittance to Nailville', 'Withdraw', '', '236.40', '22230.949999996', ''),
(1058, '02/14/2014', '330447', '02/14/2014', 'Belinda R. Ferrer', 'Remittance to Mary Pauline Salon (Buendia-Pasay Branch)', 'Withdraw', '', '599.20', '21631.749999996', ''),
(1059, '02/17/2014', '', '02/17/2014', 'Vigattin Inc.', 'ZBD', 'Withdraw', '', '1050', '20581.749999995', ''),
(1060, '02/17/2014', '', '02/17/2014', 'Vigattin Inc.', 'DEPN', 'Deposit', '3100', '', '23681.749999995', ''),
(1061, '02/17/2014', '', '02/17/2014', 'Vigattin Inc.', 'Bank Transfer from ANTZ', 'Deposit', '200000', '', '223681.74999999', ''),
(1062, '02/17/2014', '', '02/17/2014', 'Vigattin Inc.', 'DEPN', 'Deposit', '49742', '', '273423.75', ''),
(1063, '02/17/2014', '330452', '02/17/2014', 'Erick Jayson Correa', 'Reimbursement of Sir Elison', 'Withdraw', '', '11683.71', '261740.04', ''),
(1064, '02/17/2014', '330450', '02/17/2014', 'Erick Jayson Correa', 'Prepaid Load Expenses', 'Withdraw', '', '2030', '259710.04', ''),
(1065, '02/18/2014', '330451', '02/18/2014', 'Samuel A. So, Jr.', 'Payment to La Carmela de Boracay (Prepaid rooms)', 'Withdraw', '', '196840', '62870.04', ''),
(1066, '02/20/2014', '', '02/20/2014', 'Vigattin Inc.', 'DEPN', 'Deposit', '3400', '', '66270.039999995', ''),
(1067, '02/21/2014', '', '02/21/2014', 'Vigattin Inc.', 'CM', 'Deposit', '15983', '', '82253.039999995', ''),
(1068, '02/21/2014', '', '02/21/2014', 'Vigattin Inc.', 'DEPN', 'Deposit', '500', '', '82753.039999995', ''),
(1069, '02/21/2014', '', '02/21/2014', 'Vigattin Inc.', 'DEPN', 'Deposit', '3100', '', '85853.039999995', ''),
(1070, '02/21/2014', '3304556', '02/21/2014', 'Right Harvest International Inc.', 'Remttance to Right Harvest', 'Withdraw', '', '400', '85453.039999995', ''),
(1071, '02/21/2014', '330460', '02/21/2014', 'Samuel A. So, Jr.', 'Remittance to La Carmela de Boracay', 'Withdraw', '', '2550', '82903.039999995', ''),
(1072, '02/21/2014', '330462', '02/21/2014', 'Erick Jayson Correa', 'Prepaid Load Expenses (from Feb. 14-20,2014)', 'Withdraw', '', '2932', '79971.039999995', ''),
(1073, '02/21/2014', '', '02/21/2014', 'Vigattin Inc.', 'WD', 'Withdraw', '', '50', '79921.039999995', ''),
(1074, '02/24/2014', '', '02/24/2014', 'Vigattin Inc.', 'DEPN', 'Deposit', '2428.40', '', '82349.439999995', ''),
(1075, '02/24/2014', '330463', '02/24/2014', 'Erick Jayson Correa', 'Facebook Ads and Amazon Web services', 'Withdraw', '', '35954.89', '46394.549999996', ''),
(1076, '02/24/2014', '330457', '02/24/2014', 'Travelus Passport Suit', 'Remittance to Travelus Passport Suit', 'Withdraw', '', '135', '46259.549999996', ''),
(1077, '02/24/2014', '330453', '02/24/2014', 'MaÃ±a Asian Sensational Spa', 'Remittace to MaÃ±a Asian Sensational Spa', 'Withdraw', '', '159.20', '46100.349999996', ''),
(1078, '02/24/2014', '330455', '02/24/2014', 'Phil. Creations Inc', 'remittace to PCI', 'Withdraw', '', '202.50', '45897.849999996', ''),
(1079, '02/24/2014', '3303445', '02/24/2014', 'CCT & Sons Development Inc.', 'Water Bill (Dec. 3, 2013 to Jan. 4, 2014)', 'Withdraw', '', '1313.30', '44584.549999996', '');
INSERT INTO `balance` (`id`, `date`, `checkno`, `checkdate`, `payee`, `particulars`, `type`, `deposit`, `withdraw`, `amount`, `timein`) VALUES
(1080, '02/24/2014', '0330371', '02/24/2014', 'Erick Jayson Correa', 'Prepaid Load Expenses', 'Withdraw', '', '1600', '42984.549999996', ''),
(1081, '02/24/2014', '330458', '02/24/2014', '5300', 'Remittance to Vigattin Phil.', 'Withdraw', '', '5300', '37684.549999996', ''),
(1082, '02/24/2014', '330444', '02/24/2014', 'CCT & Sons Development Inc.', 'Electric Bill (Dec. 1-31, 2013)', 'Withdraw', '', '18110.79', '19573.759999996', ''),
(1083, '02/27/2014', '', '02/27/2014', 'Vigattin Inc.', 'DEPN', 'Deposit', '28700', '', '48273.759999996', ''),
(1084, '02/27/2014', '330465', '02/27/2014', 'Erick Jayson Correa', 'Payment to Ms. Laureen Redulas Ticket to Malaysia', 'Withdraw', '', '27000', '21273.759999996', ''),
(1085, '02/28/2014', '', '02/28/2014', 'Vigattin Inc.', 'DEPN', 'Deposit', '384', '', '21657.759999996', ''),
(1086, '02/28/2014', '', '02/28/2014', 'Vigattin Inc.', 'DEPN', 'Deposit', '29970', '', '51627.759999996', ''),
(1087, '02/28/2014', '', '02/28/2014', 'Vigattin Inc.', 'DEPN', 'Deposit', '39500', '', '91127.759999996', ''),
(1088, '02/28/2014', '330466', '02/28/2014', 'Erick Jayson Correa', 'Payment to Jonatz Travel and Tours (Rajeta Salazar and Lorencia Oblipias) Hong Kong Tour (4D/3N)', 'Withdraw', '', '28044.80', '63082.959999996', ''),
(1089, '02/28/2014', '', '02/28/2014', 'Vigattin Inc.', 'Bank Transfer from ANTZ', 'Deposit', '120000', '', '183082.96', ''),
(1090, '02/28/2014', '330469', '02/28/2014', 'Erick Jayson Correa', 'Salary (February 15-28, 2014)', 'Withdraw', '', '105246.42', '77836.54', ''),
(1091, '02/28/2014', '', '02/28/2014', 'Vigattin Inc.', 'Service Charge', 'Withdraw', '', '500', '77336.539999996', ''),
(1092, '02/28/2014', '', '02/28/2014', 'Vigattin Inc.', 'Deposit', 'Deposit', '5.97', '', '77342.509999996', ''),
(1093, '02/28/2014', '', '02/28/2014', 'Vigattin Inc.', 'WT', 'Withdraw', '', '1.19', '77341.319999996', ''),
(1094, '03/03/2014', '', '03/03/2014', 'Vigattin Inc.', 'DEPN', 'Deposit', '441', '', '77782.319999996', ''),
(1095, '03/03/2014', '330475', '03/03/2014', 'Bayan Telecommunications Inc.', 'Bayantel Internet and Landline Services(Jan. 21 to Feb. 20, 2014)', 'Withdraw', '', '14998', '62784.319999996', ''),
(1096, '03/03/2014', '330468', '03/03/2014', 'Samuel A. So, Jr.', 'Remittance to La Carmela de Boracay', 'Withdraw', '', '4800', '57984.319999996', ''),
(1097, '03/03/2014', '330470', '03/03/2014', 'Erick Jayson Correa', 'Prepaid Load Expenses', 'Withdraw', '', '3078', '54906.319999996', ''),
(1098, '03/03/2014', '330474', '03/03/2014', 'Erick Jayson Correa', 'Professional Fee of Ms. Arne Barcelo', 'Withdraw', '', '3750', '51156.319999996', ''),
(1099, '03/03/2014', '033046', '03/03/2014', 'Karl Leonid Rico Silvanetto', 'Cash Advance', 'Withdraw', '', '5000', '46156.319999996', ''),
(1100, '03/03/2014', '', '03/03/2014', 'Vigattin Inc.', 'Bank Transfer from ANTZ', 'Deposit', '50000', '', '96156.319999996', ''),
(1101, '03/03/2014', '330382', '03/03/2014', 'CCT & Sons Development Inc.', 'Rental Fee for the month of March 2014', 'Withdraw', '', '33600', '62556.319999996', ''),
(1102, '03/04/2014', '330471', '03/04/2014', 'Neneth H. Leonardo', 'Remittance to Monaka Clothing & Accessories', 'Withdraw', '', '351.12', '62205.199999996', ''),
(1103, '03/04/2014', '330472', '03/04/2014', 'TransRadio Broadcasting Corporation', 'Vigattin Radio (Dec. 5 to Jan. 4, 2014)', 'Withdraw', '', '25000', '37205.199999996', ''),
(1104, '03/05/2014', '330464', '03/05/2014', 'Yenom Marketing Corporation', 'Payment to Yenom Marketing Corporation', 'Withdraw', '', '1739.70', '35465.499999996', ''),
(1105, '03/06/2014', '330461', '03/06/2014', 'Marites R. Guevarra', 'Refund of 2 perfumes (P1800 each - less P 6 for the payment gateway)', 'Withdraw', '', '3594', '31871.499999995', ''),
(1106, '03/06/2014', '', '03/06/2014', 'Vigattin Inc.', 'DEPN', 'Deposit', '4295.94', '', '36167.439999995', ''),
(1107, '03/06/2014', '', '03/06/2014', 'Vigattin Inc.', 'DEPN', 'Deposit', '8074', '', '44241.439999996', ''),
(1108, '03/07/2014', '', '03/07/2014', 'Vigattin Inc.', 'CM', 'Deposit', '1019', '', '45260.439999996', ''),
(1109, '03/07/2014', '', '03/07/2014', 'Vigattin Inc.', 'CM', 'Deposit', '141.55', '', '45401.989999996', ''),
(1110, '03/10/2014', '330473', '03/10/2014', 'Erick Jayson Correa', 'Professional Fee of Mr. Den Macaranas (Feb. 1, 8, 15, and 22, 2014 @ P1,250/wk)', 'Withdraw', '', '5000', '40401.989999996', ''),
(1111, '03/10/2014', '033046', '03/10/2014', 'Karl Leonid Rico Silvanetto', 'Cash Advance', 'Withdraw', '', '5000', '35401.989999996', ''),
(1112, '03/10/2014', '', '03/10/2014', 'Vigattin Inc.', 'DEPN', 'Deposit', '12200', '', '47601.989999996', ''),
(1113, '03/10/2014', '330478', '03/10/2014', 'Leah Camille Sabinosa', 'payments to Nailville', 'Withdraw', '', '544.80', '47057.189999996', ''),
(1114, '03/10/2014', '330480', '03/10/2014', 'John Paul Galeos', 'Commission of Sir JP for month of Feb.', 'Withdraw', '', '5000', '42057.189999996', ''),
(1115, '03/10/2014', '330483', '03/10/2014', 'Erick Jayson Correa', 'Reimbursement of Sir Elison', 'Withdraw', '', '3985', '38072.189999996', ''),
(1116, '03/10/2014', '330482', '03/10/2014', 'Rosevie Decio', 'Prepaid Load Expenses (From Feb. 28 to Mar. 7, 2014)', 'Withdraw', '', '2000', '36072.189999996', ''),
(1117, '03/10/2014', '0330484', '03/10/2014', ' Club Haven Resort Boracay Inc.', 'Remittance to Club Haven Resort Boracay Inc.', 'Withdraw', '', '4400', '31672.189999996', ''),
(1118, '03/11/2014', '330479', '03/11/2014', 'Dorothy Lugana', 'Remittance to Perfect Sweets', 'Withdraw', '', '509.15', '31163.039999996', ''),
(1119, '03/11/2014', '330477', '03/11/2014', 'Innove Communications Inc.', 'Globe Bill (Jan. 4 to Feb. 14, 2014)', 'Withdraw', '', '2295', '28868.039999995', ''),
(1120, '03/12/2014', '', '03/12/2014', 'Vigattin Inc.', 'DEPN', 'Deposit', '10100', '', '38968.039999995', ''),
(1121, '03/14/2014', '', '03/14/2014', 'Vigattin Inc.', 'CM', 'Deposit', '2133', '', '41101.039999995', ''),
(1122, '03/14/2014', '', '03/14/2014', 'Vigattin Inc.', 'DEPN', 'Deposit', '25000', '', '66101.039999995', ''),
(1123, '03/14/2014', '', '03/14/2014', 'Vigattin Inc.', 'CM', 'Deposit', '150000', '', '216101.04', ''),
(1124, '03/14/2014', '0330493', '03/14/2014', 'Erick Jayson Correa', 'Prepaid Load Expenses (March 8 to 14, 2014)', 'Withdraw', '', '2084', '214017.04', ''),
(1125, '03/14/2014', '', '03/14/2014', 'Vigattin Inc.', 'Professional Fee of Mr. Den Macaranas (Mar. 1 and 8 2014)', 'Withdraw', '', '2500', '211517.04', ''),
(1126, '03/14/2014', '0330494', '03/14/2014', 'Erick Jayson Correa', 'Reimbursement of Sir Elison', 'Withdraw', '', '2927', '208590.04', ''),
(1127, '03/14/2014', '0330495', '03/14/2014', 'Erick Jayson Correa', 'Salary (Mar 1 to 14,2014)', 'Withdraw', '', '103559.05', '105030.99', ''),
(1128, '03/14/2014', '0330497', '03/14/2014', 'Maricel Torres', 'Payment to HK Voucher (to be deposited to Maricel Torres account. Total amount to be paid by customer is 70,900)', 'Withdraw', '', '25000', '80030.99', ''),
(1129, '03/14/2014', '330490', '03/14/2014', 'Josephine Arceo                                                                                     ', 'Remittance to Pink2Pink', 'Withdraw', '', '186.75', '79844.239999996', ''),
(1130, '03/15/2014', '', '03/15/2014', 'Vigattin Inc.', 'DEPN', 'Deposit', '375', '', '80219.239999996', ''),
(1131, '03/20/2014', '330491', '03/20/2014', 'Mary Bernadette Tan', 'Remittance to Tuffes Pastry Shop', 'Withdraw', '', '304.30', '79914.939999996', ''),
(1132, '03/20/2014', '330492', '03/20/2014', 'Crisatina B. Monzales', 'remittance to Cristina Jones Hair Salon', 'Withdraw', '', '560', '79354.939999996', ''),
(1133, '03/21/2014', '330498', '03/21/2014', 'Sharon Bantaculo', 'Refund of 12 Vouchers from Royal Lake Spa (Less P60 for the Payment Gateway)', 'Withdraw', '', '6180', '73174.939999996', ''),
(1134, '03/21/2014', '', '03/21/2014', 'Vigattin Inc.', 'CM', 'Deposit', '3032', '', '76206.939999996', ''),
(1135, '03/24/2014', '', '03/24/2014', 'Vigattin Inc.', 'CM', 'Deposit', '20000', '', '96206.939999996', ''),
(1136, '03/24/2014', '346007', '03/24/2014', 'Hridesh Parwani', 'Remittance to AOIP Co.', 'Withdraw', '', '286.18', '95920.759999996', ''),
(1137, '03/24/2014', '346004', '03/24/2014', 'Erick Jayson Correa', 'Reimbursement of Sir Elison', 'Withdraw', '', '4036.06', '91884.699999996', ''),
(1138, '03/24/2014', '346005', '03/24/2014', 'Erick Jayson Correa', 'Prepaid Load Expenses (from Mar. 15-19, 2014)', 'Withdraw', '', '1491', '90393.699999996', ''),
(1139, '03/24/2014', '330500', '03/24/2014', ':Leah Camille Sabinosa', 'Remittance to Nailville', 'Withdraw', '', '255.60', '90138.099999996', ''),
(1140, '03/24/2014', '', '03/24/2014', 'Erick Jayson Correa', 'Amazon Web Services and Facebook Ads', 'Withdraw', '', '40300.93', '49837.169999997', ''),
(1141, '03/24/2014', '346003', '03/24/2014', 'SAJE 168 INC', 'Remittance to Saje Coffee, Tea and Me', 'Withdraw', '', '249.90', '49587.269999997', ''),
(1142, '03/24/2014', '330487', '03/24/2014', 'CCT & Sons Development Inc.', 'Water Bill (Jan. 4 to Feb. 3 2014)', 'Withdraw', '', '687.44', '48899.829999997', ''),
(1143, '03/24/2014', '330489', '03/24/2014', 'CCT & Sons Development Inc.', 'Water Bill (Feb. 3 to Mar. 3, 2014)', 'Withdraw', '', '1800.54', '47099.289999996', ''),
(1144, '03/24/2014', '330486', '03/24/2014', 'CCT & Sons Development Inc.', 'Electric Bill (Jan 1-31, 2014)', 'Withdraw', '', '17035.34', '30063.949999996', ''),
(1145, '03/24/2014', '330488', '03/24/2014', 'CCT & Sons Development Inc.', 'Electric Bill (February 1-28, 2014)', 'Withdraw', '', '17767.33', '12296.619999996', ''),
(1146, '03/26/2014', '', '03/26/2014', 'Vigattin Inc.', 'ZBD', 'Withdraw', '', '1370', '10926.619999996', ''),
(1147, '03/26/2014', '330499', '03/26/2014', 'MaÃ±a Asian Sensational Spa', 'Remittance t MaÃ±a Asia Sensational Spa', 'Withdraw', '', '159.20', '10767.419999996', ''),
(1148, '03/26/2014', '346001', '03/26/2014', 'Naneth H. Leonardo', 'remittance to Monaka Clothing & BIke Watch', 'Withdraw', '', '229.30', '10538.119999996', ''),
(1149, '03/26/2014', '346002', '03/26/2014', 'Vincent Volckmann & Lourdes Ortiz', 'remittance to Ortiz Spa and Aesthenic Care', 'Withdraw', '', '238.40', '10299.719999996', ''),
(1150, '03/27/2014', '', '03/27/2014', 'Vigattin Inc.', 'DEPN', 'Deposit', '6200', '', '16499.719999996', ''),
(1152, '03/28/2014', '', '03/28/2014', 'Vigattin Inc.', 'CM', 'Deposit', '12223', '', '28722.719999996', ''),
(1153, '03/28/2014', '', '03/28/2014', 'Vigattin Inc.', 'DEPN', 'Deposit', '3400', '', '32122.719999996', ''),
(1154, '03/28/2014', '346010', '03/28/2014', 'Gracielli Olivera Bauzon', 'Remittance to Hubgets Merchandising', 'Withdraw', '', '1479.20', '30643.519999996', ''),
(1155, '03/28/2014', '346011', '03/28/2014', 'Josephine Arceo                                                                                     ', 'Remittance to Pink2Pink', 'Withdraw', '', '1307.25', '29336.269999996', ''),
(1156, '03/28/2014', '0346014', '03/28/2014', 'Erick Jayson Correa', 'Reimbursement of Sir Elison (from March 20 to 27,2014)', 'Withdraw', '', '2489.50', '26846.769999996', ''),
(1157, '03/28/2014', '', '03/28/2014', 'Vigattin Inc.', 'DEPN', 'Deposit', '7200', '', '34046.769999996', ''),
(1158, '03/28/2014', '', '03/28/2014', 'Vigattin Inc.', 'ZBD', 'Withdraw', '', '5400', '28646.769999996', ''),
(1159, '03/31/2014', '', '03/31/2014', 'Vigattin Inc.', 'DEPN', 'Deposit', '5900', '', '34546.769999996', ''),
(1160, '03/31/2014', '', '03/31/2014', 'Vigattin Inc.', 'Bank Transfer from ANTZ', 'Deposit', '105000', '', '139546.77', ''),
(1161, '03/31/2014', '0346018', '03/31/2014', 'Erick Jayson Correa', 'Salary (March 15-31,2014)', 'Withdraw', '', '104550.43', '34996.34', ''),
(1162, '03/31/2014', '0346012', '03/31/2014', 'Plumberry Nail and Body Spa', 'Remittance to Plumberry Nail and Body Spa', 'Withdraw', '', '79.20', '34917.139999996', ''),
(1163, '03/31/2014', '', '03/31/2014', 'Vigattin Inc.', 'Deposit', 'Deposit', '7.42', '', '34924.559999996', ''),
(1164, '03/31/2014', '', '03/31/2014', 'Vigattin Inc.', 'WT', 'Withdraw', '', '1.48', '34923.079999996', ''),
(1165, '04/01/2014', '', '04/01/2014', 'Vigattin Inc.', 'CM', 'Deposit', '30000', '', '64923.079999995', ''),
(1166, '04/01/2014', '346020', '04/01/2014', 'Innove Communications Inc.', 'Globe Internel and Landline Services (Feb. 04 2014 to MAr. 03 2014)', 'Withdraw', '', '2295', '62628.079999995', ''),
(1167, '04/01/2014', '', '04/01/2014', 'Vigattin Inc.', 'DEPN', 'Deposit', '950', '', '63578.079999995', ''),
(1168, '04/01/2014', '346019', '04/01/2014', 'Erick Jayson Correa', 'Prepaid Load Expenses (March 22 to 31, 2014)', 'Withdraw', '', '872', '62706.079999995', ''),
(1169, '04/01/2014', '346013', '04/01/2014', 'Maria Veronica de Policarpio', 'remittance to J-Four Skincare & Aesthetic', 'Withdraw', '', '620.10', '62085.979999995', ''),
(1170, '04/01/2014', '346016', '04/01/2014', 'Elaine Barcelo', 'remittance  to Ms. Elaine BArcelo for La Carmela Sold Vouchers (Please see attached file for the computation)', 'Withdraw', '', '25966', '36119.979999996', ''),
(1171, '04/01/2014', '330383', '04/01/2014', 'CCT & Sons Development Inc.', 'Rental Fee (April 2014)', 'Withdraw', '', '33600', '2519.979999996', ''),
(1172, '04/02/2014', '', '04/02/2014', 'Vigattin Inc.', 'DEPN', 'Deposit', '21000', '', '23519.979999996', ''),
(1174, '04/02/2014', '', '04/02/2014', 'Vigattin Inc.', 'DEPN', 'Deposit', '3500', '', '27019.979999996', ''),
(1175, '04/02/2014', '', '04/02/2014', 'Vigattin Inc.', 'DEPN', 'Deposit', '6200', '', '33219.979999996', ''),
(1176, '04/03/2014', '0346021', '04/03/2014', 'Hey! Jude Hotel Boracay', 'Remittance to Hey! Jude Hotel Boracay(Vigattin Tourism)', 'Withdraw', '', '4500', '28719.979999996', ''),
(1177, '04/04/2014', '', '04/04/2014', 'Vigattin Inc.', 'CM', 'Deposit', '14522', '', '43241.979999996', ''),
(1178, '04/04/2014', '346022', '04/04/2014', 'Teresita A. Tan', 'Remittance to Right Harvest International Inc', 'Withdraw', '', '170', '43071.979999996', ''),
(1179, '04/04/2014', '346024', '04/04/2014', 'La Carmela de Boracay Resort Hotel, Inc.', 'Remittance to La Carmela de Boracay', 'Withdraw', '', '5100', '37971.979999996', ''),
(1180, '04/04/2014', '346025', '04/04/2014', 'Erick Jayson Correa', 'Reimbursement of Sir Elison', 'Withdraw', '', '5432.01', '32539.969999996', ''),
(1181, '04/04/2014', '346023', '04/04/2014', 'Ricky B. Bincal', 'Remittance to PerfumesPh', 'Withdraw', '', '1920', '30619.969999996', ''),
(1182, '04/07/2014', '', '04/07/2014', 'Vigattin Inc.', 'DEPN', 'Deposit', '80', '', '30699.969999996', ''),
(1183, '04/07/2014', '', '04/07/2014', 'Vigattin Inc.', 'ZBD', 'Withdraw', '', '80', '30619.969999996', ''),
(1184, '04/07/2014', '', '04/07/2014', 'Vigattin Inc.', 'DEPN', 'Deposit', '80', '', '30699.969999996', ''),
(1185, '04/07/2014', '', '04/07/2014', 'Vigattin Inc.', 'DEPN', 'Deposit', '7000', '', '37699.969999996', ''),
(1187, '04/11/2014', '', '04/11/2014', 'Vigattin Inc.', 'CM', 'Deposit', '4082', '', '41781.969999996', ''),
(1188, '04/11/2014', '0346027', '04/11/2014', 'Elegant Secrets Spa Inc.', 'Remittance to Elegant Secrets Spa', 'Withdraw', '', '597', '41184.969999996', ''),
(1189, '04/11/2014', '', '04/11/2014', 'Vigattin Inc.', 'ZBD', 'Withdraw', '', '2500', '38684.969999996', ''),
(1190, '04/11/2014', '0346028', '04/11/2014', 'Erick Jayson Correa', 'Reimbursement of Sir Elison', 'Withdraw', '', '2422', '36262.969999996', ''),
(1191, '04/15/2014', '0346026', '04/15/2014', 'Yenom Marketing Corporation', 'Purchase Order #003', 'Withdraw', '', '2054.40', '34208.569999996', ''),
(1192, '04/15/2014', '', '04/15/2014', 'Vigattin Inc.', 'DEPN', 'Deposit', '5358', '', '39566.569999996', ''),
(1193, '04/15/2014', '', '04/15/2014', 'Vigattin Inc.', 'Bank Transfer from ANTZ', 'Deposit', '100000', '', '139566.57', ''),
(1194, '04/15/2014', '0346030', '04/15/2014', 'Erick Jayson Correa', 'Salary (April 1-15, 2014)', 'Withdraw', '', '111488.86', '28077.71', ''),
(1195, '04/15/2014', '0346031', '04/15/2014', 'Erick Jayson Correa', 'Prepaid Load Expenses (April 1-14, 2014)', 'Withdraw', '', '1342', '26735.709999995', ''),
(1196, '04/15/2014', '0346032', '04/15/2014', 'Erick Jayson Correa', 'Reimbursement of Sir Elison (Refund of Ms. Judy Lea Emata Royal Lake Vouchers)', 'Withdraw', '', '1605', '25130.709999995', ''),
(1197, '04/15/2014', '0346033', '04/15/2014', 'Erick Jayson Correa', 'Reimbursement of Sir Elison (Refund of Mr. Christopher Guray Royal Lake Voucher)', 'Withdraw', '', '520', '24610.709999995', ''),
(1198, '04/16/2014', '', '04/16/2014', 'Vigattin Inc.', 'CM', 'Deposit', '11152', '', '35762.709999995', ''),
(1199, '04/16/2014', '0346038', '04/16/2014', 'Diamond Oasis Food Exchange Inc.', 'Remittance to Lucky Tea', 'Withdraw', '', '439.20', '35323.509999995', ''),
(1200, '04/16/2014', '0346035', '04/16/2014', 'Josephine Arceo                                                                                     ', 'Remittance to Pink2Pink & Face Skin Care Center ', 'Withdraw', '', '1871.25', '33452.259999995', ''),
(1201, '04/16/2014', '', '04/16/2014', 'Vigattin Inc.', 'DEPN', 'Deposit', '400', '', '33852.259999995', ''),
(1202, '04/16/2014', '0346034', '04/16/2014', 'A & G The Boracay Beach Resort Co', 'Remittance to Vigattin Tourism', 'Withdraw', '', '4903.67', '28948.589999995', ''),
(1203, '04/21/2014', '0346037', '04/21/2014', 'John Aerufe Enterprise', 'remittance to Cheapdito', 'Withdraw', '', '1390', '27558.589999995', ''),
(1204, '04/22/2014', '', '04/22/2014', 'Vigattin Inc.', 'DEPN', 'Deposit', '2800', '', '30358.589999995', ''),
(1205, '04/22/2014', '', '04/22/2014', 'Vigattin Inc.', 'DEPN', 'Deposit', '199', '', '30557.589999995', ''),
(1206, '04/22/2014', '0346041', '04/22/2014', 'Bayan Telecommunications Inc.', 'Bayantel Internet and Landline Services (Feb. 21 to Mar. 20, 2014)', 'Withdraw', '', '7499', '23058.589999995', ''),
(1207, '04/22/2014', '0346039', '04/22/2014', 'Globe Telecom Inc.', 'Globelines Bill (Feb. 27 to Mar. 26, 2014)', 'Withdraw', '', '1797', '21261.589999995', ''),
(1208, '04/22/2014', '0346042', '04/22/2014', 'Erick Jayson Correa', 'Reimbursement of Sir Elison', 'Withdraw', '', '6241.25', '15020.339999995', ''),
(1209, '04/23/2014', '0346043', '04/23/2014', 'Vigattin Inc.', 'Remittance to Vigattin Tourism', 'Withdraw', '', '2500', '12520.339999995', ''),
(1210, '04/23/2014', '0346040', '04/23/2014', 'Jim Gomez', 'Refund of Ms. Abigail Gomez Island Hopping. (checkin- april 11 check out- april 13 (please see attached file))', 'Withdraw', '', '5000', '7520.339999995', ''),
(1213, '04/23/2014', '0346036', '04/23/2014', 'Marlon O. Laroza', 'Remittance to P&D Facial Care & Spa', 'Withdraw', '', '111.75', '7408.5899999952', ''),
(1214, '04/24/2014', '', '04/24/2014', 'Vigattin Inc.', 'Bank Transfer from ANTZ', 'Deposit', '50000', '', '57408.589999995', ''),
(1215, '04/24/2014', '0346044', '04/24/2014', 'Erick Jayson Correa', 'Amazon Web Services and Facebook Ads (Mar. 4, 2014 to Apr. 2014)', 'Withdraw', '', '36539.22', '20869.369999995', ''),
(1216, '04/25/2014', '', '04/25/2014', 'Vigattin Inc.', 'CM', 'Deposit', '7289', '', '28158.369999995', ''),
(1217, '04/25/2014', '0346047', '04/25/2014', 'Josephine Arceo                                                                                     ', 'Remittance to Pink2Pink & Face Skin Care Center ', 'Withdraw', '', '186.75', '27971.619999995', ''),
(1218, '04/24/2014', '0346046', '04/24/2014', 'CCT & Sons Development Inc.', 'Electric Bill (Mar. 1-31, 2014)', 'Withdraw', '', '13266.99', '14704.629999995', ''),
(1219, '04/24/2014', '0346045', '04/24/2014', 'CCT & Sons Development Inc.', 'Water Bill (Mar. 3 to Apr. 3, 2014)', 'Withdraw', '', '1071.50', '13633.129999995', ''),
(1220, '04/25/2014', '034649', '04/25/2014', 'Arlene Francia', 'remittance to Lefrancien Courture', 'Withdraw', '', '660', '12973.129999995', ''),
(1221, '04/25/2014', '0346048', '04/25/2014', 'John Aerufe Enterprise', 'remittance to Cheapdito', 'Withdraw', '', '924', '12049.129999995', ''),
(1222, '04/29/2014', '', '04/29/2014', 'Vigattin Inc.', 'CM', 'Deposit', '1100', '', '13149.129999995', ''),
(1223, '04/30/2014', '', '04/30/2014', 'Vigattin Inc.', 'Bank Transfer from ANTZ', 'Deposit', '130000', '', '143149.12999999', ''),
(1224, '04/30/2014', '0346052', '04/30/2014', 'Erick Jayson Correa', 'April 16-30, 2014', 'Withdraw', '', '95824.19', '47324.94', ''),
(1225, '05/02/2014', '', '05/02/2014', 'Vigattin Inc.', 'CM', 'Deposit', '2848', '', '50172.939999995', ''),
(1226, '05/02/2014', '0346059', '05/02/2014', 'Erick Jayson Correa', 'Prepaid Load Expenses', 'Withdraw', '', '968', '49204.939999995', ''),
(1227, '05/02/2014', '0346060', '05/02/2014', 'Erick Jayson Correa', 'Professional fee of Mr. Den Macaranas (Mar.29 to Apr. 5, 2014)', 'Withdraw', '', '2500', '46704.939999995', ''),
(1228, '05/02/2014', '0346061', '05/02/2014', 'Erick Jayson Correa', 'Professional Fee of Ms. Arne Barcelo (Feb. 15, 22, Mar. 1 & 8, 2014)', 'Withdraw', '', '3000', '43704.939999995', ''),
(1229, '05/02/2014', '', '05/02/2014', 'Vigattin Inc.', 'Remittance from PayPal', 'Deposit', '14087.67', '', '57792.609999995', ''),
(1230, '05/02/2014', '330384', '05/02/2014', 'CCT & Sons Development Inc.', 'Rental Fee (May 2014)', 'Withdraw', '', '33600', '24192.609999995', ''),
(1233, '05/05/2014', '0346057', '05/05/2014', 'Marq Bien Cereno', 'Remittance to Travel Cravers Services', 'Withdraw', '', '2376.60', '21816.009999995', ''),
(1234, '05/05/2014', '0346053', '05/05/2014', 'Jasmin A. Ortega', 'Remittance to Nail Axis Hand and Foot Spa', 'Withdraw', '', '877.60', '20938.409999995', ''),
(1235, '05/02/2014', '0346054', '05/02/2014', 'Katherine R. Dela Cruz', 'Remittace to Doctor Pisces Fish Spa', 'Withdraw', '', '760', '20178.409999995', ''),
(1236, '05/02/2014', '0346058', '05/02/2014', 'Fernando Impelido', 'Refund of 2 Royal Lake Vouchers (0040052200102 & 0040052200103)', 'Withdraw', '', '1000', '19178.409999995', ''),
(1237, '05/02/2014', '0346056', '05/02/2014', 'It Figures Facial & Slimming Salon', 'Remittance to It Figures Skin Care & Body Shaping', 'Withdraw', '', '200', '18978.409999995', ''),
(1238, '05/05/2014', '0346055', '05/05/2014', 'Melissa A. Ilagan', 'Remittance to Asian Clinic', 'Withdraw', '', '1519.20', '17459.209999995', ''),
(1239, '05/05/2014', '', '05/05/2014', 'Efren Taberna', 'Customers Payment for Hotel', 'Deposit', '10000', '', '27459.209999995', ''),
(1240, '05/05/2014', '0346062', '05/05/2014', 'Melani A. Deparis', 'Remittance to Deparis Beach Resort', 'Withdraw', '', '8200', '19259.209999995', ''),
(1241, '05/06/2014', '', '05/06/2014', 'Efren Taberna', 'Customers Payment for Airline Ticketing', 'Deposit', '28650', '', '47909.209999995', ''),
(1242, '05/06/2014', '0346063', '05/06/2014', 'Erick Jayson Correa', 'Airline Ticketing (to the Airline)', 'Withdraw', '', '28650', '19259.209999995', ''),
(1243, '05/07/2014', '0346064', '05/07/2014', 'Innove Communications Inc.', 'Globe Internet And Landline Services (Mar. 04)', 'Withdraw', '', '2295', '16964.209999995', ''),
(1244, '05/07/2014', '', '05/07/2014', 'Maria Imelda C. Magtira', 'MICM Shoes (1)', 'Deposit', '350', '', '17314.209999995', ''),
(1245, '05/07/2014', '', '05/07/2014', 'Maria Imelda C. Magtira', 'MICM Shoes (4)', 'Deposit', '1400', '', '18714.209999995', ''),
(1246, '05/08/2014', '', '05/08/2014', 'Efren Taberna', 'Airline Ticketing (to the Airline)', 'Deposit', '3000', '', '21714.209999995', ''),
(1247, '05/09/2014', '', '05/09/2014', 'Erick Jayson Correa', 'Remittance from DragonPay', 'Deposit', '7677', '', '29391.209999995', ''),
(1248, '05/09/2014', '', '05/09/2014', 'Vigattin Inc.', 'CM', 'Deposit', '135', '', '29526.209999995', ''),
(1249, '05/09/2014', '0346066', '05/09/2014', 'Josephine Arceo                                                                                     ', 'Remittance to Pink2Pink & Face Skin Care Center ', 'Withdraw', '', '373.50', '29152.709999995', ''),
(1250, '05/09/2014', '0346065', '05/09/2014', 'MNO Boutique', 'MNO Boutique', 'Withdraw', '', '1516', '27636.709999995', ''),
(1251, '05/09/2014', '0346070', '05/09/2014', 'Erick Jayson Correa', 'Reimbursement of Sir Elison', 'Withdraw', '', '7356.73', '20279.979999995', ''),
(1252, '05/08/2014', '0346068', '05/08/2014', 'Melissa A. Ilagan', 'Remittance to Asian Clinic', 'Withdraw', '', '1519.20', '18760.779999995', ''),
(1253, '05/08/2014', '0346069', '05/08/2014', 'Aileen A. Abelinde', 'Remittance to Abelinde Dental Clinic', 'Withdraw', '', '8799.20', '9961.579999995', ''),
(1275, '05/08/2014', '0346067', '05/08/2014', 'Phil. Creations Inc', 'Remittance to PCI', 'Withdraw', '', '240.00', '9721.5799999945', ''),
(1276, '05/13/2014', '', '05/13/2014', 'Vigattin Inc.', 'Remittance from Elegant Spa', 'Deposit', '398.00', '', '10119.579999994', ''),
(1278, '05/13/2014', '0346071', '05/13/2014', 'Letty Chua', 'Remittance to Becos Facial and Body Spa', 'Withdraw', '', '1439.20', '8680.379999994', ''),
(1279, '05/15/2014', '', '05/15/2014', 'Vigattin Inc.', 'Bank Transfer from ANTZ', 'Deposit', '145000', '', '153680.37999999', ''),
(1280, '05/15/2014', '0346072', '05/15/2014', 'Maria Imelda C. Magtira', 'Remittance to MICM Shoes', 'Withdraw', '', '2700', '150980.37999999', ''),
(1281, '05/15/2014', '0346076', '05/15/2014', 'Myrna P. FariÃ±as', 'Remittance to Myrna FariÃ±as Salon', 'Withdraw', '', '1599.20', '149381.17999999', ''),
(1282, '05/15/2014', '0346077', '05/15/2014', 'Belinda R. Ferrer', 'Remittance to Mary Pauline Salon (Buendia-Pasay Branch)', 'Withdraw', '', '1077.60', '148303.57999999', ''),
(1283, '05/15/2014', '0346082', '05/15/2014', 'Bayan Telecommunications Inc.', 'Bayantel Internet and landline services (Mar. 21 to Apr. 20, 2014)', 'Withdraw', '', '7499', '140804.57999999', ''),
(1284, '05/15/2014', '0346084', '05/15/2014', 'Erick Jayson Correa', 'Salary (May 1 - 15, 2014)', 'Withdraw', '', '124578.55', '16226.02999999', ''),
(1285, '05/16/2014', '', '05/16/2014', 'Vigattin Inc.', 'Remittance from DragonPay', 'Deposit', '6859', '', '23085.029999995', ''),
(1286, '05/16/2014', '0346073', '05/16/2014', 'Jacqueline Lim', 'Remittance to Pichapies Corner', 'Withdraw', '', '112.50', '22972.529999995', ''),
(1287, '05/16/2014', '0346078', '05/16/2014', 'Dorothy Lugana', 'Remittance to Perfect Sweets', 'Withdraw', '', '509.15', '22463.379999995', ''),
(1288, '05/16/2014', '0346075', '05/16/2014', 'It Figures Facial & Slimming Salon', 'Remittance to It Figures Skin Care & Body Shaping', 'Withdraw', '', '200', '22263.379999994', ''),
(1289, '05/16/2014', '0346074', '05/06/2014', 'Lorena Barroga', 'Remittance to The Spa Republic', 'Withdraw', '', '560', '21703.379999994', ''),
(1290, '05/16/2014', '0346081', '05/16/2014', 'Rosary May Canay-Diaz', 'Remittance to SA3 Trading', 'Withdraw', '', '2767.20', '18936.179999994', ''),
(1291, '05/16/2014', '0346079', '05/16/2014', 'Cristina B. Monzales', 'Remittance to Cristina Jones Hair Salon', 'Withdraw', '', '560', '18376.179999994', ''),
(1292, '05/16/2014', '', '05/16/2014', 'Maria Imelda C. Magtira', 'Payment for MICM Shoes', 'Deposit', '350', '', '18726.179999994', ''),
(1294, '05/16/2014', '', '05/16/2014', 'Maria Imelda C. Magtira', 'Payment for MICM Shoes', 'Deposit', '350', '', '19076.179999994', ''),
(1295, '05/16/2014', '', '05/16/2014', 'Maria Imelda C. Magtira', 'Payment for MICM Shoes', 'Deposit', '350', '', '19426.179999994', ''),
(1296, '05/16/2014', '0346083', '05/16/2014', 'Cash', '10 pcs. of table @ P 1,900 each', 'Withdraw', '', '19000', '426.179999994', ''),
(1298, '05/16/2014', '', '05/16/2014', 'Vigattin Inc.', 'Bank Transfer from ANTZ', 'Deposit', '10000', '', '10426.179999994', ''),
(1299, '05/16/2014', '', '05/16/2014', 'Vigattin Inc.', ' Balance of Mr. Ef Taberna (Airline Ticketing)', 'Deposit', '88.48', '', '10514.659999994', ''),
(1300, '05/16/2014', '0346085', '05/16/2014', 'Erick Jayson Correa', 'Prepaid Load Expenses (May 3 to May 16, 2014)', 'Withdraw', '', '1144', '9370.659999995', ''),
(1301, '05/16/2014', '0346080', '05/16/2014', 'Cristina Palileo', 'remittance to Mikaelas sweet ceration', 'Withdraw', '', '1572.50', '7798.1599999946', ''),
(1302, '05/19/2014', '', '05/19/2014', 'Vigattin Inc.', 'Remittance for MICM shoes', 'Deposit', '350', '', '8148.1599999946', '');
/*!40000 ALTER TABLE `balance` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `log`
--

DROP TABLE IF EXISTS `log`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `log` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(128) NOT NULL,
  `action` text NOT NULL,
  `datetime` datetime NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=195 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `log`
--

LOCK TABLES `log` WRITE;
/*!40000 ALTER TABLE `log` DISABLE KEYS */;
INSERT INTO `log` VALUES (32,'try','logged in','2014-05-27 17:24:57'),(33,'try2','logged in','2014-05-27 17:26:54'),(34,'try','logged in','2014-05-27 17:29:54'),(35,'try','logged in','2014-05-27 17:30:32'),(36,'try','updated user: joshua2','2014-05-27 17:30:48'),(37,'try','logged in','2014-05-27 17:54:31'),(38,'try','logged in','2014-05-27 17:56:20'),(39,'try','logged in','2014-05-27 17:57:04'),(40,'try','logged in','2014-05-28 09:45:07'),(41,'try','logged in','2014-05-28 09:46:07'),(42,'try','logged in','2014-05-28 09:48:39'),(43,'try','logged in','2014-05-28 10:00:23'),(44,'try','logged in','2014-05-28 10:04:16'),(45,'try','logged in','2014-05-28 10:33:04'),(46,'try','logged in','2014-05-28 10:45:27'),(47,'try','logged in','2014-05-28 10:50:52'),(48,'try','logged in','2014-05-28 11:00:32'),(49,'try','logged in','2014-05-28 11:08:56'),(50,'try','logged in','2014-05-28 11:24:25'),(51,'try','logged in','2014-05-28 11:27:23'),(52,'try','logged in','2014-05-28 11:31:48'),(53,'try','logged in','2014-05-28 11:34:17'),(54,'try','logged in','2014-05-28 11:37:16'),(55,'try','logged in','2014-05-28 11:38:46'),(56,'try','logged in','2014-05-28 11:42:32'),(57,'try','logged in','2014-05-28 11:53:04'),(58,'try','logged in','2014-05-28 12:51:46'),(59,'try','logged in','2014-05-28 12:57:23'),(60,'try','logged in','2014-05-28 12:57:37'),(61,'TRY','logged in','2014-05-28 13:00:41'),(62,'TRY','added user: joshua2','2014-05-28 13:01:03'),(63,'try','logged in','2014-05-28 13:04:30'),(64,'try','logged in','2014-05-28 13:05:49'),(65,'try','logged in','2014-05-28 13:08:30'),(66,'try','added user: joshua3','2014-05-28 13:08:54'),(67,'try','updated user: joshua4','2014-05-28 13:09:27'),(68,'try','logged in','2014-05-28 13:13:44'),(69,'try','logged in','2014-05-28 13:18:18'),(70,'try','added user: joshua5','2014-05-28 13:18:32'),(71,'try','updated user: joshua5From username: joshua5 to joshua6 and user type joshua5 toaccounting','2014-05-28 13:18:52'),(72,'try','logged in','2014-05-28 13:20:00'),(73,'try','added user: joshua7','2014-05-28 13:20:22'),(74,'try','updated user: joshua4. From username: joshua4 to joshua4 and user type accounting to accounting','2014-05-28 13:20:34'),(75,'try','logged in','2014-05-28 13:24:48'),(76,'try','logged in','2014-05-28 13:29:11'),(77,'TRY','logged in','2014-05-28 13:37:33'),(78,'try','logged in','2014-05-28 14:02:12'),(79,'try','logged in','2014-05-28 14:02:57'),(80,'try','logged in','2014-05-28 14:04:45'),(81,'try','logged in','2014-05-28 14:07:00'),(82,'try','logged in','2014-05-28 14:15:59'),(83,'try','logged in','2014-05-28 14:19:07'),(84,'try','logged in','2014-05-28 14:20:02'),(85,'try','logged in','2014-05-28 14:21:11'),(86,'try','logged in','2014-05-28 14:22:19'),(87,'try','logged in','2014-05-28 14:22:46'),(88,'try','logged in','2014-05-28 14:24:09'),(89,'try','logged in','2014-05-28 14:29:33'),(90,'try','logged in','2014-05-28 14:31:04'),(91,'try','logged in','2014-05-28 14:34:32'),(92,'try','logged in','2014-05-28 14:36:20'),(93,'try','logged in','2014-05-28 14:38:21'),(94,'try','logged in','2014-05-28 14:46:02'),(95,'try','logged in','2014-05-28 14:50:07'),(96,'try','logged in','2014-05-24 14:50:48'),(97,'try','logged in','2014-05-24 14:55:24'),(98,'try','logged in','2014-05-25 14:56:07'),(99,'try','logged in','2014-05-24 14:58:25'),(100,'TRY','logged in','2014-05-24 15:06:42'),(101,'TRY','logged in','2013-01-01 15:07:54'),(102,'try','logged in','2014-05-24 15:08:23'),(103,'try','logged in','2014-05-24 15:11:40'),(104,'try','user inserted data to checkbook balance: date issued is: 2014-05-24, checkno is: 1234, checkdate is: 2014-05-25, payee is: joshua, particular is: joshua`s particulars, type is: Withdraw, amount is: 73000','2014-05-24 15:12:18'),(105,'try','user inserted data to checkbook balance: date issued is: 2014-05-24, checkno is: 1234, checkdate is: 2014-05-25, payee is: joshua, particular is: joshua`s particulars, type is: Withdraw, amount is: 73000.00','2014-05-24 15:14:02'),(106,'try','user inserted data to checkbook balance: date issued is: 2014-05-24, checkno is: 1234, checkdate is: 2014-05-25, payee is: joshua, particular is: joshua`s particulars, type is: Withdraw, amount is: 73000.00','2014-05-24 15:14:07'),(107,'try','user inserted data to checkbook balance: date issued is: 2014-05-24, checkno is: 1234, checkdate is: 2014-05-25, payee is: joshua, particular is: joshua`s particulars, type is: Withdraw, amount is: 73000.00','2014-05-24 15:14:10'),(108,'try','logged in','2014-05-24 15:20:37'),(109,'try','logged in','2014-05-24 15:21:21'),(110,'try','logged in','2014-05-24 15:28:47'),(111,'try','logged in','2014-05-24 15:29:57'),(112,'try','logged in','2014-05-24 15:30:37'),(113,'try','user inserted data to checkbook balance: date issued is: 2013-02-06, checkno is: , checkdate is: 2014-02-06, payee is: Vigattin Inc., particular is: DEPN, type is: Deposit, amount is: 31421.47','2014-05-24 15:30:57'),(114,'try','logged in','2014-05-24 15:35:22'),(115,'try','logged in','2014-05-24 15:36:00'),(116,'try','logged in','2014-05-24 15:39:57'),(117,'try','user inserted data to checkbook balance: date issued is: 2014-05-24, checkno is: 12345, checkdate is: 2014-05-25, payee is: joshua, particular is: joshua`s particulars, type is: Withdraw, amount is: 73000.00','2014-05-24 15:40:14'),(118,'try','logged in','2014-05-25 15:43:42'),(119,'try','logged in','2014-05-25 15:44:53'),(120,'try','logged in','2014-05-27 15:45:23'),(121,'try','user inserted data to checkbook balance: date issued is: 2014-05-27, checkno is: 7777, checkdate is: 2014-05-28, payee is: joshua, particular is: joshua`s particulars, type is: Withdraw, amount is: 15000','2014-05-27 15:45:59'),(122,'try','logged in','2014-05-28 15:49:43'),(123,'try','logged in','2014-05-28 15:54:33'),(124,'try','user inserted data to checkbook balance: date issued is: 2014-05-28, checkno is: 777724234242, checkdate is: 2014-05-29, payee is: joshua, particular is: joshua`s particulars, type is: Deposit, amount is: 15000.00','2014-05-28 15:57:39'),(125,'try','logged in','2014-05-28 16:03:16'),(126,'try','user inserted data to checkbook balance: date issued is: 2013-12-27, checkno is:  330361, checkdate is: 2013-12-27, payee is: Erick Jayson Correa, particular is: Water Bill (10/3/13 to 11/3/13), type is: Withdraw, amount is: 89922.70','2014-05-28 16:09:24'),(127,'try','logged in','2014-05-28 16:17:24'),(128,'try','logged in','2014-05-28 16:19:03'),(129,'try','added user: jemalyn','2014-05-28 16:35:07'),(130,'try','logged in','2014-05-28 16:37:12'),(131,'try','deleted record from balance. id is: 1311, date issued is: 5/27/2014, checkno is: 7777, checkdate is: 5/28/2014, payee is: joshua 2, particular is: joshua`s particulars, type is: Withdraw, deposit is: 0.00, withdraw is: 15000.00','2014-05-28 16:37:51'),(132,'try2','logged in','2014-05-28 16:38:20'),(133,'corei09','logged in','2014-05-28 16:38:48'),(134,'try','logged in','2014-05-28 17:14:27'),(135,'try','logged in','2014-05-29 09:54:46'),(136,'try','logged in','2014-05-29 09:57:40'),(137,'try','logged in','2014-05-29 10:05:59'),(138,'try','logged in','2014-05-29 10:06:58'),(139,'try','logged in','2014-05-29 10:10:55'),(140,'try','logged in','2014-05-29 10:13:48'),(141,'try','logged in','2014-05-29 10:22:08'),(142,'try','logged in','2014-05-29 10:23:15'),(143,'try','logged in','2014-05-29 10:24:19'),(144,'try','logged in','2014-05-29 10:26:27'),(145,'try','logged in','2014-05-29 10:35:45'),(146,'try','logged in','2014-05-29 10:37:52'),(147,'try','logged in','2014-05-29 10:39:25'),(148,'try','logged in','2014-05-29 10:40:27'),(149,'try','logged in','2014-05-29 10:45:09'),(150,'try','logged in','2014-05-29 10:47:10'),(151,'try','logged in','2014-05-29 10:47:32'),(152,'try','logged in','2014-05-29 11:01:25'),(153,'try','user inserted data to checkbook balance: date issued is: 2014-05-29, checkno is: null1, checkdate is: 2014-05-30, payee is: joshua, particular is: testing, type is: Deposit, amount is: 190000','2014-05-29 11:02:16'),(154,'try','logged in','2014-05-29 11:04:03'),(155,'try','logged in','2014-05-29 11:12:18'),(156,'try','logged in','2014-05-29 11:17:12'),(157,'try','logged in','2014-05-29 11:26:43'),(158,'try','logged in','2014-05-29 11:29:04'),(159,'try','logged in','2014-05-29 11:32:53'),(160,'try','logged in','2014-05-29 13:11:45'),(161,'try','logged in','2014-05-29 13:15:51'),(162,'try','logged in','2014-05-29 13:17:41'),(163,'try','logged in','2014-05-29 13:20:25'),(164,'try','logged in','2014-05-29 13:24:07'),(165,'try','logged in','2014-05-29 13:24:59'),(166,'try','logged in','2014-05-29 13:26:46'),(167,'try','logged in','2014-05-29 13:27:59'),(168,'try','logged in','2014-05-29 13:32:04'),(169,'try','logged in','2014-05-29 13:32:29'),(170,'try','logged in','2014-05-29 13:58:50'),(171,'try','logged in','2014-05-29 14:01:06'),(172,'try','logged in','2014-05-29 14:02:32'),(173,'try','logged in','2014-05-29 14:06:09'),(174,'try','logged in','2014-05-29 14:10:52'),(175,'try','logged in','2014-05-29 14:11:43'),(176,'try','logged in','2014-05-29 14:14:06'),(177,'try','logged in','2014-05-29 14:15:41'),(178,'try','logged in','2014-05-29 14:16:17'),(179,'try','logged in','2014-05-29 14:16:41'),(180,'try','logged in','2014-05-29 14:18:01'),(181,'try','logged in','2014-05-29 14:22:36'),(182,'try','logged in','2014-05-29 14:30:16'),(183,'try','logged in','2014-05-29 14:32:17'),(184,'try','logged in','2014-05-29 14:39:36'),(185,'try','logged in','2014-05-29 14:39:57'),(186,'try','logged in','2014-05-29 14:41:45'),(187,'try','logged in','2014-05-29 14:47:12'),(188,'try','logged in','2014-05-29 14:50:08'),(189,'try','logged in','2014-05-29 14:54:12'),(190,'try2','logged in','2014-05-29 14:54:22'),(191,'try2','logged in','2014-05-29 14:54:46'),(192,'try','logged in','2014-05-29 14:58:47'),(193,'try2','logged in','2014-05-29 14:58:58'),(194,'try2','logged in','2014-05-29 15:19:39');
/*!40000 ALTER TABLE `log` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `particulars`
--

DROP TABLE IF EXISTS `particulars`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `particulars` (
  `id` int(50) NOT NULL AUTO_INCREMENT,
  `particulars` varchar(500) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=188 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `particulars`
--

LOCK TABLES `particulars` WRITE;
/*!40000 ALTER TABLE `particulars` DISABLE KEYS */;
INSERT INTO `particulars` VALUES (177,'Facebook Ads and Amazon Services'),(178,'Prepaid Load Expenses'),(179,'Reimbursement of Sir Elison'),(180,'Remittance'),(181,'Salary'),(182,'GoDaddy.com'),(183,'Globe Internet and Landline Services'),(184,'Bayantel Internet and Landline Services'),(185,'Electric Bill'),(186,'Water Bill'),(187,'Globelines Bill');
/*!40000 ALTER TABLE `particulars` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `payee`
--

DROP TABLE IF EXISTS `payee`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `payee` (
  `id` int(50) NOT NULL AUTO_INCREMENT,
  `name` varchar(500) NOT NULL,
  `company` varchar(500) NOT NULL,
  `contact` varchar(500) NOT NULL,
  `bank` varchar(500) NOT NULL,
  `account` varchar(500) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=60 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `payee`
--

LOCK TABLES `payee` WRITE;
/*!40000 ALTER TABLE `payee` DISABLE KEYS */;
INSERT INTO `payee` VALUES (31,'Erick Jayson Correa','Vigattin Inc','09067922130','',''),(32,'Denise Risha Leigh M. Bantaculo','Vigattin Deals','09283511141','BDO','2410-0932-60'),(33,'John Paul Galeos','Vigattin Inc.','09351372669','Landbank',''),(34,'Ma. Cazandra Andalis','Vigattin Inc.','09265397379','',''),(35,'Rosevie Decio','Vigattin Inc.','09357909672','',''),(36,'CCT & Sons Development Inc.','CCT & Sons Development Inc.','371-9412','',''),(37,'Maricel Torres','Vigattin Inc.','945-2568','',''),(38,'Sharon Bantaculo','Vigattin Inc.','09283511141','',''),(39,'Jaena De Luis-Sibug','Vigattin Inc.',' 09063505052/3618875','',''),(40,'Elaine Barcelo','Vigattin Inc.','945-2568','',''),(41,'Innove Communications, Inc.','Innove Communications, Inc.','730-1288','',''),(42,'Elison Barcelo','Vigattin Inc.','945-2568','',''),(43,'Bayan Telecommunications Inc.','Vigattin','945-2568','',''),(44,'Royal Lake Entertainment Center','Vigattin Inc.','945-2568','',''),(45,'Enrico B. Reyes','Vigattin Inc.','945-2568','',''),(46,'Yenom Marketing Corp.','Yenom Marketing Corp.','724-2026','',''),(47,'Transradio BroadCasting Corp.','Vigattin Inc.','945-2568','',''),(48,'Hridesh Parwani','AOIP','','',''),(49,'Genelus B. Alberto','Best Finds Store','','',''),(50,'Jaena De Luis Sibug','Vigattin Inc.','945-2568','',''),(51,'Karl Leonid Rico Silvanetto','Vigattin Inc.','945-2568','',''),(52,'Jonatz Travel and Tours','Jonatz Travel and Tours','','',''),(53,'Marites R. Guevarra','Vigattin Inc.','945-2568','',''),(54,'Samuel A. So, Jr.','La Carmela de Boracay','','',''),(55,'Christopher Dela Torre','royal lake Entertainment Inc.','','',''),(56,'Norman C. Bernabe','Vigattin Inc.','945-2568','',''),(57,'Judy Lea Emata','Vigattin Inc.','945-2568','BPI','4919-0625-12'),(58,'Jim Gomez','Vigattin Inc.','945-2568','BDO','1290-2090-39'),(59,'Fernando Impelido','Vigattin Inc.','945-2568','','');
/*!40000 ALTER TABLE `payee` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `payments`
--

DROP TABLE IF EXISTS `payments`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `payments` (
  `id` int(50) NOT NULL AUTO_INCREMENT,
  `amount` varchar(500) NOT NULL,
  `total` varchar(500) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `payments`
--

LOCK TABLES `payments` WRITE;
/*!40000 ALTER TABLE `payments` DISABLE KEYS */;
/*!40000 ALTER TABLE `payments` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `spoiled`
--

DROP TABLE IF EXISTS `spoiled`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `spoiled` (
  `id` int(40) NOT NULL AUTO_INCREMENT,
  `date` date NOT NULL,
  `checkno` varchar(500) NOT NULL,
  `checkdate` date NOT NULL,
  `payee` varchar(500) NOT NULL,
  `particulars` varchar(500) NOT NULL,
  `amount` decimal(11,2) NOT NULL,
  `type` varchar(500) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `spoiled`
--

LOCK TABLES `spoiled` WRITE;
/*!40000 ALTER TABLE `spoiled` DISABLE KEYS */;
INSERT INTO `spoiled` VALUES (3,'2014-05-24','','2014-05-25','joshua','joshua`s particulars',150000.00,'Spoiled'),(4,'2014-05-26','234','2014-05-26','joshua','joshua`s particulars 2',15000.00,'Spoiled'),(5,'2014-05-28','777724234242','2014-05-29','joshua','joshua`s particulars',15000.00,'Spoiled'),(6,'2014-05-24','12345','2014-05-29','joshua','joshua`s particulars',73000.00,'Spoiled');
/*!40000 ALTER TABLE `spoiled` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `system_status`
--

DROP TABLE IF EXISTS `system_status`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `system_status` (
  `status` varchar(128) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `system_status`
--

LOCK TABLES `system_status` WRITE;
/*!40000 ALTER TABLE `system_status` DISABLE KEYS */;
INSERT INTO `system_status` VALUES ('SERVER OK');
/*!40000 ALTER TABLE `system_status` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `user` (
  `id` int(1) NOT NULL AUTO_INCREMENT,
  `username` varchar(20) NOT NULL,
  `password` varchar(32) NOT NULL,
  `user_type` varchar(128) NOT NULL,
  `login_status` varchar(128) NOT NULL DEFAULT 'no',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` VALUES (2,'corei09','7823a0dfa862b92782e4d32e428fba57','masteradmin','no'),(3,'try','080f651e3fcca17df3a47c2cecfcb880','accounting','no'),(4,'try2','080f651e3fcca17df3a47c2cecfcb880','masteradmin','yes'),(7,'joshua4','912ec803b2ce49e4a541068d495ab570','accounting','no'),(8,'joshua6','b2c794c90e2d42fd937dad03dca468a9','accounting','no'),(9,'joshua7','f329b2c06cea59ac005fbbbe3a971bbe','accounting','no'),(10,'jemalyn','9ee82d498698869d4c1d0d48c10e2259','accounting','no');
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vouchers`
--

DROP TABLE IF EXISTS `vouchers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `vouchers` (
  `id` int(50) NOT NULL AUTO_INCREMENT,
  `date` date NOT NULL,
  `control` int(250) NOT NULL,
  `payee` varchar(500) NOT NULL,
  `bank` varchar(500) NOT NULL,
  `checkno1` varchar(500) NOT NULL,
  `particulars1` varchar(500) NOT NULL,
  `amount1` varchar(500) NOT NULL,
  `checkno2` varchar(500) NOT NULL,
  `particulars2` varchar(500) NOT NULL,
  `amount2` varchar(500) NOT NULL,
  `checkno3` varchar(500) NOT NULL,
  `particulars3` varchar(500) NOT NULL,
  `amount3` varchar(500) NOT NULL,
  `total` varchar(500) NOT NULL,
  `prepared` varchar(500) NOT NULL,
  `checked` varchar(500) NOT NULL,
  `noted` varchar(500) NOT NULL,
  `approved` varchar(500) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=335 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vouchers`
--

LOCK TABLES `vouchers` WRITE;
/*!40000 ALTER TABLE `vouchers` DISABLE KEYS */;
INSERT INTO `vouchers` VALUES (171,'2013-12-27',0,'Erick Jayson Correa','BDO/East Maya','0330365','Payment for Perfumes (Elizabeth Arden, Bvlgari Extreme and Salvatore Ferragamo Incanto','4300','','','','','','','Four thousand three hundred only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(172,'2013-12-27',0,'Innove Communications, Inc.','BDO/East Maya','0330364','Globe Internet and Landline Services','2295','','','','','','','two thousand two hundred ninety five only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(174,'2013-12-27',0,'Bayan Telecommunications Inc.','BDO/East Maya','0330363','Bayantel Internet and Landline Services','5499','','','','','','','Five thousand four hundred ninety nine only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(175,'2013-12-27',0,'Erick Jayson Correa','BDO/East Maya','0330362','Prepaid Load Expenses','2254','','','','','','','two thousand two hundred fifty four only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(176,'2013-12-18',0,'Erick Jayson Correa','BDO/East Maya','0330351','Amazon Web Services and Facebook Ads','35281.88','','','','','','','thirty five thousand two hundred eighty one and 88/100 only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(177,'2013-12-13',0,'Erick Jayson Correa','BDO/East Maya','0330349','Payment for Vigattin Radio','25000','','','','','','','twenty five thousand only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(178,'2013-12-13',0,'Erick Jayson Correa','BDO/East Maya','0330348','Prepaid Load Expenses','1325','','','','','','','one thousand three hundred twenty five only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(179,'2013-12-13',0,'Erick Jayson Correa','BDO/East Maya','0330347','Salary (Nov. 30 to Dec. 13,2013)','96151.83','','','','','','','ninety six thousand one hundred fifty one and 83/100 only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(180,'2013-12-12',0,'Erick Jayson Correa','BDO/East Maya','0330346','Reimbursment of Sir Elison','14717.25','','','','','','','fourteen thousand seven hundred seventeen and 25/100 only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(181,'2013-12-12',0,'Erick Jayson Correa','BDO/East Maya','0330343','Payment to Norman Megacard (Calling Card of Vigattin - P 250/box * 7)','1750','','','','','','','one thousand seven hundred fifty only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(182,'2013-12-05',0,'Erick Jayson Correa','BDO/East Maya','0330339','Prepaid Load Expenses from 11-21 to 12-05-13','3050','','','','','','','three thousand fifty only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(183,'2013-12-05',0,'Erick Jayson Correa','BDO/East Maya','0330340','Reimbursement of Sir Elison','5544.20','','','','','','','five thousand five hundred forty four and 20/100 only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(184,'2013-11-29',0,'Erick Jayson Correa','BDO/East Maya','0330338','Reimbursement of Sir Elison','9901.50','','','','','','','Nine thousand nie hundred one and 50/100 only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(185,'2013-11-29',0,'Erick Jayson Correa','BDO/East Maya','0330337','Salary ( Nov. 16-30,2013)','94991.29','','','','','','','Ninety four thousand nine hundred ninety one and 29/100 only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(186,'2013-11-28',0,'Royal Lake Entertainment Center','BDO/East Maya','0330336','500 pcs Vouchers at P408 each','204000','','','','','','','two hundred four thousand only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(187,'2013-11-26',0,'CCT & Sons Development Inc.','BDO/East Maya','0330333','Water Bill for 10/3/13 to 11/3/13','898.58','','','','','','','Eight hundred ninety eight and 58/100 only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(188,'2013-11-26',0,'Bayan Telecommunications Inc.','BDO/East Maya','0330331','Bayantel Internet and Landline Services for Sept. 21 to Oct. 20,2013','5499','','','','','','','Five thousand four hundred ninety nine only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(189,'2013-11-26',0,'CCT & Sons Development Inc.','BDO/East Maya','0330333','Electric Bill for October 2013','12248.39','','','','','','','twelve thousand two hundred forty eight and 39/100 only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(190,'2013-11-26',0,'CCT & Sons Development Inc.','BDO/East Maya','0330333','Water Bill for 9/3/13 to 10/3/13','856.03','','','','','','','eight hundred fifty six and 03/100 only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(191,'2013-11-26',0,'CCT & Sons Development Inc.','BDO/East Maya','0330332','Electric Bill for September 2013','14208.60','','','','','','','fourteen thousand two hundred eight and 60/100 only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(192,'2013-11-20',0,'Erick Jayson Correa','BDO/East Maya','0330318','Amazon Web Services and Facebook Ads','30454.31','','','','','','','thirty thousand four hundred fifty four and 31/100 only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(193,'2013-11-26',0,'Innove Communications, Inc.','BDO/East Maya','0330330','Globe Internet and Landline Services for the month of October and Novermber 2013','4590','','','','','','','four thousand five hundred ninety only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(194,'2014-04-08',0,'Yenom Marketing Corporation','BDO East Maya','0346026','Purchase Order #003','2054.40','','','','','','','Two thousand fifty four and 40/100 only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(195,'2013-11-25',0,'Enrico B. Reyes','BDO/East Maya','0330323','Sir Ricos Professional Fee (Expand with holding Tax, Remittances Jan-Dec, 2013, Alphalist 2013) ','2000','','','','','','','two thousand only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(196,'2013-11-22',0,'Erick Jayson Correa','BDO/East Maya','0330322','Amazon Web Services and Facebook Ads','33654.31','','','','','','','thirty three thousand six hundred fifty four and 31/100 only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(197,'2013-11-20',0,'Erick Jayson Correa','BDO/East Maya','0330319','Reimbursement of Sir Elison','30454.31','','','','','','','thirty thousand four hundred fifty four and 31/100 only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(198,'2013-11-20',0,'Transradio BroadCasting Corp.','BDO/East Maya','0330320','Payment for Vigattin Radio at DZIQ','25000','','','','','','','twenty five thousand only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(199,'2013-11-21',0,'Erick Jayson Correa','BDO/East Maya','0330321','Prepaid Load Expenses (Trade and Deals)','2546','','','','','','','two thousand five hundred forty six only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(200,'2013-11-20',0,'Erick Jayson Correa','BDO/East Maya','0330319','Reimbursement of Sir Elison','3966.50','','','','','','','three thousand nine hundred sixty six and 50/100 only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(201,'2013-11-08',0,'Erick Jayson Correa','BDO/East Maya','0330311','Prepaid Load Expenses for Trade and Deals','1816','','','','','','','one thousand eight hundred sixteen only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(202,'2013-11-08',0,'Erick Jayson Correa','BDO/East Maya','0330310','Reimbursement of Sir Elison','7064.44','','','','','','','Seven thousand sixty four and 44/100 only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(203,'2013-10-31',0,'Erick Jayson Correa','BDO/East Maya','0330309','Reimbursement of Sir Elison','5453.11','','','','','','','five thousand four hundred  fifty three and 11/100 only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(204,'2013-10-31',0,'Erick Jayson Correa','BDO/East Maya','0330308','Intellectual Property Office','2121','','','','','','','two thousand one hundred twenty one only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(205,'2013-10-25',0,'Erick Jayson Correa','BDO/East Maya','0330305','Reimbursement of Sir Elison','7649.75','','','','','','','seven thousand six hundred forty nine and 75/100','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(206,'2013-10-25',0,'Erick Jayson Correa','BDO/East Maya','0330306','Prepaid Load Expenses','1930','','','','','','','One thousand nine hundred thirty only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(207,'2013-10-24',0,'Erick Jayson Correa','BDO/East Maya','0330303','Facebook Ads','41719.44','','','','','','','Forty one thousand seven hundred nineteen and 44/100 only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(208,'2013-10-18',0,'Transradio BroadCasting Corp.','BDO/East Maya','0330302','Payment of Vigattin Radio','25000','','','','','','','twenty five thousand only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(209,'2013-10-18',0,'Erick Jayson Correa','BDO/East Maya','0330301','Reimbursement of Sir Elison','7453.20','','','','','','','Seven thousand four hundred fifty three and 20/100 only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(210,'2013-10-16',0,'Bayan Telecommunications Inc.','BDO/East Maya','0288900','Bayantel Internet and Landline Services (Aug. 21- Sep 20,2013)','6498.99','','','','','','','Six thousand four hundred ninety eight and 99/100 only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(211,'2013-10-11',0,'Erick Jayson Correa','BDO/East Maya','0288898','Amazon Web  Services (August 1-30,2013) - $422','19492.80','','','','','','','Nineteen thousand four hundred ninety two and 80/100 only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(212,'2013-10-10',0,'Erick Jayson Correa','BDO/East Maya','0288897','Reimbursement of Sir Elison and Prepaid Load Expense','6302.21','','','','','','','Six thousand three hundred two and 21/100 only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(213,'2013-10-04',0,'Hridesh Parwani','BDO/East Maya','0288894','Remittance to AOIP (Vigattindeals)','531.36','','','','','','','Five hundred thirty one and 36/100','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(214,'2013-10-04',0,'Genelus B. Alberto','BDO/East Maya','0288895','Remittance to Best Finds Store (Vigattindeals)','1299','','','','','','','One thousand two hundred ninety nine only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(215,'2013-10-04',0,'Erick Jayson Correa','BDO/East Maya','0288896','Reimbursement of Sir Elison','5516.90','','','','','','','Five thousand five hundred sixteen and 90/100 only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(216,'2013-10-01',0,'CCT & Sons Development Inc.','BDO/East Maya','0288892','Water Bill August 3 - September 3,2013','889.13','','','','','','','eight hundred eighty nine and 13/100 only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(217,'2013-10-01',0,'CCT & Sons Development Inc.','BDO/East Maya','0288893','Electric Bill (August, 2013)','18260.27','','','','','','','Eighteen thousand two hundred sixty and 27/100','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(218,'2013-09-30',0,'Erick Jayson Correa','BDO/East Maya','0288888','Salary (Sept. 14,-30, 2013)','96854.96','','','','','','','Ninety six thousand eight hundred fifty four and 96/100 only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(219,'2013-09-30',0,'Erick Jayson Correa','BDO/East Maya','0288889','Prepaid Load Expenses (Sept. 16-30, 2013)','1545','','','','','','','One thousand five hundred forty five only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(220,'2013-09-30',0,'Erick Jayson Correa','BDO/East Maya','0288890','Professional Fee of Sir Christian','1850','','','','','','','One thousand eight hundred fifty only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(221,'2013-09-24',0,'Innove Communications, Inc.','BDO/East Maya','0288883','Globe Landline/Broadband Bill','2295','','','','','','','Two thousand two hundred ninety five only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(222,'2013-09-23',0,'Erick Jayson Correa','BDO/East Maya','0288882','Amazon Web Service (July 1-30) and Facebook Ads','15128.64','','','','','','','Fifteen thousand one hundred twenty eight and 64/100 only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(223,'2013-09-13',0,'Erick Jayson Correa','BDO/East Maya','0288877','Salary (August 31 - September 13, 2013)','81215.69','','','','','','','Eighty one thousand two hundred fifteen and 69/100 only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(224,'2013-09-13',0,'Erick Jayson Correa','BDO/East Maya','0288878','Prepaid Load Expenses','420','','','','','','','Four hundred twenty only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(225,'2013-09-13',0,'Erick Jayson Correa','BDO/East Maya','0288878','Daily Expenses','4888.20','','','','','','','Four thousand eight hundred eighty eight and 20/100 only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(226,'2013-09-12',0,'Erick Jayson Correa','BDO/East Maya','0288876','Salary of Maam Mary','4462.90','','','','','','','Four thousand four hundred sixty two and 90/100 only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(227,'2013-09-09',0,'Erick Jayson Correa','BDO/East Maya','0288874','Payment to Load Expenses and Salary of Keemverly Caparas','2974.60','','','','','','','Two thousand nine hundred seventy four and 60/100 only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(228,'2013-08-30',0,'Erick Jayson Correa','BDO/East Maya','0288872','Salary (August 16-30, 2013)','93263.71','','','','','','','Ninety three thousand two hundred sixty three and 71/100 only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(229,'2013-08-28',0,'CCT & Sons Development Inc.','BDO/East Maya','0288869','Electric Bill for June 1-30,2013','16137.07','','','','','','','Sixteen thousand one hundred thirty seven and 07/100 only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(230,'2013-09-28',0,'CCT & Sons Development Inc.','BDO/East Maya','0288870','Water Bill for July 3- August 3, 2013','907.95','','','','','','','Nine Hundred seven and 95/100 only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(231,'2013-08-30',0,'Bayan Telecommunications Inc.','BDO/East Maya','0288871','Bayantel Landline and Internet Connection','11997.96','','','','','','','Eleven thousand nine hundred ninety seven and 96/100 only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(232,'2013-08-27',0,'Erick Jayson Correa','BDO/East Maya','0288867','Amazon Web Services','19371.01','','','','','','','Nineteen thousand three hundred seventy one and 01/100 only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(233,'2013-08-27',0,'Erick Jayson Correa','BDO/East Maya','0288868','GoDaddy.com','6329.35','','','','','','','Six thousand three hundred twenty nine and 35/100 only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(234,'2014-03-31',0,'Erick Jayson Correa','BDO/East Maya','0346018','Salary (March 15-31,2014)','104550.43','','','','','','','One hundred four thousand five hundred fifty and 43/100 only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(235,'2014-03-28',0,'Elaine Barcelo','BDO/East Maya','0346016','Remittance to Ms. Elaine Barcelo for La Carmela Sold Vouchers (Please see attached file for the computation)','25966','','','','','','','Twenty five thousand nine hundred sixty six only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(236,'2014-03-28',0,'Erick Jayson Correa','BDO/East Maya','0346014','Reimbursement of Sir Elison (from March 20 to 27,2014)','2489.50','','','','','','','Two thousand four hundred eighty nine and 50/100 only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(237,'2014-03-24',0,'Erick Jayson Correa','BDO/East Maya','0346008','Amazon Web Services and Facebook Ads','40300.93','','','','','','','Forty thousand three hundred and 93/100 only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(238,'2014-03-22',0,'Jaena De Luis-Sibug','BDO/East Maya','0346006','Refund of the payment for Elizabeth Arden Green Tea Edp Perfume for Women 100 ml','1300','','','','','','','One thousand three hundred only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(239,'2014-03-21',0,'Erick Jayson Correa','BDO East Maya','0346005','Prepaid Load Expenses (from Mar. 15-19,2014)','1491','','','','','','','One thousand four hundred ninety one only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(240,'2014-03-21',0,'Erick Jayson Correa','BDO East Maya','0346004','Reimbursement of Sir Elison','4036.06','','','','','','','Four thousand thirty six and 06/100 only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(241,'2014-03-20',0,'Sharon Bantaculo','BDO East Maya','0330498','Refund of 12 Vouchers from Royal Lake Spa (Less P60 for the Payment Gateway)','6180','','','','','','','Six thousand one hundred eighty only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(242,'2014-03-13',0,'CCT & Sons Development Inc.','BDO East Maya','0330489','Water Bill (February 3 to March 3,2014)','1800.54','','','','','','','One thousand eight hundred and 54/100 only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(243,'2014-03-13',0,'CCT & Sons Development Inc.','BDO East Maya','0330488','Electric Bill (February 1-28,2014)','17767.33','','','','','','','Seventeen thousand seven hundred sixty seven and 33/100 only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(244,'2014-03-13',0,'CCT & Sons Development Inc.','BDO East Maya','0330487','Water Bill (January 4 to February 3,2014)','687.44','','','','','','','Six hundred eighty seven and 44/100 only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(245,'2014-03-13',0,'CCT & Sons Development Inc.','BDO East Maya','0330486','Electric Bill (Jan 1-31, 2014)','17035.34','','','','','','','Seventeen thousand thirty five and 34/100 only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(246,'2014-03-14',0,'Maricel Torres','BDO East Maya','0330497','Payment to HK Voucher (to be deposited to Maricel Torres account. Total amount to be paid by customer is 70,900)','25000','','','','','','','twenty five thousand only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(247,'2014-03-14',0,'Erick Jayson Correa','BDO East Maya','0330495','Salary (Mar 1 to 14,2014)','103559.05','','','','','','','One hundred three thousand five hundred fifty nine and 05/100 only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(248,'2014-03-14',0,'Erick Jayson Correa','BDO East Maya','0330494','Reimbursement of Sir Elison','2927','','','','','','','Two thousand nine hundred twenty seven only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(249,'2014-03-14',0,'Erick Jayson Correa','BDO East Maya','0330493','Prepaid Load Expenses (March 8 to 14, 2014)','2084','','','','','','','Two thousand eighty four only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(250,'2014-03-06',0,'Erick Jayson Correa','BDO East Maya','0330483','Reimbursement of Sir Elison','3985','','','','','','','Three thousand nine hundred eighty five only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(251,'2014-03-07',0,'Rosevie Decio','BDO East Maya','0330482','Prepaid Load Expenses (From Feb. 28 to Mar. 7,2014)','2000','','','','','','','Two thousand only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(252,'2014-03-07',0,'Ma. Cazandra Andalis','BDO East Maya','0330481','Commission for the month of February','5000','','','','','','','Five thousand pesos only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(253,'2014-03-07',0,'John Paul Galeos','BDO East Maya','0330480','Commission for the month of February','5000','','','','','','','Five thousand pesos only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(254,'2014-03-06',0,'Innove Communications, Inc.','BDO/East Maya','0330477','Globe Bill (Jan. 4 to Feb 14,2014)','2295','','','','','','','Two thousand two hundred ninety five only ','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(255,'2014-03-03',0,'Karl Leonid Rico Silvanetto','BDO/East Maya','033046','Cash Advance','5000','','','','','','','Five thousand only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(256,'2014-03-01',0,'Bayan Telecommunications Inc.','BDO East Maya','0330475','Bayantel Landline and Internet Services (Jan. 21 to Feb 20, 2014)','14998','','','','','','','Fourteen thousand nine hundred ninety eight only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(257,'2014-02-28',0,'Erick Jayson Correa','BDO East Maya','0330474','Professional Fee of Ms. Arne Barcelo (11,18,25, and Feb. 1 & 8 @ P750/wk)','3750','','','','','','','Three thousand seven hundred fifty only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(258,'2014-02-28',0,'Erick Jayson Correa','BDO East Maya','0330473','Professional Fee of Mr. Den Macaranas (Feb. 1,8,15 and 22, 2014 @ P1,250/wk)','5000','','','','','','','Five thousand only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(259,'2014-02-28',0,'Transradio BroadCasting Corp.','BDO/East Maya','0330472','Vigattin Radio (Dec. 5, 2013-Jan. 5, 2014)','25000','','','','','','','twenty five thousand only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(260,'2014-02-28',0,'Erick Jayson Correa','BDO/East Maya','0330470','Prepaid Load Expenses','3078','','','','','','','Three thousand seventy eight only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(261,'2014-02-28',0,'Erick Jayson Correa','BDO/East Maya','0330469','Salary (February 15-28, 2014)','105246.42','','','','','','','One hundred five thousand two hundred forty six and 42/100 only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(262,'2014-02-25',0,'Yenom Marketing Corp.','BDO/East Maya','0330464','Payment to Yenom Marketing for the Office Supplies','1739.70','','','','','','','One thousand seven hundred thirty nine and 70/100 only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(263,'2014-02-28',0,'Jonatz Travel and Tours','BDO/East Maya','0330466','Payment to Jonatz Travel and Tours (Rajeta Salazar and Lorencia Oblipias) Hong Kong Tour (4D/3N) ','28044.80','','','','','','','Twenty eight thousand forty four and 80/100 only ','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(264,'2014-02-27',0,'Erick Jayson Correa','BDO/East Maya','0330465','Payment to Ms. Laureen Redulas Ticket to Malaysia ','27000','','','','','','','Twenty seven thousand  only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(265,'2014-02-21',0,'Erick Jayson Correa','BDO/East Maya','0330463','Facebook Ads and Amazon Web Services','35954.89','','','','','','','Thirty five thousand nine hundred fifty four and 89/100 only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(266,'2014-02-21',0,'Rosevie Decio','BDO/East Maya','0330462','Prepaid Load Expenses (from Feb. 14-20,2014)','2932','','','','','','','Two thousand nine hundred thirty two only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(267,'2014-02-21',0,'Marites R. Guevarra','BDO/East Maya','0330461','Refund of 2 Perfumes (P1,800 each-Less P6 for the payment gateway)','3594','','','','','','','Three thousand five hundred ninety four only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(268,'2014-02-14',0,'Erick Jayson Correa','BDO/East Maya','0330452','Reimbursement of Sir Elison','11683.71','','','','','','','Eleven thousand six hundred eighty three and 71/100 only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(269,'2014-02-14',0,'Samuel A. So, Jr.','BDO/East Maya','0330451','Payment to La Carmela de Boracay','147098','','','','','','','One hundred forty seven thousand ninety eight only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(270,'2014-02-14',0,'Erick Jayson Correa','BDO/East Maya','0330450','Prepaid Load Expenses','2030','','','','','','','Two thousand thirty only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(271,'2014-02-14',0,'Erick Jayson Correa','BDO/East Maya','0330449','Salary (Jan. 31- Feb. 14,2014)','102905.96','','','','','','','One hundred two thousand nine hundred five and 96/100 only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(272,'2014-02-12',0,'Christopher Dela Torre','BDO/East Maya','0330446','Refund for 7 Royal Lake Voucher of Mr. Christopher Dela Torre (520/voucher less Payment Gateway)','3620','','','','','','','Three thousand six hundred twenty only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(273,'2014-02-12',0,'CCT & Sons Development Inc.','BDO/East Maya','0330445','Water Bill (December 3,2013 to January 4, 2014)','1313.30','','','','','','','One thousand three hundred thirteen and 30/100 only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(274,'2014-02-12',0,'CCT & Sons Development Inc.','BDO/East Maya','0330444','Electric Bill (december 1-31, 2013)','18110.79','','','','','','','Eighteen thousand one hundred ten and 79/100 only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(275,'2014-02-07',0,'Erick Jayson Correa','BDO/East Maya','0330443','Reimbursement of Sir Elison','9440.50','','','','','','','Nine thousand four hundred forty and 50/100 only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(276,'2014-02-06',0,'Erick Jayson Correa','BDO/East Maya','0330441','Prepaid Load Expenses','2376','','','','','','','Two thousand three hundred seventy six only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(277,'2014-02-03',0,'Erick Jayson Correa','BDO/East Maya','0330434','Mayor`s Permit  ','12972','','','','','','','Twelve thousand nine hundred seventy two only ','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(278,'2014-01-28',0,'Erick Jayson Correa','BDO/East Maya','0330422','remittance to La Carmela Hotel (3D/2N)','5100','','','','','','','five thousand one hundred only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(279,'2014-01-27',0,'Erick Jayson Correa','BDO/East Maya','0330421','Facebook Ads (December 3-23), Amazon Web Services and GoDaddy.com (Domain)','46499.49','','','','','','','Forty six thousand four hundred ninety nine and 49/100 only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(280,'2014-01-27',0,'Erick Jayson Correa','BDO/East Maya','0330420','Prepaid Load Expenses','1656','','','','','','','One thousand six hundred and fifty six only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(281,'2014-01-24',0,'Transradio BroadCasting Corp.','BDO/East Maya','0330419','Payment for Vigattin Radio (Nov. 5- Dec. 4,2013)','25000','','','','','','','twenty five thousand only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(282,'2014-01-22',0,'Erick Jayson Correa','BDO/East Maya','0330415','Reimbursement of Sir Elison (from Jan. 10-22,2014)','8955.31','','','','','','','Eight thousand nine hundred ninety five and 31/100 only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(283,'2014-01-22',0,'Erick Jayson Correa','BDO/East Maya','0330414','Remittance to La Carmela de Boracay (for the purchase of 3D/2N Hotel Accommodation for 4 pax)','10200','','','','','','','Ten thousand two hundred only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(284,'2014-01-21',0,'Erick Jayson Correa','BDO/East Maya','0330412','Prepaid Load Expenses','2310','','','','','','','Two thousand three hundred ten only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(285,'2014-01-30',0,'Erick Jayson Correa','BDO/East Maya','0330433','Prepaid Load Expenses','2130','','','','','','','two thousand one hundred thirty only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(286,'2014-01-30',0,'Erick Jayson Correa','BDO/East Maya','0330432','Salary (January 16-30, 2014)','97227.50','','','','','','','Ninety seven thousand two hundred twenty seven and 50/100 only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(287,'2014-01-29',0,'Innove Communications, Inc.','BDO/East Maya','0330431','Reimbursement of Sir Yarlie','7408.06','','','','','','','Seven thousand four hundred eight and 06/100 only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(288,'2014-01-29',0,'Erick Jayson Correa','BDO/East Maya','0330430','Reimbursement of Sir Elison','4365.50','','','','','','','Four thousand three hundred sixty five and 50/100 only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(289,'2014-01-29',0,'Innove Communications, Inc.','BDO/East Maya','0330429','Globe Internet and Landline Services (Nov. 21-Dec. 20)','2295','','','','','','','Two thousand two hundred ninety five only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(290,'2014-01-29',0,'Bayan Telecommunications Inc.','BDO/East Maya','0330425','Internet and Landline Services (Nov.21-Dec. 20)','8398.96','','','','','','','Eight thousand three hundred ninety eight and 96/100 only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(291,'2014-01-20',0,'Erick Jayson Correa','BDO/East Maya','0330411','Payment to Yenom Marketing Corporation for the office supplies ','2244.90','','','','','','','Two thousand two hundred forty four and 90/100 only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(292,'2014-01-15',0,'Erick Jayson Correa','BDO/East Maya','0330408','Salary (January 1-15,2014)','102083.33','','','','','','','One hundred two thousand eighty three and 33/100 only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(293,'2014-01-10',0,'Erick Jayson Correa','BDO/East Maya','0330406','Prepaid Load Expenses','2416','','','','','','','Two thousand four hundred sixteen only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(294,'2014-01-10',0,'Erick Jayson Correa','BDO/East Maya','0330405','Reimbursement of Sir Elison','13251.25','','','','','','','thirteen thousand two hundred fifty one and 25/100 only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(295,'2014-01-10',0,'CCT & Sons Development Inc.','BDO/East Maya','0330381','Rental Fee (January 1-31, 2014)','37044','','','','','','','Thirty seven thousand forty four only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(296,'2014-01-10',0,'CCT & Sons Development Inc.','BDO/East Maya','0330380','Rental Fee (February 1-28, 2014)','33600','','','','','','','Thirty three thousand six hundred only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(297,'2014-01-09',0,'CCT & Sons Development Inc.','BDO/East Maya','0330378','Water Bill (from November 3- December 3, 2013)','1749.63','','','','','','','One thousand seven hundred forty nine and 63/100 only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(298,'2014-01-09',0,'CCT & Sons Development Inc.','BDO/East Maya','0330377','Electric Bill from November 1-30, 2013','12848.93','','','','','','','Twelve thousand eight hundred forty eight and 93/100 only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(299,'2014-01-09',0,'Norman C. Bernabe','BDO/East Maya','0330374','1 ream of letterhead (P700.00/rm.), 1 box of letter Envelope (P850.00/box), 1 pc. of ID (P 75.00/pc.), and 6 boxes of laminated Calling cards (P350.00/box)','3725','','','','','','','Three thousand seven hundred twenty five only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(300,'2014-01-06',0,'Erick Jayson Correa','BDO/East Maya','0330372','Reimbursement of Sir Elison','10123.65','','','','','','','Ten thousand one hundred twenty three and 65/100 only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(301,'2014-01-06',0,'Erick Jayson Correa','BDO/East Maya','0330371','Prepaid Load Expenses','1600','','','','','','','One thousand six hundred only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(303,'2014-01-03',0,'Erick Jayson Correa','BDO/East Maya','0330370','Payment to DZIQ for Vigattin Radio (Oct. 5 to Nov. 4, 2013)','25000','','','','','','','twenty five thousand only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(304,'2014-01-03',0,'Erick Jayson Correa','BDO/East Maya','0330369','Professional Fee of Mr. Den Macaranas (Dec. 7, 14, 21, 28, 2013 - 1,250/week)','5000','','','','','','','Five thousand only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(305,'2014-04-11',0,'Judy Lea Emata','BDO East Maya','0346028','Refund of 5 Royal Lake Vouchers','2585','','','','','','','Two thousand five hundred eighty five only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(306,'2014-04-11',0,'Erick Jayson Correa','BDO East Maya','0346028','Reimbursement of Sir Elison','2422.00','','','','','','','Two thousand four hundred twenty two only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(307,'2014-04-11',0,'Erick Jayson Correa','BDO East Maya','0346029','Professional Fee of Mr. Den Macaranas (March 15 & 22, 2014)','2500.00','','','','','','','Two thousand five hundred only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(309,'2014-04-15',0,'Erick Jayson Correa','BDO East Maya','0346030','Salary (April 1 - 15, 2014)','111488.86','','','','','','','One hundred eleven thousand four hundred eighty eight and 86/100 ','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(310,'2014-04-15',0,'Erick Jayson Correa','BDO East Maya','0346031','Prepaid Load Expenses (April 1 - 14, 2014)','1342','','','','','','','One thousand three hundred forty two only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(311,'2014-04-15',0,'Erick Jayson Correa','BDO East Maya','0346032','Reimbursement of Sir Elison (Refund of Ms. Judy Lea Emata Royal Lake Vouchers)','1605','','','','','','','One thousand six hundred five only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(312,'2014-04-15',0,'Erick Jayson Correa','BDO East Maya','0346033','Reimbursement of Sir Elison (Refund of Mr. Christopher Guray Royal Lake Voucher)','520','','','','','','','Five hundred twenty only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(313,'2014-04-21',0,'Globe Telecom, Inc.','BDO East Maya','0346039','Globelines Bill (Feb. 27 to Mar. 26, 2014','1797','','','','','','','One thousand seven hundred ninety seven only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(314,'2014-04-21',0,'Jim Gomez','BDO East Maya','0346040','Refund of Ms. Abigail Gomez Island Hopping. Check-in : April 11 Check-out : April 13 (Please see attached file)','5000','','','','','','','Five thousand pesos only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(315,'2014-04-22',0,'Bayan Telecommunications Inc.','BDO East Maya','0346041','Bayantel Internet and Landline Services (Feb. 21 to Mar. 20, 2014)','7499','','','','','','','Seven thousand four hundred ninety nine only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(316,'2014-04-22',0,'Erick Jayson Correa','BDO East Maya','0346042','Reimbursement of Sir Elison','6241.25','','','','','','','Six thousand two hundred forty one and 25/100 only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(317,'2014-04-24',0,'Erick Jayson Correa','BDO East Maya','0346044','Amazon Web Services and Facebook Ads (04 Mar 2014 to 03 Apr 2014)','36539.22','','','','','','','Thirty six thousand five hundred thirty nine and 22/100 only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(318,'2014-04-24',0,'CCT & Sons Development Inc.','BDO East Maya','0346045','Water Bill (Mar. 3 to Apr 3, 2014)','1071.5','','','','','','','One thousand seventy one and 50/100 only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(319,'2014-04-24',0,'CCT & Sons Development Inc.','BDO East Maya','0346046','Electric Bill (Mar. 1 - 31, 2014)','13266.99','','','','','','','Thirteen thousand two hundred sixty six and 99/100 only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(320,'2014-04-30',0,'Erick Jayson Correa','BDO East Maya','0346050','Spoiled Check','99806.93','','','','','','','Ninety nine thousand eight hundred six and 93/100 only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(321,'2014-04-30',0,'Erick Jayson Correa','BDO East Maya','0346051','Spoiled Check','97043.13','','','','','','','Ninety seven thousand forty three and 13/100 only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(322,'2014-04-30',0,'Erick Jayson Correa','BDO East Maya','0346052','Salary (April 16 - 30, 2014)','95824.19','','','','','','','Ninety five thousand eight hundred twenty four and 19/100 only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(323,'2014-05-02',0,'Fernando Impelido','BDO East Maya','0346058','Refund of 2 Royal Lake Vouchers (0040052200102 & 0040052200103)','1000','','','','','','','One thousand pesos only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(324,'2014-03-14',0,'Erick Jayson Correa','BDO East Maya','0330496','Professional Fee of Mr. Den Macaranas (March 1 & 8, 2014)','2500','','','','','','','Two thousand five hundred only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(325,'2014-05-02',0,'Erick Jayson Correa','BDO East Maya','0346059','Prepaid Load Expenses','968','','','','','','','Nine hundred sixty eight only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(326,'2014-05-02',0,'Erick Jayson Correa','BDO East Maya','0346060','Professional Fee or Mr. Den Macaranas (Mar. 29 to Apr. 5, 2014)','2500','','','','','','','Two thousand five hundred only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(327,'2014-05-02',0,'Erick Jayson Correa','BDO East Maya','0346061','Professional Fee of Ms. Arne Barcelo (Feb. 15, 22, Mar. 1 & 8, 2014)','3000','','','','','','','Three thousand pesos only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(328,'2014-05-06',0,'Erick Jayson Correa','BDO East Maya','0346063','Airline Ticketing (Efren Taberna)','28650','','','','','','','Twenty eight thousand six hundred fifty only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(329,'2014-05-07',0,'Innove Communications, Inc.','BDO East Maya','0346064','Globe Internet And Landline Services (Mar. 04)','2295','','','','','','','Two thousand two hundred ninety five only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(330,'2014-05-08',0,'Erick Jayson Correa','BDO East Maya','0346070','Reimbursement of Sir Elison','7356.73','','','','','','','Seven thousand three hundred fifty six and 73/100 only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(331,'2014-05-15',0,'Bayan Telecommunications Inc.','BDO East Maya','0346082','Bayantel Internet and Landline Services (Mar. 21 to Apr. 20, 2014)','7499','','','','','','','Seven thousand four hundred ninety nine only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(332,'2014-05-15',0,'Cash','BDO East Maya','0346083','19 pcs. of table @ P1,900 each','19000','','','','','','','Nineteen thousand only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(333,'2014-05-15',0,'Erick Jayson Correa','BDO East Maya','0346084','Salary (May 1 - 15, 2014)','124578.55','','','','','','','One hundred twenty four thousand five hundred seventy eight and 55/100 only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido'),(334,'2014-05-16',0,'Erick Jayson Correa','BDO East Maya','0346085','Prepaid Load Expenses (May 3 to May 16, 2014)','1144','','','','','','','One thousand four hundred forty four only','Erick Jayson Correa','Elison Barcelo','Yarlie Lim','Fernando Impelido');
/*!40000 ALTER TABLE `vouchers` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2014-05-29 15:19:42
