using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Movies;

namespace WindowsFormsApplication5
{
    class ActionMovie : Movie, Music
    {

        private string violencelevel;
        private string drugusage;


       public ActionMovie(string dname, string Tname, int year, string CMovie, int CTicket, string vilvl, string drguse)
         : base(dname, Tname, year, CMovie, CTicket)
        {
            violencelevel = vilvl;
            drugusage = drguse;
        }

        public override string ToString()
        {
            return titles + " " + Year + " " + "Are Drugs used in the Movie?" + drugusage;
        }

        public override string BadGuy()
        {
            return ("Joker");
        }

        public override string lengthofmovie()
        {
            return "152 minutes";
        }

        public string GetMusicGenre()
        {
            return "Rock";
        }
        public string GetNumberOfSongs()
        {
            return "5";
        }

        
        
        

    }

}