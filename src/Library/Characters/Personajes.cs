using System;
using System.Collections;

namespace RoleplayGame
{
    public class Personajes : Heroes, IPersonaje
    {
        public int health = 100;
        public ArrayList elementos = new ArrayList();
        
        public virtual void AddElemento(IElemento elemento)
        {
            this.elementos.Add(elemento);
        }

        public virtual void RemoveElemento(IElemento elemento)
        {
            this.elementos.Remove(elemento);
        }
        public virtual int AttackValue
        {
            get
            {
                int AttackValueAUX=0;
                foreach (IElemento elemento in elementos)
                {
                    AttackValueAUX= AttackValueAUX+elemento.AttackValue;
                }
                return AttackValue;
            }
        }
        public virtual int DefenseValue
        {
            get
            {
                int DefenseValueAUX=0;
                foreach (IElemento elemento in elementos)
                {
                    DefenseValueAUX= DefenseValueAUX+elemento.DefenseValue;
                }
                return DefenseValue;
            }
        }

        public virtual int Health
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

        public virtual int GetAttack()
        {
            return this.AttackValue;
        }

        public virtual void ReceiveAttack(IPersonaje personaje)
        {
            this.Health = this.Health - personaje.GetAttack();
        }

        public virtual void Cure()
        {
            this.Health = 100;
        }

        public int PV = 0;
    }
}