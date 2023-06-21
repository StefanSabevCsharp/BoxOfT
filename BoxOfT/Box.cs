using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxOfT
{
    public class Box<T>
    {
        int count = 0;
        public List<T> boxes;
        
        public int Count { get; }
        public Box()
        {
              boxes = new List<T>();
        }

        public void Add(T box)
        {
            boxes.Add(box);
            count++;
        }
        public T Remove()
        {
            T box = boxes.Last();
            boxes.RemoveAt(boxes.Count - 1);
            count--;
            return box;
            
            
        }
    }
}
