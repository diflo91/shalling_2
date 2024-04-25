using System.Drawing;

using Application_wild_student.Menu;

using Newtonsoft.Json;

namespace Application_wild_student
{
    public class Program
    {

        static void Main(string[] args)
        { 
            MenuMngt menu = new MenuMngt();
            menu._MenuMngt();

        public static string wildStudent = @"
    ███████╗██╗  ██╗ █████╗ ██╗     ██╗     ██╗███╗   ██╗ ██████╗ 
    ██╔════╝██║  ██║██╔══██╗██║     ██║     ██║████╗  ██║██╔════╝ 
    ███████╗███████║███████║██║     ██║     ██║██╔██╗ ██║██║  ███╗
    ╚════██║██╔══██║██╔══██║██║     ██║     ██║██║╚██╗██║██║   ██║
    ███████║██║  ██║██║  ██║███████╗███████╗██║██║ ╚████║╚██████╔╝
    ╚══════╝╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚══════╝╚═╝╚═╝  ╚═══╝ ╚═════╝ 
                                                                                          Developped by Fleury
    ----------------------------------------------------------------------------------------------------------";

        public static bool Correct = false;
        public static int ChoixOptionInt;
        public static string ChoixOption = "";


        static void Main(string[] args)
        {


            while (true)
            {
                // dConsole.Clear();
                string wildStudent = Program.wildStudent;
                string ChoixOption = Program.ChoixOption;
                bool Correct = Program.Correct;
                int ChoixOptionInt = Program.ChoixOptionInt;

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(wildStudent);
                Console.ResetColor();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.Write("    ");

                Console.WriteLine("[1]. Elève ");
                Console.Write("    ");
                Console.WriteLine("[2]. Cours");
                Console.WriteLine("");
                Console.Write("    ");
                Console.Write("Veuillez choisir l'option : ");

                ChoixOption = Console.ReadLine() ?? "";
                Correct = int.TryParse(ChoixOption, out ChoixOptionInt);




                while (!Correct)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(wildStudent);
                    Console.ResetColor();
                    Console.WriteLine();
                    Console.Write("    ");
                    Console.WriteLine("[1]. Elève ");
                    Console.Write("    ");
                    Console.WriteLine("[2]. Cours");
                    Console.WriteLine("");
                    Console.Write("    ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Saisie invalide. Veuillez saisir un nombre : ");
                    Console.ResetColor();
                    ChoixOption = Console.ReadLine() ?? "";
                    Correct = int.TryParse(ChoixOption, out ChoixOptionInt);
                }

                // Affichage du menu eleve

                if (ChoixOption == "1" && Correct)
                {


                    while (true)
                    {
                        string OptionMenuEleve;
                        bool isValideMenu = false;

                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(wildStudent);
                        Console.ResetColor();
                        Console.WriteLine(" ");
                        Console.Write("    ");
                        Console.WriteLine("[1]. Lister les élèves ");
                        Console.Write("    ");
                        Console.WriteLine("[2]. Créer un nouvel élève");
                        Console.Write("    ");
                        Console.WriteLine("[3]. Consulter un élève existant");
                        Console.Write("    ");
                        Console.WriteLine("[4]. Ajouter une note et une appréciation pour un cours sur un élève existant");
                        Console.Write("    ");
                        Console.WriteLine("[5]. Revenir au menu principal");
                        Console.WriteLine("");
                        Console.Write("    ");
                        Console.Write("Veuillez choisir l'option : ");

                        OptionMenuEleve = Console.ReadLine() ?? "";
                        isValideMenu = int.TryParse(OptionMenuEleve, out ChoixOptionInt);


                        if (isValideMenu)
                        {
                            if (ChoixOptionInt == 5)
                            {
                                Console.Clear();
                                break;
                            }
                            else if (ChoixOptionInt == 1)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine(Program.wildStudent);
                                Eleves eleves = new Eleves();
                                eleves.ListerEleve();
                                Console.Read();

                            }
                            else if (ChoixOptionInt == 2)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine(wildStudent);
                                Console.ResetColor();
                                Console.WriteLine(" ");
                                Console.Write("    ");
                                Console.Write("Saisissez le nom : ");
                                Console.Write("    ");
                                string NomEleveSet = Console.ReadLine() ?? "";
                                Console.Write("    ");
                                Console.Write("Saisissez le prenom : ");
                                Console.Write("    ");
                                string PreNomEleveSet = Console.ReadLine() ?? "";
                                Console.Write("    ");
                                Console.Write("Saisissez la date de naissance : ");
                                Console.Write("    ");
                                string DateDeNaissanceEleveSet = Console.ReadLine() ?? "";
                                Console.Write("    ");
                                Console.Write("Saisissez vos appreciations : ...");
                                Console.Write("    ");
                                string AppreciationEleve = Console.ReadLine() ?? "";
                                Console.Write("    ");



                                Eleves NewEleve = new Eleves();
                                NewEleve.AjouterEleve(NomEleveSet, PreNomEleveSet, DateDeNaissanceEleveSet, AppreciationEleve );
                                // NewEleve.LireDonneesJson();
                                NewEleve._EleveEnregistrerDonneesJson();


                            }
                            else if (ChoixOptionInt == 3)
                            {

                            }
                            else if (ChoixOptionInt == 4)
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
                            Console.WriteLine(wildStudent);
                            Console.ResetColor();
                            Console.WriteLine(" ");
                            Console.Write("    ");
                            Console.WriteLine("[1]. Lister les élèves ");
                            Console.Write("    ");
                            Console.WriteLine("[2]. Créer un nouvel élève");
                            Console.Write("    ");
                            Console.WriteLine("[3]. Consulter un élève existant");
                            Console.Write("    ");
                            Console.WriteLine("[4]. Ajouter une note et une appréciation pour un cours sur un élève existant");
                            Console.Write("    ");
                            Console.WriteLine("[5]. Revenir au menu principal");
                            Console.WriteLine("");
                            Console.Write("    ");
                            Console.WriteLine("Veuillez choisir l'option : ");

                            Console.WriteLine();
                            Console.Write("    ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("! Veuillez saisir un nombre, appuyez sur enter pour continuer : .... ");
                            Console.ResetColor();
                            OptionMenuEleve = Console.ReadLine() ?? "";
                            isValideMenu = int.TryParse(OptionMenuEleve, out ChoixOptionInt);


                        }


                    }

                }
                else if (ChoixOption == "2" && Correct)
                {
                    while (true)
                    {
                        string OptionMenuEleve;
                        bool isValideMenu = false;

                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(wildStudent);
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
                                Console.WriteLine(wildStudent);
                                Console.ResetColor();
                                Console.WriteLine(" ");
                                Console.Write("    ");
                                Console.Write("Saisissez le nom du cours : ");
                                Console.Write("    ");
                                string NomCoursSet = Console.ReadLine() ?? "";
                                Console.Write("    ");

                                Cours NewCours = new Cours(NomCoursSet);
                                NewCours.AddCours(NomCoursSet);
                                // NewEleve.LireDonneesJson();
                                NewCours._CourSaveOnJsonFile();


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
                            Console.WriteLine(wildStudent);
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
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("    ");
                    Console.Write("Saisissez les options disponibles, Appuyez enter pour continuer : ... ");
                    Console.ResetColor();
                    ChoixOption = Console.ReadLine() ?? "";
                    Console.Clear();
                }



            }
>>>>>>> 64f46d9f972fde35267a8afa3ed4ab3fd588755f
        }
    }
}
