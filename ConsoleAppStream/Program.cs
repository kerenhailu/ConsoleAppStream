//FileStream fs = new FileStream(@"C:\Users\keren-hailu\source\repos\ObjStream2_12\ObjStream2_12\bin\Debug\net6.0\data.txt", FileMode.CreateNew);
//using (StreamWriter write = new StreamWriter(fs))
//{
//    write.WriteLine("some text...");

//};
//fs.Close();

//FileStream fs = new FileStream(@"C:\Users\keren-hailu\source\repos\ObjStream2_12\ObjStream2_12\bin\Debug\net6.0\data.txt", FileMode.Create);
//using (StreamWriter write = new StreamWriter(fs))
//{
//    write.WriteLine("keren...");

//};
//fs.Close();

//FileStream fs = new FileStream(@"C:\Users\keren-hailu\source\repos\ObjStream2_12\ObjStream2_12\bin\Debug\net6.0\data.txt", FileMode.Open);
//using (StreamWriter write = new StreamWriter(fs))
//{
//    write.WriteLine("keren.111..");

//};
//fs.Close();

//FileStream fs = new FileStream(@"C:\Users\keren-hailu\source\repos\ObjStream2_12\ObjStream2_12\bin\Debug\net6.0\data.txt", FileMode.OpenOrCreate);
//using (StreamWriter write = new StreamWriter(fs))
//{
//    write.WriteLine("keren.22222..");

//};
//fs.Close();

//FileStream fs = new FileStream(@"C:\Users\keren-hailu\source\repos\ObjStream2_12\ObjStream2_12\bin\Debug\net6.0\data.txt", FileMode.Append);
//using (StreamWriter write = new StreamWriter(fs))
//{
//    write.WriteLine("kerenHailu...");

//};
//fs.Close();

//Console.WriteLine("put name");
//string name=Console.ReadLine();
//Console.WriteLine("put lname");
//string lname = Console.ReadLine();

//FileStream fs = new FileStream(@"C:\Users\keren-hailu\source\repos\ObjStream2_12\ObjStream2_12\bin\Debug\net6.0\data.txt", FileMode.Append);
//using (StreamWriter write = new StreamWriter(fs))
//{
//    write.WriteLine(name);
//    write.WriteLine(lname);

//};
//fs.Close();
//=================================================================

//static void getFromUserAge()
//{
//    int age = int.Parse(Console.ReadLine());
//    FileStream ageFile = new FileStream(@"C:\file\data.txt", FileMode.Append);
//    using (StreamWriter write = new StreamWriter(ageFile))
//    {
//        write.WriteLine(age);
//    }

//};

//getFromUserAge();

//=================================================================
//static void getFromUserEmail()
//{
//    string email = Console.ReadLine();
//    if (email.Length > 5)
//    {
//        FileStream emailsFile = new FileStream(@"C:\file\mian.txt", FileMode.Append);
//        using (StreamWriter write = new StreamWriter(emailsFile))
//        {
//            write.WriteLine(email);
//        }

//    };
//}
//getFromUserEmail();

//=================================================
//static void getFromUserNumber()
//{
//    int number = int.Parse(Console.ReadLine());
//    FileStream ageFile = new FileStream(@"C:\file\data.txt", FileMode.Append);
//    using (StreamWriter write = new StreamWriter(ageFile))
//    {
//        write.WriteLine(age);
//    }

//};

//getFromUserNumber();
//===================================================

//FileStream person = new FileStream(@"C:\txt\person.txt", FileMode.Open);
//using (StreamReader reader = new StreamReader(person))
//{
//    string str = reader.ReadToEnd();
//    Console.WriteLine(str);
//}
//=======================================================5
//FileStream car = new FileStream(@"C:\file\car.txt", FileMode.Append);
//using (StreamWriter write = new StreamWriter(car))
//{
//    write.WriteLine("car");
//    write.WriteLine("car");
//    write.WriteLine("car");
//    write.WriteLine("car");

//}


//FileStream cars = new FileStream(@"C:\txt\cars.txt", FileMode.Open);
//using (StreamReader reader = new StreamReader(cars))
//{
//    string str = reader.ReadToEnd();
//    Console.WriteLine(str);
//}
//=======================================================6
//void getToNum()
//{
//    int num1 = int.Parse(Console.ReadLine());
//    int num2 = int.Parse(Console.ReadLine());
//    FileStream numbers = new FileStream(@"C:\file\numbers.txt", FileMode.Append);
//    using (StreamWriter write = new StreamWriter(numbers))
//    {
//        write.WriteLine(num1+num2);

//    }
//}
//getToNum();
//=======================================================7
//void getNumAndRundom()
//{
//    int numPromUser=int.Parse(Console.ReadLine());
//    Random random = new Random();
//    int r=random.Next(1,10);
//    if (r ==numPromUser)
//    {
//        FileStream numTheSame = new FileStream(@"C:\file\numTheSame.txt", FileMode.Append);
//        using (StreamWriter write = new StreamWriter(numTheSame))
//        {
//            write.WriteLine(numPromUser);

//        }
//    }
//    else
//    {
//        Console.WriteLine("you lose");

//    }
//}
//getNumAndRundom();
//=======================================================8+9
void getNumAndRundom1()
{
    int numPromUser = int.Parse(Console.ReadLine());
    Random random = new Random();
    int numRun = random.Next(1, 10);
    FileStream numTheSame = new FileStream(@"C:\file\numTheSame.txt", FileMode.Append);
    using (StreamWriter write = new StreamWriter(numTheSame))
    {
        write.WriteLine(numPromUser);

    }
    if (numRun == numPromUser)
    {
        Console.WriteLine("win");

    }
    else
    {
        Console.WriteLine("you lose");

    }
    if (numPromUser < 10)
    {
        getNumAndRundom1();
    }
    else
    {
        Console.WriteLine(numPromUser);
        Console.WriteLine(numRun);

    }
}
getNumAndRundom1();
//=======================================================10
//פונקציה שקוראת מקובץ של person ומדפיסה את הגיל במידה והוא שווה 25

static void getAge()
{

    FileStream personAGE = new FileStream(@"C:\txt\person.txt", FileMode.Open);
    using (StreamReader reader = new StreamReader(personAGE))
    {
        string str = reader.ReadToEnd();
        if(str == 25)
        {

        Console.WriteLine(str);
        }
    }

};

getAge();
