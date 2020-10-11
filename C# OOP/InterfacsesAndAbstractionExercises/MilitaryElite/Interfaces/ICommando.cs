using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Interfaces
{
    public interface ICommando
    {

        HashSet<Mission> Missions { get; set; }

    }
}
