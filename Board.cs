using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversiApp
{
    enum Disk
    {
        Empty,
        White,
        Black
    };

    /**
     * <summary>Describes board for Reversi game</summary>
     */
    class Board
    {
        public static readonly int WIDTH = 8;
        public static readonly int HEIGHT = 8;

        public Disk[,] Disks;

        public int WhiteScore => CountDisks(Disk.White);
        public int BlackScore => CountDisks(Disk.Black);

        public bool IsFinished => !CanMove(true) && !CanMove(false);

        public Board()
        {
            Disks = new Disk[HEIGHT, WIDTH];

            for (int y = 0; y < HEIGHT; y++)
            {
                for (int x = 0; x < WIDTH; x++)
                {
                    Disks[y, x] = Disk.Empty;
                }
            }
        }

        /**
         * <summary>Prepare board for a game</summary>
         */
        public void Init()
        {
            Disks[HEIGHT / 2 - 1, WIDTH / 2 - 1] = Disk.Black;
            Disks[HEIGHT / 2 - 1, WIDTH / 2    ] = Disk.White;
            Disks[HEIGHT / 2    , WIDTH / 2 - 1] = Disk.White;
            Disks[HEIGHT / 2, WIDTH / 2] = Disk.Black;
        }

        /**
         * <summary>Make a move for a given player</summary> 
         * 
         * <param name="y">the y-coordinate of disk to move</param>
         * <param name="x">the x-coordinate of disk to move</param>
         * <param name="isWhite">the color of player to make a move</param>
         * 
         * <exception cref="IndexOutOfRangeException">x or y coordinates are out of range</exception>
         * <exception cref="Exception">disk is not empty</exception>
         */
        public void Move(int y, int x, bool isWhite)
        {
            if (y < 0 || y >= HEIGHT)
            {
                throw new IndexOutOfRangeException($"wrong y value: {y}");
            }
            if (x < 0 || x >= HEIGHT)
            {
                throw new IndexOutOfRangeException($"wrong x value: {x}");
            }
            if (!Disks[y, x].Equals(Disk.Empty))
            {
                throw new Exception($"[{y},{x}] is not empty");
            }
            Disks[y, x] = isWhite ? Disk.White : Disk.Black;
            RewriteDisks(y, x, isWhite);
        }

        /**
         * <summary>Rewrite all "eaten" disks to all 8 directions after move</summary>
         */
        private void RewriteDisks(int yPos, int xPos, bool isWhite) 
        {
            Disk empty = Disk.Empty;
            Disk current = isWhite ? Disk.White : Disk.Black;
            Disk enemy = isWhite ? Disk.Black : Disk.White;

            // top left, y--, x--
            for (int y = yPos - 1, x = xPos - 1; y >= 0 && x >= 0; y--, x--)
            {
                Disk disk = Disks[y, x];
                if (disk.Equals(empty)) break;
                if (disk.Equals(current)) {
                    while (y < yPos && x < xPos) 
                    {
                        Disks[y, x] = current;
                        y++;
                        x++;
                    }
                    break;
                }
            }

            // top, y--
            for (int y = yPos - 1; y >= 0; y--)
            {
                Disk disk = Disks[y, xPos];
                if (disk.Equals(empty)) break;
                if (disk.Equals(current))
                {
                    while (y < yPos) 
                    {
                        Disks[y, xPos] = current;
                        y++;
                    }
                    break;
                }
            }

            // top right, y--, x++
            for (int y = yPos - 1, x = xPos + 1; y >= 0 && x < WIDTH; y--, x++)
            {
                Disk disk = Disks[y, x];
                if (disk.Equals(empty)) break;
                if (disk.Equals(current))
                {
                    while (y < yPos && x > xPos) 
                    {
                        Disks[y, x] = current;
                        y++;
                        x--;
                    }
                    break;
                }
            }

            // right, x++
            for (int x = xPos + 1; x < WIDTH; x++)
            {
                Disk disk = Disks[yPos, x];
                if (disk.Equals(empty)) break;
                if (disk.Equals(current))
                {
                    while (x > xPos)
                    {
                        Disks[yPos, x] = current;
                        x--;
                    }
                    break;
                }
            }

            // bottom right, y++, x++
            for (int y = yPos + 1, x = xPos + 1; y < HEIGHT && x < WIDTH; y++, x++)
            {
                Disk disk = Disks[y, x];
                if (disk.Equals(empty)) break;
                if (disk.Equals(current))
                {
                    while (y > yPos && x > xPos)
                    {
                        Disks[y, x] = current;
                        y--;
                        x--;
                    }
                    break;
                }
            }

            // bottom, y++
            for (int y = yPos + 1; y < HEIGHT; y++)
            {
                Disk disk = Disks[y, xPos];
                if (disk.Equals(empty)) break;
                if (disk.Equals(current))
                {
                    while (y > yPos)
                    {
                        Disks[y, xPos] = current;
                        y--;
                    }
                    break;
                }
            }

            // bottom left, y++, x--
            for (int y = yPos + 1, x = xPos - 1; y < HEIGHT && x >= 0; y++, x--)
            {
                Disk disk = Disks[y, x];
                if (disk.Equals(empty)) break;
                if (disk.Equals(current))
                {
                    while (y > yPos && x < xPos) 
                    {
                        Disks[y, x] = current;
                        y--;
                        x++;
                    }
                    break;
                }
            }

            // left, x--
            for (int x = xPos - 1; x >= 0; x--)
            {
                Disk disk = Disks[yPos, x];
                if (disk.Equals(empty)) break;
                if (disk.Equals(current))
                {
                    while (x < xPos)
                    {
                        Disks[yPos, x] = current;
                        x++;
                    }
                    break;
                }
            }
        }

        /**
         * <summary>Count disks with given color</summary> 
         */
        private int CountDisks(Disk disk)
        {
            int result = 0;
            for (int y = 0; y < HEIGHT; y++)
            {
                for (int x = 0; x < WIDTH; x++)
                {
                    if (Disks[y, x].Equals(disk))
                    {
                        result++;
                    }
                }
            }
            return result;
        }

        /**
         * <summary>Get all cells where current player can put his disk</summary>
         * 
         * <param name="isWhite">Is player white</param>
         * 
         * <returns>Table of booleans</returns>
         */

        public bool[,] GetPossibleMoves(bool isWhite)
        {
            Disk current = isWhite ? Disk.White : Disk.Black;

            bool[,] result = new bool[HEIGHT, WIDTH];
            for (int y = 0; y < HEIGHT; y++)
            {
                for (int x = 0; x < WIDTH; x++)
                {
                    result[y, x] = false;
                }
            }

            for (int y = 0; y < HEIGHT; y++)
            {
                for (int x = 0; x < WIDTH; x++)
                {
                    if (!Disks[y, x].Equals(current)) continue;
                    CheckPossibleMoves(y, x, ref result, current);
                }
            }

            return result;
        }

        /**
         * <summary>Check if given player has any possible legal moves</summary>
         */
        public bool CanMove(bool isWhite) {
            bool[,] possibleMoves = GetPossibleMoves(isWhite);
            for (int y = 0; y < HEIGHT; y++) {
                for (int x = 0; x < WIDTH; x++) {
                    if (possibleMoves[y, x]) return true;
                }
            }
            return false;
        }

        private void CheckPossibleMoves(int yPos, int xPos, ref bool[,] result, Disk current)
        {
            Disk empty = Disk.Empty;
            Disk enemy = current.Equals(Disk.White) ? Disk.Black : Disk.White;

            // top left, y--, x--
            for (int y = yPos - 1, x = xPos - 1, enemies = 0; y >= 0 && x >= 0; y--, x--)
            {
                Disk disk = Disks[y, x];

                if (disk.Equals(current)) {
                    break;
                }

                if (disk.Equals(enemy))
                {
                    enemies++;
                    continue;
                }

                if (disk.Equals(empty)) {
                    if (enemies > 0) result[y, x] = true;
                    break;
                }
            }

            // top, y--
            for (int y = yPos - 1, enemies = 0; y >= 0; y--)
            {
                Disk disk = Disks[y, xPos];

                if (disk.Equals(current))
                {
                    break;
                }

                if (disk.Equals(enemy))
                {
                    enemies++;
                    continue;
                }

                if (disk.Equals(empty)) {
                    if (enemies > 0) result[y, xPos] = true;
                    break;
                }
            }

            // top right, y--, x++
            for (int y = yPos - 1, x = xPos + 1, enemies = 0; y >= 0 && x < WIDTH; y--, x++)
            {
                Disk disk = Disks[y, x];

                if (disk.Equals(current))
                {
                    break;
                }

                if (disk.Equals(enemy))
                {
                    enemies++;
                    continue;
                }

                if (disk.Equals(empty)) {
                    if (enemies > 0) result[y, x] = true;
                    break;
                }
            }

            // right, x++
            for (int x = xPos + 1, enemies = 0; x < WIDTH; x++)
            {
                Disk disk = Disks[yPos, x];

                if (disk.Equals(current))
                {
                    break;
                }

                if (disk.Equals(enemy))
                {
                    enemies++;
                    continue;
                }

                if (disk.Equals(empty)) {
                    if (enemies > 0) result[yPos, x] = true;
                    break;
                }
            }

            // bottom right, y++, x++
            for (int y = yPos + 1, x = xPos + 1, enemies = 0; y < HEIGHT && x < WIDTH; y++, x++)
            {
                Disk disk = Disks[y, x];

                if (disk.Equals(current))
                {
                    break;
                }

                if (disk.Equals(enemy))
                {
                    enemies++;
                    continue;
                }

                if (disk.Equals(empty)) {
                    if (enemies > 0) result[y, x] = true;
                    break;
                }
            }

            // bottom, y++
            for (int y = yPos + 1, enemies = 0; y < HEIGHT; y++)
            {
                Disk disk = Disks[y, xPos];

                if (disk.Equals(current))
                {
                    break;
                }

                if (disk.Equals(enemy))
                {
                    enemies++;
                    continue;
                }

                if (disk.Equals(empty)) {
                    if (enemies > 0) result[y, xPos] = true;
                    break;
                }
            }

            // bottom left, y++, x--
            for (int y = yPos + 1, x = xPos - 1, enemies = 0; y < HEIGHT && x >= 0; y++, x--)
            {
                Disk disk = Disks[y, x];

                if (disk.Equals(current))
                {
                    break;
                }

                if (disk.Equals(enemy))
                {
                    enemies++;
                    continue;
                }

                if (disk.Equals(empty)) {
                    if (enemies > 0) result[y, x] = true;
                    break;
                }
            }

            // left, x--
            for (int x = xPos - 1, enemies = 0; x >= 0; x--)
            {
                Disk disk = Disks[yPos, x];

                if (disk.Equals(current))
                {
                    break;
                }

                if (disk.Equals(enemy))
                {
                    enemies++;
                    continue;
                }

                if (disk.Equals(empty)) {
                    if (enemies > 0) result[yPos, x] = true;
                    break;
                }
            }
        }
    }
}
