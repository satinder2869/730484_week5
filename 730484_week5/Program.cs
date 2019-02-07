using System;

namespace _730484_week5
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new testques2();
            a.Play();
        }
    }

    class testques2
    {
        public int myfavvari = 0;
        public void Play()
        {
            //write a for loop

            for (; my();)
            {
                if (myfavvari <= 10)
                    Console.WriteLine("you are fool");
                break;
            }
            Console.WriteLine("shit for loop again");
        }
        public bool my()
        {
            myfavvari++;
            return true;
        }
    }

    class dog
    {
        public dog(string name, string breed)
        {
            dog_name = name;
            dog_breed = breed;
        }
        public string dog_name;
        public string dog_breed;

        public dog next dog;
public dog prev_dog;

    }
    class birthday_party
    {
        public dog peanut;
        public dog fifi;
        public dog clarence;
        public dog roy;

        public dog head;
        public dog tail;
        public dog temporary;
    }
}

