﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransportApp.Domain;

namespace TransportApp.Application.Services
{
    public interface IServiceStreet
    {
        Task<Street> CreateNewStreetAsync(Street street);

        Task GetStreetByIdAsync(int id);

        Task UpdateStreetAsync(int id);

        Task DeleteStreetAsync(int id);
    }
}
