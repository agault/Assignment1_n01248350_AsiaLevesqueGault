using System;
using System.Reflection;

namespace Assignment1_n01248350_AsiaLevesqueGault.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}