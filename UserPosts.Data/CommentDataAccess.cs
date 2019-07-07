using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserPosts.Domain;
using UserPosts.Services;

namespace UserPosts.Data
{
    public class CommentDataAccess : BaseDataAccess<Comment>, ICommentRepository
    {
        protected override string GetFile()
        {
            return @"C:\DotNetHomeWork\Week11\UserPosts\UserPosts.Data\Files\comments.json";
        }

        public IList<Comment> GetCommentsByUserId(int id)
        {
            var list = this.GetAll();

            return list.Where(x => x.Id == id).ToList();
        }
    }
}
