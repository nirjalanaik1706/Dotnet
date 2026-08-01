
// // Min &Max
// int []arr={2,6,1,3,6};
// int largest=int.MinValue;
// // int largest=arr[0];

// for(int i = 0; i < arr.Length - 1; i++)
// {
//     if (largest > arr[i])
//     {
//         largest=arr[i];
//     }
// }
// Console.WriteLine(largest);



// reverse string

// string str="NAMAN";
// string revStr="";

// for(int i=str.Length-1; i>=0;i--)
// {
//     revStr+=str[i];
// }
// Console.WriteLine(revStr);
// if (str == revStr)
// {
//     Console.WriteLine("palindrom");
// }
// else
// {
//     Console.WriteLine("Not palindrom");
// }

// find duplicates in str

string str="Programming";
for(int i = 0; i <= str.Length - 1; i++)
{
    for(int j = i + 1; j <= str.Length-1; j++)
    {
        if (str[i] == str[j])
        {
            Console.WriteLine(str[i]);
        }
    }
}
