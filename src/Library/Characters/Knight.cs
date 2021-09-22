namespace RoleplayGame
{
    public class Knight : IPersonaje
    {
        private int health = 100;

        public Knight(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public Sword Sword { get; set; }

        public Shield Shield { get; set; }

        public Armor Armor { get; set; }

        public int AttackValue
        {
            get
            {
                return Sword.AttackValue;
            }
        }

        public int DefenseValue
        {
            get
            {
                return Armor.DefenseValue + Shield.DefenseValue;
            }
        }

        public int Health
        {
            get
            {
                return this.health;
            }
            private set
            {
                this.health = value < 0 ? 0 : value;
            }
        }

        public int GetAttack()
        {
            return this.AttackValue;
        }

        public void ReceiveAttack(IPersonaje personaje)
        {
            this.Health = this.Health - personaje.GetAttack();
        }

        public void Cure()
        {
            this.Health = 100;
        }
    }
}