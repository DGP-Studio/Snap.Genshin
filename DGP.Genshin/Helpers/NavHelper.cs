﻿using System;
using System.Windows;

namespace DGP.Genshin.Helpers
{
    public class NavHelper
    {
        public static Type GetNavigateTo(ModernWpf.Controls.NavigationViewItem item) => (Type)item.GetValue(NavigateToProperty);

        public static void SetNavigateTo(ModernWpf.Controls.NavigationViewItem item, Type value) => item.SetValue(NavigateToProperty, value);

        public static readonly DependencyProperty NavigateToProperty =
            DependencyProperty.RegisterAttached("NavigateTo", typeof(Type), typeof(NavHelper), new PropertyMetadata(null));
    }
}
