using RLNET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLikeGame
{
    public class Program
    {
        private static readonly int _screenWidth = 100;
        private static readonly int _screenHeight = 70;
        private static RLRootConsole _rootConsole;
        static void Main(string[] args)
        {
            string fontFileName = "terminal8x8.png";
            string consoleTitle = "RPG - Level 1";
            _rootConsole = new RLRootConsole(fontFileName, _screenWidth, _screenHeight, 8, 8, 1, consoleTitle);
            _rootConsole.Update += OnRootConsoleUpdate;
            _rootConsole.Render += OnRootConsoleRender;
            _rootConsole.Run();
        }

        private static void OnRootConsoleRender(object sender, UpdateEventArgs e)
        {
            _rootConsole.Print(10, 10, "It worked!", RLColor.White);
        }

        private static void OnRootConsoleUpdate(object sender, UpdateEventArgs e)
        {
            _rootConsole.Draw();
        }
    }
}
