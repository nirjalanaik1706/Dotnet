namespace Manager.UI;

using Manager;

public class UIManager
{
    public PolicyManager policy;
    public UIManager(PolicyManager policy)
    {
        this.policy=policy;
    }
    public void DisplayMenu()
    {
        Console.WriteLine("====================================");
        Console.WriteLine("Insurance Management System");
        Console.WriteLine("====================================");
        Console.WriteLine("1. Purchase Policy");
        Console.WriteLine("2. Pay Premium");
        Console.WriteLine("3. Register Claim");
        Console.WriteLine("4. Renew Policy");
        Console.WriteLine("5. Exit");
        Console.WriteLine("");
        Console.Write("Enter Choice:");

        int choice=int.Parse(Console.ReadLine());
        HandledDisplayMenu(choice);

    }

    public void HandledDisplayMenu(int num)
    {
        switch (num)
        {
            case 1:
                policy.PurchasePolicy("");
            break;

            case 2:
                policy.PayPremium();
            break;

            case 3:
                policy.RegisterClaim();
            break;

            case 4:
                policy.RenewPolicy();
            break;

            case 5:
                Environment.Exit(0);
            break;
        }
    }
}