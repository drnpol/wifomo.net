﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WIF.Core.Repositories
{
    public interface IUnitOfWork
    {
        UserRepository UserRepository { get; }
        Task SaveChanges();
    }
}
