﻿#pragma checksum "..\..\Recept.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "30A3C709CDD96BCD6C143A282941FB46A152F79AA03413D7D79AA6C6643E340A"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Recepti;
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


namespace Recepti {
    
    
    /// <summary>
    /// Recept
    /// </summary>
    public partial class Recept : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\Recept.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock NazvanieTextBlock;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Recept.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock OpisanieTextBlock;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Recept.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock IngredientiTextBlock;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\Recept.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock KategoriaTextBlock;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\Recept.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock AvtorReceptaTextBlock;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\Recept.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock InstrukciaTextBlock;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\Recept.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgOtzivi;
        
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
            System.Uri resourceLocater = new System.Uri("/Recepti;component/recept.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Recept.xaml"
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
            this.NazvanieTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.OpisanieTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.IngredientiTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.KategoriaTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.AvtorReceptaTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.InstrukciaTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            
            #line 31 "..\..\Recept.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 32 "..\..\Recept.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click2);
            
            #line default
            #line hidden
            return;
            case 9:
            this.dgOtzivi = ((System.Windows.Controls.DataGrid)(target));
            
            #line 35 "..\..\Recept.xaml"
            this.dgOtzivi.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dgOtzivi_SelectionChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

