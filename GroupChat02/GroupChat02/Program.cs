namespace GroupChat02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] menu = new string[] { "1. Play Game", "2. Load Game", "3. Exit" };
            int menuSelection;
            do
            {
                Console.Clear();
                Input.ReadChoice("Choice? ", menu, out menuSelection);
                switch (menuSelection)
                {
                    case 1:
                        break;
                    case 2:
                        string saveGame = string.Empty;
                        Input.ReadString("Enter save game name: ", ref saveGame);
                        break;
                }
            } while (menuSelection != 3);
        }
    }
}