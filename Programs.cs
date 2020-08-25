using System;
using System.Collections.Generic;
using System.Text;

namespace oop_6115261027_w05
{
    class Programs
    {
        private string programsName;
        private string programsRank;


        public string Programsname
        {
            get { return programsName; }
            set { programsName = value; }
        }

        public string Programsnank
        {
            get { return programsRank; }
            set { programsRank = value; }
        }

        public Programs(string pn, string pg)
        {
            this.programsName = pn;
            this.programsRank = pg;


        }
        public override string ToString()
        {
            return this.programsRank + this.programsName;
        }
    }
}