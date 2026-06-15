using  MaxNewYorkInsurance.Models;
using MaxNewYorkInsurance.Repositories;
namespace MaxNewYorkInsurance.Departments;
class ClaimDepartment
{
    public void OnClaimRegistered(Claim claim)
    {
        
        ClaimsRepository repo=new ClaimsRepository();
        List<Claim> claims = repo.GetAllRegisterClaim();
        claims.Add(claim);
        repo.SaveRegisterClaim(claims);
        Console.WriteLine("Claim registered");
        
    }
}
