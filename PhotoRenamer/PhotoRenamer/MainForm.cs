using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoRenamer
{
    // im gonna use this http://www.languagetechfunda.com/csharp/create-image-gallery-windows-form-c
    // and https://stackoverflow.com/questions/68598/how-do-i-drag-and-drop-files-into-an-application
    public partial class MainForm : Form
    {
		private ExifManager ExifData;
		private Dictionary<int, string> ExifDataSource;
        private const int IMAGE_SIZE = 100;

        public MainForm()
        {
            InitializeComponent();
            rdoList.Appearance = Appearance.Button;
            rdoList.FlatStyle = FlatStyle.Flat;
            rdoList.BackColor = Color.White;
            rdoList.FlatAppearance.BorderSize = 0;
            rdoTile.Appearance = Appearance.Button;
            rdoTile.FlatStyle = FlatStyle.Flat;
            rdoTile.BackColor = Color.White;
            rdoTile.FlatAppearance.BorderSize = 0;
            rdoList.Checked = true;
			ExifData = new ExifManager();
			ExifDataSource = ExifData.CommonExif;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Multiselect = true,
                ValidateNames = true,
                Filter = "Image Files|*.jpg;*.jpeg;*.jpe;*.jfif;*.png"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                addImagesByFileName(openFileDialog.FileNames);
                invalidateImageListView();
            }
        }

        private void invalidateImageListView()
        {
            if (listViewImages.Items.Count > 0 && listViewImages.SelectedItems.Count > 0)
            {
                btnDelete.Enabled = true;
            }
            else
            {
                btnDelete.Enabled = false;
            }
        }

        private void listViewImages_DragDrop(object sender, DragEventArgs e)
        {
            string[] filenames = (string[])e.Data.GetData(DataFormats.FileDrop);
            addImagesByFileName(filenames);
        }

        private void addImagesByFileName(string[] filenames)
        {
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(IMAGE_SIZE, IMAGE_SIZE);
            int count = imageList.Images.Count;

            if (filenames.Count() > 0)
            {
                foreach (string filename in filenames)
                {
                    FileInfo fileinfo = new FileInfo(filename);
                    using (FileStream stream = new FileStream(fileinfo.FullName, FileMode.Open, FileAccess.Read))
                    {
                        if (!listViewImages.Items.ContainsKey(fileinfo.FullName))
                        {
							Image image = Image.FromStream(stream);
                            imageList.Images.Add(image);
							ExifData.AddImage(filename, image);
                        }
                    }

                    listViewImages.LargeImageList = imageList;
                    listViewImages.Items.Add(new ListViewItem
                    {
                        ImageIndex = count,
                        Name = fileinfo.FullName,
                        Text = fileinfo.Name,
                        Tag = fileinfo.FullName
                    });
                    count++;
                }
                invalidateImageListView();
				UpdateExifList();

			}
        }

        private void listViewImages_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewImages.SelectedItems)
            {
                listViewImages.Items.Remove(item);
            }
            invalidateImageListView();
        }

        private void listViewImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            invalidateImageListView();
        }

        private void rdoList_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoList.Checked)
            {
                rdoList.BackColor = Color.LightGray;
                rdoTile.BackColor = Color.White;
                listViewImages.View = View.List;
            }
            else
            {
                rdoList.BackColor = Color.White;
                rdoTile.BackColor = Color.LightGray;
                listViewImages.View = View.LargeIcon;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Button btnSender = (Button)sender;
            Point ptLowerLeft = new Point(0, btnSender.Height);
            ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
            ctmOpen.Show(ptLowerLeft);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this, "This application will make copies of photos and rename them based on their EXIF properties.", "About this application");
        }

		//https://stackoverflow.com/questions/11624298/how-to-use-openfiledialog-to-select-a-folder
		private void openFolderToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (var folderBrowserDialog = new FolderBrowserDialog())
			{
				DialogResult result = folderBrowserDialog.ShowDialog();

				if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
				{
					addImagesByFileName(Directory.GetFiles(folderBrowserDialog.SelectedPath));
				}
			}
		}

		private void UpdateExifList()
		{
			List<string> data = new List<string>();
			for (int i = 0; i < ExifDataSource.Count; i++)
			{
				data.Add(ExifDataSource.Values.ElementAt(i));
			}
			lstExifTags.DataSource = data;
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked)
			{
				ExifDataSource = ExifData.CommonExif;
			}
			else
			{
				ExifDataSource = ExifData.AllExif;
			}
			UpdateExifList();
		}

		private void button1_Click(object sender, EventArgs e)
		{

		}
	}
}
