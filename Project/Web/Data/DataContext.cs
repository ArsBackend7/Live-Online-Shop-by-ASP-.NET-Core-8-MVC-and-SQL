﻿using Microsoft.EntityFrameworkCore;

namespace Web.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }
}
