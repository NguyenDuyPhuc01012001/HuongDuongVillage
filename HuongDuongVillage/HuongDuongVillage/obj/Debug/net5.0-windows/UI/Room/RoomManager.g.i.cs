﻿#pragma checksum "..\..\..\..\..\UI\Room\RoomManager.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1AF3BD06DCA5654D3200A95A7C37E7BB8D11FC12"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
    /// RoomManager
    /// </summary>
    public partial class RoomManager : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 108 "..\..\..\..\..\UI\Room\RoomManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSortStatus;
        
        #line default
        #line hidden
        
        
        #line 117 "..\..\..\..\..\UI\Room\RoomManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.PackIcon SortStatusIcon;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/HuongDuongVillage;component/ui/room/roommanager.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\UI\Room\RoomManager.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.btnSortStatus = ((System.Windows.Controls.Button)(target));
            
            #line 115 "..\..\..\..\..\UI\Room\RoomManager.xaml"
            this.btnSortStatus.Click += new System.Windows.RoutedEventHandler(this.sortButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.SortStatusIcon = ((MaterialDesignThemes.Wpf.PackIcon)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

