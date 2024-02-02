using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment_1.Controllers
{
    // question 1
    public class AddTenController : ApiController
    {

        /// <summary>
        /// adds 10 to the input integer
        /// </summary>
        /// <param name="id">input integer</param>
        /// <returns>input number plus 10</returns>
        /// GET api/AddTen/21 -> 31
        /// GET api/AddTen/0 -> 10
        /// GET api/AddTen/-9 -> 1
        public int GET(int id)
        {
            return id + 10;
        }

    }
  
        // question 2
        public class SquareController : ApiController
        {/// <summary>
         /// Squares the input number
         /// </summary>
         /// <param name="id">input integer</param>
         /// <returns>square of the input integer</returns>
         /// GET api/Square/2 -> 4
         /// GET api/Square/-2 -> 4
         /// GET api/Square/10 -> 100

        public int GET(int id)
            {
                return id * id;
            }
        }


   


    // question 3 and 4
    public class GreetingController : ApiController
    {
        public string Post()
        {
            return "Hello World!";
        }




        /// <summary>
        /// takes input from user and returns a string based on it
        /// </summary>
        /// <param name="id">number of people</param>
        /// <returns>the string "Greetings to {id} people!"</returns>
        /// GET api/Greeting/3 -> "Greetings to 3 people!"
        /// GET api/Greeting/6 -> "Greetings to 6 people!"
        /// GET api/Greeting/0 -> "Greetings to 0 people!"

        public string GET(int id)
        {
            return $"Greetings to {id} people!";
        }
    }


    // question 5
    public class NumberMachineController : ApiController
    {    /// <summary>
         /// perfroms mathematical operations to a number given by the user
         /// </summary>
         /// <param name="id">input integer</param>
         /// <returns>
         /// integers resulted from using mathematical operations
         /// Addition : 10 + 10 -> 20
         /// Subtraction : 10 - 10 -> 0
         /// Multiplication : 10 * 10 -> 100
         /// Division : 10 / 10 -> 1
         /// </returns>
         /// <example>
         /// GET http://localhost/api/NumberMachine/10
         /// response: Addition : 20 , Subtraction : 0 , Multiplication : 100, Division : 1 </example>
         /// GET http://localhost/api/NumberMachine/-5
         /// response: Addition : 5 , Subtraction : -15 , Multiplication : -50, Division : 0 </example>
         /// /// GET http://localhost/api/NumberMachine/30
         /// response: Addition : 40 , Subtraction : 20 , Multiplication : 300, Division : 3 </example>
        public string GET(int id)
    {
            int sum = id + 10;
            int sub = id - 10;
            int mul = id * 10;
            int div = id / 10;
            return $"Addition : {sum} , Subtraction : {sub} , Multiplication : {mul}, Division : {div}";
    }

    }


    // question 6
    public class HostingCostController : ApiController
    {    /// <summary>
         /// Calculates the cost of web hosting and maintenance
         /// </summary>
         /// <param name="id">number of days which has elapsedsince the beginning of the hosting</param>
         /// <returns>
         /// 3 strings which describe the total hosting cost
         /// </returns>
         /// <example>
         /// GET http://localhost:50726/api/Hostingcost/0
         /// response: 1 fortnights at $5.50/FN = 5.5 HST 13 % = $0.715 CAD total = $6.22 CAD </example>
         /// GET http://localhost:50726/api/Hostingcost/14
         /// response: 2 fortnights at $5.50/FN = 11 HST 13 % = $1.43 CAD total = $12.43 CAD </example>
         /// /// GET http://localhost:50726/api/Hostingcost/15
         /// response: 2 fortnights at $5.50/FN = 11 HST 13 % = $1.43 CAD total = $12.43 CAD </example>
         /// GET http://localhost:50726/api/Hostingcost/21
         /// response: 2 fortnights at $5.50/FN = 11 HST 13 % = $1.43 CAD total = $12.43 CAD </example>
        /// GET http://localhost:50726/api/Hostingcost/28
        /// 3 fortnights at $5.50/FN = 16.5 HST 13 % = $2.145 CAD total = $18.64 CAD
        public string GET(int id)
        {
            // counts the number of fortnights
            // 0 - 13 -> 1 fortnight
            // 14 - 27 -> 2 fortnights
            // dividing the number of days by 14 gives us the value of the fortnightd
            // but as, 0 is also considered as 1 fortnight, we add 1 to this value, as this value gives us 0 days as 0 fortnights
            // and that is the case with every input
            int numFN = id / 14 +1 ; 
            double costPerFN = 5.50;
            double hst = 0.13;
            // calculating the cost before adding the tax, number of days * cost
            double costBeforeTax = costPerFN * numFN;
            // calculating the tax 
            double tax = hst * costBeforeTax;
            // adding the tax and with costBeforeTax
            double totalCost = tax + costBeforeTax;

            // displaying the information
            return $"{numFN} fortnights at $5.50/FN = {costBeforeTax} " +
                $"HST 13 % = ${tax} CAD "+
                $"total = ${Math.Round(totalCost, 2)} CAD";
        }

    }






}
