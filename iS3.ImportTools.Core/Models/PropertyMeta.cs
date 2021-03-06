﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iS3.ImportTools.Core.Models
{
    /// <summary>
    /// attributes of perporty
    /// </summary>
   public class PropertyMeta:LangBase
    {
        public bool isKey { get; set; }
        public string PropertyName { get; set; }
        public string DataType { get; set; }
        public string Unit { get; set; }
        public string Description { get; set; }
        public PropertyMeta()
        {

        }
        public PropertyMeta(string propertyName,string dataType,string unit,string description,string langStr, bool isKey = false)
        {
            this.LangStr = langStr;
            this.PropertyName = propertyName;
            this.DataType = dataType;
            this.Unit = unit;
            this.Description = description;
            this.isKey = isKey;
        }
    }
}
