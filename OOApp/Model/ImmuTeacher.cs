using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOApp.Model
{
    /// <summary>
    /// Poco class with immutable properties (get only).
    /// (Plain Old Clr Object)
    /// </summary>
    internal class ImmuTeacher
    {
        public int Id { get; }
        public string? Firstname { get; }
        public string? Lastname { get; }

    public ImmuTeacher()
        {

        }

        public ImmuTeacher(int id, string firstname, string lastname)
        {
            Id = id;
            Firstname = firstname;
            Lastname = lastname;
        }
    }
}
