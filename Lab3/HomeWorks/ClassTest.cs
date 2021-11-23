using System;

namespace Lab3.HomeWorks
{
    /// <summary>
    /// Класс для реализации метода сравнения объектов
    /// </summary>
    public class ClassTest : IComparable 
    {
        private string name = "";

        public ClassTest(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get; set; }

        public int CompareTo(object obj)
        {
            ClassTest ct = (ClassTest)obj;
            try
            {
                if (this.Age < ct.Age)
                    return -1;
                if (this.Age > ct.Age)
                    return 1;
                else 
                    return 0;
            }
            catch (NullReferenceException)
            {
                throw new Exception("Нет объекта для сравнения");
            }
        }

        public override bool Equals(object obj)
        {
            ClassTest ct = (ClassTest)obj;
            try
            { 
                return this.Name == ct.Name && this.Age == ct.Age;
            }
            catch (NullReferenceException)
            {
                return false;
            }
        }
    }
}