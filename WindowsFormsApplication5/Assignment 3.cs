using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Movies;
using Musics;
using ActionMovies;
using RomanticMovies;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        ActionMovie actobj;
        RomanticMovie romobj;



        public Form1()
        {
            InitializeComponent();
            actobj = new ActionMovie("Terence Young", "From Russia With Love", 1964, "79 Million", 1, "Are Drugs used in the Movie?", "Is there a lot of Violence");
            romobj = new RomanticMovie("James Cameron", "Titanic", 1997, "200 million", 8, "Is there sexual content", "Do they use fowl language");
        }

        private void btAction_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(actobj.ToString());
            //director
            tbxADirector.Text = actobj.ADirector.ToString();
            //title
            tbxATitle.Text = actobj.titles.ToString();
            //year made
            tbxAYear.Text = actobj.Year.ToString();
            //cost to make movie
            tbxACost.Text = actobj.ACostofmovie.ToString();
            //cost of ticket
            tbxATicket.Text = actobj.ATicketprice.ToString();
            
        }

        private void btRomantic_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(romobj.ToString());
            //director
            tbxRDirector.Text = romobj.ADirector.ToString();
            //title
            tbxRTitle.Text = romobj.titles.ToString();
            //year made
            tbxRYear.Text = romobj.Year.ToString();
            //cost to make movie
            tbxRCost.Text = romobj.ACostofmovie.ToString();
            //cost of ticket
            tbxRTicket.Text = romobj.ATicketprice.ToString();

        }

        private void btMusic_Click(object sender, EventArgs e)
        {
            // action movie Genre
            tbxActionGenre.Text = actobj.GetMusicGenre();

            //Romantic Movie Genre
            tbxRomanticGenre.Text = romobj.GetMusicGenre();

            //Action Movie Songs Number
            tbxActionSong.Text = actobj.GetNumberOfSongs();

            //Romantic Movie Songs Number
            tbxRomanticSong.Text = romobj.GetNumberOfSongs();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
