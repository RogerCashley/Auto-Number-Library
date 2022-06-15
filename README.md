# Auto Number Library

A small class library for incrementing the last numeric part of a string; Most commonly used for incrementing invoice number.

## Description
| Version | Dependencies |
| ------- | ------------ |
|1.0|.Net Framework 4.0 and above|

## Sample usage/output

Basic increment:
```aspx-csharp
string testString = "INV/2206/001";

Console.WriteLine(testString.Add(1));      // INV/2206/002
Console.WriteLine(testString.Add(10));     // INV/2206/011
Console.WriteLine(testString.Add(999));    // INV/2206/1000
```

With letters:
```aspx-csharp
strong testString = "INV/2206/001ASF";

Console.WriteLine(testString.Add(1));      // INV/2206/002ASF
Console.WriteLine(testString.Add(10));     // INV/2206/011ASF
Console.WriteLine(testString.Add(999));    // INV/2206/1000ASF
```
