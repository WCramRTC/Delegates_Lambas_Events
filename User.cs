using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;

namespace Delegates_Lambas_Events
{
    public class User
    {

        string _name;

        public string Name { get => _name; set => _name = value; }

        public User(string name)
        {
            _name = name;
        } // User

        public void UpdateMe(string name, Run rtb)
        {
            rtb.Text += $"{_name}! {name} has some new content\n";
        }

        public override string ToString()
        {
            return _name;
        }

    } // class

} // namespace
