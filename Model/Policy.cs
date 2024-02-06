using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceManagement_Codding_Challenge_.Model
{
    internal class Policy
    {
        private int policyId;
        private string policyname;
        public Policy()
        {



        }
        //Parameterized constructor
        public Policy(int policyId, string policyname)
        {
            this.policyId = policyId;
            this.policyname = policyname;
            

        }
        //getter and setter methods
        public int PolicyId
        {
            get { return policyId; }
            set { policyId = value; }
        }
        public string Policyname
        {
            get { return policyname; }
            set { policyname = value; }
        }
    }
}
