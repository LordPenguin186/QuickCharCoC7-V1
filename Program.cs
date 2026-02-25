namespace ProjectQuickCharCoC7
{
    internal class Program
    {
        //3D6 * 5 Stats
        static float STR, CON, DEX, APP, POW, LUCK;
        //2D6 + 6 * 5 Stats
        static float SIZ, INT, EDU;
        static void Main(string[] args)
        {
            GeneratedChar(true);
            ColourCheck(2);
            Console.WriteLine("");
            while (true)
            {
                Console.WriteLine("");
                Console.Write("> ");
                string rawInput = Console.ReadLine();
                string input = rawInput.ToUpper();
                Console.Clear();
                if (input == "")
                {
                    GeneratedChar(true);
                }
                if (input == "STR")
                {
                    STR = D6(3) * 5f;
                    GeneratedChar(false);
                }
                if (input == "CON")
                {
                    CON = D6(3) * 5f;
                    GeneratedChar(false);
                }
                if (input == "DEX")
                {
                    DEX = D6(3) * 5f;
                    GeneratedChar(false);
                }
                if (input == "APP")
                {
                    APP = D6(3) * 5f;
                    GeneratedChar(false);
                }
                if (input == "POW" || input == "SAN")
                {
                    POW = D6(3) * 5f;
                    GeneratedChar(false);
                }
                if (input == "LUCK")
                {
                    LUCK = D6(3) * 5f;
                    GeneratedChar(false);
                }
                if (input == "SIZ")
                {
                    SIZ = (D6(2) + 6) * 5f;
                    GeneratedChar(false);
                }
                if (input == "INT")
                {
                    INT = (D6(2) + 6) * 5f;
                    GeneratedChar(false);
                }
                if (input == "EDU")
                {
                    EDU = (D6(2) + 6) * 5f;
                    GeneratedChar(false);
                }
                Console.WriteLine("");
            }
        }

        static void GeneratedChar(bool reroll)
        {   
            if (reroll == true)
            {
                //Rolling Stats
                STR = D6(3) * 5f;
                CON = D6(3) * 5f;
                DEX = D6(3) * 5f;
                APP = D6(3) * 5f;
                POW = D6(3) * 5f;
                LUCK = D6(3) * 5f;

                SIZ = (D6(2) + 6) * 5f;
                INT = (D6(2) + 6) * 5f;
                EDU = (D6(2) + 6) * 5f;
            }
            Print();
        }

        private static void Print()
        {
            //Strength
            Console.Write("STR: ");
            CheckScore(STR);
            Console.Write($" {STR} \t");
            ColourCheck(2);

            //Size
            Console.Write("SIZ: ");
            CheckScore(SIZ);
            Console.Write($" {SIZ} \n");
            ColourCheck(2);

            //Constitution
            Console.Write("CON: ");
            CheckScore(CON);
            Console.Write($" {CON} \t");
            ColourCheck(2);

            //Willpower
            Console.Write("POW: ");
            CheckScore(POW);
            Console.Write($" {POW} \n");
            ColourCheck(2);

            //Dexterity
            Console.Write("DEX: ");
            CheckScore(DEX);
            Console.Write($" {DEX} \t");
            ColourCheck(2);

            //Appearance
            Console.Write("APP: ");
            CheckScore(APP);
            Console.Write($" {APP} \t");
            ColourCheck(2);

            //Luck
            Console.Write("LUCK: ");
            CheckScore(LUCK);
            Console.Write($"\t {LUCK} \n");
            ColourCheck(2);

            //Intelligence
            Console.Write("INT: ");
            CheckScore(INT);
            Console.Write($" {INT} \t");
            ColourCheck(2);

            //Education
            Console.Write("EDU: ");
            CheckScore(EDU);
            Console.Write($" {EDU} \t");
            ColourCheck(2);

            //Sanity
            Console.Write("SANITY: ");
            CheckScore(POW);
            Console.Write($" {POW} \n");
            ColourCheck(2);

            //Occupational Skill Points
            Console.Write($"\nOccupational Skill Points:\n");

            Console.Write($"[EDU x 4]: \t\t");
            ColourCheck(1);
            Console.Write($" {EDU * 4} \n");
            ColourCheck(2);


            Console.Write($"[EDU x 2 + STR x 2]: \t");
            ColourCheck(1);
            Console.Write($" {(EDU * 2) + (STR * 2)} \n");
            ColourCheck(2);

            Console.Write($"[EDU x 2 + DEX x 2]: \t");
            ColourCheck(1);
            Console.Write($" {(EDU * 2) + (DEX * 2)} \n");
            ColourCheck(2);

            Console.Write($"[EDU x 2 + APP x 2]: \t");
            ColourCheck(1);
            Console.Write($" {(EDU * 2) + (APP * 2)} ");
            ColourCheck(2);


            //Personal Skill Points
            Console.Write($"\n\nPersonal Skill Points: ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write($"\t {INT * 2} ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void ColourCheck(int value)
        {
            if (value == 1)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
            }
            if (value == 2)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        private static void CheckScore(float stat)
        {
            if (stat <= 40)
            {
                Console.ForegroundColor = ConsoleColor.Black; 
                Console.BackgroundColor = ConsoleColor.Red;
            }
            if (stat > 40 && stat <= 65)
            {
                Console.ForegroundColor = ConsoleColor.Black;                
                Console.BackgroundColor = ConsoleColor.Yellow;

            }
            if (stat > 65 && stat < 90)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Green;
            }
            if (stat >= 90)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Cyan;
            }
        }

        static int D6(int amount)
        {
            Random d6 = new Random();
            int total = 0;
            for (int count = 1; count <= amount; count++)
            {
                total += d6.Next(1, 7);
            }
            return total;
        }
    }
}
