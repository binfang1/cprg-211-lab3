namespace Lab3
{
    public abstract class Animal
    {
        private string _name;
        private string _colour;
        private int _age;
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string Colour
        {
            get { return _colour; }
            set { _colour = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public abstract void Eat();

        public Animal(string name, string colour, int age)
        {
            Name = name;
            Colour = colour;
            Age = age;
        }

    }
}






