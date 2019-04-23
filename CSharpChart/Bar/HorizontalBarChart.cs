using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSharpChart.Model;

namespace CSharpChart.Bar
{
    public class HorizontalBarChart : BarChart
    {

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            var graphics = e.Graphics;
             
            TranslateTransform(graphics);
            
            if (Series.Count > 0)
            {
                var chartMaxValue = Series.Max((x) => x.Value);

                DrawAxis(graphics, chartMaxValue, AxisLineSpacing);
                DrawSeries(graphics, Series, ChartWidth);
            }
        }

        protected override void DrawSeries(Graphics graphics, SerieCollection series, float chartLength)
        {
            //항목에서 최대값 구하기
            var chartMaxValue = Series.Max((x) => x.Value); 

            float barCoordY = 0;

            
            foreach (Serie serie in Series)
            {
                float barWidth = chartLength / (chartMaxValue / serie.Value);
                Brush barBrush = new SolidBrush(serie.LineColor);

                graphics.FillRectangle(barBrush, 0, barCoordY, barWidth, BarSize);

                //to-do: 이미지 가로 사이즈 Padding 값에 따라 조정되게끔 수정해야함

                //Serie 이미지 처리 로직
                if (serie.Image != null)
                {
                    const int imagePadding = 10;

                    int imageX = -Padding.Left+ imagePadding;
                    float imageWidth = Padding.Left- imagePadding;
                    float imageHeight = BarSpacing + BarSize;

                    var imageRect = new Rectangle(
                        new Point(imageX, (int)barCoordY),
                        new Size((int)imageWidth, (int)imageHeight)
                        );

                    graphics.DrawImage(serie.Image, imageRect);
                }
                if (BarValueVisible)
                {
                    string valueString = serie.Value.ToString("0.0");
                    graphics.DrawString(valueString, BarValueFont, new Pen(ForeColor, 5).Brush, barWidth + 10, barCoordY);
                } 
                if(BarCaptionVisible)
                { 
                    // 쓰여질 text 사이즈 
                    Size textSize = TextRenderer.MeasureText(serie.Text, BarCaptionFont);

                    //자동 생삭 설정
                    Color captionColor = Color.Black;
                    if (AutoBarCaptionColor)
                        captionColor = ControlPaint.Dark(serie.LineColor, (float)0.05);
                    else
                        captionColor = BarCaptionColor;

                    // Bar 너비랑 텍스트 사이즈 비교할때 보정값? 오차범위 같은 값
                    const int compare = 5;
                     
                    // Bar 너비보다 텍스트 사이즈가 클경우 잘라야함.
                    int captionWidth = (int)((barWidth - compare < textSize.Width) ? textSize.Width - (textSize.Width - compare - barWidth) : textSize.Width);
                    int captionHeight = (int)((BarSize - compare < textSize.Height) ? textSize.Height - (textSize.Height - compare - BarSize) : textSize.Height);

                    graphics.DrawString(serie.Text  , BarCaptionFont, new Pen(captionColor).Brush,
                        new RectangleF(0, barCoordY, captionWidth , captionHeight));
                } 

                barCoordY += BarSpacing + BarSize;
            }
        }
        protected override void DrawAxis(Graphics graphics, float maxValue, float interval)
        { 
            float lineCount = maxValue / interval;
            float axisX = 0;
             
            for (int i = 0; i <= maxValue / interval; i++)
            {

                var axisString = $"{(interval * i).ToString()}"; 

                graphics.DrawLine(new Pen(AxisColor, 2), axisX, 0, axisX, ChartHeight);

                graphics.DrawString(axisString, Font, new Pen(ForeColor, 3).Brush, axisX, ChartHeight-10);

                axisX += ChartWidth / lineCount;
            }
        }

    }
}
