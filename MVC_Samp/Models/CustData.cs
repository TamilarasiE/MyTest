using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Samp.Models
{
    public class CustData
    {
        CUSTOMER cust = new CUSTOMER();
        PracticeEntities practice = new PracticeEntities();
        public IEnumerable<CUSTOMER> GetAll()
        {
           
            var custs = from p in practice.CUSTOMERS
                        select p;
       //     var nums = practice.CUSTOMERS.Select(m => m.ID).ToList();

        //   // var cc = practice.CUSTOMERS.(s => s.NAME != "")();

            return custs;

        }

        public CUSTOMER getByID(int id)
        {
            var cust = from c in practice.CUSTOMERS
                       where c.ID == id
                       select c;

            return cust.First();
        }

        public void Addcustomer(int id,int age,decimal salary,string address,string name)
        {
            var dbContaxt =new PracticeEntities();

            CUSTOMER cust = new CUSTOMER();
            cust.ID = practice.CUSTOMERS.Max(c=>c.ID) + 1;
            cust.ADDRESS = address;
            cust.SALARY = salary;
            cust.NAME = name;
            cust.AGE = age;
            dbContaxt.CUSTOMERS.Add(cust);
            dbContaxt.SaveChanges();
          //  return cust();
        }


    }
}