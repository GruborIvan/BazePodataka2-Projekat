// Updated by XamlIntelliSenseFileGenerator 5/30/2021 9:03:18 PM
#pragma checksum "..\..\..\CrudWindows\KompanijeWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7A4ECC40C36993841BE7BCBA12C3D20B6434BCBF8694B2836EC0E27682E656C7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using BazeProjekatPokusaj2.CrudWindows;
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


namespace BazeProjekatPokusaj2.CrudWindows
{


    /// <summary>
    /// KompanijeWindow
    /// </summary>
    public partial class KompanijeWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/BazeProjekatPokusaj2;component/crudwindows/kompanijewindow.xaml", System.UriKind.Relative);

#line 1 "..\..\..\CrudWindows\KompanijeWindow.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.TextBox GradTextBox;
        internal System.Windows.Controls.TextBox GradTextBox2E;
        internal System.Windows.Controls.TextBox GradTextBox3;
        internal System.Windows.Controls.Button ButtonCancel;
        internal System.Windows.Controls.Button ButtonSave;
        internal System.Windows.Controls.DataGrid LokacijeList;
        internal System.Windows.Controls.DataGridTextColumn KID;
        internal System.Windows.Controls.DataGridTextColumn GodinaOsnivanja;
        internal System.Windows.Controls.DataGridTextColumn Naziv;
        internal System.Windows.Controls.DataGridTextColumn Lokacija;
    }
}

