﻿#pragma checksum "..\..\..\ConstructorPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6B509C7D5F88ECCC92A16DD7B08B1CC1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
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


namespace Kristofides {
    
    
    /// <summary>
    /// ConstructorPage
    /// </summary>
    public partial class ConstructorPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 24 "..\..\..\ConstructorPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CreatePointButton;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\ConstructorPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CreateLineButton;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\ConstructorPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button OpenImageButton;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\ConstructorPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas GraphCanvas;
        
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
            System.Uri resourceLocater = new System.Uri("/Kristofides;component/constructorpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ConstructorPage.xaml"
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
            this.CreatePointButton = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\ConstructorPage.xaml"
            this.CreatePointButton.Click += new System.Windows.RoutedEventHandler(this.CreatePointButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.CreateLineButton = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\ConstructorPage.xaml"
            this.CreateLineButton.Click += new System.Windows.RoutedEventHandler(this.CreateLineButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.OpenImageButton = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\ConstructorPage.xaml"
            this.OpenImageButton.Click += new System.Windows.RoutedEventHandler(this.Open_Image);
            
            #line default
            #line hidden
            return;
            case 4:
            this.GraphCanvas = ((System.Windows.Controls.Canvas)(target));
            
            #line 28 "..\..\..\ConstructorPage.xaml"
            this.GraphCanvas.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Canvas_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

