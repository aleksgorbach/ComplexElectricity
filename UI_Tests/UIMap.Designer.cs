﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      Этот код был создан построителем кодированных тестов ИП.
//      Версия: 14.0.0.0
//
//      Изменения, внесенные в этот файл, могут привести к неправильной работе кода и будут
//      утрачены при повторном формировании кода.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace UI_Tests
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
    
    
    [GeneratedCode("Построитель кодированных тестов ИП", "14.0.23107.0")]
    public partial class UIMap
    {
        
        /// <summary>
        /// RecordedMethod1
        /// </summary>
        public void RecordedMethod1()
        {
            #region Variable Declarations
            WinList uIItemList = this.UIItemWindow.UIFolderViewWindow.UIItemList;
            #endregion

            // Щелкните список
            Mouse.Click(uIItemList, new Point(1651, 322));

            // Перемещение  список
            Mouse.StartDragging(uIItemList, new Point(1636, 381));
            Mouse.StopDragging(uIItemList, 4, 40);

            // Перемещение  список
            Mouse.StartDragging(uIItemList, new Point(1699, 542));
            Mouse.StopDragging(uIItemList, 21, 27);

            // Перемещение  список
            Mouse.StartDragging(uIItemList, new Point(1675, 656));
            Mouse.StopDragging(uIItemList, -146, -247);
        }
        
        #region Properties
        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow();
                }
                return this.mUIItemWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIItemWindow mUIItemWindow;
        #endregion
    }
    
    [GeneratedCode("Построитель кодированных тестов ИП", "14.0.23107.0")]
    public class UIItemWindow : WinWindow
    {
        
        public UIItemWindow()
        {
            #region Условия поиска
            this.SearchProperties[WinWindow.PropertyNames.AccessibleName] = "Рабочий стол";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "#32769";
            #endregion
        }
        
        #region Properties
        public UIFolderViewWindow UIFolderViewWindow
        {
            get
            {
                if ((this.mUIFolderViewWindow == null))
                {
                    this.mUIFolderViewWindow = new UIFolderViewWindow(this);
                }
                return this.mUIFolderViewWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIFolderViewWindow mUIFolderViewWindow;
        #endregion
    }
    
    [GeneratedCode("Построитель кодированных тестов ИП", "14.0.23107.0")]
    public class UIFolderViewWindow : WinWindow
    {
        
        public UIFolderViewWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Условия поиска
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "1";
            #endregion
        }
        
        #region Properties
        public WinList UIItemList
        {
            get
            {
                if ((this.mUIItemList == null))
                {
                    this.mUIItemList = new WinList(this);
                }
                return this.mUIItemList;
            }
        }
        #endregion
        
        #region Fields
        private WinList mUIItemList;
        #endregion
    }
}
