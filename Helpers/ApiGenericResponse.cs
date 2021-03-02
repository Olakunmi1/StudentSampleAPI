using System;
using System.Collections.Generic;

namespace StudentSampleAPI.Helpers
{
    public class ApiGenericResponse<T>
    {
        public bool Success { get; set; }

        public string Message { get; set; }

        public T Result { get; set; }

        public List<T> Results { get; set; }
    }
}
