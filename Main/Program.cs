using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string file1Path = args[0];
            string file2Path = args[1];

            string file1Text = File.ReadAllText(file1Path);
            string file2Text = File.ReadAllText(file2Path);

            if (file1Text == file2Text)
            {
                Console.WriteLine("Two files are equals!");
            }
            else
            {
                Console.WriteLine("Two files are not equals!");
            }
        }
    }
}
