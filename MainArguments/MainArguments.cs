using System;

namespace MainArguments
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i=0; i<args.Length; ++i)
            {
                Console.WriteLine($"args[{i}] = {args[i]}");
            }

            Divide(0f, 1f);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="numerator"></param>
        /// <param name="denominator"></param>
        /// <returns></returns>
        static float Divide(float numerator, float denominator)
        {
            return numerator / denominator;
        }
    }
}