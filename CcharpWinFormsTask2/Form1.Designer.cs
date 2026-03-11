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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxInitialDeposit = new System.Windows.Forms.TextBox();
            this.TextLableInitialDeposit = new System.Windows.Forms.Label();
            this.TextLableLimitIncomeDeposit = new System.Windows.Forms.Label();
            this.textBoxLimitIncomeDeposit = new System.Windows.Forms.TextBox();
            this.TextLableLimitDeposit = new System.Windows.Forms.Label();
            this.textBoxLimitDeposit = new System.Windows.Forms.TextBox();
            this.buttonMonthIncrease = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelTaskDescription = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxInitialDeposit
            // 
            this.textBoxInitialDeposit.Location = new System.Drawing.Point(13, 126);
            this.textBoxInitialDeposit.Name = "textBoxInitialDeposit";
            this.textBoxInitialDeposit.Size = new System.Drawing.Size(100, 22);
            this.textBoxInitialDeposit.TabIndex = 0;
            // 
            // TextLableInitialDeposit
            // 
            this.TextLableInitialDeposit.AutoSize = true;
            this.TextLableInitialDeposit.Location = new System.Drawing.Point(10, 107);
            this.TextLableInitialDeposit.Name = "TextLableInitialDeposit";
            this.TextLableInitialDeposit.Size = new System.Drawing.Size(233, 16);
            this.TextLableInitialDeposit.TabIndex = 1;
            this.TextLableInitialDeposit.Text = "Введите начальную сумму вклада";
            // 
            // TextLableLimitIncomeDeposit
            // 
            this.TextLableLimitIncomeDeposit.AutoSize = true;
            this.TextLableLimitIncomeDeposit.Location = new System.Drawing.Point(10, 165);
            this.TextLableLimitIncomeDeposit.Name = "TextLableLimitIncomeDeposit";
            this.TextLableLimitIncomeDeposit.Size = new System.Drawing.Size(524, 16);
            this.TextLableLimitIncomeDeposit.TabIndex = 2;
            this.TextLableLimitIncomeDeposit.Text = "Введите число В. где число В это порог для ежемесячного увеличения вклада ";
            // 
            // textBoxLimitIncomeDeposit
            // 
            this.textBoxLimitIncomeDeposit.Location = new System.Drawing.Point(13, 184);
            this.textBoxLimitIncomeDeposit.Name = "textBoxLimitIncomeDeposit";
            this.textBoxLimitIncomeDeposit.Size = new System.Drawing.Size(98, 22);
            this.textBoxLimitIncomeDeposit.TabIndex = 3;
            // 
            // TextLableLimitDeposit
            // 
            this.TextLableLimitDeposit.AutoSize = true;
            this.TextLableLimitDeposit.Location = new System.Drawing.Point(12, 227);
            this.TextLableLimitDeposit.Name = "TextLableLimitDeposit";
            this.TextLableLimitDeposit.Size = new System.Drawing.Size(552, 16);
            this.TextLableLimitDeposit.TabIndex = 4;
            this.TextLableLimitDeposit.Text = "Введите число C, где С это через сколько месяцев размер вклада превысит C руб. ";
            // 
            // textBoxLimitDeposit
            // 
            this.textBoxLimitDeposit.Location = new System.Drawing.Point(14, 246);
            this.textBoxLimitDeposit.Name = "textBoxLimitDeposit";
            this.textBoxLimitDeposit.Size = new System.Drawing.Size(97, 22);
            this.textBoxLimitDeposit.TabIndex = 5;
            // 
            // buttonMonthIncrease
            // 
            this.buttonMonthIncrease.Location = new System.Drawing.Point(13, 274);
            this.buttonMonthIncrease.Name = "buttonMonthIncrease";
            this.buttonMonthIncrease.Size = new System.Drawing.Size(602, 33);
            this.buttonMonthIncrease.TabIndex = 6;
            this.buttonMonthIncrease.Text = "Отобразить через сколько ежемесячный процент дохода превысит заданный процент";
            this.buttonMonthIncrease.UseVisualStyleBackColor = true;
            this.buttonMonthIncrease.Click += new System.EventHandler(this.buttonMonthIncrease_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 313);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(600, 28);
            this.button2.TabIndex = 7;
            this.button2.Text = "Отобразить месяц когда размер влкад превысит лимит \r\n";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelTaskDescription
            // 
            this.labelTaskDescription.AutoSize = true;
            this.labelTaskDescription.Location = new System.Drawing.Point(12, 9);
            this.labelTaskDescription.Name = "labelTaskDescription";
            this.labelTaskDescription.Size = new System.Drawing.Size(532, 80);
            this.labelTaskDescription.TabIndex = 8;
            this.labelTaskDescription.Text = resources.GetString("labelTaskDescription.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTaskDescription);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonMonthIncrease);
            this.Controls.Add(this.textBoxLimitDeposit);
            this.Controls.Add(this.TextLableLimitDeposit);
            this.Controls.Add(this.textBoxLimitIncomeDeposit);
            this.Controls.Add(this.TextLableLimitIncomeDeposit);
            this.Controls.Add(this.TextLableInitialDeposit);
            this.Controls.Add(this.textBoxInitialDeposit);
            this.Name = "Form1";
            this.Text = "Вклад";
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
        private System.Windows.Forms.Button buttonMonthIncrease;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelTaskDescription;
    }
}

