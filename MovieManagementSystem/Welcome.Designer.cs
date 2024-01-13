namespace MovieManagementSystem
{
    partial class Welcome
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
            this.buttonAddMovie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MistyRose;
            this.label1.Location = new System.Drawing.Point(152, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(529, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Zee Studios";
            // 
            // buttonAddMovie
            // 
            this.buttonAddMovie.BackColor = System.Drawing.Color.MistyRose;
            this.buttonAddMovie.FlatAppearance.BorderColor = System.Drawing.Color.PeachPuff;
            this.buttonAddMovie.FlatAppearance.BorderSize = 2;
            this.buttonAddMovie.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SaddleBrown;
            this.buttonAddMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddMovie.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddMovie.ForeColor = System.Drawing.Color.Black;
            this.buttonAddMovie.Location = new System.Drawing.Point(336, 162);
            this.buttonAddMovie.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddMovie.Name = "buttonAddMovie";
            this.buttonAddMovie.Size = new System.Drawing.Size(140, 52);
            this.buttonAddMovie.TabIndex = 1;
            this.buttonAddMovie.Text = "Add Movie";
            this.buttonAddMovie.UseVisualStyleBackColor = false;
            this.buttonAddMovie.Click += new System.EventHandler(this.buttonAddMovie_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MovieManagementSystem.Properties.Resources.felix_mooneeram_evlkOfkQ5rE_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(817, 462);
            this.Controls.Add(this.buttonAddMovie);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Welcome";
            this.Text = "Movie Management System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddMovie;
    }
}

