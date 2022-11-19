using Section1DSA2;


Person head = new Person() { FullName = "Artem Mescheryakov", Age = 18, Gender = "M"};
Department root = new Department("Carchik (Company)", head);
var curr = root;
List<Department> tree = new List<Department>();
Department Bulgaria = new Department("Bulgaria", new Person() { FullName = "Vasko Pagini", Age = 24, Gender = "M" });
Department France = new Department("France", new Person() { FullName = "Makron Ivan", Age = 34, Gender = "M" });
Department Usa = new Department("USA", new Person() { FullName = "Boba Fett", Age = 34, Gender = "M"});
Department Finance = new Department("Finance(Bg)", new Person() { FullName = "Oleg Tinkoff", Age = 44, Gender = "M"});
Department It = new Department("It(Bg)", new Person() { FullName = "Bill Gaets", Gender = "M", Age = 37 });
Department Security = new Department("Security(Bg)", new Person() { FullName = "Sasha Beli", Gender = "M", Age = 23 });
Department Hr = new Department("HR(Bg)", new Person() { FullName = "Olya Paninson", Age = 19, Gender = "F"});
Department Development = new Department("Development(Bg)", new Person() { FullName = "Artem Yaralov", Age = 20, Gender = "M"});
Department Designer = new Department("Designer(Bg)", new Person() { FullName = "Olga Skywalker", Age = 20, Gender = "F"});
Department Finance2 = new Department("Finance(Fr)", new Person() { FullName = "David Shaginyan", Age = 27, Gender = "M" });
Department It2 = new Department("It(Fr)", new Person() { FullName = "Egor Prichik", Gender = "M", Age = 25 });
Department Security2 = new Department("Security(Fr)", new Person() { FullName = "Filip Kovalev", Gender = "M", Age = 20 });
Department Finance3 = new Department("Finance(Us)", new Person() { FullName = "David Shagy", Age = 27, Gender = "M" });
Department It3 = new Department("It(Us)", new Person() { FullName = "Egor Proshka", Gender = "M", Age = 25 });
Department Security3 = new Department("Security(Us)", new Person() { FullName = "Filip Papic", Gender = "M", Age = 20 });
Department Hr2 = new Department("HR(Fr)", new Person() { FullName = "Olya Kravovic", Age = 19, Gender = "F" });
Department Development2 = new Department("Development(Fr)", new Person() { FullName = "Artem Pralax", Age = 20, Gender = "M" });
Department Designer2 = new Department("Designer(Fr)", new Person() { FullName = "Han Solo", Age = 20, Gender = "M" });
Department Hr3 = new Department("HR(Us)", new Person() { FullName = "Malik Papa", Age = 19, Gender = "M" });
Department Development3 = new Department("Development(Us)", new Person() { FullName = "Misha Diak", Age = 20, Gender = "M" });
Department Designer3 = new Department("Designer(Us)", new Person() { FullName = "Mila Ledovskaya", Age = 20, Gender = "F" });

List<Person> list = new List<Person>();
//List<Department> layer1 = new List<Department>() {Bulgaria, France, Usa };
//List<Department> layer21 = new List<Department>() {Security, Finance, It };
//List<Department> layer22 = new List<Department>() { Security2, Finance2, It2 };
//List<Department> layer23 = new List<Department>() { Security3, Finance3, It3 };
//List<Department> layer31 = new List<Department>() { Hr, Development, Designer };
//List<Department> layer32 = new List<Department>() { Hr2, Development2, Designer2 };
//List<Department> layer33 = new List<Department>() { Hr3, Development3, Designer3 };
list.Add(new Person() { FullName = "Person one", Age = 17, Gender = "M" });
list.Add(new Person() { FullName = "Person two", Age = 17, Gender = "M" });
list.Add(new Person() { FullName = "Person three", Age = 17, Gender = "M" });
list.Add(new Person() { FullName = "Person four", Age = 17, Gender = "M" });

root.AddDepartment(Bulgaria);
root.AddDepartment(France);
root.AddDepartment(Usa);
root.Employee = list;
Bulgaria.AddDepartment(It);
Bulgaria.AddDepartment(Finance);
Bulgaria.AddDepartment(Security);
Bulgaria.Employee = list;
France.AddDepartment(It2);
France.AddDepartment(Security2);
France.AddDepartment(Finance2);
France.Employee = list;
Usa.AddDepartment(It3);
Usa.AddDepartment(Security3);
Usa.AddDepartment(Finance3);
Usa.Employee = list;
It.AddDepartment(Development);
It.AddDepartment(Designer);
It.AddDepartment(Hr);
It.Employee = list;
It2.AddDepartment(Development2);
It2.AddDepartment(Hr2);
It2.AddDepartment(Designer2);
It3.AddDepartment(Hr3);
It3.AddDepartment(Development3);
It3.AddDepartment(Designer3);
AllDep(root, tree);

Console.WriteLine("Welcome to Section 1 by Artem Meshcheryakov");
Console.WriteLine(" ");
Console.WriteLine($"1 {root.Name}");
Console.WriteLine("_____________");
Console.WriteLine("");
Console.WriteLine("Press any key to continue");
string input = Console.ReadLine();
bool loop = true;

while (loop)
{
    
    PrintStep(curr);
    input = Console.ReadLine();
    int choice = Int32.Parse(input);
    switch (choice)
    {
        case 1:
            Console.Write("Enter name of the department: ");
            string name = Console.ReadLine();
            Console.Write("Enter the fullname of the manager: ");
            string ManName = Console.ReadLine();
            Console.Write("Enter the gender of the manager (M/F): ");
            string Gender = Console.ReadLine();
            Console.Write("Enter the age of the manager: ");
            string age = Console.ReadLine();
            int Age = Int32.Parse(age);
            Person mang = new Person() { FullName = ManName, Age = Age, Gender = Gender };
            curr.AddDepartment(new Department(name, mang));
            AllDep(root, tree);
            break;

        case 2:
            Console.Write($"Enter number of the department, which you can see before. From: 1 to {curr.SubDepartments.Count}: ");
            int ind = Int32.Parse(Console.ReadLine());
            curr.RemoveDepartment(root, curr.SubDepartments[ind - 1].Name);
            AllDep(root, tree);
            break;
        case 3:
            Console.Write($"Enter number of the person, which you can see before. From: 1 to {curr.Employee.Count}: ");
            int ind1 = Int32.Parse(Console.ReadLine());
            curr.RemovePerson(curr.Employee[ind1 - 1]);
            break;
        case 4:
            Console.Write("Enter full name of the person");
            string ManName1 = Console.ReadLine();
            Console.Write("Enter the gender of the manager (M/F): ");
            string Gender1 = Console.ReadLine();
            Console.Write("Enter the age of the manager: ");
            string age1 = Console.ReadLine();
            int Age1 = Int32.Parse(age1);
            Person mang1 = new Person() { FullName = ManName1, Age = Age1, Gender = Gender1 };
            curr.AddPerson(mang1);
            break;
        case 5:
            PrintAllDep();
            int ind2 = Int32.Parse(Console.ReadLine());
            int cnt = 1;
            Console.WriteLine("Which person you want to move?");
            foreach (var i in curr.Employee)
            {
                Console.WriteLine($"{cnt} {i.FullName} {i.Age} y.o.");
                cnt = cnt + 1;
            }
            cnt = 1;
            Console.Write($"Please input number of person from 1 to {curr.Employee.Count}: ");
            int ind3 = Int32.Parse(Console.ReadLine());
            curr.MovePerson(curr.Name, tree[ind2 - 1].Name, curr.Employee[ind3 - 1], root);
            break;

        case 6:
            Console.Write($"Select one department from list below from 1 to {curr.SubDepartments.Count}: ");
            int ind4 = Int32.Parse(Console.ReadLine());
            curr = curr.SubDepartments[ind4 - 1];
            break;
        case 7:
            Console.Write($"Select one department, which you want to move from list below from 1 to {curr.SubDepartments.Count}: ");
            int ind5 = Int32.Parse(Console.ReadLine());
            PrintAllDep();
            int ind6 = Int32.Parse(Console.ReadLine());
            curr.MoveDepartment(curr.SubDepartments[ind5 - 1].Name, tree[ind6 - 1].Name, root);
            break;
        case 8:
            curr.Find(root, curr.Name);
            curr = curr.parent;
            break;

        

    }


}


void PrintStep(Department dep)
{
    Console.Clear();
    int k = 1;
    foreach (var i in dep.SubDepartments)
    {
        Console.WriteLine($"{k} {i.Name}");
        k = k + 1;
    }
    k = 1;
    Console.WriteLine("_____________");
    Console.WriteLine("Info:");
    Console.WriteLine($"{dep.Manager.FullName} {dep.Manager.Age} y.o.");
    Console.WriteLine($"Number of Departments: {root.GetLenghtOfDepartments(dep)}");
    Console.WriteLine($"Number of Employee: {root.GetLenghtOfEmployee(dep)}");
    Console.WriteLine("");
    Console.WriteLine("Employee list:");
    foreach (var i in dep.Employee)
    {
        Console.WriteLine($"{k} {i.FullName} {i.Age} y.o.");
        k = k + 1;
    }
    k = 1;
    Console.WriteLine("_____________");
    Console.WriteLine("1 Add Department");
    Console.WriteLine("2 Remove Department");
    Console.WriteLine("3 Remove Person");
    Console.WriteLine("4 Add Person");
    Console.WriteLine("5 Move person");
    Console.WriteLine("6 Go to department");
   
    if (curr != root)
    {
        Console.WriteLine("7 Move Department");
        Console.WriteLine("8 Go Back");
    }
    Console.WriteLine("");
    Console.WriteLine("Press one of these keys");
}

void AllDep(Department root, List<Department> list)
{
    list.Add(root);

    if(root.SubDepartments.Count > 0)
    {
        foreach(var child in root.SubDepartments)
        {
           
            AllDep(child, list);
        }
    }
}

void PrintAllDep()
{
    int c = 1;
    Console.WriteLine("Please select department which you want to move this person/department");
    foreach(var branch in tree)
    {
        Console.WriteLine($"{c} {branch.Name}");
        c = c + 1;
    }
    Console.Write($"Enter number of the department from 1 to {tree.Count}: ");
}