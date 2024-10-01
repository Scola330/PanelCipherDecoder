namespace Decrypt
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Encryptor = new GroupBox();
            EncryptionResult = new GroupBox();
            Eresult = new Label();
            EncryptionSettings = new GroupBox();
            EncryptButton = new Button();
            label5 = new Label();
            label4 = new Label();
            EShiftX = new NumericUpDown();
            ERotY = new NumericUpDown();
            label1 = new Label();
            EText = new TextBox();
            Decryptor = new GroupBox();
            DecryptionResult = new GroupBox();
            Dresult = new Label();
            DecryptionSettings = new GroupBox();
            DecryptButton = new Button();
            label9 = new Label();
            label8 = new Label();
            DShiftX = new NumericUpDown();
            DRotY = new NumericUpDown();
            label2 = new Label();
            Dtext = new TextBox();
            Encryptor.SuspendLayout();
            EncryptionResult.SuspendLayout();
            EncryptionSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EShiftX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ERotY).BeginInit();
            Decryptor.SuspendLayout();
            DecryptionResult.SuspendLayout();
            DecryptionSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DShiftX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DRotY).BeginInit();
            SuspendLayout();
            // 
            // Encryptor
            // 
            Encryptor.Controls.Add(EncryptionResult);
            Encryptor.Controls.Add(EncryptionSettings);
            Encryptor.Location = new Point(12, 12);
            Encryptor.Name = "Encryptor";
            Encryptor.Size = new Size(1324, 426);
            Encryptor.TabIndex = 0;
            Encryptor.TabStop = false;
            Encryptor.Text = "Encryptor :";
            // 
            // EncryptionResult
            // 
            EncryptionResult.Controls.Add(Eresult);
            EncryptionResult.Location = new Point(450, 25);
            EncryptionResult.Name = "EncryptionResult";
            EncryptionResult.Size = new Size(868, 396);
            EncryptionResult.TabIndex = 1;
            EncryptionResult.TabStop = false;
            EncryptionResult.Text = "Encryption result :";
            // 
            // Eresult
            // 
            Eresult.AutoSize = true;
            Eresult.Location = new Point(6, 28);
            Eresult.Name = "Eresult";
            Eresult.Size = new Size(16, 15);
            Eresult.TabIndex = 0;
            Eresult.Text = "...";
            Eresult.Click += CopyEncrypted;
            // 
            // EncryptionSettings
            // 
            EncryptionSettings.Controls.Add(EncryptButton);
            EncryptionSettings.Controls.Add(label5);
            EncryptionSettings.Controls.Add(label4);
            EncryptionSettings.Controls.Add(EShiftX);
            EncryptionSettings.Controls.Add(ERotY);
            EncryptionSettings.Controls.Add(label1);
            EncryptionSettings.Controls.Add(EText);
            EncryptionSettings.Location = new Point(6, 22);
            EncryptionSettings.Name = "EncryptionSettings";
            EncryptionSettings.Size = new Size(438, 399);
            EncryptionSettings.TabIndex = 0;
            EncryptionSettings.TabStop = false;
            EncryptionSettings.Text = "Encryption settings :";
            // 
            // EncryptButton
            // 
            EncryptButton.Location = new Point(6, 348);
            EncryptButton.Name = "EncryptButton";
            EncryptButton.Size = new Size(426, 45);
            EncryptButton.TabIndex = 10;
            EncryptButton.Text = "Encrypt";
            EncryptButton.UseVisualStyleBackColor = true;
            EncryptButton.Click += EncryptText;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 221);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 8;
            label5.Text = "shift x:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 161);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 7;
            label4.Text = "Panel shift : ";
            // 
            // EShiftX
            // 
            EShiftX.Location = new Point(6, 239);
            EShiftX.Maximum = new decimal(new int[] { 2, 0, 0, 0 });
            EShiftX.Name = "EShiftX";
            EShiftX.Size = new Size(120, 23);
            EShiftX.TabIndex = 4;
            // 
            // ERotY
            // 
            ERotY.Location = new Point(6, 179);
            ERotY.Maximum = new decimal(new int[] { 2, 0, 0, 0 });
            ERotY.Name = "ERotY";
            ERotY.Size = new Size(120, 23);
            ERotY.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 31);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 1;
            label1.Text = "Text :";
            // 
            // EText
            // 
            EText.Location = new Point(6, 49);
            EText.Name = "EText";
            EText.Size = new Size(426, 23);
            EText.TabIndex = 0;
            // 
            // Decryptor
            // 
            Decryptor.Controls.Add(DecryptionResult);
            Decryptor.Controls.Add(DecryptionSettings);
            Decryptor.Location = new Point(12, 444);
            Decryptor.Name = "Decryptor";
            Decryptor.Size = new Size(1324, 433);
            Decryptor.TabIndex = 1;
            Decryptor.TabStop = false;
            Decryptor.Text = "Decryptor :";
            Decryptor.Enter += Decryptor_Enter;
            // 
            // DecryptionResult
            // 
            DecryptionResult.Controls.Add(Dresult);
            DecryptionResult.Location = new Point(453, 28);
            DecryptionResult.Name = "DecryptionResult";
            DecryptionResult.Size = new Size(865, 399);
            DecryptionResult.TabIndex = 2;
            DecryptionResult.TabStop = false;
            DecryptionResult.Text = "Decryption result :";
            // 
            // Dresult
            // 
            Dresult.AutoSize = true;
            Dresult.Location = new Point(6, 31);
            Dresult.Name = "Dresult";
            Dresult.Size = new Size(16, 15);
            Dresult.TabIndex = 1;
            Dresult.Text = "...";
            Dresult.Click += CopyDecrypted;
            // 
            // DecryptionSettings
            // 
            DecryptionSettings.Controls.Add(DecryptButton);
            DecryptionSettings.Controls.Add(label9);
            DecryptionSettings.Controls.Add(label8);
            DecryptionSettings.Controls.Add(DShiftX);
            DecryptionSettings.Controls.Add(DRotY);
            DecryptionSettings.Controls.Add(label2);
            DecryptionSettings.Controls.Add(Dtext);
            DecryptionSettings.Location = new Point(6, 22);
            DecryptionSettings.Name = "DecryptionSettings";
            DecryptionSettings.Size = new Size(441, 405);
            DecryptionSettings.TabIndex = 1;
            DecryptionSettings.TabStop = false;
            DecryptionSettings.Text = "Decryption settings :";
            // 
            // DecryptButton
            // 
            DecryptButton.Location = new Point(0, 354);
            DecryptButton.Name = "DecryptButton";
            DecryptButton.Size = new Size(435, 45);
            DecryptButton.TabIndex = 11;
            DecryptButton.Text = "Decrypt";
            DecryptButton.UseVisualStyleBackColor = true;
            DecryptButton.Click += DecryptText;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(5, 227);
            label9.Name = "label9";
            label9.Size = new Size(42, 15);
            label9.TabIndex = 10;
            label9.Text = "shift x:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 167);
            label8.Name = "label8";
            label8.Size = new Size(71, 15);
            label8.TabIndex = 10;
            label8.Text = "Panel shift : ";
            // 
            // DShiftX
            // 
            DShiftX.Location = new Point(6, 245);
            DShiftX.Maximum = new decimal(new int[] { 2, 0, 0, 0 });
            DShiftX.Name = "DShiftX";
            DShiftX.Size = new Size(120, 23);
            DShiftX.TabIndex = 8;
            // 
            // DRotY
            // 
            DRotY.Location = new Point(6, 185);
            DRotY.Maximum = new decimal(new int[] { 2, 0, 0, 0 });
            DRotY.Name = "DRotY";
            DRotY.Size = new Size(120, 23);
            DRotY.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 37);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 2;
            label2.Text = "Cipher :";
            // 
            // Dtext
            // 
            Dtext.Location = new Point(6, 55);
            Dtext.Name = "Dtext";
            Dtext.Size = new Size(429, 23);
            Dtext.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 886);
            Controls.Add(Decryptor);
            Controls.Add(Encryptor);
            Name = "Form1";
            Text = "PanelCipher Decoder";
            Encryptor.ResumeLayout(false);
            EncryptionResult.ResumeLayout(false);
            EncryptionResult.PerformLayout();
            EncryptionSettings.ResumeLayout(false);
            EncryptionSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EShiftX).EndInit();
            ((System.ComponentModel.ISupportInitialize)ERotY).EndInit();
            Decryptor.ResumeLayout(false);
            DecryptionResult.ResumeLayout(false);
            DecryptionResult.PerformLayout();
            DecryptionSettings.ResumeLayout(false);
            DecryptionSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DShiftX).EndInit();
            ((System.ComponentModel.ISupportInitialize)DRotY).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox Encryptor;
        private GroupBox EncryptionSettings;
        private GroupBox Decryptor;
        private GroupBox DecryptionSettings;
        private GroupBox EncryptionResult;
        private Label label1;
        private TextBox EText;
        private GroupBox DecryptionResult;
        private Label label2;
        private TextBox Dtext;
        private Label label5;
        private Label label4;
        private NumericUpDown EShiftX;
        private NumericUpDown ERotY;
        private NumericUpDown DShiftX;
        private NumericUpDown DRotY;
        private Label label9;
        private Label label8;
        private Button EncryptButton;
        private Button DecryptButton;
        private Label Eresult;
        private Label Dresult;
    }
}
