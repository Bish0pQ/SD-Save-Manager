namespace SD_Save_Manager
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.picHeader = new System.Windows.Forms.PictureBox();
            this.lstSaveGames = new System.Windows.Forms.ListBox();
            this.btnLoadSave = new System.Windows.Forms.Button();
            this.btnCopyCurrent = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRename = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // picHeader
            // 
            this.picHeader.Image = ((System.Drawing.Image)(resources.GetObject("picHeader.Image")));
            this.picHeader.Location = new System.Drawing.Point(1, -1);
            this.picHeader.Name = "picHeader";
            this.picHeader.Size = new System.Drawing.Size(492, 135);
            this.picHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHeader.TabIndex = 0;
            this.picHeader.TabStop = false;
            // 
            // lstSaveGames
            // 
            this.lstSaveGames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lstSaveGames.ForeColor = System.Drawing.Color.White;
            this.lstSaveGames.FormattingEnabled = true;
            this.lstSaveGames.ItemHeight = 16;
            this.lstSaveGames.Location = new System.Drawing.Point(-1, 134);
            this.lstSaveGames.Name = "lstSaveGames";
            this.lstSaveGames.Size = new System.Drawing.Size(391, 148);
            this.lstSaveGames.TabIndex = 1;
            // 
            // btnLoadSave
            // 
            this.btnLoadSave.Location = new System.Drawing.Point(396, 140);
            this.btnLoadSave.Name = "btnLoadSave";
            this.btnLoadSave.Size = new System.Drawing.Size(84, 23);
            this.btnLoadSave.TabIndex = 2;
            this.btnLoadSave.Text = "Load";
            this.btnLoadSave.UseVisualStyleBackColor = true;
            // 
            // btnCopyCurrent
            // 
            this.btnCopyCurrent.Location = new System.Drawing.Point(396, 169);
            this.btnCopyCurrent.Name = "btnCopyCurrent";
            this.btnCopyCurrent.Size = new System.Drawing.Size(84, 42);
            this.btnCopyCurrent.TabIndex = 3;
            this.btnCopyCurrent.Text = "Copy Current";
            this.btnCopyCurrent.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(396, 217);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 25);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnRename
            // 
            this.btnRename.Location = new System.Drawing.Point(396, 248);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(84, 25);
            this.btnRename.TabIndex = 5;
            this.btnRename.Text = "Rename";
            this.btnRename.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(492, 282);
            this.Controls.Add(this.btnRename);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCopyCurrent);
            this.Controls.Add(this.btnLoadSave);
            this.Controls.Add(this.lstSaveGames);
            this.Controls.Add(this.picHeader);
            this.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Opacity = 0.9D;
            this.Text = "Stranded Deep Save Manager";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picHeader;
        private System.Windows.Forms.ListBox lstSaveGames;
        private System.Windows.Forms.Button btnLoadSave;
        private System.Windows.Forms.Button btnCopyCurrent;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRename;
    }
}

