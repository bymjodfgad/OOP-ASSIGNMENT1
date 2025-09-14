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

            Console.ReadLine();
            Console.WriteLine("Polymorfism! (press enter)");
            Console.ReadLine();


            //it just prints the overridden class instead of both
            Shape circle = new Circle();
            circle.Draw();
            Console.ReadLine();
            Console.WriteLine("Inkapsling");
            Console.WriteLine();

            User user = new User("Jacob");
            user.SetPassword("password");
            Console.WriteLine(user.VerifyPassword("fel"));    //kommer vara fel
            Console.WriteLine(user.VerifyPassword("password")); //kommer vara rätt 

            Console.ReadLine();
            Console.WriteLine("Abstraktion");
            PaymentMethod payment = new CreditCard();
            payment.Pay(499.99);

            payment = new PayPal();
            payment.Pay(69.99);
        }
    }
}

