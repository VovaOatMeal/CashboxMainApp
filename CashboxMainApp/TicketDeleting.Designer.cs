
namespace CashboxMainApp
{
    partial class TicketDeleting
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
            this.TD_goHomeButton = new System.Windows.Forms.Button();
            this.TD_textBox = new System.Windows.Forms.TextBox();
            this.TD_searchButton = new System.Windows.Forms.Button();
            this.TD_resetButton = new System.Windows.Forms.Button();
            this.TD_dataGridView = new System.Windows.Forms.DataGridView();
            this.TD_deleteTicketButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TD_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TD_goHomeButton
            // 
            this.TD_goHomeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TD_goHomeButton.Location = new System.Drawing.Point(31, 26);
            this.TD_goHomeButton.Name = "TD_goHomeButton";
            this.TD_goHomeButton.Size = new System.Drawing.Size(132, 35);
            this.TD_goHomeButton.TabIndex = 0;
            this.TD_goHomeButton.Text = "На главную";
            this.TD_goHomeButton.UseVisualStyleBackColor = true;
            this.TD_goHomeButton.Click += new System.EventHandler(this.PS_goHomeButton_Click);
            // 
            // TD_textBox
            // 
            this.TD_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TD_textBox.Location = new System.Drawing.Point(31, 120);
            this.TD_textBox.Name = "TD_textBox";
            this.TD_textBox.Size = new System.Drawing.Size(466, 30);
            this.TD_textBox.TabIndex = 1;
            // 
            // TD_searchButton
            // 
            this.TD_searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TD_searchButton.Location = new System.Drawing.Point(525, 120);
            this.TD_searchButton.Name = "TD_searchButton";
            this.TD_searchButton.Size = new System.Drawing.Size(113, 30);
            this.TD_searchButton.TabIndex = 2;
            this.TD_searchButton.Text = "Поиск";
            this.TD_searchButton.UseVisualStyleBackColor = true;
            this.TD_searchButton.Click += new System.EventHandler(this.PS_searchButton_Click);
            // 
            // TD_resetButton
            // 
            this.TD_resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TD_resetButton.Location = new System.Drawing.Point(657, 120);
            this.TD_resetButton.Name = "TD_resetButton";
            this.TD_resetButton.Size = new System.Drawing.Size(113, 30);
            this.TD_resetButton.TabIndex = 2;
            this.TD_resetButton.Text = "Сбросить";
            this.TD_resetButton.UseVisualStyleBackColor = true;
            this.TD_resetButton.Click += new System.EventHandler(this.PS_resetButton_Click);
            // 
            // TD_dataGridView
            // 
            this.TD_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TD_dataGridView.Location = new System.Drawing.Point(31, 187);
            this.TD_dataGridView.Name = "TD_dataGridView";
            this.TD_dataGridView.ReadOnly = true;
            this.TD_dataGridView.RowHeadersWidth = 51;
            this.TD_dataGridView.RowTemplate.Height = 24;
            this.TD_dataGridView.Size = new System.Drawing.Size(739, 258);
            this.TD_dataGridView.TabIndex = 3;
            // 
            // TD_deleteTicketButton
            // 
            this.TD_deleteTicketButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TD_deleteTicketButton.Location = new System.Drawing.Point(347, 470);
            this.TD_deleteTicketButton.Name = "TD_deleteTicketButton";
            this.TD_deleteTicketButton.Size = new System.Drawing.Size(101, 36);
            this.TD_deleteTicketButton.TabIndex = 4;
            this.TD_deleteTicketButton.Text = "Удалить";
            this.TD_deleteTicketButton.UseVisualStyleBackColor = true;
            this.TD_deleteTicketButton.Click += new System.EventHandler(this.TD_deleteTicketButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(268, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Выберите билет";
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
            // TicketDeleting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 543);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TD_deleteTicketButton);
            this.Controls.Add(this.TD_dataGridView);
            this.Controls.Add(this.TD_resetButton);
            this.Controls.Add(this.TD_searchButton);
            this.Controls.Add(this.TD_textBox);
            this.Controls.Add(this.TD_goHomeButton);
            this.Name = "TicketDeleting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Удаление билета";
            ((System.ComponentModel.ISupportInitialize)(this.TD_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TD_goHomeButton;
        private System.Windows.Forms.TextBox TD_textBox;
        private System.Windows.Forms.Button TD_searchButton;
        private System.Windows.Forms.Button TD_resetButton;
        private System.Windows.Forms.DataGridView TD_dataGridView;
        private System.Windows.Forms.Button TD_deleteTicketButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}