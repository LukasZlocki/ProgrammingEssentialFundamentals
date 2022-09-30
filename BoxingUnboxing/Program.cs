
// Boxing number and unboxing number by casting to int
int number = 5;
object boxedNumber = number;
int unboxedNumber = (int)boxedNumber;

// boxing shortnumber and unboxing by casting to int - ERROR not able to cast short to int
//short shortnumber = 4;
//object boxedShort = shortnumber;
//int unboxedShort = (int)boxedShort;

// boxing -> unboxing : casting to same type
short otherShortNumber = 3;
int otherShortNumberCastToInt = (int)otherShortNumber;

Console.ReadKey();