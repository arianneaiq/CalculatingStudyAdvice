using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatingStudyAdvice
{
    public partial class Form1 : Form
    {
        private StudyAdvice studyadvice; 
        public Form1()
        {
            InitializeComponent();
            studyadvice = new StudyAdvice();
        }

        private void btnCalculateAdvice_Click(object sender, EventArgs e)
        {
            int block1Value = Convert.ToInt32(nBlock1.Value);
            int block2Value = Convert.ToInt32(nBlock2.Value);
            int block3Value = Convert.ToInt32(nBlock3.Value);
            int block4Value = Convert.ToInt32(nBlock4.Value);

           if( block1Value == 0 && block2Value == 0 && block3Value == 0 && block4Value == 0)
            {
                MessageBox.Show(studyadvice.NoAdvice());
            } 
            else if (block1Value > 0 && block2Value == 0 && block3Value == 0 && block4Value == 0)
            {
                MessageBox.Show(studyadvice.GetAdviceInfo(block1Value));
            }
            else if (block1Value > 0 && block2Value > 0 && block3Value == 0 && block4Value == 0)
            {
                MessageBox.Show(studyadvice.GetAdviceInfo(block1Value, block2Value));
            }
            else if (block1Value > 0 && block2Value > 0 && block3Value > 0 && block4Value == 0)
            {
                MessageBox.Show(studyadvice.GetAdviceInfo(block1Value, block2Value, block3Value));
            } 
            else if (block1Value > 0 && block2Value > 0 && block3Value > 0 && block4Value > 0)
            {
                MessageBox.Show(studyadvice.GetAdviceInfo(block1Value, block2Value, block3Value, block4Value));
            }

          

         
           

           

           

        }
    }
}
