namespace KinectTester
{
    partial class KinectTesterForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
      this.buttonStart = new System.Windows.Forms.Button();
      this.pictureBoxVideo = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVideo)).BeginInit();
      this.SuspendLayout();
      // 
      // buttonStart
      // 
      this.buttonStart.Location = new System.Drawing.Point(26, 12);
      this.buttonStart.Name = "buttonStart";
      this.buttonStart.Size = new System.Drawing.Size(173, 56);
      this.buttonStart.TabIndex = 0;
      this.buttonStart.Text = "Start";
      this.buttonStart.UseVisualStyleBackColor = true;
      this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
      // 
      // pictureBoxVideo
      // 
      this.pictureBoxVideo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.pictureBoxVideo.Location = new System.Drawing.Point(26, 73);
      this.pictureBoxVideo.Name = "pictureBoxVideo";
      this.pictureBoxVideo.Size = new System.Drawing.Size(640, 480);
      this.pictureBoxVideo.TabIndex = 1;
      this.pictureBoxVideo.TabStop = false;
      this.pictureBoxVideo.Click += new System.EventHandler(this.pictureBoxVideo_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(689, 573);
      this.Controls.Add(this.pictureBoxVideo);
      this.Controls.Add(this.buttonStart);
      this.Name = "Form1";
      this.Text = "Kinect Tester";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVideo)).EndInit();
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.PictureBox pictureBoxVideo;
    }
}

