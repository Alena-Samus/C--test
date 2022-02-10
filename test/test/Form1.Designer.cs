
namespace test
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
            this.previousBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.QTBox = new System.Windows.Forms.TextBox();
            this.Answ1rB = new System.Windows.Forms.RadioButton();
            this.Answ2rB = new System.Windows.Forms.RadioButton();
            this.Answ3rB = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.NameTb = new System.Windows.Forms.TextBox();
            this.OkBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // previousBtn
            // 
            this.previousBtn.Location = new System.Drawing.Point(74, 384);
            this.previousBtn.Name = "previousBtn";
            this.previousBtn.Size = new System.Drawing.Size(95, 23);
            this.previousBtn.TabIndex = 3;
            this.previousBtn.Text = "Предыдущий";
            this.previousBtn.UseVisualStyleBackColor = true;
            this.previousBtn.Click += new System.EventHandler(this.previousBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(187, 384);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(86, 23);
            this.nextBtn.TabIndex = 4;
            this.nextBtn.Text = "Следующий";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(514, 384);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(75, 23);
            this.stopBtn.TabIndex = 5;
            this.stopBtn.Text = "Завершить";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // QTBox
            // 
            this.QTBox.Location = new System.Drawing.Point(25, 30);
            this.QTBox.Name = "QTBox";
            this.QTBox.Size = new System.Drawing.Size(622, 20);
            this.QTBox.TabIndex = 6;
            // 
            // Answ1rB
            // 
            this.Answ1rB.AutoSize = true;
            this.Answ1rB.Location = new System.Drawing.Point(74, 155);
            this.Answ1rB.Name = "Answ1rB";
            this.Answ1rB.Size = new System.Drawing.Size(85, 17);
            this.Answ1rB.TabIndex = 7;
            this.Answ1rB.TabStop = true;
            this.Answ1rB.Text = "radioButton1";
            this.Answ1rB.UseVisualStyleBackColor = true;
            this.Answ1rB.CheckedChanged += new System.EventHandler(this.Answ1rB_CheckedChanged);
            // 
            // Answ2rB
            // 
            this.Answ2rB.AutoSize = true;
            this.Answ2rB.Location = new System.Drawing.Point(74, 192);
            this.Answ2rB.Name = "Answ2rB";
            this.Answ2rB.Size = new System.Drawing.Size(85, 17);
            this.Answ2rB.TabIndex = 8;
            this.Answ2rB.TabStop = true;
            this.Answ2rB.Text = "radioButton2";
            this.Answ2rB.UseVisualStyleBackColor = true;
            this.Answ2rB.CheckedChanged += new System.EventHandler(this.Answ2rB_CheckedChanged);
            // 
            // Answ3rB
            // 
            this.Answ3rB.AutoSize = true;
            this.Answ3rB.Location = new System.Drawing.Point(74, 228);
            this.Answ3rB.Name = "Answ3rB";
            this.Answ3rB.Size = new System.Drawing.Size(85, 17);
            this.Answ3rB.TabIndex = 9;
            this.Answ3rB.TabStop = true;
            this.Answ3rB.Text = "radioButton3";
            this.Answ3rB.UseVisualStyleBackColor = true;
            this.Answ3rB.CheckedChanged += new System.EventHandler(this.Answ3rB_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Введите имя и фамилию тестируемого";
            // 
            // NameTb
            // 
            this.NameTb.Location = new System.Drawing.Point(211, 100);
            this.NameTb.Name = "NameTb";
            this.NameTb.Size = new System.Drawing.Size(202, 20);
            this.NameTb.TabIndex = 11;
            // 
            // OkBtn
            // 
            this.OkBtn.Location = new System.Drawing.Point(452, 100);
            this.OkBtn.Name = "OkBtn";
            this.OkBtn.Size = new System.Drawing.Size(34, 23);
            this.OkBtn.TabIndex = 12;
            this.OkBtn.Text = "ОК";
            this.OkBtn.UseVisualStyleBackColor = true;
            this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(675, 450);
            this.Controls.Add(this.OkBtn);
            this.Controls.Add(this.NameTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Answ3rB);
            this.Controls.Add(this.Answ2rB);
            this.Controls.Add(this.Answ1rB);
            this.Controls.Add(this.QTBox);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.previousBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Тест";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button previousBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.TextBox QTBox;
        private System.Windows.Forms.RadioButton Answ1rB;
        private System.Windows.Forms.RadioButton Answ2rB;
        private System.Windows.Forms.RadioButton Answ3rB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTb;
        private System.Windows.Forms.Button OkBtn;
    }
}

