﻿namespace ClubestApp.Tests.Services.UnitTests
{
    using ClubestApp.Data;
    using ClubestApp.Data.Models;
    using ClubestApp.Data.Models.Enums;
    using ClubestApp.Models.InputModels;
    using ClubestApp.Services;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Xunit;

    public class ClubServiceTests : IClassFixture<DbFixture>
    {
        private ServiceProvider serviceProvider;
        private ApplicationDbContext dbContext;
        private ClubService clubService;

        public ClubServiceTests(DbFixture dbFixture)
        {
            this.serviceProvider = dbFixture.ServiceProvider;
        }

        private void Before()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;
            this.dbContext = new ApplicationDbContext(options);

            this.clubService = new ClubService(this.dbContext,
                this.serviceProvider.GetService<UserService>(),
                this.serviceProvider.GetService<CloudinaryService>(),
                this.serviceProvider.GetService<UserManager<User>>()
            );
        }

        [Fact]
        public async Task AddClubShouldReturnAddedClub()
        {
            this.Before();

            AddClubInputModel clubInputModel = new AddClubInputModel()
            {
                Name = "Programmer",
                Fee = 30,
                PriceType = "2",
                IsPublic = true,
                Description = "some information describing the club dfvcsdfvdvsevre",
                Town = "Sofia",
                Interests = new List<string>()
                 {
                     "software engineering",
                     "programming",
                     "informatics"
                 }
            };

            User user = new User()
            {
                FirstName = "Test"
            };
            this.dbContext.Add(user);
            this.dbContext.SaveChanges();

            var club = await this.clubService.AddClub(clubInputModel, user.Id);

            Assert.NotNull(club);
        }

        [Fact]
        public async Task AddClubShouldReturnNullWithNoEmptyData()
        {
            this.Before();

            AddClubInputModel clubInputModel = new AddClubInputModel();

            User user = new User()
            {
                FirstName = "Test"
            };
            this.dbContext.Add(user);
            this.dbContext.SaveChanges();

            var club = await this.clubService.AddClub(clubInputModel, user.Id);

            Assert.Null(club);
        }
    }
}