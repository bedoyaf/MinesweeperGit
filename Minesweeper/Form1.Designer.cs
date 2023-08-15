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
            ((System.ComponentModel.ISupportInitialize)(this.tileNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BombNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // tileNumber
            // 
            this.tileNumber.Location = new System.Drawing.Point(1124, 63);
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
            this.tileNumber.Size = new System.Drawing.Size(130, 20);
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
            this.tileGenerator.Location = new System.Drawing.Point(1300, 60);
            this.tileGenerator.Name = "tileGenerator";
            this.tileGenerator.Size = new System.Drawing.Size(75, 23);
            this.tileGenerator.TabIndex = 1;
            this.tileGenerator.Text = "Generate";
            this.tileGenerator.UseVisualStyleBackColor = true;
            this.tileGenerator.Click += new System.EventHandler(this.tileGenerator_Click);
            // 
            // switchState
            // 
            this.switchState.Location = new System.Drawing.Point(1270, 527);
            this.switchState.Name = "switchState";
            this.switchState.Size = new System.Drawing.Size(104, 55);
            this.switchState.TabIndex = 2;
            this.switchState.Text = "Switch to Flags";
            this.switchState.UseVisualStyleBackColor = true;
            this.switchState.Click += new System.EventHandler(this.switchState_Click);
            // 
            // stateShower
            // 
            this.stateShower.AutoSize = true;
            this.stateShower.Location = new System.Drawing.Point(1267, 492);
            this.stateShower.Name = "stateShower";
            this.stateShower.Size = new System.Drawing.Size(116, 13);
            this.stateShower.TabIndex = 3;
            this.stateShower.Text = "Current State: Detector";
            // 
            // BombNumber
            // 
            this.BombNumber.Location = new System.Drawing.Point(1124, 109);
            this.BombNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BombNumber.Name = "BombNumber";
            this.BombNumber.Size = new System.Drawing.Size(130, 20);
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
            this.label1.Location = new System.Drawing.Point(1118, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Generator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1044, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Board Length:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1024, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Number of Bombs:";
            // 
            // PresetEasy
            // 
            this.PresetEasy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PresetEasy.Location = new System.Drawing.Point(1124, 146);
            this.PresetEasy.Name = "PresetEasy";
            this.PresetEasy.Size = new System.Drawing.Size(130, 40);
            this.PresetEasy.TabIndex = 9;
            this.PresetEasy.Text = "Beginner";
            this.PresetEasy.UseVisualStyleBackColor = true;
            this.PresetEasy.Click += new System.EventHandler(this.PresetEasy_Click);
            // 
            // PresetModerate
            // 
            this.PresetModerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PresetModerate.Location = new System.Drawing.Point(1124, 200);
            this.PresetModerate.Name = "PresetModerate";
            this.PresetModerate.Size = new System.Drawing.Size(130, 40);
            this.PresetModerate.TabIndex = 10;
            this.PresetModerate.Text = "Intermediate";
            this.PresetModerate.UseVisualStyleBackColor = true;
            this.PresetModerate.Click += new System.EventHandler(this.PresetModerate_Click);
            // 
            // PresetHard
            // 
            this.PresetHard.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PresetHard.Location = new System.Drawing.Point(1124, 255);
            this.PresetHard.Name = "PresetHard";
            this.PresetHard.Size = new System.Drawing.Size(130, 40);
            this.PresetHard.TabIndex = 11;
            this.PresetHard.Text = "Expert";
            this.PresetHard.UseVisualStyleBackColor = true;
            this.PresetHard.Click += new System.EventHandler(this.PresetHard_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(999, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Preset Difficulty";
            // 
            // DetectorButton
            // 
            this.DetectorButton.Location = new System.Drawing.Point(1346, 200);
            this.DetectorButton.Name = "DetectorButton";
            this.DetectorButton.Size = new System.Drawing.Size(75, 23);
            this.DetectorButton.TabIndex = 14;
            this.DetectorButton.Text = "Detect";
            this.DetectorButton.UseVisualStyleBackColor = true;
            this.DetectorButton.Click += new System.EventHandler(this.DetectorButton_Click);
            // 
            // victory
            // 
            this.victory.AutoSize = true;
            this.victory.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.victory.Location = new System.Drawing.Point(55, 527);
            this.victory.Name = "victory";
            this.victory.Size = new System.Drawing.Size(0, 31);
            this.victory.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(1276, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Cheats:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1459, 961);
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
    }
}

