using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Rubik_s_Cube_Timer
{
    public partial class FrmRubiksCubeTimer : Form
    {
        static List<string> AlgValues = new List<string>
        {
            "F",
            "B",
            "L",
            "R",
            "U",
            "D"
        };
        static List<string> AlgAttributes = new List<string>
        {
            " ",
            "'",
            "2"
        };

        StringBuilder ScrambleAlg = new StringBuilder();
        bool Started = false;
        bool LockBtn = false;
        Stopwatch stopWatch = new Stopwatch();
        Timer timer = new Timer
        {
            Interval = (10)
        };

        public FrmRubiksCubeTimer()
        {
            InitializeComponent();
            UpdateScrambleAlg();
        }

        private void Timer_Tick(object sender = null, EventArgs e = null)
        {
            LblTimer.Text = GetFormatedTime(stopWatch.Elapsed);

        }

        private string GetFormatedTime(TimeSpan ts)
        {
            return String.Format("{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);

        }

        private void BtnStartStop_Click(object sender, EventArgs e)
        {

            if (Started)
            {
                Started = false;
                stopWatch.Stop();
                timer.Stop();
                TimeSpan ts = stopWatch.Elapsed;
                Timer_Tick();
                AddHistoryList(GetFormatedTime(stopWatch.Elapsed));
                UpdateScrambleAlg(LockBtn);

            }
            else
            {
                Started = true;
                stopWatch.Reset();
                stopWatch.Start();
                timer.Tick += new EventHandler(Timer_Tick);
                timer.Start();

            }

            BtnStartStop.Focus();

        }

        private void AddHistoryList(string FinishedTime)
        {
            if (LstBoxHistory.Items.Contains("(none)"))
            {
                LstBoxHistory.Items.Clear();
            }

            LstBoxHistory.Items.Add(FinishedTime);

        }

        private void BtnDeleteSelected_Click(object sender, EventArgs e)
        {
            for (int i = LstBoxHistory.SelectedItems.Count - 1; i >= 0; i--)
            {
                LstBoxHistory.Items.Remove(LstBoxHistory.SelectedItems[i]);

            }

            BtnStartStop.Focus();

        }

        private void BtnNewScramble_Click(object sender, EventArgs e)
        {
            UpdateScrambleAlg(LockBtn);

            BtnStartStop.Focus();

        }

        private void NudScrambleLength_ValueChanged(object sender, EventArgs e)
        {
            UpdateScrambleAlg(true);

        }

        private void UpdateScrambleAlg(bool locked = false)
        {
            int ScrambleLength = Convert.ToInt32(NudScrambleLength.Value);

            if (!locked)
            {
                GenerateAlgorithm();

            }

            LblScrambler.Text = ScrambleAlg.ToString(0, ScrambleLength * 3);

        }

        private void BtnLockScramble_Click(object sender, EventArgs e)
        {
            if (LockBtn)
            {
                LockBtn = false;
                BtnLockScramble.Text = "Lock";

            }
            else
            {
                LockBtn = true;
                BtnLockScramble.Text = "Unlock";

            }

            BtnStartStop.Focus();

        }

        private void GenerateAlgorithm()
        {
            Random rand = new Random();
            ScrambleAlg.Clear();
            string prev1 = AlgValues[rand.Next(6)];
            string prev2 = prev1;
            string AlgValue = prev1;
            string AlgAttribute;

            for (int i = 0; i < 63; i++)
            {
                while (AlgValue == prev1 || AlgValue == prev2)
                {
                    AlgValue = AlgValues[rand.Next(6)];
                }
                prev2 = prev1;
                prev1 = AlgValue;
                AlgAttribute = AlgAttributes[rand.Next(3)];
                ScrambleAlg.Append(AlgValue + AlgAttribute + " ");

            }

        }

    }

}
