using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceManagement_Codding_Challenge_.Repository
{
    internal interface IPolicyRepository
    {
        bool CreatePolicy( string userPolicyName);
        string GetPolicyById(int userPolicyId);
        string GetAllPolicies();
        bool UpdatePolicy(int userupdatePolicyId,int userPolicyId);
        bool UpdatePolicyName(string userPolicyName, int userPolicyId);
        bool DeletePolicy(int userPolicyId);
    }
}
