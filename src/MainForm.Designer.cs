namespace ANSIConverter
{
    partial class MainForm
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
            selecionarArquivoButton = new Button();
            label1 = new Label();
            fileConvertProgressBar = new ProgressBar();
            label2 = new Label();
            finalFilePathLinkLabel = new LinkLabel();
            SuspendLayout();
            // 
            // selecionarArquivoButton
            // 
            selecionarArquivoButton.Location = new Point(420, 38);
            selecionarArquivoButton.Name = "selecionarArquivoButton";
            selecionarArquivoButton.RightToLeft = RightToLeft.No;
            selecionarArquivoButton.Size = new Size(75, 23);
            selecionarArquivoButton.TabIndex = 0;
            selecionarArquivoButton.Text = "Selecionar";
            selecionarArquivoButton.UseVisualStyleBackColor = true;
            selecionarArquivoButton.Click += selecionarArquivo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 46);
            label1.Name = "label1";
            label1.Size = new Size(252, 15);
            label1.TabIndex = 1;
            label1.Text = "Selecione o arquivo a ser convertido para ANSI";
            // 
            // fileConvertProgressBar
            // 
            fileConvertProgressBar.Location = new Point(27, 84);
            fileConvertProgressBar.Name = "fileConvertProgressBar";
            fileConvertProgressBar.Size = new Size(468, 23);
            fileConvertProgressBar.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 130);
            label2.Name = "label2";
            label2.Size = new Size(194, 15);
            label2.TabIndex = 3;
            label2.Text = "Endereço do arquivo transformado:";
            // 
            // finalFilePathLinkLabel
            // 
            finalFilePathLinkLabel.AutoSize = true;
            finalFilePathLinkLabel.Location = new Point(31, 157);
            finalFilePathLinkLabel.Name = "finalFilePathLinkLabel";
            finalFilePathLinkLabel.Size = new Size(0, 15);
            finalFilePathLinkLabel.TabIndex = 4;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 189);
            Controls.Add(finalFilePathLinkLabel);
            Controls.Add(label2);
            Controls.Add(fileConvertProgressBar);
            Controls.Add(label1);
            Controls.Add(selecionarArquivoButton);
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ANSI Converter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button selecionarArquivoButton;
        private Label label1;
        private ProgressBar fileConvertProgressBar;
        private Label label2;
        private LinkLabel finalFilePathLinkLabel;
    }
}