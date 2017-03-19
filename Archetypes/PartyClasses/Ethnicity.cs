using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Open.Aids;
using Open.Archetypes.BaseClasses;


namespace Open.Archetypes.PartyClasses
{
    public class Ethnicity: Archetype

    {
    private string name;
    private string description;

    public string Name
    {
        get { return Str.EmptyIfNull(name); }
        set { name = value; }
    }

    public string Description
    {
        get { return Str.EmptyIfNull(description); }
        set { description = value; }
    }
    }
}
