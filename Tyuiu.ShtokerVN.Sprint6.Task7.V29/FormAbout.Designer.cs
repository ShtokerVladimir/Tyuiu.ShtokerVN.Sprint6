
namespace Tyuiu.ShtokerVN.Sprint6.Task7.V29
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.pictureBoxPhotographZakatBydtoParyLetNazadBezTebya_SHVN = new System.Windows.Forms.PictureBox();
            this.textBoxInfo_SHVN = new System.Windows.Forms.TextBox();
            this.buttonCloseDone_SHVN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhotographZakatBydtoParyLetNazadBezTebya_SHVN)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPhotographZakatBydtoParyLetNazadBezTebya_SHVN
            // 
            this.pictureBoxPhotographZakatBydtoParyLetNazadBezTebya_SHVN.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPhotographZakatBydtoParyLetNazadBezTebya_SHVN.Image")));
            this.pictureBoxPhotographZakatBydtoParyLetNazadBezTebya_SHVN.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxPhotographZakatBydtoParyLetNazadBezTebya_SHVN.Name = "pictureBoxPhotographZakatBydtoParyLetNazadBezTebya_SHVN";
            this.pictureBoxPhotographZakatBydtoParyLetNazadBezTebya_SHVN.Size = new System.Drawing.Size(292, 187);
            this.pictureBoxPhotographZakatBydtoParyLetNazadBezTebya_SHVN.TabIndex = 1;
            this.pictureBoxPhotographZakatBydtoParyLetNazadBezTebya_SHVN.TabStop = false;
            // 
            // textBoxInfo_SHVN
            // 
            this.textBoxInfo_SHVN.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxInfo_SHVN.Location = new System.Drawing.Point(310, 12);
            this.textBoxInfo_SHVN.Multiline = true;
            this.textBoxInfo_SHVN.Name = "textBoxInfo_SHVN";
            this.textBoxInfo_SHVN.ReadOnly = true;
            this.textBoxInfo_SHVN.Size = new System.Drawing.Size(393, 158);
            this.textBoxInfo_SHVN.TabIndex = 2;
            this.textBoxInfo_SHVN.Text = resources.GetString("textBoxInfo_SHVN.Text");
            this.textBoxInfo_SHVN.TextChanged += new System.EventHandler(this.textBoxInfo_SHVN_TextChanged);
            // 
            // buttonCloseDone_SHVN
            // 
            this.buttonCloseDone_SHVN.Location = new System.Drawing.Point(620, 176);
            this.buttonCloseDone_SHVN.Name = "buttonCloseDone_SHVN";
            this.buttonCloseDone_SHVN.Size = new System.Drawing.Size(83, 23);
            this.buttonCloseDone_SHVN.TabIndex = 3;
            this.buttonCloseDone_SHVN.Text = "OK";
            this.buttonCloseDone_SHVN.UseVisualStyleBackColor = true;
            this.buttonCloseDone_SHVN.Click += new System.EventHandler(this.buttonCloseDone_SHVN_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 208);
            this.Controls.Add(this.buttonCloseDone_SHVN);
            this.Controls.Add(this.textBoxInfo_SHVN);
            this.Controls.Add(this.pictureBoxPhotographZakatBydtoParyLetNazadBezTebya_SHVN);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhotographZakatBydtoParyLetNazadBezTebya_SHVN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPhotographZakatBydtoParyLetNazadBezTebya_SHVN;
        private System.Windows.Forms.TextBox textBoxInfo_SHVN;
        private System.Windows.Forms.Button buttonCloseDone_SHVN;
    }
}