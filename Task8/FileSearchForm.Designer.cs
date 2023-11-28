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
            this.execButton = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.groupBoxInputFile = new System.Windows.Forms.GroupBox();
            this.textBoxInputFile = new System.Windows.Forms.TextBox();
            this.comboBoxFiles = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBoxInputFile.SuspendLayout();
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
            this.groupBox1.Text = "Каталог";
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
            // execButton
            // 
            this.execButton.Location = new System.Drawing.Point(692, 156);
            this.execButton.Name = "execButton";
            this.execButton.Size = new System.Drawing.Size(75, 23);
            this.execButton.TabIndex = 6;
            this.execButton.Text = "Поиск";
            this.execButton.UseVisualStyleBackColor = true;
            this.execButton.Click += new System.EventHandler(this.execButton_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.Location = new System.Drawing.Point(16, 128);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(0, 20);
            this.labelResult.TabIndex = 7;
            // 
            // groupBoxInputFile
            // 
            this.groupBoxInputFile.Controls.Add(this.textBoxInputFile);
            this.groupBoxInputFile.Location = new System.Drawing.Point(12, 60);
            this.groupBoxInputFile.Name = "groupBoxInputFile";
            this.groupBoxInputFile.Size = new System.Drawing.Size(609, 41);
            this.groupBoxInputFile.TabIndex = 8;
            this.groupBoxInputFile.TabStop = false;
            this.groupBoxInputFile.Text = "Файл";
            // 
            // textBoxInputFile
            // 
            this.textBoxInputFile.Location = new System.Drawing.Point(7, 15);
            this.textBoxInputFile.Name = "textBoxInputFile";
            this.textBoxInputFile.Size = new System.Drawing.Size(596, 20);
            this.textBoxInputFile.TabIndex = 0;
            // 
            // comboBoxFiles
            // 
            this.comboBoxFiles.FormattingEnabled = true;
            this.comboBoxFiles.Location = new System.Drawing.Point(20, 157);
            this.comboBoxFiles.Name = "comboBoxFiles";
            this.comboBoxFiles.Size = new System.Drawing.Size(313, 21);
            this.comboBoxFiles.TabIndex = 9;
            // 
            // FileSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 191);
            this.Controls.Add(this.comboBoxFiles);
            this.Controls.Add(this.groupBoxInputFile);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.execButton);
            this.Controls.Add(this.checkBoxCond);
            this.Controls.Add(this.groupBox1);
            this.Name = "FileSearchForm";
            this.Text = "Поиск файлов";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxInputFile.ResumeLayout(false);
            this.groupBoxInputFile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.CheckBox checkBoxCond;
        private System.Windows.Forms.Button execButton;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.GroupBox groupBoxInputFile;
        private System.Windows.Forms.TextBox textBoxInputFile;
        private System.Windows.Forms.ComboBox comboBoxFiles;
    }
}

