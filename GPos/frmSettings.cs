using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPos
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
        }

        private void btnNewGuid_Click(object sender, EventArgs e)
        {
            
            txtUnique.Text = Guid.NewGuid().ToString();
        
    }
}
}
