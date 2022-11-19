using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section1DSA2
{
    public class Department
    {
        public Department parent;
        public string Name { get; set; }
        public Person Manager { get; set; }
        public List<Person> Employee { get; set; }
        public List<Department> SubDepartments { get; set; }

        public Department(string Name, Person person)
        {
            this.Name = Name;
            this.Manager = person;
            this.Employee = new List<Person>();
            this.SubDepartments = new List<Department>();
        }

        public void AddDepartment(Department department)
        {
            SubDepartments.Add(department);          
            
        }
        public Department Find(Department root, string name)
        {
            if(root.Name == name) {
                
                return root; }
            else
            {
                
                foreach(var child in root.SubDepartments)
                {
                    parent = root;
                    var res = Find(child, name);
                    if(res != null) {
                    
                        return res; }
                }
            }
            return null;

        }

        public void RemoveDepartment(Department root, string name)
        {
            var target = Find(root, name);
            var childrens = target.SubDepartments;
            parent.SubDepartments.Remove(target);
            foreach(var child in childrens)
            {
                parent.SubDepartments.Add(child);
            }
            
        }

        public void MoveDepartment(string movedep, string pos, Department root)
        {
            var target = Find(root, movedep);
            RemoveDepartment(root, movedep);
            var position = Find(root, pos);
            position.AddDepartment(target);

        }

        public void AddPerson(Person person)
        {
            
            Employee.Add(person);
        }

        public void RemovePerson(Person person)
        {
            Employee.Remove(person);
        }

        public Person FindPersonInDepartment(Person person, Department department)
        {
            foreach(var per in department.Employee)
            {
                if(per == person) { return per; }
            }
            return null;
        }

        public void MovePerson(string start, string pos, Person person, Department root)
        {
            var targetDep = Find(root, start);
            
            var target = FindPersonInDepartment(person, targetDep);
            
            var position = Find(root, pos);
            
            position.AddPerson(target);
            
            targetDep.RemovePerson(target);
            

            
        }

        public int GetLenghtOfEmployee(Department department)
        {
            return department.Employee.Count;
        }
        public int GetLenghtOfDepartments(Department department)
        {
            return department.SubDepartments.Count;
        }



    }
}
