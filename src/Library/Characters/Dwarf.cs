using System.Collections;

namespace RoleplayGame
{
    public class Dwarf  : Personajes, IPersonaje
    {
        public Dwarf(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
    }
}