﻿#pragma checksum "..\..\..\..\GUI\CustomAlertBox.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D9B8A1868D106A350F7027B7A661B6C21D22DBBA"
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
using LiveCharts.Wpf;
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
    /// CustomAlertBox
    /// </summary>
    public partial class CustomAlertBox : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\..\GUI\CustomAlertBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal HuongDuongVillage.CustomAlertBox DisplayArea;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\..\GUI\CustomAlertBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock MessageTitle;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\..\GUI\CustomAlertBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image img;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\..\..\GUI\CustomAlertBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtMsg;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\..\..\GUI\CustomAlertBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grdBtn;
        
        #line default
        #line hidden
        
        
        #line 112 "..\..\..\..\GUI\CustomAlertBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnOk;
        
        #line default
        #line hidden
        
        
        #line 131 "..\..\..\..\GUI\CustomAlertBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnYes;
        
        #line default
        #line hidden
        
        
        #line 149 "..\..\..\..\GUI\CustomAlertBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnNo;
        
        #line default
        #line hidden
        
        
        #line 166 "..\..\..\..\GUI\CustomAlertBox.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancel;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/HuongDuongVillage;component/gui/customalertbox.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\GUI\CustomAlertBox.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.DisplayArea = ((HuongDuongVillage.CustomAlertBox)(target));
            return;
            case 2:
            this.MessageTitle = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.img = ((System.Windows.Controls.Image)(target));
            return;
            case 4:
            this.txtMsg = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.grdBtn = ((System.Windows.Controls.Grid)(target));
            return;
            case 6:
            this.btnOk = ((System.Windows.Controls.Button)(target));
            
            #line 121 "..\..\..\..\GUI\CustomAlertBox.xaml"
            this.btnOk.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            
            #line 127 "..\..\..\..\GUI\CustomAlertBox.xaml"
            this.btnOk.MouseEnter += new System.Windows.Input.MouseEventHandler(this.btn_MouseEnter);
            
            #line default
            #line hidden
            
            #line 128 "..\..\..\..\GUI\CustomAlertBox.xaml"
            this.btnOk.MouseLeave += new System.Windows.Input.MouseEventHandler(this.btn_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnYes = ((System.Windows.Controls.Button)(target));
            
            #line 140 "..\..\..\..\GUI\CustomAlertBox.xaml"
            this.btnYes.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            
            #line 145 "..\..\..\..\GUI\CustomAlertBox.xaml"
            this.btnYes.MouseEnter += new System.Windows.Input.MouseEventHandler(this.btn_MouseEnter);
            
            #line default
            #line hidden
            
            #line 146 "..\..\..\..\GUI\CustomAlertBox.xaml"
            this.btnYes.MouseLeave += new System.Windows.Input.MouseEventHandler(this.btn_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnNo = ((System.Windows.Controls.Button)(target));
            
            #line 158 "..\..\..\..\GUI\CustomAlertBox.xaml"
            this.btnNo.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            
            #line 162 "..\..\..\..\GUI\CustomAlertBox.xaml"
            this.btnNo.MouseEnter += new System.Windows.Input.MouseEventHandler(this.btn_MouseEnter);
            
            #line default
            #line hidden
            
            #line 163 "..\..\..\..\GUI\CustomAlertBox.xaml"
            this.btnNo.MouseLeave += new System.Windows.Input.MouseEventHandler(this.btn_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnCancel = ((System.Windows.Controls.Button)(target));
            
            #line 175 "..\..\..\..\GUI\CustomAlertBox.xaml"
            this.btnCancel.Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            
            #line 179 "..\..\..\..\GUI\CustomAlertBox.xaml"
            this.btnCancel.MouseEnter += new System.Windows.Input.MouseEventHandler(this.btn_MouseEnter);
            
            #line default
            #line hidden
            
            #line 180 "..\..\..\..\GUI\CustomAlertBox.xaml"
            this.btnCancel.MouseLeave += new System.Windows.Input.MouseEventHandler(this.btn_MouseLeave);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

