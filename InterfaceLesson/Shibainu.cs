using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceLesson {
    class Shibainu : IPrint {
        public string Characteristic { get; set; } = "Stand-offish";
        public string Type { get; set; } = "Shibainu";

        public void Print() {
            Console.WriteLine($"This dog is a {Type} and it is {Characteristic}");
        }
    }
}
