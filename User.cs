//Programmer: Joseph Morga
//RedID: 817281186
//File Name: User.cs
//Date Created: 11/16/2018

// Date last Modified: 
// Programmer: 
// Changes: 

using System;
using System.Collections.Generic;

namespace MovieApp
{
    class User : IComparable<User>
    {
        private string username;
        private string firstName;
        private string lastName;
        private string password;
        private LinkedList<Movie> favoriteList;

        public User() { /*Do nothing, just look pretty*/ }

        public User(string username, string firstName, string lastName, string password)
        {
            this.username = username;
            this.firstName = firstName;
            this.lastName = lastName;
            this.favoriteList = new LinkedList<Movie>();
        }

        //--------  Accessor Methods  ---------
        public string getUsername() => username;
        public string getPassword() => password;
        public string getLastName() => lastName;
        public string getFirstName() => firstName;

        //--------  Accessor Methods  ---------

        public void setUsername(string username) { this.username = username; }
        public void setPassword(string password) { this.password = password; }
        public void setLastName(string lastName) { this.lastName = lastName; }
        public void setFirstName(string firstName) { this.firstName = firstName; }

        /// <summary>
        ///     Adds a new Movie object into the movie list
        /// </summary>
        /// <param name="obj"> the Movie object to be added </param>
        /// <returns> Returns true if Movie obj was added, false otherwise </returns>
        public bool addMovie(Movie obj)
        {
            if (favoriteList.Contains(obj))
                return false;

            favoriteList.AddLast(obj);
            return true;
        }

        public void clearFavoriteList() { favoriteList.Clear(); }

        public void removeMovie(Movie obj) { favoriteList.Remove(obj); }

        public int CompareTo(User obj)
        {
            if (obj == null)
                return 1;

            return this.username.CompareTo(obj.getUsername());
        }
    }
}