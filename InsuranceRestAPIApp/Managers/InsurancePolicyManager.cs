namespace MaxNewYorkInsurance.Managers;

using System.Drawing;
using System.Runtime.InteropServices.Marshalling;
using System.Text.Json;
using MaxNewYorkInsurance.Agents;
using MaxNewYorkInsurance.Models;
using MaxNewYorkInsurance.Renewal;
using Microsoft.AspNetCore.Routing.Constraints;

public class InsurancePolicyManager
{
    //evnets

    public event AccountsAgent? policyPurchased;
    public event ClaimsAgent? claimRegistered;
    public event AccountsAgent? premiumPaid;
    public event RenewalAgent? policyRenewed;

    public void PurchasePolicy(Policy policy)
    {
        policyPurchased?.Invoke(policy);
    }
    public void RegisterClaim(Claim claim)
    {
        claimRegistered?.Invoke(claim);
    }

    public void RenewPolicy(Policy policy)
    {
        policyRenewed?.Invoke(policy);
    }
    public void PayPremium(Policy policy)
    {
        premiumPaid?.Invoke(policy);
        Console.WriteLine("Premium is paid Successfully");
    }


    


   


    
}