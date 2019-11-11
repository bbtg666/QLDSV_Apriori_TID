using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_V1
{
    public class Header
    {
        public string MAMH { get; set; }
        public int Code { get; set; }

        public Header() 
        {
            Code = -1;
        }
        public Header(string mamh, int code) 
        {
            this.MAMH = mamh;
            this.Code = code;
        }
    }

    public class ListHeader
    {
        public List<Header> Headers { get; set; }

        public ListHeader()
        {
            Headers = new List<Header>();
        }

        public ListHeader(List<Header> headers)
        {
            Headers = headers;
        }
        public void Remove()
        {
            Headers.Clear();
        }
    }
}
