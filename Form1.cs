using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOOPS_PRACTICE_2
{
    public partial class frmFibonacciSequence : Form
    {
        public frmFibonacciSequence()
        {
            InitializeComponent();
        }

        private void frmFibonacciSequence_Load(object sender, EventArgs e)
        {
            tmrHelloKitty.Enabled = true;
        }
        int counter = 0;
        private void tmrHelloKitty_Tick(object sender, EventArgs e)
        {
            string[] helloKitty = new string[] 
            { "Screenshot 2025-06-07 233028.png", "Screenshot 2025-06-07 233040.png"};

            if (counter == 2)
            {
                counter = 0;
            }
            else
            {
                picHelloKitty.Image = Image.FromFile("Assets/" + helloKitty[counter]);
                counter++;
            }
                
            
        }

        private void btnGenerateSequence_Click(object sender, EventArgs e)
        {
            lstOutput.Items.Clear();
            int sequenceNumber;
            if (txtEnterNumber == null || !int.TryParse(txtEnterNumber.Text, out sequenceNumber)) 
            {

                MessageBox.Show("Please enter a valid number.");
            }
            else
            {
                int i = 0;
                int first, second;
                first = 0;
                second = 1;
                for (i = 0; i < sequenceNumber; i++)
                { 
                    lstOutput.Items.Add(first.ToString());
                    int next = first + second;
                    first = second;
                    second = next;
                }
                                  

            }

            

        }
    }
}
