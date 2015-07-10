﻿namespace Kid_Icarus_Uprising_Save_Editor
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
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.heartsUpDown = new System.Windows.Forms.NumericUpDown();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.enemies = new System.Windows.Forms.NumericUpDown();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.statsVal = new System.Windows.Forms.NumericUpDown();
            this.score = new System.Windows.Forms.NumericUpDown();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.unlockedBox = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.hintBox = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.lockedBox = new System.Windows.Forms.TextBox();
            this.unlockAll = new System.Windows.Forms.Button();
            this.hintButton = new System.Windows.Forms.Button();
            this.difficulty = new System.Windows.Forms.TrackBar();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.palutenaBox = new System.Windows.Forms.NumericUpDown();
            this.viridiBox = new System.Windows.Forms.NumericUpDown();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.statsNames = new System.Windows.Forms.ComboBox();
            this.featherButton = new System.Windows.Forms.Button();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.featherBox = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.trophyBox = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.neverReleased = new System.Windows.Forms.Button();
            this.unit = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.heartsUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statsVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.score)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.difficulty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.palutenaBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viridiBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Import File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // heartsUpDown
            // 
            this.heartsUpDown.Location = new System.Drawing.Point(112, 41);
            this.heartsUpDown.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.heartsUpDown.Name = "heartsUpDown";
            this.heartsUpDown.Size = new System.Drawing.Size(120, 20);
            this.heartsUpDown.TabIndex = 2;
            this.heartsUpDown.ValueChanged += new System.EventHandler(this.heartsUpDown_ValueChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(20, 43);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(86, 13);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Amount of hearts";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Chapter 1",
            "Chapter 2",
            "Chapter 3",
            "Chapter 4",
            "Chapter 5",
            "Chapter 6",
            "Chapter 7",
            "Chapter 8",
            "Chapter 9",
            "Chapter 10",
            "Chapter 11",
            "Chapter 12",
            "Chapter 13",
            "Chapter 14",
            "Chapter 15",
            "Chapter 16",
            "Chapter 17",
            "Chapter 18",
            "Chapter 19",
            "Chapter 20",
            "Chapter 21",
            "Chapter 22",
            "Chapter 23",
            "Chapter 24",
            "Chapter 25"});
            this.comboBox1.Location = new System.Drawing.Point(20, 74);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(212, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(20, 138);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(98, 13);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "Enemies Defeated";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // enemies
            // 
            this.enemies.Location = new System.Drawing.Point(151, 136);
            this.enemies.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.enemies.Name = "enemies";
            this.enemies.Size = new System.Drawing.Size(81, 20);
            this.enemies.TabIndex = 6;
            this.enemies.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Control;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(20, 397);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(212, 13);
            this.textBox4.TabIndex = 7;
            this.textBox4.Text = "Stats";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // statsVal
            // 
            this.statsVal.Location = new System.Drawing.Point(20, 443);
            this.statsVal.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.statsVal.Name = "statsVal";
            this.statsVal.Size = new System.Drawing.Size(171, 20);
            this.statsVal.TabIndex = 8;
            this.statsVal.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // score
            // 
            this.score.Location = new System.Drawing.Point(134, 110);
            this.score.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(98, 20);
            this.score.TabIndex = 10;
            this.score.ValueChanged += new System.EventHandler(this.score_ValueChanged);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Control;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Location = new System.Drawing.Point(20, 112);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 13);
            this.textBox5.TabIndex = 11;
            this.textBox5.Text = "Score";
            // 
            // unlockedBox
            // 
            this.unlockedBox.Location = new System.Drawing.Point(203, 205);
            this.unlockedBox.Name = "unlockedBox";
            this.unlockedBox.Size = new System.Drawing.Size(29, 20);
            this.unlockedBox.TabIndex = 12;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.Control;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Location = new System.Drawing.Point(20, 208);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(125, 13);
            this.textBox7.TabIndex = 13;
            this.textBox7.Text = "Achievements Unlocked";
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.Control;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Location = new System.Drawing.Point(20, 234);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(125, 13);
            this.textBox8.TabIndex = 14;
            this.textBox8.Text = "Achievements with hint";
            // 
            // hintBox
            // 
            this.hintBox.Location = new System.Drawing.Point(203, 231);
            this.hintBox.Name = "hintBox";
            this.hintBox.Size = new System.Drawing.Size(29, 20);
            this.hintBox.TabIndex = 15;
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.SystemColors.Control;
            this.textBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox10.Location = new System.Drawing.Point(20, 260);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(125, 13);
            this.textBox10.TabIndex = 16;
            this.textBox10.Text = "Achievements w/o hint";
            // 
            // lockedBox
            // 
            this.lockedBox.Location = new System.Drawing.Point(203, 257);
            this.lockedBox.Name = "lockedBox";
            this.lockedBox.Size = new System.Drawing.Size(29, 20);
            this.lockedBox.TabIndex = 17;
            // 
            // unlockAll
            // 
            this.unlockAll.Location = new System.Drawing.Point(20, 310);
            this.unlockAll.Name = "unlockAll";
            this.unlockAll.Size = new System.Drawing.Size(212, 23);
            this.unlockAll.TabIndex = 18;
            this.unlockAll.Text = "Unlock all achievements";
            this.unlockAll.UseVisualStyleBackColor = true;
            this.unlockAll.Click += new System.EventHandler(this.button2_Click);
            // 
            // hintButton
            // 
            this.hintButton.Location = new System.Drawing.Point(20, 339);
            this.hintButton.Name = "hintButton";
            this.hintButton.Size = new System.Drawing.Size(212, 23);
            this.hintButton.TabIndex = 19;
            this.hintButton.Text = "Add hints to remaining achievements";
            this.hintButton.UseVisualStyleBackColor = true;
            this.hintButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // difficulty
            // 
            this.difficulty.AutoSize = false;
            this.difficulty.Location = new System.Drawing.Point(20, 178);
            this.difficulty.Maximum = 90;
            this.difficulty.Name = "difficulty";
            this.difficulty.Size = new System.Drawing.Size(191, 21);
            this.difficulty.TabIndex = 20;
            this.difficulty.Value = 20;
            this.difficulty.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.SystemColors.Control;
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox12.Location = new System.Drawing.Point(20, 157);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(212, 13);
            this.textBox12.TabIndex = 21;
            this.textBox12.Text = "Highest intensity";
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox13
            // 
            this.textBox13.BackColor = System.Drawing.SystemColors.Control;
            this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox13.Location = new System.Drawing.Point(210, 179);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(22, 13);
            this.textBox13.TabIndex = 22;
            this.textBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox13.TextChanged += new System.EventHandler(this.textBox13_TextChanged);
            // 
            // palutenaBox
            // 
            this.palutenaBox.Location = new System.Drawing.Point(151, 477);
            this.palutenaBox.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.palutenaBox.Name = "palutenaBox";
            this.palutenaBox.Size = new System.Drawing.Size(81, 20);
            this.palutenaBox.TabIndex = 23;
            this.palutenaBox.ValueChanged += new System.EventHandler(this.palutenaBox_ValueChanged);
            // 
            // viridiBox
            // 
            this.viridiBox.Location = new System.Drawing.Point(151, 503);
            this.viridiBox.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.viridiBox.Name = "viridiBox";
            this.viridiBox.Size = new System.Drawing.Size(81, 20);
            this.viridiBox.TabIndex = 24;
            this.viridiBox.ValueChanged += new System.EventHandler(this.viridiBox_ValueChanged);
            // 
            // textBox14
            // 
            this.textBox14.BackColor = System.Drawing.SystemColors.Control;
            this.textBox14.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox14.Location = new System.Drawing.Point(20, 479);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(100, 13);
            this.textBox14.TabIndex = 25;
            this.textBox14.Text = "Offered to Palutena";
            // 
            // textBox15
            // 
            this.textBox15.BackColor = System.Drawing.SystemColors.Control;
            this.textBox15.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox15.Location = new System.Drawing.Point(20, 505);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(100, 13);
            this.textBox15.TabIndex = 26;
            this.textBox15.Text = "Offered to Viridi";
            // 
            // statsNames
            // 
            this.statsNames.FormattingEnabled = true;
            this.statsNames.Items.AddRange(new object[] {
            " Times played ",
            " Total game time ",
            " Total Solo Play time ",
            " Hearts acquired ",
            " Weapons acquired ",
            " Powers acquired ",
            " ???? ",
            " Enemies defeated ",
            " Bosses defeated ",
            " Ranged attacks ",
            " Melee attacks ",
            " Attacks evaded ",
            " Knockback Recoveries ",
            " Shots narrowly avoided ",
            " Special Attacks used ",
            " Times finished ",
            " Powers used ",
            " Items used ",
            " Times eggplanted ",
            " Times tumpuraed ",
            " Centurions summoned ",
            " Chapters cleared ",
            " Total score ",
            " Chapters cleared at max Intensity ",
            " Avg. Intensity ",
            " Avg. Intensity for cleared chapters ",
            " Hearts bet in the Fiend\'s Cauldron ",
            " Hearts lost ",
            " Most hearts acquired ",
            " Most weapons acquired ",
            " Most powers acquired ",
            " Weapons purchased ",
            " Weapons converted to hearts ",
            " ???? ",
            " ???? ",
            " ???? ",
            " ???? ",
            " ???? ",
            " Weapon fusions ",
            " Treasure boxes opened ",
            " Times pickpocketed ",
            " Souflees defeated ",
            " Rare Treasurefish defeated ",
            " Exo Tank uses ",
            " Aether Ring uses ",
            " Cherubot uses ",
            " Three Sacred Treasures uses ",
            " Lightning Chariot uses ",
            " Great Sacred Treasure uses ",
            " Time played as Magnus ",
            " Time played as Dark Pit ",
            " Practice Range uses ",
            " Nearby matches played ",
            " Nearby time played ",
            " Total Nearby participants ",
            " Far Away matches played ",
            " Total Far Away Participants ",
            " Time played With Friends ",
            " Time played With Anyone ",
            " Light vs Dark matches played ",
            " Light vs Dark matches won ",
            " Free-for-All matches played ",
            " Free-for-All matches won ",
            " Opponents defeated ",
            " Matches suspended ",
            " Times you became an angel ",
            " Times you won as an angel ",
            " Angels defeated ",
            " Weapons rewarded ",
            " Powers rewarded ",
            " Hearts rewarded ",
            " Weapon gems created ",
            " Weapon-gem-exchange partners ",
            " ??? ",
            " Weapons fused from gems ",
            " Hearts acquired by gems "});
            this.statsNames.Location = new System.Drawing.Point(20, 416);
            this.statsNames.Name = "statsNames";
            this.statsNames.Size = new System.Drawing.Size(212, 21);
            this.statsNames.TabIndex = 27;
            this.statsNames.SelectedIndexChanged += new System.EventHandler(this.statsNames_SelectedIndexChanged);
            // 
            // featherButton
            // 
            this.featherButton.Location = new System.Drawing.Point(20, 368);
            this.featherButton.Name = "featherButton";
            this.featherButton.Size = new System.Drawing.Size(212, 23);
            this.featherButton.TabIndex = 28;
            this.featherButton.Text = "Remove feather uses";
            this.featherButton.UseVisualStyleBackColor = true;
            this.featherButton.Click += new System.EventHandler(this.featherButton_Click);
            // 
            // textBox16
            // 
            this.textBox16.BackColor = System.Drawing.SystemColors.Control;
            this.textBox16.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox16.Location = new System.Drawing.Point(20, 287);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(140, 13);
            this.textBox16.TabIndex = 29;
            this.textBox16.Text = "Achievements with feather";
            // 
            // featherBox
            // 
            this.featherBox.Location = new System.Drawing.Point(203, 284);
            this.featherBox.Name = "featherBox";
            this.featherBox.Size = new System.Drawing.Size(29, 20);
            this.featherBox.TabIndex = 30;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.Control;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Location = new System.Drawing.Point(20, 532);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 13);
            this.textBox6.TabIndex = 31;
            this.textBox6.Text = "Trophies unlocked";
            // 
            // trophyBox
            // 
            this.trophyBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.trophyBox.Location = new System.Drawing.Point(164, 532);
            this.trophyBox.Name = "trophyBox";
            this.trophyBox.ReadOnly = true;
            this.trophyBox.Size = new System.Drawing.Size(33, 13);
            this.trophyBox.TabIndex = 32;
            this.trophyBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.SystemColors.Control;
            this.textBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox11.Location = new System.Drawing.Point(203, 532);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(29, 13);
            this.textBox11.TabIndex = 33;
            this.textBox11.Text = "/412";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(20, 552);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 23);
            this.button2.TabIndex = 34;
            this.button2.Text = "Unlock all trophies";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // neverReleased
            // 
            this.neverReleased.Location = new System.Drawing.Point(20, 582);
            this.neverReleased.Name = "neverReleased";
            this.neverReleased.Size = new System.Drawing.Size(212, 23);
            this.neverReleased.TabIndex = 35;
            this.neverReleased.Text = "Unlock never-released two trophies";
            this.neverReleased.UseVisualStyleBackColor = true;
            this.neverReleased.Click += new System.EventHandler(this.neverReleased_Click);
            // 
            // unit
            // 
            this.unit.BackColor = System.Drawing.SystemColors.Control;
            this.unit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.unit.Location = new System.Drawing.Point(197, 445);
            this.unit.Name = "unit";
            this.unit.Size = new System.Drawing.Size(35, 13);
            this.unit.TabIndex = 36;
            this.unit.Text = "units";
            this.unit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.unit.TextChanged += new System.EventHandler(this.unit_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 616);
            this.Controls.Add(this.unit);
            this.Controls.Add(this.neverReleased);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.trophyBox);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.featherBox);
            this.Controls.Add(this.textBox16);
            this.Controls.Add(this.featherButton);
            this.Controls.Add(this.statsNames);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.viridiBox);
            this.Controls.Add(this.palutenaBox);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.difficulty);
            this.Controls.Add(this.hintButton);
            this.Controls.Add(this.unlockAll);
            this.Controls.Add(this.lockedBox);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.hintBox);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.unlockedBox);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.score);
            this.Controls.Add(this.statsVal);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.enemies);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.heartsUpDown);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.heartsUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statsVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.score)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.difficulty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.palutenaBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viridiBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.NumericUpDown heartsUpDown;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.NumericUpDown enemies;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.NumericUpDown statsVal;
        private System.Windows.Forms.NumericUpDown score;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox unlockedBox;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox hintBox;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox lockedBox;
        private System.Windows.Forms.Button unlockAll;
        private System.Windows.Forms.Button hintButton;
        private System.Windows.Forms.TrackBar difficulty;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.NumericUpDown palutenaBox;
        private System.Windows.Forms.NumericUpDown viridiBox;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.ComboBox statsNames;
        private System.Windows.Forms.Button featherButton;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox featherBox;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox trophyBox;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button neverReleased;
        private System.Windows.Forms.TextBox unit;
    }
}
