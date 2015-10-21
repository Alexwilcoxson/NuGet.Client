// <auto-generated />
namespace NuGet.ProjectModel
{
    using System.Globalization;
    using System.Reflection;
    using System.Resources;

    internal static class Strings
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("NuGet.ProjectModel.Strings", typeof(Strings).GetTypeInfo().Assembly);

        /// <summary>
        /// Error loading lock file: {0}
        /// </summary>
        internal static string Log_ErrorReadingLockFile
        {
            get { return GetString("Log_ErrorReadingLockFile"); }
        }

        /// <summary>
        /// Error loading lock file: {0}
        /// </summary>
        internal static string FormatLog_ErrorReadingLockFile(object p0)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Log_ErrorReadingLockFile"), p0);
        }

        /// <summary>
        /// Error reading {0} : {1}
        /// </summary>
        internal static string Log_ErrorReadingProjectJson
        {
            get { return GetString("Log_ErrorReadingProjectJson"); }
        }

        /// <summary>
        /// Error reading {0} : {1}
        /// </summary>
        internal static string FormatLog_ErrorReadingProjectJson(object p0, object p1)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Log_ErrorReadingProjectJson"), p0, p1);
        }

        /// <summary>
        /// Error reading {0} at line {1} column {2} : {3}
        /// </summary>
        internal static string Log_ErrorReadingProjectJsonWithLocation
        {
            get { return GetString("Log_ErrorReadingProjectJsonWithLocation"); }
        }

        /// <summary>
        /// Error reading {0} at line {1} column {2} : {3}
        /// </summary>
        internal static string FormatLog_ErrorReadingProjectJsonWithLocation(object p0, object p1, object p2, object p3)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("Log_ErrorReadingProjectJsonWithLocation"), p0, p1, p2, p3);
        }

        private static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name);

            System.Diagnostics.Debug.Assert(value != null);

            if (formatterNames != null)
            {
                for (var i = 0; i < formatterNames.Length; i++)
                {
                    value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
                }
            }

            return value;
        }
    }
}
