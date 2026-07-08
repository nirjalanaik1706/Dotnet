
using MaxNewYorkInsurance.Models;
using System.Text.Json;
using TFLCollections;

namespace MaxNewYorkInsurance.Repositories;

public class PremiumRepository
{
public DoublyLinkedList<Premium> GetAllPremimum()
    {
        string fileName = @"C:\Users\Nirjala\Downloads\InsuranceRestAPIApp\InsuranceRestAPIApp\Data\premiums.json";
        string jsonString = File.ReadAllText(fileName);
        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        DoublyLinkedList<Premium>? premiums = JsonSerializer.Deserialize<DoublyLinkedList<Premium>>(jsonString, options);
        return premiums;
    }


    public bool SaveAllPremium(DoublyLinkedList<Premium> premiums)
    {
        bool status = false;
        string fileName = @"C:\Users\Nirjala\Downloads\InsuranceRestAPIApp\InsuranceRestAPIApp\Data\premiums.json";
        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        string jsonString = JsonSerializer.Serialize(premiums, options);
        File.WriteAllText(fileName, jsonString);
        status = true;
        return status;
    }


}