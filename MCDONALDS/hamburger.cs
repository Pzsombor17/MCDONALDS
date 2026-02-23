using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCDONALDS
{
    
        public class falatkak
        {
            public string name { get; set; }
            public int price { get; set; }
            public double kaloria { get; set; }
            public bool glutenmentes { get; set; }

            public falatkak(string[] data)
            {
                this.name = data[0];
                this.price = int.Parse(data[1]);
                this.kaloria = double.Parse(data[2]);
                if (data[3] == "true") { this.glutenmentes = true; }
                else if (data[6] == "false") { this.glutenmentes = false; }
                else { this.glutenmentes = false; }
            }
            public void buy(int darab)
        {

        }
            public override string ToString() {
            return $"A burger neve: {name}, ára: {price}, kcal: {kaloria}, glutenmentes: {glutenmentes}";
            }

        }
    }

