namespace Matrix
{
    using System;
    using System.Collections.Generic;

    class Test
    {
        static void Main()
        {
            int row = 4;
            int col = 4;
            var matrix = new Matrix<int>(row, col);

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = i + j;
                }                
            }

            var matrix2 = new Matrix<int>(row, col);

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix2[i, j] = (i + 1) * (j + 1);
                }
            }


            Console.WriteLine(matrix);

            Console.WriteLine(matrix2);

            var SumOfMatrix = new Matrix<int>(row, col);

            Console.WriteLine(matrix + matrix2);

            Console.WriteLine(matrix2 - matrix);

            Console.WriteLine(matrix - matrix2);

            Console.WriteLine(matrix * matrix2);

            if (matrix2)
            {
                Console.WriteLine("No zeros");
            }
            else
            {
                Console.WriteLine("There are zeros");
            }

            Type type = typeof(Matrix<int>);
            object[] attr = type.GetCustomAttributes(false);
            foreach (var item in attr)
            {
                Console.WriteLine(item);
            }
        }
    }
    
}
