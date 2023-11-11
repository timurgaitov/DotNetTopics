const string interned0 = "text"; // const relates to the variable, not the string itself, it does not affect string interning
string interned1 = "text";
string interned2 = "text"; // constant strings (string literals) are interned
string notInterned1 = new string("text");
string x = "te";
string y = "xt";
string notInterned2 = x + y; // explicitly created strings are not interned
string interned3 = string.Intern(x + y); // can explicitly intern a string

// interned strings are not garbage collected

// compare references, check if it is the same object
Console.WriteLine((object)interned1 == (object)interned0); // True
Console.WriteLine((object)interned2 == (object)interned1); // True
Console.WriteLine((object)notInterned1 == (object)interned2); // False
Console.WriteLine((object)notInterned2 == (object)notInterned1); // False
Console.WriteLine((object)notInterned2 == (object)interned2); // False
Console.WriteLine((object)interned3 == (object)notInterned2); // False
Console.WriteLine((object)interned3 == (object)interned2); // True 
