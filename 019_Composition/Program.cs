using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _019_Composition
{
    internal class Program
    {
        static void Main()
        {
            //make new instance for param
            var dbMigrator = new DbMigrator(new Logger());

            //make new variable for param
            var logger = new Logger();
            var installer = new Installer(logger);


            dbMigrator.Migrate();

            installer.Install();

            Console.ReadLine();
        }
    }
}
