using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_wild_student.Menu
{
    public class ErrorSelection : MenuAttribute
    {
        public void _SelectionErrone()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("    ");
            Console.Write("Saisissez les options disponibles, Appuyez enter pour continuer : ... ");
            Console.ResetColor();
            ChoixOption = Console.ReadLine() ?? "";
            Console.Clear();
        }
    }
}
