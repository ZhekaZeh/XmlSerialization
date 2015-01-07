namespace XmlSerialization
{
    public class User
    {
        #region Constructors

        /// <summary>
        /// Constructor have to be explicitly called for XmlSerialization.
        /// </summary>
        public User()
        {
        }

        public User(string name, int age)
        {
            Name = name;
            Age = age;
        }

        #endregion

        #region Properties

        public string Name { get; set; }
        public int Age { get; set; }

        #endregion
    }
}
//NataliComment2inUser