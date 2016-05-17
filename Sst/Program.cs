using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sst
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User();
            user.Id = 3;
            Console.WriteLine(user.Id);
            var item = new Item()
            {
                Id = 6
            };

            Helper.Method1(user.Id, item.Id);

            Console.ReadLine();
        }
    }
}
