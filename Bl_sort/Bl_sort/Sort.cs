using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl_sort
{
    class Sort : Interface
    {
        int scambio = 0;
        bool continuaCiclo = true;
        bool swapped = false;
        public int[] OrdinaVett(int[] array)
        {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    for (int j = i; j < array.Length - i - 1; j++)
                    {
                        if (array[j] < array[j + 1])
                        {
                            int tmp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = tmp;
                            swapped = true;
                        }
                    }
                    for (int j = array.Length - 2 - i; j > i; j--)
                    {
                        if (array[j] > array[j - 1])
                        {
                            int tmp = array[j];
                            array[j] = array[j - 1];
                            array[j - 1] = tmp;
                            swapped = true;
                        }
                    }
                    for (int count = 0; count < array.Length - 1; count++)  //controllo generale per fermare il ciclo
                    {
                        if (array[count] <= array[count + 1])
                        {
                            swapped = false;
                        }
                        if (!swapped) break;
                    }

                }
                return array;
            }
          
            
        }
    }

       
   
          
     

