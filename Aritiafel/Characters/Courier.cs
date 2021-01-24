﻿using System;
using System.Collections.Generic;
using System.Text;
using Aritiafel.Items;

namespace Aritiafel.Characters
{
    public class Courier //Message/Object Carrier
    {
        public string Name { get; set; }

        public Package Package { get; set; }
        public string Response { get; set; }
        public List<string> MessageReceived { get; set; } = new List<string>();

        public Courier()
            : this("")
        { }

        public Courier(string name)
        {
            Name = name;
        }
    }
}
