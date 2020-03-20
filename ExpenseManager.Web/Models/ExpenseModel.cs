using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExpenseManager.Web.Models
{
    public class ExpenseModel
    {
        public int ExpenseID { get; set; }
        public string Expense_Description { get; set; }
        public int ExpenseRS { get; set; }
        public System.DateTime Date { get; set; }
        public int UserID { get; set; }
    }
}