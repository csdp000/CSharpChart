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


namespace CSharpChart.Sample
{
    public partial class Form1 : Form
    {
        private Random _ran = new Random();
        private bool _updown = true;
        private Dictionary<string, List<float>> dest;

        Dictionary<string, int> 구간 = new Dictionary<string, int>();

        public Form1()
        {
            InitializeComponent();

            string text = Properties.Resources.SampleData;
            using (var reader = new StringReader(text))
            {
                string line = reader.ReadLine();
                var cols = line.Split(',');
                dest = new Dictionary<string, List<float>>();

                var rows = reader.ReadLine().Split(',').Skip(1).ToArray();
                for (int i=0; i<cols.Length; i++)
                {
                    string colName = cols[i];

                    var colors = new List<Color>()
                    {
                        Color.LightBlue, Color.LightCoral, Color.Cyan, Color.LightGreen, Color.Lime, Color.LimeGreen,Color.Yellow,Color.Orange
                    }; 
                    var color = colors[_ran.Next(0, colors.Count)];
                     
                    
                    horizontalBarChart1.Series.Add(new Serie(colName, float.Parse(rows[i]), color));
                    horizontalBarChart1.Invalidate();
                    dest.Add(colName, new List<float>());
                    구간.Add(colName, 0);
                }

                while (( line = reader.ReadLine()) != null )
                {
                    MessageBox.Show(line);
                    var row = line.Split(',').Skip(1).ToArray();
                    for(int i=0;i<row.Length; i++)
                    {
                        dest[cols[i]].Add(float.Parse(row[i]));
                    }
                }
            }
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
                float val = (kvp.Value[구간[kvp.Key] + 1] - kvp.Value[구간[kvp.Key]]) / interval;
                
                
                horizontalBarChart1.Series[kvp.Key].Value += val;
                horizontalBarChart1.Invalidate();
                float newValue = horizontalBarChart1.Series[kvp.Key].Value;
                if (val > 0 && newValue > kvp.Value[구간[kvp.Key]+1 ])
                {
                    구간[kvp.Key]++;
                }
                else if (val < 0 && newValue < kvp.Value[구간[kvp.Key]+1])
                {
                    구간[kvp.Key]++;
                }
                if (구간[kvp.Key]+1 >= kvp.Value.Count) { timer1.Enabled = false; }
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
    }
    public class DestPoint
    {
        public float DestValue { get; set; }
        public float AddValue { get; set; }
    }
}
