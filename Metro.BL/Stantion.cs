using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metro.BL
{
    public enum Branch : int
    {
        Red = 119,
        Blue = 217,
        Green = 314
    };

    public class Stantion
    {
        public int _StantionId { get; }
        public string _StantionName { get; }
        public Branch _Branch { get; }
        public Stantion _TransferToStantion { get; set; }
        public double _LeftProportion { get; } //left coordinate in percent
        public double _TopProportion { get; } // top coordinate in percent


        public Stantion Next { get; set; }
        public Stantion Previous { get; set; }

        public Stantion(int id, string stantionName, Branch branch, Stantion transferStantion, double left_prop, double top_prop)
        {
            _StantionId = id;
            _StantionName = stantionName;
            _Branch = branch;
            _TransferToStantion = transferStantion;
            Next = null;
            Previous = null;
            _LeftProportion = left_prop;
            _TopProportion = top_prop;
        }
    }
}
