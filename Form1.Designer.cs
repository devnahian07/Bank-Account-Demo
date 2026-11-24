namespace BankAccountNew
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            OwnerTxt = new Label();
            AmountTxt = new Label();
            textBox1 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            BankAccountsGrid = new DataGridView();
            DepositBtn = new Button();
            WithdrawBtn = new Button();
            CreateAccountBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BankAccountsGrid).BeginInit();
            SuspendLayout();
            // 
            // OwnerTxt
            // 
            OwnerTxt.AutoSize = true;
            OwnerTxt.Location = new Point(50, 53);
            OwnerTxt.Margin = new Padding(6, 0, 6, 0);
            OwnerTxt.Name = "OwnerTxt";
            OwnerTxt.Size = new Size(105, 38);
            OwnerTxt.TabIndex = 0;
            OwnerTxt.Text = "Owner:";
            // 
            // AmountTxt
            // 
            AmountTxt.AutoSize = true;
            AmountTxt.Location = new Point(50, 425);
            AmountTxt.Margin = new Padding(6, 0, 6, 0);
            AmountTxt.Name = "AmountTxt";
            AmountTxt.Size = new Size(122, 38);
            AmountTxt.TabIndex = 1;
            AmountTxt.Text = "Amount:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(164, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(222, 43);
            textBox1.TabIndex = 2;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(181, 425);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 43);
            numericUpDown1.TabIndex = 3;
            // 
            // BankAccountsGrid
            // 
            BankAccountsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BankAccountsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BankAccountsGrid.Location = new Point(445, 53);
            BankAccountsGrid.Name = "BankAccountsGrid";
            BankAccountsGrid.RowHeadersWidth = 51;
            BankAccountsGrid.Size = new Size(485, 410);
            BankAccountsGrid.TabIndex = 4;
            // 
            // DepositBtn
            // 
            DepositBtn.Location = new Point(443, 469);
            DepositBtn.Name = "DepositBtn";
            DepositBtn.Size = new Size(249, 49);
            DepositBtn.TabIndex = 5;
            DepositBtn.Text = "Deposit";
            DepositBtn.UseVisualStyleBackColor = true;
            // 
            // WithdrawBtn
            // 
            WithdrawBtn.Location = new Point(702, 469);
            WithdrawBtn.Name = "WithdrawBtn";
            WithdrawBtn.Size = new Size(230, 49);
            WithdrawBtn.TabIndex = 6;
            WithdrawBtn.Text = "Withdraw";
            WithdrawBtn.UseVisualStyleBackColor = true;
            // 
            // CreateAccountBtn
            // 
            CreateAccountBtn.Location = new Point(149, 128);
            CreateAccountBtn.Name = "CreateAccountBtn";
            CreateAccountBtn.Size = new Size(249, 49);
            CreateAccountBtn.TabIndex = 7;
            CreateAccountBtn.Text = "Create Account";
            CreateAccountBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(987, 530);
            Controls.Add(CreateAccountBtn);
            Controls.Add(WithdrawBtn);
            Controls.Add(DepositBtn);
            Controls.Add(BankAccountsGrid);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox1);
            Controls.Add(AmountTxt);
            Controls.Add(OwnerTxt);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)BankAccountsGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label OwnerTxt;
        private Label AmountTxt;
        private TextBox textBox1;
        private NumericUpDown numericUpDown1;
        private DataGridView BankAccountsGrid;
        private Button DepositBtn;
        private Button WithdrawBtn;
        private Button CreateAccountBtn;
    }
}
