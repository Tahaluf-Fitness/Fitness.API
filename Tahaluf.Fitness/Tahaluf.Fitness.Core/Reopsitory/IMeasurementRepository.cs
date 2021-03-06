using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.Fitness.Data;

namespace Tahaluf.Fitness.Core.Reopsitory
{
    public interface IMeasurementRepository
    {
        public List<Measurement> GetMeasurement();
        public bool CreateMeasurement(Measurement measurement);
        public bool UpdateMeasurement(int id, Measurement measurement);
        public bool DeleteMeasurement(int id);
        public List<Measurement> GetMeasurementByUserID(int id);

    }
}
