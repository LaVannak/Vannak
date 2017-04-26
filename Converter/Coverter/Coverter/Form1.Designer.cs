namespace Coverter
{
    partial class FrmConverter
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
            this.lblOutput = new System.Windows.Forms.Label();
            this.NumInput = new System.Windows.Forms.NumericUpDown();
            this.cmbWstern = new System.Windows.Forms.ComboBox();
            this.cmbAsia = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbTemperature = new System.Windows.Forms.RadioButton();
            this.rdbValume = new System.Windows.Forms.RadioButton();
            this.rdbArea = new System.Windows.Forms.RadioButton();
            this.rdbLength = new System.Windows.Forms.RadioButton();
            this.rdbWeiht = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.NumInput)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "To";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(172, 159);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 13);
            this.lblOutput.TabIndex = 3;
            // 
            // NumInput
            // 
            this.NumInput.DecimalPlaces = 2;
            this.NumInput.Location = new System.Drawing.Point(13, 151);
            this.NumInput.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NumInput.Name = "NumInput";
            this.NumInput.Size = new System.Drawing.Size(120, 20);
            this.NumInput.TabIndex = 6;
            this.NumInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumInput.ValueChanged += new System.EventHandler(this.NumInput_ValueChanged);
            // 
            // cmbWstern
            // 
            this.cmbWstern.FormattingEnabled = true;
            this.cmbWstern.Items.AddRange(new object[] {
            "adf"});
            this.cmbWstern.Location = new System.Drawing.Point(11, 124);
            this.cmbWstern.Name = "cmbWstern";
            this.cmbWstern.Size = new System.Drawing.Size(121, 21);
            this.cmbWstern.TabIndex = 1;
            this.cmbWstern.SelectedIndexChanged += new System.EventHandler(this.cmbWstern_SelectedIndexChanged);
            // 
            // cmbAsia
            // 
            this.cmbAsia.FormattingEnabled = true;
            this.cmbAsia.Items.AddRange(new object[] {
            "df"});
            this.cmbAsia.Location = new System.Drawing.Point(164, 124);
            this.cmbAsia.Name = "cmbAsia";
            this.cmbAsia.Size = new System.Drawing.Size(121, 21);
            this.cmbAsia.TabIndex = 7;
            this.cmbAsia.SelectedIndexChanged += new System.EventHandler(this.cmbAsia_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbTemperature);
            this.groupBox1.Controls.Add(this.rdbValume);
            this.groupBox1.Controls.Add(this.rdbArea);
            this.groupBox1.Controls.Add(this.rdbLength);
            this.groupBox1.Controls.Add(this.rdbWeiht);
            this.groupBox1.Location = new System.Drawing.Point(8, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 82);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type of Measurement Units";
            // 
            // rdbTemperature
            // 
            this.rdbTemperature.AutoSize = true;
            this.rdbTemperature.Location = new System.Drawing.Point(100, 48);
            this.rdbTemperature.Name = "rdbTemperature";
            this.rdbTemperature.Size = new System.Drawing.Size(85, 17);
            this.rdbTemperature.TabIndex = 4;
            this.rdbTemperature.Text = "Temperature";
            this.rdbTemperature.UseVisualStyleBackColor = true;
            this.rdbTemperature.CheckedChanged += new System.EventHandler(this.rdbTemperature_CheckedChanged);
            // 
            // rdbValume
            // 
            this.rdbValume.AutoSize = true;
            this.rdbValume.Location = new System.Drawing.Point(8, 48);
            this.rdbValume.Name = "rdbValume";
            this.rdbValume.Size = new System.Drawing.Size(60, 17);
            this.rdbValume.TabIndex = 3;
            this.rdbValume.Text = "Volume";
            this.rdbValume.UseVisualStyleBackColor = true;
            this.rdbValume.CheckedChanged += new System.EventHandler(this.rdbValume_CheckedChanged);
            // 
            // rdbArea
            // 
            this.rdbArea.AutoSize = true;
            this.rdbArea.Location = new System.Drawing.Point(205, 24);
            this.rdbArea.Name = "rdbArea";
            this.rdbArea.Size = new System.Drawing.Size(47, 17);
            this.rdbArea.TabIndex = 2;
            this.rdbArea.Text = "Area";
            this.rdbArea.UseVisualStyleBackColor = true;
            this.rdbArea.CheckedChanged += new System.EventHandler(this.rdbArea_CheckedChanged);
            // 
            // rdbLength
            // 
            this.rdbLength.AutoSize = true;
            this.rdbLength.Location = new System.Drawing.Point(10, 25);
            this.rdbLength.Name = "rdbLength";
            this.rdbLength.Size = new System.Drawing.Size(58, 17);
            this.rdbLength.TabIndex = 1;
            this.rdbLength.Text = "Length";
            this.rdbLength.UseVisualStyleBackColor = true;
            this.rdbLength.CheckedChanged += new System.EventHandler(this.rdbLength_CheckedChanged);
            // 
            // rdbWeiht
            // 
            this.rdbWeiht.AutoSize = true;
            this.rdbWeiht.Location = new System.Drawing.Point(100, 24);
            this.rdbWeiht.Name = "rdbWeiht";
            this.rdbWeiht.Size = new System.Drawing.Size(59, 17);
            this.rdbWeiht.TabIndex = 0;
            this.rdbWeiht.Text = "Weight";
            this.rdbWeiht.UseVisualStyleBackColor = true;
            this.rdbWeiht.CheckedChanged += new System.EventHandler(this.rdbWeiht_CheckedChanged);
            // 
            // FrmConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(316, 189);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbAsia);
            this.Controls.Add(this.NumInput);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbWstern);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmConverter";
            this.Text = "Converter";
            this.Load += new System.EventHandler(this.FrmConverter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumInput)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.NumericUpDown NumInput;
        private System.Windows.Forms.ComboBox cmbWstern;
        private System.Windows.Forms.ComboBox cmbAsia;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbArea;
        private System.Windows.Forms.RadioButton rdbLength;
        private System.Windows.Forms.RadioButton rdbWeiht;
        private System.Windows.Forms.RadioButton rdbTemperature;
        private System.Windows.Forms.RadioButton rdbValume;
    }
}

