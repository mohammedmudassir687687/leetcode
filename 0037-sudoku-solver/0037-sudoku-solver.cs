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
    
    
    public char[][] FillSlots(char[][] board, List<string> allNumbersSet, Dictionary<string, List<int>> possible) {

        char[][] boardcopy = board.Select(a => a.ToArray()).ToArray();
        List<string> allNumbersSetCopy = allNumbersSet.Select(a => a).ToList();
        Dictionary<string, List<int>> possibleCopy = new Dictionary<string, List<int>>(possible);
            
        if (allNumbersSetCopy.Count == 0 && IsValidSudoku(boardcopy)) {
            return boardcopy;
        }
        
        for(int index = 0; index < allNumbersSetCopy.Count; index++) {
            string item = allNumbersSetCopy[index];
            int i = item[0] - '0';
            int j = item[1] - '0';

            List<int> possibleValues = possibleCopy["" + i + "" + j];
        
            for(int val = 0; val < possibleValues.Count; val++) {
                int value = possibleValues[val];
                boardcopy[i][j] = (char)(value + '0');
                allNumbersSetCopy.Remove(item);
                if (IsValidSudoku(boardcopy)) {
                    char[][] fill = FillSlots(boardcopy, allNumbersSetCopy, possibleCopy);
                    bool flag = false;
                    for (int k = 0; k < 9; k++) {
                        for (int l = 0; l < 9; l++) {
                            if (fill[k][l] == '.') {
                                flag = true;
                                break;
                            }
                        }
                        if (flag) break;
                    }
                    if (!flag) {
                        return fill;
                    } else if (val == possibleValues.Count - 1) {
                        boardcopy[i][j] = '.';
                        return boardcopy;
                    }
                } 
            }
        }

        return boardcopy;

    }
    
    public void SolveSudoku(char[][] board) {
        Dictionary<string, List<int>> possible = new Dictionary<string, List<int>>();
        
        List<string> allNumbersSet = new List<string>();
    
        for (int i = 0; i < 9; i++) {
            for (int j = 0; j < 9; j++) {
                if (board[i][j] == '.') {
                    possible.Add("" + i + "" + j, new List<int>());
                    for (int k = 1; k < 10; k++) {
                        board[i][j] = (char)(k + '0');
                        if (IsValidSudoku(board)) {
                            possible["" + i + "" + j].Add(k);
                        }
                    }
                    if (possible["" + i + "" + j].Count == 1) {
                        board[i][j] = (char)(possible["" + i + "" + j][0] + '0');
                        possible.Remove("" + i + "" + j);
                        if (allNumbersSet.Contains("" + i + "" + j))
                            allNumbersSet.Remove("" + i + "" + j);
                    } else {
                        board[i][j] = '.';
                        if (!allNumbersSet.Contains("" + i + "" + j))
                            allNumbersSet.Add("" + i + "" + j);
                    }
                   
                }
                
            }
        }
        

        char[][] solved = FillSlots(board, allNumbersSet, possible);
        for(int i = 0; i < 9; i++) {
            for (int j = 0; j < 9; j++) {
                board[i][j] = solved[i][j];
            }
        }        
        
    }
}
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    