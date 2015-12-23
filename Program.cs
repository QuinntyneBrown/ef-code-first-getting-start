using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework6
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayersDbContext context = new PlayersDbContext();

            var player = context.Players.Where(x => x.Name == "LeBron").First();
 
            Console.WriteLine(player.Name);

            Console.ReadLine();
        }
    }
}
