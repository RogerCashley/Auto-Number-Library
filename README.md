# Auto-Number-Library

A small class library for incrementing the last numeric part of a string; Most commonly used for incrementing invoice number.

## Sample Usage/Output

Basic increment
```aspx-csharp
stirng testString = "INV/2206/001";
Console.WriteLine(testString.Add(1));      // INV/2206/002
Console.WriteLine(testString.Add(10));     // INV/2206/011
Console.WriteLine(testString.Add(20));     // INV/2206/021
```

