# 🚗 API RESTful - Sistema de Estacionamiento

Proyecto ASP.NET Core que gestiona espacios de estacionamiento, reservas, liberaciones y cálculo de tarifas según tipo de vehículo y tipo de espacio.

---

## 📦 Endpoints disponibles

### 🔍 1. Filtrar espacios por tipo

- **Método:** `GET`  
- **URL:**  
  `https://localhost:7187/api/estacionamieto/Filtrar?tipo=Full day`

- **Parámetros de consulta:**
  - `tipo`: `"Full day"` o `"Rápido"`

---

### 🚘 2. Registrar vehículo

- **Método:** `POST`  
- **URL:**  
  `https://localhost:7187/api/estacionamieto/RegistrarVehiculo`

- **Body (JSON):**
```json
{
  "Placa": "ABC123",
  "Tipo": "Auto"
}
```

- **Valores válidos para `Tipo`:** `"Auto"`, `"Bus"`, `"Moto"`

---

### 📅 3. Reservar espacio

- **Método:** `POST`  
- **URL:**  
  `https://localhost:7187/api/estacionamieto/Reservar?placa=ABC123&tipoVehiculo=Auto&tipoEspacio=Rápido`

- **Parámetros de consulta:**
  - `placa`: Placa del vehículo
  - `tipoVehiculo`: `"Auto"`, `"Bus"`, `"Moto"`
  - `tipoEspacio`: `"Full day"` o `"Rápido"`

- **Resultado esperado:** Mensaje confirmando la reserva y cantidad de espacios ocupados.

---

### 🔓 4. Liberar espacio

- **Método:** `POST`  
- **URL:**  
  `https://localhost:7187/api/estacionamieto/Liberar?placa=ABC123`

- **Parámetro de consulta:**
  - `placa`: Placa del vehículo que desea liberar el espacio

- **Resultado esperado:** Devuelve el monto total a pagar según el tiempo y tipo de espacio.

---

### 📋 5. Listar espacios (con filtros opcionales)

- **Método:** `GET`  
- **URL base:**  
  `https://localhost:7187/api/estacionamieto/Espacios`

- **Filtros opcionales:**
  - `tipo`: `"Full day"` o `"Rápido"`
  - `estado`: `"Disponible"` o `"Ocupado"`

#### 🔧 Ejemplos:

- `https://localhost:7187/api/estacionamieto/Espacios?tipo=Rápido`
- `https://localhost:7187/api/estacionamieto/Espacios?estado=Disponible`
- `https://localhost:7187/api/estacionamieto/Espacios?tipo=Full day&estado=Ocupado`

---

## 💰 Tarifas

| Tipo de Vehículo | Full Day (S/) | Rápido (por hora) |
|------------------|----------------|-------------------|
| Auto             | 80             | 10                |
| Bus              | 150            | 15                |
| Moto             | 30             | 3                 |

> La tarifa se cobra al liberar el espacio.

---

## ⚙️ Cómo ejecutar el proyecto en Visual Studio Code

1. Abre Visual Studio Code.
2. Ve a **File → Open Folder...** y selecciona la carpeta raíz del proyecto (donde está el `.csproj`).
3. Instala la extensión **C# for Visual Studio Code** si no la tienes.
4. Abre la terminal (`Ctrl + ñ` o `View > Terminal`) y ejecuta los siguientes comandos:

```bash
dotnet restore
dotnet build
dotnet run
```

5. El servidor se levantará en:  
   `https://localhost:7187`

---

## 📁 Estructura recomendada del proyecto

```
/Estacionamiento
├── Controllers/
│   └── estacionamietoController.cs
├── entitis/
│   ├── Espacio.cs
│   ├── vehiculos.cs
│   └── BaseDatosSimulada.cs
├── Program.cs
├── Estacionamiento.csproj
```

---

## 🧠 Recomendaciones para probar

- ✅ Registra primero un vehículo antes de intentar hacer una reserva.
- ✅ Usa Postman para realizar peticiones fácilmente (GET y POST).
- ✅ Puedes crear una **colección en Postman** con los 5 endpoints y ejemplos listos.
- ✅ Si usas Visual Studio Code, guarda tus peticiones en un archivo `.http` para reutilizarlas.

---

## ✅ Estado del proyecto

- [x] Registro de vehículos  
- [x] Reserva de espacios  
- [x] Liberación y cálculo de tarifas  
- [x] Filtros por tipo y estado de espacios  
- [x] Base de datos simulada en memoria  
- [x] Totalmente funcional con Postman


