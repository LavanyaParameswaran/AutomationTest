using NUnit.Framework;
using System;

namespace Com_Test_Lavanya
{
    public class UserCredentials
    {
        public static string GetVariableValue(string variableName)
        {
            return TestContext.Parameters[variableName] != null ? TestContext.Parameters[variableName] : Environment.GetEnvironmentVariable(variableName);
        }
    }
}
