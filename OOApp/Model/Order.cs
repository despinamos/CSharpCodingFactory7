using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOApp.Model
{
    internal class Order
    {
        private int _id;
        private string? _name;

        // private setter can be used within the class
        public int Id
        {
            get { return _id; }
            private set { _id = value; }
        }
    }
}
