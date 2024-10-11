using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Islem
{
    public abstract class Game 
    {
        public int number1;
        public int number2;
        public String op;
        public Random r = new Random();
        public abstract int hardnes();
        public List<string> operators = new List<string>
        {
            "*",
            "+",
            "-",
            "/",
        };
        public int calculation()
        {
            switch (op)
            {
                case "+":
                    return number1 + number2;
                case "-":
                    return number1 - number2;
                case "*":
                    return number1 * number2;
                case "/":
                    return number1 / number2;
            }
            throw new Exception();
        }
    }
}
