//var stu1 = new
//{
//    name = "Emiraslan",
//    surname = "Miriyev",
//    age = 33
//};


//var stu2 = new
//{
//    name = "Sirac",
//    surname = "Memmedov",
//    age = 22
//};

//Console.WriteLine(stu1);


//Console.WriteLine(stu1.name+" "+stu1.surname+" "+stu1.age);



//using OOP_Class_Praktik;
//using System.ComponentModel.DataAnnotations;

//Student stu1 = new Student();

//stu1.name = "Ismayil";
//stu1.surname = "Ceferli";
//stu1.age = 24;
//stu1.address = "Ehmedli";


//Student stu2 = new Student();

//stu2.name = "Test";
//stu2.surname = "Testov";
//stu2.age = 50;
//stu2.address ="Xetai";

//string fullName = stu1.name + " " + stu1.surname;

//Console.WriteLine(fullName);
//Console.WriteLine(stu2.name+" "+stu2.surname);


//Student stu3 = new()
//{
//    name = "Sirac",
//    surname ="Memmedov",
//    age = 22,
//    address = "Masazir",
//    phone="12345"
//};


//Console.WriteLine(stu3.GetFullName());

//var result=stu1.GetFullData();

//Console.WriteLine(result);

//Student[] students = {stu1,stu2, stu3};

//void ShowAll(Student[] datas)
//{
//    foreach (Student item in datas)
//    {
//        Console.WriteLine(item.GetFullData());
//    }
//}

//ShowAll(students);



//Student[] students = { stu1, stu2, stu3 };

//Student GetByAge(Student [] datas,int age)
//{
//    Student foundStudent = new();
//    foreach (var item in datas)
//    {
//        if (item.age == age)
//        {
//            return item;
//            break;
//        }
//    }
//    return foundStudent;

//}
//var result = GetByAge(students,24);

//Console.WriteLine(result.GetFullData());





//Student[] students = { stu1, stu2, stu3 };

//Student GetByAge(Student[] datas, int age)
//{
//    var result = datas.FirstOrDefault(m => m.age == age);
//    return result!=null ? result: new Student();

//}
//var result = GetByAge(students, 24);

//Console.WriteLine(result.GetFullData());


//int a = 5;

//Console.WriteLine(a==5 ? a :"deyil");

//var result = a == 5 ? a.ToString() : "deyil";

//Console.WriteLine(result);





//using OOP_Class_Praktik;

//Book book1 = new Book("Leyli","Mecnun");

//Console.WriteLine(book1.name+" "+book1.author);



//using OOP_Class_Praktik;

//Book book1 = new Book("Leyli");


