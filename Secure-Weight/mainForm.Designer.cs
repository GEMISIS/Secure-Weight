namespace Secure_Weight
{
    partial class mainForm
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
            this.connStatLbl = new System.Windows.Forms.Label();
            this.weightLbl = new System.Windows.Forms.Label();
            this.weightValLbl = new System.Windows.Forms.Label();
            this.personLbl = new System.Windows.Forms.Label();
            this.personValLbl = new System.Windows.Forms.Label();
            this.weightImage = new System.Windows.Forms.PictureBox();
            this.topLeftVal = new System.Windows.Forms.Label();
            this.topRightVal = new System.Windows.Forms.Label();
            this.bottomLeftVal = new System.Windows.Forms.Label();
            this.bottomRightVal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.weightImage)).BeginInit();
            this.SuspendLayout();
            // 
            // connStatLbl
            // 
            this.connStatLbl.AutoSize = true;
            this.connStatLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connStatLbl.Location = new System.Drawing.Point(12, 9);
            this.connStatLbl.Name = "connStatLbl";
            this.connStatLbl.Size = new System.Drawing.Size(157, 26);
            this.connStatLbl.TabIndex = 0;
            this.connStatLbl.Text = "Not Connected";
            // 
            // weightLbl
            // 
            this.weightLbl.AutoSize = true;
            this.weightLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightLbl.Location = new System.Drawing.Point(12, 35);
            this.weightLbl.Name = "weightLbl";
            this.weightLbl.Size = new System.Drawing.Size(86, 26);
            this.weightLbl.TabIndex = 1;
            this.weightLbl.Text = "Weight:";
            // 
            // weightValLbl
            // 
            this.weightValLbl.AutoSize = true;
            this.weightValLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightValLbl.Location = new System.Drawing.Point(104, 35);
            this.weightValLbl.Name = "weightValLbl";
            this.weightValLbl.Size = new System.Drawing.Size(53, 26);
            this.weightValLbl.TabIndex = 2;
            this.weightValLbl.Text = "0 kg";
            // 
            // personLbl
            // 
            this.personLbl.AutoSize = true;
            this.personLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personLbl.Location = new System.Drawing.Point(12, 61);
            this.personLbl.Name = "personLbl";
            this.personLbl.Size = new System.Drawing.Size(87, 26);
            this.personLbl.TabIndex = 3;
            this.personLbl.Text = "Person:";
            // 
            // personValLbl
            // 
            this.personValLbl.AutoSize = true;
            this.personValLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personValLbl.Location = new System.Drawing.Point(105, 61);
            this.personValLbl.Name = "personValLbl";
            this.personValLbl.Size = new System.Drawing.Size(64, 26);
            this.personValLbl.TabIndex = 4;
            this.personValLbl.Text = "None";
            // 
            // weightImage
            // 
            this.weightImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.weightImage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.weightImage.Location = new System.Drawing.Point(17, 90);
            this.weightImage.Name = "weightImage";
            this.weightImage.Size = new System.Drawing.Size(595, 339);
            this.weightImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.weightImage.TabIndex = 5;
            this.weightImage.TabStop = false;
            // 
            // topLeftVal
            // 
            this.topLeftVal.AutoSize = true;
            this.topLeftVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLeftVal.Location = new System.Drawing.Point(466, 9);
            this.topLeftVal.Name = "topLeftVal";
            this.topLeftVal.Size = new System.Drawing.Size(71, 26);
            this.topLeftVal.TabIndex = 6;
            this.topLeftVal.Text = "0.0 kg";
            // 
            // topRightVal
            // 
            this.topRightVal.AutoSize = true;
            this.topRightVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topRightVal.Location = new System.Drawing.Point(542, 9);
            this.topRightVal.Name = "topRightVal";
            this.topRightVal.Size = new System.Drawing.Size(71, 26);
            this.topRightVal.TabIndex = 7;
            this.topRightVal.Text = "0.0 kg";
            // 
            // bottomLeftVal
            // 
            this.bottomLeftVal.AutoSize = true;
            this.bottomLeftVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottomLeftVal.Location = new System.Drawing.Point(466, 61);
            this.bottomLeftVal.Name = "bottomLeftVal";
            this.bottomLeftVal.Size = new System.Drawing.Size(71, 26);
            this.bottomLeftVal.TabIndex = 8;
            this.bottomLeftVal.Text = "0.0 kg";
            // 
            // bottomRightVal
            // 
            this.bottomRightVal.AutoSize = true;
            this.bottomRightVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottomRightVal.Location = new System.Drawing.Point(542, 61);
            this.bottomRightVal.Name = "bottomRightVal";
            this.bottomRightVal.Size = new System.Drawing.Size(71, 26);
            this.bottomRightVal.TabIndex = 9;
            this.bottomRightVal.Text = "0.0 kg";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.bottomRightVal);
            this.Controls.Add(this.bottomLeftVal);
            this.Controls.Add(this.topRightVal);
            this.Controls.Add(this.topLeftVal);
            this.Controls.Add(this.weightImage);
            this.Controls.Add(this.personValLbl);
            this.Controls.Add(this.personLbl);
            this.Controls.Add(this.weightValLbl);
            this.Controls.Add(this.weightLbl);
            this.Controls.Add(this.connStatLbl);
            this.Name = "mainForm";
            this.Text = "Secure Weight";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.weightImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label connStatLbl;
        private System.Windows.Forms.Label weightLbl;
        private System.Windows.Forms.Label weightValLbl;
        private System.Windows.Forms.Label personLbl;
        private System.Windows.Forms.Label personValLbl;
        private System.Windows.Forms.PictureBox weightImage;
        private System.Windows.Forms.Label topLeftVal;
        private System.Windows.Forms.Label topRightVal;
        private System.Windows.Forms.Label bottomLeftVal;
        private System.Windows.Forms.Label bottomRightVal;
    }
}

