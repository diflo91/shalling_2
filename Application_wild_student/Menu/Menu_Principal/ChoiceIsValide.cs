using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_wild_student.Menu.Menu_Principal
{
    public class ChoiceIsValide : MenuAttribute
    {
        public bool _ChoiceIsValide() 
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(GlobalAttribute.wildStudent);
            Console.ResetColor();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("    ");
            Console.WriteLine("[1]. ELEVE ");
            Console.Write("    ");
            Console.WriteLine("[2]. COURS");
            Console.WriteLine("");
            Console.Write("    ");
            Console.Write("Veuillez choisir l'option : ");

            ChoixOption = Console.ReadLine() ?? "";
            Correct = int.TryParse(ChoixOption, out ChoixOptionInt);

            return Correct;
        }
    }
}
