﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace Tahaluf.Fitness.Core.Common
{
    public interface IDbContext
    {
        public DbConnection Connection
        {
            get;

        }
    }
}
