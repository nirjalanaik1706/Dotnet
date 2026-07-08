
using MaxNewYorkInsurance.Models;
using System.Text.Json;
using TFLCollections;

namespace MaxNewYorkInsurance.Repositories;

public class CustomerRepository
{

    public DoublyLinkedList<Customer> GetAllCustomers()
    {
        string fileName = @"C:\Users\Nirjala\Downloads\InsuranceRestAPIApp\InsuranceRestAPIApp\Data\customers.json";
        string jsonString = File.ReadAllText(fileName);
        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        DoublyLinkedList<Customer>? customers = JsonSerializer.Deserialize<DoublyLinkedList<Customer>>(jsonString, options);
        return customers;
    }


    public bool SaveAllCustomers(DoublyLinkedList<Customer> customers)
    {
        bool status = false;
        string fileName = @"C:\Users\Nirjala\Downloads\InsuranceRestAPIApp\InsuranceRestAPIApp\Data\customers.json";
        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        string jsonString = JsonSerializer.Serialize(customers, options);
        File.WriteAllText(fileName, jsonString);
        status = true;
        return status;
    }

}