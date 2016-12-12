using Microsoft.LightSwitch.Security.Server;
using Microsoft.LightSwitch;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System;

namespace LightSwitchApplication
{
    public partial class ApplicationDataService
    {
        partial void Bezoekers_Validate(Bezoeker entity, EntitySetValidationResultsBuilder results)
        {

        }

        private int Bezoekers_Updated(bool v)
        {
            throw new NotImplementedException();
        }

        partial void Bezoekers_CanRead(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.Can_Read);
        }
    }
}