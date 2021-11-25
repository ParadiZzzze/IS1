
namespace WindowsFormsApp1
{
    partial class Form1
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
            this.price = new System.Windows.Forms.TextBox();
            this.video = new System.Windows.Forms.Label();
            this.pay = new System.Windows.Forms.Label();
            this.cpu = new System.Windows.Forms.Label();
            this.disk = new System.Windows.Forms.Label();
            this.ozy = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.mprice = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Бюджет";
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(65, 21);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(100, 20);
            this.price.TabIndex = 1;
            // 
            // video
            // 
            this.video.AutoSize = true;
            this.video.Location = new System.Drawing.Point(13, 101);
            this.video.Name = "video";
            this.video.Size = new System.Drawing.Size(70, 13);
            this.video.TabIndex = 5;
            this.video.Text = "Видеокарта:";
            // 
            // pay
            // 
            this.pay.AutoSize = true;
            this.pay.Location = new System.Drawing.Point(16, 130);
            this.pay.Name = "pay";
            this.pay.Size = new System.Drawing.Size(62, 13);
            this.pay.TabIndex = 6;
            this.pay.Text = "Мат.плата:";
            // 
            // cpu
            // 
            this.cpu.AutoSize = true;
            this.cpu.Location = new System.Drawing.Point(15, 158);
            this.cpu.Name = "cpu";
            this.cpu.Size = new System.Drawing.Size(66, 13);
            this.cpu.TabIndex = 7;
            this.cpu.Text = "Процессор:";
            // 
            // disk
            // 
            this.disk.AutoSize = true;
            this.disk.Location = new System.Drawing.Point(15, 184);
            this.disk.Name = "disk";
            this.disk.Size = new System.Drawing.Size(83, 13);
            this.disk.TabIndex = 8;
            this.disk.Text = "Жесткий диск:";
            // 
            // ozy
            // 
            this.ozy.AutoSize = true;
            this.ozy.Location = new System.Drawing.Point(19, 210);
            this.ozy.Name = "ozy";
            this.ozy.Size = new System.Drawing.Size(33, 13);
            this.ozy.TabIndex = 9;
            this.ozy.Text = "ОЗУ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(107, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(107, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(107, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(107, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(107, 210);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Игровой";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Блок питания:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "0";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(113, 285);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Офисный";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Итоговая стоимость:";
            // 
            // mprice
            // 
            this.mprice.AutoSize = true;
            this.mprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mprice.ForeColor = System.Drawing.Color.Red;
            this.mprice.Location = new System.Drawing.Point(146, 328);
            this.mprice.Name = "mprice";
            this.mprice.Size = new System.Drawing.Size(19, 20);
            this.mprice.TabIndex = 20;
            this.mprice.Text = "0";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(220, 285);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 21;
            this.button3.Text = "Для дома";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Lavender;
            this.button4.Location = new System.Drawing.Point(324, 285);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 23);
            this.button4.TabIndex = 22;
            this.button4.Text = "Для работы";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "SSD:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(107, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(644, 377);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.mprice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ozy);
            this.Controls.Add(this.disk);
            this.Controls.Add(this.cpu);
            this.Controls.Add(this.pay);
            this.Controls.Add(this.video);
            this.Controls.Add(this.price);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Label video;
        private System.Windows.Forms.Label pay;
        private System.Windows.Forms.Label cpu;
        private System.Windows.Forms.Label disk;
        private System.Windows.Forms.Label ozy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label mprice;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

