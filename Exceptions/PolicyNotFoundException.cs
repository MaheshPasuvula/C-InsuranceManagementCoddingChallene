using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceManagement_Codding_Challenge_.Exceptions
{
    internal class PolicyNotFoundException:ApplicationException
    {
        public string Message;
        public PolicyNotFoundException()
        {
            Message = "Policy NotFound Exception";
        }
        public PolicyNotFoundException(string message) : base(message)
        {

        }
    }
}
