namespace HızGöstergesi
{
    partial class Velucityİnducator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.aGauge1 = new AGaugeApp.AGauge();
            this.HızCubugu = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.HızCubugu)).BeginInit();
            this.SuspendLayout();
            // 
            // aGauge1
            // 
            this.aGauge1.BackColor = System.Drawing.SystemColors.Window;
            this.aGauge1.BaseArcColor = System.Drawing.Color.Black;
            this.aGauge1.BaseArcRadius = 130;
            this.aGauge1.BaseArcStart = 135;
            this.aGauge1.BaseArcSweep = 270;
            this.aGauge1.BaseArcWidth = 4;
            this.aGauge1.Cap_Idx = ((byte)(1));
            this.aGauge1.CapColors = new System.Drawing.Color[] {
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black,
        System.Drawing.Color.Black};
            this.aGauge1.CapPosition = new System.Drawing.Point(40, 110);
            this.aGauge1.CapsPosition = new System.Drawing.Point[] {
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(40, 110),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10),
        new System.Drawing.Point(10, 10)};
            this.aGauge1.CapsText = new string[] {
        "",
        "",
        "",
        "",
        ""};
            this.aGauge1.CapText = "";
            this.aGauge1.Center = new System.Drawing.Point(240, 220);
            this.aGauge1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aGauge1.Location = new System.Drawing.Point(34, 29);
            this.aGauge1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.aGauge1.MaxValue = 400F;
            this.aGauge1.MinValue = 0F;
            this.aGauge1.Name = "aGauge1";
            this.aGauge1.NeedleColor1 = AGaugeApp.AGauge.NeedleColorEnum.Gray;
            this.aGauge1.NeedleColor2 = System.Drawing.Color.Black;
            this.aGauge1.NeedleRadius = 100;
            this.aGauge1.NeedleType = 0;
            this.aGauge1.NeedleWidth = 3;
            this.aGauge1.Range_Idx = ((byte)(1));
            this.aGauge1.RangeColor = System.Drawing.Color.Orange;
            this.aGauge1.RangeEnabled = true;
            this.aGauge1.RangeEndValue = 300F;
            this.aGauge1.RangeInnerRadius = 70;
            this.aGauge1.RangeOuterRadius = 130;
            this.aGauge1.RangesColor = new System.Drawing.Color[] {
        System.Drawing.Color.Lime,
        System.Drawing.Color.Orange,
        System.Drawing.Color.Red,
        System.Drawing.SystemColors.Control,
        System.Drawing.SystemColors.Control};
            this.aGauge1.RangesEnabled = new bool[] {
        true,
        true,
        true,
        false,
        false};
            this.aGauge1.RangesEndValue = new float[] {
        100F,
        300F,
        400F,
        0F,
        0F};
            this.aGauge1.RangesInnerRadius = new int[] {
        70,
        70,
        70,
        70,
        70};
            this.aGauge1.RangesOuterRadius = new int[] {
        130,
        130,
        130,
        80,
        80};
            this.aGauge1.RangesStartValue = new float[] {
        0F,
        100F,
        300F,
        0F,
        0F};
            this.aGauge1.RangeStartValue = 100F;
            this.aGauge1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.aGauge1.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleLinesInterInnerRadius = 73;
            this.aGauge1.ScaleLinesInterOuterRadius = 80;
            this.aGauge1.ScaleLinesInterWidth = 1;
            this.aGauge1.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleLinesMajorInnerRadius = 70;
            this.aGauge1.ScaleLinesMajorOuterRadius = 80;
            this.aGauge1.ScaleLinesMajorStepValue = 50F;
            this.aGauge1.ScaleLinesMajorWidth = 2;
            this.aGauge1.ScaleLinesMinorColor = System.Drawing.Color.Transparent;
            this.aGauge1.ScaleLinesMinorInnerRadius = 75;
            this.aGauge1.ScaleLinesMinorNumOf = 9;
            this.aGauge1.ScaleLinesMinorOuterRadius = 80;
            this.aGauge1.ScaleLinesMinorWidth = 1;
            this.aGauge1.ScaleNumbersColor = System.Drawing.Color.Black;
            this.aGauge1.ScaleNumbersFormat = null;
            this.aGauge1.ScaleNumbersRadius = 95;
            this.aGauge1.ScaleNumbersRotation = 0;
            this.aGauge1.ScaleNumbersStartScaleLine = 0;
            this.aGauge1.ScaleNumbersStepScaleLines = 1;
            this.aGauge1.Size = new System.Drawing.Size(472, 355);
            this.aGauge1.TabIndex = 0;
            this.aGauge1.Text = "aGauge1";
            this.aGauge1.Value = 0F;
            this.aGauge1.ValueInRangeChanged += new AGaugeApp.AGauge.ValueInRangeChangedDelegate(this.aGauge1_ValueInRangeChanged);
            // 
            // HızCubugu
            // 
            this.HızCubugu.BackColor = System.Drawing.Color.DarkBlue;
            this.HızCubugu.Location = new System.Drawing.Point(34, 424);
            this.HızCubugu.Maximum = 400;
            this.HızCubugu.Name = "HızCubugu";
            this.HızCubugu.RightToLeftLayout = true;
            this.HızCubugu.Size = new System.Drawing.Size(472, 45);
            this.HızCubugu.TabIndex = 1;
            this.HızCubugu.Tag = "";
            this.HızCubugu.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.HızCubugu.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(488, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Velucityİnducator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(512, 477);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.HızCubugu);
            this.Controls.Add(this.aGauge1);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Velucityİnducator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Valucity İnducator";
            this.Load += new System.EventHandler(this.inducator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HızCubugu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public AGaugeApp.AGauge aGauge1;
        private TrackBar HızCubugu;
        private Button button1;
    }
}