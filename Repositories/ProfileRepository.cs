﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts;
using Entity;
using Entity.DTO;
using Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Repositories
{
    public class ProfileRepository : IProfileRepository
    {
        private readonly CarAuctionContext _carAuctionContext;

        public ProfileRepository(CarAuctionContext carAuctionContext)
        {
            _carAuctionContext = carAuctionContext;
        }
        public void AddCar(CarDtoForCreation carDtoForCreation, string userId)
        {
            

            Car car = new Car
            {
                Year = carDtoForCreation.Year,
                ImageUrl = carDtoForCreation.ImageUrl,
                Fuel = carDtoForCreation.Fuel,
                CarBody = carDtoForCreation.CarBody,
                DriveUnit = carDtoForCreation.DriveUnit,
                Model = new Model
                {
                    Name = carDtoForCreation.Model,
                    Brand = new Brand
                    {
                        BrandName = carDtoForCreation.Brand
                    }
                },
                Lot = new Lot
                {
                    MinimalStep = carDtoForCreation.MinimalStep,
                    StartingPrice = carDtoForCreation.StartingPrice,
                    CurrentCost = carDtoForCreation.StartingPrice,
                    RedemptionPrice = carDtoForCreation.RedemptionPrice,
                    Status = Status.Pending,
                    SellerId = userId
                }
            };
            _carAuctionContext.Cars.Add(car);
        }

        public void DeleteLotWithCar(Car car, Lot lot)
        {
            _carAuctionContext.Cars.Remove(car);
            _carAuctionContext.Lots.Remove(lot);
        }

        public async Task<Car> GetCarAsync(int id, string idUser)
        {
            return await _carAuctionContext.Cars.SingleOrDefaultAsync(c => c.Id.Equals(id) && c.Lot.SellerId.Equals(idUser));
        }

        public async Task<IEnumerable<Car>> GetCarsProfileAsync(string id)
        {
            return await _carAuctionContext.Cars.Where(i => i.Lot.SellerId.Equals(id)).ToListAsync();
        }

        public async Task<Lot> GetLotAsync(int id)
        {
            return await _carAuctionContext.Lots.SingleOrDefaultAsync(c => c.Id.Equals(id));
        }

        public void Save()
        {
            _carAuctionContext.SaveChanges();
        }
    }
}
