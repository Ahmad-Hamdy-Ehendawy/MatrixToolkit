# MatrixToolkit Documentation

## Overview
MatrixToolkit is a C# console application that provides various matrix manipulation and analysis functions. The program offers tools to generate, display, transform, and analyze matrices with numerous mathematical operations.

## Features
- Matrix generation (organized or random values)
- Matrix visualization in console
- Matrix transposition
- Matrix multiplication
- Row and column sum calculations
- Matrix comparison
- Special matrix type identification (identity, scalar, palindrome, sparse)
- Statistical operations (min, max, sum)
- Element counting and intersection finding

## Usage

### Running the Program
1. Compile and execute the C# program.
2. Enter the desired dimensions when prompted:
   - Number of rows (n)
   - Number of columns (m)
3. The program will automatically demonstrate several matrix operations.

### Main Functions

#### Matrix Generation
- `RandomMatrixGenerator()`: Creates a matrix filled with random integers (1-10)
- `OrganizedMatrixFill()`: Creates a matrix filled with sequential integers starting from 1

#### Matrix Display
- `MatrixPrint(int[,] matrix)`: Prints a formatted matrix to console
- `ArrayPrint(int[] arr)`: Prints a 1D array to console
- `PrintMiddleRow(int[,] matrix)`: Prints the middle row of a matrix
- `PrintMiddleColumn(int[,] matrix)`: Prints the middle column of a matrix

#### Mathematical Operations
- `SumRow(int[,] matrix)`: Calculates sum of each row, returns array of sums
- `SumCol(int[,] matrix)`: Calculates sum of each column, returns array of sums
- `TransposeMatrix(int[,] matrix)`: Creates a transposed version of given matrix
- `MultiplyMatrices(int[,] matrixOne, int[,] matrixTwo)`: Element-wise multiplication
- `SumMatrix(int[,] matrix)`: Calculates and displays the sum of all elements

#### Analysis Functions
- `CompareMatrices(int[,] matrixOne, int[,] matrixTwo)`: Checks if two matrices are equal
- `IsID(int[,] matrix)`: Determines if a matrix is an identity matrix
- `IsScalar(int[,] matrix)`: Determines if a matrix is a scalar matrix
- `CountNumber(int[,] matrix)`: Counts occurrences of a specific number
- `IsSparce(int[,] matrix)`: Checks if a matrix has more zeros than non-zeros
- `IntersectedNumbers(int[,] matrixOne, int[,] matrixTwo)`: Finds common elements
- `Min(int[,] matrix)`: Finds the minimum value in the matrix
- `Max(int[,] matrix)`: Finds the maximum value in the matrix
- `IsPalindrome(int[,] matrix)`: Checks if each row reads the same forward and backward

## Example Output
```
Enter the dimensions
Rows: 
3
Columns:
3
Random Matrix 1: 
    7    3    5
    9    2    4
    6   10    1

Random Matrix 2: 
    8    6    3
    5   10    4
    2    7    9

2 Matrices multiplied
   56   18   15
   45   20   16
   12   70    9

Middle Row: 
   45   20   16 

Middle Column: 
   18 
   20 
   70 

Sum of matrix: 271
The two matrices are NOT equal
```

## Extension Possibilities
This toolkit can be extended with additional functionality such as:
- Matrix addition and subtraction
- Proper matrix multiplication (not element-wise)
- Determinant calculation
- Matrix inversion
- Eigenvalue computation
- File I/O for saving and loading matrices
- GUI implementation

## Notes
- The current implementation uses element-wise multiplication rather than mathematical matrix multiplication.
- Functions are contained within the Main method as local functions, which could be refactored into a proper class structure.
- Error handling is minimal and could be improved for production use.

## Requirements
- .NET Framework or .NET Core
- C# compiler
