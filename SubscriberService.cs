using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.DirectoryServices;
using System.Windows;

namespace Delegates_Lambas_Events
{
    internal class SubscriberService
    {

        public static void Subscribe(ContentCreator creator, User subscriber, Run display )
        {
            
            creator.NewContent += subscriber.UpdateMe;
            MessageBox.Show(subscriber.Name + " just subscribed to " + creator.Name);

        }

        public static void Unsubscribe(ContentCreator creator, User subscriber)
        {
            creator.NewContent -= subscriber.UpdateMe;
            MessageBox.Show(subscriber.Name + " just unsubscribed to " + creator.Name);
        }

    }
}
