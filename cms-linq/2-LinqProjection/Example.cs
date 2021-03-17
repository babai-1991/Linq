using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMS.UI.Models;

namespace cms_linq._2_LinqProjection
{
    public class Example
    {
        public static void Start()
        {
            //LinqSelect();
            //LinqSelectVariant();
            //LinqSelectAnonymous();
            LinqSelectMany();
        }

        private static void LinqSelectAnonymous()
        {
            var students = StudentList.FetchStudents().Select(stdnt => new
            {
                ID = stdnt.StudentId,
                FullName = stdnt.FirstName + " " + stdnt.LastName
            });

            foreach (var student in students)
            {
                Console.WriteLine($"Student Id {student.ID} FullName is {student.FullName}");
            }
        }

        //only get specific property
        private static void LinqSelectVariant()
        {
            var students = StudentList.FetchStudents().
                                                    Select(stdnt => (stdnt.StudentId, stdnt.FirstName));
            foreach (var student in students)
            {
                Console.WriteLine($"Student Name: {student.FirstName} id {student.StudentId}");
            }
        }

        private static void LinqSelect()
        {
            IEnumerable<Student> students = StudentList.FetchStudents().Select(s => s);
            foreach (var student in students)
            {
                Console.WriteLine($"Student Name: {student.FirstName} {student.LastName}");
            }
        }



        //selectmany example.
        //for this example lets create two classes
        private static void LinqSelectMany()
        {
            //selectmany() has 2 parameters , 1.source 2.result
            List<Gamer> gamers = FetchGamers();
            IEnumerable<Game> games = gamers.SelectMany(gamer => gamer.PlayedGames, (allgames, a) => a);
            foreach (Game game in games)
            {
                Console.WriteLine($"{game.Serial} {game.Name}");
            }

            //select() does not work here 
            //var enumerable = gamers.Select(g => g.PlayedGames);
            //foreach (var gm in enumerable)
            //{
            //    Console.WriteLine(gm);
            //}
        }

        static List<Gamer> FetchGamers()
        {
            var gamer = new Gamer { Name = "Babai" };
            gamer.PlayedGames.Add(new Game("1234", "Hitman"));
            gamer.PlayedGames.Add(new Game("0101", "Fifa"));

            var gamer2 = new Gamer()
            {
                Name = "Tatai",
                PlayedGames = new List<Game>()
                {
                    new Game("1001", "Sands of Time"),
                    new Game("1003", "Two Thrones")
                }
            };
            return new List<Gamer>()
            {
                gamer, gamer2
            };
        }
    }
    public class Gamer
    {
        public Gamer()
        {
            PlayedGames = new List<Game>();
        }
        public string Name { get; set; }
        public List<Game> PlayedGames { get; set; }
    }

    public class Game
    {
        public Game(string serial, string name)
        {
            Serial = serial;
            Name = name;
        }
        public string Serial { get; set; }
        public string Name { get; set; }
    }



}
