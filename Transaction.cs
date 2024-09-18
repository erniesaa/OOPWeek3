using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Transaction
    {
        private float val;
        private DateTime date;

    //setter & getter
        public void setval(float val)
    {
        if (val < 0) this.val = val;
    }
        public void setdate(DateTime date) {  this.date = date; }
        public float getval() { return val; }
        public DateTime getDate() { return date; }
    }
