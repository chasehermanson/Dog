using System;

namespace Program
{
    enum Gender
    {

        Male,
        Female

    }

    class Dog

    {

        protected string owner;
        protected string name;
        protected int age;
        protected Gender gender;
        public Dog(string n, string o, int a, Gender g)

        {

            name = n;
            age = a;
            gender = g;
            owner = o;

        }

        public void Bark(int n)

        {

            for (int count = 0; count < n; count++)

            {

                Console.WriteLine("Woof!");

            }

            Console.ReadLine();

        }

        public void GetTag()

        {

            string j;
            string k;
            string i;
            if (gender == Gender.Male)

            {
                i = "His";
                j = "He";
            }
            else
            {
                i = "Her";
                j = "She";
            }
            if (age == 1)
            {
                k = "Year";
            }
            else
            {
                k = "Years";
            }
            Console.WriteLine("If Lost, Call {0}. {1} Name Is {2} And {3} Is {4} {5} Old.", owner, i, name, j, age, k);
            Console.ReadLine();
        }
    }
    class MakeDog

    {
        static void Main(string[] args)
        {
            Dog p = new Dog("Max", "Ashley", 7, Gender.Female);
            p.Bark(5);
            p.GetTag();

            Dog s = new Dog("Buster", "Michael", 2, Gender.Male);
            s.Bark(2);
            s.GetTag();

            Dog n = new Dog("Lainey", "Roger", 1, Gender.Male);
            n.Bark(7);
            n.GetTag();
        }
    }
}
