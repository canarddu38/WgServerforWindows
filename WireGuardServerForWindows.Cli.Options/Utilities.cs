﻿using System;
using System.Linq;
using CommandLine;

namespace WireGuardServerForWindows.Cli.Options
{
    /// <summary>
    /// Static utilities related to the CLI options
    /// </summary>
    public static class Utilities
    {
        /// <summary>
        /// If the given <paramref name="verbType"/> has the <see cref="VerbAttribute"/>, returns the <see cref="VerbAttribute.Name"/> value.
        /// Otherwise, returns null.
        /// </summary>
        /// <param name="verbType"></param>
        public static string GetVerb(this Type verbType)
        {
            return verbType.GetCustomAttributes(inherit: true).OfType<VerbAttribute>().FirstOrDefault()?.Name;
        }
    }
}
