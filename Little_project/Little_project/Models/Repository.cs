using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Little_project.Models
{
    public class Repository
    {
        private static List<GuestResponse> responses =
            new List<GuestResponse>();
        public static IEnumerable<GuestResponse> Response
        {
            get
            {
                return responses;
            }
        }
        public static void AddResponse(GuestResponse response)
        {
            responses.Add(response);
        }
    }
}
