namespace Lab3
{   /*
    Part 1

    public class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Dogs eat meat.");
        }

        public Dog(string name, string colour, int age) : base(name, colour, age)
        {

        }
    }
    */

    public class Dog : IAnimal
    {
        public string Name { get; set; }
        public string Colour { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }

        public Dog(string name, string colour, int age, int height)
        {
            Name = name;
            Colour = colour;
            Age = age;
            Height = height;
        }

        public void Eat()
        {
            Console.WriteLine("Dogs eat meat.");
        }

        public string Cry()
        {
            return "Woof!";
        }

    }
}




