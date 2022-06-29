namespace Скрыть_Показать_тек.год
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
            this.chooseButton = new System.Windows.Forms.Button();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.getListBut = new System.Windows.Forms.Button();
            this.getListOPBut = new System.Windows.Forms.Button();
            this.chooseAllFormsBut = new System.Windows.Forms.Button();
            this.chooseAllOpBut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.showRadioButton = new System.Windows.Forms.RadioButton();
            this.hideRadioButton = new System.Windows.Forms.RadioButton();
            this.clearDataBut = new System.Windows.Forms.Button();
            this.startBut = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chooseButton
            // 
            this.chooseButton.Location = new System.Drawing.Point(37, 37);
            this.chooseButton.Name = "chooseButton";
            this.chooseButton.Size = new System.Drawing.Size(122, 29);
            this.chooseButton.TabIndex = 0;
            this.chooseButton.Text = "Выбор папки:";
            this.chooseButton.UseVisualStyleBackColor = true;
            this.chooseButton.Click += new System.EventHandler(this.chooseButton_Click);
            // 
            // pathTextBox
            // 
            this.pathTextBox.Enabled = false;
            this.pathTextBox.Location = new System.Drawing.Point(165, 37);
            this.pathTextBox.Multiline = true;
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(264, 29);
            this.pathTextBox.TabIndex = 1;
            // 
            // getListBut
            // 
            this.getListBut.Location = new System.Drawing.Point(37, 81);
            this.getListBut.Name = "getListBut";
            this.getListBut.Size = new System.Drawing.Size(184, 28);
            this.getListBut.TabIndex = 2;
            this.getListBut.Text = "Получить список форм";
            this.getListBut.UseVisualStyleBackColor = true;
            this.getListBut.Click += new System.EventHandler(this.getListBut_Click);
            // 
            // getListOPBut
            // 
            this.getListOPBut.Location = new System.Drawing.Point(245, 81);
            this.getListOPBut.Name = "getListOPBut";
            this.getListOPBut.Size = new System.Drawing.Size(184, 28);
            this.getListOPBut.TabIndex = 3;
            this.getListOPBut.Text = "Получить список доступных ОП";
            this.getListOPBut.UseVisualStyleBackColor = true;
            this.getListOPBut.Click += new System.EventHandler(this.getListOPBut_Click);
            // 
            // chooseAllFormsBut
            // 
            this.chooseAllFormsBut.Location = new System.Drawing.Point(37, 115);
            this.chooseAllFormsBut.Name = "chooseAllFormsBut";
            this.chooseAllFormsBut.Size = new System.Drawing.Size(184, 28);
            this.chooseAllFormsBut.TabIndex = 4;
            this.chooseAllFormsBut.Text = "Выбрать все";
            this.chooseAllFormsBut.UseVisualStyleBackColor = true;
            this.chooseAllFormsBut.Click += new System.EventHandler(this.chooseAllFormsBut_Click);
            // 
            // chooseAllOpBut
            // 
            this.chooseAllOpBut.Location = new System.Drawing.Point(245, 115);
            this.chooseAllOpBut.Name = "chooseAllOpBut";
            this.chooseAllOpBut.Size = new System.Drawing.Size(184, 28);
            this.chooseAllOpBut.TabIndex = 5;
            this.chooseAllOpBut.Text = "Выбрать все";
            this.chooseAllOpBut.UseVisualStyleBackColor = true;
            this.chooseAllOpBut.Click += new System.EventHandler(this.chooseAllOpBut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Доступные формы:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Доступные ОП:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.showRadioButton);
            this.groupBox1.Controls.Add(this.hideRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(37, 491);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 31);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // showRadioButton
            // 
            this.showRadioButton.AutoSize = true;
            this.showRadioButton.Location = new System.Drawing.Point(208, 10);
            this.showRadioButton.Name = "showRadioButton";
            this.showRadioButton.Size = new System.Drawing.Size(147, 17);
            this.showRadioButton.TabIndex = 1;
            this.showRadioButton.TabStop = true;
            this.showRadioButton.Text = "Показать #текущий год";
            this.showRadioButton.UseVisualStyleBackColor = true;
            // 
            // hideRadioButton
            // 
            this.hideRadioButton.AutoSize = true;
            this.hideRadioButton.Location = new System.Drawing.Point(0, 10);
            this.hideRadioButton.Name = "hideRadioButton";
            this.hideRadioButton.Size = new System.Drawing.Size(136, 17);
            this.hideRadioButton.TabIndex = 0;
            this.hideRadioButton.TabStop = true;
            this.hideRadioButton.Text = "Скрыть #текущий год";
            this.hideRadioButton.UseVisualStyleBackColor = true;
            // 
            // clearDataBut
            // 
            this.clearDataBut.Location = new System.Drawing.Point(37, 528);
            this.clearDataBut.Name = "clearDataBut";
            this.clearDataBut.Size = new System.Drawing.Size(184, 28);
            this.clearDataBut.TabIndex = 11;
            this.clearDataBut.Text = "Очистить данные";
            this.clearDataBut.UseVisualStyleBackColor = true;
            this.clearDataBut.Click += new System.EventHandler(this.clearDataBut_Click);
            // 
            // startBut
            // 
            this.startBut.Location = new System.Drawing.Point(245, 528);
            this.startBut.Name = "startBut";
            this.startBut.Size = new System.Drawing.Size(184, 28);
            this.startBut.TabIndex = 12;
            this.startBut.Text = "Запуск";
            this.startBut.UseVisualStyleBackColor = true;
            this.startBut.Click += new System.EventHandler(this.startBut_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(37, 177);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(182, 274);
            this.checkedListBox1.TabIndex = 13;
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.CheckOnClick = true;
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Location = new System.Drawing.Point(245, 177);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(184, 274);
            this.checkedListBox2.TabIndex = 14;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(492, 81);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(235, 251);
            this.listBox1.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(343, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 17;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(37, 457);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(392, 28);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 566);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.clearDataBut);
            this.Controls.Add(this.startBut);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chooseAllOpBut);
            this.Controls.Add(this.chooseAllFormsBut);
            this.Controls.Add(this.getListOPBut);
            this.Controls.Add(this.getListBut);
            this.Controls.Add(this.pathTextBox);
            this.Controls.Add(this.chooseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Скрыть/Показать тек. год";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button chooseButton;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Button getListBut;
        private System.Windows.Forms.Button getListOPBut;
        private System.Windows.Forms.Button chooseAllFormsBut;
        private System.Windows.Forms.Button chooseAllOpBut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton showRadioButton;
        private System.Windows.Forms.RadioButton hideRadioButton;
        private System.Windows.Forms.Button clearDataBut;
        private System.Windows.Forms.Button startBut;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

