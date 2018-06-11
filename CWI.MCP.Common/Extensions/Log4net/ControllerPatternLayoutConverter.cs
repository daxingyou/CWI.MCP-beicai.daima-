﻿//---------------------------------------------
// 版权信息：版权所有(C) 2015，COOLWI.COM
// 变更历史：
//      姓名          日期              说明
// --------------------------------------------
//      王军锋        2012/10/24        创建
//---------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net.Layout.Pattern;
using System.IO;
using log4net.Core;

namespace  CWI.MCP.Common.Extensions.Log4net
{
    /// <summary>
    /// Controller Converter
    /// </summary>
    public class ControllerPatternLayoutConverter : PatternLayoutConverter
    {
        /// <summary>
        /// 转换指定属性的值
        /// </summary>
        /// <param name="writer">writer</param>
        /// <param name="loggingEvent">loggingEvent</param>
        protected override void Convert(TextWriter writer, LoggingEvent loggingEvent)
        {
            ExtensionInternalUtils.Write(writer, loggingEvent, "Controller");
        }
    }
}
