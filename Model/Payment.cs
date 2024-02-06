using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceManagement_Codding_Challenge_.Model
{
    internal class Payment
    {
        private int paymentID;
        private DateTime paymentDate;
        private decimal paymentAmount;
        private int clientID;
        public Payment()
        {

        }
        //Parameterized constructor
        public Payment(int paymentID, DateTime paymentDate, decimal paymentAmount,int clientID )
        {
            this.paymentID = paymentID;
            this.paymentDate = paymentDate;
            this.paymentAmount = paymentAmount;
            this.clientID = clientID;
           
        }
        //getter and setter methods
        public int PaymentID
        {
            get { return paymentID; }
            set { paymentID = value; }
        }
        public DateTime PaymentDate
        {
            get { return paymentDate; }
            set { paymentDate = value; }
        }
        public decimal PaymentAmount
        {
            get { return paymentAmount; }
            set { paymentAmount = value; }
        }
        public int ClientID
        {
            get { return clientID; }
            set { clientID = value; }
        }
       
    }
}
