using Abstract_Factory.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory.Service
{
    internal class RedRogue : IRogue
    {
        private int _health = 6;

        public int Health { get => _health; set => _health = value; }
        public int Atack => 6;


        public string DaggerStab() => $"разбойник бьет кинжалом на {Atack} урона. Его здоровье - {Health}";
    }
}
