using System;

namespace SudokuSolver {
  public static class SudokuSolver {
    public static bool Solve(SudokuBoard board) {
      return Solve(board, 0, 0);
    }

    private static bool Solve(SudokuBoard board, int i, int j) {
      BoardStatus status = board.Check();
      if (status == BoardStatus.Solved) return true;
      if (status == BoardStatus.Unsolvable) return false;
      
      int iNext = i;
      int jNext = j + 1;
      if (jNext >= board.size) {
        jNext = 0;
        iNext++;
      }

      if (board.IsFixedNumber(i, j)) {
        return Solve(board, iNext, jNext);
      } else {
        for (int n = 1; n <= board.size; n++) {
          board.SetNumber(i, j, n);
          if (Solve(board, iNext, jNext)) {
            return true;
          }
        }
        board.SetNumber(i, j, 0);
        return false;
      }
    }
  }
}
