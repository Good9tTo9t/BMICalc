using System;
using System.Drawing;
using System.Windows.Forms;

namespace BMICalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false; // 禁用最大化按鈕
            this.MaximumSize = new Size(1280, 720); // 設定最大視窗大小為 1280x720
            this.MinimumSize = new Size(1280, 720); // 設定最小視窗大小為 1280x720
            this.Text = "BMI Calculator"; //設定視窗標題
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            if (NullandZeroCheck(Height.Text) && NullandZeroCheck(Weight.Text) && (meter.Checked || centi.Checked)) //檢查錯誤的輸入值或未選擇radioButton
            {
                double BMI = 0, h, w;
                h = double.Parse(Height.Text);
                w = double.Parse(Weight.Text);

                if (meter.Checked) //公尺
                {
                    BMI = w / Math.Pow(h, 2);
                }
                else if (centi.Checked) //公分
                {
                    BMI = w / Math.Pow(h / 100, 2);
                } //計算BMI

                BMIval.Text = Math.Round(BMI, 2).ToString(); //顯示BMI
                BMIval.Text += "Kg/m^2"; //顯示單位

                if (BMI < 18.5)
                {
                    comment.Text = "「體重過輕」";
                }
                else if (BMI < 24)
                {
                    comment.Text = "「健康體重」";
                }
                else if (BMI < 27)
                {
                    comment.Text = "「體重過重」";
                }
                else
                {
                    comment.Text = "「肥胖」";
                } // 顯示建議評語
            }
            else //字串為空或0或未勾選單位
            {
                MessageBox.Show("輸入值有誤", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool NullandZeroCheck(string txt)
        {
            if (String.IsNullOrEmpty(txt) || !double.TryParse(txt, out _) || double.Parse(txt) == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }//檢查字串是否為0或空

        private void CheckDigit(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // only numbers can be entered
            if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            // only the first decimal point can be entered
        }//所有輸入欄的KeyPress參考此函式即可限定數字輸入
    }
}
