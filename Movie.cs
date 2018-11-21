//Programmer: Cedric Miller
//RedID: 821235643
//File name: Movie.cs (all methods)
//DateCreated: 11/16/2018

//Programmer: 
//RedID: 
//File name:
//DateCreated: 






using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp
{
    class Movie : IComparable<Movie>
    {
        private String Title;
        private String Director;
        private int Length;
        private String Genre;
        private String Synopsis;
        private DateTime ReleaseDate;
        private double Rating;


        public Movie()
        {
            Title = "No title yet";
            Director = "No director yet";
            Length = 0;
            Genre = " No genre yet";
            Synopsis = "No synopsis yet";
            ReleaseDate = DateTime.Now;
            Rating = 0.0;
        }

        public Movie(String title, String director, int length, String genre, String synopsis,
            DateTime releaseDate, double rating)
        {
            Title = title;
            Director = director;
            Length = length;
            Genre = genre;
            Synopsis = synopsis;
            ReleaseDate = releaseDate;
            Rating = rating;

        }

        public String getTitle()
        {
            return Title;
        }

        public String getDirector()
        {
            return Director;
        }

        public int getLength()
        {
            return Length;
        }

        public String getGenre()
        {
            return Genre;
        }

        public String getSynopsis()
        {
            return Synopsis;
        }

        public DateTime getReleaseDate()
        {
            return ReleaseDate;
        }

        public double getRating()
        {
            return Rating;
        }
        public int CompareTo(Movie obj)
        {
            if (obj == null) return 1;

            return this.Title.CompareTo(obj.getTitle());
            
        }

        public Boolean Equals(Movie obj)
        {
            if (obj == null) return false;

            if (this.Title.Equals(obj.getTitle()) && this.Director.Equals(obj.getDirector())
                && this.Length == obj.getLength() && this.Genre.Equals(obj.getGenre())
                && this.ReleaseDate.Equals(obj.getReleaseDate()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
