using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceManagement_Codding_Challenge_.Model
{
    internal class Claim
    {
        private int claimId;
        private int claimNumber;
        private DateTime dateFiled;
        private decimal claimAmount;
        private string status;
        private int policyId;
        private int clientId;

        public Claim()
        {



        }
        //Parameterized constructor
        public Claim(int claimId, int claimNumber, DateTime dateFiled,decimal claimAmount, string status,int policyId,int clientId)
        {
            this.claimId = claimId;
            this.claimNumber = claimNumber;
            this.dateFiled = dateFiled;
            this.claimAmount = claimAmount;
            this.status = status;
            this.policyId = policyId;
            this.clientId= clientId;

        }
        //getter and setter methods
        public int ClaimId
        {
            get { return claimId; }
            set { claimId = value; }
        }
        public int ClaimNumber
        {
            get { return claimNumber; }
            set { claimNumber = value; }
        }
        public DateTime DateFiled
        {
            get { return dateFiled; }
            set { dateFiled = value; }
        }
        public decimal ClaimAmount
        {
            get { return claimAmount; }
            set { claimAmount = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        public int PolicyId
        {
            get { return policyId; }
            set { policyId = value; }
        }
        public int ClientId
        {
            get { return clientId; }
            set { clientId = value; }
        }

    }
}
