CREATE DATABASE  IF NOT EXISTS `garagedb` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `garagedb`;
-- MySQL dump 10.13  Distrib 8.0.13, for Win64 (x86_64)
--
-- Host: localhost    Database: garagedb
-- ------------------------------------------------------
-- Server version	5.5.5-10.2.15-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `__migrationhistory`
--

DROP TABLE IF EXISTS `__migrationhistory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `__migrationhistory` (
  `MigrationId` varchar(150) NOT NULL,
  `ContextKey` varchar(300) NOT NULL,
  `Model` longblob NOT NULL,
  `ProductVersion` varchar(32) NOT NULL,
  PRIMARY KEY (`MigrationId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `__migrationhistory`
--

LOCK TABLES `__migrationhistory` WRITE;
/*!40000 ALTER TABLE `__migrationhistory` DISABLE KEYS */;
INSERT INTO `__migrationhistory` VALUES ('201810040845214_init','DAL.Migrations.Configuration',_binary '�\0\0\0\0\0\0\�\�n\�6�}��A\�\�ZI�K\�-2;�5\�i��������T`cؗ\�a��_ء�)\�R�vC1,\�\�\�\�\�\�?���݆\�y�DЈ\�ܣɡ\�\0����\�\�M\��\�k�훯���\�\��P½Rp�\�\�̽�2>�<\�\�CH\�$�~�h-\'~z$�����?zGG 	i9\��&咆�=\�\�<\�>\�2%\�\"\n��\�\�,3�\�%	A\�ć��8y\�:\'�d��v\�y$�D��\�X\�$\�e��\�\�b@�5a\n��k��T�{5bI\�O���^\��L�G�ԭ��\�:E�ʝ\�:3\�̝	�(ٹ�\�\�x\��Ytfv��\�T�ưP\�<e2M`\�!�	a\�u�b\��v�\�G\�3�2��\"\�\�]\'Q�\�\����<p��癈���+p\�嫗�s�\�ɊA\�oM٥��8$�apM���+\Z�Y\�\�n�R|Jn`x9\\\�l\�\�\�{�\���n!(\n\�s�W	qd�B��\�K�@7��{|R_\n׹��{\Z\��?)^\����`gI\�D�F\�\�\�ݒdՉ:A�Q����S���ޘ+\�\r����k�R�{\"\��o�%\�8�~\�u>\r	s�\��\�\�,}���\�O-\�\�g��WB��\�e\��\\��\��\'BD>ͤj\�\n]����<p�����\"�^\Z\�@9f\�7�\r{	Wɠ&\\׌^\�SOS\�NX\�%�����\�J���-3`\�.��(b\�\�A\�\\�lq\�K\�M*u^�hT\�5Hh:[t\ZѦvǤ��\�@����7�T\�u��.���J��\�\�s��֭l�ozA\���\��\'\�2o�\�/�\��0�\����?���8a�&0\�\"k��&B.�$+��\�<-0=�;�\�dE�\�2K�;GSU��m��\��b�ɴ\�\�-�Y�MIZ\n\�<biȻ�fv\�4\����Ma\���V�,�j\Zz��\�3\�	er\�N\�Oゼ�\���\���@\'Q\r�Q~�Fq��C��\�Z㡑\�[߀\�pq\�mS����o\���yII�-X��*%[Q<)[i��E\�v�U�L�*���dԞiQ�/!���^9z�A^����z?\�~\�\�h�!.�k2c\�\�&?k��Ί�\"`��}�ʨ{�����>\�����$�&�^���\�/\�p�\�\�j85�>e*\r>\�T�\�\�Y����ћ\�m�̺?.t^�-�A\�����gh\�\���w5\�s�`f;v�?F��!�8	4\�\"<eto�\��\�5d^?�\Z�+�\0�?\��s\"|\�T\�r��(lK2p\�W\�zXC�2aX]�L��Z�^S\�Ә0\�v�0$�)�*�\�\��U�\�Pv\���\�`X|�%:�\"�����\�|\�\�\�./~�q5\�\��B`\�ip�=�\�\�m�\�b\�Bm׻N˻\\,«�g֞�QǺ�o\�\�ơk\�\�E�G��_�b��\�\�n\�.�c\�k+*-���?\�,�\�\��\�\�3�\�\�Afh�.[�`\�n\��b\�Ԟ/�\�k�\�1���I�\��ƍ�`\��:*��!Q	b�X I�\�\�$�tM|��}\"���AN\�\��*�q*QeW�a����g�ަ\�ӫ8�:�*��U�+�SJYP\�}\�\�\�u�P���x�/��|6��\�e\�*\�W%�[c�\�\�_�x�l\���\r�w喠�\�~G4\�>]P�IH(\n\Z5>>b\��\�?!�\�\"\0\0','6.2.0-61023'),('201810041008036_usingFluentApi','DAL.Migrations.Configuration',_binary '�\0\0\0\0\0\0\�\�n\�6�}��A\�\�XI�a]`�\�\�d�\�\�[@K\�Q�\�H*�1\�\���O\�/\�Pw��,�i7C��&y\��\���k�n2\�	����Ǔ#\�\�G囙���\��\�\�o���\�\��P�{�\�!$�3�Q��\���!����\"�\�ZM�(�Hy���~�=@.\�r�\�]\�\r!��_\��!V	aWQ\0L\�\�x�L�:\�$f\�\��\�uN%Hz	l\�:��H������T\"\�e��\�\�b�wk\�$\��Tχ�~�J�\�U�*?�*\nG\"<~�+\�3���R�T�\�ժvZ\�Te3wNl\"�s�\�ɜ	�p\�n� x q�\0\Z���pNv{���\�\�A\�\�/�\���\'L%f%;pn���/���>��:�\�+\�5�\�VD1���u\��E\�:^\�3K�\ZL&\�W�_�\�5\'+�#Դ�T�����@��[��q�\�\�,\�-M�����Q\�:Wd{	|�1N��9\�BP\��\�ca�H��A�\�5y���_�<~\r_I׹�>��4\�c�_>\�D\�!3\"\n\�\"V�\�n\�؀Bq�\�\'\�(��\�ԫܮ\�s|c}1�\��]Q����h9 �K��iH�\�\�\n��W�7���F\�&~?vԈ�q��\�J=^\"Z�P艖\"��D˩��OS��\�R\�)\���\�eQ\�C�\�\�\�\��\�\�a/\�2KT��*Ӌy\�Մ�3v�Pt�\\��\�b�\�`ۖ2�\�\�YC\�kʠq.A�����%���&�*\�Z8J\�\Z(j2[x\Z\�V{\�\�f�\Z\��u�Q�\n�\�P\�y7cS\��/�]�z^\�\�M�\�\�N��\0`v�u����\�Z\��\�r|+f8<_�tT%�%%\�\�X��[$���S!Ղ(�\":?̓\�zVw\��+(Y\�k��p\�D\���Y�|\�\0��v���XdR���phښFDK��G,	yW\�\�κ�:|vbc�z\�V<K-����d�2z\�\Z�H\�m\�	�yL�uu�\�d8��%��ȏ�\�\�G~�\�]��\�Z���\�[\r\�x\�a\�hӉ��\�o\���z9I��\�Y��J�\�[^<�\�[���̙E\�6�U�\�\'�k�5ɨ=Ӽ\�_[X�!{�{\�\�YQX�\�&�~�~�3�\�\\��\"��A�l�q���`,B�;K	Oʀ\r\�L|�Q�j�\��F�*�E\0\"\�$�zq���\�\�\�\�\�)n\�T\Z|֩4\�ɋ\��S�7�\�\�{2\�~��Ӫ\�\�\Z\�.x\0ۙ�{\nv\�\\��PA873ۉs\��1\�\r\�\�qP�§�\��\���\�\�\�V�p\��@�s\�gN�O[��X\�\�\Z�mN\��z�k:#�\�U*��\�j\�0L�Oc\�\�}L�\�+1�7��\�\�!\���=RI�\��>Mt.EyU[gU�i�1���\��\�(+�����}q\�j_�٫�A�]\�:-\�r��\"4|�Y{�F붾m[��%W�Q�=�z�,7vCv�#_[Qi\�\'\���jiV���F��\�6RC�tٚ\�v[_^#v��|�q_��󏤛\n��)��߈��\�_GE�18*�-\�(`:8�����\�)\�ߖ>�\���p��IT�(\�k(C\'�>�颷\���&N�y	�M�\"�\r�)�,(�>o\�\�:P\�̘O<ږJO>�]�\�:\�\�\�+�=�1Cd�/\�<���.aC�]�%\�F�\�M�O�l	e���ǯ\�\�A�}�ٱS\�C\"\0\0','6.2.0-61023'),('201810091334401_addsUser','DAL.Migrations.Configuration',_binary '�\0\0\0\0\0\0\�\Z\�n\�6�}��A\�\�XI�a]`�Ȝd\�\\�\�\�F:v�R�FR��a_��}\�~a����d)MҮ(\n6\�s�\�߿���YGԹ.\�\��ɞ\�\0�\� d���\�\�\�+�\�\�ￛ\�\�y_�{�\�!$3�N\�\����(�y,⥜�q\� �^\�\��\�\�\�{�(\\\�\�8ӫ�\�0�\�~�\�̇D���\�PQ�\�\�\"\�꜓DB|��G�o]理I/�.]�0K\"���w�\�l�H��\�\�M�nI���\���P\��^(޽\Z�D\�B\�\�H��/ex:��T\�V\�Bu�Z\�FI��l\�Ή�U\�7��;�S�\�\�\�d7$In@�� &%܎�\�\�\�\�ny�S9����\�\�S*S3�\�\�8�\�-\r�\�`s\06c)�MN�W�k\�\�%�\�rs˂�\��u�6��V`\r�\\�S&_�p�s$Nn)T�\�\�\�B\�~%.����	�1�k���\ZzF�뜑�[`+y�q�\�O\�5\�A��;b�!�\�)XԈ���p��ǯA\�K\�:W@�\�.L����7�-\�p\�����֠�ۛk\�W Q���\�\"N��18�j�\�u\�\�X_,���b�+���\�\r��\��aD�\�\\r�TT�W����Bh�;j\���M�Cc��-e(�DKP��e|l�(�oq\�\�TJG�\'V�c<1\�.;\"�\�L�\�|\�t��\0\�,p��.L#�P$��0AoB>f\��fzWe�F\\�1���^CH3��͔$D�)\�?\�ݪ3X\�j�Ik�л.�¹\0i\�/�M��\�\��Qiw\n\�\�6�<�h�\r�L�ra\�aw\�Գ\� ��oJ\�BU�LU�w=���\�N\�)�$\�\�H9�x3\��\�.�uc�)N�E>�\�w\��(\�\��\�\�\�W\�V�0Cb\�n�4rzr!��$�De�yϚq\�\�j%%\��M��^X��\�9�ru`h��\�NP�S{&���f�#��[\�\�<�iĺJUt\�\�7\��\�\�\�x׵\�j\�<TW� 3T\�3\�efo�Nȧ1A^����\�pE\�\�DQ\r\�Q��M\�\�\�\ny\r\�Y�\�v���{k\�OGxBՎ���:}~[�˒5�[%\�\Zĭ\�ڕ9U��o,u\�T\� s�mfW\n�xoE#�@\�J��dNo(L\�\Z}���r���\���iQӷ/H�\"�?QSy|y�_�A\'\�~�}�\���~qFX�!�A\��q�r�r֟��}�a6TJ\�:��#�+GvO�G�1D>hB\�\\\�}�k�Sܖ�W���L\'�cW�`�o��osͰڲ\�y\"\�SRUoa5��Ժ\�Fm\�j\�ء��\0\�3�\�\��9����\�q.8֚g\��k�yZ܏\�:��O٪Y;&s�1d��o�l\�(Hp��ω�I`jP�/[8��T&\'Wp\�\�]XW\�L(�;Br\�x�V\'�ÄPMf\�6$\r)�*��\�$�T~\�v\������i|�&:����\�\�\�6lj5f��Z�\Ze\�\�\�X[F�G�,�&\�\\\�uoz7\��܁m\�m��\�3k\�V�c޷�Q\�Z![\�\�[r\�b�>�\�\r/z\�\�\�\��\�}�f��\�\�m�ʲ��\�\�b\�J\�׏PC�� 5\�\�\�\�j[H?�\"F�pa.0�4�ӚW5\n�\�Y�V\"�ޜ�e\\&5���ֹ��$f�C.\�%�%^� D�K\�{BS|r\�Bp\�.R��E�薶���b�\�י6\�Ӌ$���1D@6C.\�/iH��\�K\�؁B%\�b\nR��j\ZZm*L\�1��P_U\'�!J(\"lA\�\�!�a�{+\�o\�uP7�\�h�}z�\'�(p\���}8�֯��􊯖(\0\0','6.2.0-61023'),('201810290916403_addsSpecifications','DAL.Migrations.Configuration',_binary '�\0\0\0\0\0\0\�\\[o\�6~�� \�qH��݆.�[dv2\�\rqZ\�-`$\�*Q�De1���=\�\'\�/�ԕ\�]�%\�E\"�����߿�~|�#\��Y���{0\�w��$\�|\�\�x�\���÷\����\��\\�{G\�J��\�{������0\� �4ɒ�I\� �\�\�\��\�x��p	/\�^\��1,~!��\�\�\�At�0ʪ\�\�ʹ\�\�\\�f\�Ñ;9:s��(d\�)�f�J0�D�\�O�\�4A�\�<\0\�\�rɺ�2X	|\�.��}�-�\�k	kV~�\�$\�\��\�]��\'_I�n�,��c�V���.T6r\�\0\�y�.]�\�\�p�t\�ȝ�\�\�-X,n!�a6�\����\���M�v�q\�/�Ϟ3\�#��p�`�S\�9W�]��\�\�M��ʣ���\�J\�u�GWi��)^^\�Y%�i\�:^�\�\�	2��<\�)\�\�޺\�\�\�E�qFS����`JN\\�a�(�\�Kawn/�O��<5�s\� �\�{\'d�����J�O($1Fhp�C��ܦ\�!��rۓ_�\�Ǚ\�\\èX�݇�20\�\�\�ʖ\�pD�4����%e\�\�ހt19N�\\2M�\�\�z�\�i��\�\�\�+�WWԻ\"�{��(8`\�7�N�\� r����TU���3�e(;��;ш�ŤA\�Xa\�`\�R��&Zꀲq� z��~)�T\�Β\�6�[Q\�+�\�V,[+�;<��y��5\����D�.\��\�*\�\r\�\�Z�ne>\�F\n\�\�>·�!V\n˲⛤��n�pV\�/Y��V�\�\�<\�\Z�K��\�\�Z}�e��~}ͺ\�\rL���\�\�d\nL�z0�yuZ�\�R=M�	�\�$\r���\����,�\�B�\��\�6�\���1w�\�a�\���V� \�D\��\�	�\�2n�F˸�\0�\�<��C\�Ϯ�\�*1M���\�\�5a\�x��yUeȲ��\�ڔ�PPYA�\�8p�$s�&0�:G~��j2b\�\�V�U�\�\�$I�4�hL8��\Z\",f\��\�D=u\��̽T)͎��	\\@D\�fOو\"m�E\�\Z8C�T��\�2�\ZL(`ZIs��\�\�g�Q�ᆔ���fU�坈�B,\�\�d+\�*!Ի\\ڑ@\�\�D��\�\��8\�îP��e���\�\�8�G̘UPU\��P���7��\�\�\�\�Hp]�\Zưbe\�\�V�\�\nQ\r��Rl\n]�Rǜ��>��\�\�B\�\�*I\��\�e,��C�\n���U���Y[I�ֺ�lri{�\�7Z�͗���\Z�����\�UX�ę��`\�7\���Eq\�\��3ɵQ#m�\�8Ľ%[IO\�4\����m�8��el\�P��z\'�8���3`MB.\�&Ggm\�lEpB�ӂ]Abv���� �d\�\Z\'Q#u.?K/+�wp�=����\�*\�\��L�7B]{�\�@I��C,K_>�\�P\�{�,�G�<�\�\r�G�\�ٸ�1�\��\�C�w�v����\�2��0���\�ڦ\�f/k\�Z�/ܚ\�����\�r.\�k�bj\�o9\�v4\�~bdy�O{d\�\�a\'I7Owo\�n�(���1MZ\\;+eT\�\�\�vX~\'�\�D�X��f(�f���lʯ(V�\�z\�)\�\��6�j\�\�dLf�6+*\Z\'�6�\�\�\Z\�2݀\��\�\�N}\�lva\�\�4����nX�Xfأ0s�K(\�&y�rޚ�\r\��A�\�8\nIkW�\�`�\�K*�������\Z�,\"Ɉ*C6\���-�J5^���\�b/�\�H�{�\n\\+\�^)ax_�\�\�\�\�\'�odQm�VQm�N6cWʹ�b�\��9I\�K�-\�5aM\��K�S�Ǒ�gA\��v+a�\�\\�$\�:�\�_[��8\0�X�\Z�]ר\�P^^�\�x�\�Ʋ��\�M�Y�~k:q��\�7�ݫ_�h){\�Q����$`H���\�\�*,��>>`���\�\Z\�]�\�\��\�9I�E�:\�r�%�\n�\\$�X\"��A)\�K���N�{��\�\�cJ��J6\�36�\ZSeů֯zY�	\��qm�\�\��\n`a\�\�N�N\���\�9��O���thHoO_4��\�\�|�\�nO^C7�:~~�\�G\�\��^ *X���ƕ\�~�Z\�oy�1r���xA9�h��\nT�,\�A	�\�b|͈a\�^D�Ul*6\�,�KJ�\�J\�l�\n�lg&�G+4f\�\��*�W�\�sd+E1,a\�\r\�\������u��\"���^�>\�X=کA~/,�e�\�\�t\��n�i��\�\�2G�/ؖ�\�\�M��\�y�y���o�2{\��^D_�F����Hۖ������;-R�\�͒�m\�$��p_~\�!韎R΀�\�kfY�O[��ϑ{\��\�]\�x�crd\�E�|C;>\��ſ0\�\�<�\\\�\���!9�D?\�a4r�H><+X\�V��%��\���l�l8]$ȒQ������\"\"̲K4p\�HGs\��_\�\Z5�!�jNB0OA�U<Zz�+�\� ~��C���M\0\0','6.2.0-61023'),('201810301053516_addsUniqueConstraintOnProductName','DAL.Migrations.Configuration',_binary '�\0\0\0\0\0\0\�\\[O\�F~�\��`���5$M��\�Dt�\n��X�\r\r�\�b\�o\�1eU����?��3�{\�7 E�\"�\�9s\�\��%���\��\�c90\�\��\����\�@\�\'A�f#7\�\�\��\�\�\�7<\�G\�s�\�-]G(Q6r\�1�x^\�\�\�d�8�\�$K�x\�\'��\�{������\�A\�\�%�gx�#ư���:N�\�8\�y�(���7���sb�́G\�\�\�\�F! [O`4u�P�&�|\�\��	�M\�\��nsH\�MA��J\��v��\�{o�\�^KX���\'�%\����2<�|)��������Z񂞺P\�\�gI�pv��q�҅#wR0��`>���>�٠�\�qʷ�\�\�n�v�q\�/�ώ3\�#��p�`�S\�8W�]���\�M��ʣ�+)���\�= ��\�dS���\�J�\��u�>�\�6d��d��}\�:dsp�\�:Z�\�$��BSr\�\�\n`SDy�]p�3{\�}\�݈瑨q�s�x\�ߓ8!����0�T|B!�1B�\�\nd6�\0ᬐ�ٞ�\Z\�>\�\\\�\ZFł\�>���1�^\�V�$�#¤I|�D-i\�\�\�\rHg�\�$\�%�$O}F��׺�\�+~��X����\�\�ߛwE\�C�\���a\"׹J\�OUEy\�:P��㫹��_t\Z4��n�#Z\�PPDKP�\"N\�Do\�\�/e�\�[r\�\�+�xܒe+x��m���_�]�A�������]~]�Э�\'\\K\�Z\�\�ِԄ\�RaYV|�\�t\�-\��k\�\�*\"X_ܖ\\!v\�\��]�o4ߥ\�϶Ь\�\�\��T��R\�L��\�փ)ͫӪ��\�\�i�L�e$i�\�ev�e�*엯n�\�?�1\n}\�X�\�}�#\�\n\�ě�#�N3J\�M\�h�\0���^\�\�K��LL]�nEe�GsM\�:^[5/�Q�4�Y�2%\n*+H��.�d.\�� �Ρ_~�\Z�\�q\����eh\�Ҙ$	f!�	G�VC���\"?��\�R�\�\�K�\�\�Ⱦ9�s�hڴT��(¶����1�N�R\�.������4狣;�>�>ܐ�P�լJ��Q��Cx�l�\\Ņz�K;p<�װ`��\��6\�\nu\�X��aK+��S\�\�0\��r�\�}\�\�,��`�ͨ�5�wmĹ�Q\r\�\�\�Φ���\r\".y��:�R\�9\�}\ni���\�WU���רK[\n�+�2Vg�FU\r3��B�u#\�\�\��B\�+o�\�/Or�5<\'3\�q;Wa\�gRރ�w\'��Eq\�\��3��Q#m�\�8ļ%[IO\�4\�G\0�;@\�\�qs˺�C�\�ꝸ\���΀5	��$;:<kK_`+�r��\�bⳋ���H3\�8��\�{9u�����RPz#;\�pjᚺ���̠\�tj#Ե\�\�R\�͘�b��\�sսG�E�ȜGu�\�\�Q=z6��\�\�j�\��P�n��ߌsT�ֻ�G���=C���\�\�\�em]\��E�[\��b�\�]\��6)�{3�\�6���c�G�\�\"C7\�{I�y�}[�\�Ea\�\�i\�\�\�[!)�����\�\�{8�,ǫ\�\�\�5C�7��\0K\�&��b$[�K\�\�F\�ڸ��S�1;��YQ\�8	��N�\�h�\�\Zl��v�\�z�sc��\�(͸ǌu\�j\�\�\����\\B�6\�C��\�\�k4�\�ŏ\�($I�]qP8�./�\�w�w����\Z�,\"��*B6n��-�J\�^�Y^qu/�\�H�{�r\\K\�^Iax߆\���\�է(��#�O\�4��¯9<pn\�:\�)Yp7\�E�E��[�(&�\�	=L�0�(��e�\"�8�\�\�(��s����Ŏs���|\�\�Q�ۀE�a\�\�ZU��F]E����b�\�B5�+)�l\� 1�S�V��\�\�_���F\�\�e�$ZJ�\��Г\�N�\�\�\�\�\n��\�a\�z�����W�\�l@�p�\�~M\�9���\�E �!z\�Y�\"�0Y;@E�i\�>u�b\�U�/�\n�)�\�7\�WVV~\�\�|�ۂgY|\r��\�\�nۀ\�ҩx�\�x[\�\�\�Q�O�O瀚���E�99\�\�\�\�\��\�5t}\�\�E~z\��\�}\�\"�y�k\\!Fx�D�\�#7�K���\'*A�\0Ģ�K%X�.\�Aj\�f\0d\�\�Bh��,\�)����\�ffRx�Ba6�W1�B��#Zɋa\�n�&Hn\���� �\�۬u�P�\�1\��a\�L\r\�;d\�\�(B�>Eh`\�@v�_��\0�g��9�x���$�+\��\Z�\�Y(\�	��j��\�\��q=@}�A\Z�\�cEڶ,��,\�j��\�k��5�h�\�m#Q����{1H�t�\�p\n|L^�0ˊ[\\|�\�\���\�2\���#\��.\�\�\���/�5B_\�\�弰�:�@\�\�\�%�%����D�\�Y��\�-�%��e�E\�\�\"A��*�5�\r�\�a�]�	x�\�\�F:�38��\�\�ș\�\r\�W��(�\�Yţ�\'�\�\��\�^�\�M\0\0','6.2.0-61023'),('201810311700233_addsIsRequiredForCarProperty','DAL.Migrations.Configuration',_binary '�\0\0\0\0\0\0\�\�n\�F�@��\�c\�Xv\��!%p\�0\Zǁ\�}3\�\�J&J.r\�Z(�e}\�\'�:˛{�.;E �ȝ\�ٹgg\���g�\�1���\�QJ&��\�\�a�aD���?�o^�\��m�<z�6\�^�u\0I�O\��d4ʃ{���0��,\�\�9=\�d�\�t��\�\�\�\���\npy\��� 4Jp��NS\�%-P|��8\�\�\��fVb�ޣ\�K\��v�\��N\��\�3\�}�RD����9�\�,%�\���f�İn�\�\��t\�mi?z\�hu�\r��\�i�8\"<~U3că�\�R�e�\�-���ةK�M�)�x�f+\�\�7;�\�[8�(C|��\�[\�\�#�6p^���}Ѽ=h��;�EL�O.h�\�\�CqG�/xu���Ʉqܧh�w��\�C�.qFW\�x^\��\�h7\�[�Lu�B_�����9��q�=.\�h�\�1��8��(\�a8\�î�ݹ�\�>\�n�y`5�w�\�a���`\'��y�\�\�AM�G��\�\n,!�\��=z�%�\���5,��\�5�\��}��\�~y[\�\�dir�\�h\�\�\�\r\��\�qR\�YZdG\�xԩ�Vk|��X�}QE�*��w���FA�\��ž�!�OuD���fbe\�\�c���8hk+}3؆�4����ƠlI�-�o�(�h��9Xr\�\�G�|�`܊e�\0������\�2~Eq���￵�v���%¶2�p+�km\�M\�`\nk�e�MT�U��9+藬\�[�`{v[p\�e˾\�\�Fy���:�Ӌ�\Z*��\�i6EYC�O)\�\"��k\�\�\�<������\��\�\�\�\"\�#\�\�#\�\�\�d�(\��H�p\��\�4\�\� *Y8��\�sx��$�̙hu�^6G݊��M@\�\��F\��q�:\�݅��x\�;��\�h�\"\��;R�lԞ�ڕ\�\�2C\�%�hֺL���4<Ǳ\�;�+r�cL�w\ZT^S�(-T?\\�V	��	Ng\��x\n��F��3\"A�D�#9<���1�ݑs���0�\�\�\"R�i�H[K\'H+�\�]9?��\0����\�\�\�{�eA갚\�.�W\"�s����\�Sb\�JGk\�|2# \�\�]\�\�\�~\rhYĕa�2�\'V�U�k�\�B�e\n�oV���/#Au�bXU�v\�m\rm�U�*2\�&й��މx\�Ӱ\�\�,8�)��ɿ�]\�P�^0T���8[6\�b���4lm\�֗v\r�Q\�!k:i#E+m|	5丽\�Z�ěU}�鋙{�)�p��\\҆j�mw�r\�!\�-l\r��GYN\�Ew��\�\�0��#�\�\�5;	�Ad\���;;}ׅ1�\�\0\�p��\����\�g�e��k�\�EBԹ�\Z�r�}xY(����]\��Iݐ\�Vb\�x:��\�\�.%\�nDP�}�\�=���\�GQ?�\�QwK�8\�G\�F�\\�\�\�]-�Q������~\� ZY\n?�M��<\�^\�֍D_:�\r\�/\��\�.Z��pu;�Fx�lD_U�\�.\�w\��v#\�\�򲏣{\�\��\�\�ȁ�o�\�_�\�DT\Z\��4lV(�*Wb���c(�E�X��A(�\r\��m\��+\�\Z�8Ǘ\�\�U�\Z_\�[�����L\�M}ٻ&G�H� s}�W�4�]( �%�GiI�`\�śy@S�\�%l*(}�ª��}�\��\��\�4���u+.�\�8�U�\��\��;n\����_��<�%ůls\�-��1\�ؤsl��[\�\�e�=K8�\�\�Z}1\��\���q�Vg\�8\�\n����q\��\�]\�I���\'\�MV`\�/7&K���Y�p��z%�����\�Մ���Ԇ\�\0H�t\�a��j=c�\'\�\�o�\�U�\�;b����e\�g+U�c\nu����4��%�j�lE�O���$��\�O\�\�$q\�f�\�rM�aj/7�\�A:8\Z���n�@w\�\�6Hg,\�0\�T\�p�X��|��`�\�mI\�T�Cm3E��\�޹H(���֜�Q�u�>Gc�grw�\���\�*ٵBO�Ra����\�+\')?�bn���YWk�Y���}L\�ܩ|�\�\'�>\�\�Gm\�?�N\r\�\�\�\�sR�=�ϵ\�\�\�c\����\�\��\�F\�]�>\�Agq���t�y�d�z)?�KA�\nF3Ϊt\�\�9\�vPN�jǖ\�Cв�C�\�Ai�9i\�\�\�	P\�<�r�Z�G=�m\'&�F+4bs\�y\�3T�9��\"��\�\�خ\����_,\�*$��C\�t�s\r��N��A;6\�\�\�\�Q6\��|a�����7\�ԉI\��\�\�e�&_�+&�5\�i�a\��,��@\��\���e����\��c�(��z�my�\�P��\�Ep0H�\�5d�6iGQ�����\���?�f4���\�\�\0\�y�kݲ�:�\�&w8� W]����x\�oXƧۿ�\�Đ\��ղ��6�\0dFp|E~*�8l\�>�\\<+P�T�\�1YR\�-[�ZL\�Sb��f_�\�\�d���\�\�^�6\�h\�\�\nV\���\Z�YC��\�\"�\�P�\�8:x�\n:&���\�K~�\�N\0\0','6.2.0-61023'),('201811081538387_IntroducesImages','DAL.Migrations.Configuration',_binary '�\0\0\0\0\0\0\�\�n\�6�}����\�\��\�I�\�\Z3	\�q�l�\�ۀ�8c��H�׃E������R��\�ͅ �%�\�\�s?\�9�\�?\���\�y�i\�h➟��D^\�h5qs�|��\��w���g\�z\�;��@�l\�>b�\\�F��#��F��\�Y�ħ^���ޞ��kt~>��Kp9\��.G8�`��u\Z#&8\�M\�\�0���7���D0K�\'\�\�\�\'׹@��\�p\�:\0�L����9Nc��\'\�\�\�	$\� \�`E�E�ܔ�����QX���Ǒ%\��w3F<�F,ufv}$l\�kz\�ew\n0\\\�\�\�u�\�.�aJN\�H�\n.@�, �`vZÝ8\�\�7\�\��\�I�D_\�g��8O\��� <q�\�a\���\�\�\� ��<YJ	�\�]\�y�%��\��\\V�\�|\�u\�F<`\���\'�!�\�\�|&���6��pa�\��\"���_\0\�0EGqص�;�ݧލh�\Z׹ϟ Z\�Gb\'d�\�\�������( 6F`p�C	�ܦ��S�*\�\�\'����3׹�a� {�\�0N���J�Dp��4�\�\�e\�.\�A���\'V.�\�y\�q�G�\�i��\�g��ث*\�U���{U0�]��D t�/)���(?�\�\��\��z\�#\�o}4�\��a-�)h��6(Sg\�o9yūEcA-e��	w\�ʬWG\�<!r\\^I���ΒE\�Z\�+J\�9�\���\�\0zu6z˼BH�5����ShF�a-c\��\�]�\�&7R\�Yتr�U����s]\0�\�F\�\�\�X�Э��\�[vӼj�x�\"K�D�QMW-����_�Vpd\0�B�\�l�.{�\�A����ZF�Yv�\�A\n�\�8���&\�\�\�@\�\�6�\ZjZC\�\�\�F\��5���EP�W#\�\�#\�\�a\nA�e��S\��\�2\�b/(X\�\r�l=\�=�G\�;�\�]y�@$G\"�$D��{�3Z\�Mj�wtZ\�\�sH�ٻi��:E\�V�O\�\�UԢ�<<wy˻EW0�:�^y�:�|Q\r�>�\�\'\�XaJ��S⧈��� /H@���2t��=�\�\n&Q[\�\��d_��ov\�x\�\�\ZS$�*\�\�\�.[\�\ns\�\�g��\�M�!\�F4k���AeҳCk��U\�iKand��<܃5��Ȅi��S/\�+���57\��>ˮ\�I\�QenY\�y%�8\�K�b\�x.�C�ԻX\�*V�\�Xx��\�U@P��p>\�\�p�o��\�f\�\��{\�ҜP��\��9`F+Nw\�ƙ�\�t^]�r��~VĂ\�eY*�v\�\�um�\�^P\�&3\���k\r՜_�upq���\�D�$6)s\�\�4�\�I\n��$i]\�î\�b�$B\�\�\�՘�Q����ak]\�51�m�� u\�\�H\�82�IB\�O���z\�\�\�.�雹}�ET\�y��颡�ىT�\�0��dkB\�u�f�\n`�\0h�;�#aq��\�I�� k\�_�ПK��\�Om\��\n\��%��Nq?!�U	hѽB�J�C�q�GH�s��ˈ\�\�\�b`�\�B\�$�EH���6�\�\�酠2PB\�F\��_>1\�Pu\r�(�G\�8�\�\0G�\�hT��ݶ�P\��j��ۍ��Y\�Sehn2�\n��\�8�@{C�^�\�j�^�=�t�Y�EP=��UY-۱\\�b�8\�^&K�D_D��\�\�8t\�U\�/|&\�P#�=\Zї�����\�\�^�r�\�ȴ�P\�\�h�Z�\�\�\�O\�}7O�/\�ne!M\�:W\�<��B�q��_Z9ɣ�\�Cd���k��kA���hS^T\Z\�V�Œ8�&��\�vB㋙UZ��\�\�;\�cC�v�nA\�����\�d�؅~I\�Q��\�`\\U\���%By^.�M\��S\�����[xJߟ?NÀ8�v\�\r@�f�l5p<���X9�\�Q���\�6C6B\�\�\�%\�\�ކ\�F�M=�\�{�	צ�Q�r\�\�\��8���e��-h�|�<q�\�̲�(��\�\�>͡��\��;��NG\r\n�mG$E��\�\0�\�;��0�/�C{�rժD�.�ٯ��ĹM���pΨbmGT���Ŋ�\�\�,uw�/�E:��\�T�;��X1�X��ư�Pu�>\�q�-y�\�\�h�Y*!q�\\\�~R�!9�6\��kj\�~��{m9V�F$�C�\�\�}݀\�ӠҴс~���%C\�g\�\�,�Q\�b�\�+P\�6t���>;����n���\�J\�\�u\��揑�T�*)�m�\�J\�P��\�=h�\�\�\�}T\�\�i?�p\��H\�E��BG6J\�޸\�ZӦ�}4\�˴Z�`�\r�{o{�Qq��\Z�S��Hxx\�uLJ�G϶��<\�\�ޜ\��M~\�g\��\�x\�\�c^�\�I��vN��B:q���hAY\�j\�-s<�1\�\�{�!����|\�B?�\�?�#۩�K�wD\�lB�wg\��t�H9H$ۣ\Z=2S\0��	+4\na�y���g�V\'e+E2g���\r�Q+E�,_�t��W�ґ�A\r��Q\�H��A\��\"���M1#�6b��\�;n�i0\�\��FݭZ�\�	���\�x�I\�K��]1ImV][Џ�`\��\��st\�,3\�\�\�\�ʉp$�d�3\�u�`բ��A��W6kfh׹.GQ����r1�I\�y�\�`	<L^{0ˊ?St)L܏\��g\�6\�I�ɑa�v\\)M�u��]�ǷI!\�m���#�[�s�~C��\�ÎͿ��\�T��~�^�L�cd��b_S6\�\�(		�\�\��܄6��}�+\�\�>F5�~At\�>�\n�*QV\�h\�ɯD��\�����30F�\\\0\0','6.2.0-61023');
/*!40000 ALTER TABLE `__migrationhistory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `categories`
--

DROP TABLE IF EXISTS `categories`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `categories` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Type` varchar(32) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categories`
--

LOCK TABLES `categories` WRITE;
/*!40000 ALTER TABLE `categories` DISABLE KEYS */;
INSERT INTO `categories` VALUES (1,'Retro_Vintage'),(2,'Parts'),(3,'Cars'),(4,'Lamps');
/*!40000 ALTER TABLE `categories` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `images`
--

DROP TABLE IF EXISTS `images`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `images` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `FilePath` longtext NOT NULL,
  `ProductId` int(11) NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_ProductId` (`ProductId`) USING BTREE,
  CONSTRAINT `FK_Images_Products_ProductId` FOREIGN KEY (`ProductId`) REFERENCES `products` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `images`
--

LOCK TABLES `images` WRITE;
/*!40000 ALTER TABLE `images` DISABLE KEYS */;
/*!40000 ALTER TABLE `images` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `productcategories`
--

DROP TABLE IF EXISTS `productcategories`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `productcategories` (
  `Product_Id` int(11) NOT NULL,
  `Category_Id` int(11) NOT NULL,
  PRIMARY KEY (`Product_Id`,`Category_Id`),
  KEY `IX_Product_Id` (`Product_Id`) USING BTREE,
  KEY `IX_Category_Id` (`Category_Id`) USING BTREE,
  CONSTRAINT `FK_ProductCategories_Categories_Category_Id` FOREIGN KEY (`Category_Id`) REFERENCES `categories` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `FK_ProductCategories_Products_Product_Id` FOREIGN KEY (`Product_Id`) REFERENCES `products` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `productcategories`
--

LOCK TABLES `productcategories` WRITE;
/*!40000 ALTER TABLE `productcategories` DISABLE KEYS */;
INSERT INTO `productcategories` VALUES (1,1),(2,1),(3,2),(3,4),(4,1),(5,3);
/*!40000 ALTER TABLE `productcategories` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `products`
--

DROP TABLE IF EXISTS `products`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `products` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(32) NOT NULL,
  `Price` decimal(18,2) NOT NULL,
  `Stock` int(11) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `IX_Name` (`Name`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `products`
--

LOCK TABLES `products` WRITE;
/*!40000 ALTER TABLE `products` DISABLE KEYS */;
INSERT INTO `products` VALUES (1,'Bowling kegels',12.99,10),(2,'Coca Cola Cooler',19.99,0),(3,'Zoeklicht chroom',19.99,2),(4,'Retro mic',14.99,1),(5,'VW T1',2000.00,1);
/*!40000 ALTER TABLE `products` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `specificationproducts`
--

DROP TABLE IF EXISTS `specificationproducts`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `specificationproducts` (
  `Specification_Id` int(11) NOT NULL,
  `Product_Id` int(11) NOT NULL,
  PRIMARY KEY (`Specification_Id`,`Product_Id`),
  KEY `IX_Specification_Id` (`Specification_Id`) USING BTREE,
  KEY `IX_Product_Id` (`Product_Id`) USING BTREE,
  CONSTRAINT `FK_SpecificationProducts_Products_Product_Id` FOREIGN KEY (`Product_Id`) REFERENCES `products` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `FK_SpecificationProducts_Specifications_Specification_Id` FOREIGN KEY (`Specification_Id`) REFERENCES `specifications` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `specificationproducts`
--

LOCK TABLES `specificationproducts` WRITE;
/*!40000 ALTER TABLE `specificationproducts` DISABLE KEYS */;
INSERT INTO `specificationproducts` VALUES (1,5),(2,5),(3,5),(4,5),(5,5),(6,5),(7,5);
/*!40000 ALTER TABLE `specificationproducts` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `specifications`
--

DROP TABLE IF EXISTS `specifications`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `specifications` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Value` varchar(64) DEFAULT NULL,
  `SpecificationTypeId` int(11) NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `IX_SpecificationTypeId` (`SpecificationTypeId`) USING BTREE,
  CONSTRAINT `FK_Specifications_SpecificationTypes_SpecificationTypeId` FOREIGN KEY (`SpecificationTypeId`) REFERENCES `specificationtypes` (`Id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `specifications`
--

LOCK TABLES `specifications` WRITE;
/*!40000 ALTER TABLE `specifications` DISABLE KEYS */;
INSERT INTO `specifications` VALUES (1,'VolksWagen',1),(2,'T1',2),(3,'1964',3),(4,'1600',4),(5,'Benzine',5),(6,'Groen',6),(7,'Wit',6);
/*!40000 ALTER TABLE `specifications` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `specificationtypes`
--

DROP TABLE IF EXISTS `specificationtypes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `specificationtypes` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Type` varchar(64) NOT NULL,
  `IsRequiredForCar` tinyint(1) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `specificationtypes`
--

LOCK TABLES `specificationtypes` WRITE;
/*!40000 ALTER TABLE `specificationtypes` DISABLE KEYS */;
INSERT INTO `specificationtypes` VALUES (1,'Merk',1),(2,'Model',1),(3,'Bouwjaar',1),(4,'Cilinderhoud',1),(5,'Brandstoftype',1),(6,'Kleur',1),(7,'old timer',0);
/*!40000 ALTER TABLE `specificationtypes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `users` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `UserName` varchar(32) NOT NULL,
  `Password` varchar(32) NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1,'admin','admin');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'garagedb'
--
/*!50003 DROP PROCEDURE IF EXISTS `filterProductsBasedOnCategories` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,ERROR_FOR_DIVISION_BY_ZERO,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `filterProductsBasedOnCategories`(IN arrayCategories VARCHAR(100), IN amountOfCategories int(16))
BEGIN
    select products.Id, products.Name, products.Price, products.Stock from productcategories
	inner join categories on productcategories.Category_Id = categories.Id
    inner join products on products.Id = productcategories.Product_Id
    WHERE FIND_IN_SET(categories.Type, arrayCategories)
    Group By productcategories.Product_Id
	HAVING count(distinct categories.Type) = amountOfCategories;
#select Array_String;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `filterProductsBasedOnNames` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8 */ ;
/*!50003 SET character_set_results = utf8 */ ;
/*!50003 SET collation_connection  = utf8_general_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,ERROR_FOR_DIVISION_BY_ZERO,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `filterProductsBasedOnNames`(IN arrayNames VARCHAR(100), IN amountOfNames int(16))
BEGIN
    select products.Id, products.Name, products.Price, products.Stock from productcategories
	inner join categories on productcategories.Category_Id = categories.Id
    inner join products on products.Id = productcategories.Product_Id
    WHERE FIND_IN_SET(products.Name, arrayNames)
    Group By productcategories.Product_Id
	HAVING count(distinct products.Name) = amountOfNames;
#select Array_String;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-11-09 13:06:06
