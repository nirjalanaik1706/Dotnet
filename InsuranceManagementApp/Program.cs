namespace Main;
using Action;
using Manager.UI;
using Manager;
using sales;

public class Program
{
    public static void Main(string[] args)
    {
        PolicyManager policy = new PolicyManager();
        UIManager uIManager = new UIManager(policy);
        SalseDepartment ?dept=new SalseDepartment();

        policy.PurchasePolicyEvent += dept.OnPolicyPurchased;
        
        while (true)
        {
            uIManager.DisplayMenu();
        }
    }
}
