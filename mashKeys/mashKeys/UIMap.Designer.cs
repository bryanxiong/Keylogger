﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 14.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace mashKeys
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public partial class UIMap
    {
        
        /// <summary>
        /// press keys simultaneously to try and cause error
        /// </summary>
        public void mashedKeys()
        {
            #region Variable Declarations
            WinEdit uIItemEdit = this.UIUntitledNotepadWindow.UIItemWindow.UIItemEdit;
            #endregion

            // Type 'a38ow7tya39fpw384qhag973w4yhuag89wh9aoghe9qh3w4' in text box
            uIItemEdit.Text = this.mashedKeysParams.UIItemEditText;
        }
        
        #region Properties
        public virtual mashedKeysParams mashedKeysParams
        {
            get
            {
                if ((this.mmashedKeysParams == null))
                {
                    this.mmashedKeysParams = new mashedKeysParams();
                }
                return this.mmashedKeysParams;
            }
        }
        
        public UIUntitledNotepadWindow UIUntitledNotepadWindow
        {
            get
            {
                if ((this.mUIUntitledNotepadWindow == null))
                {
                    this.mUIUntitledNotepadWindow = new UIUntitledNotepadWindow();
                }
                return this.mUIUntitledNotepadWindow;
            }
        }
        #endregion
        
        #region Fields
        private mashedKeysParams mmashedKeysParams;
        
        private UIUntitledNotepadWindow mUIUntitledNotepadWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'mashedKeys'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class mashedKeysParams
    {
        
        #region Fields
        /// <summary>
        /// Type 'a38ow7tya39fpw384qhag973w4yhuag89wh9aoghe9qh3w4' in text box
        /// </summary>
        public string UIItemEditText = "a38ow7tya39fpw384qhag973w4yhuag89wh9aoghe9qh3w4";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIUntitledNotepadWindow : WinWindow
    {
        
        public UIUntitledNotepadWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Untitled - Notepad";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "Notepad";
            this.WindowTitles.Add("Untitled - Notepad");
            #endregion
        }
        
        #region Properties
        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow(this);
                }
                return this.mUIItemWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIItemWindow mUIItemWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIItemWindow : WinWindow
    {
        
        public UIItemWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "15";
            this.WindowTitles.Add("Untitled - Notepad");
            #endregion
        }
        
        #region Properties
        public WinEdit UIItemEdit
        {
            get
            {
                if ((this.mUIItemEdit == null))
                {
                    this.mUIItemEdit = new WinEdit(this);
                    #region Search Criteria
                    this.mUIItemEdit.WindowTitles.Add("Untitled - Notepad");
                    #endregion
                }
                return this.mUIItemEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUIItemEdit;
        #endregion
    }
}
