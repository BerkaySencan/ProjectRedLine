using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Abstract;
using RedLine.Entities.Concrete;


namespace DAL.Concrete.EntityFramework
{

    // readonly UrunContext _urunContext = new UrunContext(); entity Bagalnınca olusacak
    class EFUrunDAL : IUrunDAL
    {
        public void add(Deneme entity)
        {
            throw new NotImplementedException();
        }

        public void delete(Deneme entity)
        {
            throw new NotImplementedException();
        }

        public Deneme get(Deneme entity)
        {
            throw new NotImplementedException();
        }

        public List<Deneme> getAll()
        {
            throw new NotImplementedException();
        }

        public void update(Deneme entity)
        {
            throw new NotImplementedException();
        }
    }
}
