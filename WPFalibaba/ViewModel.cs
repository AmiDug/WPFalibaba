using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System;
using System.Data.Entity;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace WPFalibaba
{
    public class ViewModel
    {
        public List<Data> data1 { get; set; }
        public List<Data> data2 { get; set; }
        public List<Data> data3 { get; set; }
        public List<Data> data4 { get; set; }
        public List<Data> data5 { get; set; }
        public List<Data> data6 { get; set; }
        public List<Data> data7 { get; set; }
        public List<Data> data8 { get; set; }
        public List<Data> data9 { get; set; }
        public List<Data> data10 { get; set; }

        //public List<Data> values1 = Program.DBInfo("road", "steps");
        /*public List<Data> values2 = Program.DBInfo("road", "duration");
        public List<Data> values3 = Program.DBInfo("road", "speed");
        public List<Data> values4 = Program.DBInfo("road", "distance");
        public List<Data> values5 = Program.DBInfo("road", "calories");
        public List<Data> values6 = Program.DBInfo("forest", "steps");
        public List<Data> values7 = Program.DBInfo("forest", "duration");
        public List<Data> values8 = Program.DBInfo("forest", "speed");
        public List<Data> values9 = Program.DBInfo("forest", "distance");
        public List<Data> values10 = Program.DBInfo("forest", "calories");*/
        public ViewModel()
        {

            //Data = Program.DBInfo();
            data1 = Program.DBInfo("road", "steps");
            data2 = Program.DBInfo("road", "duration");
            /*data3 = Program.DBInfo("road", "speed");
            data4 = Program.DBInfo("road", "distance");
            data5 = Program.DBInfo("road", "calories");
            data6 = Program.DBInfo("forest", "steps");
            data7 = Program.DBInfo("forest", "duration");
            data8 = Program.DBInfo("forest", "speed");
            data9 = Program.DBInfo("forest", "distance");
            data10 = Program.DBInfo("forest", "calories");*/
            //data = values1;
            /*data2 = values2;
            data3 = values3;
            data4 = values4;
            data5 = values5;
            data6 = values6;
            data7 = values7;
            data8 = values8;
            data9 = values9;
            data10 = values10;*/
        }
    }
}