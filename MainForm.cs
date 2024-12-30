using System;
using System.IO;
using System.Windows.Forms;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats;

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

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedFile))
            {
                MessageBox.Show("Vui lòng chọn file cần chuyển đổi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedFormat = cmbFormat.SelectedItem.ToString();
            string downloadsFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
            string outputDirectory = Path.Combine(downloadsFolder);

            try
            {
                using (Image image = Image.Load(selectedFile, out IImageFormat format))
                {
                    string outputFilePath = Path.Combine(outputDirectory, $"{Path.GetFileNameWithoutExtension(selectedFile)}.{selectedFormat}");

                    switch (selectedFormat)
                    {
                        case "png":
                            image.SaveAsPng(outputFilePath);
                            break;
                        case "jpg":
                            image.SaveAsJpeg(outputFilePath);
                            break;
                        case "bmp":
                            image.SaveAsBmp(outputFilePath);
                            break;
                        case "gif":
                            image.SaveAsGif(outputFilePath);
                            break;
                        default:
                            throw new NotSupportedException("Định dạng không được hỗ trợ.");
                    }

                    rtbLog.AppendText($"Chuyển đổi thành công: {outputFilePath}\n");
                }
            }
            catch (Exception ex)
            {
                rtbLog.AppendText($"Lỗi: {ex.Message}\n");
            }
        }
    }
}
