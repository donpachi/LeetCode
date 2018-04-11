using System;

namespace _289_game_of_life
{
    class Program
    {
        //100ms 100% on leetcode 
        //Following algorithm solves the game of life problem in place instead of using a buffer board, therefore space complexity is O(1) if we do
        //not count the input board.
        //time complexity follows: for every index in the board, we search a 3x3 (or less at the array limits) grid. This means that every index gets searched atmost 9 times
        //resulting in 9n queries. Therefore, time complexity is O(n) where n is total size of the 2d array. In terms of dimensions, time is O(n^2) or O(nm) if the dimensions differ.
        public void GameOfLife(int[,] board) {
            if(board.Length == 0) return;
            int rows = board.GetLength(0), cols = board.GetLength(1);
            for(int i = 0; i < rows; i++){
                for (int j = 0; j < cols; j++){
                    int alive = GetLiveNeighbours(board, i, j, rows, cols);
                    //combined case of dead & 3 live neighbours, or alive and 2 neighbours (alive and 3 neighbours will be inductively handled with bitwise OR logic)
                    // if alive is 3(11b) and board is dead (00b) bOR is 11b. If alive is 2(10b) or 3(11b) and board[i,j] is alive (01b), OR is 11b. 
                    if ((alive | board[i,j]) == 3) board[i,j] |= 2; //set left bit to alive while preserving current bit
                    
                    //if dead and 3 neighbours, live.
                    //else if (board[i,j] == 0 && alive == 3) board[i,j] |= 2; combined this statement into the above conditional
                    //all other conditions, die.
                    //else board[i,j] &= 1; small optimization here, since we're always working with a clean state due to the loop below, no need for this assignment
                }
            }
            //update board and clear next states
            for(int i = 0; i < rows; i++)
                for(int j = 0; j < cols; j++)
                    board[i,j] >>= 1;
        }
    
        int GetLiveNeighbours(int[,] board, int y, int x, int rows, int cols){
            int aliveCount = 0;
            for(int i = Math.Max(y - 1, 0); i <= Math.Min(rows - 1, y + 1); i++){
                for(int j = Math.Max(x - 1, 0); j <= Math.Min(cols - 1, x + 1); j++){
                    aliveCount += board[i,j] & 1;   //get current live status
                }
            }
            aliveCount -= board[y,x];   //dont count itself
            return aliveCount;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
