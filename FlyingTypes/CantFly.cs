namespace Strategy_Pattern
{
    internal class CantFly : IFly
    {
        public string fly()
        {
            return "I can't fly";
        }
    }
}