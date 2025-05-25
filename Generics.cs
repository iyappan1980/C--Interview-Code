using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCode
{
    public class GenericsMethod<T>       
    {
        private T[] _data = new T[10];
        public void Add(int index, T data)
        {
            if(index >= 0 && index < 10)
              _data[index] = data;            
        }
        public T GetData(int index)
        {
            if (index >= 0 && index < 10)            
                return _data[index];            
            else
                return default(T);
        }
    }
    public class DataStore<T>
    {
        public T Data { get; set; }
    }
    public class KeyValuePairClass<Tkey,  TValue>
    {
        public Tkey Key { get; set; }
        public TValue Value { get; set; }

    }

    //Generic Method in Non-generic Class
    public class Printer
    {
        public void Print<T>(T data)
        {
            Console.WriteLine(data);
        }
    }
}
