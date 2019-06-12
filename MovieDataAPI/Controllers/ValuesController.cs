using MovieDataAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity.Migrations;

namespace MovieDataAPI.Controllers
{ 
    public class ValuesController : ApiController
    {
        MovieDBEntities db = new MovieDBEntities();

        [HttpGet]
        // GET: api/Values
        public IEnumerable<Movie> Get()
        {
            return db.Movies.ToList();
        }
        [HttpGet]
        //GET api/Values?genre={genre}
        public List<Movie> GetGenre(string genre)
        {
            List<Movie> movies = db.Movies.Where(movi => movi.Genre == genre).ToList();

            return movies;
        }
        [HttpGet]

        public Movie Random()
        {
            Random rnd = new Random();
            int movieRandom = rnd.Next(1, db.Movies.Count());
            Movie m = db.Movies.Find(movieRandom);
            return m;
        }

        //public Movie GetRandom(Random r)
        //{
        //    int movieRandom = rnd.Next(1, 4);
        //    Movie m = db.Movies.Find(movieRandom);
        //    return m;
        //}

        //public Movie Get(string genre)
        //{
        //    List<Movie> movies = new List<Movie>();
        //    Movie mov = (Movie)db.Movies.Where(movi => movi.Genre == genre);
        //    movies.Add(mov);
        //    Random rnd = new Random();
        //    int movieRandom = rnd.Next(1, movies.Count);
        //    Movie randomMovie = db.Movies.Find(movieRandom);

        //    return randomMovie;
        //}

    }
}
