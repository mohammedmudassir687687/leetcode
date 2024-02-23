public class Solution {
    public int TotalNQueens(int n) {
        
        List<int[,]> boardStates = new List<int[,]>();

        for (int i = 0 ; i < n; i++) {
            int[,] board = new int[n,n];
            board[0, i] = 1;
            boardStates.Add(board);
        }

        return calcWays(boardStates, n, 1);
        
    }
    
    public int calcWays(List<int[,]> boardStates, int n, int kept) {
        if (kept == n) {
            return boardStates.Count;
        }  
        int sum = 0;
        while (boardStates.Count > 0) {
            int[,] boardNode = boardStates[0];
            boardStates.Remove(boardStates[0]);

            List<int[,]> newBoardStates = new List<int[,]>();
            bool noneKept = true;
            for (int j = 0; j < n; j++) {
                if (canKeep(boardNode, n, kept, j)) {
                    int[,] boardCopy = new int[n,n];
                    for (int k = 0; k < n; k++) {
                        for (int l = 0; l < n; l++) {
                            boardCopy[k, l] = boardNode[k, l];
                        }
                    }
                    boardCopy[kept, j] = 1;
                    newBoardStates.Add(boardCopy);
                    noneKept = false;
                }
            }
            if (noneKept) {
                continue;
            }
            sum += calcWays(newBoardStates, n, kept + 1);
        }

        return sum;
    }

    public bool canKeep(int[,] board, int n, int i, int j) {
        
        if (board[i,j] == 1) return false;
        int it = 0;
        for (it = 0; it < n; it++) {
            if (board[i, it] == 1 || board[it, j] == 1) {
                return false;
            }
        }

        it = 1;

        while (i - it > - 1 && j - it > - 1) {
            if (board[i-it, j-it] == 1) {
                return false;
            }
            it++;
        }

        it = 1;

        while (i - it > - 1 && j + it < n) {
            if (board[i - it, j + it] == 1) {
                return false;
            }
            it++;
        }

        it = 1;
        
        while (i + it < n && j - it > - 1) {
            if (board[i + it, j - it] == 1) {
                return false;
            }
            it++;
        }

        it = 1;

        while (i + it < n && j + it < n) {
            if (board[i + it, j + it] == 1) {
                return false;
            }
            it++;
        }

        return true;
    }
    
}