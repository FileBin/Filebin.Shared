﻿namespace Filebin.Shared.Domain.Abstractions;

public interface IUnitOfWork {
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}

