using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Modes;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities.Encoders;
using System.Text;

namespace BlowFish_File_Encryptor__CBC_Mode_
{
    public partial class Form1 : Form
    {

        private string key;
        private string iv;
        private string inputFile;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "All Files|*.*";
                openFileDialog.Title = "Select a file";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    inputFile = openFileDialog.FileName;
                    txtFilePath.Text = inputFile;
                }
            }
        }

        private void btnChooseOutput_Click(object sender, EventArgs e)
        {
            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "All Files|*.*";
                saveFileDialog.Title = "Save the output file";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtOutputFilePath.Text = saveFileDialog.FileName;
                }
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            key = txtKey.Text;
            iv = GetIV(); // Generate IV

            if (inputFile != null && File.Exists(inputFile))
            {
                EncryptFile(inputFile, txtOutputFilePath.Text, key, iv);
                txtIV.Text = iv;
                MessageBox.Show("File encrypted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select a valid file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            key = txtKey.Text;
            iv = txtIV.Text; // IV provided by the user

            if (inputFile != null && File.Exists(inputFile))
            {
                DecryptFile(inputFile, txtOutputFilePath.Text, key, iv);
                MessageBox.Show("File decrypted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select a valid file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EncryptFile(string filePath, string outputFilePath, string key, string iv)
        {
            try
            {
                byte[] keyBytes = Encoding.UTF8.GetBytes(key);
                byte[] inputBytes = File.ReadAllBytes(filePath);

                //byte[] ivBytes = Encoding.UTF8.GetBytes(iv);
                byte[] ivBytes = Convert.FromBase64String(iv);


                BufferedBlockCipher cipher = new BufferedBlockCipher(new CbcBlockCipher(new BlowfishEngine()));
                KeyParameter keyParam = new KeyParameter(keyBytes);
                ParametersWithIV keyParamWithIV = new ParametersWithIV(keyParam, ivBytes);

                cipher.Init(true, keyParamWithIV);
                byte[] outputBytes = new byte[cipher.GetOutputSize(inputBytes.Length)];
                int length = cipher.ProcessBytes(inputBytes, 0, inputBytes.Length, outputBytes, 0);
                length += cipher.DoFinal(outputBytes, length);

                File.WriteAllBytes(outputFilePath, outputBytes);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Encryption failed! " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DecryptFile(string filePath, string outputFilePath, string key, string iv)
        {
            try
            {
                byte[] keyBytes = Encoding.UTF8.GetBytes(key);
                byte[] inputBytes = File.ReadAllBytes(filePath);

                byte[] ivBytes = Encoding.UTF8.GetBytes(iv);

                BufferedBlockCipher cipher = new BufferedBlockCipher(new CbcBlockCipher(new BlowfishEngine()));
                KeyParameter keyParam = new KeyParameter(keyBytes);
                ParametersWithIV keyParamWithIV = new ParametersWithIV(keyParam, ivBytes);

                cipher.Init(false, keyParamWithIV);
                byte[] outputBytes = new byte[cipher.GetOutputSize(inputBytes.Length)];
                int length = cipher.ProcessBytes(inputBytes, 0, inputBytes.Length, outputBytes, 0);
                length += cipher.DoFinal(outputBytes, length);

                File.WriteAllBytes(outputFilePath, outputBytes);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Decryption failed! " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetIV()
        {
            byte[] ivBytes = new byte[new BlowfishEngine().GetBlockSize()];
            new Random().NextBytes(ivBytes);
            //return Hex.ToHexString(ivBytes);
            return Convert.ToBase64String(ivBytes);
        }
    }
}
