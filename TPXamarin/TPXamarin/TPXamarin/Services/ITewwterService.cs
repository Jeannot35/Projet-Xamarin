using System;
using System.Collections.Generic;
using System.Text;
using TPXamarin.Entities;

namespace TPXamarin.Services
{
    public interface ITewwterService
    {
        String Authenticate(User user);

        List<Tweet> Tweets { get;  }
    }
}
