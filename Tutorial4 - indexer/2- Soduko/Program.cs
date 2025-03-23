class Program
{
    static void Main(string[] args)
    {
        int[,] inputs = new int[,]
         {
            {5, 3, 4, 6, 7, 8, 9, 1, 2},
            {6, 7, 2, 1, 9, 5, 3, 4, 8},
            {1, 9, 8, 3, 4, 2, 5, 6, 7},
            {8, 5, 9, 7, 6, 1, 4, 2, 3},
            {4, 2, 6, 8, 5, 3, 7, 9, 1},
            {7, 1, 3, 9, 2, 4, 8, 5, 6},
            {9, 6, 1, 5, 3, 7, 2, 8, 4},
            {2, 8, 7, 4, 1, 9, 6, 3, 5},
            {3, 4, 5, 2, 8, 6, 1, 7, 9}
         };
        Sudoku s1 = new Sudoku(inputs);
        s1[4, 5] = 3;
        Console.WriteLine(s1[4, 5]);
        Console.WriteLine(s1[2, 10]);
        s1[11, 6] = 3;

    }
}

public class Sudoku
{
    private int[,] _matrix;
    public Sudoku(int[,]matrix)
    {
        _matrix = matrix;
    }
    public int this [int row, int col]
    {
        get
        {   if(row>9 || col > 9)
            {
                return -1;
            }
            else
            {
                return _matrix[row - 1, col - 1];
            }
                
        }
        set
        {
            if (row > 9 || col > 9)
            {
                Console.WriteLine("index doesn't exist");
            }
            else
            {
                _matrix[row - 1, col - 1] = value;
            }
        }

    }
    
}