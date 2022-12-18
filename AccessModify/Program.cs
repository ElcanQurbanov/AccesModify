

//1)  Yazdiqlarimi praktika etmek.

#region Task1
//using ServiceLayer;

//AccountService accountService= new AccountService();

//accountService.Login();



//using AccessModify.Models;

//Person Person1 = new Person()
//{
//    Name= "Shaiq",
//    Surname= "Kazimov",
//    Age= 25
//};

//Person Person2 = new Person()
//{
//    Name = "Ceyhun",
//    Surname = "Yusifli",
//    Age = 23
//};

//Person Person3 = new Person()
//{
//    Name = "Mubariz",
//    Surname = "Agayev",
//    Age = 18
//};

//Person Person4 = new Person()
//{
//    Name = "Pervin",
//    Surname = "Regimli",
//    Age = 25
//};

//Person Person5 = new Person()
//{
//    Name = "Mirze",
//    Surname = "Bashirzade",
//    Age = 26
//};

//Person[] people = {Person1, Person2, Person3, Person4, Person5};

////foreach (var item in people)
////{
////    Console.WriteLine(item.Name);
////}

//GetPersonsByAge(people);


//static void GetPersonsByAge(Person[]people)
//{
//    foreach (var item in people)
//    {
//        if (item.Age > 25)
//        {
//            Console.WriteLine($"{item.Name} - {item.Surname} - {item.Age}");
//        }
//    }
//}


//using AccessModify.Models;

//Student student1 = new Student()
//{
//    Name = "Cavid",
//    Surname = "Ismayilzade",
//    Address = "Sulutepe",
//    Age = 22
//};

//Student student2 = new Student()
//{
//    Name = "Aqshin",
//    Surname = "Hummetov",
//    Address = "Xirdalan",
//    Age = 27
//};

//Student student3 = new Student()
//{
//    Name = "Ali",
//    Surname = "Talibov",
//    Address = "Xetai",
//    Age = 21
//};

//Student student4 = new Student()
//{
//    Name = "Elcan",
//    Surname = "Qurbanov",
//    Address = "Hovsan",
//    Age = 19
//};

//Student[] students = {student1, student2, student3, student4};

//Search(students);

//static void Search(Student[] students)
//{
//    string searchText = "C";

//    foreach (var item in students)
//    {
//        if (item.Name.ToLower().Contains(searchText.ToLower()) || item.Surname.ToLower().Contains(searchText.ToLower()))
//        {
//            Console.WriteLine(item.Name+ " " + item.Surname);
//        }
//    }
//}
#endregion


#region Task2
//using AccessModify;

//Calculator calculator = new Calculator();
//calculator.calculation(4, 8);

#endregion


#region Task3
//using AccessModify;

//Employee employee1 = new Employee();
//{

//    employee1.Name = "Elcan";
//    employee1.Surname = "Qurbanov";
//    employee1.Age = 19;
//    employee1.Salary = 1900;
//}

//Employee employee2 = new Employee();
//{
//    employee2.Name = "Alakbar";
//    employee2.Surname = "Hasanov";
//    employee2.Age = 20;
//    employee2.Salary = 1800;
//}

//Employee employee3 = new Employee();
//{
//    employee3.Name = "Cavid";
//    employee3.Surname = "Ismayilzade";
//    employee3.Age = 22;
//    employee3.Salary = 2200;

//}

//Employee employee4 = new Employee();
//{
//    employee4.Name = "Shaiq";
//    employee4.Surname = "Kazimov";
//    employee4.Age = 25;
//    employee4.Salary = 2500;
//}

//int startSalary = 1000;
//int endSalary = 2000;

//Employee[] emplo = { employee1, employee2, employee3, employee4 };

//static void Employer(Employee[] emplo, int startSalary, int endSalary)
//{
//    bool check = false;
//    foreach (var item in emplo)
//    {
//        if (item.Salary > startSalary && item.Salary < endSalary)
//        {
//            Console.WriteLine(item.Name + " " + item.Surname + " " + item.Age + " " + item.Salary);
//            check = true;
//        }


//    }
//    if (!check)
//    {
//        Console.WriteLine("1000-2000 arasi maas alan yoxdur");
//    }


//}


//Employer(emplo, 2000, 2550);
#endregion


#region Task 4
//using AccessModify;

//Doctor doctor1 = new Doctor();
//{
//    doctor1.Name = "Alakbar";
//    doctor1.Surnname = "Hasanov";
//    doctor1.Address = "Bayil";
//    doctor1.Birthday = new DateTime(12, 24, 1986);
//}

//Doctor doctor2 = new Doctor();
//{
//    doctor2.Name = "Cavid";
//    doctor2.Surnname = "Ismayilzade";
//    doctor2.Address = "Sulutepe";
//    doctor2.Birthday = new DateTime(12, 24, 1986);
//}

//Doctor doctor3 = new Doctor();
//{
//    doctor3.Name = "Shaiq";
//    doctor3.Surnname = "Kazimov";
//    doctor3.Address = "sedmoy";
//    doctor3.Birthday = new DateTime(12, 24, 1986);
//}

//Doctor doctor4 = new Doctor();
//{
//    doctor4.Name = "Cahandar";
//    doctor4.Surnname = "Hasanov";
//    doctor4.Address = "Nargile";
//    doctor4.Birthday = new DateTime(12, 24, 1986);
//}

//Doctor doctor5 = new Doctor();
//{
//    doctor5.Name = "Pervin";
//    doctor5.Surnname = "Rehimli";
//    doctor5.Address = "";
//    doctor5.Birthday = new DateTime(12, 24, 1986);

//}
#endregion


#region Task 5
//using ServiceLayer2;
//using System.Diagnostics.CodeAnalysis;

//CustomMath customMath = new CustomMath();
//customMath.Factorial(3);


//CustomMath customMath = new CustomMath();
//customMath.Array();
#endregion







