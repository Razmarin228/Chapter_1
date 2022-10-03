namespace Chapter_1_example_2
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
            this.btnClick = new System.Windows.Forms.Button();
            this.markFIO = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(114, 190);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(137, 23);
            this.btnClick.TabIndex = 0;
            this.btnClick.Text = "Стать волком!";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // markFIO
            // 
            this.markFIO.AutoSize = true;
            this.markFIO.Location = new System.Drawing.Point(78, 101);
            this.markFIO.Name = "markFIO";
            this.markFIO.Size = new System.Drawing.Size(209, 13);
            this.markFIO.TabIndex = 1;
            this.markFIO.Text = "Волк не тот кто не волк, а тот кто волк.";
            this.markFIO.MouseHover += new System.EventHandler(this.markFIO_MouseHover);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.markFIO);
            this.Controls.Add(this.btnClick);
            this.Name = "FormMain";
            this.Text = "Example 2";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.Label markFIO;
    }
}

