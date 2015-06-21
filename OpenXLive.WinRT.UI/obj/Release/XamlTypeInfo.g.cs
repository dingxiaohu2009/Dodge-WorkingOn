﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



namespace OpenXLive.WinRT.UI.OpenXLive_WinRT_UI_XamlTypeInfo
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks","4.0.0.0")]
    public sealed class XamlMetaDataProvider: global::Windows.UI.Xaml.Markup.IXamlMetadataProvider
    {
        private global::OpenXLive.WinRT.UI.OpenXLive_WinRT_UI_XamlTypeInfo.XamlTypeInfoProvider _provider;

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(global::System.Type type)
        {
            if(_provider == null)
            {
                _provider = new global::OpenXLive.WinRT.UI.OpenXLive_WinRT_UI_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByType(type);
        }

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(global::System.String fullName)
        {
            if(_provider == null)
            {
                _provider = new global::OpenXLive.WinRT.UI.OpenXLive_WinRT_UI_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByName(fullName);
        }

        public global::Windows.UI.Xaml.Markup.XmlnsDefinition[] GetXmlnsDefinitions()
        {
            return new global::Windows.UI.Xaml.Markup.XmlnsDefinition[0];
        }
    }
}

namespace OpenXLive.WinRT.UI.OpenXLive_WinRT_UI_XamlTypeInfo
{
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal partial class XamlTypeInfoProvider
    {
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByType(global::System.Type type)
        {
            string standardName;
            global::Windows.UI.Xaml.Markup.IXamlType xamlType = null;
            if(_xamlTypeToStandardName.TryGetValue(type, out standardName))
            {
                xamlType = GetXamlTypeByName(standardName);
            }
            else
            {
                xamlType = GetXamlTypeByName(type.FullName);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByName(string typeName)
        {
            if (global::System.String.IsNullOrEmpty(typeName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            if (_xamlTypes.TryGetValue(typeName, out xamlType))
            {
                return xamlType;
            }
            xamlType = CreateXamlType(typeName);
            if (xamlType != null)
            {
                _xamlTypes.Add(typeName, xamlType);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlMember GetMemberByLongName(string longMemberName)
        {
            if (global::System.String.IsNullOrEmpty(longMemberName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlMember xamlMember;
            if (_xamlMembers.TryGetValue(longMemberName, out xamlMember))
            {
                return xamlMember;
            }
            xamlMember = CreateXamlMember(longMemberName);
            if (xamlMember != null)
            {
                _xamlMembers.Add(longMemberName, xamlMember);
            }
            return xamlMember;
        }

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType> _xamlTypes = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>();
        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember> _xamlMembers = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>();
        global::System.Collections.Generic.Dictionary<global::System.Type, string> _xamlTypeToStandardName = new global::System.Collections.Generic.Dictionary<global::System.Type, string>();

        private void AddToMapOfTypeToStandardName(global::System.Type t, global::System.String str)
        {
            if(!_xamlTypeToStandardName.ContainsKey(t))
            {
                _xamlTypeToStandardName.Add(t, str);
            }
        }

        private object Activate_0_XLiveCredentialPicker() { return new global::OpenXLive.WinRT.UI.XLiveCredentialPicker(); }

        private object Activate_2_WatermarkPasswordBox() { return new global::OpenXLive.WinRT.UI.WatermarkPasswordBox(); }

        private object Activate_3_WatermarkTextBox() { return new global::OpenXLive.WinRT.UI.WatermarkTextBox(); }


        private global::Windows.UI.Xaml.Markup.IXamlType CreateXamlType(string typeName)
        {
            global::OpenXLive.WinRT.UI.OpenXLive_WinRT_UI_XamlTypeInfo.XamlSystemBaseType xamlType = null;
            global::OpenXLive.WinRT.UI.OpenXLive_WinRT_UI_XamlTypeInfo.XamlUserType userType;

            switch (typeName)
            {
            case "Windows.UI.Xaml.Controls.Control":
                xamlType = new global::OpenXLive.WinRT.UI.OpenXLive_WinRT_UI_XamlTypeInfo.XamlSystemBaseType(typeName, typeof(global::Windows.UI.Xaml.Controls.Control));
                break;

            case "String":
                xamlType = new global::OpenXLive.WinRT.UI.OpenXLive_WinRT_UI_XamlTypeInfo.XamlSystemBaseType(typeName, typeof(global::System.String));
                break;

            case "Boolean":
                xamlType = new global::OpenXLive.WinRT.UI.OpenXLive_WinRT_UI_XamlTypeInfo.XamlSystemBaseType(typeName, typeof(global::System.Boolean));
                break;

            case "Windows.UI.Xaml.Media.Brush":
                xamlType = new global::OpenXLive.WinRT.UI.OpenXLive_WinRT_UI_XamlTypeInfo.XamlSystemBaseType(typeName, typeof(global::Windows.UI.Xaml.Media.Brush));
                break;

            case "Windows.UI.Xaml.DataTemplate":
                xamlType = new global::OpenXLive.WinRT.UI.OpenXLive_WinRT_UI_XamlTypeInfo.XamlSystemBaseType(typeName, typeof(global::Windows.UI.Xaml.DataTemplate));
                break;

            case "Windows.UI.Xaml.Controls.TextBox":
                xamlType = new global::OpenXLive.WinRT.UI.OpenXLive_WinRT_UI_XamlTypeInfo.XamlSystemBaseType(typeName, typeof(global::Windows.UI.Xaml.Controls.TextBox));
                break;

            case "Object":
                xamlType = new global::OpenXLive.WinRT.UI.OpenXLive_WinRT_UI_XamlTypeInfo.XamlSystemBaseType(typeName, typeof(global::System.Object));
                break;

            case "Windows.UI.Xaml.Style":
                xamlType = new global::OpenXLive.WinRT.UI.OpenXLive_WinRT_UI_XamlTypeInfo.XamlSystemBaseType(typeName, typeof(global::Windows.UI.Xaml.Style));
                break;

            case "OpenXLive.WinRT.UI.XLiveCredentialPicker":
                userType = new global::OpenXLive.WinRT.UI.OpenXLive_WinRT_UI_XamlTypeInfo.XamlUserType(this, typeName, typeof(global::OpenXLive.WinRT.UI.XLiveCredentialPicker), GetXamlTypeByName("Windows.UI.Xaml.Controls.Control"));
                userType.Activator = Activate_0_XLiveCredentialPicker;
                userType.AddMemberName("Caption");
                AddToMapOfTypeToStandardName(typeof(global::System.String),
                                                   "String");
                userType.AddMemberName("IsRemember");
                AddToMapOfTypeToStandardName(typeof(global::System.Boolean),
                                                   "Boolean");
                userType.AddMemberName("PickerBackground");
                userType.AddMemberName("SNSProvidersTemplate");
                userType.AddMemberName("SNSItemSource");
                xamlType = userType;
                break;

            case "System.Collections.IEnumerable":
                userType = new global::OpenXLive.WinRT.UI.OpenXLive_WinRT_UI_XamlTypeInfo.XamlUserType(this, typeName, typeof(global::System.Collections.IEnumerable), null);
                xamlType = userType;
                break;

            case "OpenXLive.WinRT.UI.WatermarkPasswordBox":
                userType = new global::OpenXLive.WinRT.UI.OpenXLive_WinRT_UI_XamlTypeInfo.XamlUserType(this, typeName, typeof(global::OpenXLive.WinRT.UI.WatermarkPasswordBox), GetXamlTypeByName("Windows.UI.Xaml.Controls.TextBox"));
                userType.Activator = Activate_2_WatermarkPasswordBox;
                userType.AddMemberName("WatermarkText");
                AddToMapOfTypeToStandardName(typeof(global::System.Object),
                                                   "Object");
                userType.AddMemberName("WatermarkStyle");
                xamlType = userType;
                break;

            case "OpenXLive.WinRT.UI.WatermarkTextBox":
                userType = new global::OpenXLive.WinRT.UI.OpenXLive_WinRT_UI_XamlTypeInfo.XamlUserType(this, typeName, typeof(global::OpenXLive.WinRT.UI.WatermarkTextBox), GetXamlTypeByName("Windows.UI.Xaml.Controls.TextBox"));
                userType.Activator = Activate_3_WatermarkTextBox;
                userType.AddMemberName("WatermarkText");
                AddToMapOfTypeToStandardName(typeof(global::System.String),
                                                   "String");
                userType.AddMemberName("WatermarkStyle");
                xamlType = userType;
                break;

            }
            return xamlType;
        }


        private object get_0_XLiveCredentialPicker_Caption(object instance)
        {
            var that = (global::OpenXLive.WinRT.UI.XLiveCredentialPicker)instance;
            return that.Caption;
        }
        private void set_0_XLiveCredentialPicker_Caption(object instance, object Value)
        {
            var that = (global::OpenXLive.WinRT.UI.XLiveCredentialPicker)instance;
            that.Caption = (global::System.String)Value;
        }
        private object get_1_XLiveCredentialPicker_IsRemember(object instance)
        {
            var that = (global::OpenXLive.WinRT.UI.XLiveCredentialPicker)instance;
            return that.IsRemember;
        }
        private void set_1_XLiveCredentialPicker_IsRemember(object instance, object Value)
        {
            var that = (global::OpenXLive.WinRT.UI.XLiveCredentialPicker)instance;
            that.IsRemember = (global::System.Boolean)Value;
        }
        private object get_2_XLiveCredentialPicker_PickerBackground(object instance)
        {
            var that = (global::OpenXLive.WinRT.UI.XLiveCredentialPicker)instance;
            return that.PickerBackground;
        }
        private void set_2_XLiveCredentialPicker_PickerBackground(object instance, object Value)
        {
            var that = (global::OpenXLive.WinRT.UI.XLiveCredentialPicker)instance;
            that.PickerBackground = (global::Windows.UI.Xaml.Media.Brush)Value;
        }
        private object get_3_XLiveCredentialPicker_SNSProvidersTemplate(object instance)
        {
            var that = (global::OpenXLive.WinRT.UI.XLiveCredentialPicker)instance;
            return that.SNSProvidersTemplate;
        }
        private void set_3_XLiveCredentialPicker_SNSProvidersTemplate(object instance, object Value)
        {
            var that = (global::OpenXLive.WinRT.UI.XLiveCredentialPicker)instance;
            that.SNSProvidersTemplate = (global::Windows.UI.Xaml.DataTemplate)Value;
        }
        private object get_4_XLiveCredentialPicker_SNSItemSource(object instance)
        {
            var that = (global::OpenXLive.WinRT.UI.XLiveCredentialPicker)instance;
            return that.SNSItemSource;
        }
        private void set_4_XLiveCredentialPicker_SNSItemSource(object instance, object Value)
        {
            var that = (global::OpenXLive.WinRT.UI.XLiveCredentialPicker)instance;
            that.SNSItemSource = (global::System.Collections.IEnumerable)Value;
        }
        private object get_5_WatermarkPasswordBox_WatermarkText(object instance)
        {
            var that = (global::OpenXLive.WinRT.UI.WatermarkPasswordBox)instance;
            return that.WatermarkText;
        }
        private void set_5_WatermarkPasswordBox_WatermarkText(object instance, object Value)
        {
            var that = (global::OpenXLive.WinRT.UI.WatermarkPasswordBox)instance;
            that.WatermarkText = (global::System.Object)Value;
        }
        private object get_6_WatermarkPasswordBox_WatermarkStyle(object instance)
        {
            var that = (global::OpenXLive.WinRT.UI.WatermarkPasswordBox)instance;
            return that.WatermarkStyle;
        }
        private void set_6_WatermarkPasswordBox_WatermarkStyle(object instance, object Value)
        {
            var that = (global::OpenXLive.WinRT.UI.WatermarkPasswordBox)instance;
            that.WatermarkStyle = (global::Windows.UI.Xaml.Style)Value;
        }
        private object get_7_WatermarkTextBox_WatermarkText(object instance)
        {
            var that = (global::OpenXLive.WinRT.UI.WatermarkTextBox)instance;
            return that.WatermarkText;
        }
        private void set_7_WatermarkTextBox_WatermarkText(object instance, object Value)
        {
            var that = (global::OpenXLive.WinRT.UI.WatermarkTextBox)instance;
            that.WatermarkText = (global::System.String)Value;
        }
        private object get_8_WatermarkTextBox_WatermarkStyle(object instance)
        {
            var that = (global::OpenXLive.WinRT.UI.WatermarkTextBox)instance;
            return that.WatermarkStyle;
        }
        private void set_8_WatermarkTextBox_WatermarkStyle(object instance, object Value)
        {
            var that = (global::OpenXLive.WinRT.UI.WatermarkTextBox)instance;
            that.WatermarkStyle = (global::Windows.UI.Xaml.Style)Value;
        }

        private global::Windows.UI.Xaml.Markup.IXamlMember CreateXamlMember(string longMemberName)
        {
            global::OpenXLive.WinRT.UI.OpenXLive_WinRT_UI_XamlTypeInfo.XamlMember xamlMember = null;
            global::OpenXLive.WinRT.UI.OpenXLive_WinRT_UI_XamlTypeInfo.XamlUserType userType;

            switch (longMemberName)
            {
            case "OpenXLive.WinRT.UI.XLiveCredentialPicker.Caption":
                userType = (global::OpenXLive.WinRT.UI.OpenXLive_WinRT_UI_XamlTypeInfo.XamlUserType)GetXamlTypeByName("OpenXLive.WinRT.UI.XLiveCredentialPicker");
                xamlMember = new global::OpenXLive.WinRT.UI.OpenXLive_WinRT_UI_XamlTypeInfo.XamlMember(this, "Caption", "String");
                xamlMember.SetIsDependencyProperty();
                xamlMember.Getter = get_0_XLiveCredentialPicker_Caption;
                xamlMember.Setter = set_0_XLiveCredentialPicker_Caption;
                break;
            case "OpenXLive.WinRT.UI.XLiveCredentialPicker.IsRemember":
                userType = (global::OpenXLive.WinRT.UI.OpenXLive_WinRT_UI_XamlTypeInfo.XamlUserType)GetXamlTypeByName("OpenXLive.WinRT.UI.XLiveCredentialPicker");
                xamlMember = new global::OpenXLive.WinRT.UI.OpenXLive_WinRT_UI_XamlTypeInfo.XamlMember(this, "IsRemember", "Boolean");
                xamlMember.SetIsDependencyProperty();
                xamlMember.Getter = get_1_XLiveCredentialPicker_IsRemember;
                xamlMember.Setter = set_1_XLiveCredentialPicker_IsRemember;
                break;
            case "OpenXLive.WinRT.UI.XLiveCredentialPicker.PickerBackground":
                userType = (global::OpenXLive.WinRT.UI.OpenXLive_WinRT_UI_XamlTypeInfo.XamlUserType)GetXamlTypeByName("OpenXLive.WinRT.UI.XLiveCredentialPicker");
                xamlMember = new global::OpenXLive.WinRT.UI.OpenXLive_WinRT_UI_XamlTypeInfo.XamlMember(this, "PickerBackground", "Windows.UI.Xaml.Media.Brush");
                xamlMember.SetIsDependencyProperty();
                xamlMember.Getter = get_2_XLiveCredentialPicker_PickerBackground;
                xamlMember.Setter = set_2_XLiveCredentialPicker_PickerBackground;
                break;
            case "OpenXLive.WinRT.UI.XLiveCredentialPicker.SNSProvidersTemplate":
                userType = (global::OpenXLive.WinRT.UI.OpenXLive_WinRT_UI_XamlTypeInfo.XamlUserType)GetXamlTypeByName("OpenXLive.WinRT.UI.XLiveCredentialPicker");
                xamlMember = new global::OpenXLive.WinRT.UI.OpenXLive_WinRT_UI_XamlTypeInfo.XamlMember(this, "SNSProvidersTemplate", "Windows.UI.Xaml.DataTemplate");
                xamlMember.SetIsDependencyProperty();
                xamlMember.Getter = get_3_XLiveCredentialPicker_SNSProvidersTemplate;
                xamlMember.Setter = set_3_XLiveCredentialPicker_SNSProvidersTemplate;
                break;
            case "OpenXLive.WinRT.UI.XLiveCredentialPicker.SNSItemSource":
                userType = (global::OpenXLive.WinRT.UI.OpenXLive_WinRT_UI_XamlTypeInfo.XamlUserType)GetXamlTypeByName("OpenXLive.WinRT.UI.XLiveCredentialPicker");
                xamlMember = new global::OpenXLive.WinRT.UI.OpenXLive_WinRT_UI_XamlTypeInfo.XamlMember(this, "SNSItemSource", "System.Collections.IEnumerable");
                xamlMember.SetIsDependencyProperty();
                xamlMember.Getter = get_4_XLiveCredentialPicker_SNSItemSource;
                xamlMember.Setter = set_4_XLiveCredentialPicker_SNSItemSource;
                break;
            case "OpenXLive.WinRT.UI.WatermarkPasswordBox.WatermarkText":
                userType = (global::OpenXLive.WinRT.UI.OpenXLive_WinRT_UI_XamlTypeInfo.XamlUserType)GetXamlTypeByName("OpenXLive.WinRT.UI.WatermarkPasswordBox");
                xamlMember = new global::OpenXLive.WinRT.UI.OpenXLive_WinRT_UI_XamlTypeInfo.XamlMember(this, "WatermarkText", "Object");
                xamlMember.Getter = get_5_WatermarkPasswordBox_WatermarkText;
                xamlMember.Setter = set_5_WatermarkPasswordBox_WatermarkText;
                break;
            case "OpenXLive.WinRT.UI.WatermarkPasswordBox.WatermarkStyle":
                userType = (global::OpenXLive.WinRT.UI.OpenXLive_WinRT_UI_XamlTypeInfo.XamlUserType)GetXamlTypeByName("OpenXLive.WinRT.UI.WatermarkPasswordBox");
                xamlMember = new global::OpenXLive.WinRT.UI.OpenXLive_WinRT_UI_XamlTypeInfo.XamlMember(this, "WatermarkStyle", "Windows.UI.Xaml.Style");
                xamlMember.SetIsDependencyProperty();
                xamlMember.Getter = get_6_WatermarkPasswordBox_WatermarkStyle;
                xamlMember.Setter = set_6_WatermarkPasswordBox_WatermarkStyle;
                break;
            case "OpenXLive.WinRT.UI.WatermarkTextBox.WatermarkText":
                userType = (global::OpenXLive.WinRT.UI.OpenXLive_WinRT_UI_XamlTypeInfo.XamlUserType)GetXamlTypeByName("OpenXLive.WinRT.UI.WatermarkTextBox");
                xamlMember = new global::OpenXLive.WinRT.UI.OpenXLive_WinRT_UI_XamlTypeInfo.XamlMember(this, "WatermarkText", "String");
                xamlMember.SetIsDependencyProperty();
                xamlMember.Getter = get_7_WatermarkTextBox_WatermarkText;
                xamlMember.Setter = set_7_WatermarkTextBox_WatermarkText;
                break;
            case "OpenXLive.WinRT.UI.WatermarkTextBox.WatermarkStyle":
                userType = (global::OpenXLive.WinRT.UI.OpenXLive_WinRT_UI_XamlTypeInfo.XamlUserType)GetXamlTypeByName("OpenXLive.WinRT.UI.WatermarkTextBox");
                xamlMember = new global::OpenXLive.WinRT.UI.OpenXLive_WinRT_UI_XamlTypeInfo.XamlMember(this, "WatermarkStyle", "Windows.UI.Xaml.Style");
                xamlMember.SetIsDependencyProperty();
                xamlMember.Getter = get_8_WatermarkTextBox_WatermarkStyle;
                xamlMember.Setter = set_8_WatermarkTextBox_WatermarkStyle;
                break;
            }
            return xamlMember;
        }

    }

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlSystemBaseType : global::Windows.UI.Xaml.Markup.IXamlType
    {
        string _fullName;
        global::System.Type _underlyingType;

        public XamlSystemBaseType(string fullName, global::System.Type underlyingType)
        {
            _fullName = fullName;
            _underlyingType = underlyingType;
        }

        public string FullName { get { return _fullName; } }

        public global::System.Type UnderlyingType
        {
            get
            {
                return _underlyingType;
            }
        }

        virtual public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name) { throw new global::System.NotImplementedException(); }
        virtual public bool IsArray { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsCollection { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsConstructible { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsDictionary { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsMarkupExtension { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsBindable { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType ItemType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType KeyType { get { throw new global::System.NotImplementedException(); } }
        virtual public object ActivateInstance() { throw new global::System.NotImplementedException(); }
        virtual public void AddToMap(object instance, object key, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void AddToVector(object instance, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void RunInitializer()   { throw new global::System.NotImplementedException(); }
        virtual public object CreateFromString(global::System.String input)   { throw new global::System.NotImplementedException(); }
    }
    
    internal delegate object Activator();
    internal delegate void AddToCollection(object instance, object item);
    internal delegate void AddToDictionary(object instance, object key, object item);

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlUserType : global::OpenXLive.WinRT.UI.OpenXLive_WinRT_UI_XamlTypeInfo.XamlSystemBaseType
    {
        global::OpenXLive.WinRT.UI.OpenXLive_WinRT_UI_XamlTypeInfo.XamlTypeInfoProvider _provider;
        global::Windows.UI.Xaml.Markup.IXamlType _baseType;
        bool _isArray;
        bool _isMarkupExtension;
        bool _isBindable;

        string _contentPropertyName;
        string _itemTypeName;
        string _keyTypeName;
        global::System.Collections.Generic.Dictionary<string, string> _memberNames;
        global::System.Collections.Generic.Dictionary<string, object> _enumValues;

        public XamlUserType(global::OpenXLive.WinRT.UI.OpenXLive_WinRT_UI_XamlTypeInfo.XamlTypeInfoProvider provider, string fullName, global::System.Type fullType, global::Windows.UI.Xaml.Markup.IXamlType baseType)
            :base(fullName, fullType)
        {
            _provider = provider;
            _baseType = baseType;
        }

        // --- Interface methods ----

        override public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { return _baseType; } }
        override public bool IsArray { get { return _isArray; } }
        override public bool IsCollection { get { return (CollectionAdd != null); } }
        override public bool IsConstructible { get { return (Activator != null); } }
        override public bool IsDictionary { get { return (DictionaryAdd != null); } }
        override public bool IsMarkupExtension { get { return _isMarkupExtension; } }
        override public bool IsBindable { get { return _isBindable; } }

        override public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty
        {
            get { return _provider.GetMemberByLongName(_contentPropertyName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType ItemType
        {
            get { return _provider.GetXamlTypeByName(_itemTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType KeyType
        {
            get { return _provider.GetXamlTypeByName(_keyTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name)
        {
            if (_memberNames == null)
            {
                return null;
            }
            string longName;
            if (_memberNames.TryGetValue(name, out longName))
            {
                return _provider.GetMemberByLongName(longName);
            }
            return null;
        }

        override public object ActivateInstance()
        {
            return Activator(); 
        }

        override public void AddToMap(object instance, object key, object item) 
        {
            DictionaryAdd(instance, key, item);
        }

        override public void AddToVector(object instance, object item)
        {
            CollectionAdd(instance, item);
        }

        override public void RunInitializer() 
        {
            System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(UnderlyingType.TypeHandle);
        }

        override public global::System.Object CreateFromString(global::System.String input)
        {
            if (_enumValues != null)
            {
                global::System.Int32 value = 0;

                string[] valueParts = input.Split(',');

                foreach (string valuePart in valueParts) 
                {
                    object partValue;
                    global::System.Int32 enumFieldValue = 0;
                    try
                    {
                        if (_enumValues.TryGetValue(valuePart.Trim(), out partValue))
                        {
                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                        }
                        else
                        {
                            try
                            {
                                enumFieldValue = global::System.Convert.ToInt32(valuePart.Trim());
                            }
                            catch( global::System.FormatException )
                            {
                                foreach( string key in _enumValues.Keys )
                                {
                                    if( global::System.String.Compare(valuePart.Trim(), key, global::System.StringComparison.OrdinalIgnoreCase) == 0 )
                                    {
                                        if( _enumValues.TryGetValue(key.Trim(), out partValue) )
                                        {
                                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        value |= enumFieldValue; 
                    }
                    catch( global::System.FormatException )
                    {
                        throw new global::System.ArgumentException(input, FullName);
                    }
                }

                return value; 
            }
            throw new global::System.ArgumentException(input, FullName);
        }

        // --- End of Interface methods

        public Activator Activator { get; set; }
        public AddToCollection CollectionAdd { get; set; }
        public AddToDictionary DictionaryAdd { get; set; }

        public void SetContentPropertyName(string contentPropertyName)
        {
            _contentPropertyName = contentPropertyName;
        }

        public void SetIsArray()
        {
            _isArray = true; 
        }

        public void SetIsMarkupExtension()
        {
            _isMarkupExtension = true;
        }

        public void SetIsBindable()
        {
            _isBindable = true;
        }

        public void SetItemTypeName(string itemTypeName)
        {
            _itemTypeName = itemTypeName;
        }

        public void SetKeyTypeName(string keyTypeName)
        {
            _keyTypeName = keyTypeName;
        }

        public void AddMemberName(string shortName)
        {
            if(_memberNames == null)
            {
                _memberNames =  new global::System.Collections.Generic.Dictionary<string,string>();
            }
            _memberNames.Add(shortName, FullName + "." + shortName);
        }

        public void AddEnumValue(string name, object value)
        {
            if (_enumValues == null)
            {
                _enumValues = new global::System.Collections.Generic.Dictionary<string, object>();
            }
            _enumValues.Add(name, value);
        }
    }

    internal delegate object Getter(object instance);
    internal delegate void Setter(object instance, object value);

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlMember : global::Windows.UI.Xaml.Markup.IXamlMember
    {
        global::OpenXLive.WinRT.UI.OpenXLive_WinRT_UI_XamlTypeInfo.XamlTypeInfoProvider _provider;
        string _name;
        bool _isAttachable;
        bool _isDependencyProperty;
        bool _isReadOnly;

        string _typeName;
        string _targetTypeName;

        public XamlMember(global::OpenXLive.WinRT.UI.OpenXLive_WinRT_UI_XamlTypeInfo.XamlTypeInfoProvider provider, string name, string typeName)
        {
            _name = name;
            _typeName = typeName;
            _provider = provider;
        }

        public string Name { get { return _name; } }

        public global::Windows.UI.Xaml.Markup.IXamlType Type
        {
            get { return _provider.GetXamlTypeByName(_typeName); }
        }

        public void SetTargetTypeName(global::System.String targetTypeName)
        {
            _targetTypeName = targetTypeName;
        }
        public global::Windows.UI.Xaml.Markup.IXamlType TargetType
        {
            get { return _provider.GetXamlTypeByName(_targetTypeName); }
        }

        public void SetIsAttachable() { _isAttachable = true; }
        public bool IsAttachable { get { return _isAttachable; } }

        public void SetIsDependencyProperty() { _isDependencyProperty = true; }
        public bool IsDependencyProperty { get { return _isDependencyProperty; } }

        public void SetIsReadOnly() { _isReadOnly = true; }
        public bool IsReadOnly { get { return _isReadOnly; } }

        public Getter Getter { get; set; }
        public object GetValue(object instance)
        {
            if (Getter != null)
                return Getter(instance);
            else
                throw new global::System.InvalidOperationException("GetValue");
        }

        public Setter Setter { get; set; }
        public void SetValue(object instance, object value)
        {
            if (Setter != null)
                Setter(instance, value);
            else
                throw new global::System.InvalidOperationException("SetValue");
        }
    }
}

