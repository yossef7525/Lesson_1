
namespace TIC_TAC_TOE
{
    class Program
    {
        static void Main()
        {

            int[] users = Users();


            string[] gameUsers = new string[2];
            if (users[0] == 0)
            {

                gameUsers[0] = "x";
                gameUsers[1] = "o";
            }
            else
            {

                gameUsers[0] = "o";
                gameUsers[1] = "x";
            }
            string[] list = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

            bool stopPlay = true;
            int next = 0;

            while (stopPlay)
            {

                Console.Clear();
                Console.WriteLine($"please enter your choice for user {gameUsers[next]}");
                PrintTable(list);

                bool fleg = int.TryParse(Console.ReadLine(), out int num);

                while (!fleg)
                {
                    Console.WriteLine("please enter a number from 1-9:");

                    fleg = int.TryParse(Console.ReadLine(), out num);
                }

                if (num > 0 && num < 10)
                {
                    if (int.TryParse(list[num - 1], out int nn))
                    {
                        list[num - 1] = gameUsers[next];
                        next = (next == 0) ? 1 : 0;
                        stopPlay = Test(list);
                    }
                    else
                    {

                    System.Windows.Forms.MessageBox.Show("אתה לא יכול לבחור ערך שכבר נבחר!!");
                    }
                }
                else
                {
                    Console.WriteLine("please enter a number from 1-9:");
                    fleg = int.TryParse(Console.ReadLine(), out num);
                }
            }
        }

        public static bool Test(string[] list)
        {
            if (Tyko(list)) {
                Console.Clear();
                PrintTable(list);
                Console.WriteLine($"Tyko game is exited!! buy buy!!");
                return false;
            }
            if (list[0] == list[1] && list[1] == list[2])
            {
                Console.Clear();
                PrintTable(list);
                Console.WriteLine($"user *** {list[0]} *** is successfully");
                return false;
            }
            else if (list[3] == list[4] && list[4] == list[5])
            {
                Console.Clear();
                PrintTable(list);
                Console.WriteLine($"user *** {list[3]} *** is successfully");
                return false;
            }
            else if (list[6] == list[7] && list[7] == list[8])
            {
                Console.Clear();
                PrintTable(list);
                Console.WriteLine($"user *** {list[6]} *** is successfully");
                return false;
            }
            else if (list[0] == list[3] && list[3] == list[6])
            {
                Console.Clear();
                PrintTable(list);
                Console.WriteLine($"user *** {list[0]} *** is successfully");
                return false;
            }
            else if (list[1] == list[4] && list[4] == list[7])
            {
                Console.Clear();
                PrintTable(list);
                Console.WriteLine($"user *** {list[1]} *** is successfully");
                return false;
            }
            else if (list[2] == list[5] && list[5] == list[8])
            {
                Console.Clear();
                PrintTable(list);
                Console.WriteLine($"user *** {list[2]} *** is successfully");
                return false;
            }
            else
            {
                return true;
            }
        }

        public static void PrintTable(string[] list)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t *************************");
            Console.WriteLine("\t *  \t * \t * \t *");
            Console.WriteLine($"\t *   {list[0]} \t *   {list[1]} \t *   {list[2]} \t *");
            Console.WriteLine("\t *  \t * \t * \t *");
            Console.WriteLine("\t *************************"); Console.WriteLine("\t *  \t * \t * \t *");
            Console.WriteLine($"\t *   {list[3]} \t *   {list[4]} \t *   {list[5]} \t *");
            Console.WriteLine("\t *  \t * \t * \t *");
            Console.WriteLine("\t *************************"); Console.WriteLine("\t *  \t * \t * \t *");
            Console.WriteLine($"\t *   {list[6]} \t *   {list[7]} \t *   {list[8]} \t *");
            Console.WriteLine("\t *  \t * \t * \t *");
            Console.WriteLine("\t *************************");
            Console.ForegroundColor = ConsoleColor.White;

        }

        public static bool Tyko(string[] list)
        {
            bool flag = true;
            foreach (var item in list)
            {
                if (int.TryParse(item, out int num))
                {
                    flag = false;
                    return flag;
                }
            }
            return flag;
        }

        public static int[] Users()
        {
            int[] users = new int[2];
            bool setUsers = true;
            while (setUsers)
            {
                Console.WriteLine("please enter your choice for user 1:");
                Console.WriteLine("\t *************************");
                Console.WriteLine("\t *   for ~X~ enter 0 \t *");
                Console.WriteLine("\t *************************");
                Console.WriteLine("\t *   for ~O~ enter 1 \t *");
                Console.WriteLine("\t *************************");

                bool fleg = int.TryParse(Console.ReadLine(), out int user1);
                if (fleg)
                {
                    switch (user1)
                    {
                        case 0:
                            users[0] = 0;
                            users[1] = 1;
                            Console.WriteLine($"your selected is: user 1 (x), user 2 (o) ");
                            setUsers = false;
                            break;
                        case 1:
                            users[0] = 1;
                            users[1] = 0;
                            Console.WriteLine($"your selected is: user 1 (o), user 2 (x) ");

                            setUsers = false;
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("your not input 1/0, please try agein");
                            break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("your not input 1/0, please try agein");

                }
            }
            return users;
        }
    }

}