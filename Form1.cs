using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HalfFull {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void textBoxInput_TextChanged(object sender, EventArgs e) {
            textBoxHalf.Text = Microsoft.VisualBasic.Strings.StrConv(textBoxInput.Text, Microsoft.VisualBasic.VbStrConv.Narrow);
            textBoxFull.Text = Microsoft.VisualBasic.Strings.StrConv(textBoxInput.Text, Microsoft.VisualBasic.VbStrConv.Wide);
        }
    }
}
