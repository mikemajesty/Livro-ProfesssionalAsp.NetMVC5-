using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Livro_ProfessionalAsp.NetMVC5_.Models
{
    public class MusicStoreDBContextInitializer : DropCreateDatabaseAlways<MusicStoreDBContext>
    {
        public override void InitializeDatabase(MusicStoreDBContext context)
        {
            base.InitializeDatabase(context);
        }
        protected override void Seed(MusicStoreDBContext context)
        {
          
            context.Orders.Add(new Order
            {
                Address = "skdsjdjs",
                City = "sddsdsdd",
                Country = "sddsdsd",
                Email = "mikee_2008@hotmail.com",
                FirstName = "sddsds",
                LastName = "sdsddsdsd",
                OrderDate = DateTime.Now,
                Phone = "sdsdsds",
                PostalCode = "sdsdssd",
                State = "sddsdsd",
                Total = 100,
                Username = "admin"


            });
            context.Artists.Add(new Artist { Name = "Al Di Meola" });
            context.Genres.Add(new Genre { Name = "Jazz" });
            context.Albums.Add(new Album
            {
                Artist = new Artist { Name = "Rush" },
                Genre = new Genre { Name = "Rock" },
                Price = 9.99m,
                Title = "Caravan"
            });
            base.Seed(context);
        }
    }
}