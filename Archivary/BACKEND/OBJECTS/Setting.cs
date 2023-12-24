using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivary.BACKEND.OBJECTS
{
    public class Setting
    {
        public int settingId { get; set; }
        public int borrowingCapacity { get; set; }
        public int reserveLimit { get; set; }
        public int borrowingDuration { get; set; }
        public Setting(int settingId, int borrowingCapacity, int reserveLimit, int borrowingDuration) 
        {
            this.settingId = settingId;
            this.borrowingCapacity = borrowingCapacity;
            this.reserveLimit = reserveLimit;
            this.borrowingDuration = borrowingDuration;
        }

    }
}
