using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10XamarinForms.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        ViewToViewDemo,
        BindingModeDemo,
        ListViewDemo,
        PickerDemo
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
