using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using csDmc2410;

namespace MoveControl
{
    static class Program
    {
        [DllImport("kernel32.dll")]
        public static extern Boolean AllocConsole();
        [DllImport("kernel32.dll")]
        public static extern Boolean FreeConsole();
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            bool bAlloc = AllocConsole();
            Application.Run(new BasicMove());
            if (bAlloc) FreeConsole();
        }
    }
    public class LeadShineCard
    {
        public void Initialize()//Load Motion Card
        {
            ushort usCardNum = Dmc2410.d2410_board_init();
            Console.WriteLine(((usCardNum > 0 && usCardNum < 9) ? "Initiate DMC2410 succeed !" : "Initiate DMC2410 failure !") + "\n\n");
        }
        public void Close()//Unload Motion Card
        {
            Console.WriteLine("Closing the DMC2410 motion control card...\n\n");
            Dmc2410.d2410_board_close();
        }
        public void XY_Interpolation(ushort axis1, int step1, ushort axis2, int step2, ushort mode)
        {
            Console.WriteLine("Two or Multi Axises starting Interpolation motion...\n\n");
            Dmc2410.d2410_t_line2(axis1, step1, axis2, step2, mode);
        }
        public void Interpolation_Speed(double min_Vel, double max_Vel, double tacc, double tdec)
        {
            Console.WriteLine("Change Axis velocity.\n\n");
            Dmc2410.d2410_set_vector_profile(min_Vel, max_Vel, tacc, tdec);
        }
    }
    public class HX2000Axis
    {
        public ushort usAxisMark;
        public double dfCurSpeedType;
        public HX2000Axis(ushort axis_sn)
        {
            usAxisMark = axis_sn;
        }
        public void Initialize()
        {
            Console.WriteLine("Initializing the DMC2410 motion control card...\n\n");
            Dmc2410.d2410_set_pulse_outmode(usAxisMark, 5);//Set Low Level effective?
            Dmc2410.d2410_config_ALM_PIN(usAxisMark, 1, 0);//ALM signal setting
            Dmc2410.d2410_config_INP_PIN(usAxisMark, 1, 0);//INP signal setting
            Dmc2410.d2410_counter_config(usAxisMark, 3);//Input pulse counter
            Dmc2410.d2410_write_SEVON_PIN(usAxisMark, 0);//Enable axis
            Dmc2410.d2410_config_ERC_PIN(usAxisMark, 0, 0, 7, 0);//ERC signal setting
        }
        public void SetAxisHome()
        {
            int homeReturnOffset = 0;
            int homeReturnOffset0 = 1600;
            int homeReturnOffset1 = 1600;
            int homeReturnOffset2 = 1600;
            int homeReturnOffset3 = 1600;
            int homeReturnOffset4 = 1600;
            int homeReturnOffset5 = 63000;
            int homeReturnOffset6 = -25000;
            int homeReturnOffset7 = 400;
            int Flag = (Dmc2410.d2410_axis_io_status(usAxisMark)) & 0x4000;

            Console.WriteLine("Axis starting back to the Home point...\n\n");
            #region
            if (Flag == 0x4000)//Already close to Home/origin        
            {
                Dmc2410.d2410_set_HOME_pin_logic(usAxisMark, 1, 0);
                Dmc2410.d2410_config_home_mode(usAxisMark, 0, 0);
                Dmc2410.d2410_home_move(usAxisMark, 1, 0);
                while (Dmc2410.d2410_check_done(usAxisMark) == 0) { }

                //while ((Dmc2410.d2410_get_rsts(usAxisMark) & 0x8000) == 0)
                //{
                //    if (usAxisMark == 7)
                //        break;
                //}
            }
            Dmc2410.d2410_set_HOME_pin_logic(usAxisMark, 0, 0);
            Dmc2410.d2410_config_home_mode(usAxisMark, 0, 0);
            Dmc2410.d2410_home_move(usAxisMark, 2, 0);
            while (Dmc2410.d2410_check_done(usAxisMark) == 0) { }
            //while ((Dmc2410.d2410_get_rsts(usAxisMark) & 0x8000) == 0)
            //{
            //    if (usAxisMark == 7)
            //        break;
            //}

            switch (usAxisMark)
            {
                case 0:
                    homeReturnOffset = homeReturnOffset0;//WHX
                    break;
                case 1:
                    homeReturnOffset = homeReturnOffset1;//WHY
                    break;
                case 2:
                    homeReturnOffset = homeReturnOffset2;//WFX
                    break;
                case 3:
                    homeReturnOffset = homeReturnOffset3;//WFY
                    break;
                case 4:
                    homeReturnOffset = homeReturnOffset4;//EAX
                    break;
                case 5:
                    homeReturnOffset = homeReturnOffset5;//EAY
                    break;
                case 6:
                    homeReturnOffset = homeReturnOffset6;//STL
                    break;
                case 7:
                    homeReturnOffset = homeReturnOffset7;//WFT
                    break;
            }
            Dmc2410.d2410_set_HOME_pin_logic(usAxisMark, 0, 0);
            Dmc2410.d2410_t_pmove(usAxisMark, homeReturnOffset, 0);//0 means relative position
            while (Dmc2410.d2410_check_done(usAxisMark) == 0) { }
            Dmc2410.d2410_set_position(usAxisMark, 0);
            Dmc2410.d2410_set_encoder(usAxisMark, 0);//count 0 ?
            //while ((Dmc2410.d2410_get_rsts(usAxisMark) & 0x8000) == 0)
            //{
            //    if (usAxisMark == 7)
            //        break;
            //}
            #endregion
        }
        public void SetAxisSevon(bool status)//使能
        {
            if (status)
            {
                Dmc2410.d2410_write_SEVON_PIN(usAxisMark, (ushort)0);
            }
            else
                Dmc2410.d2410_write_SEVON_PIN(usAxisMark, (ushort)1);
        }
        public void SetAxisSpeed(double begvel, double runvel, double timeacc, double timedec)
        {
            Dmc2410.d2410_set_profile(usAxisMark, begvel, runvel, timeacc, timedec);
        }
        public void ChangeAxisSpeed(double dstvel)
        {
            Dmc2410.d2410_variety_speed_range(usAxisMark, 1, 10000000);//Enable change speed
            Dmc2410.d2410_change_speed(usAxisMark, dstvel);
        }
        public bool CheckDone()
        {
            if (Dmc2410.d2410_check_done(usAxisMark) == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CheckMotorArrive()
        {
            if (Dmc2410.d2410_check_done(usAxisMark) == 0)
            {
                return false;
            }
            uint axState = Dmc2410.d2410_get_rsts(usAxisMark);
            if ((axState & 0x8000) == 0x8000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void RelativeMove(int dist)
        {
            Dmc2410.d2410_t_pmove(usAxisMark, dist, 0);
        }
        public void AccuracyMove(int dist)
        {
            Dmc2410.d2410_t_pmove(usAxisMark, dist, 1);
        }
        public int CurPosition
        {
            get
            {
                return Dmc2410.d2410_get_position(usAxisMark);
            }
        }
        public double CurSpeed
        {
            get
            {
                return Dmc2410.d2410_read_current_speed(usAxisMark);
            }
        }
        public void ImdStop()
        {
            Dmc2410.d2410_imd_stop(usAxisMark);
        }
        public void SlowStop(double Tacc)
        {
            Dmc2410.d2410_decel_stop(usAxisMark, Tacc);
        }
        public void StopAndCutPower()
        {
            Dmc2410.d2410_imd_stop(usAxisMark);
            Dmc2410.d2410_write_SEVON_PIN(usAxisMark, (ushort)1);
        }
        public void ZeroCurPos()
        {
            Dmc2410.d2410_set_position(usAxisMark, 0);
            Dmc2410.d2410_set_encoder(usAxisMark, 0);
        }
        public void ChangeSpeed(double vel)
        {
            Dmc2410.d2410_variety_speed_range(usAxisMark, 1, 10000000);
            Dmc2410.d2410_change_speed(usAxisMark, vel);
        }
        public void ChangePos(int pos)
        {
            Dmc2410.d2410_reset_target_position(usAxisMark, pos);
        }
    }
}
