namespace Matrix
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    [Version(1, 10)]
    public class Matrix<T>
    {
        private T[,] matrix;

        public Matrix(int row, int col)
        {
            this.matrix = new T[row, col];
        }

        public T this[int row, int col]
        {
            get
            {
                return this.matrix[row, col];
            }
            set
            {
                this.matrix[row, col] = value;
            }
        }

        public static Matrix<T> operator +(Matrix<T> m1, Matrix<T> m2)
        {
            if(m1.matrix.GetLength(0) != m2.matrix.GetLength(0) || 
                m1.matrix.GetLength(1) != m2.matrix.GetLength(1))
            {
                throw new ArgumentException("Matrixes should have the same dimentions!");
            }

            var result = new Matrix<T>(m1.matrix.GetLength(0), m1.matrix.GetLength(1));

            for (int i = 0; i < m1.matrix.GetLength(0); i++)
            {
                for (int j = 0; j <  m1.matrix.GetLength(1); j++)
                {
                    result[i, j] = (dynamic)m1[i, j] + (dynamic)m2[i, j];
                }
            }

            return result;
        }

        public static Matrix<T> operator -(Matrix<T> m1, Matrix<T> m2)
        {
            if (m1.matrix.GetLength(0) != m2.matrix.GetLength(0) ||
                 m1.matrix.GetLength(1) != m2.matrix.GetLength(1))
            {
                throw new ArgumentException("Matrixes should have the same dimentions!");
            }

            var result = new Matrix<T>(m1.matrix.GetLength(0), m1.matrix.GetLength(1));

            for (int i = 0; i < m1.matrix.GetLength(0); i++)
            {
                for (int j = 0; j < m1.matrix.GetLength(1); j++)
                {
                    T max = m1[i, j];
                    T min = m2[i, j];
                    if ((dynamic)m1[i, j] < (dynamic)m2[i, j])
                    {
                        max = m2[i, j];
                        min = m1[i, j];
                    }

                    result[i, j] = (dynamic)max - (dynamic)min;
                }
            }

            return result;
        }

        public static Matrix<T> operator *(Matrix<T> m1, Matrix<T> m2)
        {   
            //cols of m1 multiply rows of m2
            if (m2.matrix.GetLength(0) != m1.matrix.GetLength(1)) 
            {
                throw new ArgumentException("Matrixes should have *** dimentions!");
            }

            var result = new Matrix<T>(m1.matrix.GetLength(0), m2.matrix.GetLength(1));

            for (int row = 0; row < result.matrix.GetLength(0); row++)
            {
                for (int col = 0; col < result.matrix.GetLength(1); col++)
                {
                    for (int i = 0; i < m1.matrix.GetLength(1); i++)
                    {
                        result[row, col] += (dynamic)m1[row, col] * (dynamic)m2 [i, col];
                    }

                }
            }

            return result;
        }

        public static bool operator true(Matrix<T> matrix)
        {
            bool isTrue = true;

            for (int r = 0; r < matrix.matrix.GetLength(0) && isTrue; r++)
            {
                for (int c = 0; c < matrix.matrix.GetLength(1) && isTrue; c++)
                {
                    if ((dynamic)matrix[r, c] == 0)
                    {
                        isTrue = false;
                    }
                }
            }

            return isTrue;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            bool isTrue = true;

            for (int r = 0; r < matrix.matrix.GetLength(0) && isTrue; r++)
            {
                for (int c = 0; c < matrix.matrix.GetLength(1) && isTrue; c++)
                {
                    if ((dynamic)matrix[r, c] == 0)
                    {
                        isTrue = false;
                    }
                }
            }

            return !isTrue;
        }

        public static bool operator !(Matrix<T> matrix)
        {
            if(matrix)
            {
                return false;
            }

            return true;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            for (int row = 0; row < this.matrix.GetLength(0); row++)
            {
                for (int col = 0; col < this.matrix.GetLength(1); col++)
                {
                    sb.AppendFormat(" {0, 3} ", this.matrix[row, col]);
                }
                sb.Append("\n");
            }

            return sb.ToString();
        }
    }
}
