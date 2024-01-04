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
        public int borrowingCapacityStudent { get; set; }
        public int borrowingCapacityTeacher { get; set; }
        public int reserveLimit { get; set; }
        public int borrowingDuration { get; set; }
        public Setting(int settingId, int borrowingCapacityStudent, int borrowingCapacityTeacher, int reserveLimit, int borrowingDuration) 
        {
            this.settingId = settingId;
            this.borrowingCapacityStudent = borrowingCapacityStudent;
            this.borrowingCapacityTeacher = borrowingCapacityTeacher;
            this.reserveLimit = reserveLimit;
            this.borrowingDuration = borrowingDuration;
        }

    }
}
