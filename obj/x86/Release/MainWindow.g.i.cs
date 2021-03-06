﻿#pragma checksum "..\..\..\MainWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E32E329D03553CF669A4FEC149396EB4"
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
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem ResearchMenuItem;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem NewGraphMenuItem;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem OpenNewGraphMenuItem;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem SaveGraphMenuItem;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem GraphConstructorMenuItem;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem NewGraphConstructorMenuItem;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem OpenGraphConstructorMenuItem;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem SaveGraphConstructorMenuItem;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem isShowMatrix;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem isShowGraph;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame MainContent;
        
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
            System.Uri resourceLocater = new System.Uri("/Kristofides;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
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
            this.ResearchMenuItem = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 2:
            this.NewGraphMenuItem = ((System.Windows.Controls.MenuItem)(target));
            
            #line 15 "..\..\..\MainWindow.xaml"
            this.NewGraphMenuItem.Click += new System.Windows.RoutedEventHandler(this.MenuItemNewGraph_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.OpenNewGraphMenuItem = ((System.Windows.Controls.MenuItem)(target));
            
            #line 16 "..\..\..\MainWindow.xaml"
            this.OpenNewGraphMenuItem.Click += new System.Windows.RoutedEventHandler(this.MenuItemOpenGraph_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.SaveGraphMenuItem = ((System.Windows.Controls.MenuItem)(target));
            
            #line 17 "..\..\..\MainWindow.xaml"
            this.SaveGraphMenuItem.Click += new System.Windows.RoutedEventHandler(this.MenuItemSaveGraph_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.GraphConstructorMenuItem = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 6:
            this.NewGraphConstructorMenuItem = ((System.Windows.Controls.MenuItem)(target));
            
            #line 20 "..\..\..\MainWindow.xaml"
            this.NewGraphConstructorMenuItem.Click += new System.Windows.RoutedEventHandler(this.MenuItemNewGraphConstructor_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.OpenGraphConstructorMenuItem = ((System.Windows.Controls.MenuItem)(target));
            
            #line 21 "..\..\..\MainWindow.xaml"
            this.OpenGraphConstructorMenuItem.Click += new System.Windows.RoutedEventHandler(this.MenuItemOpenGraphConstructor_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.SaveGraphConstructorMenuItem = ((System.Windows.Controls.MenuItem)(target));
            
            #line 22 "..\..\..\MainWindow.xaml"
            this.SaveGraphConstructorMenuItem.Click += new System.Windows.RoutedEventHandler(this.MenuItemSaveGraph_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.isShowMatrix = ((System.Windows.Controls.MenuItem)(target));
            
            #line 26 "..\..\..\MainWindow.xaml"
            this.isShowMatrix.Click += new System.Windows.RoutedEventHandler(this.ViewEdit_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.isShowGraph = ((System.Windows.Controls.MenuItem)(target));
            
            #line 27 "..\..\..\MainWindow.xaml"
            this.isShowGraph.Click += new System.Windows.RoutedEventHandler(this.ViewEdit_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 30 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItemAbout_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.MainContent = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

