
using CurrencyMathByOperatorOverload;

var m1 = new Money(5, 75);  // $5.75
var m2 = new Money(3, 50);  // $3.50

var total = m1 + m2;
var diff = m1 - m2;

Console.WriteLine(total); // $9.25
Console.WriteLine(diff);  // $2.25
