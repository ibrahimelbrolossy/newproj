using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Takfila.Classes
{
    class MainTable
    {
        //protected string storedname;
        public DbWork DBw = new DbWork();
        protected int pos;
        protected DataTable tbl = new DataTable();
        public string curuntposition()
        {

         return (pos + 1).ToString() + "  of  " + tbl.Rows.Count.ToString();
            
        }
        public void movenext()
        {
            if (tbl.Rows.Count != 0)
            {
                if (pos < tbl.Rows.Count - 1)
                    pos++;
                setdata();
            }
            else
                MessageBox.Show("لا توجد بيانات"); 
        }
        public void moveprev()
        {
            if (tbl.Rows.Count != 0)
            {
                if (pos > 0)
                    pos--;
                setdata();

            }
            else
                MessageBox.Show("لا توجد بيانات"); 
        }
        public void movelast()
        {

            if (tbl.Rows.Count != 0)
            {
                pos = tbl.Rows.Count - 1;
                setdata();
            }
            else
            {
                MessageBox.Show("لا توجد بيانات");  
            }
          
        }
        public void movefirst()
        {
            if (tbl.Rows.Count != 0)
            {
                pos = 0;
                setdata();
            }
            else
                MessageBox.Show("لا توجد بيانات"); 
        }
            
        protected virtual void setdata()
        {

        }
        protected virtual bool Load2list(string TypeofOperation)
        {
            return false;
        }


        public bool Find(string[] keyColumn)
        {
            
            int x = tbl.Rows.IndexOf(tbl.Rows.Find(keyColumn));
            if (x != -1)
            {
                pos = x;
                setdata();
                return true;
            }
            else
                return false;
        }
    }
}
