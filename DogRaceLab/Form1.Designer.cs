namespace DogRaceLab
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.racetrackPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnRace = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rbJoe = new System.Windows.Forms.RadioButton();
            this.rbBob = new System.Windows.Forms.RadioButton();
            this.rbAl = new System.Windows.Forms.RadioButton();
            this.lbMinimumBet = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.btnBet = new System.Windows.Forms.Button();
            this.nrDolar = new System.Windows.Forms.NumericUpDown();
            this.lbBucksOnDog = new System.Windows.Forms.Label();
            this.nrDog = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.lbJoe = new System.Windows.Forms.Label();
            this.lbBob = new System.Windows.Forms.Label();
            this.lbAl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racetrackPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrDolar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrDog)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DogRaceLab.Properties.Resources.dog;
            this.pictureBox1.Location = new System.Drawing.Point(15, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 25);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // racetrackPictureBox
            // 
            this.racetrackPictureBox.Image = global::DogRaceLab.Properties.Resources.racetrack;
            this.racetrackPictureBox.Location = new System.Drawing.Point(12, 12);
            this.racetrackPictureBox.Name = "racetrackPictureBox";
            this.racetrackPictureBox.Size = new System.Drawing.Size(606, 205);
            this.racetrackPictureBox.TabIndex = 0;
            this.racetrackPictureBox.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DogRaceLab.Properties.Resources.dog;
            this.pictureBox2.Location = new System.Drawing.Point(15, 65);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(78, 25);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DogRaceLab.Properties.Resources.dog;
            this.pictureBox3.Location = new System.Drawing.Point(15, 121);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(78, 25);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::DogRaceLab.Properties.Resources.dog;
            this.pictureBox4.Location = new System.Drawing.Point(15, 175);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(78, 25);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // btnRace
            // 
            this.btnRace.Location = new System.Drawing.Point(465, 256);
            this.btnRace.Name = "btnRace";
            this.btnRace.Size = new System.Drawing.Size(89, 44);
            this.btnRace.TabIndex = 5;
            this.btnRace.Text = "Race!";
            this.btnRace.UseVisualStyleBackColor = true;
            this.btnRace.Click += new System.EventHandler(this.btnRace_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rbJoe
            // 
            this.rbJoe.AutoSize = true;
            this.rbJoe.Checked = true;
            this.rbJoe.Location = new System.Drawing.Point(8, 246);
            this.rbJoe.Name = "rbJoe";
            this.rbJoe.Size = new System.Drawing.Size(109, 17);
            this.rbJoe.TabIndex = 6;
            this.rbJoe.TabStop = true;
            this.rbJoe.Text = "Joe has 50 bucks";
            this.rbJoe.UseVisualStyleBackColor = true;
            this.rbJoe.CheckedChanged += new System.EventHandler(this.rbJoe_CheckedChanged);
            // 
            // rbBob
            // 
            this.rbBob.AutoSize = true;
            this.rbBob.Location = new System.Drawing.Point(8, 270);
            this.rbBob.Name = "rbBob";
            this.rbBob.Size = new System.Drawing.Size(114, 17);
            this.rbBob.TabIndex = 7;
            this.rbBob.Text = "Bob  has 75 bucks";
            this.rbBob.UseVisualStyleBackColor = true;
            this.rbBob.CheckedChanged += new System.EventHandler(this.rbBob_CheckedChanged);
            // 
            // rbAl
            // 
            this.rbAl.AutoSize = true;
            this.rbAl.Location = new System.Drawing.Point(8, 294);
            this.rbAl.Name = "rbAl";
            this.rbAl.Size = new System.Drawing.Size(104, 17);
            this.rbAl.TabIndex = 8;
            this.rbAl.Text = "Al  has 45 bucks";
            this.rbAl.UseVisualStyleBackColor = true;
            this.rbAl.CheckedChanged += new System.EventHandler(this.rbAl_CheckedChanged);
            // 
            // lbMinimumBet
            // 
            this.lbMinimumBet.AutoSize = true;
            this.lbMinimumBet.Location = new System.Drawing.Point(12, 224);
            this.lbMinimumBet.Name = "lbMinimumBet";
            this.lbMinimumBet.Size = new System.Drawing.Size(110, 13);
            this.lbMinimumBet.TabIndex = 9;
            this.lbMinimumBet.Text = "Minimum bet: 5 bucks";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(12, 331);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(24, 13);
            this.lbName.TabIndex = 10;
            this.lbName.Text = "Joe";
            // 
            // btnBet
            // 
            this.btnBet.Location = new System.Drawing.Point(42, 326);
            this.btnBet.Name = "btnBet";
            this.btnBet.Size = new System.Drawing.Size(58, 23);
            this.btnBet.TabIndex = 11;
            this.btnBet.Text = "Bets";
            this.btnBet.UseVisualStyleBackColor = true;
            this.btnBet.Click += new System.EventHandler(this.btnBet_Click);
            // 
            // nrDolar
            // 
            this.nrDolar.Location = new System.Drawing.Point(116, 329);
            this.nrDolar.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nrDolar.Name = "nrDolar";
            this.nrDolar.Size = new System.Drawing.Size(54, 20);
            this.nrDolar.TabIndex = 12;
            this.nrDolar.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lbBucksOnDog
            // 
            this.lbBucksOnDog.AutoSize = true;
            this.lbBucksOnDog.Location = new System.Drawing.Point(176, 331);
            this.lbBucksOnDog.Name = "lbBucksOnDog";
            this.lbBucksOnDog.Size = new System.Drawing.Size(110, 13);
            this.lbBucksOnDog.TabIndex = 13;
            this.lbBucksOnDog.Text = "bucks on dog number";
            // 
            // nrDog
            // 
            this.nrDog.Location = new System.Drawing.Point(292, 329);
            this.nrDog.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nrDog.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nrDog.Name = "nrDog";
            this.nrDog.Size = new System.Drawing.Size(54, 20);
            this.nrDog.TabIndex = 14;
            this.nrDog.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(217, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Bets";
            // 
            // lbJoe
            // 
            this.lbJoe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbJoe.Location = new System.Drawing.Point(220, 246);
            this.lbJoe.Name = "lbJoe";
            this.lbJoe.Size = new System.Drawing.Size(150, 15);
            this.lbJoe.TabIndex = 16;
            this.lbJoe.Text = "Joe hasn\'t placed a bet";
            // 
            // lbBob
            // 
            this.lbBob.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbBob.Location = new System.Drawing.Point(220, 271);
            this.lbBob.Name = "lbBob";
            this.lbBob.Size = new System.Drawing.Size(150, 15);
            this.lbBob.TabIndex = 17;
            this.lbBob.Text = "Bob hasn\'t placed a bet";
            // 
            // lbAl
            // 
            this.lbAl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbAl.Location = new System.Drawing.Point(220, 296);
            this.lbAl.Name = "lbAl";
            this.lbAl.Size = new System.Drawing.Size(150, 15);
            this.lbAl.TabIndex = 18;
            this.lbAl.Text = "Al hasn\'t placed a bet";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 371);
            this.Controls.Add(this.lbAl);
            this.Controls.Add(this.lbBob);
            this.Controls.Add(this.lbJoe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nrDog);
            this.Controls.Add(this.lbBucksOnDog);
            this.Controls.Add(this.nrDolar);
            this.Controls.Add(this.btnBet);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbMinimumBet);
            this.Controls.Add(this.rbAl);
            this.Controls.Add(this.rbBob);
            this.Controls.Add(this.rbJoe);
            this.Controls.Add(this.btnRace);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.racetrackPictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racetrackPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrDolar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrDog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox racetrackPictureBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnRace;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton rbJoe;
        private System.Windows.Forms.RadioButton rbBob;
        private System.Windows.Forms.RadioButton rbAl;
        private System.Windows.Forms.Label lbMinimumBet;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Button btnBet;
        private System.Windows.Forms.NumericUpDown nrDolar;
        private System.Windows.Forms.Label lbBucksOnDog;
        private System.Windows.Forms.NumericUpDown nrDog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbJoe;
        private System.Windows.Forms.Label lbBob;
        private System.Windows.Forms.Label lbAl;
    }
}

