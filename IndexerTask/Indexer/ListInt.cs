using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    public class ListInt
    {
        private int[] array;

        public ListInt()
        {
            array = new int[0];
        }

        public int this[int index]
        {
            get
            {
                if (index >= 0 && index < array.Length)
                {

                    return array[index];
                }
                return default;
            }
            set
            {
                if (index >= 0 && index < array.Length)
                {

                    array[index] = value;
                }
            }
        }

        
        public void Add(int num)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = num;
        }

        public void Add(params int[] nums)
        {
            int oldLength = array.Length;
            Array.Resize(ref array, oldLength + nums.Length);
            Array.Copy(nums, 0, array, oldLength, nums.Length);
        }


        public bool Contains(int num)
        {
            return Array.Exists(array, element => element == num); // Exists array daxilindəki elementin var olub oladığını yoxlamaq üçündür.
        }


        public int Pop()
        {
            if (array.Length == 0)
            { return default; }

            int lastElement = array[array.Length - 1];
            Array.Resize(ref array, array.Length - 1);
            return lastElement;
        }


        public int Sum()
        {
            return array.Sum();
        }


        public override string ToString()
        {
            return string.Join(", ", array); // Join array daxilindəki elementləri müəyyən bir ayırıcı ilə birləşdirmək üçün istifadə edilir.
        }


        public int IndexOf(int num)
        {
            return Array.IndexOf(array, num);
        }


        public int LastIndexOf(int num)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] == num)
                {

                    return i;
                }
            }
            return -1; 
        }


        public bool Insert(int num, int index)
        {
            if (index < 0 || index > array.Length)
            {

                return false;
            }

            Array.Resize(ref array, array.Length + 1);
            for (int i = array.Length - 1; i > index; i--)
            {
                array[i] = array[i - 1];
            }
            array[index] = num;
            return true;
        }


        public float Average()
        {
            if (array.Length > 0)
            {
                return (float)Sum() / array.Length;
            }

            return 0; 
        }

    }
}
