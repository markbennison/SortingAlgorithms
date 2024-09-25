/* *************************************************************************** *
 * *************************************************************************** *
 *       __  ___           __       ____                   _                   *
 *      /  |/  /___ ______/ /__    / __ )___  ____  ____  (_)________  ____    *
 *     / /|_/ / __ `/ ___/ //_/   / __  / _ \/ __ \/ __ \/ / ___/ __ \/ __ \   *
 *    / /  / / /_/ / /  / ,<     / /_/ /  __/ / / / / / / (__  ) /_/ / / / /   *
 *   /_/  /_/\__,_/_/  /_/|_|   /_____/\___/_/ /_/_/ /_/_/____/\____/_/ /_/    *
 *                                                                             *
 * *************************************************************************** *
 * *************************************************************************** */

using System.Reflection;

namespace SortingAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            MenuSystem mainmenu = new MenuSystem("Program");

            mainmenu.AddMenuItem("one", "One", typeof(Program));
            mainmenu.AddMenuItem("two", "Two", typeof(Program));
            mainmenu.AddMenuItem("three", "Three", typeof(Program));

            mainmenu.RunForever();

        }

        public static void One()
        {
            Console.WriteLine("ONE WORLD");
        }

        public static void Two()
        {
            Console.WriteLine("TWO WORLD");
        }

        public static void Three()
        {
            Console.WriteLine("THREE WORLD");
        }

    }
}
