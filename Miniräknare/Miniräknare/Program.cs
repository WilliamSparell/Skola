// See https://aka.ms/new-console-template for more information
using Miniräknare;

var calc = new Calculator();
var res = calc.Digit(5).Operator('+').Digit(6).Result();

Console.WriteLine(res);