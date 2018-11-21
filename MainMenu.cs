//Programmer: Joseph Morga
//RedID: 817281186
//File Name: MainMenu.cs
//Date Created: 11/16/2018

// Date last Modified: 
// Programmer: 
// Changes: 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MovieApp
{
    public partial class MainMenu : Form
    {
        private readonly int ARRAY_WIDTH = 7;
        private readonly int ARRAY_HEIGHT = 5;
        private readonly int BUTTON_WIDTH = 50;
        private readonly int BUTTON_HEIGHT = 100;

        private Buttons[,] button;
        public MainMenu()
        {
            InitializeComponent();
            button = new Buttons[ARRAY_HEIGHT, ARRAY_WIDTH];

            string imageName = "test.jpg"; // Name of the image for the button


            //Adding buttons to window
            for (int i = 0; i < ARRAY_HEIGHT; i++)
                for (int j = 0; j < ARRAY_WIDTH; j++)
                {
                    button[i, j] = new Buttons(imageName, new Movie(), BUTTON_WIDTH, BUTTON_HEIGHT)
                    {
                        Location = new Point((BUTTON_WIDTH + 15) * j, (BUTTON_HEIGHT + 15) * i)
                    };
                    this.Controls.Add(button[i, j]);
                }
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}
