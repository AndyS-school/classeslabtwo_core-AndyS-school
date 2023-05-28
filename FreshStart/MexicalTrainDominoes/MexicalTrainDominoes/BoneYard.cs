using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MexicalTrainDominoes
    //yeah i misspelled mexican
{
    public class BoneYard
    {
        private List<Domino> dominoes = new List<Domino>();

        public BoneYard(int maxDots)
        {
            for (int i = 1; i <= maxDots; i++)
                for (int i2 = 1; i2 < maxDots; i2++)
                    dominoes.Add(new Domino(i, i2));
        }

        public int DomCount
        {
            get { return dominoes.Count; }
        }

        public Domino this[int i]
        {
            get { return dominoes[i]; }
            set { dominoes[i] = value; }
        }

        public Domino DrawDeal()
        {
            //cant deal if boneyard is empty
            if (!IsEmpty)
            {
                //saves domino at top of list in a variable
                Domino c = dominoes[0];
                //deletes top index of list
                dominoes.Remove(c);
                //returns saved value
                return c;
            }
            return null;
        }

        public bool IsEmpty
        {
            //sets bool based on whether count == 0 or not
            get { return (dominoes.Count == 0); }
        }

        public void Shuffle()
        {
            Random gen = new Random();
            //increments trough every dominoe in the boneyard
            for(int i = 0; i < DomCount; i++)
            {
                //makes a random index
                int rnd = gen.Next(0, DomCount);
                //saves the domino at random index
                Domino d = dominoes[rnd];
                //sets random domino to value of domino in the current index, and vice versa
                dominoes[rnd] = dominoes[i];
                dominoes[i] = d;
            }
        }

        public override string ToString()
        {
            string output = "";

            foreach (Domino d in dominoes)
                output += (d.ToString() + "/n");
            return output;
        }
    }
}
