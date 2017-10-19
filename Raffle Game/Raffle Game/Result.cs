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
using System.Media;

namespace Raffle_Game
{
    public partial class Result : Form
    {
        public Result()
        {
            InitializeComponent();
        }
         public int x;
         public string k;
         public string[] path = Directory.GetFiles(@"D:\C#\程序\Raffle Game\用户头像\");
         Random ran = new Random();
         Class1 cs = new Class1();
        private void Result_Load(object sender, EventArgs e)
        {
            System.Media.SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = @"D:\C#\程序\Raffle Game\刘德华 - 恭喜发财 (铃声).wav";
            sp.PlayLooping();//循环播放音乐
            int a, b, c;
            a=ran.Next(0, path.Length - 1);
            b=cs.generate(a);
            c=cs.Rgenrate(a,b);
            if (k=="")
            {
                pictureBox1.Image = Image.FromFile(path[a]);
                label1.Text = Path.GetFileNameWithoutExtension(path[a]);
                pictureBox2.BackColor = Color.Transparent;
                pictureBox3.BackColor = Color.Transparent;
            }
            else
            {
                switch (x)
                {
                    case 1: pictureBox1.Image = Image.FromFile(path[a]);
                        label1.Text = Path.GetFileNameWithoutExtension(path[a]);
                        pictureBox2.BackColor = Color.Transparent;
                        pictureBox3.BackColor = Color.Transparent;
                        break;
                    case 2:
                        pictureBox1.Image = Image.FromFile(path[a]);
                        label1.Text = Path.GetFileNameWithoutExtension(path[a]);
                        pictureBox2.Image = Image.FromFile(path[b]);
                        label2.Text = Path.GetFileNameWithoutExtension(path[b]);
                        pictureBox3.BackColor = Color.Transparent;
                        break;
                    case 3:
                        pictureBox1.Image = Image.FromFile(path[a]);
                        label1.Text = Path.GetFileNameWithoutExtension(path[a]);
                        pictureBox2.Image = Image.FromFile(path[b]);
                        label2.Text = Path.GetFileNameWithoutExtension(path[b]);
                        pictureBox3.Image = Image.FromFile(path[c]);
                        label3.Text = Path.GetFileNameWithoutExtension(path[c]);
                        break;
                    default: 
                        pictureBox1.Image = Image.FromFile(path[a]);
                        label1.Text = Path.GetFileNameWithoutExtension(path[a]);
                        pictureBox2.Image = Image.FromFile(path[b]);
                        label2.Text = Path.GetFileNameWithoutExtension(path[b]);
                        pictureBox3.Image = Image.FromFile(path[c]);
                        label3.Text = Path.GetFileNameWithoutExtension(path[c]);
                        break;
                }               
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
