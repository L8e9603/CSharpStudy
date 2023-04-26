using System;

namespace SwapHumanRef
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human();
            Human human2 = new Human();
            //SwapFace(human1, human2);
            SwapHuman(human1, human2);
            //SwapHumanRef(ref human1, ref human2);
        }

        public static void SwapFace(Human h1, Human h2)
        {
            Face temp = h1.GetFace();
            h1.SetFace(h2.GetFace());
            h2.SetFace(temp);
        }

        public static void SwapHuman(Human h1, Human h2)
        {
            Human temp = h1;
            h1 = h2;
            h2 = temp;
        }

        public static void SwapHumanRef(ref Human h1, ref Human h2)
        {
            Human temp = h1;
            h1 = h2;
            h2 = temp;
        }
    }
}