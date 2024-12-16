using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Exceptions
{
    public class EntityNotFoundException:Exception
    {
        public EntityNotFoundException(string entityName, int id):base($"{entityName} with ID {id} was not found."){}
    }

    public class ValidationException:Exception
    {
        public ValidationException(string message):base(message){}
    }
}