namespace ConsoleApp7
{
    internal class Matrix
    {
        int rows;
        int columns;
        int[,] data;
        public int this[int i, int j]
        {
            get { return data[i, j]; }
            set { data[i, j] = value; }
        }
        public Matrix(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
            data = new int[rows, columns];
        }
        public static Matrix operator +(Matrix a, Matrix b)
        {
            Matrix res = new Matrix(a.rows, a.columns);
            for (int i = 0; i < a.rows; i++)
            {
                for (int j = 0; j < a.columns; j++)
                {
                    res[i, j] = a[i, j] + b[i, j];
                }
            }
            return res;
        }
        public static Matrix operator -(Matrix a, Matrix b)
        {
            Matrix res = new Matrix(a.rows, a.columns);
            for (int i = 0; i < a.rows; i++)
            {
                for (int j = 0; j < a.columns; j++)
                {
                    res[i, j] = a[i, j] - b[i, j];
                }
            }
            return res;
        }
        public static Matrix operator *(Matrix a, Matrix b)
        {
            Matrix res = new Matrix(a.rows, a.columns);
            for (int i = 0; i < a.rows; i++)
            {
                for (int j = 0; j < a.columns; j++)
                {
                    res[i, j] = a[i, j] * b[i, j];
                }
            }
            return res;
        }
        public static bool operator ==(Matrix left, Matrix right)
        {
            return left.rows == right.rows;
        }
        public static bool operator !=(Matrix left, Matrix right)
        {
            return left.rows != right.rows;
        }
    }
}