﻿#pragma checksum "..\..\..\UserControls\AppsViewerUC.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A943231DDE907C501665EA675133A1AE66AF73E05A9366DD3689BF3D7792B19E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using WindowsStoreClone.UserControls;


namespace WindowsStoreClone.UserControls {
    
    
    /// <summary>
    /// AppsViewerUC
    /// </summary>
    public partial class AppsViewerUC : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\UserControls\AppsViewerUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ScrollLeftButton;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\UserControls\AppsViewerUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ScrollViewer AppsScrollView;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\UserControls\AppsViewerUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ItemsControl AppsList;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\UserControls\AppsViewerUC.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ScrollRightButton;
        
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
            System.Uri resourceLocater = new System.Uri("/WindowsStoreClone;component/usercontrols/appsvieweruc.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\UserControls\AppsViewerUC.xaml"
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
            this.ScrollLeftButton = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\UserControls\AppsViewerUC.xaml"
            this.ScrollLeftButton.Click += new System.Windows.RoutedEventHandler(this.ScrollLeftButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.AppsScrollView = ((System.Windows.Controls.ScrollViewer)(target));
            return;
            case 3:
            this.AppsList = ((System.Windows.Controls.ItemsControl)(target));
            return;
            case 4:
            this.ScrollRightButton = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\UserControls\AppsViewerUC.xaml"
            this.ScrollRightButton.Click += new System.Windows.RoutedEventHandler(this.ScrollRightButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
