using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Raffle_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int i = 0;//图片索引参数
        public string[] path = Directory.GetFiles(@"D:\C#\程序\Raffle Game\用户头像\");//获取所有图片路径
        private void Start_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
            System.Drawing.Rectangle newRectangle = Start.ClientRectangle;
            newRectangle.Inflate(-10, -10);
            e.Graphics.DrawEllipse(System.Drawing.Pens.Black, newRectangle);
            newRectangle.Inflate(1, 1);
            buttonPath.AddEllipse(newRectangle);
            Start.Region = new System.Drawing.Region(buttonPath);
        }//构造开始键图形

        private void Stop_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath buttonPath = new System.Drawing.Drawing2D.GraphicsPath();
            System.Drawing.Rectangle newRectangle = Stop.ClientRectangle;
            newRectangle.Inflate(-10, -10);
            e.Graphics.DrawEllipse(System.Drawing.Pens.Black, newRectangle);
            newRectangle.Inflate(1, 1);
            buttonPath.AddEllipse(newRectangle);
            Stop.Region = new System.Drawing.Region(buttonPath);
        }//构造停止键图形

        private void Start_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Start_MouseEnter(object sender, EventArgs e)
        {
            Start.Size = new Size(105, 105);

        }

        private void Start_MouseLeave(object sender, EventArgs e)
        {
            Start.Size = new Size(100, 100);
        }

        private void Stop_MouseEnter(object sender, EventArgs e)
        {
            Stop.Size = new Size(105, 105);
        }

        private void Stop_MouseLeave(object sender, EventArgs e)
        {
            Stop.Size = new Size(100, 100);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;//设定图片显示格式
            pictureBox1.Image = Image.FromFile(@"D:\C#\程序\Raffle Game\用户头像\backgroundDefault.jpg");//默认显示图片
        }

        private void Start_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;//启动
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            if (i > path.Length - 1) i = 0;
            pictureBox1.Image=Image.FromFile(path[i]);//循环滚动图片
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;//停止timer
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromFile(@"D:\C#\程序\Raffle Game\60a1d11ed65c4f7ca9dcaf4627ac10a4.png");
            Result result = new Result();//在内存中创建result 
            if (textBox1.Text=="")
                result.k = textBox1.Text;
            else
            {
                int y = int.Parse(textBox1.Text);
                result.x = y;
            }          
            result.Show();//弹出中奖用户窗口
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
