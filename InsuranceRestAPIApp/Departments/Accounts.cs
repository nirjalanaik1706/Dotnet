using MaxNewYorkInsurance.Models;
using MaxNewYorkInsurance.Repositories;

namespace MaxNewYorkInsurance.Departments;

public class AccountsDepartment
{
       public void OnPayPurchasePolicy(Policy policy)
    {
         PolicyRepository repo=new PolicyRepository();

        List<Policy> policies = repo.GetAllPolicies();
        policies.Add(policy);
        repo.SaveAllPolicies(policies);
        Console.WriteLine("Payment recorded successfully.");
    }

    public void OnPayPremium(Policy policy)
    {
        PremiumRepository repo=new PremiumRepository();
        List<Premium> premiums = repo.GetAllPremimum();
        premiums.Add(policy);
        repo.SaveAllPremium(premiums);
        Console.WriteLine("Premium is paid Successfully");
    }
}