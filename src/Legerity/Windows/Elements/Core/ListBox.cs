namespace Legerity.Windows.Elements.Core
{
    using System;
    using System.Collections.ObjectModel;
    using System.Linq;
    using Legerity.Windows.Extensions;

    using OpenQA.Selenium;
    using OpenQA.Selenium.Appium;
    using OpenQA.Selenium.Appium.Windows;

    /// <summary>
    /// Defines a <see cref="WindowsElement"/> wrapper for the core UWP ListBox control.
    /// </summary>
    public class ListBox : WindowsElementWrapper
    {
        private readonly By listBoxItemQuery = By.ClassName("ListBoxItem");

        /// <summary>
        /// Initializes a new instance of the <see cref="ListBox"/> class.
        /// </summary>
        /// <param name="element">
        /// The <see cref="WindowsElement"/> reference.
        /// </param>
        public ListBox(WindowsElement element)
            : base(element)
        {
        }

        /// <summary>
        /// Gets the collection of items associated with the list box.
        /// </summary>
        public ReadOnlyCollection<AppiumWebElement> Items => this.Element.FindElements(this.listBoxItemQuery);

        /// <summary>
        /// Gets the element associated with the currently selected item.
        /// </summary>
        public AppiumWebElement SelectedItem =>
            this.Items.FirstOrDefault(
                i => i.GetAttribute("SelectionItem.IsSelected").Equals(
                    "True",
                    StringComparison.CurrentCultureIgnoreCase));

        /// <summary>
        /// Allows conversion of a <see cref="WindowsElement"/> to the <see cref="ListBox"/> without direct casting.
        /// </summary>
        /// <param name="element">
        /// The <see cref="WindowsElement"/>.
        /// </param>
        /// <returns>
        /// The <see cref="ListBox"/>.
        /// </returns>
        public static implicit operator ListBox(WindowsElement element)
        {
            return new ListBox(element);
        }

        /// <summary>
        /// Allows conversion of a <see cref="AppiumWebElement"/> to the <see cref="ListBox"/> without direct casting.
        /// </summary>
        /// <param name="element">
        /// The <see cref="AppiumWebElement"/>.
        /// </param>
        /// <returns>
        /// The <see cref="ListBox"/>.
        /// </returns>
        public static implicit operator ListBox(AppiumWebElement element)
        {
            return new ListBox(element as WindowsElement);
        }

        /// <summary>
        /// Clicks on an item in the list box with the specified item name.
        /// </summary>
        /// <param name="name">
        /// The name of the item to click.
        /// </param>
        public void ClickItem(string name)
        {
            this.VerifyElementsShown(this.listBoxItemQuery, TimeSpan.FromSeconds(2));

            AppiumWebElement item = this.Items.FirstOrDefault(element => element.VerifyNameOrAutomationIdEquals(name));

            item.Click();
        }
    }
}