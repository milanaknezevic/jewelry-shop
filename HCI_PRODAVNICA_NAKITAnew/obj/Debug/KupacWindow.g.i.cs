﻿#pragma checksum "..\..\KupacWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F5E77CC8E5D2D88391F6A57BD7CB2AAAECC90E0E50C5C0761E404EEFF0E10233"
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
    /// KupacWindow
    /// </summary>
    public partial class KupacWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\KupacWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button nazadButton;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\KupacWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button postavkeKupcaButton;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\KupacWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button kupiButton;
        
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
            System.Uri resourceLocater = new System.Uri("/HCI_PRODAVNICA_NAKITAnew;component/kupacwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\KupacWindow.xaml"
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
            this.nazadButton = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\KupacWindow.xaml"
            this.nazadButton.Click += new System.Windows.RoutedEventHandler(this.nazadButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.postavkeKupcaButton = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\KupacWindow.xaml"
            this.postavkeKupcaButton.Click += new System.Windows.RoutedEventHandler(this.postavkeKupcaButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.kupiButton = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
