namespace CreditCalc
{
    partial class MainForm
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tbSum = new System.Windows.Forms.TextBox();
            this.tbTime = new System.Windows.Forms.TextBox();
            this.tbPercent = new System.Windows.Forms.TextBox();
            this.btCalculate = new System.Windows.Forms.Button();
            this.lbSum = new System.Windows.Forms.Label();
            this.lbOverpayment = new System.Windows.Forms.Label();
            this.lbPayment = new System.Windows.Forms.Label();
            this.btPaymentsGraph = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(20, 21);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(614, 367);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btPaymentsGraph);
            this.tabPage1.Controls.Add(this.lbPayment);
            this.tabPage1.Controls.Add(this.lbOverpayment);
            this.tabPage1.Controls.Add(this.lbSum);
            this.tabPage1.Controls.Add(label7);
            this.tabPage1.Controls.Add(label6);
            this.tabPage1.Controls.Add(label5);
            this.tabPage1.Controls.Add(label4);
            this.tabPage1.Controls.Add(this.btCalculate);
            this.tabPage1.Controls.Add(label3);
            this.tabPage1.Controls.Add(this.tbPercent);
            this.tabPage1.Controls.Add(label2);
            this.tabPage1.Controls.Add(this.tbTime);
            this.tabPage1.Controls.Add(label1);
            this.tabPage1.Controls.Add(this.tbSum);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(606, 333);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Свои значения";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(606, 341);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Выбрать банк";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tbSum
            // 
            this.tbSum.Location = new System.Drawing.Point(14, 31);
            this.tbSum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSum.Name = "tbSum";
            this.tbSum.Size = new System.Drawing.Size(148, 29);
            this.tbSum.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(9, 5);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(120, 21);
            label1.TabIndex = 1;
            label1.Text = "Сумма кредита";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(9, 68);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(79, 21);
            label2.TabIndex = 3;
            label2.Text = "Срок, мес";
            // 
            // tbTime
            // 
            this.tbTime.Location = new System.Drawing.Point(14, 94);
            this.tbTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(148, 29);
            this.tbTime.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(9, 131);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(79, 21);
            label3.TabIndex = 5;
            label3.Text = "Ставка, %";
            // 
            // tbPercent
            // 
            this.tbPercent.Location = new System.Drawing.Point(14, 157);
            this.tbPercent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPercent.Name = "tbPercent";
            this.tbPercent.Size = new System.Drawing.Size(148, 29);
            this.tbPercent.TabIndex = 4;
            // 
            // btCalculate
            // 
            this.btCalculate.Location = new System.Drawing.Point(14, 200);
            this.btCalculate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btCalculate.Name = "btCalculate";
            this.btCalculate.Size = new System.Drawing.Size(150, 44);
            this.btCalculate.TabIndex = 6;
            this.btCalculate.Text = "Рассчитать";
            this.btCalculate.UseVisualStyleBackColor = true;
            this.btCalculate.Click += new System.EventHandler(this.btCalculate_Click);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(297, 5);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(151, 21);
            label4.TabIndex = 7;
            label4.Text = "Результаты расчета";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(297, 42);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(166, 21);
            label5.TabIndex = 8;
            label5.Text = "Ежемесячный платеж";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(297, 94);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(86, 21);
            label6.TabIndex = 9;
            label6.Text = "Переплата";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(297, 157);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(123, 21);
            label7.TabIndex = 10;
            label7.Text = "Общая выплата";
            // 
            // lbSum
            // 
            this.lbSum.AutoSize = true;
            this.lbSum.Location = new System.Drawing.Point(486, 157);
            this.lbSum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSum.Name = "lbSum";
            this.lbSum.Size = new System.Drawing.Size(19, 21);
            this.lbSum.TabIndex = 11;
            this.lbSum.Text = "0";
            // 
            // lbOverpayment
            // 
            this.lbOverpayment.AutoSize = true;
            this.lbOverpayment.Location = new System.Drawing.Point(486, 94);
            this.lbOverpayment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbOverpayment.Name = "lbOverpayment";
            this.lbOverpayment.Size = new System.Drawing.Size(19, 21);
            this.lbOverpayment.TabIndex = 12;
            this.lbOverpayment.Text = "0";
            // 
            // lbPayment
            // 
            this.lbPayment.AutoSize = true;
            this.lbPayment.Location = new System.Drawing.Point(486, 42);
            this.lbPayment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPayment.Name = "lbPayment";
            this.lbPayment.Size = new System.Drawing.Size(19, 21);
            this.lbPayment.TabIndex = 13;
            this.lbPayment.Text = "0";
            // 
            // btPaymentsGraph
            // 
            this.btPaymentsGraph.Location = new System.Drawing.Point(302, 200);
            this.btPaymentsGraph.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btPaymentsGraph.Name = "btPaymentsGraph";
            this.btPaymentsGraph.Size = new System.Drawing.Size(204, 44);
            this.btPaymentsGraph.TabIndex = 14;
            this.btPaymentsGraph.Text = "График платежей";
            this.btPaymentsGraph.UseVisualStyleBackColor = true;
            this.btPaymentsGraph.Click += new System.EventHandler(this.btPaymentsGraph_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 407);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Кредитный калькулятор";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tbPercent;
        private System.Windows.Forms.TextBox tbTime;
        private System.Windows.Forms.TextBox tbSum;
        private System.Windows.Forms.Button btCalculate;
        private System.Windows.Forms.Label lbSum;
        private System.Windows.Forms.Label lbOverpayment;
        private System.Windows.Forms.Label lbPayment;
        private System.Windows.Forms.Button btPaymentsGraph;
    }
}

