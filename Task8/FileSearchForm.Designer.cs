namespace Task8
{
    partial class FileSearchForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.checkBoxCond = new System.Windows.Forms.CheckBox();
            this.comboBoxResult = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.execButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxInput);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(609, 41);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(7, 15);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(596, 20);
            this.textBoxInput.TabIndex = 0;
            // 
            // checkBoxCond
            // 
            this.checkBoxCond.AutoSize = true;
            this.checkBoxCond.Location = new System.Drawing.Point(633, 28);
            this.checkBoxCond.Name = "checkBoxCond";
            this.checkBoxCond.Size = new System.Drawing.Size(142, 17);
            this.checkBoxCond.TabIndex = 3;
            this.checkBoxCond.Text = "Включать подкаталоги";
            this.checkBoxCond.UseVisualStyleBackColor = true;
            // 
            // comboBoxResult
            // 
            this.comboBoxResult.FormattingEnabled = true;
            this.comboBoxResult.Location = new System.Drawing.Point(7, 19);
            this.comboBoxResult.Name = "comboBoxResult";
            this.comboBoxResult.Size = new System.Drawing.Size(305, 21);
            this.comboBoxResult.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxResult);
            this.groupBox2.Location = new System.Drawing.Point(13, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(323, 52);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Найденные файлы/подкаталоги";
            // 
            // execButton
            // 
            this.execButton.Location = new System.Drawing.Point(692, 105);
            this.execButton.Name = "execButton";
            this.execButton.Size = new System.Drawing.Size(75, 23);
            this.execButton.TabIndex = 6;
            this.execButton.Text = "Поиск";
            this.execButton.UseVisualStyleBackColor = true;
            this.execButton.Click += new System.EventHandler(this.execButton_Click);
            // 
            // FileSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 140);
            this.Controls.Add(this.execButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.checkBoxCond);
            this.Controls.Add(this.groupBox1);
            this.Name = "FileSearchForm";
            this.Text = "Поиск файлов";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.CheckBox checkBoxCond;
        private System.Windows.Forms.ComboBox comboBoxResult;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button execButton;
    }
}

