using System;

namespace Class
{
    class Warrior
    {
        /// <summary>
        /// 멤버변수, 프로퍼티
        /// </summary>
        public string Name { get; private set; } // 자동으로 구현된 프로퍼티, 멤버변수 선언 필요없음

        private int mHealth = MAX_HEALTH;
        public int Health // 직접 작성한 프로퍼티, 멤버변수 선언 필요, 프로퍼티를 직접 작성하면 getter/setter에 로직 작성 가능
        {
            get
            {
                return mHealth;
            }

            set
            {
                mHealth = value;

                if (mHealth < 0)
                {
                    mHealth = 0;
                }

                if (mHealth > MAX_HEALTH)
                {
                    mHealth = MAX_HEALTH;
                }
            }
        }

        private int mMana = MAX_MANA;
        public int Mana
        {
            get
            {
                return mMana;
            }

            set
            {
                mMana = value;

                if (mMana < 0)
                {
                    mMana = 0;
                }

                if (mMana > MAX_MANA)
                {
                    mMana = MAX_MANA;
                }
            }
        }

        private int mStamina = MAX_STAMINA;
        public int Stamina
        {
            get
            {
                return mStamina;
            }

            set
            {
                mStamina = value;

                if (mStamina < 0)
                {
                    mStamina = 0;
                }

                if (mStamina > MAX_STAMINA)
                {
                    mStamina = MAX_STAMINA;
                }
            }
        }

        private const int MAX_HEALTH = 500;
        private const int MAX_MANA = 50;
        private const int MAX_STAMINA = 200;

        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="name"></param>
        public Warrior(string name)
        {
            Name = name;
        }

        /// <summary>
        /// 멤버함수 (메서드)
        /// </summary>
        public void Introduce()
        {
            Console.WriteLine($"I'm {Name}! Honour and glory! THIS IS SPARTA!!!");
        }

        public void UseWhirlwind()
        {
            if (Mana < 5 || Stamina < 70)
            {
                Console.WriteLine($"{Name} cant't use Whirlwind!");
                return;
            }

            Mana -= 5;
            Stamina -= 70;

            Console.WriteLine($"{Name} used Whirlwind!");
        }

        public void SwordStrike()
        {
            if (Stamina < 20)
            {
                Console.WriteLine($"{Name} cant't use SwordStrike!");
                return;
            }

            Stamina -= 20;

            Console.WriteLine($"{Name} used SwordStrike!");
        }

        public void Rest()
        {
            Health += 5;
            Mana += 2;
            Stamina += 5;

            Console.WriteLine($"{Name} is resting");
        }

        public void GetStatus()
        {
            Console.WriteLine($"{Name} - Health: {Health} / Mana: {Mana} / Stamina: {Stamina}");
        }
    }
}
