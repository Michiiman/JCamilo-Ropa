## 1. Generación del token 🔑:
**Endpoint**: `http://localhost:5272/api/usuario/token`

**Método**: `POST`

**Payload**:

`{
    "Nombre": "Admin",
    "Contraseña": "123"
}`
## 2. Registro de Usuarios 📝:

**Endpoint**: `http://localhost:5272/api/usuario/register`

**Método**: `POST`

**Payload**:

json
`{
    "Usuario": "<nombre_de_usuario>",
    "Contraseña": "<contraseña>",
    "CorreoElectronico": "<correo_electronico>"
}`

## 3. Refresh Token 🔄:

**Endpoint**: `http://localhost:5272/api/usuario/refresh-token`

**Método**: `POST`

**Payload**:

`{
    "Nombre": "<nombre_de_usuario>",
    "Contraseña": "<contraseña>"
}`


## Desarrollo de los Endpoints 

Se desarrollaron dos endpoints, los cuales fueron:

## 1. Listar los proveedores que sean persona natural.

    **Endpoint**: `http://localhost:5272/api/proveedor/ProveedoresNaturales`
    
    **Método**: `GET`

## 3.Listar las prendas agrupadas por el tipo de protección.

    **Endpoint**: `http://localhost:5272/api/prenda/PrendaPorProteccion`
    
    **Método**: `GET`

  ##Metodos Basicos
  Los demas metodos del crud estan funcionando:

  `http://localhost:5272/api/Cargo`,
  `http://localhost:5272/api/Cliente`,
  `http://localhost:5272/api/Color`,
  `http://localhost:5272/api/Departamento`,
  `http://localhost:5272/api/DetalleOrden`,
  `http://localhost:5272/api/DetalleVenta`,
  `http://localhost:5272/api/Empleado`,
  `http://localhost:5272/api/Empresa`,
  `http://localhost:5272/api/Estado`,
  `http://localhost:5272/api/FormaPago`,
  `http://localhost:5272/api/Genero`,
  `http://localhost:5272/api/Insumo`,
  `http://localhost:5272/api/Inventario`,
  `http://localhost:5272/api/Municipio`,
  `http://localhost:5272/api/Orden`,
  `http://localhost:5272/api/Pais`,
  `http://localhost:5272/api/Prenda`,
  `http://localhost:5272/api/Proveedor`,
  `http://localhost:5272/api/Talla`,
  `http://localhost:5272/api/TipoEstado`,
  `http://localhost:5272/api/TipoPersona`,
  `http://localhost:5272/api/TipoProteccion`,
  `http://localhost:5272/api/Venta`.
