namespace BarkodluSatis
{
    partial class deneme
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
            this.tStandart1 = new BarkodluSatis.tStandart();
            this.lSandart1 = new BarkodluSatis.lSandart();
            this.tNumeric1 = new BarkodluSatis.tNumeric();
            this.bStandart1 = new BarkodluSatis.bStandart();
            this.SuspendLayout();
            // 
            // tStandart1
            // 
            this.tStandart1.BackColor = System.Drawing.Color.White;
            this.tStandart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tStandart1.Location = new System.Drawing.Point(340, 226);
            this.tStandart1.Name = "tStandart1";
            this.tStandart1.Size = new System.Drawing.Size(115, 30);
            this.tStandart1.TabIndex = 3;
            // 
            // lSandart1
            // 
            this.lSandart1.AutoSize = true;
            this.lSandart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lSandart1.ForeColor = System.Drawing.Color.DarkCyan;
            this.lSandart1.Location = new System.Drawing.Point(348, 128);
            this.lSandart1.Name = "lSandart1";
            this.lSandart1.Size = new System.Drawing.Size(96, 25);
            this.lSandart1.TabIndex = 1;
            this.lSandart1.Text = "lSandart1";
            // 
            // tNumeric1
            // 
            this.tNumeric1.BackColor = System.Drawing.Color.White;
            this.tNumeric1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tNumeric1.Location = new System.Drawing.Point(340, 169);
            this.tNumeric1.Name = "tNumeric1";
            this.tNumeric1.Size = new System.Drawing.Size(115, 30);
            this.tNumeric1.TabIndex = 0;
            this.tNumeric1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // bStandart1
            // 
            this.bStandart1.BackColor = System.Drawing.Color.Tomato;
            this.bStandart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bStandart1.Location = new System.Drawing.Point(480, 128);
            this.bStandart1.Margin = new System.Windows.Forms.Padding(0);
            this.bStandart1.Name = "bStandart1";
            this.bStandart1.Size = new System.Drawing.Size(127, 139);
            this.bStandart1.TabIndex = 0;
            this.bStandart1.Text = "bStandart1";
            this.bStandart1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bStandart1.UseVisualStyleBackColor = false;
            // 
            // deneme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bStandart1);
            this.Controls.Add(this.tStandart1);
            this.Controls.Add(this.lSandart1);
            this.Controls.Add(this.tNumeric1);
            this.Name = "deneme";
            this.Text = "deneme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private tNumeric tNumeric1;
        private lSandart lSandart1;
        private tStandart tStandart1;
        private bStandart bStandart1;
    }
}