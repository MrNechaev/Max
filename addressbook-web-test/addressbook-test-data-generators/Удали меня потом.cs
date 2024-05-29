using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addressbook_test_data_generators
{
    public partial class Удали_меня_потом : Component
    {
        public Удали_меня_потом()
        {
            InitializeComponent();
        }

        public Удали_меня_потом(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
