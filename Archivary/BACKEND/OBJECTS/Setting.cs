using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivary.BACKEND.OBJECTS
{
    internal class Setting
    {
        private int settingId;
        private int borrowingCapacity;
        private int reserveLimit;
        private int borrowingDuration;
        public Setting(int settingId, int borrowingCapacity, int reserveLimit, int borrowingDuration) 
        {
            this.settingId = settingId;
            this.borrowingCapacity = borrowingCapacity;
            this.reserveLimit = reserveLimit;
            this.borrowingDuration = borrowingDuration;
        }

    }
}
