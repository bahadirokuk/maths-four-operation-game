using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Islem
{
    class Level4 : Game
    {
        public Level4()
        {
            this.op = operators[r.Next(operators.Count)];
            if (op == "/" || op == "*")
            {
                this.number1 = r.Next(100, 500);
                this.number2 = r.Next(2, 12);
            }
            if (op == "+" || op == "-")
            {
                this.number1 = r.Next(100, 1000);
                this.number2 = r.Next(10, 100);
            }
        }
        public override int hardnes()
        {
            if (op == "/" || op == "*")
            {
                return 3;
            }
            return 2;
        }
    }
}
