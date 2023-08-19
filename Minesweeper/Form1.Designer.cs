namespace Minesweeper
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
            this.tileNumber = new System.Windows.Forms.NumericUpDown();
            this.tileGenerator = new System.Windows.Forms.Button();
            this.switchState = new System.Windows.Forms.Button();
            this.stateShower = new System.Windows.Forms.Label();
            this.BombNumber = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PresetEasy = new System.Windows.Forms.Button();
            this.PresetModerate = new System.Windows.Forms.Button();
            this.PresetHard = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.DetectorButton = new System.Windows.Forms.Button();
            this.victory = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BombsLeftCounter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tileNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BombNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // tileNumber
            // 
            this.tileNumber.Location = new System.Drawing.Point(177, 98);
            this.tileNumber.Margin = new System.Windows.Forms.Padding(4);
            this.tileNumber.Maximum = new decimal(new int[] {
            21,
            0,
            0,
            0});
            this.tileNumber.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.tileNumber.Name = "tileNumber";
            this.tileNumber.Size = new System.Drawing.Size(173, 22);
            this.tileNumber.TabIndex = 0;
            this.tileNumber.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.tileNumber.ValueChanged += new System.EventHandler(this.tileNumber_ValueChanged);
            // 
            // tileGenerator
            // 
            this.tileGenerator.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tileGenerator.Location = new System.Drawing.Point(411, 94);
            this.tileGenerator.Margin = new System.Windows.Forms.Padding(4);
            this.tileGenerator.Name = "tileGenerator";
            this.tileGenerator.Size = new System.Drawing.Size(130, 55);
            this.tileGenerator.TabIndex = 1;
            this.tileGenerator.Text = "Generate";
            this.tileGenerator.UseVisualStyleBackColor = true;
            this.tileGenerator.Click += new System.EventHandler(this.tileGenerator_Click);
            // 
            // switchState
            // 
            this.switchState.BackColor = System.Drawing.Color.Green;
            this.switchState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.switchState.Location = new System.Drawing.Point(177, 539);
            this.switchState.Margin = new System.Windows.Forms.Padding(4);
            this.switchState.Name = "switchState";
            this.switchState.Size = new System.Drawing.Size(195, 77);
            this.switchState.TabIndex = 2;
            this.switchState.Text = "Switch to Flags";
            this.switchState.UseVisualStyleBackColor = false;
            this.switchState.Click += new System.EventHandler(this.switchState_Click);
            // 
            // stateShower
            // 
            this.stateShower.AutoSize = true;
            this.stateShower.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stateShower.Location = new System.Drawing.Point(138, 492);
            this.stateShower.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stateShower.Name = "stateShower";
            this.stateShower.Size = new System.Drawing.Size(212, 25);
            this.stateShower.TabIndex = 3;
            this.stateShower.Text = "Current State: Detector";
            // 
            // BombNumber
            // 
            this.BombNumber.Location = new System.Drawing.Point(177, 154);
            this.BombNumber.Margin = new System.Windows.Forms.Padding(4);
            this.BombNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BombNumber.Name = "BombNumber";
            this.BombNumber.Size = new System.Drawing.Size(173, 22);
            this.BombNumber.TabIndex = 4;
            this.BombNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(169, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "Generator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Board Length:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 157);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Number of Bombs:";
            // 
            // PresetEasy
            // 
            this.PresetEasy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PresetEasy.Location = new System.Drawing.Point(177, 200);
            this.PresetEasy.Margin = new System.Windows.Forms.Padding(4);
            this.PresetEasy.Name = "PresetEasy";
            this.PresetEasy.Size = new System.Drawing.Size(173, 49);
            this.PresetEasy.TabIndex = 9;
            this.PresetEasy.Text = "Beginner";
            this.PresetEasy.UseVisualStyleBackColor = true;
            this.PresetEasy.Click += new System.EventHandler(this.PresetEasy_Click);
            // 
            // PresetModerate
            // 
            this.PresetModerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PresetModerate.Location = new System.Drawing.Point(177, 266);
            this.PresetModerate.Margin = new System.Windows.Forms.Padding(4);
            this.PresetModerate.Name = "PresetModerate";
            this.PresetModerate.Size = new System.Drawing.Size(173, 49);
            this.PresetModerate.TabIndex = 10;
            this.PresetModerate.Text = "Intermediate";
            this.PresetModerate.UseVisualStyleBackColor = true;
            this.PresetModerate.Click += new System.EventHandler(this.PresetModerate_Click);
            // 
            // PresetHard
            // 
            this.PresetHard.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PresetHard.Location = new System.Drawing.Point(177, 334);
            this.PresetHard.Margin = new System.Windows.Forms.Padding(4);
            this.PresetHard.Name = "PresetHard";
            this.PresetHard.Size = new System.Drawing.Size(173, 49);
            this.PresetHard.TabIndex = 11;
            this.PresetHard.Text = "Expert";
            this.PresetHard.UseVisualStyleBackColor = true;
            this.PresetHard.Click += new System.EventHandler(this.PresetHard_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(10, 211);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Preset Difficulty";
            // 
            // DetectorButton
            // 
            this.DetectorButton.Location = new System.Drawing.Point(473, 266);
            this.DetectorButton.Margin = new System.Windows.Forms.Padding(4);
            this.DetectorButton.Name = "DetectorButton";
            this.DetectorButton.Size = new System.Drawing.Size(100, 28);
            this.DetectorButton.TabIndex = 14;
            this.DetectorButton.Text = "Detect";
            this.DetectorButton.UseVisualStyleBackColor = true;
            this.DetectorButton.Click += new System.EventHandler(this.DetectorButton_Click);
            // 
            // victory
            // 
            this.victory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.victory.AutoSize = true;
            this.victory.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.victory.Location = new System.Drawing.Point(39, 393);
            this.victory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.victory.Name = "victory";
            this.victory.Size = new System.Drawing.Size(0, 39);
            this.victory.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(379, 266);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Cheats:";
            // 
            // BombsLeftCounter
            // 
            this.BombsLeftCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BombsLeftCounter.AutoSize = true;
            this.BombsLeftCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BombsLeftCounter.Location = new System.Drawing.Point(12, 432);
            this.BombsLeftCounter.Name = "BombsLeftCounter";
            this.BombsLeftCounter.Size = new System.Drawing.Size(116, 25);
            this.BombsLeftCounter.TabIndex = 16;
            this.BombsLeftCounter.Text = "Bombs Left:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(631, 629);
            this.Controls.Add(this.BombsLeftCounter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DetectorButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PresetHard);
            this.Controls.Add(this.PresetModerate);
            this.Controls.Add(this.PresetEasy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.victory);
            this.Controls.Add(this.BombNumber);
            this.Controls.Add(this.stateShower);
            this.Controls.Add(this.switchState);
            this.Controls.Add(this.tileGenerator);
            this.Controls.Add(this.tileNumber);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tileNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BombNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown tileNumber;
        private System.Windows.Forms.Button tileGenerator;
        private System.Windows.Forms.Button switchState;
        private System.Windows.Forms.Label stateShower;
        private System.Windows.Forms.NumericUpDown BombNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button PresetEasy;
        private System.Windows.Forms.Button PresetModerate;
        private System.Windows.Forms.Button PresetHard;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DetectorButton;
        private System.Windows.Forms.Label victory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label BombsLeftCounter;
    }
}

