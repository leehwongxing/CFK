namespace GTranslator.Views
{
    partial class API_Translator
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
            this.TX_Source = new System.Windows.Forms.RichTextBox();
            this.TX_Result = new System.Windows.Forms.RichTextBox();
            this.CBO_SourceLang = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CBO_TransLang = new System.Windows.Forms.ComboBox();
            this.Btn_SignIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TX_Source
            // 
            this.TX_Source.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TX_Source.Font = new System.Drawing.Font("Segoe UI Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TX_Source.Location = new System.Drawing.Point(19, 98);
            this.TX_Source.Margin = new System.Windows.Forms.Padding(10);
            this.TX_Source.MaxLength = 2000;
            this.TX_Source.Name = "TX_Source";
            this.TX_Source.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.TX_Source.Size = new System.Drawing.Size(747, 200);
            this.TX_Source.TabIndex = 0;
            this.TX_Source.Text = "";
            this.TX_Source.TextChanged += new System.EventHandler(this.TX_Source_TextChanged);
            // 
            // TX_Result
            // 
            this.TX_Result.BackColor = System.Drawing.SystemColors.Window;
            this.TX_Result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TX_Result.Font = new System.Drawing.Font("Segoe UI Semilight", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TX_Result.Location = new System.Drawing.Point(19, 387);
            this.TX_Result.Margin = new System.Windows.Forms.Padding(10);
            this.TX_Result.Name = "TX_Result";
            this.TX_Result.ReadOnly = true;
            this.TX_Result.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.TX_Result.Size = new System.Drawing.Size(747, 200);
            this.TX_Result.TabIndex = 1;
            this.TX_Result.TabStop = false;
            this.TX_Result.Text = "";
            // 
            // CBO_SourceLang
            // 
            this.CBO_SourceLang.DropDownHeight = 207;
            this.CBO_SourceLang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBO_SourceLang.FormattingEnabled = true;
            this.CBO_SourceLang.IntegralHeight = false;
            this.CBO_SourceLang.ItemHeight = 20;
            this.CBO_SourceLang.Location = new System.Drawing.Point(132, 49);
            this.CBO_SourceLang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CBO_SourceLang.Name = "CBO_SourceLang";
            this.CBO_SourceLang.Size = new System.Drawing.Size(207, 28);
            this.CBO_SourceLang.TabIndex = 2;
            this.CBO_SourceLang.SelectedIndexChanged += new System.EventHandler(this.CBO_SourceLang_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Translate From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 342);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Translate Into";
            // 
            // CBO_TransLang
            // 
            this.CBO_TransLang.DropDownHeight = 207;
            this.CBO_TransLang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBO_TransLang.FormattingEnabled = true;
            this.CBO_TransLang.IntegralHeight = false;
            this.CBO_TransLang.ItemHeight = 20;
            this.CBO_TransLang.Location = new System.Drawing.Point(132, 339);
            this.CBO_TransLang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CBO_TransLang.Name = "CBO_TransLang";
            this.CBO_TransLang.Size = new System.Drawing.Size(207, 28);
            this.CBO_TransLang.TabIndex = 4;
            this.CBO_TransLang.SelectedIndexChanged += new System.EventHandler(this.CBO_TransLang_SelectedIndexChanged);
            // 
            // Btn_SignIn
            // 
            this.Btn_SignIn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SignIn.Location = new System.Drawing.Point(540, 49);
            this.Btn_SignIn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_SignIn.Name = "Btn_SignIn";
            this.Btn_SignIn.Size = new System.Drawing.Size(207, 28);
            this.Btn_SignIn.TabIndex = 6;
            this.Btn_SignIn.Text = "Google Account..";
            this.Btn_SignIn.UseVisualStyleBackColor = true;
            this.Btn_SignIn.Click += new System.EventHandler(this.Btn_SignIn_Click);
            // 
            // API_Translator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 609);
            this.Controls.Add(this.Btn_SignIn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CBO_TransLang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBO_SourceLang);
            this.Controls.Add(this.TX_Result);
            this.Controls.Add(this.TX_Source);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "API_Translator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Google MLTranslator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox TX_Source;
        private System.Windows.Forms.RichTextBox TX_Result;
        private System.Windows.Forms.ComboBox CBO_SourceLang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBO_TransLang;
        private System.Windows.Forms.Button Btn_SignIn;
    }
}
