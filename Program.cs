namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserInfo user1 = new UserInfo("Jack");
            user1.Jarima();
            

            user1.UserInfo1();
            Console.WriteLine();

            UserInfo user2 = new UserInfo("Lee");
            user2.Jarima();
            

            user2.UserInfo1();

        }
    }
}