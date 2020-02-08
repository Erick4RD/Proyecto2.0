using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyApplication.Models;

namespace EasyApplication.Data
{
    public class DbInitializer
    {

        //busqueda de registro para materias //
        public static void Initialize (EasyApplicationContext context)
        {
            context.Database.EnsureCreated();

            if(context.Categoria.Any())
            {

                return;

            }

            var categoria = new Categoria[]
            {
                //pruebas x2

                new Categoria{Nombre="Programacion",Descripcion="Materia de Programacion",Estado= true},
                 new Categoria{Nombre="Diseño grafico",Descripcion="Materia de Diseño grafico",Estado= true}
            };

            foreach(Categoria c in categoria)
            {
                context.Categoria.Add(c);

            }
            context.SaveChanges();

        }
    }
}
