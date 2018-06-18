using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Created by: Tiva Rait
 * Created on: 17-06-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #25 - Numbers Nested Loops
 * This program loops through the numbers through one loop then enters another
*/

namespace NestedLoopsTivaR
{
    public partial class frmNestedLoops : Form
    {
        public frmNestedLoops()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Declare local variables
            int firstNumber;
            int secondNumber;

            // clear listbox
            this.lstNumbers.Items.Clear();

            // Loop through the numbers from 0 to 10
            for (firstNumber = 0; firstNumber <= 10; firstNumber++)
            {
                // For each of the numbers above, loop through again writing
                //beside it the second number from 0 to 10
                for (secondNumber = 0; secondNumber <= 10; secondNumber++)
                {
                    this.lstNumbers.Items.Add(firstNumber + " -> " + secondNumber);
                }
            }
        }
    }
}
