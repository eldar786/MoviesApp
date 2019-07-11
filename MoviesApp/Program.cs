using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoviesApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        internal static object SearchByName(object text)
        {
            throw new NotImplementedException();
        }

        public static List<Movie> SearchByName(string text)
        {
            var client = new RestClient("http://www.omdbapi.com");

            var request = new RestRequest("", Method.GET);

            request.AddParameter("s", text);

            request.AddParameter("apikey", "d15aeb59");

            IRestResponse<Movies> response2 = client.Execute<Movies>(request);
            var movies = response2.Data;

            return movies.Search;


        }
        public static Movie GetMovieById(string id)
        {

            var client = new RestClient("http://www.omdbapi.com");

            var request = new RestRequest("", Method.GET);

            request.AddParameter("i", id);

            request.AddParameter("apikey", "d15aeb59");

            IRestResponse<Movie> response2 = client.Execute<Movie>(request);
            var movie = response2.Data;

            return movie;
        }
    }
}
