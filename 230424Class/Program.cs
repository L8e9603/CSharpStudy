using System;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior warrior = new Warrior("Chuck");

            warrior.Introduce();
            warrior.GetStatus();

            // warrior.Name = "Peter"; // private set 이기 때문에 불가능

            warrior.SwordStrike();
            warrior.UseWhirlwind();
            warrior.UseWhirlwind();
            warrior.UseWhirlwind();
            warrior.GetStatus();

            warrior.Rest();

            warrior.GetStatus();

            warrior.Health -= 200;
            // warrior.mHealth = 5000; // private라서 Warrior 클래스 외부에서 접근 불가능

            warrior.GetStatus();
        }
    }
}