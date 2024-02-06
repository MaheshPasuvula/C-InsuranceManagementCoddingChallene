using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceManagement_Codding_Challenge_.Model
{
    internal class Client
    {
        private int clientId;
        private string clientname;
        private string contactInfo;
        private int policyId;
        public Client()
        {

           

        }
        //Parameterized constructor
        public Client(int clientId, string clientname, string contactInfo, int policyId)
        {
            this.clientId = clientId;
            this.clientname = clientname;
            this.contactInfo = contactInfo;
            this.policyId = policyId;

        }
        //getter and setter methods
        public int ClientId
        {
            get { return clientId; }
            set { clientId = value; }
        }
        public string Clientname
        {
            get { return clientname; }
            set { clientname = value; }
        }
        public string ContactInfo
        {
            get { return contactInfo; }
            set { contactInfo = value; }
        }
        public int PolicyId
        {
            get { return policyId; }
            set { policyId = value; }
        }
    }
}
