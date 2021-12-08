
namespace CashboxMainApp
{
    partial class PassengerSelection
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PS_goHomeButton = new System.Windows.Forms.Button();
            this.PS_textBox = new System.Windows.Forms.TextBox();
            this.PS_searchButton = new System.Windows.Forms.Button();
            this.PS_resetButton = new System.Windows.Forms.Button();
            this.PS_dataGridView = new System.Windows.Forms.DataGridView();
            this.PassengerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIrstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SecondName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PS_nextButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PS_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PS_goHomeButton
            // 
            this.PS_goHomeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PS_goHomeButton.Location = new System.Drawing.Point(31, 26);
            this.PS_goHomeButton.Name = "PS_goHomeButton";
            this.PS_goHomeButton.Size = new System.Drawing.Size(132, 35);
            this.PS_goHomeButton.TabIndex = 0;
            this.PS_goHomeButton.Text = "На главную";
            this.PS_goHomeButton.UseVisualStyleBackColor = true;
            this.PS_goHomeButton.Click += new System.EventHandler(this.PS_goHomeButton_Click);
            // 
            // PS_textBox
            // 
            this.PS_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PS_textBox.Location = new System.Drawing.Point(31, 120);
            this.PS_textBox.Name = "PS_textBox";
            this.PS_textBox.Size = new System.Drawing.Size(466, 30);
            this.PS_textBox.TabIndex = 1;
            // 
            // PS_searchButton
            // 
            this.PS_searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PS_searchButton.Location = new System.Drawing.Point(525, 120);
            this.PS_searchButton.Name = "PS_searchButton";
            this.PS_searchButton.Size = new System.Drawing.Size(113, 30);
            this.PS_searchButton.TabIndex = 2;
            this.PS_searchButton.Text = "Поиск";
            this.PS_searchButton.UseVisualStyleBackColor = true;
            this.PS_searchButton.Click += new System.EventHandler(this.PS_searchButton_Click);
            // 
            // PS_resetButton
            // 
            this.PS_resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PS_resetButton.Location = new System.Drawing.Point(657, 120);
            this.PS_resetButton.Name = "PS_resetButton";
            this.PS_resetButton.Size = new System.Drawing.Size(113, 30);
            this.PS_resetButton.TabIndex = 2;
            this.PS_resetButton.Text = "Сбросить";
            this.PS_resetButton.UseVisualStyleBackColor = true;
            this.PS_resetButton.Click += new System.EventHandler(this.PS_resetButton_Click);
            // 
            // PS_dataGridView
            // 
            this.PS_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PS_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PassengerID,
            this.FIrstName,
            this.SecondName,
            this.LastName});
            this.PS_dataGridView.Location = new System.Drawing.Point(31, 187);
            this.PS_dataGridView.Name = "PS_dataGridView";
            this.PS_dataGridView.ReadOnly = true;
            this.PS_dataGridView.RowHeadersWidth = 51;
            this.PS_dataGridView.RowTemplate.Height = 24;
            this.PS_dataGridView.Size = new System.Drawing.Size(739, 258);
            this.PS_dataGridView.TabIndex = 3;
            // 
            // PassengerID
            // 
            this.PassengerID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PassengerID.HeaderText = "Passenger ID";
            this.PassengerID.MinimumWidth = 6;
            this.PassengerID.Name = "PassengerID";
            this.PassengerID.ReadOnly = true;
            this.PassengerID.Width = 122;
            // 
            // FIrstName
            // 
            this.FIrstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FIrstName.HeaderText = "FIrst Name";
            this.FIrstName.MinimumWidth = 6;
            this.FIrstName.Name = "FIrstName";
            this.FIrstName.ReadOnly = true;
            this.FIrstName.Width = 105;
            // 
            // SecondName
            // 
            this.SecondName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SecondName.HeaderText = "Second Name";
            this.SecondName.MinimumWidth = 6;
            this.SecondName.Name = "SecondName";
            this.SecondName.ReadOnly = true;
            this.SecondName.Width = 126;
            // 
            // LastName
            // 
            this.LastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.LastName.HeaderText = "Last Name";
            this.LastName.MinimumWidth = 6;
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Width = 105;
            // 
            // PS_nextButton
            // 
            this.PS_nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PS_nextButton.Location = new System.Drawing.Point(669, 470);
            this.PS_nextButton.Name = "PS_nextButton";
            this.PS_nextButton.Size = new System.Drawing.Size(101, 36);
            this.PS_nextButton.TabIndex = 4;
            this.PS_nextButton.Text = "Далее";
            this.PS_nextButton.UseVisualStyleBackColor = true;
            this.PS_nextButton.Click += new System.EventHandler(this.PS_nextButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(234, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Выберите пассажира";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(31, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Поиск по ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(28, 481);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(581, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Примечание: если пассажир в базе отсутствует, его нужно предварительно добавить.";
            // 
            // PassengerSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 543);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PS_nextButton);
            this.Controls.Add(this.PS_dataGridView);
            this.Controls.Add(this.PS_resetButton);
            this.Controls.Add(this.PS_searchButton);
            this.Controls.Add(this.PS_textBox);
            this.Controls.Add(this.PS_goHomeButton);
            this.Name = "PassengerSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор пассажира";
            ((System.ComponentModel.ISupportInitialize)(this.PS_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PS_goHomeButton;
        private System.Windows.Forms.TextBox PS_textBox;
        private System.Windows.Forms.Button PS_searchButton;
        private System.Windows.Forms.Button PS_resetButton;
        private System.Windows.Forms.DataGridView PS_dataGridView;
        private System.Windows.Forms.Button PS_nextButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PassengerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIrstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SecondName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}