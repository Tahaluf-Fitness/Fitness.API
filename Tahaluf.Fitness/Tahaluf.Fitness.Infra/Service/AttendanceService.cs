using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.Fitness.Core;
using Tahaluf.Fitness.Core.Reopsitory;
using Tahaluf.Fitness.Core.Service;

namespace Tahaluf.Fitness.Infra.Service
{
    public class AttendanceService:IAttendanceService
    {
        private readonly IAttendanceRepository attendanceRepository;

        public AttendanceService(IAttendanceRepository _attendanceRepository)
        {
           attendanceRepository = _attendanceRepository;
        }
        public bool UpdateAttendance(Attendance attendance)
        {
            return attendanceRepository.UpdateAttendance(attendance);
        }

        public bool CreateAttendance(Attendance attendance)
        {
            return attendanceRepository.CreateAttendance(attendance);
        }

        public bool DeleteAttendance(int id)
        {
            return attendanceRepository.DeleteAttendance(id);
        }

        public List<Attendance> GetAttendance()
        {
            return attendanceRepository.GetAttendance();

        }
    }
}
