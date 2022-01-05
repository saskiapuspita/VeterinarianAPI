﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VeterinarianAPI.Models;

namespace VeterinarianAPI.Repositories
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<Customer>> Get();

        Task<Customer> Get(int id);

        Task<Customer> Create(Customer customer);

        Task Update(Customer customer);

        Task Delete(int id);
    }
}
