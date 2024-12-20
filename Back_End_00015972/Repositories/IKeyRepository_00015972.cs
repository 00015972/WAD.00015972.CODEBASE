﻿using Back_End_00015972.Models;
/*  My Studen ID: 00015972   */

namespace Back_End_00015972.Repositories
{
    public interface IKeyRepository_00015972
    {
        Task<IEnumerable<KeyItem_00015972>> GetAllKeysAsync();
        Task AddKeyAsync(KeyItem_00015972 key);
        Task UpdateKeyAsync(KeyItem_00015972 key);
        Task DeleteKeyAsync(int id);
        Task SaveAsync();
    }
}