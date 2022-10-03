namespace WindowsFormsApp1
{
    partial class FormMain
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
            this.markFIO = new System.Windows.Forms.Label();
            this.btnClME = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // markFIO
            // 
            this.markFIO.AutoSize = true;
            this.markFIO.Location = new System.Drawing.Point(333, 179);
            this.markFIO.Name = "markFIO";
            this.markFIO.Size = new System.Drawing.Size(149, 13);
            this.markFIO.TabIndex = 0;
            this.markFIO.Text = "Ремезов Кирилл Андреевич";
            // 
            // btnClME
            // 
            this.btnClME.Location = new System.Drawing.Point(370, 221);
            this.btnClME.Name = "btnClME";
            this.btnClME.Size = new System.Drawing.Size(75, 23);
            this.btnClME.TabIndex = 1;
            this.btnClME.Text = "Click Me";
            this.btnClME.UseVisualStyleBackColor = true;
            this.btnClME.Click += new System.EventHandler(this.btnClME_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClME);
            this.Controls.Add(this.markFIO);
            this.Name = "FormMain";
            this.Text = "Example 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label markFIO;
        private System.Windows.Forms.Button btnClME;
    }
}

