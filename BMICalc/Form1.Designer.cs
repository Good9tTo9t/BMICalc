
namespace BMICalc
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.meter = new System.Windows.Forms.RadioButton();
            this.centi = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Height = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Weight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comment = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BMIval = new System.Windows.Forms.Label();
            this.Enter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // meter
            // 
            this.meter.AutoSize = true;
            this.meter.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.meter.Location = new System.Drawing.Point(810, 170);
            this.meter.Name = "meter";
            this.meter.Size = new System.Drawing.Size(63, 41);
            this.meter.TabIndex = 0;
            this.meter.Text = "m";
            this.meter.UseVisualStyleBackColor = true;
            // 
            // centi
            // 
            this.centi.AutoSize = true;
            this.centi.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.centi.Location = new System.Drawing.Point(810, 217);
            this.centi.Name = "centi";
            this.centi.Size = new System.Drawing.Size(78, 41);
            this.centi.TabIndex = 1;
            this.centi.Text = "cm";
            this.centi.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(322, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 61);
            this.label1.TabIndex = 2;
            this.label1.Text = "身高：";
            // 
            // Height
            // 
            this.Height.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Height.Location = new System.Drawing.Point(525, 181);
            this.Height.Name = "Height";
            this.Height.Size = new System.Drawing.Size(262, 71);
            this.Height.TabIndex = 3;
            this.Height.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckDigit);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(322, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 61);
            this.label2.TabIndex = 4;
            this.label2.Text = "體重：";
            // 
            // Weight
            // 
            this.Weight.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Weight.Location = new System.Drawing.Point(525, 274);
            this.Weight.Name = "Weight";
            this.Weight.Size = new System.Drawing.Size(262, 71);
            this.Weight.TabIndex = 5;
            this.Weight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckDigit);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(813, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "kgw";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(386, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(490, 81);
            this.label4.TabIndex = 7;
            this.label4.Text = "BMI Calculator";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(383, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(493, 61);
            this.label5.TabIndex = 8;
            this.label5.Text = "資訊二乙 10號 吳一弘";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(322, 461);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 61);
            this.label6.TabIndex = 9;
            this.label6.Text = "BMI：";
            // 
            // comment
            // 
            this.comment.AutoSize = true;
            this.comment.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comment.Location = new System.Drawing.Point(546, 581);
            this.comment.Name = "comment";
            this.comment.Size = new System.Drawing.Size(219, 61);
            this.comment.TabIndex = 10;
            this.comment.Text = "尚未輸入";
            this.comment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(322, 581);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 61);
            this.label8.TabIndex = 11;
            this.label8.Text = "評語：";
            // 
            // BMIval
            // 
            this.BMIval.AutoSize = true;
            this.BMIval.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.BMIval.Location = new System.Drawing.Point(546, 461);
            this.BMIval.Name = "BMIval";
            this.BMIval.Size = new System.Drawing.Size(219, 61);
            this.BMIval.TabIndex = 12;
            this.BMIval.Text = "尚未輸入";
            this.BMIval.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Enter
            // 
            this.Enter.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Enter.Location = new System.Drawing.Point(524, 363);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(263, 81);
            this.Enter.TabIndex = 13;
            this.Enter.Text = "計算";
            this.Enter.UseVisualStyleBackColor = true;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.BMIval);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comment);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Weight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Height);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.centi);
            this.Controls.Add(this.meter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton meter;
        private System.Windows.Forms.RadioButton centi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Height;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Weight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label comment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label BMIval;
        private System.Windows.Forms.Button Enter;
    }
}

