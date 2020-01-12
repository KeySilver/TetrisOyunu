namespace Tetris_Oyunu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.sekil1 = new System.Windows.Forms.Timer(this.components);
            this.sekil2 = new System.Windows.Forms.Timer(this.components);
            this.sekil3 = new System.Windows.Forms.Timer(this.components);
            this.sekil4 = new System.Windows.Forms.Timer(this.components);
            this.sekil5 = new System.Windows.Forms.Timer(this.components);
            this.kontrol = new System.Windows.Forms.Timer(this.components);
            this.dondur = new System.Windows.Forms.Timer(this.components);
            this.sure = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 591);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Tetris_Oyunu.Properties.Resources.refresh_icon;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(484, 400);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 64);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Tetris_Oyunu.Properties.Resources.play_icon;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(442, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 122);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sekil1
            // 
            this.sekil1.Interval = 1;
            this.sekil1.Tick += new System.EventHandler(this.sekil1_Tick);
            // 
            // sekil2
            // 
            this.sekil2.Interval = 1;
            this.sekil2.Tick += new System.EventHandler(this.sekil2_Tick);
            // 
            // sekil3
            // 
            this.sekil3.Interval = 1;
            this.sekil3.Tick += new System.EventHandler(this.sekil3_Tick);
            // 
            // sekil4
            // 
            this.sekil4.Interval = 1;
            this.sekil4.Tick += new System.EventHandler(this.sekil4_Tick);
            // 
            // sekil5
            // 
            this.sekil5.Interval = 1;
            this.sekil5.Tick += new System.EventHandler(this.sekil5_Tick);
            // 
            // kontrol
            // 
            this.kontrol.Interval = 1;
            this.kontrol.Tick += new System.EventHandler(this.kontrol_Tick);
            // 
            // dondur
            // 
            this.dondur.Interval = 1;
            this.dondur.Tick += new System.EventHandler(this.dondur_Tick);
            // 
            // sure
            // 
            this.sure.Interval = 1000;
            this.sure.Tick += new System.EventHandler(this.sure_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(670, 591);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Tetris";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer sekil1;
        private System.Windows.Forms.Timer sekil2;
        private System.Windows.Forms.Timer sekil3;
        private System.Windows.Forms.Timer sekil4;
        private System.Windows.Forms.Timer sekil5;
        private System.Windows.Forms.Timer kontrol;
        private System.Windows.Forms.Timer dondur;
        private System.Windows.Forms.Timer sure;
    }
}

