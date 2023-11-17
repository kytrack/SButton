using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfApp1
{
    public class SButton : Button
    {
        public SButton(string cim)
        {
            this.Content = cim;
            this.Background = Brushes.LightSalmon;
        }
    }
}
