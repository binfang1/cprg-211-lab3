namespace Lab3
{
    class Program
    {
        static public void Main(string[] args)
        {
            // Ask user for input and create dog
            Console.WriteLine("Enter dog name: ");
            string dogName = Console.ReadLine();
            Console.WriteLine("Enter dog colour: ");
            string dogColour = Console.ReadLine();
            Console.WriteLine("Enter dog age: ");
            int dogAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter dog height: ");
            int dogHeight = Convert.ToInt32(Console.ReadLine());
            Dog dog = new Dog(dogName, dogColour, dogAge, dogHeight);
            Console.WriteLine($"Dog: Name: {dog.Name} / Colour: {dog.Colour} / Age: {dog.Age} / Height: {dog.Height} ");
            dog.Eat();
            Console.WriteLine(dog.Cry());

            // Ask user for input and create cat
            Console.WriteLine("Enter cat name: ");
            string catName = Console.ReadLine();
            Console.WriteLine("Enter cat colour: ");
            string catColour = Console.ReadLine();
            Console.WriteLine("Enter cat age: ");
            int catAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter cat height: ");
            int catHeight = Convert.ToInt32(Console.ReadLine());
            Cat cat = new Cat(catName, catColour, catAge, catHeight);
            Console.WriteLine($"Cat: Name: {cat.Name} / Colour: {cat.Colour} / Age: {cat.Age} / Height: {cat.Height}");
            cat.Eat();
            Console.WriteLine(cat.Cry());

            // Create list of animals
            List<IAnimal> animals = new List<IAnimal>();
            animals.Add(dog);
            animals.Add(cat);

            // Loop through and print each animal name
            foreach (IAnimal animal in animals)
            {
                Console.WriteLine(animal.Name);
            }
        }
    }
}
