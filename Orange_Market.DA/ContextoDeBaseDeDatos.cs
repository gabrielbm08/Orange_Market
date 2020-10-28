using Microsoft.EntityFrameworkCore;
using Orange_Market.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Orange_Market.DA
{
    public class ContextoDeBaseDeDatos : DbContext
    {


        public DbSet<Categoria> Categoria { get; set;  }

        public DbSet<Clientes> Clientes { get; set; }

        public DbSet<Codigo_Comercial_FE> Codigo_Comercial_FE { get; set; }

        public DbSet<Condicion_Venta> Condicion_Ventas { get; set; }

        public DbSet<Datos_Factura_Electronica> Datos_Factura_Electronicas { get; set; }

        public DbSet<Descuento> Descuento { get; set; }

        public DbSet<Historial_Ventas> Historial_Ventas { get; set; }

        public DbSet<Impuesto_FE> Impuesto_FE { get; set; }

        public DbSet<Inventario> Inventario { get; set; }

        public DbSet<Lista_Productos> Lista_Productos { get; set; }

        public DbSet<Medio_Pago_Fe> Medio_Pago_Fe { get; set; }


        public DbSet<Proveedor> Proveedor { get; set; }


        public DbSet<Telefono> Telefono { get; set; }

        public DbSet<Tipo_Documento_Electronico> Tipo_Documento_Electronico { get; set; }

        public DbSet<Tipo_Empleado> Tipo_Empleado { get; set; }

        public DbSet<Tipo_Telefono> Tipo_Telefono { get; set; }

        public DbSet<Transacciones> Transacciones { get; set; }

     

        public DbSet<Unidad_Medida_FE> Unidad_Medida_FE { get; set; }

        public DbSet<Usuario> Usuario { get; set; }

       

        public ContextoDeBaseDeDatos(DbContextOptions<ContextoDeBaseDeDatos> options) : base(options)
        {

        }


    }
}
