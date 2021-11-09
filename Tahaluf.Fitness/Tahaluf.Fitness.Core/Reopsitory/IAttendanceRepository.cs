using System;
using System.Collections.Generic;
using System.Text;

namespace Tahaluf.Fitness.Core.Reopsitory
{
    public interface IAttendanceRepository
    {
        bool CreateAttendance(Attendance attendance);
        bool UpdateAttendance(Attendance attendance);
        bool DeleteAttendance(int id);
        List<Attendance> GetAttendance();




    }
}
