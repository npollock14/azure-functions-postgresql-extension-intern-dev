// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Extensions.PostgreSql;
using Microsoft.Azure.WebJobs.Extensions.PostgreSql.Samples.Common;


namespace Microsoft.Azure.WebJobs.Extensions.PostgreSql.Samples.InputBindingSamples
{
    /// <summary>
    /// This shows an example of a PostgreSQL Input binding that queries from a PostgreSQL View named ProductNames.
    /// </summary>
    public static class GetProductNamesView
    {
        [FunctionName("GetProductNamesView")]
        public static IActionResult Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "getproduct-namesview/")]
            HttpRequest req,
            [PostgreSql("SELECT * FROM ProductNames",
                "PostgreSqlConnectionString")]
            IEnumerable<ProductName> products)
        {
            return new OkObjectResult(products);
        }
    }
}
