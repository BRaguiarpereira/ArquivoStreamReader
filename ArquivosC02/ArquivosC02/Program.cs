using System;
using System.IO;
namespace ArquivosC02
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"E:\C#\Projetos02\ArquivosC02\file1";
           /* FileStream fs = null*/;
            StreamReader sr = null;
            try
            {
                //fs = new FileStream(path, FileMode.Open);
                //outra forma :
                sr = File.OpenText(path);
                // while para ler todas as linha
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
                
            }catch(IOException e)
            {
                Console.WriteLine("Deu erro");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
                //if (fs != null) fs.Close();
            }
        }
    }
}
