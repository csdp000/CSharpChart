using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharpChart.Model;
using System.IO;

using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace CSharpChart.Sample
{
    public partial class BarChartForm : Form
    {
        private Random _ran = new Random();
        private bool _updown = true;
        private Dictionary<string, List<float>> dest;

        private float _bottomPanelHeight = 0;
        private float _rightPanelWidth = 0;

        private List<SerieImage> _serieImage = new List<SerieImage>();

        Dictionary<string, int> _destPoint = new Dictionary<string, int>();

        [Serializable]
        private  class ChartOption
        {
             
            public Color AxisColor { get; set; } = Color.LightGray; 
            public float BarSize { get; set; } = 40;  
            public float BarSpacing { get; set; } = 5;  
            public Font BarValueFont { get; set; } = new Font(FontFamily.GenericSansSerif, 10); 
            public Font BarCaptionFont { get; set; } = new Font(FontFamily.GenericSansSerif, 10); 
            public Color BarCaptionColor { get; set; } = Color.White; 
            public bool AutoBarCaptionColor { get; set; } = true; 
            public bool BarCaptionVisible { get; set; } = true; 
            public bool BarValueVisible { get; set; } = true; 
            public float AxisLineSpacing { get; set; } = 5;
             
            public Image BarTitleImage { get; set; }
            public Size BarTitleImageSize { get; set; }

            public int SerieImageSize { get; set; } = 50;
            public static ChartOption LoadChartOption(string fileName)
            {
                var formatter = new BinaryFormatter();
                ChartOption option; 
                try
                {
                    using (var readerFileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
                    { 
                        option = formatter.Deserialize(readerFileStream) as ChartOption;

                        readerFileStream.Close();
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }   
                return option;
            }
            public static void SaveChartOption(ChartOption option, string fileName)
            {
                var formatter = new BinaryFormatter();
                try
                {
                    using (var writerFileStream = new FileStream(fileName, FileMode.Create, FileAccess.Write))
                    {
                        formatter.Serialize(writerFileStream, option);
                    }
                }
                catch(Exception ex)
                {
                    throw ex;
                }
            }
        }

        private void LoadChartDataFromFile(string filename)
        { 
        }
        private void SaveChartOption(string fileName)
        {
            var option = new ChartOption()
            {
                AutoBarCaptionColor = horizontalBarChart1.AutoBarCaptionColor, 
                AxisColor = horizontalBarChart1.AxisColor,
                AxisLineSpacing = horizontalBarChart1.AxisLineSpacing,
                BarCaptionColor = horizontalBarChart1.BarCaptionColor,
                BarCaptionFont = horizontalBarChart1.BarCaptionFont,
                BarCaptionVisible = horizontalBarChart1.BarCaptionVisible,
                BarSize = horizontalBarChart1.BarSize,
                BarSpacing = horizontalBarChart1.BarSpacing,
                BarTitleImage = horizontalBarChart1.BarTitleImage,
                BarTitleImageSize = horizontalBarChart1.BarTitleImageSize,
                BarValueFont = horizontalBarChart1.BarValueFont,
                BarValueVisible = horizontalBarChart1.BarValueVisible,
                SerieImageSize = (int)chartLeftPaddingNumeric.Value, 
                
            }; 
            ChartOption.SaveChartOption(option, fileName);
        }
        private void LoadChartOption(string fileName)
        { 
            var option = ChartOption.LoadChartOption(fileName);

            autoBarCaptionColorCheckBox.Checked = option.AutoBarCaptionColor; 
            axisColorLabel.ForeColor = option.AxisColor;
            axisSpacingNumeric.Value = (long)option.AxisLineSpacing;
            barCaptionColorLabel.ForeColor = option.BarCaptionColor;

            barCaptionFontLabel.Font = option.BarCaptionFont;
            var font = barCaptionFontLabel.Font;
            barCaptionFontLabel.Text = $"{font.Name}, {font.Size}px";

            barCaptionVisibleCheckBox.Checked = option.BarCaptionVisible;
            barSizeNumeric.Value = (long)option.BarSize;
            barTitleImagePictureBox.Image = option.BarTitleImage;
            if (barTitleImagePictureBox.Image != null)
            {
                barTitleImageWidthNumeric.Maximum = barTitleImagePictureBox.Image.Size.Width;
                barTitleImageHeightNumeric.Maximum = barTitleImagePictureBox.Image.Size.Height;
            }

            barTitleImageWidthNumeric.Value = option.BarTitleImageSize.Width;
            barTitleImageHeightNumeric.Value = option.BarTitleImageSize.Height;

            chartLeftPaddingNumeric.Value = option.SerieImageSize;

            barValueFontLabel.Font = option.BarValueFont;
            font = barValueFontLabel.Font;
            barValueFontLabel.Text = $"{font.Name}, {font.Size}px";

            barValueVisibleCheckBox.Checked = option.BarValueVisible;
        } 


        private void OptionValue_Changed(object sender, EventArgs e)
        {
            horizontalBarChart1.AutoBarCaptionColor = autoBarCaptionColorCheckBox.Checked; 
            horizontalBarChart1.BarSpacing = (float)barSpacingNumeric.Value;
            horizontalBarChart1.AxisColor = axisColorLabel.ForeColor;
            horizontalBarChart1.AxisLineSpacing = (float)axisSpacingNumeric.Value;
            horizontalBarChart1.BarCaptionColor = barCaptionColorLabel.ForeColor;
            horizontalBarChart1.BarCaptionFont = barCaptionFontLabel.Font;
            horizontalBarChart1.BarCaptionVisible = barCaptionVisibleCheckBox.Checked;
            horizontalBarChart1.BarSize = (float)barSizeNumeric.Value;
            horizontalBarChart1.BarTitleImage = barTitleImagePictureBox.Image;
            horizontalBarChart1.BarTitleImageSize = new Size((int)barTitleImageWidthNumeric.Value, (int)barTitleImageHeightNumeric.Value);
            if (barTitleImagePictureBox.Image != null)
            {
                barTitleImageWidthNumeric.Maximum = barTitleImagePictureBox.Image.Size.Width;
                barTitleImageHeightNumeric.Maximum = barTitleImagePictureBox.Image.Size.Height;
            } 
            horizontalBarChart1.BarValueFont = barValueFontLabel.Font;
            horizontalBarChart1.BarValueVisible = barValueVisibleCheckBox.Checked;

            horizontalBarChart1.Padding = 
                new Padding((int)chartLeftPaddingNumeric.Value,
                horizontalBarChart1.Padding.Top,
                horizontalBarChart1.Padding.Right,
                horizontalBarChart1.Padding.Bottom);


            foreach (var item in _serieImage)
            {
                var targetSerie = horizontalBarChart1.Series[item.SerieName];
                if (targetSerie != null)
                {
                    targetSerie.Image = item.Image;
                }
            }

            horizontalBarChart1.Invalidate(); 
        }
        private void ChartSeriesRandomColor(SerieCollection series)
        {

            var colors = new List<Color>()
            {
                Color.LightBlue, Color.LightCoral, Color.Cyan, Color.LightGreen, Color.Lime, Color.LimeGreen, Color.Yellow, Color.Orange, 
            }; 
            foreach(var serie in series)
            {
                var color = colors[_ran.Next(0, colors.Count)];
                serie.LineColor = GenerateRandomColor(color);
                
            }
        }
        public Color GenerateRandomColor(Color mix)
        { 
            int red = _ran.Next(256);
            int green = _ran.Next(256);
            int blue = _ran.Next(256);

            // mix the color
            if (mix != null)
            {
                red = (red + mix.R) / 2;
                green = (green + mix.G) / 2;
                blue = (blue + mix.B) / 2;
            }
             
            return Color.FromArgb(red, green, blue);
        }

        public void LoadChartDataFromText(string text)
        {

            using (var reader = new StringReader(text))
            {
                string line = reader.ReadLine();
                var cols = line.Split('\t');
                dest = new Dictionary<string, List<float>>();

                var rows = reader.ReadLine().Split('\t').Skip(1).ToArray();
                for (int i = 0; i < cols.Length; i++)
                {
                    string colName = cols[i];
                     

                    horizontalBarChart1.Series.Add(new Serie(colName, float.Parse(rows[i]), Color.LightBlue));
                    horizontalBarChart1.Invalidate();
                    dest.Add(colName, new List<float>());
                    _destPoint.Add(colName, 0);
                } 
                while ((line = reader.ReadLine()) != null)
                { 
                    var row = line.Split('\t').Skip(1).ToArray();
                    for (int i = 0; i < row.Length; i++)
                    {
                        dest[cols[i]].Add(float.Parse(row[i]));
                    }
                }
            }
            ChartSeriesRandomColor(horizontalBarChart1.Series);
        }
        public BarChartForm()
        {
            InitializeComponent();
            if (File.Exists($"{Application.StartupPath}\\이미지.dat"))
            { 
                _serieImage = SerieImage.LoadSerieImages( $"{Application.StartupPath}\\이미지.dat");
            }
            string fileString = Properties.Resources.SampleData;
            LoadChartDataFromText(fileString);
        }
        int seq = 0;
        private void Button1_Click(object sender, EventArgs e)
        {
            
            string text = ((char)('a'+seq++)).ToString();
            var colors = new List<Color>()
            {
                Color.LightBlue, Color.LightCoral, Color.Cyan, Color.LightGreen, Color.Lime, Color.LimeGreen,Color.Yellow,Color.Orange
            };

            var color = colors[_ran.Next(0, colors.Count)];

            horizontalBarChart1.Series.Add(new Serie(text, _ran.Next(1, 10), color));
            horizontalBarChart1.Invalidate();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            _updown = true;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            _updown = false;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }
         
        private void Timer1_Tick(object sender, EventArgs e)
        {
            horizontalBarChart1.Series.Sort();
            float interval = 333; 

            foreach (KeyValuePair<string, List<float>> kvp in dest)
            {
                float val = (kvp.Value[_destPoint[kvp.Key] + 1] - kvp.Value[_destPoint[kvp.Key]]) / interval;
                
                
                horizontalBarChart1.Series[kvp.Key].Value += val;
                horizontalBarChart1.Invalidate();
                float newValue = horizontalBarChart1.Series[kvp.Key].Value;
                if (val > 0 && newValue > kvp.Value[_destPoint[kvp.Key]+1 ])
                {
                    _destPoint[kvp.Key]++;
                }
                else if (val < 0 && newValue < kvp.Value[_destPoint[kvp.Key]+1])
                {
                    _destPoint[kvp.Key]++;
                }
                if (_destPoint[kvp.Key]+1 >= kvp.Value.Count) { timer1.Enabled = false; }
            } 
        }
        int selectIndex = 0;

        private void Timer2_Tick(object sender, EventArgs e)
        {

            horizontalBarChart1.Series.Sort();
            horizontalBarChart1.Series[selectIndex].Value += ((float)_ran.NextDouble() / 50) * (_updown ? 1 : -1);
            horizontalBarChart1.Invalidate();
        }
        private void Button5_Click(object sender, EventArgs e)
        { 
            horizontalBarChart1.Series["a"].Value += 1;     
        } 
        private void Button6_Click(object sender, EventArgs e)
        {

            selectIndex++;
            if (horizontalBarChart1.Series.Count <= selectIndex) 
                selectIndex = 0; 
        }

        private void 하단숨김ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float panelHeight = tableLayoutPanel1.RowStyles[1].Height; 

            tableLayoutPanel1.RowStyles[1].SizeType = SizeType.Absolute;

            _bottomPanelHeight = panelHeight > 0 ? panelHeight : _bottomPanelHeight;

            if (panelHeight > 0) 
                tableLayoutPanel1.RowStyles[1].Height = 0; 
            else 
                tableLayoutPanel1.RowStyles[1].Height = _bottomPanelHeight; 
        }

        private void 우측숨김ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            float panelWidth = tableLayoutPanel2.ColumnStyles[1].Width;

            tableLayoutPanel2.ColumnStyles[1].SizeType = SizeType.Absolute;

            _rightPanelWidth = panelWidth > 0 ? panelWidth : _rightPanelWidth;

            if (panelWidth > 0)
                tableLayoutPanel2.ColumnStyles[1].Width = 0;
            else
                tableLayoutPanel2.ColumnStyles[1].Width = _rightPanelWidth;
        }

        private void 실행ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 중지ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Button7_Click(object sender, EventArgs e)
        {
            ChartSeriesRandomColor(horizontalBarChart1.Series);
            horizontalBarChart1.Invalidate();
        }

        private void fontLabel_Click(object sender, EventArgs e)
        {
            var targetLabel = sender as Label;

            var dialogResult = fontDialog.ShowDialog();

            if(dialogResult == DialogResult.OK)
            {
                Font font = fontDialog.Font;
                targetLabel.Font = font;
                targetLabel.Text = $"{font.Name}, {font.Size}px";
            }
        }

        private void colorLabel_Click(object sender, EventArgs e)
        { 
            var targetLabel = sender as Label;

            var dialogResult = colorDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                Color color = colorDialog.Color; 
                targetLabel.ForeColor = color;
            }
        }

        private void LoadOptionButton_Click(object sender, EventArgs e)
        {
            var fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = Application.StartupPath;
            fileDialog.Filter = "차트 옵션 파일 (*.dat)|*.dat";

            var result = fileDialog.ShowDialog();
            if (result == DialogResult.OK)
                LoadChartOption(fileDialog.FileName);
        }

        private void SaveOptionButton_Click(object sender, EventArgs e)
        {

            var fileDialog = new SaveFileDialog();
            fileDialog.InitialDirectory = Application.StartupPath;
            fileDialog.Filter = "차트 옵션 파일 (*.dat)|*.dat";
            fileDialog.AddExtension = true;
            fileDialog.DefaultExt = ".dat";
            var result = fileDialog.ShowDialog();
            if (result == DialogResult.OK)
                SaveChartOption(fileDialog.FileName);
        }

        private void BarTitleImagePictureBox_DoubleClick(object sender, EventArgs e)
        {

            var fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = Application.StartupPath;
            var result = fileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                barTitleImagePictureBox.Image = Image.FromFile(fileDialog.FileName); 
            }
        }

        private void 항목이미지설정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var serieImageForm = new SerieImageForm(_serieImage);
            serieImageForm.Show();
        } 
    }   
}
