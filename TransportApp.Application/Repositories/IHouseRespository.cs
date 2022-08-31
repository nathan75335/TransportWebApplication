﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportApp.Domain;

namespace TransportAppApplication.Repositories
{
    public interface IHouseRespository
    {
        Task<House> CreateNewHouseAsync(House house);

        Task<List<House>> GetListHouseAsync();

        Task<House> UpdateHouseAsync(House house);

        Task<House> DeleteHouseAsync(House house);

        Task<House> GetHouseByIdAsync(int id);
    }
}
