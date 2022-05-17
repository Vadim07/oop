namespace LabOOP
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
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.labelA = new System.Windows.Forms.Label();
            this.labelP = new System.Windows.Forms.Label();
            this.ResultP = new System.Windows.Forms.Label();
            this.labelS = new System.Windows.Forms.Label();
            this.ResultS = new System.Windows.Forms.Label();
            this.buttonResultS = new System.Windows.Forms.Button();
            this.buttonResultP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxA
            // 
            this.textBoxA.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBoxA.Location = new System.Drawing.Point(178, 25);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(100, 20);
            this.textBoxA.TabIndex = 0;
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(30, 28);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(142, 13);
            this.labelA.TabIndex = 1;
            this.labelA.Text = "Введите сторону квадрата";
            // 
            // labelP
            // 
            this.labelP.AutoSize = true;
            this.labelP.Location = new System.Drawing.Point(30, 91);
            this.labelP.Name = "labelP";
            this.labelP.Size = new System.Drawing.Size(17, 13);
            this.labelP.TabIndex = 2;
            this.labelP.Text = "P:";
            // 
            // ResultP
            // 
            this.ResultP.AutoSize = true;
            this.ResultP.Location = new System.Drawing.Point(105, 91);
            this.ResultP.Name = "ResultP";
            this.ResultP.Size = new System.Drawing.Size(16, 13);
            this.ResultP.TabIndex = 3;
            this.ResultP.Text = "...";
            // 
            // labelS
            // 
            this.labelS.AutoSize = true;
            this.labelS.Location = new System.Drawing.Point(30, 154);
            this.labelS.Name = "labelS";
            this.labelS.Size = new System.Drawing.Size(17, 13);
            this.labelS.TabIndex = 4;
            this.labelS.Text = "S:";
            // 
            // ResultS
            // 
            this.ResultS.AutoSize = true;
            this.ResultS.Location = new System.Drawing.Point(105, 154);
            this.ResultS.Name = "ResultS";
            this.ResultS.Size = new System.Drawing.Size(16, 13);
            this.ResultS.TabIndex = 5;
            this.ResultS.Text = "...";
            // 
            // buttonResultS
            // 
            this.buttonResultS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonResultS.Location = new System.Drawing.Point(33, 191);
            this.buttonResultS.Name = "buttonResultS";
            this.buttonResultS.Size = new System.Drawing.Size(245, 23);
            this.buttonResultS.TabIndex = 6;
            this.buttonResultS.Text = "Найти S";
            this.buttonResultS.UseVisualStyleBackColor = true;
            this.buttonResultS.Click += new System.EventHandler(this.buttonResultS_Click);
            // 
            // buttonResultP
            // 
            this.buttonResultP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonResultP.Location = new System.Drawing.Point(33, 241);
            this.buttonResultP.Name = "buttonResultP";
            this.buttonResultP.Size = new System.Drawing.Size(245, 23);
            this.buttonResultP.TabIndex = 7;
            this.buttonResultP.Text = "Найти Р";
            this.buttonResultP.UseVisualStyleBackColor = true;
            this.buttonResultP.Click += new System.EventHandler(this.buttonResultP_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(307, 320);
            this.Controls.Add(this.buttonResultP);
            this.Controls.Add(this.buttonResultS);
            this.Controls.Add(this.ResultS);
            this.Controls.Add(this.labelS);
            this.Controls.Add(this.ResultP);
            this.Controls.Add(this.labelP);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.textBoxA);
            this.Name = "Form1";
            this.Text = "Квадрат";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelP;
        private System.Windows.Forms.Label ResultP;
        private System.Windows.Forms.Label labelS;
        private System.Windows.Forms.Label ResultS;
        private System.Windows.Forms.Button buttonResultS;
        private System.Windows.Forms.Button buttonResultP;
    }
}

