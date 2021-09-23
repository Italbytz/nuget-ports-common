﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CommonPorts
{
    /// <summary>
    /// A data source (the R of a CRUD Repository).
    /// </summary>
    public interface IDataSource<TId, TEntity>
    {
        /// <summary>
        /// Retrieves an entity.
        /// </summary>
        /// <param name="id">ID of the entity to retrieve.</param>
        /// <returns>An entity.</returns>
        Task<Result<TEntity>> Retrieve(TId id);

        /// <summary>
        /// Retrieves all entities.
        /// </summary>
        /// <returns>All entities.</returns>
        Task<Result<List<TEntity>>> RetrieveAll();
    }
}
