namespace Legerity.Windows.Elements.Core
{
    using OpenQA.Selenium.Appium;
    using OpenQA.Selenium.Appium.Windows;

    public partial class InkToolbar
    {
        /// <summary>
        /// Defines a color flyout for the pencil in the <see cref="InkToolbar"/>.
        /// </summary>
        private class InkToolbarPencilFlyout : InkToolbarColorFlyoutBase
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="Legerity.Windows.Elements.Core.InkToolbar.InkToolbarPencilFlyout"/> class.
            /// </summary>
            /// <param name="element">
            /// The <see cref="WindowsElement"/> reference.
            /// </param>
            public InkToolbarPencilFlyout(WindowsElement element)
                : base(element)
            {
            }

            /// <summary>
            /// Allows conversion of a <see cref="WindowsElement"/> to the <see cref="InkToolbarPencilFlyout"/> without direct casting.
            /// </summary>
            /// <param name="element">
            /// The <see cref="WindowsElement"/>.
            /// </param>
            /// <returns>
            /// The <see cref="InkToolbarPencilFlyout"/>.
            /// </returns>
            public static implicit operator InkToolbarPencilFlyout(WindowsElement element)
            {
                return new InkToolbarPencilFlyout(element);
            }

            /// <summary>
            /// Allows conversion of a <see cref="AppiumWebElement"/> to the <see cref="InkToolbarPencilFlyout"/> without direct casting.
            /// </summary>
            /// <param name="element">
            /// The <see cref="AppiumWebElement"/>.
            /// </param>
            /// <returns>
            /// The <see cref="InkToolbarPencilFlyout"/>.
            /// </returns>
            public static implicit operator InkToolbarPencilFlyout(AppiumWebElement element)
            {
                return new InkToolbarPencilFlyout(element as WindowsElement);
            }
        }
    }
}