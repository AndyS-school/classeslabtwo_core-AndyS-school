﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MexicalTrainDominoes
{
    /// <summary>
    /// This class represents an individual domino
    /// </summary>
    [Serializable()]
    public class Domino
    {
        private int side1;
        private int side2;

        /// <summary>
        /// Default constructor.  Initializes both sides to 0.
        /// </summary>
        public Domino()
        {
            Side1 = 0;
            Side2 = 0;
        }

        /// <summary>
        /// Overloaded constructor.  Uses arguments to initialize each side.
        /// </summary>
        public Domino(int p1, int p2)
        {
            Side1 = p1;
            Side2 = p2;
        }

        // notice that I didn't do an auto implemented property because of the validation in the setter - p 390
        public int Side1
        {
            get
            {
                return side1;
            }
            set
            {
                if (value >= 0 && value <= 12)
                    side1 = value;
                else
                    throw new ArgumentException("Value must be between 0 and 13.");
            }
        }

        /// <summary>
        /// Read/Write property for Side2.
        /// Throws an exception when value is not between 0 and 12
        /// </summary>
        public int Side2
        {
            get
            {
                return side2;
            }
            set
            {
                if (value >= 0 && value <= 12)
                    side2 = value;
                else
                    throw new ArgumentException("Value must be between 0 and 13.");
            }
        }

        public void Flip()
        {
            int temp = side1;
            side1 = side2;
            side2 = temp;
        }

        /* This is how I would have done this in 233N
        public int Score
        {
            get
            {
                return side1 + side2;
            }
        }
        */

        // because it's a read only property, I can use the "expression bodied syntax" or a lamdba expression - p 393
        public int Score => side1 + side2;

        /* ditto for the first version of this method and the next one
        public bool IsDouble()
        {
            if (side1 == side2)
                return true;
            else
                return false;
        }
        */
        public bool IsDouble() => (side1 == side2) ? true : false;

        public override string ToString()
        {
            return String.Format("Side 1: {0}  Side 2: {1}", side1, side2);
        }

        // could you do this one using a lambda expression?
        public string Filename
        {
            get 
            {
                return String.Format("d{0}{1}.png", side1, side2);
            }
        }

        // could you overload the == and != operators?
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            else
            {
                Domino d = (Domino)obj;
                if (d.Side1 == this.Side1 && d.Side2 == this.Side2)
                    return true;
                else
                    return false;
            }
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }
}
