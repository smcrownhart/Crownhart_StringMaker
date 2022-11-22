using Crownhart_StringMaker;

// Sue Crownhart
// IT113
// NOTES: All outside help should be cited. If I missed any, it was not intentional.
// BEHAVIORS NOT IMPLIMENTED AND WHY: I think I have all the behaviors working correctly.  

StringMaker something = new StringMaker();

Console.WriteLine(something.Reverse("Sunbeam Tiger"));

Console.WriteLine(something.Reverse("Sunbeam Tiger", false));

Console.WriteLine(something.Symmetric("ABBA"));
Console.WriteLine(something.Symmetric("ABA"));
Console.WriteLine(something.Symmetric("ABba"));

Console.WriteLine(something.ToString("Sunbeam Tiger"));
Console.WriteLine(something.Equals("Sunbeam Tiger"));