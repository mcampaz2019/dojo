using System.Security.Cryptography;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Data;
using MySql.Data.MySqlClient;
using LostWoods.Models;
using LostWoods.Properties;
using Microsoft.Extensions.Options;

namespace LostWoods.Factory
{
    public class TrailFactory
    {
        private MySqlOptions _options;
               
        public TrailFactory(IOptions<MySqlOptions> config)
        {
            _options = config.Value;
        }
        internal IDbConnection Connection
        {
            get {
                return new MySqlConnection(_options.ConnectionString);
            }
        }
        
        public void Add(Trail item)
        {
            using(IDbConnection dbConnection = Connection){
               // string trailmap = @Trailmap;
                string query = "INSERT INTO trail (TrailName, Description, Length, ElevationGain, MaxElevation, Longitude, Latitude, TrailMap) VALUES (@TrailName, @Description, @Length, @ElevationGain, @MaxElevation, @Longitude, @Latitude, @TrailMap)";
                dbConnection.Open();
                dbConnection.Execute(query, item); 
            }
        }

        public IEnumerable<Trail> FindAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Trail>("SELECT * FROM trail").ToList();
            }
        }

        public Trail FindById(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Trail>("SELECT * FROM trail WHERE TrailId = @id", new {id = id}).FirstOrDefault();
            }
        }
    }
}