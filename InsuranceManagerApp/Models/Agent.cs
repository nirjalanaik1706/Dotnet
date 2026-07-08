namespace MaxNewYorkInsurance.Models;

public class Agent
{
    public int AgentId { get; set; }

    public string AgentCode { get; set; } = string.Empty;

    public string FullName { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string MobileNumber { get; set; } = string.Empty;

    public string LicenseNumber { get; set; } = string.Empty;

    public string Branch { get; set; } = string.Empty;

    public string Designation { get; set; } = string.Empty;

    public decimal CommissionRate { get; set; }

    public decimal TotalCommissionEarned { get; set; }

    public DateTime DateOfJoining { get; set; }

    public bool IsActive { get; set; }

    public override string ToString()
    {
        return $"{AgentCode} - {FullName} ({Designation})";
    }
}