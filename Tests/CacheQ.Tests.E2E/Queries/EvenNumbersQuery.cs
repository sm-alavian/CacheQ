﻿using System.Diagnostics.CodeAnalysis;
using MediatR;

namespace CacheQ.Tests.E2E.Queries
{
    [ExcludeFromCodeCoverage]
    internal class EvenNumbersQuery : IRequest<int>
    {
        public int StartRange { get; set; }
        public int EndRange { get; set; }
    }
}
