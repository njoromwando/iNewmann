using DAL.Common;
using DAL.Registration;
using DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DAL.CRUD
{
   internal class Registration : Repository
    {

        public async Task CreateStudent(object[] args)
        {
            var query = @"";
            await UpdateAsync(query, args);

        }
        public async Task UpdateStudentDetails(object[] args)
        {
            var query = @"";
            await UpdateAsync(query, args);

        }
        //Returns a list of students
        public async Task<IEnumerable<Student>> StudentDetails(object[] args)
        {
            return await FindAsync<Student>("select * from Students", args);
        }


        public Registration(DataBaseContext context) : base(context)
        {
        }
    }
}
