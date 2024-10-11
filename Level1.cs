using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Islem
{
    class Level1 : Game
    {
        public Level1()
        {
            this.number1 = r.Next(0,10);
            this.number2 = r.Next(0,10);
            this.op = operators[r.Next(operators.Count)];
            if (op=="/" && number2 ==0)
            {
                this.number2= r.Next(1, 10); 
            }
        }
        public override int hardnes() => 1;

    }
}
