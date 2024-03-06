public class Solution {
    public IList<int> SpiralOrder(int[][] matrix) {
     
        List<int> res = new List<int>();
        
        int columns = matrix[0].Length - 1;
        int rows = matrix.Length - 1;
        int topLeft = 0;
        
        while (topLeft <= columns && topLeft <= rows) {
            int row = topLeft;
            int col = topLeft;

            while (col <= columns && row <= rows) {
                res.Add(matrix[row][col]);
                col++;
            }

            col = columns;
            row = topLeft + 1;
            while (row <= rows) {
                res.Add(matrix[row][col]);
                row++;
            }

            row = rows;
            col = columns - 1;
            while (col >= topLeft && row != topLeft){
                res.Add(matrix[row][col]);
                col--;
            }

            col = topLeft;
            row = rows - 1;
            while (row > topLeft && col != columns) {
                res.Add(matrix[row][col]);
                row--;
            }

            topLeft++;
            columns--;
            rows--;
        }
        
        return res;
            
    }
}