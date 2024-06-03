using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tic_tac_toe
{
    public class Check_win
    {
        public char isWinner(char[] letter, int num)
        {
            if(num > 2)
            {
                if (letter[0] == 'x' && letter[4] == 'x' && letter[8] == 'x')
                {
                    return 'x';
                }
                else if (letter[0] == 'o' && letter[4] == 'o' && letter[8] == 'o')
                {
                    return 'o';
                }
                else if (letter[2] == 'x' && letter[4] == 'x' && letter[6] == 'x')
                {
                    return 'x';
                }
                else if (letter[2] == 'o' && letter[4] == 'o' && letter[6] == 'o')
                {
                    return 'o';
                }

                else if (letter[0] == 'x' && letter[3] == 'x' && letter[6] == 'x')
                {
                    return 'x';
                }
                else if (letter[0] == 'o' && letter[3] == 'o' && letter[6] == 'o')
                {
                    return 'o';
                }
                else if (letter[2] == 'x' && letter[5] == 'x' && letter[8] == 'x')
                {
                    return 'x';
                }
                else if (letter[2] == 'o' && letter[5] == 'o' && letter[8] == 'o')
                {
                    return 'o';
                }
                else if (letter[1] == 'x' && letter[4] == 'x' && letter[7] == 'x')
                {
                    return 'x';
                }
                else if (letter[1] == 'o' && letter[4] == 'o' && letter[7] == 'o')
                {
                    return 'o';
                }

                else if (letter[0] == 'x' && letter[1] == 'x' && letter[2] == 'x')
                {
                    return 'x';
                }
                else if (letter[0] == 'o' && letter[1] == 'o' && letter[2] == 'o')
                {
                    return 'o';
                }
                else if (letter[3] == 'x' && letter[4] == 'x' && letter[5] == 'x')
                {
                    return 'x';
                }
                else if (letter[3] == 'o' && letter[4] == 'o' && letter[5] == 'o')
                {
                    return 'o';
                }
                else if (letter[6] == 'x' && letter[7] == 'x' && letter[8] == 'x')
                {
                    return 'x';
                }
                else if (letter[6] == 'o' && letter[7] == 'o' && letter[8] == 'o')
                {
                    return 'o';
                }

                else
                {
                    return 'n';
                }
            }
            else
            {
                return 'n';
            }
        }
    }
}
