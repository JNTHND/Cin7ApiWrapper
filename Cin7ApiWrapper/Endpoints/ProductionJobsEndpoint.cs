﻿using Cin7ApiWrapper.Common;
using Cin7ApiWrapper.Endpoints.Base;
using Cin7ApiWrapper.Models;

namespace Cin7ApiWrapper.Endpoints
{
    public class ProductionJobsEndpoint : Cin7Endpoint<ProductionJobsEndpoint, ProductionJob>
    {
        internal ProductionJobsEndpoint(Cin7ApiClient client)
            : base(client, "/api/v1/ProductionJobs")
        {
        }
    }
}
