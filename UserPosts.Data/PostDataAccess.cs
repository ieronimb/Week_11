﻿using System.Collections.Generic;
using System.Linq;
using UserPosts.Domain;
using UserPosts.Services;

namespace UserPosts.Data
{
    public class PostDataAccess : BaseDataAccess<Post>, IPostRepository
    {
        protected override string GetFile()
        {
            return @"C:\DotNetHomeWork\Week11\UserPosts\UserPosts.Data\Files\posts.json";
        }

        public IList<Post> GetPostsByUserId(int id)
        {
            var list = this.GetAll();
            return list.Where(x => x.UserId == id).ToList();
        }
    }
}
