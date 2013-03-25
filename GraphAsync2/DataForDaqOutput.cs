/*
 * Singleton class which hold all the data required for the controlling the DAQ outputs
 * 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphAsync1
{
    public sealed class DataForDaqOutput
    {
        // single instance of class which is created on declaration
        static readonly DataForDaqOutput _instance = new DataForDaqOutput();

        // returns the above single instance
        public static DataForDaqOutput Instance
        {
            get
            {
                return _instance;
            }
        }

        public List<double> outTimesL { get; set; }
        public List<double> outVoltsL { get; set; }

        public DataForDaqOutput()
        {
            outTimesL = new List<double> { 0, 0.1, 1 };
            outVoltsL = new List<double> { 0, 2.5, 0 };
        }
    }
}
