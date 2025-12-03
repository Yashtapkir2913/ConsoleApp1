using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interface
{

    namespace TicTacToeOOP
    {
        // ---------- Board (encapsulation + ToString) ----------
        public class Board
        {
            private char[,] grid; // 'X', 'O' or ' ' 
            public int Size { get; }

            public Board(int size = 3)
            {
                Size = size;
                grid = new char[size, size];
                for (int r = 0; r < Size; r++)
                    for (int c = 0; c < Size; c++)
                        grid[r, c] = ' ';
            }

            public bool IsFull()
            {
                for (int r = 0; r < Size; r++)
                    for (int c = 0; c < Size; c++)
                        if (grid[r, c] == ' ') return false;
                return true;
            }

            public bool Place(int row, int col, char mark)
            {
                if (row < 0 || row >= Size || col < 0 || col >= Size) return false;
                if (grid[row, col] != ' ') return false;
                grid[row, col] = mark;
                return true;
            }

            public bool HasWinner(char mark)
            {
                // rows & cols
                for (int i = 0; i < Size; i++)
                {
                    bool rowWin = true, colWin = true;
                    for (int j = 0; j < Size; j++)
                    {
                        if (grid[i, j] != mark) rowWin = false;
                        if (grid[j, i] != mark) colWin = false;
                    }
                    if (rowWin || colWin) return true;
                }

                // diag
                bool d1 = true, d2 = true;
                for (int i = 0; i < Size; i++)
                {
                    if (grid[i, i] != mark) d1 = false;
                    if (grid[i, Size - 1 - i] != mark) d2 = false;
                }
                return d1 || d2;
            }

            public override string ToString()
            {
                // simple grid string
                string s = "";
                for (int r = 0; r < Size; r++)
                {
                    for (int c = 0; c < Size; c++)
                    {
                        s += $" {grid[r, c]} ";
                        if (c < Size - 1) s += "|";
                    }
                    s += Environment.NewLine;
                    if (r < Size - 1) s += new string('-', Size * 4 - 1) + Environment.NewLine;
                }
                return s;
            }

            // expose grid read-only for simple AI scanning
            public char GetCell(int r, int c) => grid[r, c];
        }

        // ---------- Player (abstract) + polymorphism ----------
        public abstract class Player
        {
            public string Name { get; }
            public char Mark { get; } // 'X' or 'O'

            // constructor
            protected Player(string name, char mark)
            {
                Name = name;
                Mark = mark;
            }

            // each player must implement how to choose a move
            public abstract (int row, int col) ChooseMove(Board board);

            public override string ToString() => $"{Name} ({Mark})";
        }

        // Human player - reads input
        public class HumanPlayer : Player
        {
            public HumanPlayer(string name, char mark) : base(name, mark) { }

            public override (int row, int col) ChooseMove(Board board)
            {
                while (true)
                {
                    Console.Write($"{Name}, enter move as row,col (1-{board.Size}): ");
                    var input = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(input)) continue;
                    var parts = input.Split(',');
                    if (parts.Length != 2) continue;
                    if (int.TryParse(parts[0].Trim(), out int r) && int.TryParse(parts[1].Trim(), out int c))
                    {
                        return (r - 1, c - 1); // convert to 0-based
                    }
                }
            }
        }

        // Very simple computer: pick first empty cell (keeps code tiny)
        public class ComputerPlayer : Player
        {
            public ComputerPlayer(string name, char mark) : base(name, mark) { }

            public override (int row, int col) ChooseMove(Board board)
            {
                for (int r = 0; r < board.Size; r++)
                    for (int c = 0; c < board.Size; c++)
                        if (board.GetCell(r, c) == ' ')
                            return (r, c);
                return (-1, -1); // no move
            }
        }

        // ---------- Game orchestrator ----------
        public class Game
        {
            private readonly Board board;
            private readonly Player player1;
            private readonly Player player2;
            private Player current;

            public Game(Player p1, Player p2, int boardSize = 3)
            {
                player1 = p1; player2 = p2;
                board = new Board(boardSize);
                current = player1;
            }

            public void Play()
            {
                Console.WriteLine("Starting Tic-Tac-Toe!");
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine(board);
                    Console.WriteLine($"Turn: {current}");

                    var (r, c) = current.ChooseMove(board);
                    bool ok = board.Place(r, c, current.Mark);
                    if (!ok)
                    {
                        Console.WriteLine("Invalid move, try again.");
                        System.Threading.Thread.Sleep(800);
                        continue;
                    }

                    // check win
                    if (board.HasWinner(current.Mark))
                    {
                        Console.Clear();
                        Console.WriteLine(board);
                        Console.WriteLine($"{current.Name} wins! ({current.Mark})");
                        break;
                    }

                    if (board.IsFull())
                    {
                        Console.Clear();
                        Console.WriteLine(board);
                        Console.WriteLine("It's a draw!");
                        break;
                    }

                    // switch
                    current = current == player1 ? player2 : player1;
                }
            }
        }

        // ---------- Program (entry) ----------
        class TicTacToeOOP1
        {
            public static void M1()
            {
                Console.WriteLine("Tic-Tac-Toe (OOP Demo)");

                Console.Write("Enter your name: ");
                string name = Console.ReadLine()?.Trim();
                if (string.IsNullOrEmpty(name)) name = "Player";

                // human vs computer example (you can create two humans to play)
                Player human = new HumanPlayer(name, 'X');
                Player cpu = new ComputerPlayer("Computer", 'O');

                var game = new Game(human, cpu);
                game.Play();

                Console.WriteLine("Game over. Press any key to exit.");
                Console.ReadKey();
            }
        }
    }

}
