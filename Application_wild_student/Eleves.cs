using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Application_wild_student
{
    public class Eleves
    {

        private string MonCheminJson = "MonFichierJson.json";
        private int _IdentifiantUniqueEleve;
        private string _NomEleve;
        private string _PrenomEleve;
        private string _DateDeNaissanceEleve;
        private string _Cours;
        private Dictionary<string, double> _ListDeNote = new Dictionary<string, double>();
        // private double _MoyenneNoteEleve;

        public int Identifiant
        {
            get { return _IdentifiantUniqueEleve; }
            set { _IdentifiantUniqueEleve = value; }
        }

        public string NomEleve
        {
            get { return _NomEleve; }
            set { _NomEleve = value; }
        }

        public string PrenomEleve
        {
            get { return _PrenomEleve; }
            set { _PrenomEleve = value; }
        }

        public string DateDeNaissanceEleve
        {
            get { return _DateDeNaissanceEleve; }
            set { _DateDeNaissanceEleve = value; }
        }

        public string Cours
        {
            get { return _Cours; }
            set { _Cours = value; }
        }
        /*
                public Dictionary<string, double> ListeNote
                {
                    get { return _ListDeNote; }
                    set { _ListDeNote = value; }
                }

                public double MoyenneNoteEleve
                {
                    get { return _MoyenneNoteEleve; }
                    set { _MoyenneNoteEleve = value; }
                }
        */
        /*public Eleves(/*string NewNomEleve, string NewPrenomEleve, string NewDateDeNaissanceEleve/*, Dictionary<string, double> NewListDeNote)*/
        /*{
            _NomEleve = NewNomEleve;
            _PrenomEleve = NewPrenomEleve;
            _DateDeNaissanceEleve = NewDateDeNaissanceEleve;
           // _ListDeNote = NewListDeNote;
        }*/


        public void GenIdentifiantEleve()
        {
            _IdentifiantUniqueEleve++;
        }


        public void AjouterEleve(string NewNomEleve, string NewPrenomEleve, string NewDateDeNaissanceEleve, string NewCours /*, Dictionary<string, double> NewListe, double NewMoyenneNoteEleve*/)
        {
            _NomEleve = NewNomEleve;
            _PrenomEleve = NewPrenomEleve;
            _DateDeNaissanceEleve = NewDateDeNaissanceEleve;
            _Cours = NewCours;

        }





        public void _EleveEnregistrerDonneesJson()
        {
            List<Eleves> listeEleves = new List<Eleves>();

            if (File.Exists(MonCheminJson))
            {


                string jsonData = File.ReadAllText(MonCheminJson);
                listeEleves = JsonConvert.DeserializeObject<List<Eleves>>(jsonData) ?? new List<Eleves>();
                foreach (var eleve in listeEleves)
                {
                    _IdentifiantUniqueEleve = eleve.Identifiant + 1;
                }
            }



            listeEleves.Add(this);

            string jsonMiseAJour = JsonConvert.SerializeObject(listeEleves, Formatting.Indented);

            File.WriteAllText(MonCheminJson, jsonMiseAJour);












            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("    ");
            Console.Write("    ");
            Console.WriteLine($"Les données de l'élève ont été ajoutées et enregistrées avec succès.");
            Console.ResetColor();
            Console.ReadLine();
        }



        public void ListerEleve()
        {


           
            List<Eleves> listeEleves = new List<Eleves>();
            if (File.Exists(MonCheminJson))
            {
                string jsonData = File.ReadAllText(MonCheminJson);
                listeEleves = JsonConvert.DeserializeObject<List<Eleves>>(jsonData)?? new List<Eleves>();
                
                foreach (var eleve in listeEleves)
                {
                   
                   
                    Console.WriteLine("    ");
                    Console.Write("    ");
                    Console.Write($"Identifiant:"); Console.ResetColor(); Console.WriteLine($" {eleve.Identifiant}");
                    Console.Write("    ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write($"Nom:"); Console.ResetColor(); Console.WriteLine($" {eleve.NomEleve}");
                    Console.Write("    ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write($"Prénom:"); Console.ResetColor(); Console.WriteLine($" {eleve.PrenomEleve}");
                    Console.Write("    ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write($"Date de naissance:"); Console.ResetColor(); Console.WriteLine($" {eleve.DateDeNaissanceEleve}");
                    
                    Console.WriteLine(); // Ligne vide pour séparer les élèves
                   
                }



            }




        }

    }
}
