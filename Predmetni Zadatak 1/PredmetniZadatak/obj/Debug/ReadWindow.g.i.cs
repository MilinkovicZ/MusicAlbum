﻿#pragma checksum "..\..\ReadWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "463AB254CF3A3A755E52A1D3CA213D8D2C543AB4FF100EE2DB9F888C04A5EBA6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using PredmetniZadatak;
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


namespace PredmetniZadatak {
    
    
    /// <summary>
    /// ReadWindow
    /// </summary>
    public partial class ReadWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\ReadWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Path UIPath;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\ReadWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnIzadji;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\ReadWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image slikaS;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\ReadWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lNaslov;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\ReadWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lTrajanje;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\ReadWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RichTextBox rtbOpis;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\ReadWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lDan;
        
        #line default
        #line hidden
        
        
        #line 66 "..\..\ReadWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lMesec;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\ReadWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lGodina;
        
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
            System.Uri resourceLocater = new System.Uri("/PredmetniZadatak;component/readwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ReadWindow.xaml"
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
            
            #line 8 "..\..\ReadWindow.xaml"
            ((PredmetniZadatak.ReadWindow)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Window_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.UIPath = ((System.Windows.Shapes.Path)(target));
            return;
            case 3:
            this.btnIzadji = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\ReadWindow.xaml"
            this.btnIzadji.Click += new System.Windows.RoutedEventHandler(this.btnIzadji_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.slikaS = ((System.Windows.Controls.Image)(target));
            return;
            case 5:
            this.lNaslov = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.lTrajanje = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.rtbOpis = ((System.Windows.Controls.RichTextBox)(target));
            return;
            case 8:
            this.lDan = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.lMesec = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.lGodina = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

