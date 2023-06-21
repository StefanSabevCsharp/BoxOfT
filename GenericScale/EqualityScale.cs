using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericScale
{
    public class EqualityScale<T> : IComparable<EqualityScale<T>>
    {
        private T left;
        private T right;
        public EqualityScale(T left,T right)
        {
            this.left = left;
            this.right = right;
        }

        public int CompareTo(EqualityScale<T>? other)
        {
            
            if (this.left.Equals(this.right))
            {
                return 0;
            }
            else if (this.left.GetHashCode() > this.right.GetHashCode())
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
        public bool AreEqual(T left,T right)
        {
            return left.Equals(right);
        }
    }
}
