using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHSDC.Common.Configurations
{
    /// <summary>
    /// This class defines Database constants
    /// </summary>
    /// <remarks>
    /// The properties are self explanatory and can be changed as per requirement.
    /// </remarks>
    public class EF
    {
        //public const string DatabaseName = Application.Abbreviation + "AA7DB";
        public const string DatabaseName = "aa7data";
        public const string DatabaseSchema = Application.Abbreviation;
        public const string DatabaseServer = "192.168.10.63";
        public const string DatabaseUsername = "sa";
        public const string DatabasePassword = "Admin@2018";
        //public const string DatabaseServer = "TESTSERVER\\SQLEXPRESS";
        //public const string DatabaseUsername = "USER1";
        //public const string DatabasePassword = "Admin@2018";



    }
}
