using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Cabinet_V0._1
{
    public partial class addBook : Form
    {
        public addBook()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CloseProgram_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
