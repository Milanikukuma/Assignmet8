using GymGear.Models;
using SQLite;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace GymGear.Services
{
    public class EquipmentDatabase
    {
        private static EquipmentDatabase _instance;
        private SQLiteConnection _dbConnection;

        private EquipmentDatabase()
        {
            _dbConnection = new SQLiteConnection(GetDatabasePath());

            _dbConnection.CreateTable<Equipments>();
            _dbConnection.CreateTable<UserProfile>();
            _dbConnection.CreateTable<Cart>();

            if (_dbConnection.Table<Equipments>().Count() == 0)
            {
                InsertDefaultEquipments();
            }
        }

        public static EquipmentDatabase Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new EquipmentDatabase();
                }
                return _instance;
            }
        }
        public EquipmentDatabase(string dbPath)
        {
            _dbConnection = new SQLiteConnection(dbPath);
            _dbConnection.CreateTable<Equipments>();
            _dbConnection.CreateTable<UserProfile>();
            _dbConnection.CreateTable<Cart>();

            if (_dbConnection.Table<Equipments>().Count() == 0)
            {
                InsertDefaultEquipments();
            }
        }

        private string GetDatabasePath()
        {
            string filename = "Equipmentdata.db";
            string pathToDb = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            return System.IO.Path.Combine(pathToDb, filename);
        }

        private void InsertDefaultEquipments()
        {
            // Insert default equipment data here
        }

        public void SaveUserProfile(UserProfile userProfile)
        {
            _dbConnection.Insert(userProfile);
        }

        // Other methods for CRUD operations...

        public void SaveChanges()
        {
            // Save any pending changes to the database
        }

        internal IEnumerable<object> GetCartItems()
        {
            throw new NotImplementedException();
        }
    }
    }
