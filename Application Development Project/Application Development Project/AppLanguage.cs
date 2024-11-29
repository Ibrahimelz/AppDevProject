using System;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Threading;
using System.Windows.Forms;

namespace Application_Development_Project
{
    internal static class AppLanguage
    {
        public static string CurrentCulture { get; set; } = "en-CA";
        private static ResourceManager ResourceManager;

        public static void ApplyLanguage(Form form)
        {
            // Set the current thread's culture info to the selected culture
            var cultureInfo = new CultureInfo(CurrentCulture);
            Thread.CurrentThread.CurrentCulture = cultureInfo;
            Thread.CurrentThread.CurrentUICulture = cultureInfo;

            // Initialize the ResourceManager
            LoadResourceManager();

            // Localize the form and its controls
            LocalizeForm(form);
        }

        private static void LoadResourceManager()
        {
            // Load the default resource file (it will automatically handle culture variations)
            ResourceManager = new ResourceManager("Application_Development_Project.Properties.Strings", Assembly.GetExecutingAssembly());
        }

        private static void LocalizeForm(Form form)
        {
            foreach (Control control in form.Controls)
            {
                LocalizeControl(control);

                // Recursively handle nested controls (e.g., panels, group boxes)
                if (control.HasChildren)
                {
                    foreach (Control childControl in control.Controls)
                    {
                        LocalizeControl(childControl);
                    }
                }
            }
        }

        private static void LocalizeControl(Control control)
        {
            // Get the localization key from the Tag property (or use the Name as fallback)
            string localizationKey = control.Tag?.ToString() ?? control.Name;
            string localizedText = ResourceManager.GetString(localizationKey, Thread.CurrentThread.CurrentUICulture);

            if (!string.IsNullOrEmpty(localizedText))
            {
                switch (control)
                {
                    case LinkLabel linkLabel:
                        linkLabel.Text = localizedText;
                        break;
                    case Button button:
                        button.Text = localizedText;
                        break;
                    case Label label:
                        label.Text = localizedText;
                        break;
                    case ComboBox comboBox:
                        LocalizeComboBox(comboBox);
                        break;
                    case TabPage tabPage:
                        tabPage.Text = localizedText;
                        break;
                    case CheckBox checkBox:
                        checkBox.Text = localizedText;
                        break;
                    default:
                        break;
                }
            }

            // Recursively localize child controls (for containers like TabPages, Panels, etc.)
            foreach (Control child in control.Controls)
            {
                LocalizeControl(child);
            }
        }

        private static void LocalizeComboBox(ComboBox comboBox)
        {
            // Iterate through ComboBox items and apply localization if keys are provided
            for (int i = 0; i < comboBox.Items.Count; i++)
            {
                string itemKey = comboBox.Items[i].ToString();
                string localizedItem = ResourceManager.GetString(itemKey, Thread.CurrentThread.CurrentUICulture);
                if (!string.IsNullOrEmpty(localizedItem))
                {
                    comboBox.Items[i] = localizedItem;
                }
            }
        }
    }
}