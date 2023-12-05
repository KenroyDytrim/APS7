using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APS7
{
    abstract class Command
    {
        public abstract void Execute(Form1 form, int id);
        public abstract void Undo(Form1 form, int id);
    }
    class CreateCommand: Command
    {
        Receiver receiver;
        public CreateCommand(Receiver r)
        {
            receiver = r;
        }
        public override void Execute(Form1 form, int id)
        {
            receiver.Create(form, -1);
        }

        public override void Undo(Form1 form, int id)
        {
            receiver.Delete(form, id);
        }
    }
    class DeleteCommand : Command
    {
        Receiver receiver;
        public DeleteCommand(Receiver r)
        {
            receiver = r;
        }
        public override void Execute(Form1 form, int id)
        {
            receiver.Delete(form, -1);
        }

        public override void Undo(Form1 form, int id)
        {
            receiver.Create(form, id);
        }
    }
    class MovingCommand : Command
    {
        Receiver receiver;
        public MovingCommand(Receiver r)
        {
            receiver = r;
        }
        public override void Execute(Form1 form, int id)
        {
            receiver.Move(form, -1);
        }

        public override void Undo(Form1 form, int id)
        {
            receiver.Move(form, id);
        }
    }
    class EditCommand : Command
    {
        Receiver receiver;
        public EditCommand(Receiver r)
        {
            receiver = r;
        }
        public override void Execute(Form1 form, int id)
        {
            receiver.Repaint(form, -1);
        }

        public override void Undo(Form1 form, int id)
        {
            receiver.Repaint(form, id);
        }
    }
    class Receiver
    {
        public void Create(Form1 form, int id)
        {
            var panel = form.panel1;

            GraphicsPath path = new GraphicsPath();

            Rectangle rect= new Rectangle();

            PictureBox pictureBox = new PictureBox();

            if (id == -1)
            {
                pictureBox.Tag = form.buff;
                pictureBox.Image = new Bitmap(form.rec.Width, form.rec.Height);
                pictureBox.Width = form.rec.Width;
                pictureBox.Height = form.rec.Height;
                pictureBox.Top = form.rec.Y;
                pictureBox.Left = form.rec.X;
                pictureBox.Cursor = Cursors.Hand;

                rect = new Rectangle(0, 0, form.rec.Width, form.rec.Height);

                if (form.figureMode == 1)
                {
                    path.AddEllipse(rect);
                    Region region = new Region(path);
                    pictureBox.Region = region;
                }
                form.Figures.Add(new Figure(form.buff, pictureBox, form.brush.Color, form.pen.Color, form.figureMode));
                form.memory.Add(new S_P(form.Figures.Last().PictureBox.Width, form.Figures.Last().PictureBox.Height, form.Figures.Last().PictureBox.Top, form.Figures.Last().PictureBox.Left, form.Figures.Last().FigM, form.Figures.Last().Cl1, form.Figures.Last().Cl2));
                form.buff += 1;
            }
            else
            {
                pictureBox.Tag = id;
                pictureBox.Image = new Bitmap(form.memory.Last().Width, form.memory.Last().Height);
                pictureBox.Width = form.memory.Last().Width;
                pictureBox.Height = form.memory.Last().Height;
                pictureBox.Top = form.memory.Last().Top;
                pictureBox.Left = form.memory.Last().Left;
                pictureBox.Cursor = Cursors.Hand;

                rect = new Rectangle(0, 0, form.memory.Last().Width, form.memory.Last().Height);

                if (form.memory.Last().FigM == 1)
                {
                    path.AddEllipse(rect);
                    Region region = new Region(path);
                    pictureBox.Region = region;
                }
                form.Figures.Add(new Figure(id, pictureBox, form.memory.Last().Cl1, form.memory.Last().Cl2, form.memory.Last().FigM));
                form.memory.Remove(form.memory.Last());
            }

            pictureBox.DoubleClick += form._DoubleClick;

            form.Draw();
        }
        public void Delete(Form1 form, int id)
        {
            if (id == -1)
            {
                for (int i = 0; i < form.Figures.Count; i++)
                {
                    if (Convert.ToInt32(form.Figures[i].Id) == form.Id)
                    {
                        form.memory.Add(new S_P(form.Figures[i].PictureBox.Width, form.Figures[i].PictureBox.Height, form.Figures[i].PictureBox.Top, form.Figures[i].PictureBox.Left, form.Figures[i].FigM, form.Figures[i].Cl1, form.Figures[i].Cl2));
                        form.Figures.RemoveAt(i);
                        break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < form.Figures.Count; i++)
                {
                    if (Convert.ToInt32(form.Figures[i].Id) == id)
                    {
                        form.Figures.RemoveAt(i);
                        form.memory.Remove(form.memory.Last());
                        break;
                    }
                }
            }
            form.Draw();
        }
        public void Repaint(Form1 form, int id)
        {
            if (id == -1)
            {
                for (int i = 0; i < form.Figures.Count; i++)
                {
                    if (Convert.ToInt32(form.Figures[i].Id) == form.Id)
                    {
                        form.memory.Add(new S_P(form.Figures[i].PictureBox.Width, form.Figures[i].PictureBox.Height, form.Figures[i].PictureBox.Top, form.Figures[i].PictureBox.Left, form.Figures[i].FigM, form.Figures[i].Cl1, form.Figures[i].Cl2));
                        form.Figures[i].Cl1 = form.brush.Color;
                        form.Figures[i].Cl2 = form.pen.Color;
                        break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < form.Figures.Count; i++)
                {
                    if (Convert.ToInt32(form.Figures[i].Id) == id)
                    {
                        form.Figures[i].Cl1 = form.memory.Last().Cl1;
                        form.Figures[i].Cl2 = form.memory.Last().Cl2;
                        form.memory.Remove(form.memory.Last());
                        break;
                    }  
                }
            }
            form.Draw();
        }
        public void Move(Form1 form, int id)
        {
            if (id == -1)
            {
                for (int i = 0; i < form.Figures.Count; i++)
                {
                    if (Convert.ToInt32(form.Figures[i].Id) == Convert.ToInt32(form.textId.Text))
                    {
                        form.memory.Add(new S_P(form.Figures[i].PictureBox.Width, form.Figures[i].PictureBox.Height, form.Figures[i].PictureBox.Top, form.Figures[i].PictureBox.Left, form.Figures[i].FigM, form.Figures[i].Cl1, form.Figures[i].Cl2));
                        form.Figures[i].PictureBox.Left = Convert.ToInt32(form.textX.Text);
                        form.Figures[i].PictureBox.Top = Convert.ToInt32(form.textY.Text);
                        break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < form.Figures.Count; i++)
                {
                    if (Convert.ToInt32(form.Figures[i].Id) == id)
                    {
                        form.Figures[i].PictureBox.Left = Convert.ToInt32(form.memory.Last().Left);
                        form.Figures[i].PictureBox.Top = Convert.ToInt32(form.memory.Last().Top);
                        form.memory.Remove(form.memory.Last());
                        break;
                    }
                }
            }
            form.Draw();
        }
    }
    class Invoker
    {
        Command command;
        private Stack<Command> history;
        public List<int> idH;
        public Invoker()
        {
            history = new Stack<Command>();
            idH = new List<int>();
        }
        public void SetCommand(Command c)
        {
            command = c;
            history.Push(command);
        }
        public void Run(Form1 form)
        {
            switch (form.Command)
            {
                case 0:
                    idH.Add(form.buff);
                    break;
                case 1:
                    idH.Add(form.Id);
                    break;
                case 2:
                    idH.Add(form.Id);
                    break;
                case 3:
                    idH.Add(form.Id);
                    break;
            }
            command.Execute(form, -1);
        }
        public void Cancel(Form1 form)
        {
            if (history.Count != 0 && idH.Count != 0)
            {
                history.Pop().Undo(form, idH.Last());
                idH.RemoveAt(idH.Count-1);
            }
        }
    }
}