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

            foreach (var f in fields
                .Where(f => reqFields.Contains(f.Name)))
            {
                output += (Environment.NewLine, 
                    $"{f.Name} = {f.GetValue(classInstance)}");
            }

            return output;
        }

        public string AnalyzeAcessModifiers(string className)
        {
            string output = null;

            var type = Type.GetType(className);
            var fields = type.GetFields(
                BindingFlags.Instance | BindingFlags.Static |
                BindingFlags.Public);

            foreach (var f in fields)
            {
                output += (Environment.NewLine, 
                    $"{f.Name} must be private!");
            }

            var propsGet = type.GetMethods(
                BindingFlags.Instance | BindingFlags.NonPublic);

            foreach (var p in propsGet
                .Where(x => x.Name.StartsWith("get")))
            {
                output += (Environment.NewLine, 
                    $"{p.Name} have to be public!");
            }

            var propsSet = type.GetMethods(
                BindingFlags.Instance | BindingFlags.Public);

            foreach (var p in propsSet
                .Where(x => x.Name.StartsWith("set")))
            {
                output += (Environment.NewLine, 
                    $"{p.Name} have to be private!");
            }

            return output;
        }

        public string RevealPrivateMethods(string className)
        {
            string output = null;

            var type = Type.GetType(className);
            var methods = type.GetMethods(
                BindingFlags.Instance | BindingFlags.NonPublic);

            output += $"All Private Methods of Class: {className}";
            output += $"Base Class: {type.BaseType.Name}";

            foreach (var m in methods)
            {
                output += (Environment.NewLine, m.Name);
            }

            return output;
        }

        public string CollectGettersAndSetters(string className)
        {
            string output = null;

            var type = Type.GetType(className);
            var methods = type.GetMethods(
                BindingFlags.Instance | BindingFlags.NonPublic | 
                BindingFlags.Public);

            foreach (var m in methods
                .Where(x => x.Name.StartsWith("get")))
            {
                output += (Environment.NewLine, 
                    $"{m.Name} will return {m.ReturnType}");
            }

            foreach (var m in methods
                .Where(x => x.Name.StartsWith("set")))
            {
                output += (Environment.NewLine, 
                    $"{m.Name} will set field of {m.GetParameters().First().ParameterType}");
            }

            return output;
        }
    }
}
