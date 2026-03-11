namespace CcharpWinFormsTask2
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
            this.textBoxInitialDeposit = new System.Windows.Forms.TextBox();
            this.TextLableInitialDeposit = new System.Windows.Forms.Label();
            this.TextLableLimitIncomeDeposit = new System.Windows.Forms.Label();
            this.textBoxLimitIncomeDeposit = new System.Windows.Forms.TextBox();
            this.TextLableLimitDeposit = new System.Windows.Forms.Label();
            this.textBoxLimitDeposit = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxInitialDeposit
            // 
            this.textBoxInitialDeposit.Location = new System.Drawing.Point(24, 50);
            this.textBoxInitialDeposit.Name = "textBoxInitialDeposit";
            this.textBoxInitialDeposit.Size = new System.Drawing.Size(100, 22);
            this.textBoxInitialDeposit.TabIndex = 0;
            // 
            // TextLableInitialDeposit
            // 
            this.TextLableInitialDeposit.AutoSize = true;
            this.TextLableInitialDeposit.Location = new System.Drawing.Point(21, 31);
            this.TextLableInitialDeposit.Name = "TextLableInitialDeposit";
            this.TextLableInitialDeposit.Size = new System.Drawing.Size(233, 16);
            this.TextLableInitialDeposit.TabIndex = 1;
            this.TextLableInitialDeposit.Text = "Введите начальную сумму вклада";
            // 
            // TextLableLimitIncomeDeposit
            // 
            this.TextLableLimitIncomeDeposit.AutoSize = true;
            this.TextLableLimitIncomeDeposit.Location = new System.Drawing.Point(21, 89);
            this.TextLableLimitIncomeDeposit.Name = "TextLableLimitIncomeDeposit";
            this.TextLableLimitIncomeDeposit.Size = new System.Drawing.Size(524, 16);
            this.TextLableLimitIncomeDeposit.TabIndex = 2;
            this.TextLableLimitIncomeDeposit.Text = "Введите число В. где число В это порог для ежемесячного увеличения вклада ";
            // 
            // textBoxLimitIncomeDeposit
            // 
            this.textBoxLimitIncomeDeposit.Location = new System.Drawing.Point(24, 108);
            this.textBoxLimitIncomeDeposit.Name = "textBoxLimitIncomeDeposit";
            this.textBoxLimitIncomeDeposit.Size = new System.Drawing.Size(98, 22);
            this.textBoxLimitIncomeDeposit.TabIndex = 3;
            // 
            // TextLableLimitDeposit
            // 
            this.TextLableLimitDeposit.AutoSize = true;
            this.TextLableLimitDeposit.Location = new System.Drawing.Point(23, 151);
            this.TextLableLimitDeposit.Name = "TextLableLimitDeposit";
            this.TextLableLimitDeposit.Size = new System.Drawing.Size(552, 16);
            this.TextLableLimitDeposit.TabIndex = 4;
            this.TextLableLimitDeposit.Text = "Введите число C, где С это через сколько месяцев размер вклада превысит C руб. ";
            // 
            // textBoxLimitDeposit
            // 
            this.textBoxLimitDeposit.Location = new System.Drawing.Point(25, 170);
            this.textBoxLimitDeposit.Name = "textBoxLimitDeposit";
            this.textBoxLimitDeposit.Size = new System.Drawing.Size(97, 22);
            this.textBoxLimitDeposit.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(31, 261);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 28);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxLimitDeposit);
            this.Controls.Add(this.TextLableLimitDeposit);
            this.Controls.Add(this.textBoxLimitIncomeDeposit);
            this.Controls.Add(this.TextLableLimitIncomeDeposit);
            this.Controls.Add(this.TextLableInitialDeposit);
            this.Controls.Add(this.textBoxInitialDeposit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInitialDeposit;
        private System.Windows.Forms.Label TextLableInitialDeposit;
        private System.Windows.Forms.Label TextLableLimitIncomeDeposit;
        private System.Windows.Forms.TextBox textBoxLimitIncomeDeposit;
        private System.Windows.Forms.Label TextLableLimitDeposit;
        private System.Windows.Forms.TextBox textBoxLimitDeposit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

