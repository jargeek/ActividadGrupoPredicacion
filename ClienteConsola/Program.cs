using API;
using API.Modelos;
using System;
using System.Collections.Generic;

namespace ActividadGrupoServicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var manager = new PublicadorManager();

            manager.CrearPublicador(new Publicador
            {
                Nombres = "Miriam",
                Apellidos = "Cruz",
                FechaNacimiento = new DateTime(1996, 03, 15),
                Bautizado = true,
                FechaBautismo = new DateTime(2005, 10, 08),
                Ungido = false,
                Direccion = "Av Jardin 10, Fracc. El Tejocote, Texcoco, Estado de México",
                Telefono = "5545307128"
            });

            manager.CrearPublicador(new Publicador
            {
                Nombres = "Guersom",
                Apellidos = "González",
                FechaNacimiento = new DateTime(1996, 02, 07),
                Bautizado = true,
                FechaBautismo = new DateTime(2001, 08, 11),
                Ungido = false,
                Direccion = "Av Jardin 10, Fracc. El Tejocote, Texcoco, Estado de México",
                Telefono = "5545307128"
            });


            //manager.Publicador(id);
            //manager.ActualizarPublicador(publicador);
            //manager.BorrarPublicador(publicador);

            //manager.Publicadores();
            //manager.PublicadoresInactivos();
            //manager.PrecursoresRegulares();
            //manager.PrecursoresAuxiliares();
            //manager.PublicadoresIrregulares();
        }
    }
}
