using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucHanh2
{

    internal class Board
    {
        private string currentPlayer = "o";
        public static int currentRow = 0;
        public static int currentColumn = 0;
        public int height { get; set; }
        public int width { get; set; }
        public Board() { }
        public Board(int height, int width)
        {
            this.height = height;
            this.width = width;
        }
        string[,] board = new string[3, 3]

{
    {
        "-" , "-", "-"
    },{
        "-" , "-", "-"
    },{
        "-" , "-", "-"
    }
};

        void printBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                // in ra các cột
                for (int j = 0; j < 3; j++)
                {
                    if (i == currentRow && j == currentColumn)
                    {
                        // in ra cột
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(board[i, j] + " ");
                        Console.ResetColor();

                    }
                    else
                    {
                        Console.Write(board[i, j] + " ");

                    }
                }
                // Ngắt dòng
                Console.WriteLine("");
            }
        }

        // check win thắng = 2, hòa = 1, không có gì = 0
        int CheckWin(string player)
        {
            int result = 0;
            // dòng
            if (board[0, 0] == player && board[0, 1] == player && board[0, 2] == player)
            {
                result = 2;
            }
            if (board[2, 0] == player && board[2, 1] == player && board[2, 2] == player)
            {
                result = 2;
            }
            if (board[1, 0] == player && board[1, 1] == player && board[1, 2] == player)
            {
                result = 2;
            }

            // cột
            if (board[0, 0] == player && board[1, 0] == player && board[2, 0] == player)
            {
                result = 2;
            }
            if (board[0, 1] == player && board[1, 1] == player && board[2, 1] == player)
            {
                result = 2;
            }
            //chéo
            if (board[0, 0] == player && board[1, 1] == player && board[2, 2] == player)
            {
                result = 2;
            }
            if (board[2, 0] == player && board[1, 1] == player && board[0, 2] == player)
            {
                result = 2;
            }
            if (getRemain() == 0 && result == 0)
            {
                return 1;
            }
            return result;
        }

        int getRemain()
        {
            int count = 0;
            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == "-")
                    {
                        count++;
                    }
                }


            }
            return count;
        }
        public void Play()
        {
            Console.OutputEncoding = Encoding.UTF8;
            while (true)
            {
                Console.Clear();
                printBoard();
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.UpArrow)
                {
                    // Di chuyển đối tượng lên trên
                    currentRow--;
                    currentRow = (currentRow < 0) ? 2 : currentRow;
                }
                else if (keyInfo.Key == ConsoleKey.DownArrow)
                {
                    // Di chuyển đối tượng xuống dưới
                    currentRow++;
                    currentRow = (currentRow >= 3) ? 0 : currentRow;


                }
                else if (keyInfo.Key == ConsoleKey.LeftArrow)
                {
                    // Di chuyển đối tượng sang trái
                    currentColumn--;
                    currentColumn = (currentColumn < 0) ? 2 : currentColumn;


                }
                else if (keyInfo.Key == ConsoleKey.RightArrow)
                {
                    // Di chuyển đối tượng sang phải
                    currentColumn++;
                    currentColumn = (currentColumn >= 3) ? 0 : currentColumn;

                }
                else if (keyInfo.Key == ConsoleKey.Z)
                {
                    // Lấy giá trị có sẵn tại điểm  - 
                    string value = board[currentRow, currentColumn];
                    if (value == "-")
                    {
                        board[currentRow, currentColumn] = currentPlayer;
                        currentPlayer = (currentPlayer == "o") ? "x" : "o";
                        int result = CheckWin(currentPlayer);
                        if (result == 0)
                        {
                            // Khong co gi ca

                        }
                        else if (result == 1)
                        {
                            Console.WriteLine("Hòa");
                            Task.Delay(2000).Wait();
                            break;

                        }
                        else if (result == 2)
                        {
                            Console.WriteLine($"Người chơi {currentPlayer} thắng");
                            Task.Delay(2000).Wait();
                            break;

                        }
                    }
                    else
                    {
                        Console.WriteLine("O trong da co du lieu");
                        Task.Delay(2000).Wait();
                    }
                }
            }
        }


    }
}
