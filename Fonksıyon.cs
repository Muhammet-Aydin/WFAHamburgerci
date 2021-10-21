using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAHamburgerci
{
    public class Fonksıyon
    {
        public static void Temizle(Control.ControlCollection kolleksıyon)
        {

            foreach (var item in kolleksıyon)
            {
                if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    txt.Clear();
                }             
                else if (item is RadioButton)
                {
                    
                    RadioButton rb = (RadioButton)item;
                    if (rb.Name=="rbküçük")
                    {
                        rb.Checked = true;
                    }
                    //rb.Checked = false;//formda bırı tıklı gelir o sekıldede  secilebilir.
                }
                else if (item is NumericUpDown)
                {
                    NumericUpDown nmr =(NumericUpDown)item;
                    nmr.Value = 1;
                }
                else if (item is CheckBox)
                {
                    CheckBox cb = (CheckBox)item;
                    cb.Checked = false;
                }
                else if (item is GroupBox)
                {
                    GroupBox gr = (GroupBox)item;
                    Temizle(gr.Controls);
                }
                else if (item is ComboBox )
                {
                    ComboBox cmb = (ComboBox)item;
                    cmb.SelectedIndex = 0;
                }
                else if (item is FlowLayoutPanel)
                {
                    FlowLayoutPanel flp = (FlowLayoutPanel)item;
                    Temizle(flp.Controls);
                }
            }
        }
    }
}
