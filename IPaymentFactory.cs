using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementSystem
{
    internal interface IPaymentFactory
    { 
        public string PaymentOperator { get; }
        public int Amount { get; }
        public void CreatePayment() { }
    }
}
