using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowDockTest
{
    public partial class Form1 : Form
    {
        public Form1 parent;
        private int _count = 1;
        private ArrayList _children;
        public bool DockReady = false;
        public Point DockPoint;
        const int DOCK_AREA_SIZE = 20;
        int BORDER_SIZE = SystemInformation.CaptionHeight;


        public Form1(Form1 parent)
        {
            InitializeComponent();
            this.parent = parent;
            Label_MyName.Text = Name;
            Label_Parent.Text = parent == null ? "NULL" : parent.Name;
            Label_ParentCount.Text = (GetParentCount(1) - 1).ToString();
            this.OnResize(new EventArgs());
            if (parent == null)
            {
                _children = new ArrayList();
            }
        }

        private void Button_Create_Click(object sender, EventArgs e)
        {
            GetOldestParent().StartNewForm();
        }

        public void StartNewForm()
        {
            if (parent != null)
                return;
            var newform = new Form1(this);
            newform.Name = "Form" + (++_count).ToString();
            _children.Add(newform);
            newform.Show();
        }

        public int GetParentCount(int count)
        {
            if (parent != null)
            {
                return count + parent.GetParentCount(count);
            }
            else
            {
                return 1;
            }
        }

        public Form1 GetOldestParent()
        {
            if (parent != null)
            {
                return parent.GetOldestParent();
            }
            else
            {
                return this;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Label_MyName.Text = Name;
            this.Text = Name;
        }

        public ArrayList GetChildren()
        {
            return _children;
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            Label_Point.Text = Location.ToString();
            object[] forms = GetOldestParent().GetChildren().ToArray();
            if (forms == null)
                return;

            foreach(Form1 form in forms)
            {
                if (form.Name.Equals(Name))
                    continue;
                Point p1 = form.Location;
                Point p2 = this.Location;
                Console.WriteLine(p1 + ", " +p2);

                if (p2.Y >= p1.Y - DOCK_AREA_SIZE && (p2.Y + DisplayRectangle.Height) <= (p1.Y + form.DisplayRectangle.Height) + DOCK_AREA_SIZE)
                {
                    if ((p2.X + DisplayRectangle.Width) <= p1.X && (p2.X + DisplayRectangle.Width) >= p1.X - DOCK_AREA_SIZE)
                    {
                        DockReady = true;
                        DockPoint = new Point(p1.X - DisplayRectangle.Width, p1.Y);
                        return;
                    } else if (p2.X >= (p1.X + form.DisplayRectangle.Width) && p2.X <= (p1.X + form.DisplayRectangle.Width) + DOCK_AREA_SIZE)
                    {
                        DockReady = true;
                        DockPoint = new Point(p1.X + DisplayRectangle.Width, p1.Y);
                        return;
                    }
                }
                else if (p2.X >= p1.X - DOCK_AREA_SIZE && (p2.X + DisplayRectangle.Width) <= (p1.X + form.DisplayRectangle.Width) + DOCK_AREA_SIZE)
                {
                    if ((p2.Y + DisplayRectangle.Height) <= p1.Y && (p2.Y + DisplayRectangle.Height) >= p2.Y - DOCK_AREA_SIZE)
                    {
                        DockReady = true;
                        DockPoint = new Point(p1.X, p1.Y - DisplayRectangle.Height - BORDER_SIZE);
                        return;
                    }
                    else if (p2.Y >= (p1.Y + form.DisplayRectangle.Height) && p2.Y <= (p2.Y + form.DisplayRectangle.Height) + DOCK_AREA_SIZE)
                    {
                        DockReady = true;
                        DockPoint = new Point(p1.X, p1.Y + DisplayRectangle.Height + BORDER_SIZE);
                        return;
                    }
                }

                DockReady = false;
                DockPoint = this.Location;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Console.WriteLine($"{Name} mouse up");
            if (DockReady && DockPoint != null)
            {
                this.Location = DockPoint;
            }
        }

        const int WM_EXITSIZEMOVE = 0x232;

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_EXITSIZEMOVE)
            {
                if (DockReady && DockPoint != null)
                {
                    this.Location = DockPoint;
                }
            }

            base.WndProc(ref m);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Label_Width.Text = this.DisplayRectangle.Width.ToString();
            Label_Height.Text = this.DisplayRectangle.Height.ToString();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
