using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyModels;



namespace MyDataBase.DBOperations
{
   public class StudentRepository
    {
        public int AddStudent(StudentModel model)
        {
            using (var context = new StudentRegisDBEntities())
            {
                StudentTable std = new StudentTable()
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email,
                    Class = model.Class,
                    MobileNo = model.MobileNo
                };
                context.StudentTable.Add(std);

                context.SaveChanges();

                return std.Id;
            }
        }
    }
}
