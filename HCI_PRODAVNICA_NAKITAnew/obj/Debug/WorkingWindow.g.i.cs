﻿#pragma checksum "..\..\WorkingWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B761223EB328EC83EF58B7ABDE7D993972BF47626636B1871431C693285CE893"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using HCI_PRODAVNICA_NAKITAnew;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace HCI_PRODAVNICA_NAKITAnew {
    
    
    /// <summary>
    /// WorkingWindow
    /// </summary>
    public partial class WorkingWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\WorkingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid grid1;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\WorkingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button dodajNakitButton;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\WorkingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AzurirajButton;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\WorkingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button obrisiButton;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\WorkingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MojProfil;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\WorkingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock mojprofil;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\WorkingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid boze;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\WorkingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LogoutButton;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\WorkingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock logoutTextBlock;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/HCI_PRODAVNICA_NAKITAnew;component/workingwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\WorkingWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.grid1 = ((System.Windows.Controls.DataGrid)(target));
            
            #line 34 "..\..\WorkingWindow.xaml"
            this.grid1.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.grid1_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.dodajNakitButton = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\WorkingWindow.xaml"
            this.dodajNakitButton.Click += new System.Windows.RoutedEventHandler(this.dodajNakitButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.AzurirajButton = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\WorkingWindow.xaml"
            this.AzurirajButton.Click += new System.Windows.RoutedEventHandler(this.AzurirajButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.obrisiButton = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\WorkingWindow.xaml"
            this.obrisiButton.Click += new System.Windows.RoutedEventHandler(this.obrisiButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.MojProfil = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\WorkingWindow.xaml"
            this.MojProfil.Click += new System.Windows.RoutedEventHandler(this.MojProfil_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.mojprofil = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.boze = ((System.Windows.Controls.Grid)(target));
            return;
            case 8:
            this.LogoutButton = ((System.Windows.Controls.Button)(target));
            
            #line 85 "..\..\WorkingWindow.xaml"
            this.LogoutButton.Click += new System.Windows.RoutedEventHandler(this.logoutButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.logoutTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

