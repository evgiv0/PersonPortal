﻿using System.Threading.Tasks;
using Models;

namespace DBRepository.Interfaces
{
    public interface IBlogRepository
    {
        Task<Page<Post>> GetPosts(int index, int pageSize, string tag = null);
    }
}