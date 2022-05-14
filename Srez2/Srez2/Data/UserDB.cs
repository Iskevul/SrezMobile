using System.Collections.Generic;
using SQLite;
using Srez2.Model;
using Srez2.Pages;
using Srez2;
using Srez2.Data;

namespace Srez2.Data
{
    public class UserDB
    {
        SQLiteConnection database;
        public UserDB(string databasePath)
        {
            database = new SQLiteConnection(databasePath);
            database.CreateTable<Project>();
            database.CreateTable<User>();
        }

        //Project-----------------------------------
        public Project GetProject(int id)
        {
            return database.Get<Project>(id);
        }
        public int DeleteProject(int id)
        {
            return database.Delete<Project>(id);
        }
        public int SaveProject(Project item)
        {
            if (item.Id != 0)
            {
                database.Update(item);
                return item.Id;
            }
            else
            {
                return database.Insert(item);
            }
        }
        public IEnumerable<Project> GetProjects()
        {
            return database.Table<Project>().ToList();
        }

        //User---------------------------------------------

        public User GetUser(int id)
        {
            return database.Get<User>(id);
        }
        public int DeleteUser(int id)
        {
            return database.Delete<User>(id);
        }
        public int SaveUser(User item)
        {
            if (item.Id != 0)
            {
                database.Update(item);
                return item.Id;
            }
            else
            {
                return database.Insert(item);
            }
        }
        public IEnumerable<User> GetUsers()
        {
            return database.Table<User>().ToList();
        }
    }
}
