﻿#pragma checksum "..\..\..\..\Drawing\Views\EntitiesRandomEditorView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "27A37923455E28D033A22D30FA4822D9"
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


namespace IgorKL.ACAD3.Model.Drawing.Views {
    
    
    /// <summary>
    /// EntitiesRandomEditorView
    /// </summary>
    public partial class EntitiesRandomEditorView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\..\Drawing\Views\EntitiesRandomEditorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox _textBox_BottomTolerance;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\Drawing\Views\EntitiesRandomEditorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox _textBox_TopTolerance;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\Drawing\Views\EntitiesRandomEditorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox _checkBox_UseDefineFormat;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\Drawing\Views\EntitiesRandomEditorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button _button_Complete;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\Drawing\Views\EntitiesRandomEditorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox _comboBox_Format;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\Drawing\Views\EntitiesRandomEditorView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox _checkBox_UseMinTolerance;
        
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
            System.Uri resourceLocater = new System.Uri("/IgorKL.ACAD3.Model;component/drawing/views/entitiesrandomeditorview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Drawing\Views\EntitiesRandomEditorView.xaml"
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
            this._textBox_BottomTolerance = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this._textBox_TopTolerance = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this._checkBox_UseDefineFormat = ((System.Windows.Controls.CheckBox)(target));
            
            #line 30 "..\..\..\..\Drawing\Views\EntitiesRandomEditorView.xaml"
            this._checkBox_UseDefineFormat.Checked += new System.Windows.RoutedEventHandler(this._checkBox_UseDefineFormat_Checked);
            
            #line default
            #line hidden
            
            #line 30 "..\..\..\..\Drawing\Views\EntitiesRandomEditorView.xaml"
            this._checkBox_UseDefineFormat.Unchecked += new System.Windows.RoutedEventHandler(this._checkBox_UseDefineFormat_Unchecked);
            
            #line default
            #line hidden
            return;
            case 4:
            this._button_Complete = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\..\Drawing\Views\EntitiesRandomEditorView.xaml"
            this._button_Complete.Click += new System.Windows.RoutedEventHandler(this.ok_Button_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this._comboBox_Format = ((System.Windows.Controls.ComboBox)(target));
            
            #line 33 "..\..\..\..\Drawing\Views\EntitiesRandomEditorView.xaml"
            this._comboBox_Format.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this._comboBox_Format_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this._checkBox_UseMinTolerance = ((System.Windows.Controls.CheckBox)(target));
            
            #line 39 "..\..\..\..\Drawing\Views\EntitiesRandomEditorView.xaml"
            this._checkBox_UseMinTolerance.Unchecked += new System.Windows.RoutedEventHandler(this._checkBox_UseMinTolerance_Unchecked);
            
            #line default
            #line hidden
            
            #line 39 "..\..\..\..\Drawing\Views\EntitiesRandomEditorView.xaml"
            this._checkBox_UseMinTolerance.Checked += new System.Windows.RoutedEventHandler(this._checkBox_UseMinTolerance_Checked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

