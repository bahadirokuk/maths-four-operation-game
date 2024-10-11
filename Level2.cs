using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Islem
{
    class Level2 : Game
    {
        public Level2()
        {
            this.op = operators[r.Next(operators.Count)];
            if (op == "/" || op == "*")
            {
                this.number1 = r.Next(1, 20);
                this.number2 = r.Next(2, 10);
            }
            if (op == "+" || op == "-")
            {
                this.number1 = r.Next(1, 100);
                this.number2 = r.Next(1, 20);
            }
        }
        public override int hardnes()
        {
            if (op == "/" || op == "*")
            {
                return 2;
            }
            return 1;
        }
    }
}
