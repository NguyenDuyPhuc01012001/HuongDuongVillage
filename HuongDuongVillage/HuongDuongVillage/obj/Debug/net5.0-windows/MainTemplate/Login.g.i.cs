#pragma checksum "..\..\..\..\MainTemplate\Login.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A943C816B3AEECF134D12B6E2E2DC0F5D8E03814"
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
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 59 "..\..\..\..\MainTemplate\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid pgbLoading;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\..\MainTemplate\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClose;
        
        #line default
        #line hidden
        
        
        #line 120 "..\..\..\..\MainTemplate\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox usernameContainer;
        
        #line default
        #line hidden
        
        
        #line 137 "..\..\..\..\MainTemplate\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border bdrPassword;
        
        #line default
        #line hidden
        
        
        #line 147 "..\..\..\..\MainTemplate\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox encryptedPasswordBox;
        
        #line default
        #line hidden
        
        
        #line 157 "..\..\..\..\MainTemplate\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox decryptedPasswordBox;
        
        #line default
        #line hidden
        
        
        #line 167 "..\..\..\..\MainTemplate\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button showPasswordBtn;
        
        #line default
        #line hidden
        
        
        #line 175 "..\..\..\..\MainTemplate\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.PackIcon togglePassStatusIcon;
        
        #line default
        #line hidden
        
        
        #line 183 "..\..\..\..\MainTemplate\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ckbSaveAcc;
        
        #line default
        #line hidden
        
        
        #line 191 "..\..\..\..\MainTemplate\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnForgotPassword;
        
        #line default
        #line hidden
        
        
        #line 207 "..\..\..\..\MainTemplate\Login.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DisplayArea;
        
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
            System.Uri resourceLocater = new System.Uri("/HuongDuongVillage;component/maintemplate/login.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\MainTemplate\Login.xaml"
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
            this.pgbLoading = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.btnClose = ((System.Windows.Controls.Button)(target));
            
            #line 87 "..\..\..\..\MainTemplate\Login.xaml"
            this.btnClose.Click += new System.Windows.RoutedEventHandler(this.btnClose_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.usernameContainer = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.bdrPassword = ((System.Windows.Controls.Border)(target));
            return;
            case 5:
            this.encryptedPasswordBox = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 155 "..\..\..\..\MainTemplate\Login.xaml"
            this.encryptedPasswordBox.PasswordChanged += new System.Windows.RoutedEventHandler(this.encryptedPasswordBox_PasswordChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.decryptedPasswordBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 164 "..\..\..\..\MainTemplate\Login.xaml"
            this.decryptedPasswordBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.decryptedPasswordBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.showPasswordBtn = ((System.Windows.Controls.Button)(target));
            
            #line 173 "..\..\..\..\MainTemplate\Login.xaml"
            this.showPasswordBtn.Click += new System.Windows.RoutedEventHandler(this.showPasswordBtn_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.togglePassStatusIcon = ((MaterialDesignThemes.Wpf.PackIcon)(target));
            return;
            case 9:
            this.ckbSaveAcc = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 10:
            this.btnForgotPassword = ((System.Windows.Controls.Button)(target));
            
            #line 193 "..\..\..\..\MainTemplate\Login.xaml"
            this.btnForgotPassword.Click += new System.Windows.RoutedEventHandler(this.btnForgotPassword_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.DisplayArea = ((System.Windows.Controls.Button)(target));
            
            #line 210 "..\..\..\..\MainTemplate\Login.xaml"
            this.DisplayArea.Click += new System.Windows.RoutedEventHandler(this.Login_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

