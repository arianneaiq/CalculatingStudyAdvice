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
        private  StudyAdvice studyadvice; 
        public Form1()
        {
            InitializeComponent();
            studyadvice = new StudyAdvice();
        }

        private void btnCalculateAdvice_Click(object sender, EventArgs e)
        {
            studyadvice.setBlock(Convert.ToInt32(nBlock1.Value));
            studyadvice.setBlock2(Convert.ToInt32(nBlock2.Value));
            studyadvice.Calculate();

            MessageBox.Show(StudyAdvice.getStudyAdvice());
        }
    }
}
