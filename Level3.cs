using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Islem
{
    class Level3 : Game
    {
        public Level3()
        {
            this.op = operators[r.Next(operators.Count)];
            if (op == "/" || op == "*")
            {
                this.number1 = r.Next(50, 100);
                this.number2 = r.Next(2, 20);
            }
            if (op == "+" || op == "-")
            {
                this.number1 = r.Next(10, 120);
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
