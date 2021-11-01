using Abstract_Factory.Interfaces;
using System;

namespace Abstract_Factory.Models
{
    public class CoffeeTable : ICoffeeTable
    {
        public CoffeeTable(string modelo)
        {
            Montar(modelo);
        }

        public string Info { get; private set; }

        public void Montar(string modelo)
        {
            Info = $"Mesa {modelo} pronta.";
        }
    }
}