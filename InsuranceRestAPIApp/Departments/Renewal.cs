using MaxNewYorkInsurance.Models;
using MaxNewYorkInsurance.Repositories;

namespace MaxNewYorkInsurance.Departments;
class RenewalDepartment
{
    PolicyRepository repo=new PolicyRepository();
    public bool OnPolicyRenewed(string PolicyNumber)
    {
        List<Policy> policies = repo.GetAllPolicies();

        bool status = false;

        foreach (Policy policy in policies)
        {
            if (policy.PolicyNumber == PolicyNumber)
            {
                policy.IsRenewed = true;
                status = true;
                break;
            }
        }

        if (status)
        {
            repo.SaveAllPolicies(policies);
        }
        return status;
    }
    }
