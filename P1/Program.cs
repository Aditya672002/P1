using System;

namespace Petassignment
{
    class MyPet
    {
        public string PetName { get; set; }
        public string PetType { get; set; }
        public int Hunger { get; set; }
        public int Happiness { get; set; }
        public int Health { get; set; }

        public MyPet(string name, string type)
        {
            PetName = name;
            PetType = type;
            Hunger = 5;
            Happiness = 5;
            Health = 10;
        }

        public void Feed()
        {
            Hunger -= 2;
            Health += 1;
            Console.WriteLine($"You fed {PetName}! Hunger decreased by 2, Health increased by 1.");
        }

        public void Play()
        {
            if (Hunger > 3)
            {
                Happiness += 2;
                Hunger += 1;
                Console.WriteLine($"You played with {PetName}! Happiness increased by 2, Hunger increased by 1.");
            }
            else
            {
                Console.WriteLine($"{PetName} is too hungry to play. Please feed them first!");
            }
        }

        public void Rest()
        {
            Health += 2;
            Happiness -= 1;
            Console.WriteLine($"You let {PetName} rest. Health increased by 2, Happiness decreased by 1.");
        }

        public void CheckStatus()
        {
            Console.WriteLine($"** {PetName}'s Status **");
            Console.WriteLine($"Hunger: {Hunger}/10");
            Console.WriteLine($"Happiness: {Happiness}/10");
            Console.WriteLine($"Health: {Health}/10");

            if (Hunger < 3)
            {
                Console.WriteLine("NOTE: Hunger is critically low!");
            }
            if (Happiness < 3)
            {
                Console.WriteLine("NOTE: Happiness is critically low!");
            }
            if (Health < 5)
            {
                Console.WriteLine("NOTE: Health is critically low!");
            }
        }

        public void SimulateTimePassage()
        {
            Hunger += 1;
            Happiness -= 1;
            Console.WriteLine("Time passed... Hunger increased by 1, Happiness decreased by 1.");
        }
    }

    
}
