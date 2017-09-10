using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_27
{
    class LazyItem<T>
    {
        public LazyItem(Func<T> func)
        {
            _func = func;
        }
        public int index;
        private T _item;
        private Func<T> _func;
        public T Item 
        {
            get
            {
                if(index > 0)
                {
                    return _item;
                }
                _item = _func();
                index++;
                return _item;
            }
        }
    }
}
