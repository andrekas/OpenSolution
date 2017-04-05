﻿using Open.Aids;
using Open.Archetypes.BaseClasses;

namespace Open.Archetypes.PartyClasses
{
    public class EmailAddress: TemporalEntity

    {
    private string email;

    public string Email
    {
        get { return Str.EmptyIfNull(email); }
        set { email = value; }
    }
    }
}