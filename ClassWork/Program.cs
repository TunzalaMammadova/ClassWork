

//static void CheckPowerOfTwo(int n)
//{
//    int result = 0;

//    while (n > 1 && n % 2 == 0)
//    {
//        n /= 2;

//    }

//    if (n == 1)
//    {
//        Console.WriteLine("Quwwetidir");
//    }
//    else
//    {
//        Console.WriteLine("deyil");
//    }
//}


//CheckPowerOfTwo(9);

////var res = Math.Pow(2, 3);
////Console.WriteLine(res);

//var res = Math.Sqrt(48);
//Console.WriteLine(res);


//CustomMath math = new();


//Console.WriteLine(math.SumOfOddNumbers(new int[] { 1, 2, 3, 4, 5, 6 }));

//Console.WriteLine(math.CheckOddOrEvenNumber(5));

//Console.WriteLine(math.FindPowOfEvenNumbers(new int[] { 1, 2, 3, 4, 5, 6 }));

//Console.WriteLine(math.FindPowOfEvenNumbers(new int[] { 1, 2, 3, 4, 5, 6 }, 4));

//Console.WriteLine(math.GetFactorial(4));




//static void GetEmployeesByAge(int age)
//{
//    Employee[] employees = GetEmployees();

//    Employee[] filteredEmployees = employees.Where(m => m.age > age).ToArray();

//    foreach (var employee in filteredEmployees)
//    {
//        string result = $"{employee.name} - {employee.surname} - {employee.age} - {employee.address}- {employee.email}";

//        Console.WriteLine(result);
//    }
//}


//GetEmployeesByAge(20);




//static int CountOfEmployee(int startage, int endAge)
//{
//    Employee[] employees = GetEmployees();

//    Employee[] filteredEmployees = employees.Where(m => m.age > startage && m.age < endAge).ToArray();

//    return filteredEmployees.Length;
//}


//static int CountOfEmployee(int startage, int endAge) => GetEmployees().Where(m => m.age > startage && m.age < endAge).ToArray().Length;

//static int SumOfEmployeeAges()
//{
//    var employees = GetEmployees();
//    return employees.Sum(m => m.age);

//}


//static int SumOfEmployeeAges() => GetEmployees().Sum(m => m.age);




//Console.WriteLine(CountOfEmployee(20, 30));

//Console.WriteLine(SumOfEmployeeAges());




//static void GetEmployeesByFilteredEmail(string str)
//{
//    Employee[] employees = GetEmployees();
//    Employee[] filteredEmployees = employees.Where(m => m.email.ToLower().StartsWith(str.ToLower())).ToArray();

//    foreach (var employee in filteredEmployees)
//    {
//        string result = $"{employee.name} - {employee.surname} - {employee.age} - {employee.address}- {employee.email}";

//        Console.WriteLine(result);
//    }



//}


//GetEmployeesByFilteredEmail("T");

//static Employee[] GetEmployees()
//{
//    Employee employee1 = new()
//    {
//        name = "Semed",
//        surname = "Huseynov",
//        address = "Xezer",
//        email = "semed@gmail.com",
//        age = 26
//    };



//    Employee employee2 = new()
//    {
//        name = "Tunzale",
//        surname = "Memmedova",
//        address = "Azadliq",
//        email = "tunzale@gmail.com",
//        age = 24
//    };



//    Employee employee3 = new()
//    {
//        name = "Meryem",
//        surname = "Eliyeva",
//        address = "Yasamal",
//        email = "meryem@gmail.com",
//        age = 23
//    };


//    Employee[] employees = { employee1, employee2, employee3 };
//    return employees;

//};








