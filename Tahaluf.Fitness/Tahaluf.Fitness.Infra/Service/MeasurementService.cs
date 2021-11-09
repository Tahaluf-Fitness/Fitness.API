﻿using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.Fitness.Core.Reopsitory;
using Tahaluf.Fitness.Core.Service;
using Tahaluf.Fitness.Data;

namespace Tahaluf.Fitness.Infra.Service
{
    public class MeasurementService:IMeasurementService
    {
        private readonly IMeasurementRepository measurementRepository;

        public MeasurementService(IMeasurementRepository measurementRepository)
        {
            this.measurementRepository = measurementRepository;
        }
        public List<Measurement> GetMeasurement()
        {
            return measurementRepository.GetMeasurement();
        }
        public bool CreateMeasurement(Measurement measurement)
        {
            return measurementRepository.CreateMeasurement(measurement);
        }
        public bool UpdateMeasurement(Measurement measurement)
        {
            return measurementRepository.UpdateMeasurement(measurement);
        }
        public bool DeleteMeasurement(int id)
        {
            return measurementRepository.DeleteMeasurement(id);
        }
    }
}
