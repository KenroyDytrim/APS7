using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APS7
{
    public class Figure
    {
        public int Id {  get; set; }
        public PictureBox PictureBox {  get; set; }
        public Color Cl1 { get; set; }
        public Color Cl2 { get; set; }
        public int FigM { get; set; }

        public Figure(int id, PictureBox pictureBox, Color cl1, Color cl2, int figM)
        {
            Id = id;
            PictureBox = pictureBox;
            Cl1 = cl1;
            Cl2 = cl2;
            FigM = figM;
        }
    }
}
