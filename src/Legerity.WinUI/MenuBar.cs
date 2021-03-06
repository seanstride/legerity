namespace Legerity.Windows.Elements.WinUI
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Core;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Appium;
    using OpenQA.Selenium.Appium.Windows;

    /// <summary>
    /// Defines a <see cref="WindowsElement"/> wrapper for the WinUI UWP MenuBar control.
    /// </summary>
    public class MenuBar : WindowsElementWrapper
    {
        private readonly By menuBarItemsQuery = By.ClassName("Microsoft.UI.Xaml.Controls.MenuBarItem");

        /// <summary>
        /// Initializes a new instance of the <see cref="MenuBar"/> class.
        /// </summary>
        /// <param name="element">
        /// The <see cref="WindowsElement"/> reference.
        /// </param>
        public MenuBar(WindowsElement element)
            : base(element)
        {
        }

        /// <summary>
        /// Gets the UI components associated with the menu items.
        /// </summary>
        public IEnumerable<MenuBarItem> MenuItems =>
            this.Element.FindElements(this.menuBarItemsQuery)
                .Select(element => new MenuBarItem(this, element as WindowsElement));

        /// <summary>
        /// Allows conversion of a <see cref="WindowsElement"/> to the <see cref="MenuBar"/> without direct casting.
        /// </summary>
        /// <param name="element">
        /// The <see cref="WindowsElement"/>.
        /// </param>
        /// <returns>
        /// The <see cref="MenuBar"/>.
        /// </returns>
        public static implicit operator MenuBar(WindowsElement element)
        {
            return new MenuBar(element);
        }

        /// <summary>
        /// Allows conversion of a <see cref="AppiumWebElement"/> to the <see cref="MenuBar"/> without direct casting.
        /// </summary>
        /// <param name="element">
        /// The <see cref="AppiumWebElement"/>.
        /// </param>
        /// <returns>
        /// The <see cref="MenuBar"/>.
        /// </returns>
        public static implicit operator MenuBar(AppiumWebElement element)
        {
            return new MenuBar(element as WindowsElement);
        }

        /// <summary>
        /// Clicks on a child menu option with the specified item name.
        /// </summary>
        /// <param name="name">
        /// The name of the item to click.
        /// </param>
        /// <returns>
        /// The clicked <see cref="MenuBarItem"/>.
        /// </returns>
        public MenuBarItem ClickOption(string name)
        {
            MenuBarItem item = this.MenuItems.FirstOrDefault(
                element => element.Element.GetAttribute("Name")
                    .Equals(name, StringComparison.CurrentCultureIgnoreCase));
            item.Click();
            return item;
        }
    }
}