﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PromoCodeFactory.DataAccess.Data
{
	public class EfDbInitializer : IDbInitializer
	{
		private readonly DataContext _dataContext;

		public EfDbInitializer(DataContext dataContext)
		{
			_dataContext = dataContext;
		}

		public void InitializeDb()
		{
			_dataContext.Database.EnsureDeleted();
			_dataContext.Database.EnsureCreated();

			_dataContext.AddRange(FakeDataFactory.Employees);
			_dataContext.SaveChanges();

			_dataContext.AddRange(FakeDataFactory.Preferences);
			_dataContext.SaveChanges();

			_dataContext.AddRange(FakeDataFactory.Customers);
			_dataContext.SaveChanges();

			_dataContext.AddRange(FakeDataFactory.Partners);
			_dataContext.SaveChanges();
		}
    }
}
