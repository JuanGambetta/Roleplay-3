using System.Collections;

namespace RoleplayGame
{
    public class Archer : Personajes, IPersonaje
    {
        public Archer(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
    }
}