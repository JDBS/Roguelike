using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roguelike.File_System.DBMS.Exception
{
    [Serializable]
    public class DBException : System.Exception
    {
        public DBException()
        {

        }
        public DBException(string message) : base(message)
        {

        }

        public DBException(string message, System.Exception inner) : base(message, inner){

        }

        protected DBException(
             System.Runtime.Serialization.SerializationInfo info,
             System.Runtime.Serialization.StreamingContext context) : base(info, context)
        { }
    }
}
