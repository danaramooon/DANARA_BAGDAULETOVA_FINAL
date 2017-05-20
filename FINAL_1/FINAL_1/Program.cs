using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FINAL_1
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\Данара\Desktop\DANARA_BAGDAULETOVA_FINAL\FINAL_1\FINAL_1\bin\Debug\Task1");
            FileInfo[] fl = dir.GetFiles();
            
            StreamReader sr = new StreamReader(@" C: \Users\Данара\Desktop\DANARA_BAGDAULETOVA_FINAL\FINAL_1\FINAL_1\bin\Debug\Task1\file1.txt");
            string[] f1 = sr.ReadToEnd().Split();
           int[] arr = new int[f1.Length];
            for (int i = 0; i < f1.Length; i++)
            {  
                arr[i] = int.Parse(f1[i]);
                Array.Sort(arr);
                int x = Math.Max(arr[0], arr[fl.Length - 1]);
                for (int j = 0; j <= x; j++)
                {
                    if (arr[i] == Math.Pow(2, j))
                    {
                        foreach (FileInfo f in fl)
                        {

                            Console.WriteLine(f.Name + " " +  arr[i]);
                        }
                    }
                }
                
            }
            Console.ReadKey();
            
            //StreamReader sr = new StreamReader(@"C:\Users\Данара\Desktop\DANARA_BAGDAULETOVA_FINAL\Task1\file1.txt");
            //StreamReader sw = new StreamReader(@"C:\Users\Данара\Desktop\DANARA_BAGDAULETOVA_FINAL\Task1\file2.txt");
            //StreamReader sd = new StreamReader(@"C:\Users\Данара\Desktop\DANARA_BAGDAULETOVA_FINAL\Task1\file3.txt");

            //string[] f1 = sr.ReadToEnd().Split();
            //string[] f2 = sw.ReadToEnd().Split();
            //string[] f3 = sd.ReadToEnd().Split();
            //int[] arr1 = new int[f1.Length];
            //int[] arr2 = new int[f2.Length];
            //int[] arr3 = new int[f3.Length];
            //for (int i =0 ; i < f1.Length; i++)
            //{
            //    arr1[i] = int.Parse(f1[i]);
            //    if(arr1[i] == Math.Pow(2,))
            //}



        }
    }
}
