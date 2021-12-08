
namespace CashboxMainApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addPassengerButton = new System.Windows.Forms.Button();
            this.addTicketButton = new System.Windows.Forms.Button();
            this.deleteTicketButton = new System.Windows.Forms.Button();
            this.editFlightButton = new System.Windows.Forms.Button();
            this.deleteFlightButton = new System.Windows.Forms.Button();
            this.printLastTicket = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(244, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cashbox Main Application";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(125, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пассажиры";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(631, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Рейсы";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(142, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Билеты";
            // 
            // addPassengerButton
            // 
            this.addPassengerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.addPassengerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addPassengerButton.Location = new System.Drawing.Point(90, 164);
            this.addPassengerButton.Name = "addPassengerButton";
            this.addPassengerButton.Size = new System.Drawing.Size(189, 64);
            this.addPassengerButton.TabIndex = 4;
            this.addPassengerButton.Text = "Добавить пассажира";
            this.addPassengerButton.UseVisualStyleBackColor = false;
            this.addPassengerButton.Click += new System.EventHandler(this.addPassengerButton_Click);
            // 
            // addTicketButton
            // 
            this.addTicketButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.addTicketButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addTicketButton.Location = new System.Drawing.Point(90, 370);
            this.addTicketButton.Name = "addTicketButton";
            this.addTicketButton.Size = new System.Drawing.Size(189, 60);
            this.addTicketButton.TabIndex = 5;
            this.addTicketButton.Text = "Оформить билет";
            this.addTicketButton.UseVisualStyleBackColor = false;
            this.addTicketButton.Click += new System.EventHandler(this.addTicketButton_Click);
            // 
            // deleteTicketButton
            // 
            this.deleteTicketButton.BackColor = System.Drawing.Color.Red;
            this.deleteTicketButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteTicketButton.Location = new System.Drawing.Point(90, 436);
            this.deleteTicketButton.Name = "deleteTicketButton";
            this.deleteTicketButton.Size = new System.Drawing.Size(189, 59);
            this.deleteTicketButton.TabIndex = 5;
            this.deleteTicketButton.Text = "Удалить билет";
            this.deleteTicketButton.UseVisualStyleBackColor = false;
            this.deleteTicketButton.Click += new System.EventHandler(this.deleteTicketButton_Click);
            // 
            // editFlightButton
            // 
            this.editFlightButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.editFlightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editFlightButton.Location = new System.Drawing.Point(578, 164);
            this.editFlightButton.Name = "editFlightButton";
            this.editFlightButton.Size = new System.Drawing.Size(177, 64);
            this.editFlightButton.TabIndex = 6;
            this.editFlightButton.Text = "Редактировать рейс";
            this.editFlightButton.UseVisualStyleBackColor = false;
            this.editFlightButton.Click += new System.EventHandler(this.editFlightButton_Click);
            // 
            // deleteFlightButton
            // 
            this.deleteFlightButton.BackColor = System.Drawing.Color.Red;
            this.deleteFlightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteFlightButton.Location = new System.Drawing.Point(578, 234);
            this.deleteFlightButton.Name = "deleteFlightButton";
            this.deleteFlightButton.Size = new System.Drawing.Size(177, 45);
            this.deleteFlightButton.TabIndex = 6;
            this.deleteFlightButton.Text = "Удалить рейс";
            this.deleteFlightButton.UseVisualStyleBackColor = false;
            this.deleteFlightButton.Click += new System.EventHandler(this.deleteFlightButton_Click);
            // 
            // printLastTicket
            // 
            this.printLastTicket.BackColor = System.Drawing.Color.LightGray;
            this.printLastTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.printLastTicket.Location = new System.Drawing.Point(578, 370);
            this.printLastTicket.Name = "printLastTicket";
            this.printLastTicket.Size = new System.Drawing.Size(177, 60);
            this.printLastTicket.TabIndex = 7;
            this.printLastTicket.Text = "Печать";
            this.printLastTicket.UseVisualStyleBackColor = false;
            this.printLastTicket.Click += new System.EventHandler(this.printLastTicket_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(578, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Последний билет";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 585);
            this.Controls.Add(this.printLastTicket);
            this.Controls.Add(this.deleteFlightButton);
            this.Controls.Add(this.editFlightButton);
            this.Controls.Add(this.deleteTicketButton);
            this.Controls.Add(this.addTicketButton);
            this.Controls.Add(this.addPassengerButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cashbox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addPassengerButton;
        private System.Windows.Forms.Button addTicketButton;
        private System.Windows.Forms.Button deleteTicketButton;
        private System.Windows.Forms.Button editFlightButton;
        private System.Windows.Forms.Button deleteFlightButton;
        private System.Windows.Forms.Button printLastTicket;
        private System.Windows.Forms.Label label5;
    }
}

