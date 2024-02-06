using InsuranceManagement_Codding_Challenge_.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using InsuranceManagement_Codding_Challenge_.Exceptions;

namespace InsuranceManagement_Codding_Challenge_.Service
{
    internal class PolicyService : IPolicyService
    {
        static bool IsValidString(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                {
                    return false;
                }
            }
            return true;
        }
        IPolicyRepository policyRepository = new PolicyRepository();
        public void CreatePolicy()
        {
            bool policyInserted;
            Console.WriteLine("Enter your PolicyName");
            string userPolicyName = Console.ReadLine();
            if (IsValidString(userPolicyName))
            {

                policyInserted = policyRepository.CreatePolicy(userPolicyName);
                if (policyInserted)
                {
                    Console.WriteLine("Policy Inserted Successfully");
                }
                else
                {
                    Console.WriteLine("Policy Not Inserted Successfully");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a string with all characters being alphabetic.");
            }


        }
        public void GetPolicyById()
        {
            Console.Write("Enter your PolicyId: ");
            int userPolicyId = int.Parse(Console.ReadLine());
            String policy = policyRepository.GetPolicyById(userPolicyId);
            Console.WriteLine(policy);



        }
        public void GetAllPolicies()
        {
            String allPolices = policyRepository.GetAllPolicies();
            Console.WriteLine(allPolices);
        }
        public void UpdatePolicy()
        {
            try
            {
                Console.WriteLine("Enter your PolicyId");
                int userPolicyId = int.Parse(Console.ReadLine());
                if ((policyRepository.GetPolicyById(userPolicyId)) != null)
                {
                    Console.WriteLine("Select Option To Update");
                    Console.WriteLine("1.PolicyId");
                    Console.WriteLine("2.PolicyName");
                    int userChoice = int.Parse(Console.ReadLine());
                    switch (userChoice)
                    {
                        case 1:
                            int userupdatePolicyId;

                            Console.WriteLine("Enter your PolicyId: ");
                            userupdatePolicyId = int.Parse(Console.ReadLine());



                            String Conformationmessagerecieved;
                            bool Conformationmessage = policyRepository.UpdatePolicy(userupdatePolicyId, userPolicyId);
                            if (Conformationmessage)
                            {
                                Conformationmessagerecieved = $"Dear Employee,\n\n"
                                            + $"Policy Id is Updated to: {userupdatePolicyId}\n"

                                           + "Sincerely,\nFlipKart\nflipkart@gmail.com";
                                Console.WriteLine(Conformationmessagerecieved);
                            }
                            else
                            {
                                Conformationmessagerecieved = $"Dear Employee,\n\n"
                                           + $"Policy Id is Not Updated to: {userupdatePolicyId}\n"

                                          + "Sincerely,\nFlipKart\nflipkart@gmail.com";
                                Console.WriteLine(Conformationmessagerecieved);
                            }
                            break;
                        case 2:
                            string userPolicyName;
                            do
                            {
                                Console.WriteLine("Enter your PolicyName: ");
                                userPolicyName = Console.ReadLine();

                                if (!IsValidString(userPolicyName))
                                {
                                    Console.WriteLine("Invalid format. Please enter a valid string.");
                                }

                            } while (!IsValidString(userPolicyName));
                            string Conformationmessage2;
                            bool Conformation = policyRepository.UpdatePolicyName(userPolicyName, userPolicyId);
                            if (Conformation)
                            {
                                Conformationmessage2 = $"Dear Employee,\n\n"
                                            + $"Policy Name is Updated to: {userPolicyName}\n"

                                           + "Sincerely,\nFlipKart\nflipkart@gmail.com";
                                Console.WriteLine(Conformationmessage2);
                            }
                            else
                            {
                                Conformationmessage2 = $"Dear Employee,\n\n"
                                             + $"Policy Id is Not Updated to: {userPolicyName}\n"

                                            + "Sincerely,\nFlipKart\nflipkart@gmail.com";
                                Console.WriteLine(Conformationmessage2);
                            }
                            break;

                    }
                }
            }
            catch (PolicyNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public void DeletePolicy()
        {
            try
            {
                Console.WriteLine("Enter your PolicyId");
                int userPolicyId = int.Parse(Console.ReadLine());
                if ((policyRepository.GetPolicyById(userPolicyId)) != null)
                {
                    String Conformationmessagerecieved;
                    bool Conformationmessage = policyRepository.DeletePolicy(userPolicyId);
                    if (Conformationmessage)
                    {
                        Conformationmessagerecieved = $"Dear Employee,\n\n"
                                    + $"Policy Id Is deleted with {userPolicyId}\n"

                                   + "Sincerely,\nFlipKart\nflipkart@gmail.com";
                        Console.WriteLine(Conformationmessagerecieved);
                    }
                    else
                    {
                        Conformationmessagerecieved = $"Dear Employee,\n\n"
                                   + $"Policy Id is Not Deleted to: {userPolicyId}\n"

                                  + "Sincerely,\nFlipKart\nflipkart@gmail.com";
                        Console.WriteLine(Conformationmessagerecieved);
                    }

                }
                else
                {
                    throw new PolicyNotFoundException();
                }
            }
            catch (PolicyNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}
