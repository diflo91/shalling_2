using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_wild_student.Menu.Menu_Principal
{
    public class ChoiceNotValide : MenuAttribute
    {
        public bool _ChoiceNotValide() 
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(GlobalAttribute.wildStudent);
            Console.ResetColor();
            Console.WriteLine();
            Console.Write("    ");
            Console.WriteLine("[1]. ELEVE ");
            Console.Write("    ");
            Console.WriteLine("[2]. COURS");
            Console.WriteLine("");
            Console.Write("    ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Saisie invalide. Veuillez saisir un nombre : ");
            Console.ResetColor();
            ChoixOption = Console.ReadLine() ?? "";
            Correct = int.TryParse(ChoixOption, out ChoixOptionInt);

            return Correct;
        }
    }
}
