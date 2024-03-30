using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Binary_Tree
{
    public partial class Form1 : Form
    {
        Graphics graphics; // инициализация графики 
        int recX; // координата меча по x
        int recY; // координата меча по y      
        TNode root;
        public Form1()
        { 
            InitializeComponent();
            recX = 30; 
            recY = 30;  
            Paint += new PaintEventHandler(this.MainFormPaint);
        }
        void MainFormPaint(object sender, PaintEventArgs e) 
        {
            graphics = CreateGraphics();        
        }
        void OutputTree(TNode node, int x, int y, int shift)
        {
            if (shift < 40) shift = 40;
            if (node != null)
            {
               DrawBall(x, y, recX, recY, new SolidBrush(Color.Black), Convert.ToString(node.ValueOfNode));
                if (node.Left != null)
                {
                    Pen blackPen = new Pen(Color.Black, 3);
                    Point point1 = new Point(x, y+recY);
                    Point point2 = new Point(x - shift - 1 +recX, y + 40);
                    graphics.DrawLine(blackPen, point1, point2 );
                    OutputTree(node.Left, x - shift - 1, y + 40, shift / 2);
                }
                if (node.Right != null)
                {
                    Pen blackPen = new Pen(Color.Black, 3);
                    Point point1 = new Point(x + recX, y + recY);
                    Point point2 = new Point(x + shift + 1, y + 40);
                    graphics.DrawLine(blackPen, point1, point2);
                    OutputTree(node.Right, x + shift + 1, y + 40, shift / 2);
                }
            }
        }
        void DrawBall(int x, int y, int w, int h, SolidBrush Color, string value)
        {
            Pen blackPen = new Pen(Color, 3);
            graphics.DrawRectangle(blackPen, x, y, w, h);
            Graphics formGraphics = this.CreateGraphics();
            string drawString = value;
            Font drawFont = new Font("Arial", 16);
            SolidBrush drawBrush = new SolidBrush(System.Drawing.Color.Black);
            StringFormat drawFormat = new StringFormat();
            formGraphics.DrawString(drawString, drawFont, drawBrush, x, y, drawFormat);
            drawFont.Dispose();
            drawBrush.Dispose();
            formGraphics.Dispose();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            string[] text = textBox1.Text.Split();
            int[] values = new int[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                values[i] = Convert.ToInt32(text[i]); 
            }
            root = BinaryTree.Tree25_1(values.Length, values);
            OutputTree(root, 500, 120, 10 * values.Length);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            int n = Convert.ToInt32(textBox2.Text);
            root = BinaryTree.Tree(n);
            OutputTree(root, 500, 120, 10 * n);
            BinaryTree.Tree44(root);
            OutputTree(root, this.Width / 2, 400, 10 * (2*n));
        }
    }
}
