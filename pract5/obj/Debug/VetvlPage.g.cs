﻿#pragma checksum "..\..\VetvlPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "531F4D6127F6AA7F4EE3D0AD2EA1AF4E49488EC97A4ED347BF4329265528502B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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
using pract5;


namespace pract5 {
    
    
    /// <summary>
    /// VetvlPage
    /// </summary>
    public partial class VetvlPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\VetvlPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbx;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\VetvlPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tby;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\VetvlPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbCos;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\VetvlPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbSqr;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\VetvlPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rbExp;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\VetvlPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tbResult;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\VetvlPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRes;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\VetvlPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox cbColor;
        
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
            System.Uri resourceLocater = new System.Uri("/pract5;component/vetvlpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\VetvlPage.xaml"
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
            this.tbx = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.tby = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.rbCos = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 4:
            this.rbSqr = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 5:
            this.rbExp = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 6:
            this.tbResult = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.btnRes = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\VetvlPage.xaml"
            this.btnRes.Click += new System.Windows.RoutedEventHandler(this.btnRes_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.cbColor = ((System.Windows.Controls.CheckBox)(target));
            
            #line 46 "..\..\VetvlPage.xaml"
            this.cbColor.Checked += new System.Windows.RoutedEventHandler(this.cbColor_Checked);
            
            #line default
            #line hidden
            
            #line 46 "..\..\VetvlPage.xaml"
            this.cbColor.Unchecked += new System.Windows.RoutedEventHandler(this.cbColor_Checked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

