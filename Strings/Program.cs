string name = "Nanit";
Console.WriteLine(name);


//String concatenation
string lastName = "Khanna";
string fullName = name + " " + lastName;

Console.WriteLine(fullName);

//String interpolation
string fullNameInterpolated = $"{name} {lastName}";
Console.WriteLine(fullNameInterpolated);

//String length
Console.WriteLine($"Length of full name: {fullName.Length}");

//trim
string paddedName = "      Nanit Khanna           ";
Console.WriteLine(paddedName.Trim());

//Console.WriteLine(paddedName.TrimEnd());
//Console.WriteLine(paddedName.TrimStart();


// String replacement
string replacedName = fullName.Replace("Nanit", "Nani");
Console.WriteLine(replacedName);

//String searching

int indexofkhanna = fullname.indexof("khanna");
console.writeline($"index of 'khanna': {indexofkhanna}");