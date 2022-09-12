﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    public class Inventory
    {
        #region Fields
        private int _capacity = 0;
        private List<string> _items = new List<string>();
        #endregion

        #region Properties
        public int Capacity { 
            get { return _capacity; } 
            set { 
                if(value > 0)
                    _capacity = value; 
            } 
        }

        public int Count
        {
            get { return _items.Count; }
        }

        public List<string> Items
        {
            get { return _items; }
            private set { _items = value; }
        }
        #endregion

        #region Constructors
        public Inventory(int capacity, List<string> items)
        {
            Capacity = capacity;
            Items = items.ToList();//clone it so you have your own COPY of the list
        }
        #endregion
    }
}
