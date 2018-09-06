using System;

namespace Strategy_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Use default flying behavior
            Animal bird = new Bird("Tweety");
            Animal dog = new Dog("Sparky");

            Console.WriteLine($"{bird.Name}: {bird.FlyingType.fly()}");
            Console.WriteLine($"{dog.Name}: {dog.FlyingType.fly()}");

            // Modify flying types dynamically
            Console.WriteLine();

            bird.FlyingType = new CantFly();
            dog.FlyingType = new CanFly();

            Console.WriteLine($"{bird.Name}: {bird.FlyingType.fly()}");
            Console.WriteLine($"{dog.Name}: {dog.FlyingType.fly()}");
        }
    }
}
