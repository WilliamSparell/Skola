using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayRepetition
{
    public class GenericOneDimensionalArray<T> where T : new()
    {
        private T[] array;
        public GenericOneDimensionalArray(int rows)
        {
            array = new T[rows];
        }
        public int Length
        {
            get { return array.GetLength(0); }
        }
        public T[] GetArray()
        {
            return array;
        }
        public T this[int index]
        {
            get { return GetValue(index); }
            set { SetValue(index, value); }
        }
        public T GetValue(int index)
        {
            if (index > 0 && index < array.GetLength(0))
                return array[index];
            else
                return new T();
        }
        public void SetValue(int index, T value)
        {
            if (index >= array.GetLength(0)) IncreaseArrayRows(index + 1);
            if (index > 0 && index < array.GetLength(0))
                array[index] = value;
        }
        public void IncreaseArrayRows(int rows)
        {
            // Array.Resize(ref array, rows);
            // Samma sak som koden nedan men det är bra att se hur det fungerar
            if (rows > array.GetLength(0))
            {
                var newArr = new T[rows];
                array.CopyTo(newArr, 0);
                array = newArr;
            }
        }
        public void DecreaseArrayRows(int rows)
        {
            // Array.Resize(ref array, rows);
            // Samma sak som koden nedan men det är bra att se hur det fungerar
            if (rows < array.GetLength(0))
            {
                var newArr = new T[rows];
                array.CopyTo(newArr, 0);
                array = newArr;
            }
        }
    }
}
