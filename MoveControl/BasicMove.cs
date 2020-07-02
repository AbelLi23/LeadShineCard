using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using csDmc2410;

namespace MoveControl
{
    public partial class BasicMove : Form
    {
        public BasicMove()
        {
            InitializeComponent();
        }

        private void BasicMove_Load(object sender, EventArgs e)
        {
            int n;
            n = Dmc2410.d2410_board_init();
            if (n < 1 || n > 8)
                MessageBox.Show("未找到控制卡", "出错");
        }

        private void BasicMove_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dmc2410.d2410_board_close();
        }
    }


}
