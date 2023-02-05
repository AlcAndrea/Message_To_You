using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Happy_Valentine_s_Day
{
    public partial class vDay : Form
    {
        public vDay()
        {
            InitializeComponent();
        }

        private void questionButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I like you, will you be valentine now and forever?");
            DialogResult dialogResult = MessageBox.Show("Will you reciprocate those feelings back to me?", "It would be nice if you accept it...", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ;
                MessageBox.Show("Oh my gosh, you feel the same. Let's be lovers <3");
                this.Close();
            }

            else if (dialogResult == DialogResult.No)
            {
                ;
                MessageBox.Show("It is okay, I am used to it.");
                this.Close();
            }
        }
    }
}