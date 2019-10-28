using DAL.Common;
using DAL.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DAL.CRUD
{
    public class Common : Repository
    {

        public async Task CreateCodeGenerator(object[] args)
        {
            var query = @"insert into codegenerators (category,seed,prefix,surfix,currentnumber)
                        values ({0},{1},{2},{3},{4})";
            await UpdateAsync(query, args);

        }
        public async Task UpdateCodeGenerator(object[] args)
        {
            var query = @"update codegenerators set  currentnumber={1}
                            where category={0}";
            await UpdateAsync(query, args);

        }
        public async Task<IEnumerable<CodeGenerator>> CodeGenerators(object[] args)
        {
            return await FindAsync<CodeGenerator>("select * from codegenerators", args);
        }


        public Common(DataBaseContext context) : base(context)
        {
        }
    }
}
