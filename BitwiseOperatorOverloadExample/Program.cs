
using BitwiseOperatorOverloadExample;

var f1 = new Flags(2);  // 2 in integer
Flags f2 = 3;   // 3 in integer || no need to write Flags f2 = new Flags(3);

Console.WriteLine(f1 & f2);  
Console.WriteLine(f1 | f2);  
Console.WriteLine(f1 ^ f2);  
Console.WriteLine(~f1);