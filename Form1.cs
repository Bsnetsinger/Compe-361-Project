using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieInfoPage
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Contructor for info page will produce a page showing info for a given movie. 
        /// Star wars info is coded in for example, eventually a movie object will be sent to the page constructor.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            this.pictureBox1.Image = Properties.Resources.EmpireStrikesBack; //movie.Image;
            this.Title.Text = "Star Wars: The Empire Strikes Back";
            this.Summary.Text = "After the rebels are brutally overpowered by the Empire on the ice planet Hoth, Luke Skywalker begins Jedi training with Yoda, while his friends are pursued by Darth Vader.";
            this.Length.Text = "1:45";
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
