﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameAI
{
    class RandomList<T>
    {
        Random random = new Random(DateTime.Now.Millisecond);
        List<T> list;
        public RandomList(IList<T> list)
        {
            this.list = new List<T>();
            foreach(var item in list)
                this.list.Add(item);
        }
        public List<T> Randomize()
        {
            List<T> newList = new List<T>();
            int elementCount = this.list.Count;
            while (newList.Count < elementCount)
            {
                int index = random.Next(this.list.Count);
                newList.Add(this.list[index]);
                this.list.RemoveAt(index);
            
            }
            return newList;
        }
    }
}
