using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    /// <summary>
    /// Represents a single multi-sided die
    /// </summary>
    class Die
    {
        private byte faceValue;
        private readonly byte numberOfSides;
        private static Random rand;


        /// <summary>
        /// Static constructor - called before any instance constructors.
        /// Needed to initialize static objects.
        /// </summary>
        static Die()
        {
            // Share one instance of Random across ALL
            // instances of the Die class
            rand = new Random();
        }

        /// <summary>
        /// Creates a standard 6-sided die
        /// </summary>
        public Die() : this(6)
        {
        }

        /// <summary>
        /// Creates a die with the specified number of sides
        /// </summary>
        /// <param name="numberOfSides">The number of sides</param>
        public Die(byte numberOfSides)
        {
            this.numberOfSides = numberOfSides;
            Roll();
        }

        public byte FaceValue
        {
            get { return faceValue; }
            private set
            {
                if ( value == 0 )
                {
                    throw new Exception("Die cannot be 0");
                }
                faceValue = value;
            }
        }

        public bool IsHeld { get; set; }


        /// <summary>
        /// Rolls the die, sets face value to generated number,
        /// and returns generated number
        /// </summary>
        public byte Roll()
        {
            // if the die is held, return current face value
            if (IsHeld)
            {
                return FaceValue;
            }

            const byte MinValue = 1;
            // Offset because of exclusive upper bound for random
            byte MaxValue = (byte) (numberOfSides + 1);

            byte result = (byte) rand.Next( MinValue, MaxValue );

            FaceValue = result;

            return result;
        }
    }
}
