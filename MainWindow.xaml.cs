using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace Delegates_Lambas_Events
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<ContentCreator> _creators = new List<ContentCreator>();
        public List<User> _users = new List<User>();


        public MainWindow()
        {
            InitializeComponent();
            lbCreators.ItemsSource = _creators;
            lbUsers.ItemsSource = _users;
            PopulateLists();

            //ContentCreator jazza = new ContentCreator("Jazza");

            //User will = new User("Will");


            //SubscriberService.Subscribe(jazza, will, rtbDisplay);

            //jazza.PuttingOutNewContent(rtbDisplay);

        }

        private void btnSubscribe_Click(object sender, RoutedEventArgs e)
        {
            ContentCreator cc = (ContentCreator)lbCreators.SelectedItem;
            User user = (User)lbUsers.SelectedItem;

            SubscriberService.Subscribe(cc, user, rtbDisplay);
        }

        private void btnUnsubscribe_Click(object sender, RoutedEventArgs e)
        {
            ContentCreator cc = (ContentCreator)lbCreators.SelectedItem;
            User user = (User)lbUsers.SelectedItem;

            SubscriberService.Unsubscribe(cc, user);
        }



        public void PopulateLists()
        {
            _creators.Add(new ContentCreator("Jazza"));
            _users.Add(new User("Will"));
        }

        private void btnNewContent_Click(object sender, RoutedEventArgs e)
        {
            ContentCreator cc = (ContentCreator)lbCreators.SelectedItem;

            cc.PuttingOutNewContent(rtbDisplay);
        }

        private void btnNewCreator_Click(object sender, RoutedEventArgs e)
        {
            _creators.Add(new ContentCreator(txtCreator.Text));

            lbCreators.Items.Refresh();
        }

        private void btnNewUser_Click(object sender, RoutedEventArgs e)
        {
            _users.Add(new User(txtUserName.Text));

            lbUsers.Items.Refresh();
        }
    }
}
