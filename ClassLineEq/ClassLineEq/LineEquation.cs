using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLineEq
{
    public class LineEquation
    {
        private double _a;
        private double _b;
        private double _result;

        public void getRatios(ref double a, ref double b)
        {
            //Как тут будет лучше поступать, ибо мне кажется, что такой способ полная лажа?
            _a = a;
            _b = b;
        }

        public void printEquation()
        {
            Console.WriteLine("{0}*x={1}", _a, _b);
        }
        public double getAnsw()
        {
            /*Тут я пытался поймать деление на 0,
             но это не работает, и в случае деления на 0 не выдаёт ошибку,
             а <_result> присваивается <?>".
             Однако, я рад, что в остальных случаях всё работает*/
            try
            {
                _result = _b / _a;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: DivideByZeroException");
            }
            return _result;
        }
    }
}
