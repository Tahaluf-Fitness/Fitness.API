using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Tahaluf.Fitness.Core.Common;
using Tahaluf.Fitness.Core.Reopsitory;
using Tahaluf.Fitness.Data;

namespace Tahaluf.Fitness.Infra.Repository
{
    public class MeasurementRepository: IMeasurementRepository
    {
        private readonly IDbContext dbContext;

        public MeasurementRepository(IDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Measurement> GetMeasurement()
        {
            IEnumerable<Measurement> result = dbContext.Connection.Query<Measurement>("GetMeasurement", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public List<Measurement> GetMeasurementByUserID(int id)
        {
            var parameter = new DynamicParameters();
            parameter.Add("@UserID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            IEnumerable<Measurement> result = dbContext.Connection.Query<Measurement>("GetMeasurementByUserID",parameter, commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
        public bool CreateMeasurement(Measurement measurement)
        {
            var parameter = new DynamicParameters();
            parameter.Add("@Height",measurement.Height , dbType: DbType.Double, direction: ParameterDirection.Input);
            parameter.Add("@Weight", measurement.Weight, dbType: DbType.Double, direction: ParameterDirection.Input);
            parameter.Add("@BMI", measurement.Bmi, dbType: DbType.Double, direction: ParameterDirection.Input);
            parameter.Add("@BicepsWidth",measurement.BicepsWidth , dbType: DbType.Double, direction: ParameterDirection.Input);
            parameter.Add("@ThighWidth",measurement.ThighWidth , dbType: DbType.Double, direction: ParameterDirection.Input);
            parameter.Add("@Chest", measurement.Chest, dbType: DbType.Double, direction: ParameterDirection.Input);
            parameter.Add("@Shoulder",measurement.Shoulder , dbType: DbType.Double, direction: ParameterDirection.Input);
            parameter.Add("@Waist",measurement.Waist , dbType: DbType.Double, direction: ParameterDirection.Input);
            parameter.Add("@DateOfMeasurement",measurement.DateOfMeasurement , dbType: DbType.Date, direction: ParameterDirection.Input);
            parameter.Add("@UserID", measurement.UserId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dbContext.Connection.ExecuteAsync("CreateMesurment", parameter, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool UpdateMeasurement(Measurement measurement,int id)
        {
            var parameter = new DynamicParameters();
            parameter.Add("@MesurmentID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameter.Add("@Height", measurement.Height, dbType: DbType.Double, direction: ParameterDirection.Input);
            parameter.Add("@Weight", measurement.Weight, dbType: DbType.Double, direction: ParameterDirection.Input);
            parameter.Add("@BMI", measurement.Bmi, dbType: DbType.Double, direction: ParameterDirection.Input);
            parameter.Add("@BicepsWidth", measurement.BicepsWidth, dbType: DbType.Double, direction: ParameterDirection.Input);
            parameter.Add("@ThighWidth", measurement.ThighWidth, dbType: DbType.Double, direction: ParameterDirection.Input);
            parameter.Add("@Chest", measurement.Chest, dbType: DbType.Double, direction: ParameterDirection.Input);
            parameter.Add("@Shoulder", measurement.Shoulder, dbType: DbType.Double, direction: ParameterDirection.Input);
            parameter.Add("@Waist", measurement.Waist, dbType: DbType.Double, direction: ParameterDirection.Input);
            parameter.Add("@DateOfMeasurement", measurement.DateOfMeasurement, dbType: DbType.Date, direction: ParameterDirection.Input);
            parameter.Add("@UserID", measurement.UserId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dbContext.Connection.ExecuteAsync("UpdateMeasurement", parameter, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool DeleteMeasurement(int id)
        {
            var parameter = new DynamicParameters();
            parameter.Add("@MeasurementID", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dbContext.Connection.ExecuteAsync("DeleteMeasurement", parameter, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
