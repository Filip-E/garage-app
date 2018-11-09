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
INSERT INTO `__migrationhistory` VALUES ('201810040845214_init','DAL.Migrations.Configuration',_binary '‹\0\0\0\0\0\0\í\Ûn\Û6ô}ÀşA\Ğ\ãZI»K\Ø-2;‚5\Äi±·€–¢¥‰T`cØ—\íaŸ´_Ø¡®)\ÉR’vC1,\ê\Ü\Ï\á¹\é\ï?ÿš¾İ†\Ìy€DĞˆ\ÏÜ£É¡\ë\0÷£€ò\Í\ÌM\åú\Åk÷í›¯¿š\á\ÖùPÂ½Rpˆ\É\ÅÌ½—2>ö<\á\ßCH\Ä$¤~‰h-\'~z$ˆ¼—‡‡?zGG 	i9\Îô&å’†=\à\ã<\â>\Ä2%\ì\"\n€‰\â\ß,3ª\Î%	A\ÄÄ‡™»8y\ç:\'Œd½¶v\Ây$‰DÁ\ßX\Ê$\â›eŒ„\İ\îb@¸5a\nkğ¡²¾T²{5bI\ÊO…ŒÂ‘^\ÆğLôG™Ô­Œ…\æ:E³Ê\Ò:3\ÙÌ	›(Ù¹\É\ìx\Î˜YtfvŸ”\àTşÆ°P\Î<e2M`\Æ!•	a\Îuºb\Ôÿv·\ÑG\à32¦„\"\á»\Æ]\'Q‰\Ü\İÀºó<p¯‰ç™ˆš†“+p\Îå«—®s‰\ÌÉŠA\åoMÙ¥Œø8$¨apM¤„„+\ZY\Ì\ânğR|Jn`x9\\\ç‚l\ß\ß\È{¼\ÈıŒn!(\n\ŞsŠW	qd’B‹€\ÓKò@7™¼{|R_\n×¹–ˆ{\Z\çñ?)^\Ş¾£€`gI\ŞD¬F\Õ\Ş\Şİ’dÕ‰:A–Qšø†€S¯®Ş˜+\è\r¹úÿˆkòRÿ{\"\îûoŸ%\â¬8£~\Åu>\r	s\ëõ\áµ\ë,}¢¶©\ßO-\â\ÜgÁ¡WBö\ç¸e\Ä÷\\Šò\Ş¹\'BD>Í¤j\Ş\n]¢¦ª§<pö‹—„¦\"†^\Z\ã¥@9f\î7–\r{	WÉ &\\×Œ^\ÊSOS\ÒNX\Ó%¡ş…ş»\ÅJÁ¶-3`\á.’ƒ(b\×\ÔA\Ñ\\‚lq\íK\ËM*u^µhT\Ö5Hh:[t\ZÑ¦vÇ¤™§\Å@¥…®€7ŠT\éu”.»™›J·„\å\ìºsóòÖ­lñ¼ozA\â³›\Öó\'\Î2oø\æ/–\ã£0§\áù¢¥?ª¤­8a®&0\Ş\"k”ôŒ&B.ˆ$+¢ò\Ó<-0=´;®\ädE¯\í¶2Kõ;GSU³Šm±¶\Ûªb‘É´\Û\Ã-¨Y£MIZ\n\Ş<biÈ»Šfv\Ş4\éøù‰Ma\ê²›Vñ,³j\Zzª\Û3\Ö	er\ïƒN\ÌOã‚¼‹\Ğñó“\áŠ–@\'Q\r§Q~FqôùC¡™\ÊZã¡‘\Æ[ß€\èpq\×mS‰¹½½o\Éõ¶yII°-X”*%[Q<)[i—‘Â™E\Èv®U‹L*´ªšdÔiQö/!¬Âƒ¨^9z A^–¿±‰z?\É~\Î\Åh®!.§k2c\Ü\ï&?kÿÎŠÁ\"`÷Ÿ}£Ê¨{‡­‘£Š>\ïó’ø÷$±&ş^š£§\å/\Ãpú\Ø\Új85¸>e*\r>\éTš\Ù\äYıú”‹Ñ›\ÆmğÌº?.t^š-¬A\íœ°¹¿gh\Ç\Îù¯w5\æs•`f;v?Fû¡!ı8	4\Ô\"<eto­\Ïö\È5d^?²\Z„+¾\0œ?\Ïøs\"|\ØT\Årõ(lK2p\ÎW\ëzXC¢2aX]…L°¾Z^S\îÓ˜0\ÃvŸ0$“)õ*Š\æ›\ÄÀUŠ\êPv\Ëş©\â`X|Ÿ%:—\"ƒ¢ª­³\Ò|\Ú\ê\Ì./~±q5\Ê\ËÿB`\íipŸ=²\Ú\×mö\êb\ĞBm×»NË»\\,Â«ŸgÖ½QÇº­o\Û\ÖÆ¡k\É\ÕE¿G¢‡_b—€\Õ\Æn\È.°c\äk+*-û„û?\Ó,­\Ã\êğ\Õ\ß3”\Û\ÆAfhŸ.[³`\Ûn\ëób\ÄÔ/ñ\ŞkŸ\Â1ÿº©I¨\ãüÆ¯`\Îù:*³!Q	b´X I€\é\à$‘tM|‰¯}\"û¶ô°AN\Ã\çü*•q*QeW¬a•Àúøg‹Ş¦\ÌÓ«8û:ó* ˜U€+şSJYP\É}\Ö\Ò\ßuP™±˜x”/¥š|6»Š\Òe\Ä*\ÌW%ô[c†\Ä\Ä_’xŒl\ï¼ƒ\rñwå– ›\È~G4\Í>]P²IH(\n\Z5>>b\áö\Í?!¹\Ï\"\0\0','6.2.0-61023'),('201810041008036_usingFluentApi','DAL.Migrations.Configuration',_binary '‹\0\0\0\0\0\0\í\Ûn\Û6ô}ÀşA\Ğ\ãXI‹a]`·\È\ìd–\â´\Ø[@K\ÇQŠ\ÒH*°1\ì\Ëö°O\Ú/\ìPw‘’,¥i7C€À&y\î÷\ã¿ÿükún2\ç	„¤Ÿ¹Ç“#\×\îGå›™›¨õ\á÷\İ\Ûo¿™\á\ÖùP¼{­\ß!$—3÷Q©ø\Äó¤ÿ!‘“ú\"’\ÑZMü(ôHy¯~ô=@.\ârœ\é]\Â\r!ı‚_\ç÷!V	aWQ\0L\æ\çx³L±:\×$f\î\âô\ÒuN%Hz	l\í:„óH…Œ¼—°T\"\â›eŒ„\İ\ïbÀwk\Â$\äŸTÏ‡ò~ôJó\îU€*?‘*\nG\"<~+\Ã3ÁŸ¥R·Tª\ëÕªvZ\êTe3wNl\"±s“\ØÉœ	ıp\ænˆ x qü\0\Z‚œpNv{ˆ·‡\Å\íA\é\è/ú\ïÀ™\'L%f%;pn“£ş/°»>Ÿñ„±:§\È+\Ş5ğ\èVD1µ»ƒu\ÎÿE\à:^\Î3K°\ZL&\ÙW¯_¹\Î5\'+¥#Ô´°T‘€Ÿƒ@‰ƒ[¢®q¤\Â\î,\ê-M§ †‡Q\ã:Wd{	|£1Nú9\İBP\ä¼\çca”H …Aƒ\è5y¢›”_ƒ<~\r_I×¹–>4\Îc’_>\ä¶D\Ã!3\"\n\ï\"V\Ön\î‰Ø€Bq¢\Î\'\Ë(¾Á\àÔ«Ü®\×s|c}1û\ßû]Qÿÿü®h9 õKªğiH˜\ë\Ü\nü”W”7®³ô‰F\Ø&~?vÔˆÿqŸ‡\ÆJ=^\"ZŠPè‰–\" †DË©”‘OS®š\áR\ç¨)\êœı\ìeQ\İC„\Æ\È\Ç\Ìı\Î\Òa/\â2KTˆ«*Ó‹y\êÕ„´3vŠPtÿ\\ş«\İb¥\Ï`Û–2°\Ô\çYC\æ¾kÊ q.Aµ˜¿²€%€¥‰&–*\áZ8J\í\Z(j2[x\Z\ŞV{\Ø\í“f\Z\ä¥u¼Q¨\n«\×P\Õy7cS\è÷/]õz^\Ö\ìM¡\×\ÑN¯°\0`v«u‰ù‰³\ÌZ\Äù\ár|+f8<_¶tT%·%%\Ì\ÕX‹Œ[$œS!Õ‚(²\":?Íƒ\ĞzVw\í‡+(Y\Şk›­p\ÄD\ÎÀ°Y®|\Û\0¬ôv¢„XdR©À¶phÚšFDKÁ›G,	yW\Ñ\ìƒÎº©:|vbc˜z\ï¦V<K-†‡šŠd†2z\Æ\Z¡H\ãm\Ğ	ùyLuuø\ìd8†¼%¨£È†\ã\ÈG~ô\å]¡™\ÊZı¡‘\Æ[\r\ßx\Ña\â®hÓ‰¹½\ïo\Éõ¶z9I°\ÍY´‚J\Å[^<\É[¡—‘Ì™E\È6®U‹\Ì\'¥k•5É¨=Ó¼\ì_[X…!{¢{\å\è‰YQXş\Æ&ú~’~œ3Š\Ş\\½¸\"œ®AªlŒq¿Ÿü`,Bş;K	OÊ€\r\ÜL|ñQŒj¥\î¶F*õE\0\"\Â$Âš¿zq£¿\Å\Õ\Ç\Ö\ç)n\ÏT\Z|Ö©4\ÕÉ‹\ÚõS£7\Û\Ï{2\ë~¿¨Óª\é\Â\Z\Ô.x\0Û™û{\nv\â\\üúPA873Û‰s\äü1\Ú\r\î\ÇqPÁÂ§Œ\î­õ\Ù¹†\Ì\ë\ÇVƒp\ÃÀ@s\êgN¤O[ƒºX\î\á \Z…mN\ÎùzÁk:#†\ÕU*õ\Õj\Ì0L¹Oc\Â\Ø}ÂL¦\Å+1š7ˆ\ë\Õ!\ì’ı=RIÁ\Ğø>Mt.EyU[gU³i«1»¬ø\Õú\Õ(+ÿµ§Á}q\Ïj_·Ù«‹Aµ]\ï:-\ër±¯\"4|–Y{öFë¶¾m[…®%WşQ¬=ôz¸,7vCv#_[Qi\Ù\'\Øÿ™jiV‡¯şF¨¡\Ø6RCûtÙš\Ûv[_^#v ö|‰q_ûñó¤›\n…ş)ƒßˆøò\Í_GEö18*-\Ö(`:8Š®‰¯ğ\Ú)\Óß–>–\à“³pÁ¿ITœ(\Âk(C\'°>úé¢·\Éóô&Ny	MŠ\"À\rÿ)¡,(ù>o\é\ï:P\èÌ˜O<Ú–JO>›]‰\é:\â\å\ê+ú=„1Cdò†/\É<‡·÷.aCü]±%\èF²\ßMµO”l	e£‚Ç¯\è\ÃA¸}ûÙ±S\ÙC\"\0\0','6.2.0-61023'),('201810091334401_addsUser','DAL.Migrations.Configuration',_binary '‹\0\0\0\0\0\0\í\Z\Ûn\Û6ô}ÀşA\Ğ\ãXI‹a]`·Èœd\Ö\\§\Å\ŞF:v„R”FR©a_¶‡}\Ò~a‡º‹¤d)MÒ®(\n6\És¿\çß¿ÿ™¾YGÔ¹.Â˜\Í\ÜıÉ\ë\0ó\ã d«™›\Ê\å\î+÷\Í\ëï¿›\Ñ\Úy_¾{©\Ş!$3÷N\Ê\äÀó„“(ôy,â¥œøq\ä‘ ö^\ì\íı\ì\í\ï{€(\\\Ä\å8Ó«”\É0‚\ì~\ÇÌ‡D¦„\ÅPQœ\ã\Í\"\Ãêœ“DB|˜¹G‡o]ç†I/€.]‡0K\"‘±ƒw’\ÇlµHğ€\Ğ\ëMønI¨€‚\áƒúùP\Ş÷^(Ş½\Z°D\å§B\Æ\ÑH„û/ex:øƒT\êV\ÊBu£Z\åFI©l\æÎ‰„U\Ì7®£;˜S®\Î\Ü\ád7$In@Á‡ &%Ü“\ß\î\â\íny»S9ú‹ú·\ã\ÌS*S3©\ä„\î8—\é-\rı\ß`s\06c)¥MN‘W¼k\à\Ñ%\àrsË‚ÿ\ÓÀu¼6œ§V`\r˜\\²S&_¾ps$Nn)T\Ğ\Ğ\ÂB\Æ~%.‰”À™Â‘	»1¨k´’\ZzFëœ‘õ[`+y‡q‚\ÔO\Â5\åAÁÀ;bŒ!Œ\ä)XÔˆ“ûp•ñ«‘Ç¯A\êK\á:W@³\â.LòÀ˜—7…-\Ñp\È£«˜Ö Û›k\ÂW Qœ¸ó\É\"N¹¯18õj·\ëu\Æ\ßX_,À¾¹b¿+ªÿŸ\Ş\rıŠ\êøaD¨\ë\\rüTT”W®³ğ‰Bh¿;j\Äÿ°MƒCc¥-e(ôDKPŠ¬e|l¨(˜oq\Ò\ïTJGŸ\'Vˆc<1\á.;\"ö\ÃL…\í|\Ütù¶\0\Ç,p¶û.L#†P$ô­0AoB>f\î†fzWe¨F\\·1½˜§^CH3¸°Í”$D¿)\ä?\Ûİª3X\ÛjúIk¢Ğ».ƒÂ¹\0i\É/µM´±\Ô\İÀQiw\n\å\à6ø<¡hÀ\r…L´ra\ãaw\ÆÔ³\Ã ªøoJ\ïBUºLU“w=µ…¶\ÄN\å)õ$\â\å£H9²x3\Ëô\Ó.†uc†)NœE>À\Ìw\ãı(\Ç\áù\Â\Ò\ïW\ÜV”0Cb\Ğn‘4rzr!ˆ$·DeyÏšq\Ñ\áj%%\ÃõM³•^X‚¨\Ï9ru`h€µ\ŞNP”S{&˜¶€fƒ#¡„[\Ê\Ì<¦iÄºJUt\Ş\ë7\áó\Ã\Ô\Óx×µ\âj\Ñ<TWô 3T\Ñ3\ÖefoƒNÈ§1A^·›ğù\ÉpE\Ã\ÚDQ\r\ÇQ´¥M\Å\Ñ\ã\ny\r\ëY…\ïv°§ñ€º{k\â¨OGxBÕµœ¡:}~[¶Ë’5¶[%\Ù\ZÄ­\áÚ•9U‘µo,u\ÛT\Ï s—mfW\nªxoE#ğ@\ŞJ½ŒdNo(L\ã\Z}…ş¤r­ª¿\ĞúˆiQÓ·/H\"Ÿ?QSy|y_üA\'\ê~’}œ\Ó½¹~qFX¸!óA\Ğıqò“¶rırÖŸ¸}öa6TJ\İ:®#›+GvO¸G¸1D>hB\ì\\\Ø}ŠkıSÜ–ıWğ¤û¯L\'cW³`ÿoªosÍ°Ú²\æy\"\íSRUoa5Ÿ÷Ôº\íFm\Òj\×Ø¡œ²\0\Ö3÷\Ï\ìÀ9ıı¦†\Üq.8Öšg\Ïùk´yZÜ\ã :‚…OÙªY;&s¡1d•¶o´l\ì(Hpı¼Ï‰ğI`jPµ/[8¨·T&\'Wp\ê\Ç]XW\áL(ö;Br\ìxŒV\'óÃ„PMf\ç6$\r)ñ*Œú\Í$ÀT~\év\Éş®µ¢ i|›&:÷•ƒ¼\Ê\Ö\ë6lj5f—¿Z¿\Ze\å\Ï\àX[FG÷,û&\Ü\\\Úuoz7\İùÜm\ÑmŒ†\Ï3k\ÏV¶cŞ··Q\èZ![\×\ä[r\æb¯>Œ\í\r/z\Ä\è\Ñ\×À\Í}µf²À\ï˜\ímµÊ²°´\×\Õb\İJ\ß×PCùÁ 5\Ø\×\Ö\äj[H?¿\"Füpa.04şÓšW5\nõ\×YüV\"©Şœ²e\\&5£ò‰Ö¹$f™C.\Ã%ñ%^û DöK\è{BS|r\İBp\Ê.R™¤E†è–¶”¡òbı\ì×™6\ÏÓ‹$ûÁÿ1D@6C.\Ø/iHƒŠ\ïK\ÛØB%\Üb\nR¶”j\ZZm*L\ç1ˆ¨P_U\'®!J(\"lA\î\á!¼a{+\âo\ÊuP7’\í†h«}z’\'‘(p\Ôğø}8ˆÖ¯ÿ½ôŠ¯–(\0\0','6.2.0-61023'),('201810290916403_addsSpecifications','DAL.Migrations.Configuration',_binary '‹\0\0\0\0\0\0\í\\[o\Û6~°ÿ \èqH­¤İ†.°[dv2\Ë\rqZ\ì-`$\Ú*QDe1†ı²=\ì\'\í/ŒÔ•\â]¾%\é‚E\"ñû¿öß¿ÿ~|Œ#\ç¦Y˜ ‘{0\Øwˆü$\Ñ|\ä\æxö\æ½ûñÃ·\ßƒø\Ñù\\¯{G\×J”\Ü{Œ‡—ù÷0\Ù ı4É’øI\ì ñ\Ş\î\ïÿ\äx°p	/\Ç^\ç‡1,~!¿\ä\Ã\ÎAt0Êª\ç\äÍ´\à\ê\\€f\àÃ‘;9:s£(d\ë)Œf®J0ÀD°\ÃOœ\â4Aó\é‚<\0\Ñ\ÍrÉºˆ2X	|\Ø.·•}ÿ-•\İk	kV~\á$\î\Éğ\à]¥\'_I¥n£,¢®c¢V¼¤§.T6r\Ç\0\Ãy’.]‡\ß\ìp¥t\áÈƒ\Ì\á-X,n!¥a6¨\éöœò\íòöMıv¯q\â/ôÏ3\Î#œ§p„`S\í9Wù]ú¿\Â\åMò¢Ê£ˆ•”\ÈJ\ŞuGWi²€)^^\ÃY%ÿi\à:^—\Î\ã	2†¦<\Ù)\Â\ïŞº\Î\Ù\ÜE°qFSœ¤ğˆ`JN\\ŒaŠ(\â°Kawn/ºO½ñ<5®s\Ï š\ã{\'d÷“ğõƒJ€O($1FhpšC‰€Ü¦\à!œòrÛ“_ƒ\ÜÇ™\ë\\Ã¨Xİ‡‹20\Õ\Ë\ÛÊ–\ÄpD˜4‰¯“¨%e\Ş\ŞŞ€t19N¢\\2Mò\Ô\çz­\Ûi±\â\×\×+²WWÔ»\"ı{û®(8`\è7»N \Æ r«”üTU”÷®3õe(;¾;ÑˆÿÅ¤A\ÛXa\Ã`\ÑR‡‚&Zê€²qº z›…~)›T\ÌÎ’\Û6ş[Q\å+„\àV,[+À;<û†y‡ø5\Øõ‘ñD¹.\Úü\Ş*\Ú\r\á\ÇZ„ne>\áF\n\×\Ê>Î‡¤!V\nË²â›¤¦«nùpV\È/Y«VÁ\æ\â¶<\à\Z±K—½\Æ\ïZ}£eø®~}Íº\î¬\rLÿ¯\ä\Îd\nLûz0¥yuZ½\ÓR=M—	²\ì$\r¶¼±\ÊÁ²,ñ\ÃB…\İò\Å6‹\İ£À1w\åa˜\î“‰øV¸ \ŞD\ä¹\ß	š\Ñ2nªFË¸ı\0 \å<ô˜C\êÏ®¨\Î*1M¥º•\ë\í5a\êxûªyUeÈ²¤•\ÌÚ”©PPYAº\ç8pù$s‰&0‚:G~ùj2b\Ä\×V–U¢\é\Æ$I¦4hL8’´\Z\",f\Ìù\áD=u\Èñ±Ì½T)Íü›	\\@D\ÓfOÙˆ\"m»E\Ù\Z8CšT©ô\î2ù\ZL(`ZIs¾œ\Ü\ÑgğQöá†”„ª¬fUŠåˆòœB,\Â\Ûd+\ä*!Ô»\\Ú‘@\à\ÑD¸\ß\ÌŒ8\îÃ®P‡‰e¿¶´\â\Ê8•GÌ˜UPU\ç³³Pıñƒ÷7«Š\Ö\È\Ï\ÚHp]«\ZÆ°be\ç\ÓV÷\Ğ\nQ\r—¢Rl\n]ŸRÇœˆ÷>Š\Å\ÍB\ã\ë*I\Úü\Ôe,…«C•\n«ˆ³U£®†Y[I£Öº‘lri{¡\å•7ZõÍ—§¸ú\Z“„ô¸\ÌUXõÄ™–÷`\ã7\Óş÷Eq\É\Ãó3ÉµQ#m³\È8Ä½%[IO\Â4\Ã€Á mô8ˆ…el\åP¤¹z\'¡8ˆ†¬3`MB.\É&Ggm\élEpBÓ‚]Abv‘÷ ©d\æ\Z\'Q#uï ¦.?K/+¥wp²=€ ¡©\ë*\Ú\ÊšL§7B]{û\Û@I¹”C,K_>±\çP\İ{°,ªGö<ª\Û\r–Gõ\èÙ¸‚1ƒ\ë¢\ÛCõwıvœ£ú´\Î2¨õ0­¬…\ïÚ¦\Çf/k\ëZ¦/Üš\æ—óøŸ¦\èr.\èk“bj\èo9\Ùv4\ß~bdy´O{d\è\æ›a\'I7Owo\Ën»(­¹1MZ\\;+eT\Õ\Ñ\ĞvX~\'™\åDõX™»f(ÿfÁ°’lÊ¯(V²\Õz\é)\ß\è÷6®j\ä\ÔdLf•6+*\Z\'‰6õ\Ã\éŠ\Z\í2İ€\Íõ\Ó\îN}\Òlva\Ì\ã—4¥÷¸±nXXfØ£0s•K(\Ö&yƒrŞšş\r\èûAñ\ã8\nIkWœ\Î`†\ËK*÷‡Áòù€\Z½,\"Éˆ*C6\îü¢-¤J5^¥õ¼\âb/„\ÑHı{\n\\+\İ^)ax_‡\â\Ø\É\Õ\'¹odQmÁVQm…N6cWÍ´ôb­\ÛÁ9I\ÍK¡-\Ó5aM\Å„KSÀÇ‘ûgA\èœşv+a±\ç\\¦$\É:û\Î_[±¨8\0½X«\Z“]×¨\ë¨P^^¬\Öxø\ÅÆ²‡®\ØMùY§~k:q¹¦\ï7•İ«_’h){\äQ€ôı$`H·\Ö\è*,¦ˆ>>`¶©¸\á\Z\é]û\î\ØÁ\Ö9I§Eñ:\×r³%¨\nŸ\\$’X\"¢œA)\êKƒNŸ{ú§\Î\ÍcJ¬¼J6\İ36•\ZSeÅ¯Ö¯zYù	\Ëğqm\Õ\ã—\n`a\Û\ÔN–N\å¶¯\Û9ˆ®OµùùthHoO_4Ÿ“\Ó\í°|®\ìnO^C7‡:~~ø\â§G\ï\Ü÷^ *X„€ñÆ•\â~—Z\Ôoy¥1rƒ»„xA9Áh°Ÿ\nT°,\ÛA	›\Ôb|Íˆa\Ù^D¡Ul*6\î,…KJÁ\ÇJ\ì±l\n­lg&G+4f\ë\áò*¦W¨\Ösd+E1,a\Ù\r\Æ\Õ­¸¶•u”\"›·^°>\ÎX=Ú©A~/,eˆ\Ï\ç£t\Üœnöi“€\í¬±\Ô2G“/Ø–’\Ô\ÓM°\àyŠy¸¾˜o¯2{\Üø^D_F‰ù¯©HÛ–…ó–ıªô;-R³\æÍ’ºm\ã$ª—p_~\Ï!éŸRÎ€\ÉkfYñO[‹‹Ï‘{\ßÁ\à]\æx‘crd\ßE|C;>\İşÅ¿0\è\Ê<¼\\\Ş\Äˆ˜!9¼D?\ça4rŸH><+X\ĞV²º%£¶\Äô¶l¾l8]$È’Q¥¾¦¾ñ\"\"Ì²K4p\ÙHGs\çÀ_\Ö\Z5³!ºjNB0OAœU<Zzò+ñ\á ~üğC’®¡M\0\0','6.2.0-61023'),('201810301053516_addsUniqueConstraintOnProductName','DAL.Migrations.Configuration',_binary '‹\0\0\0\0\0\0\í\\[O\ÜF~¯\Ôÿ`ù±‚5$M•¢\İDt\n•›Xõ\r\rö\ìb\Åo\ì1eUõ—õ¡?©¡3¾{\î³7 E‘\"°\çœ9s\î\Çó%ÿşı\Ïğ\ãc90\Í\Â\ÜıÁ\ë@\ä\'Aˆf#7\Ç\Ó\İ÷\î\Ç\ß7<\âG\çs½\î-]G(Q6r\ï1x^\æ\ß\Ãdƒ8ô\Ó$K¦x\à\'±‚\Ä{³·÷³·¿\ïA\Â\Â%¼gx#Æ°ø…ü:N\ç8\ÑyÀ(«“7“‚«sb˜ÍG\î\Ñ\á™\ëF! [O`4u€P‚&‚|\Ê\à§	šM\æ\äˆnsH\ÖMA”ÁJ\àƒv¹©\ì{o¨\ì^KX³òó\'±%\Ãı·•2<–|)•º²ˆº‰Zñ‚ºP\Ù\ÈgIºpv³ƒq”Ò…#wR0ƒ·`>¿…”>„Ù ¦\ÛqÊ·»\ä\ínıv§q\â/ôÏ3\Î#œ§p„`S\í8Wù]ú¿Á\ÅMò¢Ê£¨+)‘•¼\ë= ®\ÒdS¼¸†\ÓJş\ÓÀu¼>\Ç6dšòd§¿}\ã:dspÁ\Æ:Z˜\à$…¿BSr\â\à\n`SDy‡]p»3{\Ñ}\êİˆç‘¨qsğx\Ñß“8!»Ÿ„0¨T|B!‰1Bƒ\Ó\nd6½\0á¬—Ùü\Z\ä>\Î\\\ç\ZFÅ‚\ì>œ—1¨^\ŞV¶$†#Â¤I|D-i\ç\í\í\rHg“\ã$\Ò%“$O}FÀ¡×º\Ò+~¶¾X‘½º¢\Ú\éß›wE\ÎC¿\Ùõúa\"×¹J\ÉOUEy\ï:P†¢ã«¹ø_t\Z4•n¬#Z\êPPDKP¦\"N\æDo\Ó\Ğ/eŠ\Ù[r\Û\Æ+ªxÜ’e+x§m˜÷ˆ_ƒ]ŸA”«¢ı§¢]~]‹Ğ­ô\'\\K\áZ\Ú\ÇÙÔ„\ÂRaYV|\Ôt\Õ-\Îùk\Õ\Ñ*\"X_Ü–\\!v\é²\×ø]©o4ß¥\ÃÏ¶Ğ¬\ê\Î\ÊÀTùÿR\îL¦À\ÔÖƒ)Í«Óª–\ê\èiºLe$i°\áev˜e‰*ì—¯n³\Ø?À1\n}\çX¦\Ó}’#\ß\n\çÄ›ˆ#÷N3J\ÆM\Õh·\0”œ‡^\ç\ê³Kª³LL]©nEeºGsM\è:^[5/«Q–4’Y™2%\n*+Hÿû.›d.\ÑŒ †Î¡_~ \Zƒ\Ìq\Äõƒ¥eh\ÚÒ˜$	Â”f!	G’VC„ùŒ\"?œƒ\ÈR‡\Ã\ÜK•\Ò\ìÈ¾9‚sˆhÚ´T‘‰(Â¶›—­1¤N•R\ï.“¡Á„¦•4ç‹£;ú>Š>Ü’P•Õ¬J±¬QˆCx›l¹\\Å…zŸK;p<š×°`›\ãÀ6\ì\nu\èX–ñ«aK+®ˆS\Ù\á0\Ä³rª\ê}\Ö\è,”ü`ıÍ¨¢5òwmÄ¹®Q\r\ë°\ê\ÊÎ¦­ş¡\r\".y¥˜:›R\×9\ë}\niŠ›\ÆWU’°ù×¨K[\n—+†2VgªFU\r3¶’B­u#\Ù\ä\ÒöB\Ë+o´\ê›/Orõ5<\'3\éq;Wa\ÕgRŞƒw\'ö÷Eq\É\Ãó3ÁµQ#m³\È8Ä¼%[IO\Â4\ÃG\0ƒ;@\Û\èqsËº•C’\æê¸\âÀ²Î€5	ı¹$;:<kK_`+‚r”˜\ìbâ³‹€´¸H3\×8‰ò\É{9u™ø»ô¢RPz#;\×pjášº¾¢Ì \Ètj#Ôµ\×\ŞR\ÊÍ˜ b»ô\åsÕ½G—EõÈœGu»\Ñ\åQ=z6® \Í\àj‡\è÷Pön¡¡ßŒsTŸÖ»ªG¦µğ=C›ôø\Ï\Ã\ìem]\ÉôE‚[\Ñübÿ\Ó]\Î¶6)¦{3ˆ\É6£ùöc—Gû\Ô\"C7\ß{Iºyº}[ö\ÛEa\Í\íi\Â\â\Ú[!)£²†¶\Ã\â{8Á,Ç«\Ç\È\Ü5Cñ7‹\0K\É&ıŠb$[­K\á\ØF\ßÚ¸²‘S‘1;«”YQ\Ò8	´©N—\ÔhŸ\é\Zl®v·\ê“z³sc»¤\É(Í¸ÇŒu\Ãj\Ä\Ò\Ã¹™«\\B±6\ÉC”ó\Ö\äk4 \ïÅ\ã($I¬]qP8…./©\Üwƒwòù€\Z½,\"Áˆ*B6nı¢-¤J\Õ^¥Y^qu/„\ÑHı{r\\K\İ^Iaxß†\âº’­\â¸Õ§(€#÷O\ç4û„Â¯9<pn\Ò:\Ù)Yp7\ÙEÀEÀú[(&«\ë	=L”0†(¬¢eº\"ª8ƒ\Ü\Ï(ısúû­€Ås™’„|\à\ìQÿÛ€Eùa\é\ÅZU›ûF]E…ü óbµ\ÆB5–+)‚l\Ç 1¶SªV©õ\Ê\æ_®˜ôF\í\îe—$ZJ‹\ÜÀĞ“\ŞN‚\é\Æ\Ó\Ó\nˆÁ\Äa\ãz›ò®şWµ\ï–l@”p²\ä¯~M\à9‚µ°\ÉE ‰!z\ÊYÀ\"¿0Y;@Eói\È>u®b\äU¢/›\n)³\â7\ëWVV~\Ç\Ò|ˆÛ‚gY|\r“\Ì\ánÛ€\å‰Ò©xÁ\æ¡x[\Ü\Ù\äQ“O–Oç€šôöôEó99\İ\Ë\ç\Ò\îö\ä5t}\å\ç‡E~z\Äñ\Ö}\ï\"ˆy¸k\\!Fx¡D—\×#7¸Kˆ”Œ\'*A«\0Ä¢¤K%X.\í¥Aj\Èf\0d\í\ÎBh¥¨,\Å)‹ö¨\ÍffRx·Ba6ÿW1µB•#ZÉ‹a\ánğ°&Hn\É¯¨« ò\ĞÛ¬u„P„\Õ1\Éòa\ĞL\r\â;d\á\ì(B‡>Eh`\æ¦@v½_“˜\0˜gŒ»9šxÁ¦”$÷+\äÁ\Z‚\çY(\æ	 ıj¿¹\Ê\Ìıq=@}©A\Z¥\ÎcEÚ¶,œµ,\èj… \ßk‘š5§hš\Ôm#Q½„ùò{1Hÿt˜\âp\n|L^û0ËŠ[\\|\Ü\ãø§\è2\Çó“#\Ãø.\ê\å\Úñ©ö/ş5B_\æ\áå¼°ğ:@\Ä\É\à%ú%£ ‘ûDğ\áYÂ‚¶’\Õ-µ%¦·e³E\Ã\é\"A†Œ*õ5ğ\rŒ\ça–]¢	x€\Ë\ÈF:š38ş¢\Æ\ÛÈ™\è\r\ÑWûğ(³\ÄYÅ£¥\'¿\â\Çÿ\ì›^ƒ\ÍM\0\0','6.2.0-61023'),('201810311700233_addsIsRequiredForCarProperty','DAL.Migrations.Configuration',_binary '‹\0\0\0\0\0\0\í\Ùn\ÛFğ½@ÿ\àc\áXv\Ò­!%p\å¸0\ZÇ\å}3\Ö\äJ&J.r\éZ(úe}\è\'õ:Ë›{¯.;E È\ÙÙ¹gg\äÿşgü\æ1‰½œ\åQJ&şñ\á‘\ïa¤aD¿ ó?øo^ı\Õøm˜<z¿6\ë^±u\0Iò‰O\éòd4Êƒ{œ ü0‰‚,\Í\Ó9=\Òd„\Âtôò\è\è\Ç\Ñññ\npy\Şøº 4Jpù¾NS\à%-P|™†8\Î\ë\çğfVbõŞ£\çK\à‰vú\Î÷N\ãÁ\Ö3\Ï}’RD°“9\Ñ,%‹\Ù øfµÄ°n\â\×Ÿt\Ëmi?z\Éhu€\rª \Èiš8\"<~U3cÄƒ¯\ÅR¿e°\ë-°•®Ø©K–Mü)¢x‘f+\ß\ã7;™\Æ[8ñ(C|‹–\Ë[\Ì\à#œ6p^õö¼}Ñ¼=hô…ı;ğ¦EL‹O.h†\â\ïCqGÁ/xu“şÉ„qÜ§h…wƒğ\èC–.qFW\×x^\Óú\Şh7\â[°Lu²B_½ô½÷°9º‹q«=.\Ìhš\áŸ1Áœ8ü€(\Åa8\ÊÃ®„İ¹½\Ø>\Ín y`5¾w‰\ßa² ÷`\'°ûyôˆ\Ã\æAMÀG\Í\n,!\Ûô=zˆ%½\Üöğ5,šû\Ş5\Ëù}´¬\ã°~y[\Ë\Ädir\Æh\ï\í\í\r\Ê˜\ÂqR\å’YZdG\àxÔ©Vk|®ºXƒ}QE½*²ÿw¯Š‚FA»\ë¢Å¾÷!ƒOuDùÁ÷fbe\Ç\×c¿›8hk+}3Ø†µ4¦ ±–Æ lIœ-oó(¨h“’9Xr\Û\ÙGª|…`ÜŠeø\0§«™€¿»\Ş2~Eq¡³öï¿µ²vƒùõ%Â¶2Ÿp+km\çM\Ò`\nk™eñMT³U·¼9+è—¬\Õ[«`{v[p\ÛeË¾\Ø\ïFy£¥ù:†Ó‹ü\Z*¢‡\çi6EYCÀO)\è\"˜³k\à\Ú\Ô<´†®³§µ\Ìª\Ê\Ì\Õ\"\Ì#\Ğ\ë#\ã\Ñ\Ód­(\ÏÿH³p\Ç«\ì4\Ï\Ó *Y8‡ı\äsx€·$ôÌ™hu˜^6GİŠ– M@\Ç\ÄÿF\àŒq…:\Äİ…‚óx\Ô;¤ş\ìŠh¯\"\Óú;R¹lÔ¦Ú•\Í\ë2C\æ%­hÖºLƒªˆ4<Ç±\Ï;™+r†cL±w\ZT^S”(-T?\\›V	§…	Ng\Ì¡x\nÁ­F„Š3\"A´D±#9<–¾—1¥İ‘s†—˜0·\é\È\"R¤i¼H[K\'H+•\Ú]9?€¡\0³šš\Ë\Õ\Ù{†eAê°š\×.–W\"†s†©¤¨ïœ­\à«Sb\éJGk\á|2# \â\Ø]\É\Ê\Ê~\rhYÄ•aª2¸\'VUƒk’\ŞBõe\n¯oV­¥¿/#Au­bXUŸv\Şm\rmÁU±*2\Å&Ğ¹„ºŞ‰x\íÓ°\È\Ü,8¾)“¤É¿]\ÆP¸^0T±°¶8[6\êb˜µ”4lm\ÉÖ—v\r²Q\Õ!k:i#E+m|	5ä¸½\ÖZıÄ›U}µé‹™{ÿ)©pŒ‚\\Ò†j©mw‚r\Ê!\î-l\r”GYN\ÏEwˆ¥\Ñ\Ó0–õ#‡\Â\Í5;	ÁAd\ãö¹;;}×…1À\Ö\0\çp”„\ì²½‹´\ìg¢e’škš\ÆEBÔ¹ƒ\Zºrü}xY(¨´ƒ£]\È¶Iİ\ÑVb\Ğx:½š\Ø\ë.%\änDP±}ø\ê‰=†º\ÒGQ?²\ÇQwKú8\êG\ÏFŒ\\¯\Ã\Ê]-ğ»Qúª¾ ~\ä ZY\n?´Mÿ<\Ä^\ÅÖD_:¸\r\Å/\Çñ\Ô.Z¹¿pu; FxûlD_U®\Ò.\ëw\ËÁv#\Ó\îò²£{\ê\àû\Û\ÛÈûoŸ\î_–\ÃDT\Z\Í 4lV(´*Wb‰¶¼c(©EöX‰»A(¿\r\é°m\Êû+\Ú\Z¾8Ç—\Î\ÂU³\Z_\Ü[¥õ·Š”L\ÂM}Ù»&G‡H· s}½W4‹]( ù%­GiI®`\×Å›y@S¨\æª%l*(}ˆÂª’›}Š\Ùû\Ãò\ã4À‰u+.‰\æ8§Uû\Ëÿ\îğ;n\äóùŒ_ò<Œ%Å¯ls\ï-¼ˆ1\ÕØ¤slõ[\×\äeÁ=K8¸\Ö\ÙZ}1\åÀ\àÿƒqıVg\Ç8\á\nü‚„øq\âÿ\é]\äIô©À\'\ŞMV`\ï/7&KºıY½p§³z%ÿ¶£šš\í³Õ„Áô–Ô†\Ø\0H‡t\Ãa­òj=cğ\'\Ş\Åo·\ŞUù\Ä;bú·‰Še\Øg+U£c\nu£‘»4·%±júlEÀO”¬Ÿ$®“\ÙO\Ü\Û$q\Ğf’\ârMÁaj/7\ÓA:8\Z‘€õnô@w\î\ë6Hg,\Ê0\ËT\ÜpƒX²©|÷¬`›\ÌmI\ËT±Cm3E´£\éŞ¹H(±òòÖœ³Q÷u¶>Gc¸grw\Û“±\Ò*ÙµBO¦Raª¤ø¿\Õ+\')?bnõö YWkªYû©¼}L\ÊÜ©|Á\î\'÷>\è\âGm\î?ŸN\r\î\í\éƒ\æsRº=†Ïµ\Õ\í\Éc\èö©Ÿ\ß\Èô\ÓF\ï]÷>\ÃAgqª®t”y¥d®z)?¼KAª\nF3Îªt\Ö\Í9\ËvPN‚jÇ–\ÍCĞ²½C’\ÆAi»9i\ã\Î\Ò	P\é<µrœZ¶G=€m\'&F+4bs\Ğy\Ó3T«9²•\"–“\æ\íØ®\ÍÀ¹¢_,\Ë*$ƒƒC\æ¼t¤s\r›N«‹A;6\È\Ò\Ò\ÚQ6\Äú|a˜†··7\ë…Ô‰I\æ­\Ç\ÃeŠ&_°+&©5\ÆiŒa\Æó,ó¿@\Ğÿ\ÖÀeöú¸\ßˆc(õşz¤my´\èP°¿\åEp0H‘\Ú5d6iGQ³„»ù½\Ä…?f4š£€\Â\ë\0\çyùkİ²‹:ñ\ß&w8¼ W]Œ“»x\àoXÆ§Û¿ü\ÑÄ\æñÕ²”ğ6\0dFp|E~*¢8l\é>—\\<+P°T²\î’1YR\Ö-[¬ZL\ïSb‰¨f_›\ß\àd²üŠ\Ì\Ğ^‡6\Èh\Ş\á\nV\Íğ\Z‰YC¶\Ï\"´\ÈP’\×8:xø\n:&¯ÿ\ìK~¼\ÄN\0\0','6.2.0-61023'),('201811081538387_IntroducesImages','DAL.Migrations.Configuration',_binary '‹\0\0\0\0\0\0\í\Ûn\Ü6ö}şƒ \Ç\Âñ\ØI»\è\Z3	\Üq¼l§\èÛ€–8c¡¥H”×ƒE¿¬ı¤şÂ’ºR¼‰\ÍÍ… °%\Ã\Ãs?\Ô9ş\ë?\Ç£\Ğy‚i\ÄhâŸ¹D^\ìh5qs¼|ó“û\áıwÿô£g\ç—z\İ;º@¢l\â>bœ\\ŒF™÷#F—\ÆY¼Ä§^€Şıkt~>‚…Kp9\Îø.G8ˆ`ñùu\Z#&8\áM\ì\Ã0«“7ó«óD0K€\'\î\Õ\å\'×¹@¶\Ãp\é:\0¡L»øšÁ9Nc´š\'\ä\ï\×	$\ë– \Ì`EğE»Ü”ö³·”öQX£òòÇ‘%\Âów3F<øF,ufv}$l\Åkz\ê‚ew\n0\\\Å\é\Úuø\Í.¦aJN\ÜHÁ\n.@’, …`vZÃ8\å\Û7\ä\í›ú\íI£D_\è¿gš‡8O\áÁ§ <q¾\äa\àı®\ï\ã\ß š <YJ	­\ä]\çyô%˜\âõ\\Vô\Ï|\×u\áF<`\ÆÀ”\'›!ü\î­\ë|&›ƒ‡6ŠÀpa\ãş\"˜’û_\0\Æ0EGqØµ°;·İ§Şh±\Z×¹ÏŸ Z\áGb\'d÷\ë\àúõƒŠ€¯( 6F`pšC	Ü¦ŸÁS°*\è\å¶\'¿ú¹‡3×¹ƒa± {’\Ò0N«—‹J–Dp„˜4\î\â°e\Ş.\îAº‚˜\'V.™\Çy\êqG­\Úi•±\Âg«‹Ø«*\êU‘ş¿{U0ğš]¯ D t/)ù©Š(?¹\Î\Ü¡\ìøz\ì„#\Şo}4µ\Ö¶a-µ)h¬¥6(Sg\Ño9yÅ«EcA-e‚	w\ßÊ¬WG\Ï<!r\\^IŒ”®Î’E\ëZ\å+J\Ë9œ\âô¶\î¦\0zu6zË¼BH€5‡ü¸ShFÿa-c\è«\ã]\Ü&7R\áYØªrøU¥õŠõs]\0ı\çF\ê\Ü\ÑX‰Ğ­¶®\Ç[vÓ¼j÷xó\"K™D÷QMW-øˆ¤ _²Vpd\0ƒB\ä€l—.{µ\ßA¥˜¡ùZF£Yv¿\åA\nı\ë8‚´&\à\ç˜\è@\Ì\Ù6÷\ZjZC\×\Ù\ÓF\æñ5ƒ©­EP˜W#\Ğ\ë#\å\Ña\nAeÿS\Ç«\ì2\Ëb/(X\Ø\r‡l=\×=ÀG\ä;ı\Å]y¦@$G\"º$D›÷{3Z\ÄMj·wtZ\Ì\ãsHıÙ»i«Š:E\ÛV•O\æ\çUÔ¢½<<wyË»EW0„:—^y±:™|Q\r‰>ø\İ\'\ÄXaJ­„Sâ§ˆù‹– /H@¨£œ2t”¨=ÿ\æ\n&Q[\Ö\ÉÀd_¦·ov\áx\Õ\Ç\ZS$”*\Í\è\Ë.[\á\ns\å\ë»g°µ\äM™!\ÄF4k£²‚AeÒ³Ck² U\ÂiKandº¦<Üƒ5›²È„i¥¸S/\ã+Á¦57\ë«ú>Ë®\ïI\ÖQenY\Åy%¢8\çK®b\Ûx.„CÁÔ»X\Ú*VÀ\ÑXxŠú\ÂU@P…¾p>\İ\Ğpúoƒ®\àf\Ê\Òü{\ĞÒœP†©\ÌÁ9`F+Nw\îÆ™…\êt^]r®†~VÄ‚\æeY*–v\Ş\ëumÀ\î^P\ä…&3\ÈÁ²k\rÕœ_upqƒƒ«\î‘D˜$6)s\Ş\ì4¼\éI\nöÀ$i]\ŞÃ®\Şb³$B\Å\Â\ÊÕ˜²Qû¥¤ak]\ã51¨m•ı u\ß\ÈH\Ñ82¾IB\ÊO¦‘¤z\â\Ì\Ë.’é›¹}·ET\ây™¤é¢¡¶Ù‰Tò\Ä0¹·dkB\éufø\n`ğ\0h…;õ#aqş½\ŞIª¢ k\×_ƒĞŸK°«\ËOm\È“\n\àš%¢‰Nq?!ºU	hÑ½BJ®C¦q˜GHs©¡Ëˆ\Ç\Â\Ëb`©\íB\î$°EH†»Œ6ƒ\Æ\Óé… 2PB\îF\åı_>1\ÇPu\r°(ªG\æ8ª\Ş\0Gõ\èhT¡Šİ¶ŠP\æöj €Û´€Y\íSehn2º\n¡¼\à8˜@{C²^°\İjÀ^À=ğ»tõY”EP=²°UY-Û±\\“b÷8\Ä^&KƒD_D¬\â—\ã8t\ÌU\î/|&\ëP#¼=\ZÑ—µ³­´‹\Ê\Ú^Àr°\İÈ´ıP\Ä\âhŸZø\ï\æ\ËO\Ç}7O÷/\Ëne!M\Ï:W\Ò<¬³B‘q©’_Z9É£œ\ä¾Cd‘¸k„òkA†€hS^T\Z\ÑVóÅ’8¾&´®\êvBã‹™UZ«¹\Ê\Ñ;\ácCv‘nA\æú‹‘½\êd¿Ø…~I\ãQš›\î`\\U\ãıó%By^.¡M\ÍñS\à—¥ùü[xJßŸ?NÃ€8±v\Å\r@Áf¸l5p<ı‘›X9\é‘Q–ù¡\ä6C6B\Ò\Ú\Ú%\Ê\ÔŞ†\ËF¶M=\Ô{¤	×¦°Q‚r\Ş\á\ïÁ8¶­¤eœğ-h†|ø<qÿ\çÌ²¯(ø–\Ã\ç>Í¡ó»“\Åı;£şNG\r\nşmG$Eù‹\Õ\0¾\é;Œ‰0‹/‚C{¸rÕªD¡.œÙ¯‹ğÄ¹M‰§½pÎ¨bmGTšòúÅŠ¬\Ó\Ô,uw´/²E:°‡\ÙT;—¨X1¿X©öÆ°®Pu²>\Äq¸-yˆ\î‹\ßh¹Y*!q\\\å~R”!96\é—kj\Ã~¡²{m9VF$ C½\è\Î}İ€\ÌÓ Ò´Ñ~™Šˆ%C\å»g\Ò\Î,½Q\Ûbö\Ş+P\Ğ6t‰”ö>;öª¿©n½÷¯\çJ\Ğ\Şuî£‹\×ğæ‘©T˜*)şmõ\ÊJ\ÊP¬\Ø=h–\Ù\Â\á}T\Õ\èi?õp\ìşH\ÕE ôBG6J\ĞŞ¸\ÖZÓ¦ó}4\ÇË´Z¾`÷\rñ{o{·Qq“¯\Z‡SÀHxx\ßuLJ·GÏ¶±º<\İ\ÚŞœ\ĞñM~\îg\ïº÷\çx\Ä\æc^¸\ÒIµvN§üB:qı‡˜hAY\ìj\Æ-s<º1\Ù\í‡{“!õŒ·|\êB?°\Ó?ş#Û©§K¾wD\ÈlB¨wg\é€t’H9H$Û£\Z=2S\0®	+4\na¡yòø¨g¨V\'e+E2g¬š¹\r“Q+E‰,_‘tŒWñÒ‘öA\rŸQ\ßH˜±A\ŞÀ\"½ÀM1#¶6b¶©\Ü;n“i0\ß\Õ™Fİ­Zª\Ô	Š²•\ÚxôI\ÆKù‚]1ImV][Ğ£`\Ì¦\ëôst\æ,3\×\Ç\í\ÌÊ‰p$»dş3\Éu³`Õ¢ •A¯“W6kfh×¹.GQ½„û²r1ğI\Òy™\â`	<L^{0ËŠ?St)LÜ\Ñôg\è6\ÇIÉ‘aôv\\)M“uû]šÇ·I!\ám#À[ôs„~C÷µ\äÃÍ¿«¯\ĞT–˜~^­LŸcdˆ¨b_S6\Ü\Ã(		²\ì\ÍÁÜ„6’¬}‚+\à­\ë>F5’~At\Ù>¾\nÀ*QV\áh\áÉ¯D‡ı\èùıÿ¬30F\\\0\0','6.2.0-61023');
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
