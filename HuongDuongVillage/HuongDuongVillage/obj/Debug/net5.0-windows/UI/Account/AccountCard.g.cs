﻿#pragma checksum "..\..\..\..\..\UI\Account\AccountCard.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26F4F37525C5CF38397433CDE58B68B46C2E6050"
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
    /// AccountCard
    /// </summary>
    public partial class AccountCard : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\..\..\UI\Account\AccountCard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel ownerContainer;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\..\UI\Account\AccountCard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tblName;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\..\UI\Account\AccountCard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel messageContainer;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\..\UI\Account\AccountCard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tblUserName;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\..\..\UI\Account\AccountCard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tblWorkingRole;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\..\..\UI\Account\AccountCard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button resetPasswordButton;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\..\..\UI\Account\AccountCard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.PackIcon resetPasswordIcon;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\..\..\..\UI\Account\AccountCard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button deleteButton;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\..\..\..\UI\Account\AccountCard.xaml"
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
            System.Uri resourceLocater = new System.Uri("/HuongDuongVillage;component/ui/account/accountcard.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\UI\Account\AccountCard.xaml"
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
            this.ownerContainer = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 2:
            this.tblName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.messageContainer = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 4:
            this.tblUserName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.tblWorkingRole = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.resetPasswordButton = ((System.Windows.Controls.Button)(target));
            
            #line 83 "..\..\..\..\..\UI\Account\AccountCard.xaml"
            this.resetPasswordButton.Click += new System.Windows.RoutedEventHandler(this.resetPasswordButton_Click);
            
            #line default
            #line hidden
            
            #line 84 "..\..\..\..\..\UI\Account\AccountCard.xaml"
            this.resetPasswordButton.MouseEnter += new System.Windows.Input.MouseEventHandler(this.resetPasswordButton_MouseEnter);
            
            #line default
            #line hidden
            
            #line 85 "..\..\..\..\..\UI\Account\AccountCard.xaml"
            this.resetPasswordButton.MouseLeave += new System.Windows.Input.MouseEventHandler(this.resetPasswordButton_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 7:
            this.resetPasswordIcon = ((MaterialDesignThemes.Wpf.PackIcon)(target));
            return;
            case 8:
            this.deleteButton = ((System.Windows.Controls.Button)(target));
            
            #line 105 "..\..\..\..\..\UI\Account\AccountCard.xaml"
            this.deleteButton.Click += new System.Windows.RoutedEventHandler(this.deleteButton_Click);
            
            #line default
            #line hidden
            
            #line 106 "..\..\..\..\..\UI\Account\AccountCard.xaml"
            this.deleteButton.MouseEnter += new System.Windows.Input.MouseEventHandler(this.deleteButton_MouseEnter);
            
            #line default
            #line hidden
            
            #line 107 "..\..\..\..\..\UI\Account\AccountCard.xaml"
            this.deleteButton.MouseLeave += new System.Windows.Input.MouseEventHandler(this.deleteButton_MouseLeave);
            
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
