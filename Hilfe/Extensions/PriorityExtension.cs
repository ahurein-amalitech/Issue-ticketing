﻿using Hilfe.Models;

namespace Hilfe.Extensions
{
    public static class PriorityExtension
    {
        static readonly Dictionary<Priority, string> _priorityCssClasses = new()
        {
            [Priority.High] = "badge bg-danger",
            [Priority.Medium] = "badge bg-warning text-dark",
            [Priority.Low] = "badge bg-success"
        };
         public static string ToCssClass(this Priority priority) => _priorityCssClasses[priority];
    }
}
