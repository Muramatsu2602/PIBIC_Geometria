﻿namespace CapturaTela
{
    partial class frmCapturaDesenho
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            //if (_writer.IsOpen)
            //{
            //    _streamVideo.SignalToStop();
            //    _writer.Close();
            //    _writer.Dispose();
            //}
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_start = new System.Windows.Forms.Button();
            this.bt_Save = new System.Windows.Forms.Button();
            this.cb_VideoCodec = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_BitRate = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_Triangle = new System.Windows.Forms.Button();
            this.txt_ShapeSize = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Circle = new System.Windows.Forms.Button();
            this.btn_Rectangle = new System.Windows.Forms.Button();
            this.btn_Square = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_PenColor = new System.Windows.Forms.Button();
            this.pnl_Draw = new System.Windows.Forms.Panel();
            this.lb_stopWatch = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_screenSelector = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nud_FPS = new System.Windows.Forms.NumericUpDown();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnl_Draw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_FPS)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_start
            // 
            this.bt_start.Location = new System.Drawing.Point(72, 495);
            this.bt_start.Margin = new System.Windows.Forms.Padding(2);
            this.bt_start.Name = "bt_start";
            this.bt_start.Size = new System.Drawing.Size(60, 34);
            this.bt_start.TabIndex = 1;
            this.bt_start.Text = "&Começar";
            this.bt_start.UseVisualStyleBackColor = true;
            this.bt_start.Click += new System.EventHandler(this.bt_start_Click);
            // 
            // bt_Save
            // 
            this.bt_Save.Location = new System.Drawing.Point(5, 495);
            this.bt_Save.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Save.Name = "bt_Save";
            this.bt_Save.Size = new System.Drawing.Size(66, 34);
            this.bt_Save.TabIndex = 2;
            this.bt_Save.Text = "&Parar";
            this.bt_Save.UseVisualStyleBackColor = true;
            this.bt_Save.Click += new System.EventHandler(this.Bt_Save_Click);
            // 
            // cb_VideoCodec
            // 
            this.cb_VideoCodec.FormattingEnabled = true;
            this.cb_VideoCodec.Location = new System.Drawing.Point(75, 446);
            this.cb_VideoCodec.Margin = new System.Windows.Forms.Padding(2);
            this.cb_VideoCodec.Name = "cb_VideoCodec";
            this.cb_VideoCodec.Size = new System.Drawing.Size(102, 21);
            this.cb_VideoCodec.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 448);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "VideoCodec:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 448);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "BitRate:";
            // 
            // cb_BitRate
            // 
            this.cb_BitRate.FormattingEnabled = true;
            this.cb_BitRate.Location = new System.Drawing.Point(230, 445);
            this.cb_BitRate.Margin = new System.Windows.Forms.Padding(2);
            this.cb_BitRate.Name = "cb_BitRate";
            this.cb_BitRate.Size = new System.Drawing.Size(76, 21);
            this.cb_BitRate.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.bt_Save);
            this.panel1.Controls.Add(this.bt_start);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 547);
            this.panel1.TabIndex = 17;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.button3);
            this.panel7.Controls.Add(this.btn_Triangle);
            this.panel7.Controls.Add(this.txt_ShapeSize);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.btn_Circle);
            this.panel7.Controls.Add(this.btn_Rectangle);
            this.panel7.Controls.Add(this.btn_Square);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Location = new System.Drawing.Point(5, 114);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(130, 378);
            this.panel7.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(23, 333);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "&Apagar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btn_Apagar_Click);
            // 
            // btn_Triangle
            // 
            this.btn_Triangle.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Triangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Triangle.Location = new System.Drawing.Point(3, 265);
            this.btn_Triangle.Name = "btn_Triangle";
            this.btn_Triangle.Size = new System.Drawing.Size(122, 52);
            this.btn_Triangle.TabIndex = 11;
            this.btn_Triangle.Text = "&TRIANGULO";
            this.btn_Triangle.UseVisualStyleBackColor = false;
            // 
            // txt_ShapeSize
            // 
            this.txt_ShapeSize.Location = new System.Drawing.Point(4, 54);
            this.txt_ShapeSize.Name = "txt_ShapeSize";
            this.txt_ShapeSize.Size = new System.Drawing.Size(122, 20);
            this.txt_ShapeSize.TabIndex = 9;
            this.txt_ShapeSize.Text = "10";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "TAMANHO";
            // 
            // btn_Circle
            // 
            this.btn_Circle.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Circle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Circle.Location = new System.Drawing.Point(4, 208);
            this.btn_Circle.Name = "btn_Circle";
            this.btn_Circle.Size = new System.Drawing.Size(122, 51);
            this.btn_Circle.TabIndex = 7;
            this.btn_Circle.Text = "&C&IRCULO";
            this.btn_Circle.UseVisualStyleBackColor = false;
            this.btn_Circle.Click += new System.EventHandler(this.btn_Circle_Click);
            // 
            // btn_Rectangle
            // 
            this.btn_Rectangle.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Rectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Rectangle.Location = new System.Drawing.Point(4, 148);
            this.btn_Rectangle.Name = "btn_Rectangle";
            this.btn_Rectangle.Size = new System.Drawing.Size(122, 54);
            this.btn_Rectangle.TabIndex = 6;
            this.btn_Rectangle.Text = "&RETANGULO";
            this.btn_Rectangle.UseVisualStyleBackColor = false;
            this.btn_Rectangle.Click += new System.EventHandler(this.btn_Rectangle_Click);
            // 
            // btn_Square
            // 
            this.btn_Square.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Square.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Square.Location = new System.Drawing.Point(3, 87);
            this.btn_Square.Name = "btn_Square";
            this.btn_Square.Size = new System.Drawing.Size(122, 55);
            this.btn_Square.TabIndex = 5;
            this.btn_Square.Text = "&QUADRADO";
            this.btn_Square.UseVisualStyleBackColor = false;
            this.btn_Square.Click += new System.EventHandler(this.btn_Square_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.DimGray;
            this.panel8.Controls.Add(this.label8);
            this.panel8.Location = new System.Drawing.Point(-1, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(130, 27);
            this.panel8.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(28, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "FORMAS";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btn_PenColor);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(132, 103);
            this.panel2.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DimGray;
            this.panel6.Controls.Add(this.label10);
            this.panel6.Location = new System.Drawing.Point(0, -1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(130, 27);
            this.panel6.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(42, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "COR";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Location = new System.Drawing.Point(-1, 126);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(130, 100);
            this.panel3.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(3, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 28);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBox1.Location = new System.Drawing.Point(4, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(122, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 28);
            this.button2.TabIndex = 0;
            this.button2.Text = "Pen Tool";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_PenColor
            // 
            this.btn_PenColor.BackColor = System.Drawing.Color.Black;
            this.btn_PenColor.Location = new System.Drawing.Point(-4, 8);
            this.btn_PenColor.Name = "btn_PenColor";
            this.btn_PenColor.Size = new System.Drawing.Size(137, 97);
            this.btn_PenColor.TabIndex = 2;
            this.btn_PenColor.UseVisualStyleBackColor = false;
            this.btn_PenColor.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnl_Draw
            // 
            this.pnl_Draw.AutoSize = true;
            this.pnl_Draw.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnl_Draw.Controls.Add(this.panel1);
            this.pnl_Draw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Draw.Location = new System.Drawing.Point(0, 0);
            this.pnl_Draw.Name = "pnl_Draw";
            this.pnl_Draw.Size = new System.Drawing.Size(1080, 547);
            this.pnl_Draw.TabIndex = 19;
            this.pnl_Draw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Draw_MouseDown);
            // 
            // lb_stopWatch
            // 
            this.lb_stopWatch.AutoSize = true;
            this.lb_stopWatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_stopWatch.Location = new System.Drawing.Point(70, 495);
            this.lb_stopWatch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_stopWatch.Name = "lb_stopWatch";
            this.lb_stopWatch.Size = new System.Drawing.Size(202, 26);
            this.lb_stopWatch.TabIndex = 13;
            this.lb_stopWatch.Text = "00:00:00.0000000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 474);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Screens:";
            // 
            // cb_screenSelector
            // 
            this.cb_screenSelector.FormattingEnabled = true;
            this.cb_screenSelector.Location = new System.Drawing.Point(75, 471);
            this.cb_screenSelector.Margin = new System.Windows.Forms.Padding(2);
            this.cb_screenSelector.Name = "cb_screenSelector";
            this.cb_screenSelector.Size = new System.Drawing.Size(102, 21);
            this.cb_screenSelector.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 472);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "FPS:";
            // 
            // nud_FPS
            // 
            this.nud_FPS.Location = new System.Drawing.Point(229, 467);
            this.nud_FPS.Margin = new System.Windows.Forms.Padding(2);
            this.nud_FPS.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nud_FPS.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_FPS.Name = "nud_FPS";
            this.nud_FPS.Size = new System.Drawing.Size(75, 20);
            this.nud_FPS.TabIndex = 9;
            this.nud_FPS.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pnl_Draw);
            this.panel4.Controls.Add(this.nud_FPS);
            this.panel4.Controls.Add(this.cb_screenSelector);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.lb_stopWatch);
            this.panel4.Controls.Add(this.cb_BitRate);
            this.panel4.Controls.Add(this.cb_VideoCodec);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1080, 547);
            this.panel4.TabIndex = 20;
            // 
            // frmCapturaDesenho
            // 
            this.AcceptButton = this.bt_start;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1080, 547);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCapturaDesenho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "Geometricamente v1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.pnl_Draw.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nud_FPS)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_start;
        private System.Windows.Forms.Button bt_Save;
        private System.Windows.Forms.ComboBox cb_VideoCodec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_BitRate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_Draw;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txt_ShapeSize;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Circle;
        private System.Windows.Forms.Button btn_Rectangle;
        private System.Windows.Forms.Button btn_Square;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_PenColor;
        private System.Windows.Forms.Button btn_Triangle;
        private System.Windows.Forms.Label lb_stopWatch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_screenSelector;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nud_FPS;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button3;
    }
}

