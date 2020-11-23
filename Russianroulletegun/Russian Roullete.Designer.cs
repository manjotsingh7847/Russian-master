namespace Russianroulletegun
{
    partial class Russian_Roullete
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
            this.gigimg = new System.Windows.Forms.PictureBox();
            this.loadbutt = new System.Windows.Forms.Button();
            this.Playagbutt = new System.Windows.Forms.Button();
            this.spinbutt = new System.Windows.Forms.Button();
            this.shootbutt = new System.Windows.Forms.Button();
            this.shootawaybutt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gigimg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome To Russian Roullete";
            // 
            // gigimg
            // 
            this.gigimg.Location = new System.Drawing.Point(93, 88);
            this.gigimg.Name = "gigimg";
            this.gigimg.Size = new System.Drawing.Size(591, 255);
            this.gigimg.TabIndex = 1;
            this.gigimg.TabStop = false;
            // 
            // loadbutt
            // 
            this.loadbutt.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadbutt.Location = new System.Drawing.Point(12, 368);
            this.loadbutt.Name = "loadbutt";
            this.loadbutt.Size = new System.Drawing.Size(120, 48);
            this.loadbutt.TabIndex = 2;
            this.loadbutt.Text = "load";
            this.loadbutt.UseVisualStyleBackColor = true;
            this.loadbutt.Click += new System.EventHandler(this.loadbutt_Click);
            // 
            // Playagbutt
            // 
            this.Playagbutt.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Playagbutt.Location = new System.Drawing.Point(628, 368);
            this.Playagbutt.Name = "Playagbutt";
            this.Playagbutt.Size = new System.Drawing.Size(145, 48);
            this.Playagbutt.TabIndex = 3;
            this.Playagbutt.Text = "Play Again";
            this.Playagbutt.UseVisualStyleBackColor = true;
            this.Playagbutt.Click += new System.EventHandler(this.Playagbutt_Click);
            // 
            // spinbutt
            // 
            this.spinbutt.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spinbutt.Location = new System.Drawing.Point(157, 368);
            this.spinbutt.Name = "spinbutt";
            this.spinbutt.Size = new System.Drawing.Size(120, 48);
            this.spinbutt.TabIndex = 4;
            this.spinbutt.Text = "spin";
            this.spinbutt.UseVisualStyleBackColor = true;
            this.spinbutt.Click += new System.EventHandler(this.spinbutt_Click);
            // 
            // shootbutt
            // 
            this.shootbutt.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shootbutt.Location = new System.Drawing.Point(294, 368);
            this.shootbutt.Name = "shootbutt";
            this.shootbutt.Size = new System.Drawing.Size(120, 48);
            this.shootbutt.TabIndex = 5;
            this.shootbutt.Text = "shoot";
            this.shootbutt.UseVisualStyleBackColor = true;
            this.shootbutt.Click += new System.EventHandler(this.shootbutt_Click);
            // 
            // shootawaybutt
            // 
            this.shootawaybutt.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shootawaybutt.Location = new System.Drawing.Point(439, 368);
            this.shootawaybutt.Name = "shootawaybutt";
            this.shootawaybutt.Size = new System.Drawing.Size(155, 48);
            this.shootawaybutt.TabIndex = 6;
            this.shootawaybutt.Text = "Shoot Away";
            this.shootawaybutt.UseVisualStyleBackColor = true;
            this.shootawaybutt.Click += new System.EventHandler(this.shootawaybutt_Click);
            // 
            // Russian_Roullete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.shootawaybutt);
            this.Controls.Add(this.shootbutt);
            this.Controls.Add(this.spinbutt);
            this.Controls.Add(this.Playagbutt);
            this.Controls.Add(this.loadbutt);
            this.Controls.Add(this.gigimg);
            this.Controls.Add(this.label1);
            this.Name = "Russian_Roullete";
            this.Text = "Russian_Roullete";
            ((System.ComponentModel.ISupportInitialize)(this.gigimg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox gigimg;
        private System.Windows.Forms.Button loadbutt;
        private System.Windows.Forms.Button Playagbutt;
        private System.Windows.Forms.Button spinbutt;
        private System.Windows.Forms.Button shootbutt;
        private System.Windows.Forms.Button shootawaybutt;
    }
}