﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Autodesk.Revit.UI;
using Autodesk.Revit.DB;
using Autodesk.Revit.Attributes;

namespace BNJRevitAddinTemplate
{
    internal class App : IExternalApplication
    {
        public Result OnStartup(UIControlledApplication app)
        {
            //// 1. Create ribbon tab
            //string tabName = "B&J";
            //try
            //{
            //    app.CreateRibbonTab(tabName);
            //}
            //catch (Exception)
            //{
            //    Debug.Print("Tab already exists.");
            //}

            //// 2. Create ribbon panel 
            //RibbonPanel panel = Common.Utils.CreateRibbonPanel(app, tabName, "Revit Tools");

            //// 3. Create button data instances
            //PushButtonData btnData1 = Command1.GetButtonData();
            //PushButtonData btnData2 = Command2.GetButtonData();

            //// 4. Create buttons
            //PushButton myButton1 = panel.AddItem(btnData1) as PushButton;
            //PushButton myButton2 = panel.AddItem(btnData2) as PushButton;

            // NOTE:
            // To create a new tool, copy lines 35 and 39 and rename the variables to "btnData3" and "myButton3". 
            // Change the name of the tool in the arguments of line 

            return Result.Succeeded;
        }

        public Result OnShutdown(UIControlledApplication a)
        {
            return Result.Succeeded;
        }
    }

}
