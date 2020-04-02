using Module3_Demo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Module3_Demo.Services
{
    public interface ITwitterService
{
        String Authenticate(User user);

        List<Tweet> Tweets { get; }
}
}
