using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPosBackOffice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

          //  this.tabControl1.HandleCreated += new System.EventHandler(TabControl_HandleCreated);

            var c = new GPosEntities();
            c.udt_CNV_UnitType.Load();
            udt_CNV_UnitTypeBindingSource.DataSource = c.udt_CNV_UnitType.ToList();

            foreach (TabPage item in tabControl1.TabPages)
            {
                item.Width = 80;
                item.Height = 80;
            }  


        }

        private void udt_CNV_UnitTypeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);



        void TabControl_HandleCreated(object sender, System.EventArgs e)
        {
            // Send TCM_SETMINTABWIDTH
            SendMessage((sender as TabControl).Handle, 0x1300 + 49, IntPtr.Zero, (IntPtr)4);
        }

    }
}
