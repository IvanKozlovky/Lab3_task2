using System;

namespace UserWorkerApp
{
    public class User
    {
        protected string name;
        protected int age;

        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }

        public void setAge(int age)
        {
            this.age = age;
        }

        public int getAge()
        {
            return age;
        }
    }

    public class Worker : User
    {
        private int salary;

        public void setSalary(int salary)
        {
            this.salary = salary;
        }

        public int getSalary()
        {
            return salary;
        }
    }

    public class Student : User
    {
        private int scholarship;
        private int course;

        public void setScholarship(int scholarship)
        {
            this.scholarship = scholarship;
        }

        public int getScholarship()
        {
            return scholarship;
        }

        public void setCourse(int course)

        {
            this.course = course;
        }

        public int getCourse()
        {
            return course;
        }
    }

    public class Driver : Worker
    {
        private int drivingExperience;
        private string drivingCategory;

        public void setDrivingExperience(int drivingExperience)
        {
            this.drivingExperience = drivingExperience;
        }

        public int getDrivingExperience()
        {
            return drivingExperience;
        }

        public void setDrivingCategory(string drivingCategory)
        {
            this.drivingCategory = drivingCategory;
        }

        public string getDrivingCategory()
        {
            return drivingCategory;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Worker worker1 = new Worker();
            worker1.setName("Іван");
            worker1.setAge(25);
            worker1.setSalary(1000);

            Worker worker2 = new Worker();
            worker2.setName("Вася");
            worker2.setAge(26);
            worker2.setSalary(2000);

            int totalSalary = worker1.getSalary() + worker2.getSalary();
            Console.WriteLine($"Сума зарплат Івана і Васі: {totalSalary}");

            Student student = new Student();
            student.setName("Олександр");
            student.setAge(20);
            student.setScholarship(500);
            student.setCourse(3);

            Driver driver = new Driver();
            driver.setName("Петро");
            driver.setAge(32);
            driver.setSalary(3000);
            driver.setDrivingExperience(7);
            driver.setDrivingCategory("B");

            Console.WriteLine($"Студент: {student.getName()}, Вік:{student.getAge()}, Стипендія: {student.getScholarship()}, Курс: {student.getCourse()}");
            Console.WriteLine($"Водій: {driver.getName()}, Вік: {driver.getAge()}, Зарплата: {driver.getSalary()}, Водійський стаж: {driver.getDrivingExperience()} років, Категорія водіння: {driver.getDrivingCategory()}");
        }
    }
}