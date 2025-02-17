namespace pr12_4_Gurina
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
            this.header = new System.Windows.Forms.Label();
            this.order = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.Label();
            this.kalors = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Nazvanie = new System.Windows.Forms.TextBox();
            this.Testo = new System.Windows.Forms.TextBox();
            this.Krem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Ves = new System.Windows.Forms.NumericUpDown();
            this.Kalorinost = new System.Windows.Forms.NumericUpDown();
            this.Tsena = new System.Windows.Forms.NumericUpDown();
            this.kolichestvo = new System.Windows.Forms.NumericUpDown();
            this.lstPirozhnoeInfo = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.Ves)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kalorinost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tsena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kolichestvo)).BeginInit();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Location = new System.Drawing.Point(159, 69);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(74, 16);
            this.header.TabIndex = 0;
            this.header.Text = "Пирожное";
            // 
            // order
            // 
            this.order.AutoSize = true;
            this.order.Location = new System.Drawing.Point(472, 69);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(47, 16);
            this.order.TabIndex = 7;
            this.order.Text = "Заказ";
            this.order.Click += new System.EventHandler(this.order_Click);
            // 
            // sum
            // 
            this.sum.AutoSize = true;
            this.sum.Location = new System.Drawing.Point(489, 165);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(59, 16);
            this.sum.TabIndex = 8;
            this.sum.Text = "Сумма : ";
            // 
            // kalors
            // 
            this.kalors.AutoSize = true;
            this.kalors.Location = new System.Drawing.Point(489, 194);
            this.kalors.Name = "kalors";
            this.kalors.Size = new System.Drawing.Size(153, 16);
            this.kalors.TabIndex = 9;
            this.kalors.Text = "Общая калорийность : ";
            this.kalors.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Введите кол-во пирожных :";
            // 
            // Nazvanie
            // 
            this.Nazvanie.Location = new System.Drawing.Point(186, 107);
            this.Nazvanie.Name = "Nazvanie";
            this.Nazvanie.Size = new System.Drawing.Size(100, 22);
            this.Nazvanie.TabIndex = 13;
            // 
            // Testo
            // 
            this.Testo.Location = new System.Drawing.Point(186, 135);
            this.Testo.Name = "Testo";
            this.Testo.Size = new System.Drawing.Size(100, 22);
            this.Testo.TabIndex = 14;
            // 
            // Krem
            // 
            this.Krem.Location = new System.Drawing.Point(186, 165);
            this.Krem.Name = "Krem";
            this.Krem.Size = new System.Drawing.Size(100, 22);
            this.Krem.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Название :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Тесто :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Крем :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(72, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "Вес :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(72, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "Цена :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Калорийность :";
            // 
            // count
            // 
            this.count.Location = new System.Drawing.Point(490, 134);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(117, 23);
            this.count.TabIndex = 11;
            this.count.Text = "Рассчитать";
            this.count.UseVisualStyleBackColor = true;
            this.count.Click += new System.EventHandler(this.count_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(197, 299);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(89, 32);
            this.Add.TabIndex = 26;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Ves
            // 
            this.Ves.Location = new System.Drawing.Point(186, 194);
            this.Ves.Name = "Ves";
            this.Ves.Size = new System.Drawing.Size(100, 22);
            this.Ves.TabIndex = 27;
            // 
            // Kalorinost
            // 
            this.Kalorinost.Location = new System.Drawing.Point(186, 222);
            this.Kalorinost.Name = "Kalorinost";
            this.Kalorinost.Size = new System.Drawing.Size(100, 22);
            this.Kalorinost.TabIndex = 28;
            // 
            // Tsena
            // 
            this.Tsena.Location = new System.Drawing.Point(186, 250);
            this.Tsena.Name = "Tsena";
            this.Tsena.Size = new System.Drawing.Size(100, 22);
            this.Tsena.TabIndex = 29;
            // 
            // kolichestvo
            // 
            this.kolichestvo.Location = new System.Drawing.Point(571, 94);
            this.kolichestvo.Name = "kolichestvo";
            this.kolichestvo.Size = new System.Drawing.Size(52, 22);
            this.kolichestvo.TabIndex = 30;
            // 
            // lstPirozhnoeInfo
            // 
            this.lstPirozhnoeInfo.ItemHeight = 16;
            this.lstPirozhnoeInfo.Location = new System.Drawing.Point(386, 254);
            this.lstPirozhnoeInfo.Name = "lstPirozhnoeInfo";
            this.lstPirozhnoeInfo.Size = new System.Drawing.Size(378, 132);
            this.lstPirozhnoeInfo.TabIndex = 31;
            this.lstPirozhnoeInfo.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstPirozhnoeInfo);
            this.Controls.Add(this.kolichestvo);
            this.Controls.Add(this.Tsena);
            this.Controls.Add(this.Kalorinost);
            this.Controls.Add(this.Ves);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Krem);
            this.Controls.Add(this.Testo);
            this.Controls.Add(this.Nazvanie);
            this.Controls.Add(this.count);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kalors);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.order);
            this.Controls.Add(this.header);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Ves)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kalorinost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tsena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kolichestvo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Label order;
        private System.Windows.Forms.Label sum;
        private System.Windows.Forms.Label kalors;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Nazvanie;
        private System.Windows.Forms.TextBox Testo;
        private System.Windows.Forms.TextBox Krem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button count;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.NumericUpDown Ves;
        private System.Windows.Forms.NumericUpDown Kalorinost;
        private System.Windows.Forms.NumericUpDown Tsena;
        private System.Windows.Forms.NumericUpDown kolichestvo;
        private System.Windows.Forms.ListBox lstPirozhnoeInfo;
    }
}

