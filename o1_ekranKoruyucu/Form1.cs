using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace o1_ekranKoruyucu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //rastgele olarak ekranda dolaşmaslı gerekli
        Random rnd = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            // rnd.Next(0, 100);
          pictureBox1.Left = rnd.Next(0, this.Width - pictureBox1.Width);
            pictureBox1.Top = rnd.Next(0, this.Height - pictureBox1.Height);

        }
    }
}
