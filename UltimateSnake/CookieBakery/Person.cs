// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Person.cs" company="MarSim">
//   Copyright © 2012
// </copyright>
// <summary>
//   An extremely simple person DTO.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CookieBakery
{
    /// <summary>
    /// An extremely simple person DTO.
    /// </summary>
    public sealed class Person
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class.
        /// </summary>
        /// <param name="name">
        /// The name of the person to create.
        /// </param>
        public Person(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Prevents a default instance of the <see cref="Person"/> class from being created.
        /// </summary>
        private Person()
        {
        }

        /// <summary>
        /// Gets the name of the person.
        /// </summary>
        public string Name { get; private set; }
    }
}
