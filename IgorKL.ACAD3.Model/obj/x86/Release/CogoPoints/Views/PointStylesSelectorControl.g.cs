﻿#pragma checksum "..\..\..\..\..\CogoPoints\Views\PointStylesSelectorControl.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B2B6761D978DBB693E63C14DB3281EF7"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using IgorKL.ACAD3.Model.CogoPoints.Views;
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


namespace IgorKL.ACAD3.Model.CogoPoints.Views {
    
    
    /// <summary>
    /// PointStylesSelectorControl
    /// </summary>
    public partial class PointStylesSelectorControl : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\..\..\..\CogoPoints\Views\PointStylesSelectorControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal IgorKL.ACAD3.Model.CogoPoints.Views.PointStylesSelectorControl userControl;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\..\CogoPoints\Views\PointStylesSelectorControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox _comboBox_PointStyles;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\..\CogoPoints\Views\PointStylesSelectorControl.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox _comboBox_PointLabelStyles;
        
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
            System.Uri resourceLocater = new System.Uri("/IgorKL.ACAD3.Model;component/cogopoints/views/pointstylesselectorcontrol.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\CogoPoints\Views\PointStylesSelectorControl.xaml"
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
            this.userControl = ((IgorKL.ACAD3.Model.CogoPoints.Views.PointStylesSelectorControl)(target));
            return;
            case 2:
            this._comboBox_PointStyles = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this._comboBox_PointLabelStyles = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            
            #line 51 "..\..\..\..\..\CogoPoints\Views\PointStylesSelectorControl.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

