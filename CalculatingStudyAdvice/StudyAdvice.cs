using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatingStudyAdvice
{
    internal class StudyAdvice
    {
        private int block;
        private int block2;
        private int block3;
        private int block4;


        public void setBlock(int block)
        {
            if (block >= 0 && block <= 15)
            {
                this.block = block;
            }
        }

        public void setBlock2(int block2)
        {
            if (block2 >= 0 && block2 <= 15)
            {
                this.block2 = block2;
            }
        }

        public int Calculate ()
        {
           int calculate = ((block + block2) / 30) * 100;
            return calculate;

        }


        public char AdviceA()
        {
            if (Calculate() == 100)
            {
                return 'A';
            }

            else if (calculate >= 75)
            {
                AdviceB();
            }

            else if (calculate >= 50)
            {
                AdviceC();
            }

            else if (calculate < 50)
            {
                AdviceD();
            }

            
        }

        public char AdviceB()
        {
            return 'B';
        }

        public char AdviceC()
        {
            return 'C';
        }

        public char AdviceD()
        {
            return 'D';
        }

        public string getStudyAdvice()
        {
            return $"YOur study advice is {Calculate()}";
        }
       
    }
}
