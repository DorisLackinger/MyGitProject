using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGitProject.Daten
{
    public class Schueler
    {
        String name;
        DateTime gebDAt;

        public Schueler(String name, DateTime gebDat)
        {
            Name = name;
            GebDAt = gebDat;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
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
            return name+" geb am "+GebDAt;
        }
    }
}
