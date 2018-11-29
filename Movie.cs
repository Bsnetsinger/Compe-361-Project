using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieInfoPage
{
    class Movie
    {

        public string Length { get; set; }

        public string Summary { get; set; }

        public string Image { get; set; }

        public string Title { get; set; }

        public static Movie GetMovie()
        {
            var temp = new Movie()
            {
                Length = "2:10",
                Image = "https://m.media-amazon.com/images/M/MV5BY2NkZjEzMDgtN2RjYy00YzM1LWI4ZmQtMjIwYjFjNmI3ZGEwXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_SX667_CR0,0,667,999_AL_.jpg",
                Summary = "The story of Henry Hill and his life in the mob, covering his relationship with his wife Karen Hill and his mob partners Jimmy Conway and Tommy DeVito in the Italian-American crime syndicate.",
                Title = "Goodfellas"
            };

            return temp;

        }


    }
    
}
