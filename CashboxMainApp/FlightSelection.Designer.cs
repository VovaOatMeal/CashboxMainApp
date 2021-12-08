
namespace CashboxMainApp
{
    partial class FlightSelection
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
            this.FS_textBox = new System.Windows.Forms.TextBox();
            this.FS_searchButton = new System.Windows.Forms.Button();
            this.FS_resetButton = new System.Windows.Forms.Button();
            this.FS_dataGridView = new System.Windows.Forms.DataGridView();
            this.PS_nextButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FS_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PS_goHomeButton
            // 
            this.PS_goHomeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PS_goHomeButton.Location = new System.Drawing.Point(31, 26);
            this.PS_goHomeButton.Name = "PS_goHomeButton";
            this.PS_goHomeButton.Size = new System.Drawing.Size(129, 35);
            this.PS_goHomeButton.TabIndex = 0;
            this.PS_goHomeButton.Text = "На главную";
            this.PS_goHomeButton.UseVisualStyleBackColor = true;
            this.PS_goHomeButton.Click += new System.EventHandler(this.PS_goHomeButton_Click);
            // 
            // FS_textBox
            // 
            this.FS_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FS_textBox.Location = new System.Drawing.Point(31, 120);
            this.FS_textBox.Name = "FS_textBox";
            this.FS_textBox.Size = new System.Drawing.Size(466, 30);
            this.FS_textBox.TabIndex = 1;
            // 
            // FS_searchButton
            // 
            this.FS_searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FS_searchButton.Location = new System.Drawing.Point(525, 120);
            this.FS_searchButton.Name = "FS_searchButton";
            this.FS_searchButton.Size = new System.Drawing.Size(113, 30);
            this.FS_searchButton.TabIndex = 2;
            this.FS_searchButton.Text = "Поиск";
            this.FS_searchButton.UseVisualStyleBackColor = true;
            this.FS_searchButton.Click += new System.EventHandler(this.PS_searchButton_Click);
            // 
            // FS_resetButton
            // 
            this.FS_resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FS_resetButton.Location = new System.Drawing.Point(657, 120);
            this.FS_resetButton.Name = "FS_resetButton";
            this.FS_resetButton.Size = new System.Drawing.Size(113, 30);
            this.FS_resetButton.TabIndex = 2;
            this.FS_resetButton.Text = "Сбросить";
            this.FS_resetButton.UseVisualStyleBackColor = true;
            this.FS_resetButton.Click += new System.EventHandler(this.PS_resetButton_Click);
            // 
            // FS_dataGridView
            // 
            this.FS_dataGridView.AllowUserToAddRows = false;
            this.FS_dataGridView.AllowUserToDeleteRows = false;
            this.FS_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FS_dataGridView.Location = new System.Drawing.Point(31, 187);
            this.FS_dataGridView.Name = "FS_dataGridView";
            this.FS_dataGridView.ReadOnly = true;
            this.FS_dataGridView.RowHeadersWidth = 51;
            this.FS_dataGridView.RowTemplate.Height = 24;
            this.FS_dataGridView.Size = new System.Drawing.Size(739, 258);
            this.FS_dataGridView.TabIndex = 3;
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
            this.label1.Location = new System.Drawing.Point(262, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Выберите рейс";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(31, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Поиск по названию:";
            // 
            // FlightSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 543);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PS_nextButton);
            this.Controls.Add(this.FS_dataGridView);
            this.Controls.Add(this.FS_resetButton);
            this.Controls.Add(this.FS_searchButton);
            this.Controls.Add(this.FS_textBox);
            this.Controls.Add(this.PS_goHomeButton);
            this.Name = "FlightSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор рейса";
            ((System.ComponentModel.ISupportInitialize)(this.FS_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PS_goHomeButton;
        private System.Windows.Forms.TextBox FS_textBox;
        private System.Windows.Forms.Button FS_searchButton;
        private System.Windows.Forms.Button FS_resetButton;
        private System.Windows.Forms.DataGridView FS_dataGridView;
        private System.Windows.Forms.Button PS_nextButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}