using System;

namespace SudokuSolver {
  class Program {
    static void Main(string[] args) {
      int?[,] initialBoard = new int?[,] {
        { null, null, null,    2  ,  3  ,  7  ,   null, null,  1   },
        { null, null,  3  ,    8  , null, null,   null,  9  , null },
        {  7  , null,  4  ,   null,  9  ,  5  ,    8  , null, null },

        {  2  ,  8  , null,   null, null, null,   null, null,  5   },
        { null, null, null,   null, null, null,   null, null, null },
        {  6  , null, null,   null, null, null,   null,  7  ,  3   },

        { null, null,  2  ,    7  ,  5  , null,    6  , null,  9   },
        { null,  7  , null,   null, null,  6  ,    4  , null, null },
        {  5  , null, null,   null, null,  9  ,   null, null, null }
      };

            SudokuBoard board = new SudokuBoard(initialBoard);

            bool solved = SudokuSolver.Solve(board);
            Console.WriteLine($"{(solved ? "SOLVED" : "UNSOLVABLE")}");

            Console.WriteLine(board.ToString());
        }
    }
}
