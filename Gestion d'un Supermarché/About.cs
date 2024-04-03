﻿using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Gestion_d_un_Supermarché
{
    partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            Text = String.Format("About {0}", AssemblyTitle);
            labelProductName.Text = AssemblyProduct;
            labelVersion.Text = String.Format("Version {0}", AssemblyVersion);
            labelCopyright.Text = AssemblyCopyright;
            labelCompanyName.Text = AssemblyCompany;
            textBoxDescription.Text = AssemblyDescription;
        }

        #region Assembly Attribute Accessors

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

        void ModeCS()
        {
            if (!(bool)Properties.Settings.Default["ModeSombre"])
            {
                BackColor = Color.White;
                textBoxDescription.ForeColor = Color.Black;
                textBoxDescription.BackColor = Color.White;
                okButton.ForeColor = Color.Black;
                okButton.BackColor = Color.White;
                okButton.FlatAppearance.BorderColor = Color.Black;
                foreach (Control control in tableLayoutPanel.Controls)
                {
                    if (control is Label) control.ForeColor = Color.Black;
                }
            }
            else
            {
                BackColor = Color.Black;
                textBoxDescription.ForeColor = Color.White;
                textBoxDescription.BackColor = Color.Black;
                okButton.ForeColor = Color.White;
                okButton.BackColor = Color.Black;
                okButton.FlatAppearance.BorderColor = Color.White;
                foreach (Control control in tableLayoutPanel.Controls)
                {
                    if (control is Label) control.ForeColor = Color.White;
                }
            }
        }

        private void AboutBox1_Load(object sender, EventArgs e)
        {
            ModeCS();
        }
    }
}
