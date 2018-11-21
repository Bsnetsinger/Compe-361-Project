//Programmer: Joseph Morga
//RedID: 817281186
//File Name: Buttons.cs
//Date Created: 11/16/2018

// Date last Modified: 
// Programmer: 
// Changes: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace MovieApp
{
    class Buttons : Button
    {
        private Movie movie;

        public Buttons(String nameOfImage, Movie movie, int width, int height)
        {
            string fileName = nameOfImage;
            string path = Path.Combine(Environment.CurrentDirectory, @"Data\", fileName);
            
            this.movie = movie;

            this.Width = width;
            this.Height = height;
            this.Image = new Bitmap(path);
        }

        public Movie getMovie() => movie;

        public void setMovie(Movie movie) { this.movie = movie; }

        public void setImage(string nameOfFile)
        {
            string fileName = nameOfFile;
            string path = Path.Combine(Environment.CurrentDirectory, @"Data\", fileName);
            this.Image = new Bitmap(path);
        }
    }
}
