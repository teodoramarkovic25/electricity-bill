namespace WindowsFormsApp1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelVrijeme = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelDatum = new System.Windows.Forms.ToolStripLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtkWh = new System.Windows.Forms.TextBox();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbVisa = new System.Windows.Forms.RadioButton();
            this.rdbNiza = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRacun = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblX = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelVrijeme,
            this.toolStripLabelDatum});
            this.toolStrip1.Location = new System.Drawing.Point(0, 377);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(677, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabelVrijeme
            // 
            this.toolStripLabelVrijeme.Name = "toolStripLabelVrijeme";
            this.toolStripLabelVrijeme.Size = new System.Drawing.Size(86, 22);
            this.toolStripLabelVrijeme.Text = "toolStripLabel1";
            // 
            // toolStripLabelDatum
            // 
            this.toolStripLabelDatum.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabelDatum.Name = "toolStripLabelDatum";
            this.toolStripLabelDatum.Size = new System.Drawing.Size(86, 22);
            this.toolStripLabelDatum.Text = "toolStripLabel1";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(186, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Obracun potrosnje elektricne energije";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Aqua;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Unesite potrosenu energiju (kWh):";
            // 
            // txtkWh
            // 
            this.txtkWh.Location = new System.Drawing.Point(238, 62);
            this.txtkWh.Name = "txtkWh";
            this.txtkWh.Size = new System.Drawing.Size(38, 20);
            this.txtkWh.TabIndex = 3;
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Aqua;
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cijena po kWh za nizu tarifu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Aqua;
            this.label4.Location = new System.Drawing.Point(12, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cijena po kWh za visu tarifu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Aqua;
            this.label5.Location = new System.Drawing.Point(235, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "0.0395";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Aqua;
            this.label6.Location = new System.Drawing.Point(235, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "0.0429";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbVisa);
            this.groupBox1.Controls.Add(this.rdbNiza);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Aqua;
            this.groupBox1.Location = new System.Drawing.Point(15, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 109);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sezona obracuna";
            // 
            // rdbVisa
            // 
            this.rdbVisa.AutoSize = true;
            this.rdbVisa.Location = new System.Drawing.Point(6, 64);
            this.rdbVisa.Name = "rdbVisa";
            this.rdbVisa.Size = new System.Drawing.Size(90, 22);
            this.rdbVisa.TabIndex = 1;
            this.rdbVisa.TabStop = true;
            this.rdbVisa.Text = "Visa tarifa";
            this.rdbVisa.UseVisualStyleBackColor = true;
            this.rdbVisa.Click += new System.EventHandler(this.rdbVisa_Click);
            // 
            // rdbNiza
            // 
            this.rdbNiza.AutoSize = true;
            this.rdbNiza.Location = new System.Drawing.Point(7, 36);
            this.rdbNiza.Name = "rdbNiza";
            this.rdbNiza.Size = new System.Drawing.Size(92, 22);
            this.rdbNiza.TabIndex = 0;
            this.rdbNiza.TabStop = true;
            this.rdbNiza.Text = "Niza tarifa";
            this.rdbNiza.UseVisualStyleBackColor = true;
            this.rdbNiza.Click += new System.EventHandler(this.rdbNiza_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Aqua;
            this.label7.Location = new System.Drawing.Point(12, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Ukupan iznos racuna:";
            // 
            // txtRacun
            // 
            this.txtRacun.Location = new System.Drawing.Point(193, 320);
            this.txtRacun.Name = "txtRacun";
            this.txtRacun.Size = new System.Drawing.Size(55, 20);
            this.txtRacun.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Aqua;
            this.label8.Location = new System.Drawing.Point(254, 321);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "KM";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Aqua;
            this.label9.Location = new System.Drawing.Point(13, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(189, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "Cijena po kWh za mrezarinu:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Aqua;
            this.label10.Location = new System.Drawing.Point(235, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 15);
            this.label10.TabIndex = 13;
            this.label10.Text = "0.0658";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Aqua;
            this.label11.Location = new System.Drawing.Point(13, 154);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(158, 17);
            this.label11.TabIndex = 14;
            this.label11.Text = "Cijena po kWh za OIEE:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Aqua;
            this.label12.Location = new System.Drawing.Point(235, 154);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 15);
            this.label12.TabIndex = 15;
            this.label12.Text = "0.02";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.nikola_tesla;
            this.pictureBox1.Location = new System.Drawing.Point(358, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(307, 278);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.ForeColor = System.Drawing.Color.Red;
            this.lblX.Location = new System.Drawing.Point(651, 9);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(18, 17);
            this.lblX.TabIndex = 17;
            this.lblX.Text = "X";
            this.lblX.Click += new System.EventHandler(this.lblX_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(677, 402);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtRacun);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtkWh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(693, 441);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(693, 441);
            this.Name = "Form1";
            this.Text = "Kalkulator potrosnje elektricne energije";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabelVrijeme;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripLabel toolStripLabelDatum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtkWh;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRacun;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbVisa;
        private System.Windows.Forms.RadioButton rdbNiza;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblX;
    }
}

