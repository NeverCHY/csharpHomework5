using System;
using System.IO;


namespace Plus100Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            readDate();
            int[] intdate = new int[100];
            string inputstring = readDate();
            string[] inputstrings = inputstring.Split(new char[] { ' ', '\n' });
            int i = 0;
            foreach (string d in inputstrings)
            {
                int.TryParse(d, out intdate[i]);
                i++;
            }
            int s = 0;
            foreach (int d in intdate)
            {
                s += d;
            }
            writeResult(s.ToString());
            Console.WriteLine("Hello World!");
        }
        static string readDate()
        {
            FileStream inputfile = new FileStream(@"input.txt", FileMode.Open, FileAccess.Read, FileShare.Read);
            StreamReader ReadInput = new StreamReader(inputfile);
            string inputDateString = ReadInput.ReadToEnd();
            ReadInput.Close();
            inputfile.Close();
            return inputDateString;
            //string inputDateString;
            //using (FileStream inputfile = new FileStream(@"input.txt", FileMode.Open, FileAccess.Read, FileShare.Read))
            //{
            //    using (StreamReader ReadInput = new StreamReader(inputfile))
            //    { 
            //        inputDateString = ReadInput.ReadToEnd();
            //    }
            //}
            //return inputDateString;
        }
        static void writeResult(string result)
        {
            FileStream Outputfile = new FileStream(@"output.txt", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
            StreamWriter Wr = new StreamWriter(Outputfile);
            Wr.WriteLine(result);
            Wr.Close();
            Outputfile.Close();

        }
    }

}