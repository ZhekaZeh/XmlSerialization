using System;

namespace XmlSerialization
{
    internal class Core
    {
        #region Private fields

        private readonly Deserializer<User[]> _deserializer;
        private readonly Serializer<User[]> _serializer;
        private User[] _users;

        #endregion

        #region Constructors

        public Core()
        {
            _users = new User[Const.NumberOfUsers];
            _serializer = new Serializer<User[]>();
            _deserializer = new Deserializer<User[]>();
        }

        #endregion

        #region Private methods

        private void GenerateUsers()
        {
            for (int i = 0; i < Const.NumberOfUsers; i++)
            {
                _users[i] = new User(ToString() + i, i + 30);
            }
        }

        #endregion

        #region Public methods

        public void SerializeToXml()
        {
            GenerateUsers();
            _serializer.Serialize(_users);
        }

        public void DeserializeXmlToObject()
        {
            _users = _deserializer.Deserialize();
        }

        public void ShowUsersInfo()
        {
            foreach (var user in _users)
            {
                Console.WriteLine(@"Name: {0}, Age:{1}", user.Name, user.Age);   
            }
        }
        #endregion
    }
}