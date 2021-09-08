using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm
{
    public class DiningTable
    {
        public int TableID { get; set; }
        public string TableName{ get; set; }

        public int Status { get; set; }
        public int Floor { get; set; }

        public DiningTable()
        {

        }
        public DiningTable(int tableID, string tableName, int status, int floor)
        {
            TableID = tableID;
            TableName = tableName;
            Status = 0;
            Floor = floor;
        }
    }
}
