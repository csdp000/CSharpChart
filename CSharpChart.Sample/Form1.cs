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

namespace CSharpChart.Sample
{
    public partial class Form1 : Form
    {
        private Random _ran = new Random();
        private bool _updown = true;

        public Form1()
        { 
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string text = ((char)_ran.Next('a', 'z')).ToString();
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
            int index = _ran.Next(0, horizontalBarChart1.Series.Count);
            horizontalBarChart1.Series[index].Value += ((float)_ran.NextDouble()/30) *(_updown?1:-1);
            horizontalBarChart1.Invalidate();

        }
    }
}
