namespace Attributes
{
    using System.Linq;
    using System.Reflection;

    public class Tracker
    {
        public string PrintMethodsByAuthor()
        {
            var type = typeof(StartUp);
            var methods = type.GetMethods(
                BindingFlags.Instance | BindingFlags.Static |
                BindingFlags.Public);
            string output = null;

            foreach (var m in methods)
            {
                if (m.CustomAttributes
                    .Any(n => n.AttributeType == typeof(SoftUniAttribute)))
                {
                    var attrs = m.GetCustomAttributes(false);
                    foreach (SoftUniAttribute a in attrs)
                    {
                        output += $"{m.Name} is written by {a.Name}";
                    }
                }
            }
            return output;
        }	
    }
}