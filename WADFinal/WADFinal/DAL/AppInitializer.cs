using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WADFinal.Models;

namespace WADFinal.DAL
{
    public class AppInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SearchAppContext>
    {
        protected override void Seed(SearchAppContext context)
        {
            var developers = new List<Developer>
            {
                new Developer{User="Ubisoft12", Password="PassUbi12", LoggedIn=false, Name="Ubisoft"},
                new Developer{User="EA12", Password="PassEA12", LoggedIn=false, Name="EA"},
                new Developer{User="Blizzard", Password="PassBlizzard12", LoggedIn=false, Name="Blizzard"}
            };
            developers.ForEach(s => context.Developers.Add(s));
            context.SaveChanges();

            var games = new List<Game>
            {
                new Game{DeveloperId = 1, Name="FarCry"},
                new Game{DeveloperId = 2, Name="FIFA"},
                new Game{DeveloperId = 3, Name="Diablo"}
            };
            games.ForEach(s => context.Games.Add(s));
            context.SaveChanges();

            var clients = new List<Client>
            {
                new Client{User="Client1", Password="Pass1", LoggedIn=false},
                new Client{User="Client2", Password="Pass2", LoggedIn=false},
                new Client{User="Client3", Password="Pass3", LoggedIn=false}
            };
            clients.ForEach(s => context.Clients.Add(s));
            context.SaveChanges();

            var reviewers = new List<Reviewer>
            {
                new Reviewer{User="Reviewer1", Password="Pass1", LoggedIn=false},
                new Reviewer{User="Reviewer2", Password="Pass2", LoggedIn=false},
                new Reviewer{User="Reviewer3", Password="Pass3", LoggedIn=false}
            };
            reviewers.ForEach(s => context.Reviewers.Add(s));
            context.SaveChanges();
        }
    }
}