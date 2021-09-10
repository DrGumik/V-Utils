namespace Vape_ohm
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tb1 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbA = new System.Windows.Forms.TextBox();
            this.tbOhm = new System.Windows.Forms.Label();
            this.tbO = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbAB = new System.Windows.Forms.TextBox();
            this.tbW = new System.Windows.Forms.TextBox();
            this.lbl9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbONB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbPON = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbMMB = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tbPMB = new System.Windows.Forms.TextBox();
            this.tbPMBB = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbPOMER = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbPG = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tbVG = new System.Windows.Forms.TextBox();
            this.btn3 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.tbOCB = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tb1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(21, 63);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(480, 45);
            this.tb1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "3,2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(478, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "4,2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(251, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "3,7";
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn2.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn2.FlatAppearance.BorderSize = 2;
            this.btn2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn2.Location = new System.Drawing.Point(161, 146);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(135, 63);
            this.btn2.TabIndex = 5;
            this.btn2.Text = "Výpočet";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(25, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Napětí baterie [V]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(25, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Max. proud baterie [A]";
            // 
            // tbA
            // 
            this.tbA.Location = new System.Drawing.Point(27, 145);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(145, 20);
            this.tbA.TabIndex = 8;
            this.tbA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbA_KeyBlock);
            // 
            // tbOhm
            // 
            this.tbOhm.AutoSize = true;
            this.tbOhm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbOhm.Location = new System.Drawing.Point(25, 168);
            this.tbOhm.Name = "tbOhm";
            this.tbOhm.Size = new System.Drawing.Size(142, 17);
            this.tbOhm.TabIndex = 9;
            this.tbOhm.Text = "Odpor spirálky [Ohm]";
            // 
            // tbO
            // 
            this.tbO.Location = new System.Drawing.Point(28, 188);
            this.tbO.Name = "tbO";
            this.tbO.Size = new System.Drawing.Size(144, 20);
            this.tbO.TabIndex = 10;
            this.tbO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbOhm_KeyBlock);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(215, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Výkon na spirále [W]";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(215, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Proud z baterie [A]";
            // 
            // tbAB
            // 
            this.tbAB.Location = new System.Drawing.Point(218, 188);
            this.tbAB.Name = "tbAB";
            this.tbAB.ReadOnly = true;
            this.tbAB.Size = new System.Drawing.Size(135, 20);
            this.tbAB.TabIndex = 13;
            this.tbAB.Text = "0,0";
            this.tbAB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbW
            // 
            this.tbW.Location = new System.Drawing.Point(218, 145);
            this.tbW.Name = "tbW";
            this.tbW.ReadOnly = true;
            this.tbW.Size = new System.Drawing.Size(135, 20);
            this.tbW.TabIndex = 14;
            this.tbW.Text = "0,0";
            this.tbW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl9
            // 
            this.lbl9.AutoSize = true;
            this.lbl9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl9.Location = new System.Drawing.Point(25, 221);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(126, 16);
            this.lbl9.TabIndex = 15;
            this.lbl9.Text = "Kontrola baterie: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn1);
            this.groupBox1.Location = new System.Drawing.Point(12, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 226);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ohm meter";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.tbPMBB);
            this.groupBox2.Controls.Add(this.tbPMB);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.tbMMB);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.tbPON);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbONB);
            this.groupBox2.Controls.Add(this.btn2);
            this.groupBox2.Location = new System.Drawing.Point(12, 251);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(309, 218);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nikotin kalkulačka [mg/ml]";
            // 
            // tbONB
            // 
            this.tbONB.Location = new System.Drawing.Point(221, 15);
            this.tbONB.Name = "tbONB";
            this.tbONB.Size = new System.Drawing.Size(75, 20);
            this.tbONB.TabIndex = 18;
            this.tbONB.Text = "20";
            this.tbONB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(41, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Obsah nikotinu v boosteru";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(33, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(182, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Požadovaný obsah nikotinu";
            // 
            // tbPON
            // 
            this.tbPON.Location = new System.Drawing.Point(221, 41);
            this.tbPON.Name = "tbPON";
            this.tbPON.Size = new System.Drawing.Size(75, 20);
            this.tbPON.TabIndex = 20;
            this.tbPON.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(6, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(209, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "Celkové množství míchané báze";
            // 
            // tbMMB
            // 
            this.tbMMB.Location = new System.Drawing.Point(221, 68);
            this.tbMMB.Name = "tbMMB";
            this.tbMMB.Size = new System.Drawing.Size(75, 20);
            this.tbMMB.TabIndex = 22;
            this.tbMMB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn1.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn1.FlatAppearance.BorderSize = 2;
            this.btn1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn1.Location = new System.Drawing.Point(354, 126);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(135, 63);
            this.btn1.TabIndex = 18;
            this.btn1.Text = "Výpočet";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(93, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 17);
            this.label11.TabIndex = 23;
            this.label11.Text = "Počet ml boosteru";
            // 
            // tbPMB
            // 
            this.tbPMB.Location = new System.Drawing.Point(221, 94);
            this.tbPMB.Name = "tbPMB";
            this.tbPMB.ReadOnly = true;
            this.tbPMB.Size = new System.Drawing.Size(75, 20);
            this.tbPMB.TabIndex = 24;
            this.tbPMB.Text = "0";
            this.tbPMB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbPMBB
            // 
            this.tbPMBB.Location = new System.Drawing.Point(221, 120);
            this.tbPMBB.Name = "tbPMBB";
            this.tbPMBB.ReadOnly = true;
            this.tbPMBB.Size = new System.Drawing.Size(75, 20);
            this.tbPMBB.TabIndex = 25;
            this.tbPMBB.Text = "0";
            this.tbPMBB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(27, 121);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(188, 17);
            this.label12.TabIndex = 26;
            this.label12.Text = "Počet ml beznikotinové báze";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbOCB);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.tbPOMER);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.tbPG);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.tbVG);
            this.groupBox3.Controls.Add(this.btn3);
            this.groupBox3.Location = new System.Drawing.Point(327, 251);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(190, 218);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kalkulačka poměru báze [ml]";
            // 
            // tbPOMER
            // 
            this.tbPOMER.Location = new System.Drawing.Point(98, 95);
            this.tbPOMER.Name = "tbPOMER";
            this.tbPOMER.ReadOnly = true;
            this.tbPOMER.Size = new System.Drawing.Size(75, 20);
            this.tbPOMER.TabIndex = 24;
            this.tbPOMER.Text = "0";
            this.tbPOMER.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(2, 96);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 17);
            this.label14.TabIndex = 23;
            this.label14.Text = "Poměr VG/PG";
            // 
            // tbPG
            // 
            this.tbPG.Location = new System.Drawing.Point(98, 41);
            this.tbPG.Name = "tbPG";
            this.tbPG.Size = new System.Drawing.Size(75, 20);
            this.tbPG.TabIndex = 20;
            this.tbPG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label17.Location = new System.Drawing.Point(18, 15);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(74, 17);
            this.label17.TabIndex = 18;
            this.label17.Text = "Obsah VG";
            // 
            // tbVG
            // 
            this.tbVG.Location = new System.Drawing.Point(98, 14);
            this.tbVG.Name = "tbVG";
            this.tbVG.Size = new System.Drawing.Size(75, 20);
            this.tbVG.TabIndex = 18;
            this.tbVG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn3.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn3.FlatAppearance.BorderSize = 2;
            this.btn3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn3.Location = new System.Drawing.Point(38, 146);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(135, 63);
            this.btn3.TabIndex = 5;
            this.btn3.Text = "Výpočet";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.Location = new System.Drawing.Point(18, 42);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 17);
            this.label15.TabIndex = 27;
            this.label15.Text = "Obsah PG";
            // 
            // tbOCB
            // 
            this.tbOCB.Location = new System.Drawing.Point(98, 67);
            this.tbOCB.Name = "tbOCB";
            this.tbOCB.ReadOnly = true;
            this.tbOCB.Size = new System.Drawing.Size(75, 20);
            this.tbOCB.TabIndex = 28;
            this.tbOCB.Text = "0";
            this.tbOCB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(1, 68);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 17);
            this.label13.TabIndex = 29;
            this.label13.Text = "Obsah celkem";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 488);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbl9);
            this.Controls.Add(this.tbW);
            this.Controls.Add(this.tbAB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbO);
            this.Controls.Add(this.tbOhm);
            this.Controls.Add(this.tbA);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "V-Utils by Jakub Tenk";
            ((System.ComponentModel.ISupportInitialize)(this.tb1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tb1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.Label tbOhm;
        private System.Windows.Forms.TextBox tbO;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbAB;
        private System.Windows.Forms.TextBox tbW;
        private System.Windows.Forms.Label lbl9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbMMB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbPON;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbONB;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbPMBB;
        private System.Windows.Forms.TextBox tbPMB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbPOMER;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbPG;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbVG;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.TextBox tbOCB;
        private System.Windows.Forms.Label label13;
    }
}

