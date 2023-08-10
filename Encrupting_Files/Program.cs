using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Encrupting_Files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReadFile();
            Console.WriteLine("press enter to encrypt the file");
            Console.ReadLine();

            EncryptFiles(@"c:\MLFiles\ml.txt");

            Console.WriteLine("Press enter to decrypt the file ");
            Console.ReadLine();

            DecryptFile(@"c:\MLFiles\ml.txt");
        }

        public static void ReadFile()
        {

            int counter = 0;
            string line;

            //Read the file and display line by line
            System.IO.StreamReader file =
                new System.IO.StreamReader(@"c:\MLFiles\ml.txt");
            while ((line = file.ReadLine()) != null)
                Console.WriteLine(line);
            counter++;

            file.Close();

        }
        public static void EncryptFiles(string x)
        {

            File.Encrypt(x);

        }
        public static void DecryptFile(string x)
        {

            File.Decrypt(x);

        }
    }
}
