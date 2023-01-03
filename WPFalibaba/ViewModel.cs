using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System;
using System.Data.Entity;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WPFalibaba
{
    public class ViewModel
    {
        public List<Data> data { get; set; }
        public Dictionary<String, Double> values = Program.DBInfo();
        public ViewModel()
        {

            //Data = Program.DBInfo();
            data = new List<Data>()
            {
            };
            foreach (KeyValuePair<String, Double> dic in values)
            {
                data.Add(new Data { Name = dic.Key, Value = dic.Value });
            }
        }
    }
}