using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Bl_sort
{
    class Program:Sort
    {
        static void Main(string[] args)
        {
            Sort vettoreSort=new Sort();
            int[]vettoreProgram=new int[700];
            long[] valTempi = new long[700];
            int[] vett= new int[700];
            Random r = new Random();
            for (int i = 0; i < 700; i++)
            {
                //riempie 
                for (int count = 0; count < vettoreProgram.Length; count++)  //riempimento celle vettore
                {
                    vettoreProgram[count] = r.Next(1000);
                }
                //ordina
                var watch = System.Diagnostics.Stopwatch.StartNew();
                vett=vettoreSort.OrdinaVett(vettoreProgram);
                watch.Stop();
                valTempi[i] = watch.ElapsedMilliseconds;
                    Console.WriteLine(watch.ElapsedMilliseconds);
                    for (int n = 0; n < 700; n++)
                    {
                        Console.Write(" " + vett[n]);
                    }
                    Console.WriteLine("\n");
                }
            long zero = 0;
            for (int i = 0; i < valTempi.Length; i++)
            {
                zero = zero+valTempi[i];
            }
            Console.WriteLine(zero / valTempi.Length);
            Console.ReadLine();
            }
        }
    }

