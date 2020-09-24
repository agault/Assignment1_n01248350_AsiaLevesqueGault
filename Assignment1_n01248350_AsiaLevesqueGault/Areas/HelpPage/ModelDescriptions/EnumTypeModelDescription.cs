using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Assignment1_n01248350_AsiaLevesqueGault.Areas.HelpPage.ModelDescriptions
{
    public class EnumTypeModelDescription : ModelDescription
    {
        public EnumTypeModelDescription()
        {
            Values = new Collection<EnumValueDescription>();
        }

        public Collection<EnumValueDescription> Values { get; private set; }
    }
}