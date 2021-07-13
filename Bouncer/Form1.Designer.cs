namespace Bouncer
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
            this.components = new System.ComponentModel.Container();
            this.Bounce = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.Bouncer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Bounce)).BeginInit();
            this.SuspendLayout();
            // 
            // Bounce
            // 
            this.Bounce.BackgroundImage = global::Bouncer.Properties.Resources.Bouncer;
            this.Bounce.Location = new System.Drawing.Point(230, 33);
            this.Bounce.Name = "Bounce";
            this.Bounce.Size = new System.Drawing.Size(21, 21);
            this.Bounce.TabIndex = 0;
            this.Bounce.TabStop = false;
            // 
            // timer
            // 
            this.timer.Interval = 20;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Bouncer
            // 
            this.Bouncer.AutoSize = true;
            this.Bouncer.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bouncer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Bouncer.Location = new System.Drawing.Point(56, 57);
            this.Bouncer.Name = "Bouncer";
            this.Bouncer.Size = new System.Drawing.Size(39, 22);
            this.Bouncer.TabIndex = 1;
            this.Bouncer.Text = "C#";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(300, 100);
            this.Controls.Add(this.Bouncer);
            this.Controls.Add(this.Bounce);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.Bounce)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Bounce;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label Bouncer;
    }
}

