namespace Lab3
{
    /*

    Part 1

    public class Cat : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Cats eat mice.");
        }

        public Cat(string name, string colour, int age) : base(name, colour, age)
        {

        }
    } */

    public class Cat : IAnimal
    {
        public string Name { get; set; }
        public string Colour { get; set; }
        public int Age { get; set; }
        public int Height { get; set; }

        public Cat(string name, string colour, int age, int height)
        {
            Name = name;
            Colour = colour;
            Age = age;
            Height = height;
        }

        public void Eat()
        {
            Console.WriteLine("Cats eat mice.");
        }

        public string Cry()
        {
            return "Meow!";
        }

    }
}
