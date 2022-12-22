using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace home_task1
{
    public class IntArray
    {
        int[] init = new int[0];
        int counter = 0;

        public IntArray(int initSize)
        {
            this.init = new int[initSize];
            this.counter = 0;
        }

        public void Add(int element){
            Array.Resize(ref init, this.counter + 1);   // подсмотрено в лекции 0_о
            init[this.counter] = element;
            this.counter++;
        }

        public int[] Pack () {
            int[] intArr = this.init;
            int[] packed = new int[intArr.Length];
            for (int i = 0; i < intArr.Length; i++)
            {
                packed[i] = intArr[i];
            }
            return packed;
        }
    }
}