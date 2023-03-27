using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityOnClassInCSharp.ActivityOnClass
{
    internal class FileHandling
    {
        string path = "C:\\Users\\HP\\Documents\\Classes\\C#\\ActivityOnClassInCSharp\\ActivityOnClass\\FileHandlingEx\\file.txt";

        public void FileStreamClass()
        {
            FileStream file = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            file.WriteByte(68);
            file.Close();
        }

        public void StreamWriterClass()
        {
            FileStream file = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            //StreamWriter writer = new StreamWriter(file);

            //writer.WriteLine("Hi from stream Writer");
            //writer.Close();
            StreamReader streamReader = new StreamReader(file);

            Console.WriteLine(streamReader.ReadToEnd());

            streamReader.Close();
            file.Close();

        }
        public void TextStreamClass()
        {
            //using (TextWriter textWriter = File.CreateText(path))
            //{
            //    textWriter.WriteLine("HI from textStream");
            //}
            using (TextReader textReader = File.OpenText(path)) { Console.WriteLine(textReader.ReadToEnd()); }
        }

        
        
    }
}
