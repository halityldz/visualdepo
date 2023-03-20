using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        private void multiplicationExample()
        {
            Matrix matrix1 = new Matrix(5, 10, 15, 20, 25, 30);
            Matrix matrix2 = new Matrix(2, 4, 6, 8, 10, 12);

            // matrixResult is equal to (70,100,150,220,240,352) 
            Matrix matrixResult = Matrix.Multiply(matrix1, matrix2);

            // matrixResult2 is also
            // equal to (70,100,150,220,240,352) 
            Matrix matrixResult2 = matrix1 * matrix2;
        }
    }
}
