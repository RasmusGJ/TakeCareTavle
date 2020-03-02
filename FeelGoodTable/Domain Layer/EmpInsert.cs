using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace FeelGoodTable.Domain_Layer
{
    public class EmpInsert
    {
        public TextBlock Name;
        public Image Img;
        public Image Mood;

        public EmpInsert(TextBlock n, Image i, Image m)
        {
            Name = n;
            Img = i;
            Mood = m;
        }
    }
}
