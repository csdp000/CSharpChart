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

            //Draw Title 이미지 
            if (BarTitleImage != null)
            {
                graphics.DrawImage(BarTitleImage, ((Width - BarTitleImageSize.Width ) / 2) , 0, BarTitleImageSize.Width, BarTitleImageSize.Height);
            }
            TranslateTransform(graphics);
            if (Series.Count > 0)
            {
                var chartMaxValue = Series.Max((x) => x.Value);

                DrawAxis(graphics, chartMaxValue, AxisLineSpacing);
                DrawSeries(graphics, Series, ChartWidth);
            }
        }

        protected override void DrawSeries(Graphics graphics, IList<Serie> series, float chartLength)
        {

            var chartMaxValue = Series.Max((x) => x.Value);
             

            float barCoordY = 0;

            foreach (Serie serie in Series)
            {
                float barWidth = chartLength / (chartMaxValue / serie.Value);
                Brush barBrush = new SolidBrush(serie.LineColor);

                graphics.FillRectangle(barBrush, 0, barCoordY, barWidth, BarSize);

                if (BarValueVisible)
                {
                    string valueString = serie.Value.ToString("0.0");
                    graphics.DrawString(valueString, BarValueFont, new Pen(ForeColor, 5).Brush, barWidth + 10, barCoordY);
                } 
                if(BarCaptionVisible)
                { 
                    //to-do 미구현

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

                var axisString = $"{(interval * i).ToString()}"; // to-do: Format 지정 할 수 있도록 하면 좋을듯 

                graphics.DrawLine(new Pen(AxisColor, 2), axisX, 0, axisX, ChartHeight);

                graphics.DrawString(axisString, Font, new Pen(ForeColor, 3).Brush, axisX, ChartHeight-10);

                axisX += ChartWidth / lineCount;
            }
        }

    }
}
