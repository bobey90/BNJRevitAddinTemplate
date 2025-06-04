using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BNJRevitAddinTemplate.Properties
{
    public partial class Resources : Component
    {
        public Resources()
        {
            InitializeComponent();
        }

        public Resources(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
