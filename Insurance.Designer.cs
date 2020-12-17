
namespace Task8_15
{
    partial class Form
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
            this.rocket = new System.Windows.Forms.ListBox();
            this.Interface = new System.Windows.Forms.GroupBox();
            this.LaunchCount = new System.Windows.Forms.Label();
            this.InsuranceSum = new System.Windows.Forms.Label();
            this.Interface.SuspendLayout();
            this.SuspendLayout();
            // 
            // rocket
            // 
            this.rocket.BackColor = System.Drawing.SystemColors.Info;
            this.rocket.Enabled = false;
            this.rocket.FormattingEnabled = true;
            this.rocket.ItemHeight = 16;
            this.rocket.Location = new System.Drawing.Point(21, 32);
            this.rocket.Name = "rocket";
            this.rocket.Size = new System.Drawing.Size(188, 84);
            this.rocket.TabIndex = 0;
            // 
            // Interface
            // 
            this.Interface.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Interface.Controls.Add(this.InsuranceSum);
            this.Interface.Controls.Add(this.LaunchCount);
            this.Interface.Location = new System.Drawing.Point(12, 360);
            this.Interface.Name = "Interface";
            this.Interface.Size = new System.Drawing.Size(776, 78);
            this.Interface.TabIndex = 1;
            this.Interface.TabStop = false;
            // 
            // LaunchCount
            // 
            this.LaunchCount.AutoSize = true;
            this.LaunchCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LaunchCount.Location = new System.Drawing.Point(6, 18);
            this.LaunchCount.Name = "LaunchCount";
            this.LaunchCount.Size = new System.Drawing.Size(268, 29);
            this.LaunchCount.TabIndex = 0;
            this.LaunchCount.Text = "Успешных запусков: 0";
            // 
            // InsuranceSum
            // 
            this.InsuranceSum.AutoSize = true;
            this.InsuranceSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InsuranceSum.Location = new System.Drawing.Point(6, 47);
            this.InsuranceSum.Name = "InsuranceSum";
            this.InsuranceSum.Size = new System.Drawing.Size(258, 29);
            this.InsuranceSum.TabIndex = 1;
            this.InsuranceSum.Text = "Выплачено денег: 0$";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Interface);
            this.Controls.Add(this.rocket);
            this.Name = "Form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_Load);
            this.Interface.ResumeLayout(false);
            this.Interface.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox rocket;
        private System.Windows.Forms.GroupBox Interface;
        private System.Windows.Forms.Label LaunchCount;
        private System.Windows.Forms.Label InsuranceSum;
    }
}

