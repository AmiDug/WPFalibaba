using System.Collections.Generic;
namespace WPFalibaba
{
    public class ViewModel
    {
        public object Data = new object();
        //public List<object> Data;

        public ViewModel()
        {

            Data = Program.DBInfo();
            /*Data = new List<object>()
            {
                /*new Person { Name = "David", Height = 180 },
                new Person { Name = "Michael", Height = 170 },
                new Person { Name = "Steve", Height = 160 },
                new Person { Name = "Joel", Height = 182 }
            }; */
        }
    }
}