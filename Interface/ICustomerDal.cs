using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface ICustomerDal //ortak metodlar interface üzerinde tanımlanır, ikisi kendi classlarında farklı kullanılır ancak ikisi de ICustomerDal  üzerinden tanımlanır
    {
        void Add();
        void Update();
        void Delete();
    }
    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle Added");
            
            
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Updated");
        }
    }
    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("SQL ADDED");
        }

        public void Delete()
        {
            Console.WriteLine("SQL DELETED");
        }

        public void Update()
        {
            Console.WriteLine("SQL UPDATED");
        }
    }
    class CustomerManager
    {
        public void Add(ICustomerDal customerDal) // burada ADD oracle 'a göre mi yoksa SQL e göre mi yapılacak :?? biriyle yazılırsa diğerini kullanamayacağız...
            //ancak parantez içi interface bizi kurtaracaktır.. orada ne SQL ne de Oracle olacak, hangisi verilirse o uygulanacak ....
        {
            
        }
    }
}
