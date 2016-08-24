using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    public class Game
    {
        
        public int randomNumber;
        private int count = 9;
        private int win;
        private int lose;


        public Game()
        {
            Random random = new Random();
            randomNumber = random.Next(1, 101);
        }


        public int returnRandom()
        {
            return randomNumber;
        }


        public void newGame()
        {
            Random random = new Random();
            randomNumber = random.Next(1, 101);
            count = 9;
        }

        public void reset()
        {
            win = 0;
            lose = 0;
            count = 9;
        }


        public int logic(int numbers)
        {

            if (numbers != randomNumber)
            {
                if (count != 0)
                {
                    if (numbers > randomNumber)
                    {
                        count--;
                        return 1;
                    }
                    else if (numbers < randomNumber)
                    {
                        count--;
                        return -1;
                    }
                    else
                    {
                        win++;
                        return 0;
                    }
                }
                else
                {
                    lose++;
                    return 2;
                }
            }
            else
            {
                win++;
                return 0;
            }

        }


        public int getCount()
        {
            return count;
        }

        public int storeWin()
        {
            return win;         
        }

        public int storeLose()
        {
            return lose;
        }




    }
}
