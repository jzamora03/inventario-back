
# 🎯 Proyecto de Gestión de Inventario

Este proyecto permite la gestión de inventarios, dejasndo agregar, editar y eliminar los productos, así mismo agregar venta/cpomrpa de estos.

---

## 📌 1. Requisitos Previos  
Antes de comenzar, asegúrate de tener instalados:  
- [.NET SDK 9.0](https://dotnet.microsoft.com/en-us/download)
- [PostgreSQL](https://www.postgresql.org/download/)
- Algún cliente para probar la API (Postman o navegador)

---

## ⚙️ 2. Instalación del Proyecto  
📌 **Clona el repositorio y accede a la carpeta:**  
```bash
git clone https://github.com/jzamora03/inventario-back
cd inventario-back
```
📌 **Ajustar conexión con la bse de datos**  
```bash
{
  "ConnectionStrings": {
    "DefaultConnection": "Host=localhost;Port=5432;Database=inventario_db;Username=postgres;Password=tu_contraseña"
  }
}

```

## ⚙️ 3. Instalacion de dependencias y configuracion
📌 **En la consola en la carpeta raiz del proyecto ponemos: **  
```bash
dotnet restore
```
📌 **Si se desea usar migracion se podria de la siguiente manera:**  
```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```
📌 **Si se desea de la manera manual (Recomendado)**  
- Se importa la script de la base de datos.

## ⚙️ 4. Ejecucion del proyecto
📌 **Para arrancar el proyecto:**  
```bash
dotnet run
```
📌 **Tener en cuenta:**  
- El puerto donde se levanta el backend, para que conecte correctamente con los servicios del front.

