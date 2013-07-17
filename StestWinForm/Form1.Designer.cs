namespace StestWinForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LandBox = new System.Windows.Forms.NumericUpDown();
            this.SpellBox = new System.Windows.Forms.NumericUpDown();
            this.MaxBox = new System.Windows.Forms.NumericUpDown();
            this.MinBox = new System.Windows.Forms.NumericUpDown();
            this.TurnBox = new System.Windows.Forms.NumericUpDown();
            this.GameBox = new System.Windows.Forms.NumericUpDown();
            this.ResultsText = new System.Windows.Forms.RichTextBox();
            this.DetailsCheck = new System.Windows.Forms.CheckBox();
            this.RunButton = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.LandBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpellBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TurnBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lands";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Spells";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(224, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Max";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(224, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "Min";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(423, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 26);
            this.label5.TabIndex = 5;
            this.label5.Text = "Turns";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(423, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 26);
            this.label6.TabIndex = 4;
            this.label6.Text = "Games";
            // 
            // LandBox
            // 
            this.LandBox.Location = new System.Drawing.Point(109, 49);
            this.LandBox.Name = "LandBox";
            this.LandBox.Size = new System.Drawing.Size(109, 20);
            this.LandBox.TabIndex = 6;
            // 
            // SpellBox
            // 
            this.SpellBox.Location = new System.Drawing.Point(109, 97);
            this.SpellBox.Name = "SpellBox";
            this.SpellBox.Size = new System.Drawing.Size(109, 20);
            this.SpellBox.TabIndex = 7;
            // 
            // MaxBox
            // 
            this.MaxBox.Location = new System.Drawing.Point(287, 99);
            this.MaxBox.Name = "MaxBox";
            this.MaxBox.Size = new System.Drawing.Size(109, 20);
            this.MaxBox.TabIndex = 9;
            // 
            // MinBox
            // 
            this.MinBox.Location = new System.Drawing.Point(287, 51);
            this.MinBox.Name = "MinBox";
            this.MinBox.Size = new System.Drawing.Size(109, 20);
            this.MinBox.TabIndex = 8;
            // 
            // TurnBox
            // 
            this.TurnBox.Location = new System.Drawing.Point(512, 99);
            this.TurnBox.Name = "TurnBox";
            this.TurnBox.Size = new System.Drawing.Size(109, 20);
            this.TurnBox.TabIndex = 11;
            // 
            // GameBox
            // 
            this.GameBox.Location = new System.Drawing.Point(512, 51);
            this.GameBox.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.GameBox.Name = "GameBox";
            this.GameBox.Size = new System.Drawing.Size(109, 20);
            this.GameBox.TabIndex = 10;
            // 
            // ResultsText
            // 
            this.ResultsText.Location = new System.Drawing.Point(36, 191);
            this.ResultsText.Name = "ResultsText";
            this.ResultsText.Size = new System.Drawing.Size(749, 429);
            this.ResultsText.TabIndex = 12;
            this.ResultsText.Text = "";
            // 
            // DetailsCheck
            // 
            this.DetailsCheck.AutoSize = true;
            this.DetailsCheck.Location = new System.Drawing.Point(109, 132);
            this.DetailsCheck.Name = "DetailsCheck";
            this.DetailsCheck.Size = new System.Drawing.Size(144, 17);
            this.DetailsCheck.TabIndex = 13;
            this.DetailsCheck.Text = "Report Individual Results";
            this.DetailsCheck.UseVisualStyleBackColor = true;
            // 
            // RunButton
            // 
            this.RunButton.Location = new System.Drawing.Point(36, 132);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(67, 23);
            this.RunButton.TabIndex = 14;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(36, 162);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(749, 23);
            this.progressBar1.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 632);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.DetailsCheck);
            this.Controls.Add(this.ResultsText);
            this.Controls.Add(this.TurnBox);
            this.Controls.Add(this.GameBox);
            this.Controls.Add(this.MaxBox);
            this.Controls.Add(this.MinBox);
            this.Controls.Add(this.SpellBox);
            this.Controls.Add(this.LandBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.LandBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpellBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TurnBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown LandBox;
        private System.Windows.Forms.NumericUpDown SpellBox;
        private System.Windows.Forms.NumericUpDown MaxBox;
        private System.Windows.Forms.NumericUpDown MinBox;
        private System.Windows.Forms.NumericUpDown TurnBox;
        private System.Windows.Forms.NumericUpDown GameBox;
        private System.Windows.Forms.RichTextBox ResultsText;
        private System.Windows.Forms.CheckBox DetailsCheck;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

