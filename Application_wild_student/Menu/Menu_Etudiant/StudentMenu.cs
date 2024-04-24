using Application_wild_student.Eleve;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_wild_student.Menu.Menu_Etudiant
{
    public class StudentMenu : MenuAttribute
    {
        public void _StudentMenuChoice()
        {
            while (true)
            {
                string OptionMenuEleve;
                bool isValideMenu = false;

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(GlobalAttribute.wildStudent);
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
                        Console.WriteLine(GlobalAttribute.wildStudent);
                        Eleves eleves = new Eleves();
                        eleves.ListerEleve();
                        Console.Read();
                    }
                    else if (ChoixOptionInt == 2)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(GlobalAttribute.wildStudent);
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
                        Console.WriteLine("    ");
                        Console.Write("    ");
                        Console.Write("Saisissez vos notes et appreciations : ...");

                        Console.WriteLine("    ");
                        Console.Write("                   ");
                        Console.Write("Saisissez le cours : ");
                        Console.Write("      ");
                        string Cours = Console.ReadLine() ?? "";
                        Console.Write("                   ");
                        Console.Write("Saisissez la Note : ");
                        Console.Write("      ");
                        string Note = Console.ReadLine() ?? "";
                        Console.Write("                   ");
                        Console.Write("Saisissez l'appreciation' : ");
                        Console.Write("      ");
                        string Appreciation = Console.ReadLine() ?? "";
                        Console.Write("    ");


                        int identifiantCours = 0;
                        Dictionary<int, Dictionary<string, string>> ListeDeNote = new Dictionary<int, Dictionary<string, string>>();
                        ListeDeNote[identifiantCours] = new Dictionary<string, string>
                                           {
                                                 { "Nom", Cours },
                                                 { "Note", Note },
                                                 { "Appréciation", Appreciation }
                                           };

                        Eleves NewEleve = new Eleves();
                        NewEleve.AjouterEleve(NomEleveSet, PreNomEleveSet, DateDeNaissanceEleveSet, ListeDeNote);
                        NewEleve._EleveEnregistrerDonneesJson();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("    ");
                        Console.Write("    ");
                        Console.WriteLine($"Les données de l'élève ont été ajoutées et enregistrées avec succès.");
                        Console.ResetColor();
                        Console.ReadLine();
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
                    Console.WriteLine(GlobalAttribute.wildStudent);
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

    }
}
