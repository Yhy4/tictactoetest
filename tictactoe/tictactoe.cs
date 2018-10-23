using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tictactoe
{
    public class tictactoe
    {
        public string currentplayer;
        public string[] TictactoeArray;
        public void CreateBoard() {
             TictactoeArray = new string [9];
        }
        public string CurrentPlayer(int turn) {
            if (turn % 2 == 0)
            {
                currentplayer = "X";
            }
            else {
                currentplayer = "O";
            }
            return currentplayer;
        }
        public void ChangePlayer() {
            if (currentplayer == "X")
            {
                currentplayer = "O";
            }
            else {
                currentplayer = "X";
            }
        }
        public void MakeMove(int position, string currentplayer) {
            
             TictactoeArray[position]=currentplayer;
        }
        public bool SpaceinUse(int position) {
            if (TictactoeArray[position] != "")
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }


