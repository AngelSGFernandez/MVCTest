using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCTest.Models
{
    public class MockAmigoRepositorio: IAmigoAlmacen
    {
        private List<Amigo> amigosLista;

        public MockAmigoRepositorio()
        {
            amigosLista = new List<Amigo>();
            amigosLista.Add(new Amigo() { Id = 1, Nombre = "Angel", Ciudad = "Monterrey", Email = "angel@mail.com" });
            amigosLista.Add(new Amigo() { Id = 2, Nombre = "Salvador", Ciudad = "Garcia", Email = "Salvador@mail.com" });
            amigosLista.Add(new Amigo() { Id = 3, Nombre = "Garcia", Ciudad="Guadalup", Email = "garcia@mail.com" });
        }

        public Amigo dameDatosAmigo(int Id)
        {
            return this.amigosLista.FirstOrDefault(e => e.Id == Id);
        }
    }
}
