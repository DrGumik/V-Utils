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
            this.tb_BatteryVoltage = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_NicotineCalculator = new System.Windows.Forms.Button();
            this.lbl_BatteryVoltage = new System.Windows.Forms.Label();
            this.lbl_BatteryMaxCurrent = new System.Windows.Forms.Label();
            this.tb_BatteryMaxCurrent = new System.Windows.Forms.TextBox();
            this.lbl_Ohm = new System.Windows.Forms.Label();
            this.tb_Ohm = new System.Windows.Forms.TextBox();
            this.lbl_Power = new System.Windows.Forms.Label();
            this.lbl_BatteryOutCurrent = new System.Windows.Forms.Label();
            this.tb_BatteryOutCurrent = new System.Windows.Forms.TextBox();
            this.tb_Power = new System.Windows.Forms.TextBox();
            this.lbl_BatteryTest = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_OhmMeter = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbPMBB = new System.Windows.Forms.TextBox();
            this.tbPMB = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbMMB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbPON = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbONB = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbOCB = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tbPOMER = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbPG = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tbVG = new System.Windows.Forms.TextBox();
            this.btn_BaseCalculator = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tb_BatteryVoltage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_BatteryVoltage
            // 
            this.tb_BatteryVoltage.Location = new System.Drawing.Point(21, 63);
            this.tb_BatteryVoltage.Name = "tb_BatteryVoltage";
            this.tb_BatteryVoltage.Size = new System.Drawing.Size(480, 45);
            this.tb_BatteryVoltage.TabIndex = 0;
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
            // btn_NicotineCalculator
            // 
            this.btn_NicotineCalculator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_NicotineCalculator.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_NicotineCalculator.FlatAppearance.BorderSize = 2;
            this.btn_NicotineCalculator.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_NicotineCalculator.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_NicotineCalculator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NicotineCalculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_NicotineCalculator.Location = new System.Drawing.Point(161, 146);
            this.btn_NicotineCalculator.Name = "btn_NicotineCalculator";
            this.btn_NicotineCalculator.Size = new System.Drawing.Size(135, 63);
            this.btn_NicotineCalculator.TabIndex = 5;
            this.btn_NicotineCalculator.Text = "Výpočet";
            this.btn_NicotineCalculator.UseVisualStyleBackColor = false;
            this.btn_NicotineCalculator.Click += new System.EventHandler(this.btn_NicotineCalculator_Click);
            // 
            // lbl_BatteryVoltage
            // 
            this.lbl_BatteryVoltage.AutoSize = true;
            this.lbl_BatteryVoltage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_BatteryVoltage.Location = new System.Drawing.Point(25, 40);
            this.lbl_BatteryVoltage.Name = "lbl_BatteryVoltage";
            this.lbl_BatteryVoltage.Size = new System.Drawing.Size(118, 17);
            this.lbl_BatteryVoltage.TabIndex = 6;
            this.lbl_BatteryVoltage.Text = "Napětí baterie [V]";
            // 
            // lbl_BatteryMaxCurrent
            // 
            this.lbl_BatteryMaxCurrent.AutoSize = true;
            this.lbl_BatteryMaxCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_BatteryMaxCurrent.Location = new System.Drawing.Point(25, 125);
            this.lbl_BatteryMaxCurrent.Name = "lbl_BatteryMaxCurrent";
            this.lbl_BatteryMaxCurrent.Size = new System.Drawing.Size(147, 17);
            this.lbl_BatteryMaxCurrent.TabIndex = 7;
            this.lbl_BatteryMaxCurrent.Text = "Max. proud baterie [A]";
            // 
            // tb_BatteryMaxCurrent
            // 
            this.tb_BatteryMaxCurrent.Location = new System.Drawing.Point(27, 145);
            this.tb_BatteryMaxCurrent.Name = "tb_BatteryMaxCurrent";
            this.tb_BatteryMaxCurrent.Size = new System.Drawing.Size(145, 20);
            this.tb_BatteryMaxCurrent.TabIndex = 8;
            this.tb_BatteryMaxCurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_BatteryMaxCurrent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbA_KeyBlock);
            // 
            // lbl_Ohm
            // 
            this.lbl_Ohm.AutoSize = true;
            this.lbl_Ohm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_Ohm.Location = new System.Drawing.Point(25, 168);
            this.lbl_Ohm.Name = "lbl_Ohm";
            this.lbl_Ohm.Size = new System.Drawing.Size(142, 17);
            this.lbl_Ohm.TabIndex = 9;
            this.lbl_Ohm.Text = "Odpor spirálky [Ohm]";
            // 
            // tb_Ohm
            // 
            this.tb_Ohm.Location = new System.Drawing.Point(28, 188);
            this.tb_Ohm.Name = "tb_Ohm";
            this.tb_Ohm.Size = new System.Drawing.Size(144, 20);
            this.tb_Ohm.TabIndex = 10;
            this.tb_Ohm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_Ohm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbOhm_KeyBlock);
            // 
            // lbl_Power
            // 
            this.lbl_Power.AutoSize = true;
            this.lbl_Power.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_Power.Location = new System.Drawing.Point(215, 125);
            this.lbl_Power.Name = "lbl_Power";
            this.lbl_Power.Size = new System.Drawing.Size(138, 17);
            this.lbl_Power.TabIndex = 11;
            this.lbl_Power.Text = "Výkon na spirále [W]";
            // 
            // lbl_BatteryOutCurrent
            // 
            this.lbl_BatteryOutCurrent.AutoSize = true;
            this.lbl_BatteryOutCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_BatteryOutCurrent.Location = new System.Drawing.Point(215, 168);
            this.lbl_BatteryOutCurrent.Name = "lbl_BatteryOutCurrent";
            this.lbl_BatteryOutCurrent.Size = new System.Drawing.Size(126, 17);
            this.lbl_BatteryOutCurrent.TabIndex = 12;
            this.lbl_BatteryOutCurrent.Text = "Proud z baterie [A]";
            // 
            // tb_BatteryOutCurrent
            // 
            this.tb_BatteryOutCurrent.Location = new System.Drawing.Point(218, 188);
            this.tb_BatteryOutCurrent.Name = "tb_BatteryOutCurrent";
            this.tb_BatteryOutCurrent.ReadOnly = true;
            this.tb_BatteryOutCurrent.Size = new System.Drawing.Size(135, 20);
            this.tb_BatteryOutCurrent.TabIndex = 13;
            this.tb_BatteryOutCurrent.Text = "0,0";
            this.tb_BatteryOutCurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_Power
            // 
            this.tb_Power.Location = new System.Drawing.Point(218, 145);
            this.tb_Power.Name = "tb_Power";
            this.tb_Power.ReadOnly = true;
            this.tb_Power.Size = new System.Drawing.Size(135, 20);
            this.tb_Power.TabIndex = 14;
            this.tb_Power.Text = "0,0";
            this.tb_Power.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_BatteryTest
            // 
            this.lbl_BatteryTest.AutoSize = true;
            this.lbl_BatteryTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_BatteryTest.Location = new System.Drawing.Point(25, 221);
            this.lbl_BatteryTest.Name = "lbl_BatteryTest";
            this.lbl_BatteryTest.Size = new System.Drawing.Size(126, 16);
            this.lbl_BatteryTest.TabIndex = 15;
            this.lbl_BatteryTest.Text = "Kontrola baterie: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_OhmMeter);
            this.groupBox1.Location = new System.Drawing.Point(12, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 226);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ohm meter";
            // 
            // btn_OhmMeter
            // 
            this.btn_OhmMeter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_OhmMeter.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_OhmMeter.FlatAppearance.BorderSize = 2;
            this.btn_OhmMeter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_OhmMeter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_OhmMeter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_OhmMeter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_OhmMeter.Location = new System.Drawing.Point(354, 126);
            this.btn_OhmMeter.Name = "btn_OhmMeter";
            this.btn_OhmMeter.Size = new System.Drawing.Size(135, 63);
            this.btn_OhmMeter.TabIndex = 18;
            this.btn_OhmMeter.Text = "Výpočet";
            this.btn_OhmMeter.UseVisualStyleBackColor = false;
            this.btn_OhmMeter.Click += new System.EventHandler(this.btn_OhmMeter_Click);
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
            this.groupBox2.Controls.Add(this.btn_NicotineCalculator);
            this.groupBox2.Location = new System.Drawing.Point(12, 251);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(309, 218);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nikotin kalkulačka [mg/ml]";
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
            // tbMMB
            // 
            this.tbMMB.Location = new System.Drawing.Point(221, 68);
            this.tbMMB.Name = "tbMMB";
            this.tbMMB.Size = new System.Drawing.Size(75, 20);
            this.tbMMB.TabIndex = 22;
            this.tbMMB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // tbPON
            // 
            this.tbPON.Location = new System.Drawing.Point(221, 41);
            this.tbPON.Name = "tbPON";
            this.tbPON.Size = new System.Drawing.Size(75, 20);
            this.tbPON.TabIndex = 20;
            this.tbPON.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // tbONB
            // 
            this.tbONB.Location = new System.Drawing.Point(221, 15);
            this.tbONB.Name = "tbONB";
            this.tbONB.Size = new System.Drawing.Size(75, 20);
            this.tbONB.TabIndex = 18;
            this.tbONB.Text = "20";
            this.tbONB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.groupBox3.Controls.Add(this.btn_BaseCalculator);
            this.groupBox3.Location = new System.Drawing.Point(327, 251);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(190, 218);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kalkulačka poměru báze [ml]";
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
            // btn_BaseCalculator
            // 
            this.btn_BaseCalculator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_BaseCalculator.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_BaseCalculator.FlatAppearance.BorderSize = 2;
            this.btn_BaseCalculator.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_BaseCalculator.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_BaseCalculator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BaseCalculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_BaseCalculator.Location = new System.Drawing.Point(38, 146);
            this.btn_BaseCalculator.Name = "btn_BaseCalculator";
            this.btn_BaseCalculator.Size = new System.Drawing.Size(135, 63);
            this.btn_BaseCalculator.TabIndex = 5;
            this.btn_BaseCalculator.Text = "Výpočet";
            this.btn_BaseCalculator.UseVisualStyleBackColor = false;
            this.btn_BaseCalculator.Click += new System.EventHandler(this.btn_BaseCalculator_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 488);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbl_BatteryTest);
            this.Controls.Add(this.tb_Power);
            this.Controls.Add(this.tb_BatteryOutCurrent);
            this.Controls.Add(this.lbl_BatteryOutCurrent);
            this.Controls.Add(this.lbl_Power);
            this.Controls.Add(this.tb_Ohm);
            this.Controls.Add(this.lbl_Ohm);
            this.Controls.Add(this.tb_BatteryMaxCurrent);
            this.Controls.Add(this.lbl_BatteryMaxCurrent);
            this.Controls.Add(this.lbl_BatteryVoltage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_BatteryVoltage);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "V-Utils by Jakub Tenk";
            ((System.ComponentModel.ISupportInitialize)(this.tb_BatteryVoltage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tb_BatteryVoltage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_NicotineCalculator;
        private System.Windows.Forms.Label lbl_BatteryVoltage;
        private System.Windows.Forms.Label lbl_BatteryMaxCurrent;
        private System.Windows.Forms.TextBox tb_BatteryMaxCurrent;
        private System.Windows.Forms.Label lbl_Ohm;
        private System.Windows.Forms.TextBox tb_Ohm;
        private System.Windows.Forms.Label lbl_Power;
        private System.Windows.Forms.Label lbl_BatteryOutCurrent;
        private System.Windows.Forms.TextBox tb_BatteryOutCurrent;
        private System.Windows.Forms.TextBox tb_Power;
        private System.Windows.Forms.Label lbl_BatteryTest;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbMMB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbPON;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbONB;
        private System.Windows.Forms.Button btn_OhmMeter;
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
        private System.Windows.Forms.Button btn_BaseCalculator;
        private System.Windows.Forms.TextBox tbOCB;
        private System.Windows.Forms.Label label13;
    }
}

