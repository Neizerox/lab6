using System;


namespace lab_1_1
{
    internal class Student : Human
    {
        private string _name;
        private int _course;
        private bool _debt;

        public Student()
            : base()
        {
            this._name = "Петр";
            this._course = 1;
            this._debt = false;
            
        }
        public Student(int course, bool debt, string name, int weight,int height,int age)
            : base(weight,height,age)
        {
            this._name = name;
            this._course = course;
            this._debt = debt;
        }
        public Student(Student student, Human human)
            : base(human)
        {
            this._name = student._name;
            this._course = student._course;
            this._debt = !student._debt;
        }

        public string Name 
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        public int Course
        {
            get 
            {
                return this._course; 
            }
            set 
            {
                this._course = value; 
            }
        }

        public bool Debt
        {
            get 
            {
                return this._debt;
            }
            set 
            { 
                this._debt = value; 
            }
        }

        public void DeleteStudent()
        {
            if (_debt)
            {
                Console.WriteLine(Name + " отчислен");
            }
            else
            {
                Console.WriteLine(Name + " не отчислен");
            }
        }
        public void NextCourse()
        {
            if (!_debt && _course < 4 ) 
            {
                Console.WriteLine(Name + " переведен с " + this._course + " курса на следущий");
            }
            else
            {
                Console.WriteLine(Name + " не переведен с " + this._course + " курса");
                this.DeleteStudent();
            }
        }
    }



}
