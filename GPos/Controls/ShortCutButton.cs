using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPos.Controls
{
    public class ShortCutButton : Button
    {

        public long ProductId { get; set; }

        public ShortCutButton()
        {
            Width = 90;
            Height = 60;
            FlatStyle = FlatStyle.Flat;
            BackColor = Color.LightGreen;
            Margin = new Padding(2);
        }


    }
}