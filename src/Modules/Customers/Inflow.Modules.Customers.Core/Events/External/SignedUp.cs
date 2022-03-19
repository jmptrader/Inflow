using System;
using Inflow.Shared.Abstractions.Contracts;
using Inflow.Shared.Abstractions.Events;
using Inflow.Shared.Abstractions.Messaging;

namespace Inflow.Modules.Customers.Core.Events.External;

[Message("users")]
internal record SignedUp(Guid UserId, string Email, string Role) : IEvent;


internal class SignedUpContract : Contract<SignedUp>
{
    public SignedUpContract()
    {
        RequireAll();
    }
}