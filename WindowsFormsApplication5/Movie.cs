using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movies
{
   abstract class Movie
    {
        private string Director;
        private string title;
        private int YearMade;
        private string CostofMovie;
        private int CostofTicket;



        
        public Movie(string dname, string Tname, int year, string CMovie, int CTicket)
        {
            Director = dname;
            title = Tname;
            YearMade = year;
            CostofMovie = CMovie;
            CostofTicket = CTicket;
        }

        // Action Movie returns
        public string titles
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }

            
        }
        public int Year
        {
            get
            {
                return YearMade;
            }
            set
            {
                YearMade = value;
            }
        }
        public string ADirector
        {
            get
            {
                return Director;
            }
            set
            {
                ADirector = value;
            }
        }
        public string ACostofmovie
        {
            get
            {
                return CostofMovie;
            }
            set
            {
                CostofMovie = value;
            }
        }
        public int ATicketprice
        {
            get
            {
                return CostofTicket;
            }
            set
            {
                CostofTicket = value;
            }
        }

        // Romantic Movie Returns
        public string Rtitles
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }


        }
        public int RYear
        {
            get
            {
                return YearMade;
            }
            set
            {
                YearMade = value;
            }
        }
        public string RDirector
        {
            get
            {
                return Director;
            }
            set
            {
                RDirector = value;
            }
        }
        public string RCostofmovie
        {
            get
            {
                return CostofMovie;
            }
            set
            {
                CostofMovie = value;
            }
        }
        public int RTicketprice
        {
            get
            {
                return CostofTicket;
            }
            set
            {
                CostofTicket = value;
            }
        }



        //override toString() method
        public override string ToString()
        {
            return title + " " + YearMade;
        }
        public virtual string GetMainCharacter()
        {
            return "Jack Dawson";
        }

        public virtual string BadGuy()
        {
            return "Joker";
        }

        public abstract string lengthofmovie();
    }
}
