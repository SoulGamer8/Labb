﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public class TeacherList
    {
        private List<Teacher> teachersList = new List<Teacher>();

        public List<Teacher> TeachersLst
        {
            get
            {
                return teachersList;
            }
        }

    
        public void TeacherAdd(int id,string name, string surname, int age, string sex, string country, string district, string city, string street, string housenumber, int studentLimit,string path)
        {
            teachersList.Add(new Teacher(id, name, surname, age, sex, new Address(country,district, city,street ,housenumber), studentLimit, path));
        }

        public void RemoveTeacher(int number)
        {
            teachersList.RemoveAt(number);
        }

      

        public int FindTeacher(string surname, string name)
        {
            foreach (Teacher teacher in teachersList)
            {
                if (surname == teacher.Surname && name == teacher.Name)
                {
                    return teachersList.IndexOf(teacher);
                }
            }

            return -1;
        }

    }
}
