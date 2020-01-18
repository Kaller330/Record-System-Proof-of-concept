using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Record_System
{
    public static class Library
    {

        public static DialogResult ErrorHandler(Exception e)
        {
            return MessageBox.Show(e.ToString());
        }
    }
}
