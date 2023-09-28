namespace Github
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resultFromlevel1 = level1();
            Console.ReadKey();
            level2(resultFromlevel1);
        }

        static string level1()
        {
            Console.WriteLine("Gå vänster eller höger!");
            string answer = Console.ReadLine();
            if (answer == "vänster")
            {
                Console.WriteLine("1000kr");
            }
            else
            {
                Console.WriteLine("500kr");
            }
            return answer;
        }

        public static void level2(string level1result)
        {
            Console.WriteLine("i nivå 1 fick du: " + level1result);
            Console.ReadKey();
            Console.WriteLine("Programmet utmanar du dig i ''Rulla tärning''");
            Console.ReadKey();
            Random random = new Random();
            int playerDice = random.Next(0, 7);
            int programDice = random.Next(0, 7);
            Console.WriteLine("Tryck valfri knapp för att kasta tärningen");
            Console.ReadKey();
            Console.WriteLine("du fick: " + playerDice);
            Console.ReadKey();
            Console.WriteLine("Programmet fick: " + programDice);
            Console.ReadKey();
            if (playerDice < programDice)
            {
                Console.WriteLine("Du tappade alla dina pengar!");
            }
            else
            {
                Console.WriteLine("Du vann!!!");
            }

              
        }
            


    }
}