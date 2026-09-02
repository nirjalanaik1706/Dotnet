
using System.Reflection;
using Test;

// public class Program
// {
//     public static void Main(string[] args)
//     {
//         Calculator cal=new Calculator();
//     }
// }

Assembly assembly=Assembly.LoadFile(@"D:\TAP\GITHUB\Dotnet\Reflection\obj\Debug\net10.0\Reflection.dll");
Type calType=assembly.GetType("Test.Calculator");
object calc=Activator.CreateInstance(calType);

PropertyInfo prop=calType.GetProperty("Number");
prop.SetValue(calc,10.0);


MethodInfo addMethod=calType.GetMethod("Add");
double result=(double)addMethod.Invoke(calc,new object[]{5.0});
Console.WriteLine(result);