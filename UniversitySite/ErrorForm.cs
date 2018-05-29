using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversitySite
{
    public partial class ErrorForm : Form
    {
        public ErrorForm(string text)
        {
            InitializeComponent();
            ResultLabel.Text = text;
        }

        private void ErrorForm_Load(object sender, EventArgs e)
        {

        }
    }
}
