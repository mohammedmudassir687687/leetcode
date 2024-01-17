public class Solution {
    public bool IsValidSudoku(char[][] board) {
        
        
        for (int i = 0; i < 9; i++) {
            HashSet<char> rs = new HashSet<char>();
            for (int j = 0; j < 9; j++) {
                if (board[i][j] != '.') {
                    if (rs.Contains(board[i][j])) {
                        return false;
                    } else {
                        rs.Add(board[i][j]);
                    }
                }
            }
        }
        
        
        for (int i = 0; i < 9; i++) {
            HashSet<char> cs = new HashSet<char>();
            for (int j = 0; j < 9; j++) {
                if (board[j][i] != '.') {
                    if (cs.Contains(board[j][i])) {
                        return false;
                    } else {
                        cs.Add(board[j][i]);
                    }
                }
            }
        }
        
        
        for (int i = 1; i < 8; i += 3) {
            for (int j = 1; j < 8; j += 3) {
                HashSet<char> ss = new HashSet<char>();
                for (int k = -1; k < 2; k++) {
                    for (int l = -1; l < 2; l++) {
                        if (board[i + k][j + l] != '.') {
                            if (ss.Contains(board[i + k][j + l])) {
                                return false;
                            } else {
                                ss.Add(board[i + k][j + l]);
                            }
                        }
                    }
                }

            }
        }
        
        return true;
        
        
        
    }
}