using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MovieInfoPage
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    /// 

    public partial class MainPage : Page
    {
        Movie movie = new Movie("Goodfellas", "Martin Scor", 130, "Drama",
               "the story of henry hill and his life in the mob, covering his relationship with his wife karen hill and his mob partners jimmy conway and tommy devito in the italian-american crime syndicate.",
               new DateTime(1990, 9, 19), 8.7, "https://m.media-amazon.com/images/M/MV5BY2NkZjEzMDgtN2RjYy00YzM1LWI4ZmQtMjIwYjFjNmI3ZGEwXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_SX667_CR0,0,667,999_AL_.jpg");


        //Movie movie = new Movie("Goodfellas", 130, 
        //       "the story of henry hill and his life in the mob, covering his relationship with his wife karen hill and his mob partners jimmy conway and tommy devito in the italian-american crime syndicate.",
        //        "https://m.media-amazon.com/images/M/MV5BY2NkZjEzMDgtN2RjYy00YzM1LWI4ZmQtMjIwYjFjNmI3ZGEwXkEyXkFqcGdeQXVyNzkwMjQ5NzM@._V1_SX667_CR0,0,667,999_AL_.jpg");

        public MainPage()
        {
            this.InitializeComponent();

           
            

            DataContext = movie;

            
        }

    }
    
}
