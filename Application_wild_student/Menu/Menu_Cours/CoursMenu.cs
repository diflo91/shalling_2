using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_wild_student.Menu.Menu_Cours
{
    public class CoursMenu : MenuAttribute
    {
        public void _MenuCours()
        {
            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(GlobalAttribute.wildStudent);
                Console.ResetColor();
                Console.WriteLine(" ");
                Console.Write("    ");
                Console.WriteLine("[1]. Lister les cours existants ");
                Console.Write("    ");
                Console.WriteLine("[2]. Ajouter un nouveau cours au programme");
                Console.Write("    ");
                Console.WriteLine("[3]. Supprimer un cours par son identifiant");
                Console.Write("    ");
                Console.WriteLine("[4]. Revenir au menu principal");
                Console.WriteLine("");
                Console.Write("    ");
                Console.Write("Veuillez choisir l'option : ");

                OptionMenuEleve = Console.ReadLine() ?? "";
                isValideMenu = int.TryParse(OptionMenuEleve, out ChoixOptionInt);


                if (isValideMenu)
                {
                    if (ChoixOptionInt == 4)
                    {
                        Console.Clear();
                        break;
                    }
                    else if (ChoixOptionInt == 1)
                    {

                    }
                    else if (ChoixOptionInt == 2)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(GlobalAttribute.wildStudent);
                        Console.ResetColor();
                        Console.WriteLine(" ");
                        Console.Write("    ");
                        Console.Write("Saisissez le nom du cours : ");
                        Console.Write("    ");
                        string NomCoursSet = Console.ReadLine() ?? "";
                        Console.Write("    ");

                    }
                    else if (ChoixOptionInt == 3)
                    {

                    }

                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine();
                        Console.Write("    ");
                        Console.Write("Saisissez les options disponibles, Appuyez enter pour continuer : ... ");
                        Console.ResetColor();
                        OptionMenuEleve = Console.ReadLine() ?? "";
                        isValideMenu = int.TryParse(OptionMenuEleve, out ChoixOptionInt);
                    }
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(GlobalAttribute.wildStudent);
                    Console.ResetColor();
                    Console.WriteLine(" ");
                    Console.Write("    ");
                    Console.WriteLine("[1]. Lister les cours existants ");
                    Console.Write("    ");
                    Console.WriteLine("(2]. Ajouter un nouveau cours au programme");
                    Console.Write("    ");
                    Console.WriteLine("[3]. Supprimer un cours par son identifiant");
                    Console.Write("    ");
                    Console.WriteLine("[4]. Revenir au menu principal");
                    Console.WriteLine("");
                    Console.Write("    ");
                    Console.Write("Veuillez choisir l'option : ");

                    Console.WriteLine();
                    Console.WriteLine("");
                    Console.Write("    ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("! Veuillez saisir un nombre, appuyez sur enter pour continuer : .... ");
                    Console.ResetColor();
                    OptionMenuEleve = Console.ReadLine() ?? "";
                    isValideMenu = int.TryParse(OptionMenuEleve, out ChoixOptionInt);


                }
            }
        }
    }
}
