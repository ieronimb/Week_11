﻿using System;
using UserPosts.Data;
using UserPosts.Domain;
using UserPosts.Services;

namespace UserPosts.App
{
    public class Program
    {
        static void Main(string[] args)
        {
            IPostRepository postRepository = new PostDataAccess();
            IUserRepository userRepository = new UserDataAccess();

            var service = new UserService(userRepository, postRepository);

            var response = service.GetUserActiveRespose(2);
          
            IUserRepository newUserRepository = new UserDataAccess();
            ICommentRepository commentRepository = new CommentDataAccess();

            var commentservice = new UserCommentService(newUserRepository, commentRepository);

            var comments = commentservice.GetUserComments(1); 
            
        }
    }
}