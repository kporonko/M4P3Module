using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongsModule
{
    internal interface IQueries
    {
        public void InnerJoin(SongsModuleContext context);
        public void SongsBeforeTheYoungestArtist(SongsModuleContext context);
    }
}
