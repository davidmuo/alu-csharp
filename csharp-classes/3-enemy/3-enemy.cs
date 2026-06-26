using System;

namespace Enemies
{
    /// <summary>Defines a zombie enemy.</summary>
    public class Zombie
    {
        private int health;

        /// <summary>Initializes a new Zombie with 0 health.</summary>
        public Zombie()
        {
            health = 0;
        }

        /// <summary>Initializes a new Zombie with the given health value.</summary>
        /// <param name="value">Health value; must be >= 0.</param>
        public Zombie(int value)
        {
            if (value < 0)
                throw new ArgumentException("Health must be greater than or equal to 0");
            health = value;
        }

        /// <summary>Returns the health of the zombie.</summary>
        public int GetHealth()
        {
            return health;
        }
    }
}
