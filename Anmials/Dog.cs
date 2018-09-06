namespace Strategy_Pattern
{
    internal class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
            FlyingType = new CantFly();
        }
    }
}