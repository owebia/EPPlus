﻿/*************************************************************************************************
  Required Notice: Copyright (C) EPPlus Software AB. 
  This software is licensed under PolyForm Noncommercial License 1.0.0 
  and may only be used for noncommercial purposes 
  https://polyformproject.org/licenses/noncommercial/1.0.0/

  A commercial license to use this software can be purchased at https://epplussoftware.com
 *************************************************************************************************
  Date               Author                       Change
 *************************************************************************************************
    10/21/2020         EPPlus Software AB           Controls 
 *************************************************************************************************/
using OfficeOpenXml.Packaging;
using System.Xml;

namespace OfficeOpenXml.Drawing.Controls
{
    public class ExcelControlSpin : ExcelControl
    {
        internal ExcelControlSpin(ExcelDrawings drawings, XmlNode drawNode, ControlInternal control, ZipPackageRelationship rel, XmlDocument controlPropertiesXml)
            : base(drawings, drawNode, control, rel,  controlPropertiesXml, null)
        {
        }

        public override eControlType ControlType => eControlType.Spin;

    }
}