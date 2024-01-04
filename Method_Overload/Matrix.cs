using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overload
{
    internal class Matrix
    {
        public int[,] matrix { get; set; }
        public int[,] matrix2 { get; set; }
        public int rows { get; set; }
        public int columns { get; set; }

        public static int RowsCount(this int[,] matrix)
        {
            return matrix.GetLength(0);
        }


        public static int ColumnsCount(this int[,] matrix)
        {
            return matrix.GetLength(1);
        }

            public static Matrix operator +(Matrix matrix, Matrix matrix2, int rows, int columns)
            {
                var matrixSum = new int[rows, columns];

                for (var i = 0; i < matrixSum.GetLength(0); i++)
                {
                    for (var j = 0; j < matrixSum.GetLength(1); j++)
                    {
                        Console.Write(matrixSum[rows, columns] + "\t");

                    }

                }
            }
            public static Matrix operator -(Matrix matrix, Matrix matrix2, int rows, int columns)
            {
            var matrixRess = new int[rows, columns];
            for (int i = 0; i < GetLength(0); i++)
            {
                for (int j = 0; j < GetLength(1); j++)
                {
                    matrixRess[i, j] = matrix[i, j] - matrix2[i, j];
                }
            }
            return matrixRess[,]
            public static bool operator ==(Matrix matrix, Matrix matrix2)
            {
                if (Matrix1 == Matrix2)
                    return true;
                else
                    return false;
            }

        }
    }
}
