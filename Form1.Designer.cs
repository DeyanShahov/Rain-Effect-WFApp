namespace Rain_Effect_WFApp
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            RainEffectEvent = new System.Windows.Forms.Timer(components);
            countDrops = new TrackBar();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)countDrops).BeginInit();
            SuspendLayout();
            // 
            // RainEffectEvent
            // 
            RainEffectEvent.Enabled = true;
            RainEffectEvent.Interval = 20;
            RainEffectEvent.Tick += TimerEvent;
            // 
            // countDrops
            // 
            countDrops.BackColor = Color.Black;
            countDrops.Location = new Point(505, 12);
            countDrops.Name = "countDrops";
            countDrops.RightToLeft = RightToLeft.No;
            countDrops.Size = new Size(236, 45);
            countDrops.TabIndex = 0;
            countDrops.ValueChanged += onDropValueChanged;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(736, 12);
            label1.Name = "label1";
            label1.Size = new Size(67, 44);
            label1.TabIndex = 2;
            label1.Text = "TEXT1";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(countDrops);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Rain Effect";
            Paint += FormPaintEvent;
            ((System.ComponentModel.ISupportInitialize)countDrops).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer RainEffectEvent;
        private TrackBar countDrops;
        private Label label1;
    }
}