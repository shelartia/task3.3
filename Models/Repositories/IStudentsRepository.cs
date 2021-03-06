﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combo.Models
{
    public interface IStudentsRepository
    {
        IEnumerable<StudentModel> GetAllStudents();
        StudentModel GetStudentById(string id);
        void Add(StudentModel group);
        void PrepareGroup(StudentModel model);
        bool Delete(string objectId);
    }
}
