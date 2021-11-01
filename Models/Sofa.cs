using Abstract_Factory.Interfaces;
using System;

namespace Abstract_Factory.Models
{
    public class Sofa : ISofa
    {
        public Sofa(string modelo)
        {
            Montar(modelo);
        }

        public string Info { get; private set; }

        public void Montar(string modelo)
        {
            Info = $"Sofa {modelo} pronto.";
        }
    }
}
