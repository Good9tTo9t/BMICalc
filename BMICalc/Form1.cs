using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            if (NullandZeroCheck(Height.Text) && NullandZeroCheck(Weight.Text)) //check if textboxes are empty
            {
                //do calculation
            } else
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
        }

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
        }
    }
}
