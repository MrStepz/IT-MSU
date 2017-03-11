using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD
{
    static class DateConvert
    {
        static  public  string dmyToymd(string date)
        {
            string[] sp = date.Split('/');
            string val = sp[2] + "/"+ sp[1]+"/"+sp[0];
         return val;
        }
        static public string ymdTodmy(string date)
        {
            string[] sp = date.Split('/');
            string val = sp[1] + "/" + sp[0] + "/" + sp[2];
            return val;
        }
    }
}
