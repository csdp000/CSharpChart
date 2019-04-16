using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using CSharpChart.Model;
using System.ComponentModel;

namespace CSharpChart.Bar
{
    public abstract class BarChart : Control
    {

        private Image _barTitleImage;
        private Size _barTitleImageSize;

        private float _chartWidth;
        private float _chartHeight;
        /// <summary>
        /// 실제 차트 영역 Width
        /// </summary>
        protected float ChartWidth
        {
            get
            {
                _chartWidth = Width - Padding.Right - Padding.Left;
                return _chartWidth;
            }
        }
        /// <summary>
        /// 실제 차트 영역 Height
        /// </summary>
        protected float ChartHeight
        {
            get
            {
                _chartHeight = Height - Padding.Bottom - Padding.Top;
                return _chartHeight;
            }
        }

        /// <summary>
        /// 차트 축 색상
        /// </summary>
        public Color AxisColor { get; set; } = Color.LightGray;

        /// <summary>
        /// 바의 가로 또는 세로 너비
        /// </summary>
        public float BarSize { get; set; } = 40;

        /// <summary>
        /// 바의 너비를 자동으로 조절
        /// </summary>
        public bool AutoBarSize { get; set; } = false;

        /// <summary>
        /// 바의 간격
        /// </summary>
        public float BarSpacing { get; set; } = 5;

        /// <summary>
        /// 바 간격을 자동으로 조절
        /// </summary>
        public bool AutoBarSpacing { get; set; } = false;
        
        /// <summary>
        /// Bar Value 폰트
        /// </summary>
        public Font BarValueFont { get; set; } = new Font(FontFamily.GenericSansSerif, 10);
         

        /// <summary>
        /// Bar Caption 폰트
        /// </summary>
        public Font BarCaptionFont { get; set; } = new Font(FontFamily.GenericSansSerif, 10);
        /// <summary>
        /// Bar Caption 색상
        /// </summary>
        public Color BarCaptionColor { get; set; } = Color.White;

        /// <summary>
        /// Bar Caption 표시 여부
        /// </summary>
        public bool BarCaptionVisible { get; set; } = true;

        /// <summary>
        /// Bar Value 표시 여부
        /// </summary>
        public bool BarValueVisible { get; set; } = true;

        /// <summary>
        /// 축 간격
        /// </summary>
        public float AxisLineSpacing { get; set; } = 5;
         
        /// <summary>
        /// 차트 타이틀 이미지
        /// </summary>
        public Image BarTitleImage
        {
            get
            {
                return _barTitleImage;
            }
            set
            {
                _barTitleImage = value; 
            }
        }

        /// <summary>
        /// 타이틀 이미지 사이즈
        /// </summary>
        public Size BarTitleImageSize
        {
            get
            {
                return _barTitleImageSize;
            }
            set
            {
                _barTitleImageSize = value;
                if (_barTitleImage != null)
                {  
                    if (Padding.Top < _barTitleImageSize.Height)
                        Padding = new Padding(Padding.Left, _barTitleImageSize.Height, Padding.Right, Padding.Bottom);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public SerieCollection Series { get; set; } = new SerieCollection();

        public BarChart()
        {
            DoubleBuffered = true;
            Padding = new Padding(200, 50, 50, 50);
        }
        protected abstract void DrawAxis(Graphics graphics, float maxValue, float interval);

        protected abstract void DrawSeries(Graphics graphics, SerieCollection series, float chartLength);

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            Invalidate();
        } 

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            //Draw Title 이미지 
            if (BarTitleImage != null)
            {
                e.Graphics.DrawImage(BarTitleImage, ((Width - BarTitleImageSize.Width) / 2), 0, BarTitleImageSize.Width, BarTitleImageSize.Height);
            }
        }
        /// <summary>
        /// 좌표계 원점을 Padding 속성 값 만큼 이동
        /// </summary>
        /// <param name="graphics">Graphics 객체</param>
        protected void TranslateTransform(Graphics graphics)
        {
            graphics.TranslateTransform(Padding.Left, Padding.Top);
        } 

    }
}
