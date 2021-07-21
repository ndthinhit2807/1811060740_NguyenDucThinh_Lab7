using System;
using System.Reflection;

namespace _1811060740_NguyenDucThinh_Lab7.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}