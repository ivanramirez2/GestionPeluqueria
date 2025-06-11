# 💇‍♂️ Gestión de Reservas de Peluquería

> Aplicación de escritorio para la gestión integral de citas, usuarios y servicios en una peluquería.

---

## 📝 Descripción

**Gestión de Reservas de Peluquería** es una aplicación de escritorio desarrollada en **VB.NET (Windows Forms)** con **MySQL** como base de datos, orientada a digitalizar y automatizar el flujo completo de reservas, usuarios y servicios en una peluquería.  

Cuenta con tres roles diferenciados: **Administrador**, **Empleado** y **Cliente**, cada uno con funcionalidades específicas. Incorpora inicio de sesión seguro, recuperación de contraseñas por correo electrónico, y reportes administrativos. El objetivo es reducir errores operativos, mejorar la experiencia del cliente y optimizar el control del negocio.

---

## ✨ Características

- 🔐 **Inicio de sesión y registro**
  - Autenticación por rol con validación segura.
  - Registro exclusivo para nuevos clientes.

- 👤 **Gestión de usuarios y roles**
  - CRUD de usuarios, empleados, servicios y reservas.
  - Recuperación de usuarios eliminados.
  - Control de acceso según tipo de usuario.

- 📅 **Sistema de reservas inteligente**
  - Selección de servicios y horarios disponibles.
  - Confirmación, modificación o cancelación de citas.
  - Visualización de historial personal o general.

- 📊 **Panel administrativo con reportes**
  - Reservas diarias/semanales/mensuales.
  - Servicios más demandados.
  - Ocupación y desempeño por empleado.

- ✉️ **Recuperación de contraseña vía email**
  - Envío de claves temporales usando **SMTP**.
  - Contraseñas encriptadas con **bcrypt**.
  - Cambio forzado al iniciar sesión tras la recuperación.

- 💡 **Diseño de interfaz fluida**
  - Formularios con efecto de movimiento.
  - Inspiración en prácticas modernas de UI/UX.

---

## 🧰 Tecnologías

- **Backend:** VB.NET (Windows Forms)
- **Base de Datos:** MySQL
- **Seguridad:** bcrypt, validaciones, control de roles
- **Correo:** SMTP para recuperación de contraseñas
- **UI:** Formularios personalizados con efectos animados

---

## 📋 Requisitos

- ⚙️ .NET Framework 4.8 o superior
- 🗃️ MySQL Server con la estructura incluida en el repositorio
- 📧 Servidor SMTP (ej. Gmail) con credenciales de aplicación
- 💻 Sistema operativo Windows

---

## 🚀 Instalación y Ejecución

1. Clona el repositorio:
   ```bash
   git clone https://github.com/ivanramirez2/GestionPeluqueria
