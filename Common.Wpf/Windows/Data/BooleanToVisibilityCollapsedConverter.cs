﻿// Copyright (c) Converter Systems LLC. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Workstation.Windows.Data
{
    /// <summary>
    /// Returns Visibility.Collapsed if Value equals true
    /// </summary>
    [ValueConversion(typeof(bool), typeof(Visibility))]
    public class BooleanToVisibilityCollapsedConverter : ValueConverter<bool, Visibility>
    {
        protected override Visibility Convert(bool value, object parameter, CultureInfo culture)
        {
            return value ? Visibility.Collapsed : Visibility.Visible;
        }
    }
}