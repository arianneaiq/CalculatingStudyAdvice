using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatingStudyAdvice
{
    internal class StudyAdvice
    {
        private int calculate;


       
       public Char CalculateAdvice(int block1)
        {
            calculate = (block1) * 100 / 15;
            if (calculate == 100)
            {
                return 'A';
            }
            else if (calculate >= 75)
            {
                return 'B';
            }
            else if (calculate >= 50)
            {
                return 'C';
            }
            else if (calculate < 50)
            {
                return 'D';
            }
            else
            {
                return 'O';
            }
        }

        public Char CalculateAdvice(int block1, int block2)
        {
            calculate = (block1 + block2) * 100 / 30;

            if (calculate == 100)
            {
                return 'A';
            }
            else if (calculate >= 75)
            {
                return 'B';
            }
            else if (calculate >= 50)
            {
                return 'C';
            }
            else if (calculate < 50)
            {
                return 'D';
            }
            else
            {
                return 'O';
            }
        }

        public Char CalculateAdvice(int block1, int block2, int block3)
        {
            calculate = (block1 + block2 + block3) * 100 / 45;

            if (calculate == 100)
            {
                return 'A';
            }
            else if (calculate >= 75)
            {
                return 'B';
            }
            else if (calculate >= 50)
            {
                return 'C';
            }
            else if (calculate < 50)
            {
                return 'D';
            }
            else
            {
                return 'O';
            }
        }

        public Char CalculateAdvice(int block1, int block2, int block3, int block4)
        {
            calculate = (block1 + block2 + block3 + block4) * 100 / 60;

            if (calculate == 100)
            {
                return 'A';
            }
            else if (calculate >= 75)
            {
                return 'B';
            }
            else if (calculate >= 50)
            {
                return 'C';
            }
            else if (calculate < 50)
            {
                return 'D';
            }
            else
            {
                return 'O';
            }
        }


        public string NoAdvice()
        {
            return "No available advice";
        }

        public string GetAdviceInfo(int block)
        {
            return $"Your studyadvice is {CalculateAdvice(block)} base on block 1";
        }

        public string GetAdviceInfo(int block, int block2)
        {
            return $"Your studyadvice is {CalculateAdvice(block,block2)} base on block 1&2";
        }
        public string GetAdviceInfo(int block, int block2, int block3)
        {
            return $"Your studyadvice is {CalculateAdvice(block,block2, block3)} base on block 1,2&3";
        }
        public string GetAdviceInfo(int block, int block2, int block3, int block4)
        {
            return $"Your studyadvice is {CalculateAdvice(block,block2, block3,block4)} base on block 1,2,3&4";
        }

        



    }
}
