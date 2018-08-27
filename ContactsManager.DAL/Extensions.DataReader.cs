using System;
using System.Data;

namespace ContactsManager.DAL
{
    public static class Extensions
    {
        /// <summary>
        /// Méthode d'extension pour gérer les champs nulls de type date
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="indexColonne"></param>
        /// <returns></returns>
        public static DateTime? GetNullableDateTime(this IDataReader reader, int indexColonne)
        {
            return reader.IsDBNull(indexColonne)
                           ? (DateTime?)null
                           : reader.GetDateTime(indexColonne);
        }

        /// <summary>
        /// Méthode d'extension pour gérer les champs nulls de type string
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="indexColonne"></param>
        /// <returns></returns>
        public static string GetNullableString(this IDataReader reader, int indexColonne)
        {
            return reader.IsDBNull(indexColonne)
                           ? (string)null
                           : reader.GetString(indexColonne);
        }
    }
}
