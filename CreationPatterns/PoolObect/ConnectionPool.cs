using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolObect
{
    public class ConnectionPool
    {
        private readonly int _maxSize;
        //пулл объектов
        private readonly List<Connection> _connections;

        //создание пула
        public ConnectionPool(int minSize,int maxSize)
        {
            _maxSize = maxSize;
            _connections = new List<Connection>();
            //создание готовых к использованию конектов
            for (int i = 0; i < minSize; i++)
            {
                var connection = new Connection();
                _connections.Add(connection);
            }
        }
        //отдаем из пула объект
        public Connection GetConnection()
        {
            //возврашает первый элемент из пула конектов который не используется
            var connection = _connections.FirstOrDefault(x => !x.isInUse);
            if (connection == null)
            {
                //создание еще одного конекта если все заранее созданные 
                //конесты isInUse() == true 
                connection = CreateConnection();
            }
            //ставим флаг isInUse() == true у нового соннекта
            connection.isInUse = true;

            return connection;
        }
        //Возврат обьекта в начальное состояние
        public void ReliseConnection(Connection connection)
        {
            //проверка если ли данный коннект в в пулле
            if (!_connections.Contains(connection))
            {
                throw new InvalidOperationException();
            }
            //возврат элемента пула в начальное состояние
            connection.isInUse = false;
        }
        //создание конекта  если все заранее созданные 
        //конесты isInUse() == true 
        private Connection CreateConnection()
        {
            //проверка на мах размер пула объектов
            if (_connections .Count == _maxSize)
            {
                throw new InvalidOperationException();
            }
            //процесс создания коннекта
            var connection = new Connection();
            _connections.Add(connection);
            return connection;
        }
    }
}
