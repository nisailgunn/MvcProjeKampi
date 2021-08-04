using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class CategoryRepository : ICategoryDal
    {
        Context c = new Context();
        DbSet<category> _object;
        public void Delete(category p)
        {
            _object.Remove(p);
            c.SaveChanges();
        }

        public void Insert(category p)
        {
            _object.Add(p);
            c.SaveChanges();
        }

        public List<category> List()
        {
            return _object.ToList();
        }

        public List<category> List(Expression<Func<category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(category p)
        {
            c.SaveChanges();
        }
    }
}
