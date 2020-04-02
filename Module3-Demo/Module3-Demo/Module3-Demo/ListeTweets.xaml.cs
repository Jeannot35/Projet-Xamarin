using Module3_Demo.Entities;
using Module3_Demo.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Module3_Demo
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class ListeTweets : ContentPage
{

        ObservableCollection<Tweet> tweetes = new ObservableCollection<Tweet>();
        private User user;

        public ListeTweets()
    {
        InitializeComponent();
            this.tweetes.Add(new Tweet { User = user, Data = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", CreatedAt = DateTime.Now });
            this.tweetes.Add(new Tweet { User = user, Data = "Cras porttitor condimentum vehicula. Quisque vulputate fringilla fermentum. Sed lacinia nec nisi a molestie.", CreatedAt = DateTime.Now });
            this.tweetes.Add(new Tweet { User = user, Data = "Donec convallis et tellus pretium pharetra. In rutrum, lacus sit amet rutrum interdum, ex elit posuere nisi, eu lobortis lacus odio vel tellus. Nullam ac enim sed erat mollis malesuada. Aenean dui augue, posuere eget nulla vitae.", CreatedAt = DateTime.Now });
            this.tweetes.Add(new Tweet { User = user, Data = "Duis sem eros, pharetra in sapien tincidunt, rutrum hendrerit lectus. Suspendisse in dui placerat, rutrum magna at, condimentum diam.", CreatedAt = DateTime.Now });
            this.tweetes.Add(new Tweet { User = user, Data = "Nullam eget efficitur diam. In venenatis nulla nec arcu posuere, in pellentesque justo efficitur.", CreatedAt = DateTime.Now });
        }
}
}