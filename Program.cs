using System.Diagnostics.Metrics;
using System.Numerics;
using System.Threading.Channels;

Console.WriteLine("Enter the dimensions");
Console.WriteLine("Rows: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Columns:");
int m = int.Parse(Console.ReadLine());
int[,] matrix = new int[n, m];
int counter = 1;

// -----------------------------------------------------------------------------------------------------------------------------------------

int RandomNumberGenerator()
{
    Random random = new Random();
    int r = random.Next(1,11);
    return r;
}
void MatrixPrint(int[,] matrix)
{ 
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i,j], 5}");

    }
    Console.WriteLine("");
}
}
void ArrayPrint(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"{arr[i], 5}");
    }


}
int[] SumRow(int[,] matrix)
{ 

    int[] arrsum = new int[matrix.GetLength(0)]; 
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
            arrsum[i]+= matrix[i, j];       
    }
}
    return arrsum;
    
}
int[] SumCol(int[,] matrix)
{
    {
      
        int[] arrsum = new int[matrix.GetLength(0)];
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                arrsum[i] += matrix[j, i];
            }
        }
        return arrsum;

    }


}
int[,] RandomMatrixGenerator()
{
    int[,] newMatrix = new int[n,m];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            newMatrix[i, j] = RandomNumberGenerator();

        }

    }
    return newMatrix;
}
int OrganizedNumbersGenerator()
{
    return counter++;
}
int[,] OrganizedMatrixFill()
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = OrganizedNumbersGenerator();

        }

    }
    return matrix;
}
int[,] TransposeMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[j, i] = OrganizedNumbersGenerator();

        }

    }
    return matrix;
}
int[,] MultiplyMatrices(int[,] matrixOne, int[,] matrixTwo)
{
    int[,] mulMatrix = new int[n, m];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            mulMatrix[i, j] = matrixOne[i, j] * matrixTwo[i, j];

        }

    }
    return mulMatrix;
}
void PrintMiddleRow(int[,] matrix)
{
    // i = row 
    int middleRow = matrix.GetLength(0) / 2;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        Console.Write($"{matrix[middleRow, i], 5} ");
    }
}
void PrintMiddleColumn(int[,] matrix)
{
    // i = row 
    int middleRow = matrix.GetLength(0) / 2;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        Console.Write($"{matrix[i, middleRow],5} ");
    }
}
void SumMatrix(int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];

        }

    }
    Console.WriteLine(sum);
}
void CompareMatrices(int[,] matrixOne, int[,] matrixTwo)
{
    for (int i = 0; i < matrixOne.GetLength(0); i++)
    {
        for (int j = 0;j < matrixOne.GetLength(1); j++)
        {
            if (matrixOne[i, j] != matrixTwo[i, j])
            {
                Console.WriteLine("The two matrices are NOT equal");
                return;
            }
       
        }
    }
    Console.WriteLine("The two matrices are equal");
    return;
}
void IsID(int[,] matrix)
{
    bool status = true;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        { 
        if ((matrix[i, j] != 1 && i == j) || (matrix[i, j] != 0 && i != j))
        {
            status = false;
                return;
        }
        }
    }
    if (status) { Console.WriteLine("IDENTITY"); }
    else { Console.WriteLine("NOT IDENTITY"); }
    return; 
}
void IsScalar(int[,] matrix)
{
    bool status = true;
    int num = matrix[0, 0];
    for (int i = 0; i  < matrix.GetLength(0); i ++)
    {
        for (int j= 0; j < matrix.GetLength(1); j++)
        {
            if (( i == j && matrix[i, j] != num) || (i != j && matrix[i, j] != 0))
            {
                status = false;
                Console.WriteLine("Matrix is NOT scalar");
                return;
            }
             
        }
    }
    Console.WriteLine("Matrix IS scalar"); return;
}
void CountNumber(int [,] matrix)
{
    int count = 0;
    Console.WriteLine("What number do you wanna look for? ");
    int number = int.Parse(Console.ReadLine());
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           if (matrix[i, j] == number)
            {
                count++;
            }

        }

    }
    Console.WriteLine($"The count of number {number} is {count} ");
    return;
}
void IsSparce(int [,] matrix)
{
    {
        int countZero = 0; int countNotZero = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 0)
                {
                    countZero++;
                }
                else { countNotZero++; }

            }

        }
        Console.WriteLine(countZero > countNotZero? "Is sparce" : "Is not sparce");
    }
}
void IntersectedNumbers(int [,] matrixOne, int[,] matrixTwo)
{
    Console.Write("Intersected numbers: ");
    List<int> numbers = new List<int>();
    

   foreach (int i in matrixOne)
    {
        foreach (int j in matrixTwo)
        {
            bool status = false;
            foreach (int k in numbers)
            {
                
                if (j == k)
                {
                    status = true;
                    break;
                }
            }
             if (i == j && !status)
            {
                numbers.Add(j);
                Console.Write($"{j} \t");
            }
        }
    }
}
void Min(int[,] matrix)
{
    int min = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (min > matrix[i, j]) { min = matrix[i, j]; }

        }

    }
    Console.WriteLine($"Minimum number is {min}");
}
void Max(int[,] matrix)
{
    
    {
        int max = matrix[0, 0];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (max < matrix[i, j]) { max = matrix[i, j]; }

            }

        }
        Console.WriteLine($"Maximum number is {max}");
    }
}
void IsPalindrome(int[,] matrix)
{
    
    // i static and j moves, i moves once and j moves
    for (int i = 0; i  < matrix.GetLength(0); i++)
    {
        
        {
            for (int k = matrix.GetLength(1) - 1, j = 0; j < matrix.GetLength(1) && k >= 0; j++, k--)

            {
                if (matrix[i, j] != matrix[i, k])
                {
                    
                    Console.WriteLine("Matrix is not palindrom");
                    return;
       
    }
            }
        }
    }
    Console.WriteLine("Matrix is palindrome");
}
// ----------------------------------------------------------------------------------------------------------------------------------

Console.WriteLine("Random Matrix 1: ");
int[,] a = RandomMatrixGenerator();
MatrixPrint(a);
Console.WriteLine("");
Console.WriteLine("Random Matrix 2: ");
int[,] b = RandomMatrixGenerator();
MatrixPrint(b);
Console.WriteLine("");
Console.WriteLine("2 Matrices multiplied");
int[,] c = MultiplyMatrices(a, b);
MatrixPrint(c);
Console.WriteLine("");
Console.WriteLine("Middle Row: ");
PrintMiddleRow(c);
Console.WriteLine("");
Console.WriteLine("Middle Column: ");
PrintMiddleColumn(c);
Console.WriteLine("");
Console.WriteLine("Sum of matrix: ");
SumMatrix(c);
Console.WriteLine("");
CompareMatrices(a, b);










