
using MaxNewYorkInsurance.Models;
using System.Text.Json;
using TFLCollections;

namespace MaxNewYorkInsurance.Repositories;

public class ClaimsRepository
{
    
    public DoublyLinkedList<Claim> GetAllRegisterClaim()
    {
        string fileName = @"AC:\Users\Nirjala\Downloads\InsuranceRestAPIApp\InsuranceRestAPIApp\Data\claimrequests.json";
        string jsonString = File.ReadAllText(fileName);
        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        DoublyLinkedList<Claim>? RegisterClaims = JsonSerializer.Deserialize<DoublyLinkedList<Claim>>(jsonString, options);
        return RegisterClaims;
    }

    public bool SaveRegisterClaim(DoublyLinkedList<Claim> claims)
    {
        bool status = false;
        string fileName = @"C:\Users\Nirjala\Downloads\InsuranceRestAPIApp\InsuranceRestAPIApp\Data\claimrequests.json";
        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        string jsonString = JsonSerializer.Serialize(claims, options);
        File.WriteAllText(fileName, jsonString);
        status = true;
        return status;
    }
}