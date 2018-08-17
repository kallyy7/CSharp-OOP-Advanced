namespace Stealer
{
    using System;
    using System.Linq;
    using System.Reflection;

    public class Spy
    {
        public string StealFieldInfo(string investigatedClass, params string[] reqFields)
        {
            var type = Type.GetType(investigatedClass);

            var fields = type.GetFields(
                BindingFlags.Instance | BindingFlags.Static |
                BindingFlags.NonPublic | BindingFlags.Public);

            var classInstance = Activator
                .CreateInstance(type, new object[] { });

            string output = $"Class inder investigation: {investigatedClass}";

            foreach (var field in fields
                .Where(f => reqFields.Contains(f.Name)))
            {
                output += (Environment.NewLine, 
                    $"{field.Name} = {field.GetValue(classInstance)}");
            }

            return output;
        }
    }
}
