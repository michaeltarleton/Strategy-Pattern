namespace Strategy_Pattern
{
    internal class Bird : Animal
    {
        public Bird(string name) : base(name)
        {
            FlyingType = new CanFly();
        }
    }
}