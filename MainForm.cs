using System;
using System.Windows.Forms;

namespace ImageConverterApp
{
    public partial class MainForm : Form
    {
        private string selectedFile = string.Empty;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            cmbFormat.Items.AddRange(new string[] { "png", "jpg", "bmp", "gif" });
            cmbFormat.SelectedIndex = 0;
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files (*.webp;*.png;*.jpg;*.jpeg;*.bmp;*.gif)|*.webp;*.png;*.jpg;*.jpeg;*.bmp;*.gif";
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    selectedFile = ofd.FileName;
                    rtbLog.AppendText($"Đã chọn file: {selectedFile}\n");
                }
            }
        }
    }
}
