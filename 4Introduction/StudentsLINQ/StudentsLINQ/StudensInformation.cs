using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace StudentsLINQ
{
    [Serializable]
    public class StudensInformation
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string NameExam { get; set; }
        public string Date { get; set; }
        public int Grade { get; set; }

        public override string ToString()
        {
            return $"ID студента: {ID}, Имя студента: {Name}, Фамилия студента: {LastName}, " +
                   $"Название экзамена: {NameExam}\n, Дата экзамена: {Date}, Оценка: {Grade}";
        }

    }
}
