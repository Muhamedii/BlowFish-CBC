namespace BlowFish_File_Encryptor__CBC_Mode_
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtKey = new System.Windows.Forms.TextBox();
            this.txtIV = new System.Windows.Forms.TextBox();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.txtOutputFilePath = new System.Windows.Forms.TextBox();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.btnChooseOutput = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.lblOutputFilePath = new System.Windows.Forms.Label();
            this.lblKey = new System.Windows.Forms.Label();
            this.lblIV = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // lblIV
            this.lblIV.AutoSize = true;
            this.lblIV.Location = new System.Drawing.Point(30, 55);
            this.lblIV.Size = new System.Drawing.Size(25, 15);
            this.lblIV.Text = "IV:";
            this.Controls.Add(this.lblIV);

            // lblKey
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(30, 15);
            this.lblKey.Size = new System.Drawing.Size(40, 15);
            this.lblKey.Text = "Key:";
            this.Controls.Add(this.lblKey);

            // lblFilePath
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Location = new System.Drawing.Point(30, 95);
            this.lblFilePath.Size = new System.Drawing.Size(75, 15);
            this.lblFilePath.Text = "File Path:";
            this.Controls.Add(this.lblFilePath);

            // lblOutputFilePath
            this.lblOutputFilePath.AutoSize = true;
            this.lblOutputFilePath.Location = new System.Drawing.Point(30, 135);
            this.lblOutputFilePath.Size = new System.Drawing.Size(120, 15);
            this.lblOutputFilePath.Text = "Output File Path:";
            this.Controls.Add(this.lblOutputFilePath);

            // txtKey
            this.txtKey.Location = new System.Drawing.Point(30, 30);
            this.txtKey.Size = new System.Drawing.Size(250, 25);
            this.Controls.Add(this.txtKey);

            // txtIV
            this.txtIV.Location = new System.Drawing.Point(30, 70);
            this.txtIV.Size = new System.Drawing.Size(250, 25);
            this.Controls.Add(this.txtIV);

            // txtFilePath
            this.txtFilePath.Location = new System.Drawing.Point(30, 110);
            this.txtFilePath.Size = new System.Drawing.Size(250, 25);
            this.Controls.Add(this.txtFilePath);

            // txtOutputFilePath
            this.txtOutputFilePath.Location = new System.Drawing.Point(30, 150);
            this.txtOutputFilePath.Size = new System.Drawing.Size(250, 25);
            this.Controls.Add(this.txtOutputFilePath);

            // btnSelectFile
            this.btnSelectFile.Location = new System.Drawing.Point(290, 110);
            this.btnSelectFile.Size = new System.Drawing.Size(80, 25);
            this.btnSelectFile.Text = "Select File";
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            this.Controls.Add(this.btnSelectFile);

            // btnChooseOutput
            this.btnChooseOutput.Location = new System.Drawing.Point(290, 150);
            this.btnChooseOutput.Size = new System.Drawing.Size(80, 25);
            this.btnChooseOutput.Text = "Output";
            this.btnChooseOutput.Click += new System.EventHandler(this.btnChooseOutput_Click);
            this.Controls.Add(this.btnChooseOutput);

            // btnEncrypt
            this.btnEncrypt.Location = new System.Drawing.Point(30, 200);
            this.btnEncrypt.Size = new System.Drawing.Size(120, 35);
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            this.Controls.Add(this.btnEncrypt);

            // btnDecrypt
            this.btnDecrypt.Location = new System.Drawing.Point(160, 200);
            this.btnDecrypt.Size = new System.Drawing.Size(120, 35);
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            this.Controls.Add(this.btnDecrypt);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.TextBox txtIV;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.TextBox txtOutputFilePath;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Button btnChooseOutput;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.Label lblIV;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.Label lblOutputFilePath;
    }
}