using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
 
namespace CSharpChart.Model
{ 
    [Serializable]
    public class Serie
    { 
        public string Text { get; set; }
        public float Value { get; set; }
        public Color LineColor { get; set; } 
        public Image Image { get; set; } 
        public Serie(string text) : this(text, 0, Color.Black) { }
        public Serie(string text, Color color) : this(text, 0, color) { }
        public Serie(string text, float value) : this(text, value, Color.Black) { }
        public Serie(string text, float value, Color color)
        {
            LineColor = color;
            Value = value;
            Text = text;
        }
    }
}
