using System;
using System.Collections.Generic;
using System.Text;

namespace DualScreenExamples.XF
{
    public class Item
    {
        public Item(string Name, string Description)
        {
            this.Name = Name;
            this.Description = Description;
        }

        public string Name { get; set; }
        public string Description { get; set; }
    }
}
