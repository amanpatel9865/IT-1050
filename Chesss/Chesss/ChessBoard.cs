﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chesss
{
    public class ChessBoard
    {
        private string[,] chessBoard;
        public const int DIMENSION = 8;
        public Pawn pawn;
        private Move move;
        public ChessBoard()
        {
            pawn = new Pawn();
            move = new Move();
            ChessBoardHorizontalSymbol = "+---";
            ChessBoardVerticalSymbol = "| ";
        }
        public string ChessBoardHorizontalSymbol { get; set; }
        public string ChessBoardVerticalSymbol { get; set; }
        public void displayChessBoard()
        {
            while (!move.Exit)
            {
                Console.Clear();
                Console.WriteLine("   0   1   2   3   4   5   6   7");
                for (int r = 0; r < DIMENSION; r++)
                {
                    Console.Write(" ");
                for (int c = 0; c < DIMENSION; c++)
                    {
                        Console.Write(ChessBoardHorizontalSymbol);
                    }
                    Console.Write("+\n");
                for (int c = 0; c < DIMENSION; c++)
                    {
                        if (c == 0)
                            Console.Write(r + " ");
                        Console.Write(ChessBoardVerticalSymbol + Pawn.pawns[r, c] + " ");
                    }
                    Console.Write("|\n");
                }
                Console.Write(" ");
                for (int c = 0; c < DIMENSION; c++)
                {
                    Console.Write(ChessBoardHorizontalSymbol);
                }
                System.Console.Write("+\n\n");
                move.MakeMove();
            }
        }
    }
}

