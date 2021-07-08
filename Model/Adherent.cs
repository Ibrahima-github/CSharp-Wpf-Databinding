using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppDataBindingObjet.Model
{
  public   class Adherent   :INotifyPropertyChanged 
    {
       
        // Un attribut change à l'appel du setter ,
        // A ce moment la classe doit Notifier l'iHM 
        //qui est en liason avec elle

        // profpull + tab + tab
        private int numero;

        public int Numero
        {
            get { return numero; }
            set { numero = value;
                // A chaque appel du setter il y modification de la proprité
                //En ce moment on doit Notifier l'IHM ()
                JaiChange("Numero"); // Annoncer le changement et dire 
                                       //la propriété qui chanage
            }
        }
         
        // 
        private void JaiChange(string vPropriete)
        {
           if (PropertyChanged != null) // S'il y a des souscripteurs
            {
                PropertyChanged(this, new PropertyChangedEventArgs(vPropriete));
            }

             //    PropertyChanged.Invoke(this, new PropertyChangedEventArgs(vPropriete));
        }

        private string nom;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Nom
        {
            get { return nom; }
            set { nom = value;
                JaiChange("Nom");
            }
        }




    }
}
