using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net_022_FinalTest_SachinAmarasinghe
{
    public class GenericClass<T> where T : struct
    {
        private List<T> valueList;

        // Initialize
        public GenericClass()
        {
            valueList = new List<T>();
        }

        // Add Method
        public void AddItem(T item)
        {
            valueList.Add(item);
        }

        //Return Method
        public T GetItem(int index)
        {
            if (index < 0 || index >= valueList.Count)
            {
                throw new IndexOutOfRangeException("Index is out of range");
            }

            return valueList[index];
        }

        // Return Method - Sort decending
        public List<T> GetSortedDescending()
        {
            List<T> sortedList = valueList.OrderByDescending(x => x).ToList();
            return sortedList;
        }
    }
}
