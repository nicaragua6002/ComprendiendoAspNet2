using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComprendiendoAspNet2
{
    public class Global
    {
        public static List<Region> Regiones = new List<Region>()
        {
            new Region(1, "Pacifico","Rengion animada")
            ,new Region(2, "Central","Rengion animada")
            ,new Region(3, "Atlantica","Rengion animada")
        };

        public static List<Departamento> Departamentos = new List<Departamento>()
        {
            new Departamento(1,"Managua",1)
            ,new Departamento(2,"Masaya",1)
            ,new Departamento(3,"Granada",1)
            ,new Departamento(4,"Matagalpa",2)
            ,new Departamento(5,"Jinotega",2)
            ,new Departamento(6,"Rio San Juan",3)
        };
        public class Region
        {
            int id;
            string nombre;
            string descripcion;

            public Region(int id, string nombre, string descripcion)
            {
                this.id = id;
                this.nombre = nombre;
                this.descripcion = descripcion;
            }

            public int Id { get => id; set => id = value; }
            public string Nombre { get => nombre; set => nombre = value; }
            public string Descripcion { get => descripcion; set => descripcion = value; }
        }

        public class Departamento
        {
            int id;
            string nombre;
            int idRegion;

            public Departamento(int id, string nombre, int idRegion)
            {
                this.Id = id;
                this.Nombre = nombre;
                this.IdRegion = idRegion;
            }

            public int Id { get => id; set => id = value; }
            public string Nombre { get => nombre; set => nombre = value; }
            public int IdRegion { get => idRegion; set => idRegion = value; }
        }
    }
}