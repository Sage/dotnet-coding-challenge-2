# .NET Coding Challenge 2
> This coding challenge is for a .NET developer. We are making the assumption that you are familiar with .NET Core.

Your task is to build a solution that parses text.

There is no strict time limit and you won't be judged on how long it took you to complete, however we would like you to spend between 1-2 hours on this.
1. You must use .NET Core and C#
2. You do not need any persistent storage.
3. You can use any NuGet package but be prepared to justify its usage.

## Specification
We want you to develop an application that processes text and supplies a summary of statistics based on that text.

### Statistics Requirements
 - Raw size, in bytes of the text (assuming UTF-8 encoding if specified).
 - Number of words in the text.
 - List of distinct words in the text and the number of occurences of each.
 - All punctuation is to be ignored when counting words (and distinct words).
 - Examples of punctuation are members of the following categories in [UnicodeCategory](https://docs.microsoft.com/en-us/dotnet/api/system.globalization.unicodecategory?view=netcore-3.0): `ConnectorPunctuation`, `DashPunctuation`, `OpenPunctuation`, `ClosePunctuation`, `InitialQuotePunctuation`, `FinalQuotePunctuation`, or `OtherPunctuation`. 
 - Words are defined as any sequence of alphanumeric characters containing no whitespace.

### Extra considerations
- Is the implementation scalable? (We may need to run this against multiple/larger files).
- Consider the efficiency of the code.

## How we will assess your work
We are looking for production quality code which utilises design patterns where appropriate and conforms to best practices and principles such as SOLID, etc. Other things we will take into consideration:

 - Code should be testable and easy to maintain.

You should clone this repository and when you're ready to share your work push it to private repository and our recruitment team will let you know the username to add as a collaborator so we can check it out.