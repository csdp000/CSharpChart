using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace CSharpChart.Sample
{ 
    public partial class SerieImageForm : Form
    { 
        private List<SerieImage> _serieImages;

        private ImageList _imageList;

        private SerieImage _modifyItem;
        private ListViewItem _modifyListViewItem;
        private bool _isModifying = false;

        private void PreviewPictureBox_DoubleClick(object sender, EventArgs e)
        {
            if(_isModifying)
            { 
                var fileDialog = new OpenFileDialog();
                fileDialog.InitialDirectory = Application.StartupPath;
                var result = fileDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    var image = Image.FromFile(fileDialog.FileName);
                    previewPictureBox.BackgroundImage = image; 
                }
            }
        }
        private void SerieImageListView_DoubleClick(object sender, EventArgs e)
        {
            int selectIndex = serieImageListView.SelectedIndices[0];  
            if (_isModifying)
            {
                DialogResult result = MessageBox.Show("현재 수정중인 항목이 있습니다. 저장하고 진행하겠습니까?", "수정", MessageBoxButtons.YesNo);

                if(result == DialogResult.Yes)
                { 
                    SaveCurrentModifyingItem(); 
                } 
            }
            _isModifying = true;
            _modifyItem = (SerieImage)serieImageListView.Items[selectIndex].Tag;
            _modifyListViewItem = serieImageListView.Items[selectIndex];

            ModifyControlEnabled(true); 
            ViewSerieImage(_modifyItem);
        }      
        private void RefreshImageList()
        { 
            _imageList.Images.Clear();
            foreach (var serieImage in _serieImages)
            {
                if (serieImage.Image != null)
                    _imageList.Images.Add(serieImage.SerieName, serieImage.Image);
            }
        }
        private void SaveCurrentModifyingItem()
        {
            _modifyItem.SerieName = serieTitleTextBox.Text;
            _modifyItem.Description = serieImageDescriptionTextBox.Text;
            _modifyItem.Image = previewPictureBox.BackgroundImage;

            _modifyListViewItem.ImageKey = _modifyItem.SerieName;
            _modifyListViewItem.SubItems[1].Text = _modifyItem.SerieName;

            RefreshImageList();
             
        }
        private void 항목저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_isModifying)
            {
                SaveCurrentModifyingItem();
                ModifyControlEnabled(false);
                _isModifying = false;
                SerieImage.SaveSerieImages(_serieImages, $"{Application.StartupPath}\\이미지.dat");
            }
        }
        private void ModifyControlEnabled(bool enable)
        { 
            if (!enable)
            {
                serieImageDescriptionTextBox.Text = "";
                serieTitleTextBox.Text = "";
                previewPictureBox.BackgroundImage = Properties.Resources.imageimporttip;
                _modifyItem = null;
                _modifyListViewItem = null;
            }
            tableLayoutPanel2.Enabled = enable;
        }
        private void ViewSerieImage(SerieImage serieImage)
        {
            previewPictureBox.BackgroundImage = serieImage.Image;
            serieTitleTextBox.Text = serieImage.SerieName;
            serieImageDescriptionTextBox.Text = serieImage.Description; 
        }
        public SerieImageForm(List<SerieImage> serieImages)
        {
            InitializeComponent();

            ModifyControlEnabled(false);

            _imageList = new ImageList();
            _imageList.ImageSize = new Size(200, 80);
            serieImageListView.LargeImageList = _imageList;
            serieImageListView.SmallImageList = _imageList;

            _serieImages = serieImages; 
            foreach(var serieImage in serieImages)
            {
                AddLVIFromSerieImage(serieImage);
            }
        }
        private void AddLVIFromSerieImage(SerieImage serieImage)
        {
            var lvi = new ListViewItem();
            lvi.ImageKey = serieImage.SerieName;
            lvi.SubItems.Add(serieImage.SerieName);
            lvi.Tag = serieImage; 

            serieImageListView.Items.Add(lvi);

            RefreshImageList();

        }
        private void RemoveLVI(int index)
        {
            if (index == -1)
                throw new ArgumentException(" 값은 -1보다 커야 합니다.", nameof(index));

            var targetSerieTitle = serieImageListView.Items[index].SubItems[1].Text;
            var targetSerieImage = _serieImages.Find((x) => x.SerieName == targetSerieTitle);
            
            if(targetSerieImage != null)
            {
                _serieImages.Remove(targetSerieImage);
                serieImageListView.Items.RemoveAt(index);
                RefreshImageList();
            }
        }
        private void 추가ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var serieImage = new SerieImage
            {
                Description = "사진 설명",
                SerieName = "항목 이름",
                Image = null,
            };

            _serieImages.Add(serieImage);

            AddLVIFromSerieImage(serieImage);

        }

        private void 삭제ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int selectIndex = serieImageListView.SelectedIndices[0];
            if (selectIndex > -1 && selectIndex < serieImageListView.Items.Count) 
            {
                RemoveLVI(selectIndex);
            }
        }
    }
}
