using System;
using Microsoft.Extensions.DependencyInjection;

namespace Coupling
{
    class Program
    {
        static void Main(string[]args)
        {
            var collection = new ServiceCollection();
            collection.AddScoped<IDataAcess, DataAccess>();
            collection.AddScoped<IBusiness, Business>();

            var provider = collection.BuildServiceProvider();
            IBusiness biz = provider.GetService<IBusiness>();
            var userInterface = new userInterface(biz);
        }
    }

    public class userInterface
    {
        private readonly IBusiness _business;
        public userInterface(IBusiness business)
        {
            _business = business;
        }
        public void GetData()
        {
            Console.WriteLine("Enter Ur userName:");
            var userName = Console.ReadLine();

            Console.WriteLine("Enter Ur Password:");
            var userPass = Console.ReadLine();

            _business.SignUp(userName, userPass);
        }
    }

    public class Business : IBusiness
    {
        private readonly IDataAcess _dataAcess;
        public Business(IDataAcess dataAcess)
        {
            _dataAcess = dataAcess;
        }
        public void SignUp(string userName, string password)
        {
            _dataAcess.Store(userName, password);
        }

    }

    public class BusinessV2 : IBusiness
    {
        private readonly IDataAcess _dataAcess;
        public BusinessV2(IDataAcess dataAcess)
        {
            _dataAcess = dataAcess;
        }
        public void SignUp(string userName, string password)
        {
            throw new NotImplementedException();
        }
    }


    public class DataAccess : IDataAcess
    {
        public void Store(string userName, string Password)
        {
            //write data to Db
        }
    }

    public interface IBusiness
    {
        void SignUp (string userName, string password); 
    }

    public interface IDataAcess
    {
        void Store(string userName, string password);
    }



}