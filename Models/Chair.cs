using Abstract_Factory.Interfaces;
using System;

namespace Abstract_Factory.Models
{
    public class Chair : IChair
    {
        public Chair(string modelo)
        {
            Montar(modelo);
        }

        public string Info { get; private set; }

        public void Montar(string modelo)
        {
            Info = $"Cadeira {modelo} pronta.";
        }
    }
}