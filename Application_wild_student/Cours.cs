using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_wild_student
{
    public class Cours
    {
        private string MonCheminJson = "MonFichierJson.json";
        private string _NomCours;
       // private string _PonderationCours;
        private int _IdentifiantUniqueCours;

        public string NomCours
        {
            get { return _NomCours; }
            set { _NomCours = value; }
        }
        public int Identifiant
            {
               get { return _IdentifiantUniqueCours; }
               set { _IdentifiantUniqueCours = value;}
            }

        public Cours(string NewNomCours) 
        { 
            _NomCours = NewNomCours;
        }

        public void AddCours(string NewCours)
        {
            _NomCours = NewCours;
        }

        public void _CourSaveOnJsonFile()
        {
            List<Cours> CoursExistant = new List<Cours>();

            if (File.Exists(MonCheminJson))
            {
                 string jsonData = File.ReadAllText(MonCheminJson);
                 CoursExistant = JsonConvert.DeserializeObject<List<Cours>>(jsonData) ?? new List<Cours>();

                foreach(var cours in CoursExistant)
                {
                    _IdentifiantUniqueCours = cours.Identifiant + 1;
                }
            }

            CoursExistant.Add(this);
            string MiseAjourJson = JsonConvert.SerializeObject(CoursExistant, Formatting.Indented);
            File.WriteAllText(MonCheminJson, MiseAjourJson);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("    ");
            Console.Write("    ");
            Console.Write($"Le cours a été ajouter avec succès");
            Console.ReadLine();
            Console.ResetColor();

        }


    }
}
