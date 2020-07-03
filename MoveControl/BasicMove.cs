using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using csDmc2410;

namespace MoveControl
{
    public partial class BasicMove : Form
    {
        private LeadShineCard LSMotionCtrl;
        private HX2000Axis Xdimension, Ydimension, Curdimension;
        private const ushort X = 0, Y = 1;
        private bool X_Enabled = false, Y_Enabled = false;
        private double Min_Vel, Max_Vel, Tac, S_Tac;

        private void button_ImdStop_Click(object sender, EventArgs e)
        {
            Dmc2410.d2410_emg_stop();
        }

        private void button_Sstart_Click(object sender, EventArgs e)
        {
            RenewParas();
            if (X_Enabled) Xdimension.RelativeMove(int.Parse(textBox_sdist.Text));
            if (Y_Enabled) Ydimension.RelativeMove(int.Parse(textBox_sdist.Text));
        }

        private void button_Istart_Click(object sender, EventArgs e)
        {
            RenewParas();
            int ix = int.Parse(textBox_ixdist.Text);
            int iy = int.Parse(textBox_iydist.Text);

            LSMotionCtrl.Interpolation_Speed(Min_Vel, Max_Vel, Tac, Tac);
            LSMotionCtrl.XY_Interpolation(X, ix, Y, iy, 0);
        }

        private void button_SlowStop_Click(object sender, EventArgs e)
        {
            Tac = double.Parse(textBox_accTime.Text);
            if (X_Enabled) Xdimension.SlowStop(Tac);
            if (Y_Enabled) Ydimension.SlowStop(Tac);
        }

        private void button_ChangePos_Click(object sender, EventArgs e)
        {
            if (X_Enabled) Xdimension.ChangePos(int.Parse(textBox_sdist2.Text));
            if (Y_Enabled) Ydimension.ChangePos(int.Parse(textBox_sdist2.Text));
        }

        private void button_ChangeVel_Click(object sender, EventArgs e)
        {
            if (X_Enabled)
            {
                Dmc2410.d2410_variety_speed_range(X, 1, 10000000);
                Xdimension.ChangeSpeed(double.Parse(textBox_sspeed.Text));
            }
            if (Y_Enabled)
            {
                Dmc2410.d2410_variety_speed_range(Y, 1, 10000000);
                Ydimension.ChangeSpeed(double.Parse(textBox_sspeed.Text));
            }
        }

        private void button_BackHome_Click(object sender, EventArgs e)
        {
            if (X_Enabled) Xdimension.SetAxisHome();
            if (Y_Enabled) Ydimension.SetAxisHome();
        }

        private void button_ZeroPos_Click(object sender, EventArgs e)
        {
            if (X_Enabled) Xdimension.ZeroCurPos();
            if (Y_Enabled) Ydimension.ZeroCurPos();
        }

        private void timer_watching_Tick(object sender, EventArgs e)
        {
            bool xcheck, ycheck;
            xcheck = checkedListBox1.GetItemChecked(X);
            ycheck = checkedListBox1.GetItemChecked(Y);
            if (xcheck && !ycheck)
            {
                Xdimension.SetAxisSevon(xcheck);
                if (Y_Enabled) Ydimension.SetAxisSevon(ycheck);
                groupBox_Slg.Enabled = true;
                groupBox_Ipl.Enabled = false;
            }
            else if (!xcheck && ycheck)
            {
                if (X_Enabled) Xdimension.SetAxisSevon(xcheck);
                Ydimension.SetAxisSevon(ycheck);
                groupBox_Slg.Enabled = true;
                groupBox_Ipl.Enabled = false;
            }
            else if (xcheck && ycheck)
            {
                Xdimension.SetAxisSevon(xcheck);
                Ydimension.SetAxisSevon(ycheck);
                groupBox_Slg.Enabled = false;
                groupBox_Ipl.Enabled = true;
            }
            else
            {
                if (X_Enabled) Xdimension.SetAxisSevon(xcheck);
                if (Y_Enabled) Ydimension.SetAxisSevon(ycheck);
                groupBox_Slg.Enabled = false;
                groupBox_Ipl.Enabled = false;
            }
            X_Enabled = xcheck; Y_Enabled = ycheck;
        }
        public BasicMove()
        {
            InitializeComponent();
        }
        private void BasicMove_Load(object sender, EventArgs e)
        {
            LSMotionCtrl = new LeadShineCard();
            Xdimension = new HX2000Axis(X);
            Ydimension = new HX2000Axis(Y);

            LSMotionCtrl.Initialize();
            Xdimension.Initialize();
            Ydimension.Initialize();

            timer_watching.Start();
        }
        private void BasicMove_FormClosed(object sender, FormClosedEventArgs e)
        {
            LSMotionCtrl.Close();
        }
        private void RenewParas()
        {
            Min_Vel = double.Parse(textBox_begSpd.Text);
            Max_Vel = double.Parse(textBox_runSpd.Text);
            Tac = double.Parse(textBox_accTime.Text);
            //S_Tac
        }
    }
}
