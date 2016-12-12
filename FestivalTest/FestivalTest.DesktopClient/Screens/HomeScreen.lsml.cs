using Microsoft.LightSwitch.Presentation.Extensions;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch.Framework.Client;
using Microsoft.LightSwitch;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.IO;
using System.Linq;
using System;

namespace LightSwitchApplication
{
    public partial class HomeScreen
    {
        partial void Inloggen_Execute()
        {
            // Write your code here.
            
        }

        partial void Method_Execute()
        {
            // Write your code here.
            Application.ShowCreateNewBezoeker();
        }

        partial void KoopTicket_Execute()
        {
            // Write your code here.
            Application.ShowTicketsSetListDetail();

        }
    }
}