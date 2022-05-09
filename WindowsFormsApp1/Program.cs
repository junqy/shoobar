using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            string prompt = @"
███████╗██╗  ██╗ ██████╗  ██████╗ ██████╗  █████╗ ██████╗ 
██╔════╝██║  ██║██╔═══██╗██╔═══██╗██╔══██╗██╔══██╗██╔══██╗
███████╗███████║██║   ██║██║   ██║██████╔╝███████║██████╔╝
╚════██║██╔══██║██║   ██║██║   ██║██╔══██╗██╔══██║██╔══██╗
███████║██║  ██║╚██████╔╝╚██████╔╝██████╔╝██║  ██║██║  ██║
╚══════╝╚═╝  ╚═╝ ╚═════╝  ╚═════╝ ╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═╝                                                            
(Use arrow keys to choose options)
";
            string[] options = { "Graphic", "Console", "Quit"};
            ChoiceMenu mainMenu = new ChoiceMenu(prompt, options);
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new Shoobar());
                    break;
                case 1:
                    Menu menu = new Menu();
                    menu.Start();
                    break;
                case 2:
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }
    }
}
