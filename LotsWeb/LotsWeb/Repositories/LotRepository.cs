using LotsWebAPI.Abstractions;
using LotsWebAPI.Infraestructure;
using LotsWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LotsWebAPI.Repositories
{
    public class LotRepository : ILotRepository
    {
        private readonly LotsDbContext context;

        public LotRepository(LotsDbContext ctx)
        {
            context = ctx;

        }
        public void Add(LotOcupation lot)
        {
            
        }

        public LotOcupation Find(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<LotOcupation> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(LotOcupation lot)
        {
            throw new NotImplementedException();
        }
    }
}
