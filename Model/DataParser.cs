using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class DataParser
    {
        public delegate void valueChanged(string path, double value);
        public event valueChanged valueChange;

        private Dictionary<string, double> symboTable;
        private Dictionary<int, string> dataIndexer;

        public DataParser()
        {
            dataIndexer = new Dictionary<int, string>();
            symboTable = new Dictionary<string, double>();
        }
        public string this[int key]
        {
            get
            {
                if (dataIndexer.ContainsKey(key))
                    return dataIndexer[key];
                // in case of unknown intex, return null. 
                return null;
            }
            set { dataIndexer[key] = value; }
        }
        public double this[string key]
        {
            get
            {
                if (symboTable.ContainsKey(key))
                    return symboTable[key];
                return 0;
            }
            set
            {
                valueChange?.Invoke(key, value);
                symboTable[key] = value;
            }
        }
        public void ParseCommand(string massege)
        {
            string[] tokens = massege.Split(',');
            int i = 0;
            foreach (string token in tokens)
            {
                string str = dataIndexer[i];
                if (str != null)
                {
                    try
                    {
                        double value = Convert.ToDouble(token);
                        symboTable[str] = value;
                    }
                    catch (FormatException) { throw new Exception("invalid value : " + str); }

                }

            }
        }

    }
}

