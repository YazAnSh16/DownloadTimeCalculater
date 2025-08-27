using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace DownloadTimeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }
        
        double Speed;
        double Size;
        double resultSp;
        double resultSi;
        double resultSec;

        public object counterValue { get; private set; }

        public void Form1_Load(object sender, EventArgs e)
        {
            this.Icon = new Icon("icon.ico");
            ComboSpeed.DropDownStyle = ComboBoxStyle.DropDownList;
            comboSize.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboSpeed.SelectedIndex = 0;
            comboSize.SelectedIndex = 2;
        }

        private void txtSpeed_TextChanged(object sender, EventArgs e)
        {
            Speed = Convert.ToDouble(txtSpeed.Text);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnMspeed_Click(object sender, EventArgs e)
        {
            if (Speed > 0)
                Speed--;
           // label3.Text = Convert.ToString(Speed);
            txtSpeed.Text = Speed.ToString();

        }

        private void btnPspeed_Click(object sender, EventArgs e)
        {
            if (Speed >= 0)
                Speed++;
            //label3.Text = Convert.ToString(Speed);
            txtSpeed.Text = Speed.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Size > 0)
                Size--;
            //label3.Text = Convert.ToString(Size);
            txtSize.Text = Size.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Size >= 0)
                Size++;
            //label3.Text = Convert.ToString(Size);
            txtSize.Text = Size.ToString();
        }

        private void txtSize_TextChanged(object sender, EventArgs e)
        {
            Size = Convert.ToDouble(txtSize.Text);
        }

        private void ComboSpeed_SelectedIndexChanged(object sender, EventArgs e)
        {

            ComboSpeed.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void comboSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboSize.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void btnCalc_Click(object sender, EventArgs e)
        {
            if (ComboSpeed.SelectedIndex == 0)
            {
                if (comboSize.SelectedIndex == 0)
                {
                    resultSp = Speed / 8;
                    resultSi = (Size / 1024);
                    resultSec = resultSi / resultSp;
                }
                else if (comboSize.SelectedIndex == 1)
                {
                    resultSp = Speed / 8;
                    resultSi = (Size);
                    resultSec = resultSi / resultSp;
                }
                else if (comboSize.SelectedIndex == 2)
                {
                    resultSp = Speed / 8;
                    resultSi = (Size * 1024);
                    resultSec = resultSi / resultSp;
                }
            }
            else if (ComboSpeed.SelectedIndex == 1)
            {
                if (comboSize.SelectedIndex == 0)
                {
                    resultSp = (Speed * 1024) / 8;
                    resultSi = (Size / 1024);
                    resultSec = resultSi / resultSp;
                }
                else if (comboSize.SelectedIndex == 1)
                {
                    resultSp = (Speed * 1024) / 8;
                    resultSi = (Size);
                    resultSec = resultSi / resultSp;
                }
                else if (comboSize.SelectedIndex == 2)
                {
                    resultSp = (Speed * 1024) / 8;
                    resultSi = (Size * 1024);
                    resultSec = resultSi / resultSp;
                }
            }
            else if (ComboSpeed.SelectedIndex == 2)
            {
                if (comboSize.SelectedIndex == 0)
                {
                    resultSp = (Speed / 1024) / 8;
                    resultSi = (Size / 1024);
                    resultSec = resultSi / resultSp;
                }
                else if (comboSize.SelectedIndex == 1)
                {
                    resultSp = (Speed / 1024) / 8;
                    resultSi = (Size);
                    resultSec = resultSi / resultSp;
                }
                else if (comboSize.SelectedIndex == 2)
                {
                    resultSp = (Speed / 1024) / 8;
                    resultSi = (Size * 1024);
                    resultSec = resultSi / resultSp;
                }
            }
            TimeSpan time = new TimeSpan();
            time = TimeSpan.FromSeconds(resultSec);
            lbltime.Text = Convert.ToString(time);
        }

        private void txtSpeed_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = true;

        }
        static string Time(TimeSpan time)
        {
            if (time.TotalHours >= 1)
            {
                return $"{time.Hours} hour(s), {time.Minutes} minute(s), {time.Seconds} second(s)";
            }
            else if (time.TotalMinutes >= 1)
            {
                return $"{time.Minutes} minute(s), {time.Seconds} second(s)";
            }
            else
            {
                return $"{time.Seconds} second(s)";
            }
        }
    }

}



