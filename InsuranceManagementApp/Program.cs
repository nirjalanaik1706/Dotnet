namespace Main;

using Manager.UI;
using Manager;

public class Program
{
    public static void Main(string[] args)
    {
        PolicyManager policy=new PolicyManager();
        UIManager uIManager=new UIManager(policy);

        while(true){
        uIManager.DisplayMenu();
        }
    }
}
