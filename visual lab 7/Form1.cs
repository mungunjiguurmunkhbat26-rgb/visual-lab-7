using System.Windows.Forms;

namespace paint_mouse_event
{

    public partial class Form1 : Form
    {
        Graphics g;     // зурах цаас
        Pen p;          // үзэг
        bool draw;      // хулганы товч дарагдсан эсэх
        int x, y;       // өмнөх цэгийн координат
        public Form1()
        {
            InitializeComponent();

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = this.CreateGraphics();
            p = new Pen(Color.Black, 2);
            draw = false;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            draw = true;
            x = e.X;
            y = e.Y;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (draw)
            {
                g.DrawLine(p, x, y, e.X, e.Y);
                x = e.X;
                y = e.Y;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            draw = false;
        }

        private void colorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                p.Color = colorDialog1.Color;

            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            p.Width = (float)numericUpDown1.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}