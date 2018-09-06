namespace Strategy_Pattern
{
    internal abstract class Animal
    {
        public string Name { get; set; }
        public IFly FlyingType { get; set; }

        public Animal(string name)
        {
            Name = name;
        }
    }
}