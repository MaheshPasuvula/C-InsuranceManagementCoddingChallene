using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using InsuranceManagement_Codding_Challenge_.DataBaseUtility;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleTables;
using InsuranceManagement_Codding_Challenge_.Exceptions;

namespace InsuranceManagement_Codding_Challenge_.Repository
{
    internal class PolicyRepository : IPolicyRepository
    {
        public string connectionString;
        SqlConnection sqlconnection = null;
        SqlCommand cmd = null;
        public PolicyRepository()
        {
            sqlconnection = new SqlConnection(DataBaseConnection.GetConnectionString());
            cmd = new SqlCommand();
        }
        public bool CreatePolicy(string userPolicyName)
        {
            try
            {
                cmd.CommandText = "INSERT INTO POLICY(PolicyName)" +
                     "values(@POLICYNAME)";
                cmd.Connection = sqlconnection;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@POLICYNAME", userPolicyName);
                sqlconnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error:{ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }
        public string GetPolicyById(int userPolicyId)
        {
            try
            {
                cmd.CommandText = "SELECT * FROM POLICY WHERE POLICYID=@POLICYID";
                cmd.Connection = sqlconnection;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@POLICYID", userPolicyId);
                sqlconnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    var table = new ConsoleTable("POLICYID", "POLICYNAME");

                    while (reader.Read())
                    {
                        // Add rows to the ConsoleTable
                        table.AddRow(
                            reader["POLICYID"],
                            reader["POLICYNAME"]

                        );
                    }
                    // Capture Console output to a StringWriter
                    string tableContent = table.ToString();

                    // Return the table content as a string
                    return tableContent;

                }
                else
                {
                    throw new PolicyNotFoundException();
                }
            }
            catch (PolicyNotFoundException ex)
            {
                Console.WriteLine($"Error:{ex.Message}");
            }

            finally
            {

                sqlconnection.Close();
            }


            return null;



        }
        public string GetAllPolicies()
        {
            try
            {
                cmd.CommandText = "SELECT * FROM POLICY";
                cmd.Connection = sqlconnection;
                cmd.Parameters.Clear();
                sqlconnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    var table = new ConsoleTable("POLICYID", "POLICYNAME");

                    while (reader.Read())
                    {
                        // Add rows to the ConsoleTable
                        table.AddRow(
                            reader["POLICYID"],
                            reader["POLICYNAME"]

                        );
                    }
                    // Capture Console output to a StringWriter
                    string tableContent = table.ToString();

                    // Return the table content as a string
                    return tableContent;

                }
                else
                {
                    throw new PolicyNotFoundException();
                }
            }
            catch (PolicyNotFoundException ex)
            {
                Console.WriteLine($"Error:{ex.Message}");
            }
            finally
            {

                sqlconnection.Close();
            }


            return null;


        }
        public bool UpdatePolicy(int userupdatePolicyId, int userPolicyId)
        {
            cmd.CommandText = "UPDATE POLICY SET PolicyId=@UpdatePolicyID where POLICYID=@POLICYID";
            cmd.Connection = sqlconnection;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@UpdatePolicyId", userupdatePolicyId);
            cmd.Parameters.AddWithValue("@POLICYID", userPolicyId);
            sqlconnection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            sqlconnection.Close();
            return true;
        }
        public bool UpdatePolicyName(string userPolicyName, int userPolicyId)
        {
            cmd.CommandText = "UPDATE POLICY SET PolicyName=@UpdatePolicyName where POLICYID=@POLICYID";
            cmd.Connection = sqlconnection;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@UpdatePolicyName", userPolicyName);
            cmd.Parameters.AddWithValue("@POLICYID", userPolicyId);
            sqlconnection.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            sqlconnection.Close();
            return true;
        }
        public bool DeletePolicy(int userPolicyId)
        {

            try
            {
                cmd.CommandText = "DELETE FROM POLICY  where POLICYID=@POLICYID";
                cmd.Connection = sqlconnection;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@POLICYID", userPolicyId);
                sqlconnection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                return true;



            }
            catch (PolicyNotFoundException ex)
            {
                Console.WriteLine($"Error:{ex.Message}");

            }
            finally
            {
                sqlconnection.Close();
            }
            return false;
        }


    }
}
