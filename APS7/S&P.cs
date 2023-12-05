using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APS7
{
    public class S_P
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int Top { get; set; }
        public int Left{ get; set; }
        public int FigM { get; set; }
        public Color Cl1 { get; set; }
        public Color Cl2 { get; set; }

        public S_P(int width, int height, int top, int left, int figM, Color cl1, Color cl2)
        {
            Width = width; 
            Height = height; 
            Top = top; 
            Left = left;
            FigM = figM;
            Cl1 = cl1;
            Cl2 = cl2;
        }
    }
}
