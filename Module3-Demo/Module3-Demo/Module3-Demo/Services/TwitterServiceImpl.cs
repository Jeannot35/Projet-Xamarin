using Module3_Demo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Module3_Demo.Services
{
    public class TwitterServiceImpl : ITwitterService
    {
        private User user;

        public User User
        {
            get { return user; }
            set { User = value; }
        }

        public List<Tweet> Tweets
        {
            get
            {
                User user = new User() { Login = "Jean", Password = "secret" };
                return new List<Tweet>()
                {
                    new Tweet(){User = user, Data = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", CreatedAt = DateTime.Now },
                    new Tweet(){User = user, Data = "Cras porttitor condimentum vehicula. Quisque vulputate fringilla fermentum. Sed lacinia nec nisi a molestie.", CreatedAt = DateTime.Now },
                    new Tweet(){User = user, Data = "Donec convallis et tellus pretium pharetra. In rutrum, lacus sit amet rutrum interdum, ex elit posuere nisi, eu lobortis lacus odio vel tellus. Nullam ac enim sed erat mollis malesuada. Aenean dui augue, posuere eget nulla vitae.", CreatedAt = DateTime.Now },
                    new Tweet(){User = user, Data = "Duis sem eros, pharetra in sapien tincidunt, rutrum hendrerit lectus. Suspendisse in dui placerat, rutrum magna at, condimentum diam.", CreatedAt = DateTime.Now },
                    new Tweet(){User = user, Data = "Nullam eget efficitur diam. In venenatis nulla nec arcu posuere, in pellentesque justo efficitur.", CreatedAt = DateTime.Now }
                };
            }
        }

        public string Authenticate(User user)
        {
            bool haveError = false;
            StringBuilder stringBuilder = new StringBuilder();

            if (String.IsNullOrEmpty(user.Login) || user.Login.Length < 3)
            {
                haveError = true;
                stringBuilder.Append("L'identifiant ne peut être null et doit posséder au moins 3 caractères.");
            }

            if (String.IsNullOrEmpty(user.Password) || user.Password.Length < 6)
            {
                if (haveError)
                {
                    stringBuilder.Append("\n");
                }
                haveError = true;
                stringBuilder.Append("Le mot de passe ne peut être null et doit comporter au moins 6 caractères.");
            }

            if(!Tweets.Select(x => x.User).Any(x => x.Login == user.Login && x.Password == user.Password))
            {
                if (haveError)
                {
                    stringBuilder.Append("\n");
                }
                haveError = true;
                stringBuilder.Append("L'utilisateur n'existe pas.");
            }
            return stringBuilder.ToString();
        }
    }
}
