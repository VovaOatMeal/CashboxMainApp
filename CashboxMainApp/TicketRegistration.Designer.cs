
namespace CashboxMainApp
{
    partial class TicketRegistration
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
            this.TR_passengerTextBox = new System.Windows.Forms.TextBox();
            this.TR_passageTextBox = new System.Windows.Forms.TextBox();
            this.TR_flightTitleTextBox = new System.Windows.Forms.TextBox();
            this.TR_tillComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TR_classComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TR_chairComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TR_priceTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TR_registrarTextBox = new System.Windows.Forms.TextBox();
            this.TR_submitButton = new System.Windows.Forms.Button();
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
            this.label1.Size = new System.Drawing.Size(309, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Оформление билета";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(133, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID Пассажира:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(133, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Номер рейса:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(133, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Название рейса:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(133, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Касса:";
            // 
            // TR_passengerTextBox
            // 
            this.TR_passengerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TR_passengerTextBox.Location = new System.Drawing.Point(330, 131);
            this.TR_passengerTextBox.Name = "TR_passengerTextBox";
            this.TR_passengerTextBox.ReadOnly = true;
            this.TR_passengerTextBox.Size = new System.Drawing.Size(261, 27);
            this.TR_passengerTextBox.TabIndex = 3;
            this.TR_passengerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TR_passageTextBox
            // 
            this.TR_passageTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TR_passageTextBox.Location = new System.Drawing.Point(330, 173);
            this.TR_passageTextBox.Name = "TR_passageTextBox";
            this.TR_passageTextBox.ReadOnly = true;
            this.TR_passageTextBox.Size = new System.Drawing.Size(261, 27);
            this.TR_passageTextBox.TabIndex = 3;
            this.TR_passageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TR_flightTitleTextBox
            // 
            this.TR_flightTitleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TR_flightTitleTextBox.Location = new System.Drawing.Point(330, 215);
            this.TR_flightTitleTextBox.Name = "TR_flightTitleTextBox";
            this.TR_flightTitleTextBox.ReadOnly = true;
            this.TR_flightTitleTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.TR_flightTitleTextBox.Size = new System.Drawing.Size(261, 27);
            this.TR_flightTitleTextBox.TabIndex = 3;
            this.TR_flightTitleTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TR_tillComboBox
            // 
            this.TR_tillComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TR_tillComboBox.FormattingEnabled = true;
            this.TR_tillComboBox.Location = new System.Drawing.Point(330, 256);
            this.TR_tillComboBox.Name = "TR_tillComboBox";
            this.TR_tillComboBox.Size = new System.Drawing.Size(261, 28);
            this.TR_tillComboBox.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(133, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Класс:";
            // 
            // TR_classComboBox
            // 
            this.TR_classComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TR_classComboBox.FormattingEnabled = true;
            this.TR_classComboBox.Items.AddRange(new object[] {
            "Эконом",
            "Бизнес",
            "Первый"});
            this.TR_classComboBox.Location = new System.Drawing.Point(330, 298);
            this.TR_classComboBox.Name = "TR_classComboBox";
            this.TR_classComboBox.Size = new System.Drawing.Size(261, 28);
            this.TR_classComboBox.TabIndex = 4;
            this.TR_classComboBox.SelectedIndexChanged += new System.EventHandler(this.TR_classComboBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(133, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Место:";
            // 
            // TR_chairComboBox
            // 
            this.TR_chairComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TR_chairComboBox.FormattingEnabled = true;
            this.TR_chairComboBox.Location = new System.Drawing.Point(330, 342);
            this.TR_chairComboBox.Name = "TR_chairComboBox";
            this.TR_chairComboBox.Size = new System.Drawing.Size(261, 28);
            this.TR_chairComboBox.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(133, 390);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Цена:";
            // 
            // TR_priceTextBox
            // 
            this.TR_priceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TR_priceTextBox.Location = new System.Drawing.Point(330, 383);
            this.TR_priceTextBox.Name = "TR_priceTextBox";
            this.TR_priceTextBox.ReadOnly = true;
            this.TR_priceTextBox.Size = new System.Drawing.Size(261, 27);
            this.TR_priceTextBox.TabIndex = 3;
            this.TR_priceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(597, 390);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "грн.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(133, 432);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 20);
            this.label10.TabIndex = 2;
            this.label10.Text = "Регистратор:";
            // 
            // TR_registrarTextBox
            // 
            this.TR_registrarTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TR_registrarTextBox.Location = new System.Drawing.Point(330, 425);
            this.TR_registrarTextBox.Name = "TR_registrarTextBox";
            this.TR_registrarTextBox.Size = new System.Drawing.Size(261, 27);
            this.TR_registrarTextBox.TabIndex = 3;
            this.TR_registrarTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TR_submitButton
            // 
            this.TR_submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TR_submitButton.Location = new System.Drawing.Point(299, 520);
            this.TR_submitButton.Name = "TR_submitButton";
            this.TR_submitButton.Size = new System.Drawing.Size(136, 50);
            this.TR_submitButton.TabIndex = 5;
            this.TR_submitButton.Text = "Оформить";
            this.TR_submitButton.UseVisualStyleBackColor = true;
            this.TR_submitButton.Click += new System.EventHandler(this.TR_submitButton_Click);
            // 
            // TicketRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 630);
            this.Controls.Add(this.TR_submitButton);
            this.Controls.Add(this.TR_chairComboBox);
            this.Controls.Add(this.TR_classComboBox);
            this.Controls.Add(this.TR_tillComboBox);
            this.Controls.Add(this.TR_registrarTextBox);
            this.Controls.Add(this.TR_priceTextBox);
            this.Controls.Add(this.TR_flightTitleTextBox);
            this.Controls.Add(this.TR_passageTextBox);
            this.Controls.Add(this.TR_passengerTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TR_goHomeButton);
            this.Name = "TicketRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicketRegistration";
            this.Load += new System.EventHandler(this.TicketRegistration_Load);
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
        private System.Windows.Forms.TextBox TR_passengerTextBox;
        private System.Windows.Forms.TextBox TR_passageTextBox;
        private System.Windows.Forms.TextBox TR_flightTitleTextBox;
        private System.Windows.Forms.ComboBox TR_tillComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox TR_classComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox TR_chairComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TR_priceTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TR_registrarTextBox;
        private System.Windows.Forms.Button TR_submitButton;
    }
}