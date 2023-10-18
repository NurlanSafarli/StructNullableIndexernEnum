using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructNullableIndexernEnumTask.Models
{
    internal class ListInt
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
                if (index < 0 || index >= array.Length)
                {
                }
                return array[index];
            }
            set
            {
                if (index < 0 || index >= array.Length)
                {
                }
                array[index] = value;
            }
        }

        public void Add(int num)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = num;
        }

        public void AddRange(params int[] nums)
        {
            Array.Resize(ref array, array.Length + nums.Length);
            for (int i = 0; i < nums.Length; i++)
            {
                array[array.Length - nums.Length + i] = nums[i];
            }
        }

        public bool Contains(int num)
        {
            foreach (int item in array)
            {
                if (item == num)
                {
                    return true;
                }
            }
            return false;
        }

        public int Sum()
        {
            return array.Sum();
        }

        public void Remove(int num)
        {
            int index = Array.IndexOf(array, num);
            if (index >= 0)
            {
                for (int i = index; i < array.Length - 1; i++)
                {
                    array[i] = array[i + 1];
                }
                Array.Resize(ref array, array.Length - 1);
            }
        }
        public void RemoveRange(params int[] nums)
        {
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (!nums.Contains(array[i]))
                {
                    array[count] = array[i];
                    count++;
                }
            }

            Array.Resize(ref array, count);
        }

        public override string ToString()
        {
            return string.Join(", ", array);
        }
    }
}