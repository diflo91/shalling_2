using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application_wild_student.Menu.Menu_Cours;
using Application_wild_student.Menu.Menu_Etudiant;
using Application_wild_student.Menu.Menu_Principal;

namespace Application_wild_student.Menu
{

    public class MenuMngt :MenuAttribute
    {
        public void _MenuMngt()
        {
         FirstMenu menuPrincipal = new FirstMenu();
            while (true) {

                menuPrincipal._MenuPrincipaleApp();
                if (ChoixOption == "1" && Correct)
                {
                StudentMenu menuEtudiant = new StudentMenu();
                menuEtudiant._StudentMenuChoice();
                }
                else if (ChoixOption == "2" && Correct)
                {
                   
                CoursMenu menuCours = new CoursMenu();
                menuCours._MenuCours();

                }
                else
                {
                ErrorSelection selectionErroné = new ErrorSelection();
                selectionErroné._SelectionErrone();
                }
              }
            }
        }
    }

