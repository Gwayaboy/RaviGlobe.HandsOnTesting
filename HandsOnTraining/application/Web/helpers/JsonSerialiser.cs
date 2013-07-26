using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using RaviDataGlobe.HandsOnTraining.Core.Domain;

namespace RaviDataGlobe.HandsOnTraining.Web.helpers
{
    public static class JsonSerialiser
    {
        public static string ToJsonArray(this IEnumerable<Task> tasks)
        {
            var sb = new StringBuilder("[");

            foreach (var task in tasks)
            {
                sb.AppendFormat("{{ Description : '{0}',", task.Description);
                sb.AppendFormat("   Expires: '{0:dd/mm/yyyy}',", task.Expires);
                sb.AppendFormat("   IsCompleted : '{0}'}},", task.IsCompleted);
            }

            sb.Append("]");

            return sb.ToString();
        }


        //public static string ToJsonArray<T>(this IEnumerable<T> items)
        //{
        //    var sb = new StringBuilder("[");

        //    var properties = typeof (T).GetProperties();

        //    foreach (var item in items)
        //    {
        //        foreach (var property in properties)
        //        {
                    
        //        }
        //    }
        //}
    }
}