using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MexicalTrainDominoes;

namespace CardTests
{
    class Program
    {
        static void Main(string[] args)
        {
            TestDominoConstructor();
            TestDominoShuffle();
            TestDominoDeal();

            Console.ReadLine();
        }

        static void TestDominoConstructor()
        {
            BoneYard d = new BoneYard(6);

            Console.WriteLine("Testing deck of cards default constructor");
            Console.WriteLine("NumCards.  Expecting 30. " + d.DomCount);
            Console.WriteLine("IsEmpty.   Expecting false. " + d.IsEmpty);
            Console.WriteLine("ToString.  Expect a ton of dominoes in order.\n" + d.ToString());
            Console.WriteLine();
        }

        static void TestDominoShuffle()
        {
            BoneYard d = new BoneYard(6);
            d.Shuffle();
            Console.WriteLine("Testing deck of cards shuffle");
            Console.WriteLine("NumCards.  Expecting 30. " + d.DomCount);
            Console.WriteLine("IsEmpty.   Expecting false. " + d.IsEmpty);
            Console.WriteLine("First Domino will rarely be 1/1. " + d[0]);
            Console.WriteLine("ToString.  Expect a ton of Dominoes in shuffled order.\n" + d.ToString());
            Console.WriteLine();
        }

        static void TestDominoDeal()
        {
            BoneYard d = new BoneYard(6);
            Domino c = d.DrawDeal();

            Console.WriteLine("Testing dominoes deal");
            Console.WriteLine("NumCards.  Expecting 29. " + d.DomCount);
            Console.WriteLine("IsEmpty.   Expecting false. " + d.IsEmpty);
            Console.WriteLine("Dealt Domino should be 1/1. " + c);

            // now let's deal them all and see what happens at the end
            for (int i = 1; i <= 51; i++)
                c = d.DrawDeal();
            Console.WriteLine("Dealt all 30 dominoes");
            Console.WriteLine("NumCards.  Expecting 0. " + d.DomCount);
            Console.WriteLine("IsEmpty.   Expecting true. " + d.IsEmpty);
            Console.WriteLine("Last Card should be 6/6" + c);
            Console.WriteLine("Dealing again should return null. Expecting true. " + (d.DrawDeal() == null));

            Console.WriteLine();
        }
    }
}
