using System;
using AutoMapper;
using ContentsLimitInsurance.Data;
using ContentsLimitInsurance.Infrastructure.Automapper;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace ContentsLimitInsurance.IntegrationTests
{
    public class BaseTest :IDisposable
    {
        private const string ConnectionString = "DataSource=:memory:";
        private readonly SqliteConnection _connection;

        protected readonly Mapper _mapper;
        protected readonly ContentsLimitContext _context;

        protected BaseTest()
        {
            _connection = new SqliteConnection(ConnectionString);
            _connection.Open();
            var options = new DbContextOptionsBuilder<ContentsLimitContext>()
                .UseSqlite(_connection)
                .Options;
            _context = new ContentsLimitContext(options);
            _context.Database.EnsureCreated();

            _mapper = new Mapper(new MapperConfiguration(cfg => {
                cfg.AddProfile<MappingProfile>();
            }));
        }

        public void Dispose()
        {
            _connection.Close();
            _context.Database.EnsureDeleted();
        }
    }
}
