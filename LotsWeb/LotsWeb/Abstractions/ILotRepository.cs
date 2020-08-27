using LotsWebAPI.Infraestructure;
using LotsWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LotsWebAPI.Abstractions
{
    interface ILotRepository
    {
        public void Add(LotOcupation lot);

        IEnumerable<LotOcupation> GetAll();

        LotOcupation Find(int id);

        void Remove(int id);

        void Update(LotOcupation lot);

    }
}
