using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Application_wild_student.Eleve
{
    public class Eleves
    {


        private int _IdentifiantUniqueEleve;
        private string _NomEleve;
        private string _PrenomEleve;
        private string _DateDeNaissanceEleve;
        private string _Cours;
        private Dictionary<int, Dictionary<string, string>> _ListDeNote = new Dictionary<int, Dictionary<string, string>>();


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



        public Dictionary<int, Dictionary<string, string>> ListeNote
        {
            get { return _ListDeNote; }
            set { _ListDeNote = value; }
        }


        public void GenIdentifiantEleve()
        {
            _IdentifiantUniqueEleve++;
        }


        public void AjouterEleve(string NewNomEleve, string NewPrenomEleve, string NewDateDeNaissanceEleve, Dictionary<int, Dictionary<string, string>> NewListe/*, double NewMoyenneNoteEleve*/)
        {
            _NomEleve = NewNomEleve;
            _PrenomEleve = NewPrenomEleve;
            _DateDeNaissanceEleve = NewDateDeNaissanceEleve;
            _ListDeNote = NewListe;

        }



        public void _EleveEnregistrerDonneesJson()
        {
            List<Eleves> listeEleves = new List<Eleves>();

            if (File.Exists(GlobalAttribute.MonCheminJson))
            {


                string jsonData = File.ReadAllText(GlobalAttribute.MonCheminJson);
                listeEleves = JsonConvert.DeserializeObject<List<Eleves>>(jsonData) ?? new List<Eleves>();
                foreach (var eleve in listeEleves)
                {
                    _IdentifiantUniqueEleve = eleve.Identifiant + 1;
                }
            }



            listeEleves.Add(this);

            string jsonMiseAJour = JsonConvert.SerializeObject(listeEleves, Formatting.Indented);

            File.WriteAllText(GlobalAttribute.MonCheminJson, jsonMiseAJour);
        }

        public void ListerEleve()
        {

            List<Eleves> listeEleves = new List<Eleves>();
            if (File.Exists(GlobalAttribute.MonCheminJson))
            {
                string jsonData = File.ReadAllText(GlobalAttribute.MonCheminJson);
                listeEleves = JsonConvert.DeserializeObject<List<Eleves>>(jsonData) ?? new List<Eleves>();

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
