﻿#pragma checksum "..\..\..\Menu\MainMenu.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5AAAF3FD40DCF6A46D4D27964F6B314B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
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


namespace WPFPageSwitch {
    
    
    /// <summary>
    /// MainMenu
    /// </summary>
    public partial class MainMenu : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 52 "..\..\..\Menu\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.Animation.BeginStoryboard registerMouseEnter_BeginStoryboard;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\Menu\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.Animation.BeginStoryboard loginMouseLeave_BeginStoryboard;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\Menu\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Media.Animation.BeginStoryboard registerMouseLeave_BeginStoryboard;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\Menu\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid mainMenuLayoutRoot;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\Menu\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button newGameButton;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\Menu\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button loadGameButton;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\Menu\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button optionButton;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\Menu\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock registerTextBlock;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\Menu\MainMenu.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock loginTextBlock;
        
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
            System.Uri resourceLocater = new System.Uri("/JagoanFisika;component/menu/mainmenu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Menu\MainMenu.xaml"
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
            this.registerMouseEnter_BeginStoryboard = ((System.Windows.Media.Animation.BeginStoryboard)(target));
            return;
            case 2:
            this.loginMouseLeave_BeginStoryboard = ((System.Windows.Media.Animation.BeginStoryboard)(target));
            return;
            case 3:
            this.registerMouseLeave_BeginStoryboard = ((System.Windows.Media.Animation.BeginStoryboard)(target));
            return;
            case 4:
            this.mainMenuLayoutRoot = ((System.Windows.Controls.Grid)(target));
            return;
            case 5:
            this.newGameButton = ((System.Windows.Controls.Button)(target));
            
            #line 62 "..\..\..\Menu\MainMenu.xaml"
            this.newGameButton.Click += new System.Windows.RoutedEventHandler(this.newGameButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.loadGameButton = ((System.Windows.Controls.Button)(target));
            
            #line 63 "..\..\..\Menu\MainMenu.xaml"
            this.loadGameButton.Click += new System.Windows.RoutedEventHandler(this.loadGameButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.optionButton = ((System.Windows.Controls.Button)(target));
            
            #line 64 "..\..\..\Menu\MainMenu.xaml"
            this.optionButton.Click += new System.Windows.RoutedEventHandler(this.optionButton_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.registerTextBlock = ((System.Windows.Controls.TextBlock)(target));
            
            #line 65 "..\..\..\Menu\MainMenu.xaml"
            this.registerTextBlock.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.registerTextBlock_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 9:
            this.loginTextBlock = ((System.Windows.Controls.TextBlock)(target));
            
            #line 75 "..\..\..\Menu\MainMenu.xaml"
            this.loginTextBlock.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.loginTextBlock_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

