namespace CookieBakery
{
    /// <summary>
    /// An extremely simple person DTO.
    /// </summary>
    public sealed class Person
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name">The name of the person to create.</param>
        public Person(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Prevents an instance of <see cref="Person" /> from being created without a name.
        /// </summary>
        private Person()
        {
        }

        /// <summary>
        /// The name of the person.
        /// </summary>
        public string Name { get; private set; }
    }
}
