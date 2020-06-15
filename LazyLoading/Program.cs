using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoading
{
    class Program
    {

        static void Main(string[] args)
        {
            //Program p = new Program();

            //Customer o = new Customer(); // order object not loaded
            //Console.WriteLine(o._CustomerName);
            //foreach (Order o1 in o.Orders) // Load order object only at this moment
            //{
            //    Console.WriteLine(o1.OrderNumber);
            //}

            //Console.ReadKey();





            PersonalLoan p = new PersonalLoan("123456");

            //Load Detail started to load
            p.LoanDetail = new Loan("123456");
            Console.WriteLine(p.LoanDetail.AccountNumber);
            Console.WriteLine(p.LoanDetail.IsLoanApproved);
            Console.WriteLine(p.LoanDetail.LoanAmount);

            Console.ReadLine();
        }
    }

    public class Order
    {
        public string OrderNumber { get; set; }
    }

    public class Customer
    {
        public List<Order> _Orders = null;
        public string _CustomerName = null;
        public Customer()
        {
            _CustomerName = "Shiv";
            //Eager loading
            //_Orders = LoadOrders(); // Loads the order object even though //not needed
        }

        public List<Order> Orders
        {
            get
            {
                if(_Orders == null)
                {
                    _Orders = LoadOrders();
                }
                return _Orders;
            }
        }

        private List<Order> LoadOrders()
        {
            List<Order> temp = new List<Order>();
            Order o = new Order();
            o.OrderNumber = "ord1001";
            temp.Add(o);
            o = new Order();
            o.OrderNumber = "ord1002";
            temp.Add(o);
            return temp;
        }
    }


    public class PersonalLoan
    {
        public string AccountNumber { get; set; }
        public string AccounHolderName { get; set; }
        public Loan LoanDetail { get; set; }
        public PersonalLoan(string accountNumber)
        {
            this.AccountNumber = accountNumber;
            this.AccounHolderName = "Sourav";
        }
    }
    public class Loan
    {
        public string AccountNumber { get; set; }
        public float LoanAmount { get; set; }
        public bool IsLoanApproved { get; set; }
        public Loan(string accountNumber)
        {
            Console.WriteLine("Loan loading started");
            this.AccountNumber = accountNumber;
            this.LoanAmount = 1000;
            this.IsLoanApproved = true;
            Console.WriteLine("Loan loading started");
        }
    }
}
