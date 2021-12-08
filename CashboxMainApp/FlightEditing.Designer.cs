
namespace CashboxMainApp
{
    partial class FlightEditing
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
            this.TR_goHomeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.FE_titleTextBox = new System.Windows.Forms.TextBox();
            this.FE_seatsComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.FE_airlinerComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.FE_priceTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.FE_submitButton = new System.Windows.Forms.Button();
            this.FE_placesTextBox = new System.Windows.Forms.TextBox();
            this.FE_departDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FE_arrivalDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // TR_goHomeButton
            // 
            this.TR_goHomeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TR_goHomeButton.Location = new System.Drawing.Point(34, 29);
            this.TR_goHomeButton.Name = "TR_goHomeButton";
            this.TR_goHomeButton.Size = new System.Drawing.Size(122, 39);
            this.TR_goHomeButton.TabIndex = 0;
            this.TR_goHomeButton.Text = "На главную";
            this.TR_goHomeButton.UseVisualStyleBackColor = true;
            this.TR_goHomeButton.Click += new System.EventHandler(this.TR_goHomeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(225, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Редактирование рейса";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(133, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Название:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(133, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Дата отправления:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(133, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Дата прибытия:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(133, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Промежуточные посадки:";
            // 
            // FE_titleTextBox
            // 
            this.FE_titleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FE_titleTextBox.Location = new System.Drawing.Point(452, 135);
            this.FE_titleTextBox.Name = "FE_titleTextBox";
            this.FE_titleTextBox.Size = new System.Drawing.Size(261, 27);
            this.FE_titleTextBox.TabIndex = 3;
            this.FE_titleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FE_seatsComboBox
            // 
            this.FE_seatsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FE_seatsComboBox.FormattingEnabled = true;
            this.FE_seatsComboBox.Items.AddRange(new object[] {
            "Есть",
            "Нет"});
            this.FE_seatsComboBox.Location = new System.Drawing.Point(452, 260);
            this.FE_seatsComboBox.Name = "FE_seatsComboBox";
            this.FE_seatsComboBox.Size = new System.Drawing.Size(261, 28);
            this.FE_seatsComboBox.TabIndex = 4;
            this.FE_seatsComboBox.SelectedIndexChanged += new System.EventHandler(this.FE_seatsComboBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(133, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(279, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Места промежуточных посадок:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(133, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Лайнер:";
            // 
            // FE_airlinerComboBox
            // 
            this.FE_airlinerComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FE_airlinerComboBox.FormattingEnabled = true;
            this.FE_airlinerComboBox.Location = new System.Drawing.Point(452, 346);
            this.FE_airlinerComboBox.Name = "FE_airlinerComboBox";
            this.FE_airlinerComboBox.Size = new System.Drawing.Size(261, 28);
            this.FE_airlinerComboBox.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(133, 390);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Начальная цена:";
            // 
            // FE_priceTextBox
            // 
            this.FE_priceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FE_priceTextBox.Location = new System.Drawing.Point(452, 387);
            this.FE_priceTextBox.Name = "FE_priceTextBox";
            this.FE_priceTextBox.Size = new System.Drawing.Size(261, 27);
            this.FE_priceTextBox.TabIndex = 3;
            this.FE_priceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(719, 394);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "грн.";
            // 
            // FE_submitButton
            // 
            this.FE_submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FE_submitButton.Location = new System.Drawing.Point(341, 483);
            this.FE_submitButton.Name = "FE_submitButton";
            this.FE_submitButton.Size = new System.Drawing.Size(136, 50);
            this.FE_submitButton.TabIndex = 5;
            this.FE_submitButton.Text = "Готово";
            this.FE_submitButton.UseVisualStyleBackColor = true;
            this.FE_submitButton.Click += new System.EventHandler(this.TR_submitButton_Click);
            // 
            // FE_placesTextBox
            // 
            this.FE_placesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FE_placesTextBox.Location = new System.Drawing.Point(452, 303);
            this.FE_placesTextBox.Name = "FE_placesTextBox";
            this.FE_placesTextBox.ReadOnly = true;
            this.FE_placesTextBox.Size = new System.Drawing.Size(261, 27);
            this.FE_placesTextBox.TabIndex = 6;
            // 
            // FE_departDateTimePicker
            // 
            this.FE_departDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FE_departDateTimePicker.Location = new System.Drawing.Point(452, 181);
            this.FE_departDateTimePicker.Name = "FE_departDateTimePicker";
            this.FE_departDateTimePicker.Size = new System.Drawing.Size(261, 22);
            this.FE_departDateTimePicker.TabIndex = 7;
            // 
            // FE_arrivalDateTimePicker
            // 
            this.FE_arrivalDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FE_arrivalDateTimePicker.Location = new System.Drawing.Point(452, 224);
            this.FE_arrivalDateTimePicker.Name = "FE_arrivalDateTimePicker";
            this.FE_arrivalDateTimePicker.Size = new System.Drawing.Size(261, 22);
            this.FE_arrivalDateTimePicker.TabIndex = 7;
            // 
            // FlightEditing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 593);
            this.Controls.Add(this.FE_arrivalDateTimePicker);
            this.Controls.Add(this.FE_departDateTimePicker);
            this.Controls.Add(this.FE_placesTextBox);
            this.Controls.Add(this.FE_submitButton);
            this.Controls.Add(this.FE_airlinerComboBox);
            this.Controls.Add(this.FE_seatsComboBox);
            this.Controls.Add(this.FE_priceTextBox);
            this.Controls.Add(this.FE_titleTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TR_goHomeButton);
            this.Name = "FlightEditing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование рейса";
            this.Load += new System.EventHandler(this.FlightEditing_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TR_goHomeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FE_titleTextBox;
        private System.Windows.Forms.ComboBox FE_seatsComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox FE_airlinerComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox FE_priceTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button FE_submitButton;
        private System.Windows.Forms.TextBox FE_placesTextBox;
        private System.Windows.Forms.DateTimePicker FE_departDateTimePicker;
        private System.Windows.Forms.DateTimePicker FE_arrivalDateTimePicker;
    }
}