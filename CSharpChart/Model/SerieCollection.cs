using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpChart.Model
{ 
    [Serializable]
    public class SerieCollection : ICollection<Serie>
    { 

        List<Serie> _series = new List<Serie>();

        public int Count => _series.Count;

        public bool IsReadOnly => ((ICollection<Serie>)_series).IsReadOnly;

        public Serie this[int index]
        {
            get { return _series[index]; }
        }
        public Serie this[string name]
        {
            get { return _series.Find((x) => x.Text == name); }
        }
        public void Add(Serie serie)
        {
            _series.Add(serie);
        }
        public void Clear()
        {
            _series.Clear();
        }
        public bool Contains(Serie serie)
        {
            return _series.Contains(serie);
        }

        public void CopyTo(Serie[] array, int arrayIndex)
        {
            _series.CopyTo(array, arrayIndex);
        }

        public bool Remove(Serie item)
        {
            return _series.Remove(item);
        }

        public IEnumerator<Serie> GetEnumerator()
        {
            return _series.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _series.GetEnumerator();
        }
        public void Sort()
        {
            _series.Sort((a, b) => b.Value.CompareTo(a.Value));
        }
        public SerieCollection()
        {
        }
    }
}
