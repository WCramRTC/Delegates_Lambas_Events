using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;

namespace Delegates_Lambas_Events
{
    public class ContentCreator
    {

        private string _name;

        public string Name { get => _name; set => _name = value; }

        // Step 1: Make the Delegate
        public delegate void NotifyUsers(string name, Run display);
        // Step 2: Make the event
        public event NotifyUsers NewContent;


        public ContentCreator(string name)
        {
            _name = name;
        } // ContentCreator

        public void PuttingOutNewContent(Run rtb)
        {
            rtb.Text = _name + " has some new content!\n";

            // Step 3: Raise the event
            NewContent?.Invoke(_name, rtb);
        }

        public override string? ToString()
        {
            return _name;
        }
    }  // class

} // namespace
