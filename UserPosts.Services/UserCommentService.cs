using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserPosts.Domain;

namespace UserPosts.Services
{
    public class UserCommentService
    {
        private readonly IUserRepository userRepository;
        private readonly ICommentRepository commentRepository;

        public UserCommentService(IUserRepository userRepository, ICommentRepository commentRepository)
        {
            this.userRepository = userRepository;
            this.commentRepository = commentRepository;
        }

        public UserCommentsDetails GetUserComments(int id)
        {
            var response = new UserCommentsDetails();

            var user = this.userRepository.GetById(id);

            response.Email = user.Email;

            var comments = this.commentRepository.GetCommentsByUserId(id);

            response.Text = comments.OrderBy(x => x.Text).ToString();
            
            return response;
        }
       
    }

    public class UserCommentsDetails
    {
        public string Email { get; set; }

        public string Text { get; set; }
       
    }
   
}
