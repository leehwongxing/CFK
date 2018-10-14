namespace GTranslator.Views
{
    partial class API_SignIn
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
            this.PB_Avatar = new System.Windows.Forms.PictureBox();
            this.TX_FullName = new System.Windows.Forms.TextBox();
            this.TX_Residence = new System.Windows.Forms.TextBox();
            this.BT_SignOff = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // PB_Avatar
            // 
            this.PB_Avatar.Location = new System.Drawing.Point(95, 95);
            this.PB_Avatar.Name = "PB_Avatar";
            this.PB_Avatar.Size = new System.Drawing.Size(150, 150);
            this.PB_Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Avatar.TabIndex = 0;
            this.PB_Avatar.TabStop = false;
            // 
            // TX_FullName
            // 
            this.TX_FullName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TX_FullName.Location = new System.Drawing.Point(12, 270);
            this.TX_FullName.Name = "TX_FullName";
            this.TX_FullName.ReadOnly = true;
            this.TX_FullName.ShortcutsEnabled = false;
            this.TX_FullName.Size = new System.Drawing.Size(308, 16);
            this.TX_FullName.TabIndex = 1;
            this.TX_FullName.TabStop = false;
            this.TX_FullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TX_FullName.TextChanged += new System.EventHandler(this.TX_FullName_TextChanged);
            // 
            // TX_Residence
            // 
            this.TX_Residence.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TX_Residence.Location = new System.Drawing.Point(12, 303);
            this.TX_Residence.Name = "TX_Residence";
            this.TX_Residence.ReadOnly = true;
            this.TX_Residence.ShortcutsEnabled = false;
            this.TX_Residence.Size = new System.Drawing.Size(308, 16);
            this.TX_Residence.TabIndex = 2;
            this.TX_Residence.TabStop = false;
            this.TX_Residence.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BT_SignOff
            // 
            this.BT_SignOff.Location = new System.Drawing.Point(95, 353);
            this.BT_SignOff.Name = "BT_SignOff";
            this.BT_SignOff.Size = new System.Drawing.Size(150, 45);
            this.BT_SignOff.TabIndex = 3;
            this.BT_SignOff.Text = "Đăng xuất";
            this.BT_SignOff.UseVisualStyleBackColor = true;
            // 
            // API_SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 503);
            this.Controls.Add(this.BT_SignOff);
            this.Controls.Add(this.TX_Residence);
            this.Controls.Add(this.TX_FullName);
            this.Controls.Add(this.PB_Avatar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "API_SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "You\'re signed in as..";
            this.Shown += new System.EventHandler(this.API_SignIn_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_Avatar;
        private System.Windows.Forms.TextBox TX_FullName;
        private System.Windows.Forms.TextBox TX_Residence;
        private System.Windows.Forms.Button BT_SignOff;
    }
}
