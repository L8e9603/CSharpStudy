using System;

namespace PartialClass
{
    public partial class Robot
    {
        // partial class 간 생성자 중복 작성 불가능
        /*        public Robot(string name)
                {
                    Name = name;
                }
        */

        // partial class 간 함수 중복 작성 불가능

        /*        public void ShootLaserBeam()
                {
                    Console.WriteLine($"{Name} shooting laser beam!");
                }
        */

        public void Nuke()
        {
            Console.WriteLine($"{Name}: Nuclear lanuch detected");
        }
    }
}
