﻿#pragma checksum "..\..\CréerComptePro.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BF4976AE400396B256FE3C56B9C41D20D4DBD29A6CF02DE8DFBDBB085F777113"
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
    /// CréerCompteClient
    /// </summary>
    public partial class CréerCompteClient : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\CréerComptePro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtNom;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\CréerComptePro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Txtprénom;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\CréerComptePro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Txtidentifiant;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\CréerComptePro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TxtNumTel;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\CréerComptePro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox pwMDP;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\CréerComptePro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox pwMDP_Copy;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\CréerComptePro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnConfirmer;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\CréerComptePro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRetour;
        
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
            System.Uri resourceLocater = new System.Uri("/Projet infotools CSharp;component/cr%c3%a9ercomptepro.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CréerComptePro.xaml"
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
            this.TxtNom = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.Txtprénom = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.Txtidentifiant = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.TxtNumTel = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.pwMDP = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 6:
            this.pwMDP_Copy = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 7:
            this.btnConfirmer = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\CréerComptePro.xaml"
            this.btnConfirmer.Click += new System.Windows.RoutedEventHandler(this.btnConfirmer_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnRetour = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\CréerComptePro.xaml"
            this.btnRetour.Click += new System.Windows.RoutedEventHandler(this.btnRetour_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

