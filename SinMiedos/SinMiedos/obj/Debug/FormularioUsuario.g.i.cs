﻿#pragma checksum "..\..\FormularioUsuario.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ACE079B7C25B9D6B5A12D7F3361D8309FDFA2594"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Transitions;
using SinMiedos;
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


namespace SinMiedos {
    
    
    /// <summary>
    /// FormularioUsuario
    /// </summary>
    public partial class FormularioUsuario : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 25 "..\..\FormularioUsuario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.DialogHost modal;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\FormularioUsuario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNombre;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\FormularioUsuario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPaterno;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\FormularioUsuario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtMaterno;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\FormularioUsuario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtEdad;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\FormularioUsuario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTelefono;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\FormularioUsuario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDireccion;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\FormularioUsuario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtEmail;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\FormularioUsuario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbSexo;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\FormularioUsuario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtidPaciente;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\FormularioUsuario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGrid;
        
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
            System.Uri resourceLocater = new System.Uri("/SinMiedos;component/formulariousuario.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\FormularioUsuario.xaml"
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
            this.modal = ((MaterialDesignThemes.Wpf.DialogHost)(target));
            
            #line 25 "..\..\FormularioUsuario.xaml"
            this.modal.DialogClosing += new MaterialDesignThemes.Wpf.DialogClosingEventHandler(this.Sample1_DialogHost_OnDialogClosing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.txtNombre = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.txtPaterno = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.txtMaterno = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.txtEdad = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.txtTelefono = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.txtDireccion = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.txtEmail = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.cmbSexo = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 10:
            this.txtidPaciente = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 11:
            
            #line 51 "..\..\FormularioUsuario.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Agregar);
            
            #line default
            #line hidden
            return;
            case 12:
            this.DataGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 67 "..\..\FormularioUsuario.xaml"
            this.DataGrid.Loaded += new System.Windows.RoutedEventHandler(this.DataGrid_Paciente);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 100 "..\..\FormularioUsuario.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Modal);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 13:
            
            #line 79 "..\..\FormularioUsuario.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.EditarA);
            
            #line default
            #line hidden
            break;
            case 14:
            
            #line 82 "..\..\FormularioUsuario.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.EliminarA);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

