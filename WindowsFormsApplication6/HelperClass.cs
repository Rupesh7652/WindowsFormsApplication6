using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApplication6
{
    class HelperClass
    {
        public static void makefields(Control ctrl)
        {
            foreach (Control a in ctrl.Controls)
            {
                if (a is TextBox)
                    a.Text = "";
                if (a is ComboBox)
                    a.Text = null;
                if (a is CheckBox)
                    a.Text = "null";
                if (a is DateTimePicker)
                    a.Text = null;
                if (a is RadioButton)
                    a.Text = "";
            }
        }
    }
}
