namespace Аппроксимация_экспериментальных_данных
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.SetChartButton = new System.Windows.Forms.Button();
            this.PolinomPanel = new System.Windows.Forms.Panel();
            this.polyDeviation = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.PoliCheck = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.PolyBLabel = new System.Windows.Forms.Label();
            this.PolyCLabel = new System.Windows.Forms.Label();
            this.PolyALabel = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.ExpPanel = new System.Windows.Forms.Panel();
            this.expDeviation = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.ExpCheck = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ExpBLabel = new System.Windows.Forms.Label();
            this.ExpALabel = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.PowPanel = new System.Windows.Forms.Panel();
            this.powDeviation = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.PowCheck = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PowBLable = new System.Windows.Forms.Label();
            this.PowALabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.LinePanel = new System.Windows.Forms.Panel();
            this.lineDeviation = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.LineCheck = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.LineBLabel = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.LineALabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PointsTable = new System.Windows.Forms.DataGridView();
            this.xValues = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yValues = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.PolinomPanel.SuspendLayout();
            this.panel7.SuspendLayout();
            this.ExpPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.PowPanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.LinePanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PointsTable)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.PolinomPanel);
            this.panel1.Controls.Add(this.ExpPanel);
            this.panel1.Controls.Add(this.PowPanel);
            this.panel1.Controls.Add(this.LinePanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 358);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 192);
            this.panel1.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.SetChartButton);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(778, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(176, 192);
            this.panel8.TabIndex = 5;
            // 
            // SetChartButton
            // 
            this.SetChartButton.Location = new System.Drawing.Point(27, 6);
            this.SetChartButton.Name = "SetChartButton";
            this.SetChartButton.Size = new System.Drawing.Size(118, 36);
            this.SetChartButton.TabIndex = 0;
            this.SetChartButton.Text = "Сформировать \r\nграфик";
            this.SetChartButton.UseVisualStyleBackColor = true;
            this.SetChartButton.Click += new System.EventHandler(this.SetChartButton_Click_1);
            // 
            // PolinomPanel
            // 
            this.PolinomPanel.BackColor = System.Drawing.Color.Silver;
            this.PolinomPanel.Controls.Add(this.polyDeviation);
            this.PolinomPanel.Controls.Add(this.panel7);
            this.PolinomPanel.Controls.Add(this.label16);
            this.PolinomPanel.Controls.Add(this.label7);
            this.PolinomPanel.Controls.Add(this.label24);
            this.PolinomPanel.Controls.Add(this.PolyBLabel);
            this.PolinomPanel.Controls.Add(this.PolyCLabel);
            this.PolinomPanel.Controls.Add(this.PolyALabel);
            this.PolinomPanel.Controls.Add(this.label27);
            this.PolinomPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.PolinomPanel.Location = new System.Drawing.Point(559, 0);
            this.PolinomPanel.Name = "PolinomPanel";
            this.PolinomPanel.Size = new System.Drawing.Size(219, 192);
            this.PolinomPanel.TabIndex = 3;
            // 
            // polyDeviation
            // 
            this.polyDeviation.AutoSize = true;
            this.polyDeviation.Location = new System.Drawing.Point(108, 170);
            this.polyDeviation.Name = "polyDeviation";
            this.polyDeviation.Size = new System.Drawing.Size(19, 13);
            this.polyDeviation.TabIndex = 21;
            this.polyDeviation.Text = "__";
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.PoliCheck);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(219, 42);
            this.panel7.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 39);
            this.label4.TabIndex = 0;
            this.label4.Text = "Полиномиальная \r\nаппроксимация\r\n(квадратичная)";
            // 
            // PoliCheck
            // 
            this.PoliCheck.AutoSize = true;
            this.PoliCheck.Location = new System.Drawing.Point(110, 12);
            this.PoliCheck.Name = "PoliCheck";
            this.PoliCheck.Size = new System.Drawing.Size(15, 14);
            this.PoliCheck.TabIndex = 1;
            this.PoliCheck.UseVisualStyleBackColor = true;
            this.PoliCheck.CheckedChanged += new System.EventHandler(this.PoliCheck_CheckedChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 157);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(102, 26);
            this.label16.TabIndex = 20;
            this.label16.Text = "Суммы квадратов \r\nотклонения";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "B";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(9, 109);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(14, 13);
            this.label24.TabIndex = 20;
            this.label24.Text = "C";
            // 
            // PolyBLabel
            // 
            this.PolyBLabel.AutoSize = true;
            this.PolyBLabel.BackColor = System.Drawing.Color.White;
            this.PolyBLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PolyBLabel.Location = new System.Drawing.Point(89, 82);
            this.PolyBLabel.Name = "PolyBLabel";
            this.PolyBLabel.Size = new System.Drawing.Size(16, 15);
            this.PolyBLabel.TabIndex = 22;
            this.PolyBLabel.Text = "B";
            // 
            // PolyCLabel
            // 
            this.PolyCLabel.AutoSize = true;
            this.PolyCLabel.BackColor = System.Drawing.Color.White;
            this.PolyCLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PolyCLabel.Location = new System.Drawing.Point(88, 107);
            this.PolyCLabel.Name = "PolyCLabel";
            this.PolyCLabel.Size = new System.Drawing.Size(16, 15);
            this.PolyCLabel.TabIndex = 22;
            this.PolyCLabel.Text = "B";
            // 
            // PolyALabel
            // 
            this.PolyALabel.AutoSize = true;
            this.PolyALabel.BackColor = System.Drawing.Color.White;
            this.PolyALabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PolyALabel.Location = new System.Drawing.Point(88, 54);
            this.PolyALabel.Name = "PolyALabel";
            this.PolyALabel.Size = new System.Drawing.Size(16, 15);
            this.PolyALabel.TabIndex = 24;
            this.PolyALabel.Text = "A";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(9, 54);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(14, 13);
            this.label27.TabIndex = 23;
            this.label27.Text = "A";
            // 
            // ExpPanel
            // 
            this.ExpPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ExpPanel.Controls.Add(this.expDeviation);
            this.ExpPanel.Controls.Add(this.panel6);
            this.ExpPanel.Controls.Add(this.label13);
            this.ExpPanel.Controls.Add(this.label12);
            this.ExpPanel.Controls.Add(this.ExpBLabel);
            this.ExpPanel.Controls.Add(this.ExpALabel);
            this.ExpPanel.Controls.Add(this.label15);
            this.ExpPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ExpPanel.Location = new System.Drawing.Point(357, 0);
            this.ExpPanel.Name = "ExpPanel";
            this.ExpPanel.Size = new System.Drawing.Size(202, 192);
            this.ExpPanel.TabIndex = 2;
            // 
            // expDeviation
            // 
            this.expDeviation.AutoSize = true;
            this.expDeviation.Location = new System.Drawing.Point(124, 170);
            this.expDeviation.Name = "expDeviation";
            this.expDeviation.Size = new System.Drawing.Size(19, 13);
            this.expDeviation.TabIndex = 15;
            this.expDeviation.Text = "__";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.ExpCheck);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(202, 42);
            this.panel6.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Экспоненциальная \r\nаппроксичация";
            // 
            // ExpCheck
            // 
            this.ExpCheck.AutoSize = true;
            this.ExpCheck.Location = new System.Drawing.Point(127, 15);
            this.ExpCheck.Name = "ExpCheck";
            this.ExpCheck.Size = new System.Drawing.Size(15, 14);
            this.ExpCheck.TabIndex = 1;
            this.ExpCheck.UseVisualStyleBackColor = true;
            this.ExpCheck.CheckedChanged += new System.EventHandler(this.ExpCheck_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 157);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 26);
            this.label13.TabIndex = 14;
            this.label13.Text = "Суммы квадратов \r\nотклонения";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "B";
            // 
            // ExpBLabel
            // 
            this.ExpBLabel.AutoSize = true;
            this.ExpBLabel.BackColor = System.Drawing.Color.White;
            this.ExpBLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ExpBLabel.Location = new System.Drawing.Point(102, 84);
            this.ExpBLabel.Name = "ExpBLabel";
            this.ExpBLabel.Size = new System.Drawing.Size(16, 15);
            this.ExpBLabel.TabIndex = 16;
            this.ExpBLabel.Text = "B";
            // 
            // ExpALabel
            // 
            this.ExpALabel.AutoSize = true;
            this.ExpALabel.BackColor = System.Drawing.Color.White;
            this.ExpALabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ExpALabel.Location = new System.Drawing.Point(101, 53);
            this.ExpALabel.Name = "ExpALabel";
            this.ExpALabel.Size = new System.Drawing.Size(16, 15);
            this.ExpALabel.TabIndex = 18;
            this.ExpALabel.Text = "A";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 56);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(14, 13);
            this.label15.TabIndex = 17;
            this.label15.Text = "A";
            // 
            // PowPanel
            // 
            this.PowPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.PowPanel.Controls.Add(this.powDeviation);
            this.PowPanel.Controls.Add(this.panel5);
            this.PowPanel.Controls.Add(this.label10);
            this.PowPanel.Controls.Add(this.label6);
            this.PowPanel.Controls.Add(this.PowBLable);
            this.PowPanel.Controls.Add(this.PowALabel);
            this.PowPanel.Controls.Add(this.label9);
            this.PowPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.PowPanel.Location = new System.Drawing.Point(173, 0);
            this.PowPanel.Name = "PowPanel";
            this.PowPanel.Size = new System.Drawing.Size(184, 192);
            this.PowPanel.TabIndex = 1;
            // 
            // powDeviation
            // 
            this.powDeviation.AutoSize = true;
            this.powDeviation.Location = new System.Drawing.Point(113, 156);
            this.powDeviation.Name = "powDeviation";
            this.powDeviation.Size = new System.Drawing.Size(112, 13);
            this.powDeviation.TabIndex = 11;
            this.powDeviation.Text = "182,00468689421354";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.PowCheck);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(184, 42);
            this.panel5.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Степенная \r\nаппроксимация";
            // 
            // PowCheck
            // 
            this.PowCheck.AutoSize = true;
            this.PowCheck.Location = new System.Drawing.Point(128, 15);
            this.PowCheck.Name = "PowCheck";
            this.PowCheck.Size = new System.Drawing.Size(15, 14);
            this.PowCheck.TabIndex = 1;
            this.PowCheck.UseVisualStyleBackColor = true;
            this.PowCheck.CheckedChanged += new System.EventHandler(this.PowCheck_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 26);
            this.label10.TabIndex = 10;
            this.label10.Text = "Суммы квадратов\r\nотклонения";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "B";
            // 
            // PowBLable
            // 
            this.PowBLable.AutoSize = true;
            this.PowBLable.BackColor = System.Drawing.Color.White;
            this.PowBLable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PowBLable.Location = new System.Drawing.Point(74, 82);
            this.PowBLable.Name = "PowBLable";
            this.PowBLable.Size = new System.Drawing.Size(16, 15);
            this.PowBLable.TabIndex = 10;
            this.PowBLable.Text = "B";
            // 
            // PowALabel
            // 
            this.PowALabel.AutoSize = true;
            this.PowALabel.BackColor = System.Drawing.Color.White;
            this.PowALabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PowALabel.Location = new System.Drawing.Point(74, 51);
            this.PowALabel.Name = "PowALabel";
            this.PowALabel.Size = new System.Drawing.Size(16, 15);
            this.PowALabel.TabIndex = 12;
            this.PowALabel.Text = "A";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "A";
            // 
            // LinePanel
            // 
            this.LinePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.LinePanel.Controls.Add(this.lineDeviation);
            this.LinePanel.Controls.Add(this.label5);
            this.LinePanel.Controls.Add(this.panel4);
            this.LinePanel.Controls.Add(this.label17);
            this.LinePanel.Controls.Add(this.LineBLabel);
            this.LinePanel.Controls.Add(this.label19);
            this.LinePanel.Controls.Add(this.LineALabel);
            this.LinePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LinePanel.Location = new System.Drawing.Point(0, 0);
            this.LinePanel.Name = "LinePanel";
            this.LinePanel.Size = new System.Drawing.Size(173, 192);
            this.LinePanel.TabIndex = 0;
            // 
            // lineDeviation
            // 
            this.lineDeviation.AutoSize = true;
            this.lineDeviation.Location = new System.Drawing.Point(112, 157);
            this.lineDeviation.Name = "lineDeviation";
            this.lineDeviation.Size = new System.Drawing.Size(19, 13);
            this.lineDeviation.TabIndex = 9;
            this.lineDeviation.Text = "__";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "Суммы квадратов\r\nотклонения";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.LineCheck);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(173, 42);
            this.panel4.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Линейная аппроксичация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LineCheck
            // 
            this.LineCheck.AutoSize = true;
            this.LineCheck.Location = new System.Drawing.Point(152, 12);
            this.LineCheck.Name = "LineCheck";
            this.LineCheck.Size = new System.Drawing.Size(15, 14);
            this.LineCheck.TabIndex = 1;
            this.LineCheck.UseVisualStyleBackColor = true;
            this.LineCheck.CheckedChanged += new System.EventHandler(this.LineCheck_CheckedChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(9, 82);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(14, 13);
            this.label17.TabIndex = 3;
            this.label17.Text = "B";
            // 
            // LineBLabel
            // 
            this.LineBLabel.AutoSize = true;
            this.LineBLabel.BackColor = System.Drawing.Color.White;
            this.LineBLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LineBLabel.Location = new System.Drawing.Point(90, 80);
            this.LineBLabel.Name = "LineBLabel";
            this.LineBLabel.Size = new System.Drawing.Size(16, 15);
            this.LineBLabel.TabIndex = 4;
            this.LineBLabel.Text = "B";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(9, 55);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(14, 13);
            this.label19.TabIndex = 5;
            this.label19.Text = "A";
            // 
            // LineALabel
            // 
            this.LineALabel.AutoSize = true;
            this.LineALabel.BackColor = System.Drawing.Color.White;
            this.LineALabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LineALabel.Location = new System.Drawing.Point(90, 58);
            this.LineALabel.Name = "LineALabel";
            this.LineALabel.Size = new System.Drawing.Size(16, 15);
            this.LineALabel.TabIndex = 6;
            this.LineALabel.Text = "A";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.PointsTable);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(247, 358);
            this.panel2.TabIndex = 1;
            // 
            // PointsTable
            // 
            this.PointsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PointsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xValues,
            this.yValues});
            this.PointsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PointsTable.Location = new System.Drawing.Point(0, 0);
            this.PointsTable.Name = "PointsTable";
            this.PointsTable.Size = new System.Drawing.Size(247, 358);
            this.PointsTable.TabIndex = 0;
            // 
            // xValues
            // 
            this.xValues.HeaderText = "X";
            this.xValues.Name = "xValues";
            // 
            // yValues
            // 
            this.yValues.HeaderText = "Y";
            this.yValues.Name = "yValues";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chart1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(247, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(707, 358);
            this.panel3.TabIndex = 2;
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Исходные данные";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series11.Legend = "Исходные данные";
            series11.LegendText = "Исходные данные";
            series11.MarkerColor = System.Drawing.Color.Blue;
            series11.Name = "DefaultPoints";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series12.Legend = "Исходные данные";
            series12.LegendText = "Линейная";
            series12.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            series12.MarkerSize = 12;
            series12.Name = "LineApproximation";
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series13.Legend = "Исходные данные";
            series13.LegendText = "Степенная";
            series13.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            series13.MarkerSize = 12;
            series13.Name = "PowApproximations";
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series14.Legend = "Исходные данные";
            series14.LegendText = "Экспоненциальная";
            series14.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            series14.MarkerSize = 12;
            series14.Name = "ExpApproximation";
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series15.Legend = "Исходные данные";
            series15.LegendText = "Полиномиальная";
            series15.MarkerColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            series15.MarkerSize = 12;
            series15.Name = "PoliApproximation";
            this.chart1.Series.Add(series11);
            this.chart1.Series.Add(series12);
            this.chart1.Series.Add(series13);
            this.chart1.Series.Add(series14);
            this.chart1.Series.Add(series15);
            this.chart1.Size = new System.Drawing.Size(707, 358);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 550);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.PolinomPanel.ResumeLayout(false);
            this.PolinomPanel.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ExpPanel.ResumeLayout(false);
            this.ExpPanel.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.PowPanel.ResumeLayout(false);
            this.PowPanel.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.LinePanel.ResumeLayout(false);
            this.LinePanel.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PointsTable)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PolinomPanel;
        private System.Windows.Forms.CheckBox PoliCheck;
        private System.Windows.Forms.Panel ExpPanel;
        private System.Windows.Forms.CheckBox ExpCheck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel PowPanel;
        private System.Windows.Forms.CheckBox PowCheck;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel LinePanel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox LineCheck;
        private System.Windows.Forms.Label LineBLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label LineALabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView PointsTable;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label PolyCLabel;
        private System.Windows.Forms.Label PolyALabel;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label ExpBLabel;
        private System.Windows.Forms.Label ExpALabel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label PowBLable;
        private System.Windows.Forms.Label PowALabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn xValues;
        private System.Windows.Forms.DataGridViewTextBoxColumn yValues;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label PolyBLabel;
        private System.Windows.Forms.Label lineDeviation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button SetChartButton;
        private System.Windows.Forms.Label polyDeviation;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label expDeviation;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label powDeviation;
        private System.Windows.Forms.Label label10;
    }
}

