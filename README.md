# PrivateCodeCoverage
A quick example of 100% code coverage with private and internal elements

## Motivation
After talking with some friends about unit testing and TDD when I noticed some concerns about achieving 100% code coverage for private methods and classes.
This repo is an example of how yes, you can have 100% code coverage with private members.

The main point I try to demonstrate here is that the private methods, of both the `public StringCalculator` and the `internal CalculatorString` classes, are covered by the tests since they're part of the Unit-of-work under test.

I usually consider private members that are not part of any of the APIs Unit-of-work to be not necessary and safe to delete ([YAGNI](https://www.martinfowler.com/bliki/Yagni.html)).

## About the code
The code here is in C# and targets dotnet core 3.0. The test library is XUnit.Net.
This code is inspired by the [StringCalculator](https://osherove.com/tdd-kata-1) TDD Kata.
