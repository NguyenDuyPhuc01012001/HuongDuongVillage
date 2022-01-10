﻿#pragma checksum "..\..\..\..\..\UI\DocumentReport\DocumentReportCard.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "763339D4FF29DA52B12E8E652DA5F7DBC2FF1A10"
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
    /// DocumentReportCard
    /// </summary>
    public partial class DocumentReportCard : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\..\..\..\UI\DocumentReport\DocumentReportCard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tblOwner;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\..\UI\DocumentReport\DocumentReportCard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel messageContainer;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\..\UI\DocumentReport\DocumentReportCard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tblMessage;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\..\..\UI\DocumentReport\DocumentReportCard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tblDocument;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\..\..\UI\DocumentReport\DocumentReportCard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button editButton;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\..\..\UI\DocumentReport\DocumentReportCard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.PackIcon editIcon;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\..\..\..\UI\DocumentReport\DocumentReportCard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button deleteButton;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\..\..\..\UI\DocumentReport\DocumentReportCard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.PackIcon deleteIcon;
        
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
            System.Uri resourceLocater = new System.Uri("/HuongDuongVillage;V1.0.0.0;component/ui/documentreport/documentreportcard.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\UI\DocumentReport\DocumentReportCard.xaml"
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
            this.tblOwner = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.messageContainer = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 3:
            this.tblMessage = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.tblDocument = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.editButton = ((System.Windows.Controls.Button)(target));
            
            #line 82 "..\..\..\..\..\UI\DocumentReport\DocumentReportCard.xaml"
            this.editButton.Click += new System.Windows.RoutedEventHandler(this.editButton_Click);
            
            #line default
            #line hidden
            
            #line 83 "..\..\..\..\..\UI\DocumentReport\DocumentReportCard.xaml"
            this.editButton.MouseEnter += new System.Windows.Input.MouseEventHandler(this.addButton_MouseEnter);
            
            #line default
            #line hidden
            
            #line 84 "..\..\..\..\..\UI\DocumentReport\DocumentReportCard.xaml"
            this.editButton.MouseLeave += new System.Windows.Input.MouseEventHandler(this.addButton_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 6:
            this.editIcon = ((MaterialDesignThemes.Wpf.PackIcon)(target));
            return;
            case 7:
            this.deleteButton = ((System.Windows.Controls.Button)(target));
            
            #line 104 "..\..\..\..\..\UI\DocumentReport\DocumentReportCard.xaml"
            this.deleteButton.Click += new System.Windows.RoutedEventHandler(this.deleteButton_Click);
            
            #line default
            #line hidden
            
            #line 105 "..\..\..\..\..\UI\DocumentReport\DocumentReportCard.xaml"
            this.deleteButton.MouseEnter += new System.Windows.Input.MouseEventHandler(this.deleteButton_MouseEnter);
            
            #line default
            #line hidden
            
            #line 106 "..\..\..\..\..\UI\DocumentReport\DocumentReportCard.xaml"
            this.deleteButton.MouseLeave += new System.Windows.Input.MouseEventHandler(this.deleteButton_MouseLeave);
            
            #line default
            #line hidden
            return;
            case 8:
            this.deleteIcon = ((MaterialDesignThemes.Wpf.PackIcon)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

