using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcu1
{
    //this class will contail all methods for all math operations
    //create FEb-19,hg26
 public class MathFuctions
    {
        public int Add(int num1, int num2)
        {           
            int result = num1 + num2;
            return result;
        }

            
        
        int Sub(int num1, int num2)
        {
            return num1 - num2;
        }
         
        int Div(int num1, int num2)
        {
            return num1/num2;
        }
        int Mul(int num1, int num2)
        {
            return num1 * num2;
        }
        int Square(int num1, int num2)
        {
            return num1 * num1;
        }


      public int calc(int num1,int num2,string Mathopr)
        {
           int result=0;
         try{
                switch(Mathopr)
                {
               case "Add":
                   result=Add(num1,num2);
                   break;
               case "Sub":
                   result=Sub(num1,num2);
                   break;
               case "Div":
                   result = Div(num1, num2);
                   break;
               case "Mul":
                   result = Div(num1, num2);
                   break;
               case "Square":
                   result = Mul(num1, num1);
                   break;
               case "Other":
                   //result = Mul(num1, num2);
                   break;

            }    
               }
                catch(Exception)
                {
                    result=0;
                }
           return result;
            
           
        }

     public  int validatetextboxdata(string textbox1)
     {
         int o1=0;
         if (int.TryParse(textbox1,out o1))
         {
             //success
         }
         else
         {
             o1 = -9999;
             //string was not in correct format
         }
         return o1;

      }
    }
}
