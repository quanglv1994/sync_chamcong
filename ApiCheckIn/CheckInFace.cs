using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiCheckIn
{
    public class Data
    {
        public string dateCheckin;
        public string userCode;
        public string uuidHisCheckin;
      
        public Data(string dateCheckin, string userCode, string uuidHisCheckin)
        {
            this.dateCheckin = dateCheckin;
            this.userCode = userCode;
            this.uuidHisCheckin = uuidHisCheckin;
        }

    }

    public class Object
    {
        public int page;
        public int maxSize;
        public int totalElement;
        public int totalPages;
        public object sort;
        public object propertiesSort;
        public List<Data> data;
    }

    public class CheckInFace
    {
        public string message;
        public Object @object;
    }
}
