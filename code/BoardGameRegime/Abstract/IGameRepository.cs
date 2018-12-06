using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoardGameRegime.Entities;

namespace BoardGameRegime.Abstract
{
    public interface IGameRepository
    {
        IEnumerable <Games> Game { get; }
    }
}
