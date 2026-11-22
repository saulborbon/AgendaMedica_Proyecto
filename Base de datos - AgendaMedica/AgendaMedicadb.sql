-- MySQL dump 10.13  Distrib 8.0.46, for Win64 (x86_64)
--
-- Host: localhost    Database: agendamedicadb
-- ------------------------------------------------------
-- Server version	8.0.46

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
-- Table structure for table `citas`
--

DROP TABLE IF EXISTS `citas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `citas` (
  `id_cita` int NOT NULL AUTO_INCREMENT,
  `id_medico` int NOT NULL,
  `id_paciente` int NOT NULL,
  `fecha` date NOT NULL,
  `hora_inicio` time NOT NULL,
  `hora_fin` time NOT NULL,
  `duracion_minutos` int DEFAULT NULL,
  `tipo_cita` varchar(50) DEFAULT NULL,
  `estado_cita` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`id_cita`),
  KEY `id_medico` (`id_medico`),
  KEY `id_paciente` (`id_paciente`),
  CONSTRAINT `citas_ibfk_1` FOREIGN KEY (`id_medico`) REFERENCES `medicos` (`id_medico`),
  CONSTRAINT `citas_ibfk_2` FOREIGN KEY (`id_paciente`) REFERENCES `pacientes` (`id_paciente`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `citas`
--

LOCK TABLES `citas` WRITE;
/*!40000 ALTER TABLE `citas` DISABLE KEYS */;
INSERT INTO `citas` VALUES (1,2,1,'2026-11-05','08:00:00','08:30:00',30,'Presencial','Atendida'),(2,2,2,'2026-11-05','09:00:00','09:30:00',30,'Virtual','Atendida'),(3,3,3,'2026-11-06','13:00:00','14:00:00',60,'Presencial','Atendida'),(4,1,4,'2026-11-07','10:00:00','10:45:00',45,'Urgencia','Atendida');
/*!40000 ALTER TABLE `citas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `especialidades`
--

DROP TABLE IF EXISTS `especialidades`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `especialidades` (
  `id_especialidad` int NOT NULL AUTO_INCREMENT,
  `nombre_especialidad` varchar(100) NOT NULL,
  `descripcion` text,
  PRIMARY KEY (`id_especialidad`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `especialidades`
--

LOCK TABLES `especialidades` WRITE;
/*!40000 ALTER TABLE `especialidades` DISABLE KEYS */;
INSERT INTO `especialidades` VALUES (1,'Cardiologia','Atencion de enfermedades del corazon'),(2,'Pediatria','Atencion medica infantil'),(3,'Dermatologia','Tratamiento de enfermedades de la piel'),(4,'Medicina General','Consultas medicas generales');
/*!40000 ALTER TABLE `especialidades` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `historial_medico`
--

DROP TABLE IF EXISTS `historial_medico`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `historial_medico` (
  `id_historial` int NOT NULL AUTO_INCREMENT,
  `id_paciente` int NOT NULL,
  `id_cita` int NOT NULL,
  `fecha_registro` date DEFAULT NULL,
  `diagnostico` text,
  `observaciones` text,
  PRIMARY KEY (`id_historial`),
  KEY `id_paciente` (`id_paciente`),
  KEY `id_cita` (`id_cita`),
  CONSTRAINT `historial_medico_ibfk_1` FOREIGN KEY (`id_paciente`) REFERENCES `pacientes` (`id_paciente`),
  CONSTRAINT `historial_medico_ibfk_2` FOREIGN KEY (`id_cita`) REFERENCES `citas` (`id_cita`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `historial_medico`
--

LOCK TABLES `historial_medico` WRITE;
/*!40000 ALTER TABLE `historial_medico` DISABLE KEYS */;
INSERT INTO `historial_medico` VALUES (1,1,1,'2026-11-05','Hipertension arterial leve','Control cardiologico recomendado cada 3 meses'),(2,2,2,'2026-11-05','Presion arterial dentro de parametros normales','Continuar con habitos saludables'),(3,3,3,'2026-11-21','Faringitis viral','Reposo e hidratacion durante una semana');
/*!40000 ALTER TABLE `historial_medico` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `horarios_atencion`
--

DROP TABLE IF EXISTS `horarios_atencion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `horarios_atencion` (
  `id_horario` int NOT NULL AUTO_INCREMENT,
  `id_medico` int NOT NULL,
  `dia_semana` varchar(20) DEFAULT NULL,
  `hora_inicio` time DEFAULT NULL,
  `hora_fin` time DEFAULT NULL,
  PRIMARY KEY (`id_horario`),
  KEY `id_medico` (`id_medico`),
  CONSTRAINT `horarios_atencion_ibfk_1` FOREIGN KEY (`id_medico`) REFERENCES `medicos` (`id_medico`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `horarios_atencion`
--

LOCK TABLES `horarios_atencion` WRITE;
/*!40000 ALTER TABLE `horarios_atencion` DISABLE KEYS */;
INSERT INTO `horarios_atencion` VALUES (1,1,'Lunes','08:00:00','16:00:00'),(2,1,'Martes','08:00:00','16:00:00'),(3,2,'Miercoles','11:00:00','17:00:00'),(4,3,'Jueves','09:00:00','17:00:00');
/*!40000 ALTER TABLE `horarios_atencion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `medico_especialidad`
--

DROP TABLE IF EXISTS `medico_especialidad`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `medico_especialidad` (
  `id_medico` int NOT NULL,
  `id_especialidad` int NOT NULL,
  PRIMARY KEY (`id_medico`,`id_especialidad`),
  KEY `id_especialidad` (`id_especialidad`),
  CONSTRAINT `medico_especialidad_ibfk_1` FOREIGN KEY (`id_medico`) REFERENCES `medicos` (`id_medico`),
  CONSTRAINT `medico_especialidad_ibfk_2` FOREIGN KEY (`id_especialidad`) REFERENCES `especialidades` (`id_especialidad`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `medico_especialidad`
--

LOCK TABLES `medico_especialidad` WRITE;
/*!40000 ALTER TABLE `medico_especialidad` DISABLE KEYS */;
INSERT INTO `medico_especialidad` VALUES (2,1),(9,1),(10,1),(3,2),(10,2),(1,3),(10,3);
/*!40000 ALTER TABLE `medico_especialidad` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `medicos`
--

DROP TABLE IF EXISTS `medicos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `medicos` (
  `id_medico` int NOT NULL AUTO_INCREMENT,
  `cedula` varchar(20) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `apellido` varchar(50) NOT NULL,
  `telefono` varchar(20) DEFAULT NULL,
  `correo` varchar(100) DEFAULT NULL,
  `estado` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`id_medico`),
  UNIQUE KEY `cedula` (`cedula`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `medicos`
--

LOCK TABLES `medicos` WRITE;
/*!40000 ALTER TABLE `medicos` DISABLE KEYS */;
INSERT INTO `medicos` VALUES (1,'101350445','Carlos','Mora','88881111','carlosmora00@gmail.com','Activo'),(2,'602770786','Laura','Jimenez','88882222','laurajimenez@gmail.com','Activo'),(3,'603220123','Andres','Vargas','88883333','andresvargas33@gmail.com','Activo'),(9,'100010011','Marcos','Solis','88882288','mrc@gmail.com','Activo'),(10,'200220022','Mia','Robles','82882882','robles@gmail.com','Activo');
/*!40000 ALTER TABLE `medicos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pacientes`
--

DROP TABLE IF EXISTS `pacientes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pacientes` (
  `id_paciente` int NOT NULL AUTO_INCREMENT,
  `cedula` varchar(20) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `apellido` varchar(50) NOT NULL,
  `telefono` varchar(20) DEFAULT NULL,
  `correo` varchar(100) DEFAULT NULL,
  `fecha_nacimiento` date DEFAULT NULL,
  PRIMARY KEY (`id_paciente`),
  UNIQUE KEY `cedula` (`cedula`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pacientes`
--

LOCK TABLES `pacientes` WRITE;
/*!40000 ALTER TABLE `pacientes` DISABLE KEYS */;
INSERT INTO `pacientes` VALUES (1,'600890677','Ana','Rodriguez','88884444','anarodr@gmail.com','2002-05-10'),(2,'101340567','Luis','Perez','88885555','perezluis@gmail.com','1999-08-22'),(3,'403450889','Maria','Sanchez','88886666','mariasanchez99@gmail.com','1995-03-15'),(4,'205660776','Jose','Castro','88887777','josecastro808@gmail.com','1990-11-30'),(5,'607680544','Carolina','Villalobos','88883343','villacarolina99@gmail.com','2026-10-31');
/*!40000 ALTER TABLE `pacientes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `roles`
--

DROP TABLE IF EXISTS `roles`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `roles` (
  `id_rol` int NOT NULL AUTO_INCREMENT,
  `nombre_rol` varchar(50) NOT NULL,
  PRIMARY KEY (`id_rol`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `roles`
--

LOCK TABLES `roles` WRITE;
/*!40000 ALTER TABLE `roles` DISABLE KEYS */;
INSERT INTO `roles` VALUES (1,'Administrador'),(2,'Recepcionista');
/*!40000 ALTER TABLE `roles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuarios` (
  `id_usuario` int NOT NULL AUTO_INCREMENT,
  `id_rol` int NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(225) NOT NULL,
  `estado` varchar(20) DEFAULT 'Activo',
  PRIMARY KEY (`id_usuario`),
  UNIQUE KEY `username` (`username`),
  KEY `id_rol` (`id_rol`),
  CONSTRAINT `usuarios_ibfk_1` FOREIGN KEY (`id_rol`) REFERENCES `roles` (`id_rol`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios`
--

LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` VALUES (1,1,'administrador','1234','Activo'),(5,2,'Recepcionista','1234','Activo');
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2026-11-22 16:57:43
