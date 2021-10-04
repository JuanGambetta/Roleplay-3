using System;

namespace RoleplayGame
{
    public class Orcos : Villanos, IPersonaje
    {
        public Orcos(string name, int pv)
        {
            this.Name = name;
            this.PV = pv;
        }
        public string Name { get; set; }

        public int PV { get; set; }
    }
}