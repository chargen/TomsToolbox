﻿namespace SampleApp.Samples
{
    using System.ComponentModel.Composition;

    using TomsToolbox.Wpf.Composition;

    /// <summary>
    /// Interaction logic for SharedWidthSampleView.xaml
    /// </summary>
    [DataTemplate(typeof(SharedWidthSampleViewModel), Role = TemplateRoles.Content)]
    [PartCreationPolicy(CreationPolicy.NonShared)]
    public partial class SharedWidthSampleView
    {
        public SharedWidthSampleView()
        {
            InitializeComponent();
        }
    }
}
