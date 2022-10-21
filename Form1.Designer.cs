namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(341, 56);
            this.button1.TabIndex = 0;
            this.button1.Text = "Финансировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(492, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ЗДРАСТВУЙТЕ! ДОБРО ПОЖАЛОВАТЬ НА СТРАНИЦУ ПО ПОМОЩИ ДЕЛАМ ВОЛОНТЕРОВ!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(663, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "В ЭТОТ РАЗ НАШИ ВОЛОНТЕРЫ ПОМОГАЮТ ЖИТЕЛЯМ ОКЕАНИИ ПОСТРАДАВШИХ В РЕЗУЛЬТАТЕ ПОСЛ" +
    "ЕДНИХ ЦУНАМИ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(394, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ЕСЛИ ВАС ИНТЕРЕСУЕТ УЧАСТИЕ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(583, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "В ЭТОМ, ТО ВЫ МОЖЕТЕ ВСТУПИТЬ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(394, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(351, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "ЗАПОЛНИВ НЕКОТОРЫЕ ДОКУМЕНТЫ НАЖАВ НА ЭТУ КНОПКУ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(397, 114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(389, 56);
            this.button2.TabIndex = 9;
            this.button2.Text = "Вступить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(344, 26);
            this.label7.TabIndex = 10;
            this.label7.Text = "ЕСЛИ ВЫ ХОТИТЕ ПОДДЕРЖАТЬ ФИНАНСОВО ЭТОТ ПРОЕКТ,\r\n\r\n";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(339, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "ТО НАЖМИТЕ НА КНОПКУ И ВВЕДИТЕ НЕКОТОРЫЕ ДАННЫЕ";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(766, 269);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(51, 20);
            this.button3.TabIndex = 12;
            this.button3.Text = "выход";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 294);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Приветственное окно";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
    }
}

