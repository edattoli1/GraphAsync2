/*
 * Singleton class which hold all the data recorded from the DAQ inputs
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphAsync1
{
    public class ADstorage
    {
         // single instance of class which is created on declaration
        static readonly ADstorage _instance = new ADstorage();

        // returns the above single instance
        public static ADstorage Instance
        {
            get
            {
                return _instance;
            }
        }

        public Stack<double> inTimesQ { get; set; }
        public Stack<double> readMFC1 { get; set; }
        public Stack<double> readMFC2 { get; set; }

        public ADstorage()
        {
            inTimesQ = new Stack<double> ( new List<double> { } );
            readMFC1 = new Stack<double>(new List<double> { });
            readMFC2 = new Stack<double>(new List<double> {  });
        }
    }
 }