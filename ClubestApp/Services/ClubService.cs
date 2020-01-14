﻿namespace ClubestApp.Services
{
    using ClubestApp.Data;
    using ClubestApp.Data.Models;
    using ClubestApp.Data.Models.Enums;
    using ClubestApp.Models.InputModels;
    using System;

    public class ClubService
    {
        private ApplicationDbContext dbContext;

        public ClubService(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Club AddClub(AddClubInputModel model)
        {
            Club newClub = new Club
            {
                Name = model.Name,
                Fee = (decimal)model.Fee,
                PriceType = (PriceType)Enum.Parse(typeof(PriceType), model.PriceType, true),
                IsPublic = (bool)model.IsPublic
            };

            var result = this.dbContext.Clubs.Add(newClub);
            this.dbContext.SaveChanges();

            return result.Entity;
        }
    }
}