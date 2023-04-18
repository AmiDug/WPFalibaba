using System.Collections.Generic;

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

        public ViewModel()
        {
            data1 = Program.DBInfo("road", "steps");
            data2 = Program.DBInfo("road", "duration");
            data3 = Program.DBInfo("road", "speed");
            data4 = Program.DBInfo("road", "distance");
            data5 = Program.DBInfo("road", "calories");
            data6 = Program.DBInfo("forest", "steps");
            data7 = Program.DBInfo("forest", "duration");
            data8 = Program.DBInfo("forest", "speed");
            data9 = Program.DBInfo("forest", "distance");
            data10 = Program.DBInfo("forest", "calories");
        }
    }
}