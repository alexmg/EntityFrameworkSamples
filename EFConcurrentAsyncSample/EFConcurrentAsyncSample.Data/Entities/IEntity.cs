﻿using System;

namespace EFConcurrentAsyncSample.Data.Entities
{
    public interface IEntity<TId> : IEntity where TId : IComparable
    {
        TId Id { get; set; }
    }

    public interface IEntity
    {
        DateTimeOffset CreatedOn { get; set; }
    }
}
