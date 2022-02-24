using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DomainModels.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Repository.DAL;
using Repository.Services.Abstarction;
using TOPFY.DataInitializer.POCOGenerators;

namespace TOPFY.DataInitializer
{
    public class DbSeeder
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly AppDbContext _context;
        private readonly UserManager<User> _userManager;
        public DbSeeder(IUnitOfWork unitOfWork,AppDbContext context,
            UserManager<User> userManager)
        {
            _unitOfWork = unitOfWork;
            _context = context;
            _userManager = userManager;
        }
        public async Task InitializeSeeder() 
        {
            _context.Database.Migrate();
            if(!await _unitOfWork.Tags.AnyAsync())
            {
                await TagGenerator.GenerateTagsAsync(_unitOfWork);
            }
            if (!await _userManager.Users.AnyAsync())
            {
                await UserGenerator.GenerateUsersAsync(_userManager,_unitOfWork);
            }
            if (!await _unitOfWork.Posts.AnyAsync())
            {
                await PostGenerator.GeneratePostsAsync(_unitOfWork,_userManager);
            }
            if (!await _unitOfWork.UserConnections.AnyAsync())
            {
                await UserConnectionGenerator.GenerateUserConnectionsAsync(_unitOfWork);
            }
            await _unitOfWork.CompleteAsync();
            
        }
    }
}
