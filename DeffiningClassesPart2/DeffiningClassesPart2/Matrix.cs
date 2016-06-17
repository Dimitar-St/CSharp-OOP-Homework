namespace DeffiningClassesPart2
{
    using System;

    class Matrix<T>
    {
        private T[,] matrix;
        private T[,] index;


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


        public T[,] Matrixes
        {
            get
            {
                return this.matrix;
            }
            set
            {
                this.matrix = value;
            }
        }

        public T[,] Index
        {
            get
            {
                return this.index;
            }
            set
            {
                this.index = value;
            }
        }

       
       public static Matrix<T> operator *(Matrix<T> matrixOne, Matrix<T> matrixTwo)
         {
            var result = new Matrix<T>(matrixOne.matrix.GetLength(0), matrixTwo.matrix.GetLength(1));

            for (int row = 0; row < result.matrix.GetLength(0); row++)
            {
                for (int col = 0; col < result.matrix.GetLength(1); col++)
                {
                    for (int i = 0; i < matrixOne.matrix.GetLength(1); i++)
                    {
                        result[row, col] += (dynamic)matrixOne[row, i] * (dynamic)matrixTwo[i, col];
                    }
                }
            }
            return result;
        }


        public static Matrix<T> operator +(Matrix<T> matrixOne, Matrix<T> matrixTwo)
        {
            var result = new Matrix<T>(matrixOne.matrix.GetLength(0), matrixOne.matrix.GetLength(1));

            for (int row = 0; row < matrixOne.matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrixOne.matrix.GetLength(1); col++)
                {
                    result[row, col] = (dynamic)matrixOne[row, col] + (dynamic)matrixTwo[row, col];
                }
            }
            return result;
        }

        public static Matrix<T> operator -(Matrix<T> matrixOne, Matrix<T> matrixTwo)
        {
            var result = new Matrix<T>(matrixOne.matrix.GetLength(0), matrixOne.matrix.GetLength(1));

            for (int row = 0; row < matrixOne.matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrixOne.matrix.GetLength(1); col++)
                {
                    T max = matrixOne[row, col];
                    T min = matrixTwo[row, col];

                    if ((dynamic)matrixOne[row, col] < (dynamic)matrixTwo[row, col])
                    {
                        max = matrixTwo[row, col];
                        min = matrixOne[row, col];
                    }
                    result[row, col] = (dynamic)max - (dynamic)min;
                }
            }
            return result;
        }
    }
}
