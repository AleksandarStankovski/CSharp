namespace BGNtoEURConverter
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
            this.numericUpDownAmount = new System.Windows.Forms.NumericUpDown();
            this.labelResult = new System.Windows.Forms.Label();
            this.conevrt = new System.Windows.Forms.Label();
            this.BGNtoEUR = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownAmount
            // 
            this.numericUpDownAmount.DecimalPlaces = 2;
            this.numericUpDownAmount.Location = new System.Drawing.Point(122, 18);
            this.numericUpDownAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numericUpDownAmount.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDownAmount.Name = "numericUpDownAmount";
            this.numericUpDownAmount.Size = new System.Drawing.Size(146, 26);
            this.numericUpDownAmount.TabIndex = 0;
            this.numericUpDownAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAmount.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            this.numericUpDownAmount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numericUpDownAmount_KeyUp);
            // 
            // labelResult
            // 
            this.labelResult.BackColor = System.Drawing.Color.PaleGreen;
            this.labelResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.Location = new System.Drawing.Point(32, 55);
            this.labelResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(366, 46);
            this.labelResult.TabIndex = 1;
            this.labelResult.Text = "label1";
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelResult.Click += new System.EventHandler(this.label1_Click);
            // 
            // conevrt
            // 
            this.conevrt.AutoSize = true;
            this.conevrt.Location = new System.Drawing.Point(28, 20);
            this.conevrt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.conevrt.Name = "conevrt";
            this.conevrt.Size = new System.Drawing.Size(71, 20);
            this.conevrt.TabIndex = 2;
            this.conevrt.Text = "Convert";
            // 
            // BGNtoEUR
            // 
            this.BGNtoEUR.Location = new System.Drawing.Point(290, 20);
            this.BGNtoEUR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BGNtoEUR.Name = "BGNtoEUR";
            this.BGNtoEUR.Size = new System.Drawing.Size(123, 20);
            this.BGNtoEUR.TabIndex = 0;
            this.BGNtoEUR.Text = "BGN to EUR";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 115);
            this.Controls.Add(this.BGNtoEUR);
            this.Controls.Add(this.conevrt);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.numericUpDownAmount);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "BGN to EUR";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownAmount;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label conevrt;
        private System.Windows.Forms.Label BGNtoEUR;
    }
}

