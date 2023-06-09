﻿using HotelListing.Data;
using System.Diagnostics.Metrics;

namespace HotelListing.Repositories.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Country> Countries { get; }
        IGenericRepository<Hotel> Hotels { get; }
        Task Save();
    }
}
