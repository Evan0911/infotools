﻿#pragma checksum "..\..\FenêtreMDPOublié.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F6F43279557B85AC48F33DF5614B40807CF477A37B7C04732B0183891E8806A9"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using Projet_infotools_CSharp;
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


namespace Projet_infotools_CSharp {
    
    
    /// <summary>
    /// FenêtreMDPOublié
    /// </summary>
    public partial class FenêtreMDPOublié : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\FenêtreMDPOublié.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox PSW1;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\FenêtreMDPOublié.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox PSW2;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\FenêtreMDPOublié.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnConfirmer;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\FenêtreMDPOublié.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtIdentifiant;
        
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
            System.Uri resourceLocater = new System.Uri("/Projet infotools CSharp;component/fen%c3%aatremdpoubli%c3%a9.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\FenêtreMDPOublié.xaml"
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
            this.PSW1 = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 2:
            this.PSW2 = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 3:
            this.BtnConfirmer = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\FenêtreMDPOublié.xaml"
            this.BtnConfirmer.Click += new System.Windows.RoutedEventHandler(this.BtnConfirmer_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 16 "..\..\FenêtreMDPOublié.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.TxtIdentifiant = ((System.Windows.Controls.TextBox)(target));
            
            #line 17 "..\..\FenêtreMDPOublié.xaml"
            this.TxtIdentifiant.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TxtIdentifiant_TextChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

