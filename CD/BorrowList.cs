using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CD
{
    public static class BorrowList
    {
       public static List<string> listID;
       public static int cnt=1;

        static BorrowList()
        {
            listID = new List<string>();
        }
        public static void AddItem(string val)
        {
            listID.Add(val);
        }
        public static List<string> View()
        {
            return listID;
        }
        public static void RemoveItem(string val)
        {
            listID.Remove(val);
        }
        public static void RemoveAll()
        {
            int cntList = listID.Count();
            listID.RemoveRange(0,cntList);
        }
    }
}
