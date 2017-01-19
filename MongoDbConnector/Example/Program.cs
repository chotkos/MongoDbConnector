using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MongoDbConnector;
using MongoDB.Linq;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            var mp = new MongoProvider(null, "example");

            var profiles = mp.Context.GetCollection<Profile>();
            profiles.Delete(p => true);

            while (true)
            {
                var p = new Profile();
                Console.WriteLine("enter profile name");
                p.Name = Console.ReadLine();
                Console.WriteLine("enter profile age");
                p.Age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("saving profile");
                p.Id = new Oid(Guid.NewGuid().ToString());
                profiles.Insert(p);
                Console.WriteLine("all saved profiles:");
                var all = profiles.Linq().ToList();

                foreach (var prof in all)
                {
                    Console.WriteLine( prof.ToString());
                }
            }
        }
    }
}
