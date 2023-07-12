using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    public class Employee
    {
        protected int ID;
        protected string name;
        protected double bs, hra, ta, da, pf, gross;
        private static int count;

        public Employee(string name, double bs)
        {
            count++;
            ID = count;
            this.name = name;
            this.bs = bs;

        }

        public virtual void CalclateSallary()
        {
            hra = bs * 040;
            ta = bs * 020;
            da = bs * 0.15;
            pf = bs * 0.12;
            gross = (bs + hra + ta + da) - pf;
        }
        public override string ToString()
        {
            return $"id{ID}, name{name}, Gross{gross}";



        }
    }
    
    
    public  class SalesManager : Employee
    {

        private double comm;


        public SalesManager(string name, double bs, double comm):base (name,bs) 
        {
            this.comm = comm;
              
        }
        public override void CalclateSallary()
        {
            hra = bs * 0.40;
            ta = bs * 0.20;
            da = bs * 0.15;
            pf = bs * 0.12;
            gross =(bs + hra + ta + da+comm ) - pf;
        }

        public override string ToString()
        {
            return $" id{ID},name{name},Gross{gross}";
        }
    }
        

        
    
   
    
    
    
    
    
    
 }

    
    
     
      




















    
    
    
      
        

        
   
    
    
    
    
    
    
    
    
    
    
    
    
    
    
     
    
       
    
    
    
    
    
    
    
    
    
    
    
    






