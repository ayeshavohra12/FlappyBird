namespace Flappybird
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
            this.flappybird = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.pipeooperwala = new System.Windows.Forms.PictureBox();
            this.pipeneechewala = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.flappybird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeooperwala)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeneechewala)).BeginInit();
            this.SuspendLayout();
            // 
            // flappybird
            // 
            this.flappybird.Image = ((System.Drawing.Image)(resources.GetObject("flappybird.Image")));
            this.flappybird.Location = new System.Drawing.Point(28, 118);
            this.flappybird.Name = "flappybird";
            this.flappybird.Size = new System.Drawing.Size(78, 62);
            this.flappybird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappybird.TabIndex = 0;
            this.flappybird.TabStop = false;
            this.flappybird.Click += new System.EventHandler(this.flappybird_Click);
            // 
            // ground
            // 
            this.ground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ground.Image = ((System.Drawing.Image)(resources.GetObject("ground.Image")));
            this.ground.Location = new System.Drawing.Point(1, 339);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(437, 125);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 1;
            this.ground.TabStop = false;
            // 
            // pipeooperwala
            // 
            this.pipeooperwala.BackColor = System.Drawing.Color.Lime;
            this.pipeooperwala.Image = ((System.Drawing.Image)(resources.GetObject("pipeooperwala.Image")));
            this.pipeooperwala.Location = new System.Drawing.Point(275, -3);
            this.pipeooperwala.Name = "pipeooperwala";
            this.pipeooperwala.Size = new System.Drawing.Size(61, 111);
            this.pipeooperwala.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeooperwala.TabIndex = 2;
            this.pipeooperwala.TabStop = false;
            this.pipeooperwala.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pipeneechewala
            // 
            this.pipeneechewala.BackColor = System.Drawing.Color.Lime;
            this.pipeneechewala.Image = ((System.Drawing.Image)(resources.GetObject("pipeneechewala.Image")));
            this.pipeneechewala.Location = new System.Drawing.Point(352, 224);
            this.pipeneechewala.Name = "pipeneechewala";
            this.pipeneechewala.Size = new System.Drawing.Size(67, 116);
            this.pipeneechewala.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeneechewala.TabIndex = 3;
            this.pipeneechewala.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.gametimer);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(164, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Score";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(435, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pipeneechewala);
            this.Controls.Add(this.pipeooperwala);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.flappybird);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gemkeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gemkeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.flappybird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeooperwala)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeneechewala)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox flappybird;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox pipeooperwala;
        private System.Windows.Forms.PictureBox pipeneechewala;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}

