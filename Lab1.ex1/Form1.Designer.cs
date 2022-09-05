namespace Lab1.ex1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Deduction = new System.Windows.Forms.Button();
            this.UserLength = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.UserRadius = new System.Windows.Forms.TextBox();
            this.UserInternalRadius = new System.Windows.Forms.TextBox();
            this.UserDensity = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(65, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите данные для вычисления\r\nмассы и объема трубы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(92, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Длина";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Deduction
            // 
            this.Deduction.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Deduction.Location = new System.Drawing.Point(150, 215);
            this.Deduction.Name = "Deduction";
            this.Deduction.Size = new System.Drawing.Size(141, 29);
            this.Deduction.TabIndex = 2;
            this.Deduction.Text = "Вычислить";
            this.Deduction.UseVisualStyleBackColor = true;
            this.Deduction.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserLength
            // 
            this.UserLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserLength.Location = new System.Drawing.Point(249, 72);
            this.UserLength.Name = "UserLength";
            this.UserLength.Size = new System.Drawing.Size(100, 26);
            this.UserLength.TabIndex = 3;
            this.UserLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserLength_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(92, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Внешний радус";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(92, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Внутренний радиус";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(92, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Плотность";
            // 
            // UserRadius
            // 
            this.UserRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserRadius.Location = new System.Drawing.Point(249, 108);
            this.UserRadius.Name = "UserRadius";
            this.UserRadius.Size = new System.Drawing.Size(100, 26);
            this.UserRadius.TabIndex = 7;
            this.UserRadius.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserRadius_KeyPress);
            // 
            // UserInternalRadius
            // 
            this.UserInternalRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserInternalRadius.Location = new System.Drawing.Point(249, 140);
            this.UserInternalRadius.Name = "UserInternalRadius";
            this.UserInternalRadius.Size = new System.Drawing.Size(100, 26);
            this.UserInternalRadius.TabIndex = 8;
            this.UserInternalRadius.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.UserInternalRadius.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UserInternalRadius_KeyPress);
            // 
            // UserDensity
            // 
            this.UserDensity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserDensity.Location = new System.Drawing.Point(249, 172);
            this.UserDensity.Name = "UserDensity";
            this.UserDensity.Size = new System.Drawing.Size(100, 26);
            this.UserDensity.TabIndex = 9;
            this.UserDensity.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.UserDensity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Density_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 269);
            this.Controls.Add(this.UserDensity);
            this.Controls.Add(this.UserInternalRadius);
            this.Controls.Add(this.UserRadius);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UserLength);
            this.Controls.Add(this.Deduction);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Deduction;
        private System.Windows.Forms.TextBox UserLength;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox UserRadius;
        private System.Windows.Forms.TextBox UserInternalRadius;
        private System.Windows.Forms.TextBox UserDensity;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

