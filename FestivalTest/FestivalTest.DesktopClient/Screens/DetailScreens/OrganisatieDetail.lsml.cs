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
    public partial class OrganisatieDetail
    {
        partial void Organisatie_Loaded(bool succeeded)
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Organisatie);
        }

        partial void Organisatie_Changed()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Organisatie);
        }

        partial void OrganisatieDetail_Saved()
        {
            // Write your code here.
            this.SetDisplayNameFromEntity(this.Organisatie);
        }
    }
}