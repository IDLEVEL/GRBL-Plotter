using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrblPlotter.GUI
{
    public partial class GCodeHeaderFooterForm : Form
    {
        public GCodeHeaderFooterForm()
        {
            InitializeComponent();
        }

        public void SetGcode(String gcode)
        {
            gcodeTextBox.Lines = gcode.Split(';').Select(s => s.Trim()).ToArray();
        }

        public String GetGcode()
        {
            return String.Join(";", gcodeTextBox.Lines.Select(s => s.Trim()));
        }

        private void OnSaveClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;

            Close();
        }
    }
}
