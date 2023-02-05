
namespace Happy_Valentine_s_Day
{
    partial class vDay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vDay));
            this.confessionLabel = new System.Windows.Forms.Label();
            this.questionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // confessionLabel
            // 
            this.confessionLabel.AutoSize = true;
            this.confessionLabel.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confessionLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.confessionLabel.Location = new System.Drawing.Point(95, 23);
            this.confessionLabel.Name = "confessionLabel";
            this.confessionLabel.Size = new System.Drawing.Size(122, 26);
            this.confessionLabel.TabIndex = 0;
            this.confessionLabel.Text = "I have a confession...";
            // 
            // questionButton
            // 
            this.questionButton.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionButton.ForeColor = System.Drawing.Color.Firebrick;
            this.questionButton.Location = new System.Drawing.Point(115, 52);
            this.questionButton.Name = "questionButton";
            this.questionButton.Size = new System.Drawing.Size(75, 23);
            this.questionButton.TabIndex = 1;
            this.questionButton.Text = "What is it?";
            this.questionButton.UseVisualStyleBackColor = true;
            this.questionButton.Click += new System.EventHandler(this.questionButton_Click);
            // 
            // vDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(295, 99);
            this.Controls.Add(this.questionButton);
            this.Controls.Add(this.confessionLabel);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightSalmon;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "vDay";
            this.Text = "My message to you...";
            this.TransparencyKey = System.Drawing.Color.White;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label confessionLabel;
        private System.Windows.Forms.Button questionButton;
    }
}

