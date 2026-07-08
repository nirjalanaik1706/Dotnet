
using MaxNewYorkInsurance.Models;
using System.Text.Json;
using TFLCollections;

namespace MaxNewYorkInsurance.Repositories;

public class PolicyRepository
{
    
    public DoublyLinkedList<Policy> GetAllPolicies()
    {
        string fileName = @"C:\Users\Nirjala\Downloads\InsuranceRestAPIApp\InsuranceRestAPIApp\Data\policies.json";
        string jsonString = File.ReadAllText(fileName);
        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        // DoublyLinkedList<Policy>? policies = JsonSerializer.Deserialize<DoublyLinkedList<Policy>>(jsonString, options);
        List<Policy> policies = JsonSerializer.Deserialize<List<Policy>>(jsonString, options);
        DoublyLinkedList<Policy> tPolicies =new DoublyLinkedList<Policy>();
        foreach(Policy thePolicy in policies)
        {
            tPolicies.insertAtEnd(thePolicy);
        } 
        return tPolicies;
    }


    public bool SaveAllPolicies(DoublyLinkedList<Policy> policies)
    {
        bool status = false;
        string fileName = @"C:\Users\Nirjala\Downloads\InsuranceRestAPIApp\InsuranceRestAPIApp\Data\policies.json";
        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        string jsonString = JsonSerializer.Serialize(policies, options);
        File.WriteAllText(fileName, jsonString);
        status = true;
        return status;


        
    }

}