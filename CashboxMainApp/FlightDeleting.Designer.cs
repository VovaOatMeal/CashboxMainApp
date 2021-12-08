
namespace CashboxMainApp
{
    partial class FlightDeleting
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
            this.FD_goHomeButton = new System.Windows.Forms.Button();
            this.FD_textBox = new System.Windows.Forms.TextBox();
            this.FD_searchButton = new System.Windows.Forms.Button();
            this.FD_resetButton = new System.Windows.Forms.Button();
            this.FD_dataGridView = new System.Windows.Forms.DataGridView();
            this.FD_deleteTicketButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FD_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // FD_goHomeButton
            // 
            this.FD_goHomeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FD_goHomeButton.Location = new System.Drawing.Point(31, 26);
            this.FD_goHomeButton.Name = "FD_goHomeButton";
            this.FD_goHomeButton.Size = new System.Drawing.Size(132, 35);
            this.FD_goHomeButton.TabIndex = 0;
            this.FD_goHomeButton.Text = "На главную";
            this.FD_goHomeButton.UseVisualStyleBackColor = true;
            this.FD_goHomeButton.Click += new System.EventHandler(this.PS_goHomeButton_Click);
            // 
            // FD_textBox
            // 
            this.FD_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FD_textBox.Location = new System.Drawing.Point(31, 120);
            this.FD_textBox.Name = "FD_textBox";
            this.FD_textBox.Size = new System.Drawing.Size(466, 30);
            this.FD_textBox.TabIndex = 1;
            // 
            // FD_searchButton
            // 
            this.FD_searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FD_searchButton.Location = new System.Drawing.Point(525, 120);
            this.FD_searchButton.Name = "FD_searchButton";
            this.FD_searchButton.Size = new System.Drawing.Size(113, 30);
            this.FD_searchButton.TabIndex = 2;
            this.FD_searchButton.Text = "Поиск";
            this.FD_searchButton.UseVisualStyleBackColor = true;
            this.FD_searchButton.Click += new System.EventHandler(this.PS_searchButton_Click);
            // 
            // FD_resetButton
            // 
            this.FD_resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FD_resetButton.Location = new System.Drawing.Point(657, 120);
            this.FD_resetButton.Name = "FD_resetButton";
            this.FD_resetButton.Size = new System.Drawing.Size(113, 30);
            this.FD_resetButton.TabIndex = 2;
            this.FD_resetButton.Text = "Сбросить";
            this.FD_resetButton.UseVisualStyleBackColor = true;
            this.FD_resetButton.Click += new System.EventHandler(this.PS_resetButton_Click);
            // 
            // FD_dataGridView
            // 
            this.FD_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FD_dataGridView.Location = new System.Drawing.Point(31, 187);
            this.FD_dataGridView.Name = "FD_dataGridView";
            this.FD_dataGridView.ReadOnly = true;
            this.FD_dataGridView.RowHeadersWidth = 51;
            this.FD_dataGridView.RowTemplate.Height = 24;
            this.FD_dataGridView.Size = new System.Drawing.Size(739, 258);
            this.FD_dataGridView.TabIndex = 3;
            // 
            // FD_deleteTicketButton
            // 
            this.FD_deleteTicketButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FD_deleteTicketButton.Location = new System.Drawing.Point(347, 470);
            this.FD_deleteTicketButton.Name = "FD_deleteTicketButton";
            this.FD_deleteTicketButton.Size = new System.Drawing.Size(101, 36);
            this.FD_deleteTicketButton.TabIndex = 4;
            this.FD_deleteTicketButton.Text = "Удалить";
            this.FD_deleteTicketButton.UseVisualStyleBackColor = true;
            this.FD_deleteTicketButton.Click += new System.EventHandler(this.TD_deleteTicketButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(268, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Выберите рейс";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(31, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Поиск по названию:";
            // 
            // FlightDeleting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 543);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FD_deleteTicketButton);
            this.Controls.Add(this.FD_dataGridView);
            this.Controls.Add(this.FD_resetButton);
            this.Controls.Add(this.FD_searchButton);
            this.Controls.Add(this.FD_textBox);
            this.Controls.Add(this.FD_goHomeButton);
            this.Name = "FlightDeleting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Удаление билета";
            ((System.ComponentModel.ISupportInitialize)(this.FD_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FD_goHomeButton;
        private System.Windows.Forms.TextBox FD_textBox;
        private System.Windows.Forms.Button FD_searchButton;
        private System.Windows.Forms.Button FD_resetButton;
        private System.Windows.Forms.DataGridView FD_dataGridView;
        private System.Windows.Forms.Button FD_deleteTicketButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}