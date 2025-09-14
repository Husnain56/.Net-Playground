using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowLayout
{
    internal class MyButton : Button
    {
        TextBox _txt;
        public MyButton(TextBox txt)
        {
            MyText = txt;
        }
        public TextBox MyText
        {
            get => _txt;
            set => _txt = value;
        }
    }
}
