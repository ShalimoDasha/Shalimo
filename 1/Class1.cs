using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rab1
{
    class produkt
    {
        private string name = new string(' ', 20);
        int amount;
        private float cost;
        public produkt()
        {
            this.name = "Название";
            this.amount = 0;
            this.cost = 0;
        }
        public produkt(string name, int amount, float cost)
        {
            this.name = name;
            this.amount = amount;
            this.cost = cost;

        }
        
        
    }
}
