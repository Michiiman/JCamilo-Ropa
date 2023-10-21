using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistencia.Data.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "cargo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SueldoBase = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cargo", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "color",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_color", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "formaPago",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_formaPago", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "genero",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_genero", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "insumo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ValorUnitario = table.Column<int>(type: "int", maxLength: 30, nullable: false),
                    StockMin = table.Column<int>(type: "int", maxLength: 30, nullable: false),
                    StockMax = table.Column<int>(type: "int", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_insumo", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "pais",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pais", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "rol",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    rolName = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rol", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "talla",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_talla", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tipoEstado",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipoEstado", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tipoPersona",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipoPersona", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tipoProteccion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipoProteccion", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "usuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuario", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "departamento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(35)", maxLength: 35, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PaisIdFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_departamento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_departamento_pais_PaisIdFk",
                        column: x => x.PaisIdFk,
                        principalTable: "pais",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "estado",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TipoEstadoIdFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_estado", x => x.Id);
                    table.ForeignKey(
                        name: "FK_estado_tipoEstado_TipoEstadoIdFk",
                        column: x => x.TipoEstadoIdFk,
                        principalTable: "tipoEstado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RefreshToken",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdUsuarioFk = table.Column<int>(type: "int", nullable: false),
                    Token = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Expires = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Revoked = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshToken", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RefreshToken_usuario_IdUsuarioFk",
                        column: x => x.IdUsuarioFk,
                        principalTable: "usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "userRol",
                columns: table => new
                {
                    IdRolFk = table.Column<int>(type: "int", nullable: false),
                    IdUsuarioFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userRol", x => new { x.IdUsuarioFk, x.IdRolFk });
                    table.ForeignKey(
                        name: "FK_userRol_rol_IdRolFk",
                        column: x => x.IdRolFk,
                        principalTable: "rol",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_userRol_usuario_IdUsuarioFk",
                        column: x => x.IdUsuarioFk,
                        principalTable: "usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "municipio",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DepartamentoIdFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_municipio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_municipio_departamento_DepartamentoIdFk",
                        column: x => x.DepartamentoIdFk,
                        principalTable: "departamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "prenda",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ValorUnitCop = table.Column<int>(type: "int", maxLength: 30, nullable: false),
                    ValorUnitUsd = table.Column<int>(type: "int", maxLength: 30, nullable: false),
                    EstadoIdFk = table.Column<int>(type: "int", nullable: false),
                    TipoProteccionIdFk = table.Column<int>(type: "int", nullable: false),
                    GeneroIdFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prenda", x => x.Id);
                    table.ForeignKey(
                        name: "FK_prenda_estado_EstadoIdFk",
                        column: x => x.EstadoIdFk,
                        principalTable: "estado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_prenda_genero_GeneroIdFk",
                        column: x => x.GeneroIdFk,
                        principalTable: "genero",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_prenda_tipoProteccion_TipoProteccionIdFk",
                        column: x => x.TipoProteccionIdFk,
                        principalTable: "tipoProteccion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "cliente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TipoPersonaIdFk = table.Column<int>(type: "int", nullable: false),
                    FechaRegistro = table.Column<DateOnly>(type: "date", maxLength: 30, nullable: false),
                    MunicipioIdFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cliente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_cliente_municipio_MunicipioIdFk",
                        column: x => x.MunicipioIdFk,
                        principalTable: "municipio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_cliente_tipoPersona_TipoPersonaIdFk",
                        column: x => x.TipoPersonaIdFk,
                        principalTable: "tipoPersona",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "empleado",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CargoIdFk = table.Column<int>(type: "int", nullable: false),
                    FechaIngreso = table.Column<DateOnly>(type: "date", maxLength: 20, nullable: false),
                    MunicipioIdFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_empleado", x => x.Id);
                    table.ForeignKey(
                        name: "FK_empleado_cargo_CargoIdFk",
                        column: x => x.CargoIdFk,
                        principalTable: "cargo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_empleado_municipio_MunicipioIdFk",
                        column: x => x.MunicipioIdFk,
                        principalTable: "municipio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "empresa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nit = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RazonSocial = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RepresentanteLegal = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaCreacion = table.Column<DateOnly>(type: "date", maxLength: 20, nullable: false),
                    MunicipioIdFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_empresa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_empresa_municipio_MunicipioIdFk",
                        column: x => x.MunicipioIdFk,
                        principalTable: "municipio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "proveedor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NitProveedor = table.Column<int>(type: "int", maxLength: 30, nullable: false),
                    Nombre = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    TipoPersonaIdFk = table.Column<int>(type: "int", nullable: false),
                    MunicipioIdFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_proveedor", x => x.Id);
                    table.UniqueConstraint("AK_proveedor_NitProveedor", x => x.NitProveedor);
                    table.ForeignKey(
                        name: "FK_proveedor_municipio_MunicipioIdFk",
                        column: x => x.MunicipioIdFk,
                        principalTable: "municipio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_proveedor_tipoPersona_TipoPersonaIdFk",
                        column: x => x.TipoPersonaIdFk,
                        principalTable: "tipoPersona",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "insumoprenda",
                columns: table => new
                {
                    InsumoIdFk = table.Column<int>(type: "int", nullable: false),
                    PrendaIdFk = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_insumoprenda", x => new { x.PrendaIdFk, x.InsumoIdFk });
                    table.ForeignKey(
                        name: "FK_insumoprenda_insumo_InsumoIdFk",
                        column: x => x.InsumoIdFk,
                        principalTable: "insumo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_insumoprenda_prenda_PrendaIdFk",
                        column: x => x.PrendaIdFk,
                        principalTable: "prenda",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "inventario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CodInventario = table.Column<int>(type: "int", maxLength: 30, nullable: false),
                    PrendaIdFk = table.Column<int>(type: "int", nullable: false),
                    ValorVtaCop = table.Column<int>(type: "int", maxLength: 30, nullable: false),
                    ValorVtaUsd = table.Column<int>(type: "int", maxLength: 30, nullable: false),
                    TallaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inventario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_inventario_prenda_PrendaIdFk",
                        column: x => x.PrendaIdFk,
                        principalTable: "prenda",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_inventario_talla_TallaId",
                        column: x => x.TallaId,
                        principalTable: "talla",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "orden",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Fecha = table.Column<DateOnly>(type: "date", maxLength: 30, nullable: false),
                    EmpleadoIdFk = table.Column<int>(type: "int", nullable: false),
                    ClienteIdFk = table.Column<int>(type: "int", nullable: false),
                    EstadoIdFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orden", x => x.Id);
                    table.ForeignKey(
                        name: "FK_orden_cliente_ClienteIdFk",
                        column: x => x.ClienteIdFk,
                        principalTable: "cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_orden_empleado_EmpleadoIdFk",
                        column: x => x.EmpleadoIdFk,
                        principalTable: "empleado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_orden_estado_EstadoIdFk",
                        column: x => x.EstadoIdFk,
                        principalTable: "estado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "venta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Fecha = table.Column<DateOnly>(type: "date", maxLength: 20, nullable: false),
                    EmpleadoIdFk = table.Column<int>(type: "int", nullable: false),
                    ClienteIdFk = table.Column<int>(type: "int", nullable: false),
                    FormaPagoIdFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_venta", x => x.Id);
                    table.ForeignKey(
                        name: "FK_venta_cliente_ClienteIdFk",
                        column: x => x.ClienteIdFk,
                        principalTable: "cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_venta_empleado_EmpleadoIdFk",
                        column: x => x.EmpleadoIdFk,
                        principalTable: "empleado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_venta_formaPago_FormaPagoIdFk",
                        column: x => x.FormaPagoIdFk,
                        principalTable: "formaPago",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "insumoProveedor",
                columns: table => new
                {
                    InsumoIdFk = table.Column<int>(type: "int", nullable: false),
                    ProveedorIdFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_insumoProveedor", x => new { x.InsumoIdFk, x.ProveedorIdFk });
                    table.ForeignKey(
                        name: "FK_insumoProveedor_insumo_InsumoIdFk",
                        column: x => x.InsumoIdFk,
                        principalTable: "insumo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_insumoProveedor_proveedor_ProveedorIdFk",
                        column: x => x.ProveedorIdFk,
                        principalTable: "proveedor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "inventarioTalla",
                columns: table => new
                {
                    InventarioIdFk = table.Column<int>(type: "int", nullable: false),
                    TallaIdFk = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inventarioTalla", x => new { x.TallaIdFk, x.InventarioIdFk });
                    table.ForeignKey(
                        name: "FK_inventarioTalla_inventario_InventarioIdFk",
                        column: x => x.InventarioIdFk,
                        principalTable: "inventario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_inventarioTalla_talla_TallaIdFk",
                        column: x => x.TallaIdFk,
                        principalTable: "talla",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "detalleOrden",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OrdenIdFk = table.Column<int>(type: "int", nullable: false),
                    PrendaIdFk = table.Column<int>(type: "int", nullable: false),
                    CantidadProducir = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    ColorIdFk = table.Column<int>(type: "int", nullable: false),
                    CantidadProducida = table.Column<int>(type: "int", maxLength: 20, nullable: false),
                    EstadoIdFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_detalleOrden", x => x.Id);
                    table.ForeignKey(
                        name: "FK_detalleOrden_color_ColorIdFk",
                        column: x => x.ColorIdFk,
                        principalTable: "color",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_detalleOrden_estado_EstadoIdFk",
                        column: x => x.EstadoIdFk,
                        principalTable: "estado",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_detalleOrden_orden_OrdenIdFk",
                        column: x => x.OrdenIdFk,
                        principalTable: "orden",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_detalleOrden_prenda_PrendaIdFk",
                        column: x => x.PrendaIdFk,
                        principalTable: "prenda",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "detalleVenta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    VentaIdFk = table.Column<int>(type: "int", nullable: false),
                    InventarioIdFk = table.Column<int>(type: "int", nullable: false),
                    TallaIdFk = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<int>(type: "int", maxLength: 30, nullable: false),
                    ValorUnitario = table.Column<int>(type: "int", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_detalleVenta", x => x.Id);
                    table.ForeignKey(
                        name: "FK_detalleVenta_inventario_InventarioIdFk",
                        column: x => x.InventarioIdFk,
                        principalTable: "inventario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_detalleVenta_talla_TallaIdFk",
                        column: x => x.TallaIdFk,
                        principalTable: "talla",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_detalleVenta_venta_VentaIdFk",
                        column: x => x.VentaIdFk,
                        principalTable: "venta",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_cliente_MunicipioIdFk",
                table: "cliente",
                column: "MunicipioIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_cliente_TipoPersonaIdFk",
                table: "cliente",
                column: "TipoPersonaIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_departamento_PaisIdFk",
                table: "departamento",
                column: "PaisIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_detalleOrden_ColorIdFk",
                table: "detalleOrden",
                column: "ColorIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_detalleOrden_EstadoIdFk",
                table: "detalleOrden",
                column: "EstadoIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_detalleOrden_OrdenIdFk",
                table: "detalleOrden",
                column: "OrdenIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_detalleOrden_PrendaIdFk",
                table: "detalleOrden",
                column: "PrendaIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_detalleVenta_InventarioIdFk",
                table: "detalleVenta",
                column: "InventarioIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_detalleVenta_TallaIdFk",
                table: "detalleVenta",
                column: "TallaIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_detalleVenta_VentaIdFk",
                table: "detalleVenta",
                column: "VentaIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_empleado_CargoIdFk",
                table: "empleado",
                column: "CargoIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_empleado_MunicipioIdFk",
                table: "empleado",
                column: "MunicipioIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_empresa_MunicipioIdFk",
                table: "empresa",
                column: "MunicipioIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_estado_TipoEstadoIdFk",
                table: "estado",
                column: "TipoEstadoIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_insumoprenda_Cantidad",
                table: "insumoprenda",
                column: "Cantidad");

            migrationBuilder.CreateIndex(
                name: "IX_insumoprenda_InsumoIdFk",
                table: "insumoprenda",
                column: "InsumoIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_insumoProveedor_ProveedorIdFk",
                table: "insumoProveedor",
                column: "ProveedorIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_inventario_PrendaIdFk",
                table: "inventario",
                column: "PrendaIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_inventario_TallaId",
                table: "inventario",
                column: "TallaId");

            migrationBuilder.CreateIndex(
                name: "IX_inventarioTalla_InventarioIdFk",
                table: "inventarioTalla",
                column: "InventarioIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_municipio_DepartamentoIdFk",
                table: "municipio",
                column: "DepartamentoIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_orden_ClienteIdFk",
                table: "orden",
                column: "ClienteIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_orden_EmpleadoIdFk",
                table: "orden",
                column: "EmpleadoIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_orden_EstadoIdFk",
                table: "orden",
                column: "EstadoIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_prenda_EstadoIdFk",
                table: "prenda",
                column: "EstadoIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_prenda_GeneroIdFk",
                table: "prenda",
                column: "GeneroIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_prenda_TipoProteccionIdFk",
                table: "prenda",
                column: "TipoProteccionIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_proveedor_MunicipioIdFk",
                table: "proveedor",
                column: "MunicipioIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_proveedor_TipoPersonaIdFk",
                table: "proveedor",
                column: "TipoPersonaIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_RefreshToken_IdUsuarioFk",
                table: "RefreshToken",
                column: "IdUsuarioFk");

            migrationBuilder.CreateIndex(
                name: "IX_userRol_IdRolFk",
                table: "userRol",
                column: "IdRolFk");

            migrationBuilder.CreateIndex(
                name: "IX_venta_ClienteIdFk",
                table: "venta",
                column: "ClienteIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_venta_EmpleadoIdFk",
                table: "venta",
                column: "EmpleadoIdFk");

            migrationBuilder.CreateIndex(
                name: "IX_venta_FormaPagoIdFk",
                table: "venta",
                column: "FormaPagoIdFk");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "detalleOrden");

            migrationBuilder.DropTable(
                name: "detalleVenta");

            migrationBuilder.DropTable(
                name: "empresa");

            migrationBuilder.DropTable(
                name: "insumoprenda");

            migrationBuilder.DropTable(
                name: "insumoProveedor");

            migrationBuilder.DropTable(
                name: "inventarioTalla");

            migrationBuilder.DropTable(
                name: "RefreshToken");

            migrationBuilder.DropTable(
                name: "userRol");

            migrationBuilder.DropTable(
                name: "color");

            migrationBuilder.DropTable(
                name: "orden");

            migrationBuilder.DropTable(
                name: "venta");

            migrationBuilder.DropTable(
                name: "insumo");

            migrationBuilder.DropTable(
                name: "proveedor");

            migrationBuilder.DropTable(
                name: "inventario");

            migrationBuilder.DropTable(
                name: "rol");

            migrationBuilder.DropTable(
                name: "usuario");

            migrationBuilder.DropTable(
                name: "cliente");

            migrationBuilder.DropTable(
                name: "empleado");

            migrationBuilder.DropTable(
                name: "formaPago");

            migrationBuilder.DropTable(
                name: "prenda");

            migrationBuilder.DropTable(
                name: "talla");

            migrationBuilder.DropTable(
                name: "tipoPersona");

            migrationBuilder.DropTable(
                name: "cargo");

            migrationBuilder.DropTable(
                name: "municipio");

            migrationBuilder.DropTable(
                name: "estado");

            migrationBuilder.DropTable(
                name: "genero");

            migrationBuilder.DropTable(
                name: "tipoProteccion");

            migrationBuilder.DropTable(
                name: "departamento");

            migrationBuilder.DropTable(
                name: "tipoEstado");

            migrationBuilder.DropTable(
                name: "pais");
        }
    }
}
