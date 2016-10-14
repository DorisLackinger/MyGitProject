using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGitProject.Daten
{
    public class Schueler
    {
        String nachname;
        DateTime gebDAt;
        List<int> noten=new List<int>();

        public Schueler(String name, DateTime gebDat)
        {
            Nachname = name;
            GebDAt = gebDat;
        }

        public string Nachname
        {
            get
            {
                return nachname;
            }

            set
            {
                nachname = value;
            }
        }

        public DateTime GebDAt
        {
            get
            {
                return gebDAt;
            }

            set
            {
                gebDAt = value;
            }
        }
        public override string ToString()
        {
            return nachname+" geb am "+GebDAt;
        }
    }
}
