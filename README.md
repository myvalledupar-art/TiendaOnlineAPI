# AppOnline 🛒📱
Aplicación móvil de compras en línea con arquitectura en capas.

## 🚀 Descripción
AppOnline es una aplicación multiplataforma (iOS y Android) que permite a los usuarios:
- Buscar y seleccionar productos.
- Realizar compras seguras.
- Recibir notificaciones sobre el estado de sus pedidos.
- Consultar historial de compras.

## 📌 Arquitectura
La aplicación está organizada en capas:
- **Presentación:** Apps móviles (Flutter para Android/iOS).
- **Negocio:** Lógica de pedidos, gestión de productos, sistema de pagos.
- **Datos:** Base de datos SQL Server, historial de compras.
- **Servicios externos:** Pasarela de pago (Stripe/PayPal), notificaciones push (Firebase).

## ⚙️ Tecnologías utilizadas
- **Backend:** ASP.NET Core
- **Frontend:** Flutter
- **Base de datos:** SQL Server
- **Pruebas de API:** Postman
- **Cloud:** AWS/Azure

## 📑 Evidencias CRUD
- `Postman-UsuarioCreado.png`
- `Postman-UsuarioListado.png`
- `Postman-UsuarioActualizado.png`
- `Postman-UsuarioEliminado.png`
- `Postman-UsuarioConfirmacion.png`

## 📌 Instalación y ejecución
1. Clonar el repositorio:
   ```bash
   git clone https://github.com/tuusuario/AppOnline.git


## 📌Configura la base de datos en:
appsettings.json

## 📌Ejecuta el backend:
dotnet run

## 📌Ejecuta la APP movil con Flutter:
flutter run


## 📌 Estado del proyecto
✅ CRUD de Usuarios y Productos implementado.
✅ Arquitectura documentada.
✅ Pruebas en Postman realizadas.


## 📌 Autor
cHristian Angelone Hernandez, Esdudiante de Ing Software - Univercidad de Cartagena 