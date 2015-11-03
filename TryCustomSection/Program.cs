using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCustomSection
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = ConfigurationManager.GetSection("mySection") as MySection;
            Console.WriteLine(config.Age);
            Console.WriteLine(config.Address.Address1);
            Console.WriteLine(config.Address.PostCode);
            foreach(MemberElement member in config.Members)
                Console.WriteLine(member.FirstName + member.LastName );

            Console.Read();
        }
    }
}
