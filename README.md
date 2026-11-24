# Sistema de Gestión de Agenda Médica ("AgendaMedica")

Aplicación de escritorio desarrollada en **C# (Windows Forms)** y **MySQL** para la administración integral de pacientes, médicos, especialidades, horarios de atención, citas médicas e historial clínico.

---

## Requisitos del Sistema

* **Sistema Operativo:** Windows 10 / 11 (64 bits).
* **Entrno de Desarrollo:** Visual Studio 2022 con la carga de trabajo *Desarrollo de escritorio de .NET*.
* **Framework:** .NET Framework 4.7.2 o superior.
* **Motor de Base de Datos:** MySQL Server 8.0+ y MySQL Workbench.
* **Paquete NuGet requerido:** "MySql.Data" (v8.0 o superior).

---

## Configuración de la Base de Datos

1. Abrir **MySQL Workbench** e inciar sesión en su servidor lcal (localhost).
2. Abrir el archivo ".sql" del proyecto (agendamedicadb.sql).
3. Asegurarse de incluir al inicio del script las siguientes líneas:
   ```sql
   CREATE DATABASE IF NOT EXISTS agendamedicadb;
   USE agendamedicadb;
   ```
4. Ejecutar todo el script (Ctrl + Shift + Enter) y refrescar el panel de *Schemas* para verificar que se creó la base "agendamedicadb" con sus 9 tablas y datos iniciales.

---

## Procedimiento de Instalación y Ejecución

1. Clonar el repositorio en su equipo local:
   ```bash
   git clone <URL_DEL_REPOSITORIO>
   ```
2. Abrir el archivo de solución (.sln) en **Visual Studio**.
3. Restaurar los paquetes NuGet (clic derecho sobre la solución > *Restaurar paquetes NuGet*).
4. Buscar la cadena de conexión en el proyecto (Ctrl + Shift + F buscando Pwd=) y actualizarla con sus credenciales locales de MySQL:
   ```csharp
   Server=localhost;Database=agendamedicadb;Uid=root;Pwd=SU_CONTRASEÑA;
   ```
5. Compilar y ejecutar la aplicación presionando **F5** (o el botón *Iniciar*).

---

## Credenciales de Acceso por Defecto

* **Rol Administrador:** Usuario "administrador" | Contraseña "1234"
* **Rol Recepcionista:** Usuario  "Recepcionista" | Contraseña "1234"