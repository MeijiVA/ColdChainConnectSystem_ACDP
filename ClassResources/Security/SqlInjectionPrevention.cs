using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace ColdChainConnectSystem_ACDP.ClassResources.Connection
{
    /// <summary>
    /// Provides methods to prevent SQL injection attacks
    /// </summary>
    public static class SqlInjectionPrevention
    {
        /// <summary>
        /// Sanitizes a string input to prevent SQL injection
        /// </summary>
        /// <param name="input">The input string to sanitize</param>
        /// <returns>Sanitized string safe for use in SQL queries</returns>
        public static string SanitizeInput(string input)
        {
            if (string.IsNullOrEmpty(input))
                return string.Empty;

            // Remove or escape dangerous SQL characters
            // Remove single quotes, semicolons, comment markers, etc.
            string sanitized = input.Replace("'", "''"); // Escape single quotes
            sanitized = sanitized.Replace(";", ""); // Remove semicolons
            sanitized = sanitized.Replace("--", ""); // Remove SQL comments
            sanitized = sanitized.Replace("/*", ""); // Remove block comment start
            sanitized = sanitized.Replace("*/", ""); // Remove block comment end
            sanitized = sanitized.Replace("xp_", ""); // Remove extended procedure prefix
            sanitized = sanitized.Replace("sp_", ""); // Remove stored procedure prefix
            sanitized = sanitized.Replace("exec", ""); // Remove exec keyword
            sanitized = sanitized.Replace("execute", ""); // Remove execute keyword
            sanitized = sanitized.Replace("union", ""); // Remove union keyword
            sanitized = sanitized.Replace("select", ""); // Remove select keyword
            sanitized = sanitized.Replace("insert", ""); // Remove insert keyword
            sanitized = sanitized.Replace("update", ""); // Remove update keyword
            sanitized = sanitized.Replace("delete", ""); // Remove delete keyword
            sanitized = sanitized.Replace("drop", ""); // Remove drop keyword
            sanitized = sanitized.Replace("create", ""); // Remove create keyword
            sanitized = sanitized.Replace("alter", ""); // Remove alter keyword
            sanitized = sanitized.Replace("truncate", ""); // Remove truncate keyword

            // Remove common SQL injection patterns
            Regex regex = new Regex(@"(?i)(\b(OR|AND)\s+\d+\s*=\s*\d+\b)", RegexOptions.IgnoreCase);
            sanitized = regex.Replace(sanitized, "");

            return sanitized.Trim();
        }

        /// <summary>
        /// Validates if a string contains potentially dangerous SQL injection patterns
        /// </summary>
        /// <param name="input">The input string to validate</param>
        /// <returns>True if input appears safe, False if potentially dangerous</returns>
        public static bool IsSafeInput(string input)
        {
            if (string.IsNullOrEmpty(input))
                return true;

            // Check for common SQL injection patterns
            string[] dangerousPatterns = {
                "'", "';", "--", "/*", "*/", "xp_", "sp_",
                "exec", "execute", "union", "select", "insert",
                "update", "delete", "drop", "create", "alter",
                "truncate", "script", "<", ">", "&lt;", "&gt;"
            };

            string lowerInput = input.ToLower();
            foreach (string pattern in dangerousPatterns)
            {
                if (lowerInput.Contains(pattern.ToLower()))
                {
                    return false;
                }
            }

            // Check for SQL injection patterns like ' OR '1'='1
            Regex sqlInjectionPattern = new Regex(@"(\b(OR|AND)\s+['""]?\d+['""]?\s*=\s*['""]?\d+['""]?\b)", RegexOptions.IgnoreCase);
            if (sqlInjectionPattern.IsMatch(input))
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Adds a parameter to a SqlCommand with proper sanitization
        /// </summary>
        /// <param name="command">The SqlCommand to add the parameter to</param>
        /// <param name="parameterName">The name of the parameter (e.g., "@paramName")</param>
        /// <param name="value">The value to assign to the parameter</param>
        public static void AddParameter(SqlCommand command, string parameterName, object value)
        {
            if (value == null || value == DBNull.Value)
            {
                command.Parameters.AddWithValue(parameterName, DBNull.Value);
            }
            else if (value is string)
            {
                string stringValue = value.ToString();
                // Only sanitize if it's not already a parameterized value
                if (!stringValue.StartsWith("@"))
                {
                    stringValue = SanitizeInput(stringValue);
                }
                command.Parameters.AddWithValue(parameterName, stringValue);
            }
            else
            {
                command.Parameters.AddWithValue(parameterName, value);
            }
        }

        /// <summary>
        /// Creates a safe LIKE clause parameter for SQL queries
        /// </summary>
        /// <param name="searchTerm">The search term to use in LIKE clause</param>
        /// <returns>Sanitized search term safe for LIKE queries</returns>
        public static string SanitizeLikeInput(string searchTerm)
        {
            if (string.IsNullOrEmpty(searchTerm))
                return string.Empty;

            // Sanitize the input
            string sanitized = SanitizeInput(searchTerm);
            
            // Escape SQL wildcards if needed (but keep % for LIKE queries)
            // Remove dangerous characters but allow % and _ for LIKE patterns
            sanitized = sanitized.Replace("[", "[[]"); // Escape brackets for SQL Server
            sanitized = sanitized.Replace("]", "[]]"); // Escape brackets for SQL Server

            return sanitized;
        }
    }
}

