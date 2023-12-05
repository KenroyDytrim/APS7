using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace APS7
{
    public partial class Form1 : Form
    {
        public List<Figure> Figures = new List<Figure>();
        public List<S_P> memory = new List<S_P>();
        public Pen pen = new Pen(Color.Black);
        public SolidBrush brush = new SolidBrush(Color.White);

        public int Command = -1;

        public int Id;

        public int buff = 0;

        Invoker invoker = new Invoker();
        Receiver receiver = new Receiver();
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }
        Graphics g;
        public Rectangle rec = new Rectangle(0, 0, 0, 0);
        public int figureMode;
        public void _DoubleClick(object sender, EventArgs e)
        {
            switch (Command)
            {
                case 1:
                    Id = Convert.ToInt32((sender as Control).Tag);
                    DeleteCommand command1 = new DeleteCommand(receiver);
                    invoker.SetCommand(command1);
                    invoker.Run(this);
                    panel1.Invalidate();
                    break;
                case 2:
                    Id = Convert.ToInt32((sender as Control).Tag);
                    EditCommand command2 = new EditCommand(receiver);
                    invoker.SetCommand(command2);
                    invoker.Run(this);
                    panel1.Invalidate();
                    break;
                case 3:
                    textX.Text = (sender as Control).Left.ToString();
                    textY.Text = (sender as Control).Top.ToString();
                    textId.Text = (sender as Control).Tag.ToString();
                    break;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && rec.Width > 0 && rec.Height > 0 && Command == 0)
            {
                CreateCommand command = new CreateCommand(receiver);
                invoker.SetCommand(command);
                invoker.Run(this);  
            }
            rec.Width = 0;
            rec.Height = 0;
            panel1.Invalidate();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                rec.Width = e.X - rec.X;
                rec.Height = e.Y - rec.Y;

                panel1.Invalidate();
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                rec = new Rectangle(e.X, e.Y, 0, 0);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;

            Pen penR = new Pen(Color.Black);
            penR.DashStyle= DashStyle.Dash;

            g.DrawRectangle(penR, rec.X, rec.Y, rec.Width, rec.Height);
            g.Dispose();

        }

        private void Palitlabel_Click(object sender, EventArgs e)
        {
            Label Lb = sender as Label;
            colorDialog1.Color = Lb.BackColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                Lb.BackColor = colorDialog1.Color;
        }

        private void Palitlabel_BackColorChanged(object sender, EventArgs e)
        {
            pen.Color = Palitlabel.BackColor;
        }

        private void NizPalitlabel_BackColorChanged(object sender, EventArgs e)
        {
            brush.Color = NizPalitlabel.BackColor;
        }

        private void Figure_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle r = Figure.ClientRectangle;
            r.Width--; r.Height--;
            DrawFigure(r, g);
        }

        private void Figure_MouseDown(object sender, MouseEventArgs e)
        {
            figureMode = (figureMode + 1) % 2;
            Figure.Invalidate();
        }

        private void DrawFigure(Rectangle r, Graphics g)
        {
            SolidBrush br = new SolidBrush(Color.White);
            Pen p = new Pen(Color.Black, 2);
            switch (figureMode)
            {
                case 0:
                    g.FillRectangle(br, r);
                    g.DrawRectangle(p, r);
                    break;
                case 1:
                    g.FillEllipse(br, r);
                    g.DrawEllipse(p, r);
                    break;
            }
        }

        public void Draw()
        {
            panel1.Controls.Clear();

            for (int i = 0; i < Figures.Count; i++)
            {
                panel1.Controls.Add(Figures[i].PictureBox);

            }

            for (int i = 0; i < Figures.Count; i++)
            {
                SolidBrush br = new SolidBrush(Figures[i].Cl1);
                Pen p = new Pen(Figures[i].Cl2, 2);
                g = Graphics.FromImage(Figures[i].PictureBox.Image);

                switch (Figures[i].FigM)
                {
                    case 0:
                        g.FillRectangle(br, 0, 0, Figures[i].PictureBox.Width, Figures[i].PictureBox.Height);
                        g.DrawRectangle(p, 0, 0, Figures[i].PictureBox.Width, Figures[i].PictureBox.Height);
                        break;
                    case 1:
                        g.FillEllipse(br, 0, 0, Figures[i].PictureBox.Width, Figures[i].PictureBox.Height);
                        g.DrawEllipse(p, 0, 0, Figures[i].PictureBox.Width, Figures[i].PictureBox.Height);
                        break;
                }
                g.Dispose();
            }

        }

        private void FigB_Click(object sender, EventArgs e)
        {
            if (Command == -1)
            {
                Command = 0;
                DelB.Enabled = false;
                RepB.Enabled = false;
                MoveB.Enabled = false;
            }
            else
            {
                Command = -1;
                DelB.Enabled = true;
                RepB.Enabled = true;
                MoveB.Enabled = true;
            }
        }

        private void DelB_Click(object sender, EventArgs e)
        {
            if (Command == -1)
            {
                Command = 1;
                FigB.Enabled = false;
                RepB.Enabled = false;
                MoveB.Enabled = false;
            }
            else
            {
                Command = -1;
                FigB.Enabled = true;
                RepB.Enabled = true;
                MoveB.Enabled = true;
            }
        }

        private void RepB_Click(object sender, EventArgs e)
        {
            if (Command == -1)
            {
                Command = 2;
                FigB.Enabled = false;
                DelB.Enabled = false;
                MoveB.Enabled = false;
            }
            else
            {
                Command = -1;
                FigB.Enabled = true;
                DelB.Enabled = true;
                MoveB.Enabled = true;
            }
        }

        private void MoveB_Click(object sender, EventArgs e)
        {
            if (Command == -1)
            {
                Command = 3;
                FigB.Enabled = false;
                DelB.Enabled = false;
                RepB.Enabled = false;
                ActionB.Enabled = true;
            }
            else
            {
                Command = -1;
                FigB.Enabled = true;
                DelB.Enabled = true;
                RepB.Enabled = true;
                ActionB.Enabled = false;
            }
        }

        private void CancelB_Click(object sender, EventArgs e)
        {
            invoker.Cancel(this);
            panel1.Invalidate();
        }

        private void ActionB_Click(object sender, EventArgs e)
        {
            if (Command == 3 && textX.Text!="" && textY.Text!="" && textId.Text!="") 
            {
                Id = Convert.ToInt32(textId.Text);
                MovingCommand command = new MovingCommand(receiver);
                invoker.SetCommand(command);
                invoker.Run(this);
                panel1.Invalidate();
            }
        }
    }
}