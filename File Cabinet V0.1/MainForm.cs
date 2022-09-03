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
    public partial class mainFormBack : Form
    {
        public mainFormBack()
        {
            InitializeComponent();
        }

        private void CloseProgram_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form addBook = new addBook();
            addBook.Show();
        }
    }
}
