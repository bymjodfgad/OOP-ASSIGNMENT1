namespace OOP_ASSIGNMENT1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What do you wanna check?");
            Console.WriteLine("1. Arv");
            Console.WriteLine("2. Polymorfism");
            Console.WriteLine("3. Inkapsling");
            Console.WriteLine("4. Abstraktion");
            int answer = Convert.ToInt32(Console.ReadLine());
            Car theCar = new Car();
            Shape circle = new Circle();
            User user = new User("Jacob");

            switch (answer)
            {
                case 1:
                    //prints class and subclass
                    theCar.Drive();
                    Console.ReadLine();
                    break;
                case 2:
                    //overrides main class
                    circle.Draw();
                    Console.ReadLine();
                    break;
                case 3:
                    user.SetPassword("password");
                    Console.WriteLine(user.VerifyPassword("fel"));    //kommer vara fel
                    Console.WriteLine(user.VerifyPassword("password")); //kommer vara rätt
                    Console.ReadLine();
                    break;
                case 4:
                    PaymentMethod payment = new CreditCard();
                    payment.Pay(499.99);
                    payment = new PayPal();
                    payment.Pay(69.99);
                    Console.ReadLine();
                    break;

            }
            //clears console and resets back to main page
            Console.Clear();
            Main(args);
            
        }
    }
}

