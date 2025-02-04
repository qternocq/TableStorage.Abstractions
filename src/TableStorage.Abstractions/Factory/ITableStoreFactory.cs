﻿using Azure.Data.Tables;
using TableStorage.Abstractions.Store;

namespace TableStorage.Abstractions.Factory
{
    public interface ITableStoreFactory
    {
        ITableStore<T> CreateTableStore<T>(string tableName, string storageConnectionString) where T : class, ITableEntity, new();

        ITableStore<T> CreateTableStore<T>(string tableName, string storageConnectionString, TableStorageOptions options) where T : class, ITableEntity, new();

        ITableStoreDynamic CreateTableStore(string tableName, string storageConnectionString);

        ITableStoreDynamic CreateTableStore(string tableName, string storageConnectionString, TableStorageOptions options);
    }
}