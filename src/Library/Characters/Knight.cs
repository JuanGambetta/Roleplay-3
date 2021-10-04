using System.Collections;

namespace RoleplayGame
{
    public class Knight : Personajes, IPersonaje
    {
        public Knight(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
    }
}