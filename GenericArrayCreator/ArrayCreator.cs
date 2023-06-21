using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GenericArrayCreator
{
    public class ArrayCreator<T>
    {
        //T[] array;

        //public ArrayCreator(int lenght)
        //{
        //    array = new T[lenght];
        //}
        public static T[] Create(int length, T item)
        {
           
            T[] array = new T[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = item;
            }
            return array;
        }
    }
}
