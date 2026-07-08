using Action;

namespace Manager;

public class InsurancePolicyManager
    {
    
    public event InsuranceAction ?PurchasePolicyEvent;
    public event InsuranceAction PayPremiumEvent;
    public event InsuranceAction RegisterClaimEvent;
    public event InsuranceAction RenewPolicyEvent;

    public void PurchasePolicy(string message)
    {
        Console.WriteLine("policy purchased successfully");
        PurchasePolicyEvent?.Invoke("purches policy event ");
    }

    public void PayPremium()
    {
        Console.WriteLine("Pay permium successfully");
        PayPremiumEvent.Invoke("pay premium event");
    }

    public void RegisterClaim()
    {
        Console.WriteLine("Register Claim");
        RegisterClaimEvent.Invoke("register claim event");
    }

    public void RenewPolicy()
    {
        Console.WriteLine("Renew Policy");
        RenewPolicyEvent.Invoke("Renew policy event");
    }
    

}