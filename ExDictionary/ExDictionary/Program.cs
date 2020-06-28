using System;
using System.Collections.Generic;
using System.IO;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file full path: "); string path = Console.ReadLine();
            try { 
                using (StreamReader sr = File.OpenText(path)) 
                {
                    Dictionary<string, int> candidatos = new Dictionary<string, int>();

                    while (!sr.EndOfStream) 
                    {
                        string[] vetor = sr.ReadLine().Split(',');

                        if (!candidatos.ContainsKey(vetor[0]))
                        {
                            candidatos[vetor[0]] = int.Parse(vetor[1]);
                        }
                        else
                        {
                            candidatos[vetor[0]] += int.Parse(vetor[1]);
                        }
                    }

                    foreach (KeyValuePair<string,int> candidato in candidatos)
                    {
                        Console.WriteLine(candidato.Key + ", " + candidato.Value);
                    }
                } 
            } catch (IOException e) 
            { 
                Console.WriteLine(e.Message); 
            }
        }
    }
}
