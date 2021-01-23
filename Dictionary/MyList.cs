using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyList<TE>
    {
        TE[] items;
        public MyList()
        {
            items = new TE[0];
        }
        public void Add(TE item)
        {
            TE[] tempArray = items;
            items = new TE[items.Length+1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }

        public int Length
        {
            get { return items.Length; }
        }

        public TE[] Items
        {
            get { return items; }
        }

    }
}
