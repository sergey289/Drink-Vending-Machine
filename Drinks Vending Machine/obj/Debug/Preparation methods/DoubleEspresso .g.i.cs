#pragma checksum "..\..\..\Preparation methods\DoubleEspresso .xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "39A5D6FEB72BFB9796E6EE1F4AD7B7A499BB1E7C7915CF7410EB4E6588684719"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Drinks_Vending_Machine.Preparation_methods;
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


namespace Drinks_Vending_Machine.Preparation_methods {
    
    
    /// <summary>
    /// Espresso
    /// </summary>
    public partial class Espresso : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\Preparation methods\DoubleEspresso .xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rad_sugrarless;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\..\Preparation methods\DoubleEspresso .xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton rad_witch_sug;
        
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
            System.Uri resourceLocater = new System.Uri("/Drinks Vending Machine;component/preparation%20methods/doubleespresso%20.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Preparation methods\DoubleEspresso .xaml"
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
            this.rad_sugrarless = ((System.Windows.Controls.RadioButton)(target));
            
            #line 10 "..\..\..\Preparation methods\DoubleEspresso .xaml"
            this.rad_sugrarless.Checked += new System.Windows.RoutedEventHandler(this.rad_sugrarless_Checked);
            
            #line default
            #line hidden
            return;
            case 2:
            this.rad_witch_sug = ((System.Windows.Controls.RadioButton)(target));
            
            #line 11 "..\..\..\Preparation methods\DoubleEspresso .xaml"
            this.rad_witch_sug.Checked += new System.Windows.RoutedEventHandler(this.rad_witch_sug_Checked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

