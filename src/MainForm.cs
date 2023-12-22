using ANSIConverter.Service;
using System.IO;
using System.Text;

namespace ANSIConverter
{
    public partial class MainForm : Form
    {
        private readonly IEncodingService _encodingService;

        public MainForm(IEncodingService encodingService)
        {
            InitializeComponent();
            _encodingService = encodingService;
        }

        private void openFileToANSIConverterDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                Application.DoEvents();
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Text files | *.csv";
                dialog.Multiselect = false;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string path = dialog.FileName;
                    var filePathFinal = _encodingService.ChangeEncodeToANSI(path, fileConvertProgressBar);
                    MessageBox.Show($"Arquivo convertido com sucesso! \n {filePathFinal}");
                    fileConvertProgressBar.Value = 0;
                    finalFilePathLinkLabel.Text = filePathFinal;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Deu erro! \n {ex.Message}");
            }
        }

        private void selecionarArquivo_Click(object sender, EventArgs e)
        {
            openFileToANSIConverterDialog_FileOk(sender, null);
        }

    }
}