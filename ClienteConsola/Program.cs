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

            var pr = new PrecursorRegular();
            Console.WriteLine($"La meta para un PR es {pr.MetaMensual} horas");

            var pa = new PrecursorAuxiliar
            {
                MetaReducida = true,
                Mes = new List<Mes>
                {
                    Mes.Marzo,
                    Mes.Abril,
                    Mes.Mayo
                }
            };

            Console.WriteLine($"La meta para un PA es {pa.MetaMensual} horas");
        }
    }
}
