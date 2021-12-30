﻿#pragma checksum "..\..\..\..\..\UI\Service\ServiceCard.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E854AC421BC05F75326BEE7CCD035603E60F700E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using HuongDuongVillage;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace HuongDuongVillage {
    
    
    /// <summary>
    /// ServiceCard
    /// </summary>
    public partial class ServiceCard : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\..\..\..\UI\Service\ServiceCard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tblName;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\..\UI\Service\ServiceCard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tblRoomName;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\..\..\UI\Service\ServiceCard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tblPrice;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\..\..\UI\Service\ServiceCard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tblType;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\..\..\UI\Service\ServiceCard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tblStatus;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\..\..\..\UI\Service\ServiceCard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button editButton;
        
        #line default
        #line hidden
        
        
        #line 103 "..\..\..\..\..\UI\Service\ServiceCard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.PackIcon editIcon;
        
        #line default
        #line hidden
        
        
        #line 117 "..\..\..\..\..\UI\Service\ServiceCard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button deleteButton;
        
        #line default
        #line hidden
        
        
        #line 125 "..\..\..\..\..\UI\Service\ServiceCard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.PackIcon deleteIcon;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/HuongDuongVillage;component/ui/service/servicecard.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\UI\Service\ServiceCard.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.tblName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.tblRoomName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.tblPrice = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.tblType = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.tblStatus = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.editButton = ((System.Windows.Controls.Button)(target));
            
            #line 100 "..\..\..\..\..\UI\Service\ServiceCard.xaml"
            this.editButton.MouseEnter += new System.Windows.Input.MouseEventHandler(this.addButton_MouseEnter);
            
            #line default
            #line hidden
            
            #line 101 "..\..\..\..\..\UI\Service\ServiceCard.xaml"
            this.editButton.MouseLeave += new System.Windows.Input.MouseEventHandler(this.addButton_MouseLeave);
            
            #line default
            #line hidden
            
            #line 101 "..\..\..\..\..\UI\Service\ServiceCard.xaml"
            this.editButton.Click += new System.Windows.RoutedEventHandler(this.editButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.editIcon = ((MaterialDesignThemes.Wpf.PackIcon)(target));
            return;
            case 8:
            this.deleteButton = ((System.Windows.Controls.Button)(target));
            
            #line 122 "..\..\..\..\..\UI\Service\ServiceCard.xaml"
            this.deleteButton.MouseEnter += new System.Windows.Input.MouseEventHandler(this.deleteButton_MouseEnter);
            
            #line default
            #line hidden
            
            #line 123 "..\..\..\..\..\UI\Service\ServiceCard.xaml"
            this.deleteButton.MouseLeave += new System.Windows.Input.MouseEventHandler(this.deleteButton_MouseLeave);
            
            #line default
            #line hidden
            
            #line 123 "..\..\..\..\..\UI\Service\ServiceCard.xaml"
            this.deleteButton.Click += new System.Windows.RoutedEventHandler(this.deleteButton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.deleteIcon = ((MaterialDesignThemes.Wpf.PackIcon)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
