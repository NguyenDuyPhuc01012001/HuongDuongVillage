﻿#pragma checksum "..\..\..\..\..\UI\Payment\PaymentManager.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "B82EE81EA2EBF6A0885944EB28224FEE63B87149"
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
    /// PaymentManager
    /// </summary>
    public partial class PaymentManager : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 74 "..\..\..\..\..\UI\Payment\PaymentManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSortAmount;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\..\..\UI\Payment\PaymentManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.PackIcon iconSortAmount;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\..\..\..\UI\Payment\PaymentManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSortPaymentDate;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\..\..\..\UI\Payment\PaymentManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.PackIcon iconSortPaymentDate;
        
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
            System.Uri resourceLocater = new System.Uri("/HuongDuongVillage;component/ui/payment/paymentmanager.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\UI\Payment\PaymentManager.xaml"
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
            this.btnSortAmount = ((System.Windows.Controls.Button)(target));
            
            #line 74 "..\..\..\..\..\UI\Payment\PaymentManager.xaml"
            this.btnSortAmount.Click += new System.Windows.RoutedEventHandler(this.btnSortAmount_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.iconSortAmount = ((MaterialDesignThemes.Wpf.PackIcon)(target));
            return;
            case 3:
            this.btnSortPaymentDate = ((System.Windows.Controls.Button)(target));
            
            #line 95 "..\..\..\..\..\UI\Payment\PaymentManager.xaml"
            this.btnSortPaymentDate.Click += new System.Windows.RoutedEventHandler(this.btnSortPaymentDate_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.iconSortPaymentDate = ((MaterialDesignThemes.Wpf.PackIcon)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

