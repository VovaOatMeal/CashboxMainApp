
namespace CashboxMainApp
{
    partial class TicketPrinting
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
            this.PT_goHomeButton = new System.Windows.Forms.Button();
            this.labelDone = new System.Windows.Forms.Label();
            this.PT_dataGridView = new System.Windows.Forms.DataGridView();
            this.PT_printButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PT_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PT_goHomeButton
            // 
            this.PT_goHomeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PT_goHomeButton.Location = new System.Drawing.Point(35, 34);
            this.PT_goHomeButton.Name = "PT_goHomeButton";
            this.PT_goHomeButton.Size = new System.Drawing.Size(125, 39);
            this.PT_goHomeButton.TabIndex = 0;
            this.PT_goHomeButton.Text = "На главную";
            this.PT_goHomeButton.UseVisualStyleBackColor = true;
            this.PT_goHomeButton.Click += new System.EventHandler(this.PT_goHomeButton_Click);
            // 
            // labelDone
            // 
            this.labelDone.AutoSize = true;
            this.labelDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDone.Location = new System.Drawing.Point(282, 34);
            this.labelDone.Name = "labelDone";
            this.labelDone.Size = new System.Drawing.Size(313, 32);
            this.labelDone.TabIndex = 1;
            this.labelDone.Text = "Оформленный билет";
            this.labelDone.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PT_dataGridView
            // 
            this.PT_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PT_dataGridView.Location = new System.Drawing.Point(35, 152);
            this.PT_dataGridView.Name = "PT_dataGridView";
            this.PT_dataGridView.RowHeadersWidth = 51;
            this.PT_dataGridView.RowTemplate.Height = 24;
            this.PT_dataGridView.Size = new System.Drawing.Size(821, 109);
            this.PT_dataGridView.TabIndex = 2;
            // 
            // PT_printButton
            // 
            this.PT_printButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PT_printButton.Location = new System.Drawing.Point(363, 365);
            this.PT_printButton.Name = "PT_printButton";
            this.PT_printButton.Size = new System.Drawing.Size(161, 51);
            this.PT_printButton.TabIndex = 3;
            this.PT_printButton.Text = "Печать";
            this.PT_printButton.UseVisualStyleBackColor = true;
            this.PT_printButton.Click += new System.EventHandler(this.PT_printButton_Click);
            // 
            // TicketPrinting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 470);
            this.Controls.Add(this.PT_printButton);
            this.Controls.Add(this.PT_dataGridView);
            this.Controls.Add(this.labelDone);
            this.Controls.Add(this.PT_goHomeButton);
            this.Name = "TicketPrinting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оформленный билет";
            this.Load += new System.EventHandler(this.PrintTicket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PT_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PT_goHomeButton;
        private System.Windows.Forms.Label labelDone;
        private System.Windows.Forms.DataGridView PT_dataGridView;
        private System.Windows.Forms.Button PT_printButton;
    }
}