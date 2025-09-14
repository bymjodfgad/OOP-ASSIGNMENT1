namespace OOP_ASSIGNMENT1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arv!= (press enter)");
            Console.ReadLine();

            Car theCar = new Car();
            theCar.Drive();

            Console.ReadLine() ;
            Console.WriteLine("Polymorfism! (press enter)");
            Console.ReadLine();
            

            //it just prints the overridden class instead of both
            Shape circle = new Circle();
            circle.Draw();
        }
    }
}

