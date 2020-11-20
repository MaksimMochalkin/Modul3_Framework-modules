using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace StudentsLINQ
{
    public class DataSource : IEnumerable
    {
        private List<StudensInformation> studensInformation;

        public List<StudensInformation> Studens
        {
            get
            {
                if (studensInformation == null)
                    createList();
                
                return studensInformation; 
            }
        }

        private void createList()
        {
            DateTime date = DateTime.Now;
            var buf = date.ToShortDateString();
            List<StudensInformation> studensInformation = new List<StudensInformation>
            {
                new StudensInformation { ID = 1, Name = "Василий", LastName = "Васильев", NameExam = "Политология", Date = buf, Grade = 4},
                new StudensInformation { ID = 2, Name = "Алибек", LastName = "Алибеков", NameExam = "Механика", Date = buf, Grade = 2},
                new StudensInformation { ID = 3, Name = "Ильтай", LastName = "Ильтаев", NameExam = "Механика", Date = buf, Grade = 3},
                new StudensInformation { ID = 4, Name = "Сергазы", LastName = "Сергазов", NameExam = "Политология", Date = buf, Grade = 5},
                new StudensInformation { ID = 5, Name = "Анатолий", LastName = "Анатольев", NameExam = "ТОЭ", Date = buf, Grade = 3},
                new StudensInformation { ID = 6, Name = "Тогжан", LastName = "Тогжанова", NameExam = "Механика", Date = buf, Grade = 3},
                new StudensInformation { ID = 7, Name = "Дарья", LastName = "Дарьева", NameExam = "ТОЭ", Date = buf, Grade = 5},
                new StudensInformation { ID = 8, Name = "Алексей", LastName = "Алексеев", NameExam = "Механика", Date = buf, Grade = 2},
                new StudensInformation { ID = 9, Name = "Максим", LastName = "Максимов", NameExam = "Политология", Date = buf, Grade = 5},
                new StudensInformation { ID = 10, Name = "Иван", LastName = "Иванов", NameExam = "ТОЭ", Date = buf, Grade = 3},
                new StudensInformation { ID = 11, Name = "Султан", LastName = "Султанов", NameExam = "Политология", Date = buf, Grade = 4},
                new StudensInformation { ID = 12, Name = "Анастасия", LastName = "Анастасьева", NameExam = "ТОЭ", Date = buf, Grade = 2},
                new StudensInformation { ID = 13, Name = "Степан", LastName = "Степанов", NameExam = "Политология", Date = buf, Grade = 5},
                new StudensInformation { ID = 14, Name = "Бейбут", LastName = "Бейбутов", NameExam = "ТОЭ", Date = buf, Grade = 3},
                new StudensInformation { ID = 15, Name = "Станислав", LastName = "Станиславов", NameExam = "ТОЭ", Date = buf, Grade = 4},
                new StudensInformation { ID = 16, Name = "Полина", LastName = "Полинова", NameExam = "Политология", Date = buf, Grade = 3},
                new StudensInformation { ID = 17, Name = "Анжелика", LastName = "Анжеликина", NameExam = "ТОЭ", Date = buf, Grade = 4},
                new StudensInformation { ID = 18, Name = "Евгений", LastName = "Евгеньев", NameExam = "Механика", Date = buf, Grade = 3},
                new StudensInformation { ID = 19, Name = "Адиль", LastName = "Адильев", NameExam = "Политология", Date = buf, Grade = 4},
                new StudensInformation { ID = 20, Name = "Богдан", LastName = "Богданов", NameExam = "Политология", Date = buf, Grade = 2},
            };


        }

        public override string ToString()
        {
            return Studens.ToString();
        }

        public IEnumerator GetEnumerator()
        {
            return studensInformation.GetEnumerator();
        }
    }
}
