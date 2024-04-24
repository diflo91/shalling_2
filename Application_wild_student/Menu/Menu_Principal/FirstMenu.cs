using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_wild_student.Menu.Menu_Principal
{
    public class FirstMenu : MenuAttribute
    {
        public string _MenuPrincipaleApp()
        {
            while (true)
            {
            ChoiceIsValide saisieValide = new ChoiceIsValide();
            saisieValide._ChoiceIsValide();
              
            while (!Correct)
            {
            ChoiceNotValide saisieInValide = new ChoiceNotValide();
            saisieInValide._ChoiceNotValide();

            }
            return ChoixOption;
            } 
        }
    }
}
