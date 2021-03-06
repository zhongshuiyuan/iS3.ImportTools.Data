﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iS3.ImportTools.Core.Models
{
    public class DataStandardDef:LangBase
    {
        public string Code { get; set; }
        public string Description { get; set; }

        public List<DomainDef> DomainContainer { get; set; }
        public DataStandardDef()
        {
            DomainContainer = new List<DomainDef>();
        }
        public DGObjectDef getDGObjectDefByCode(string Code)
        {
            foreach (var domain in DomainContainer)
            {
                foreach (var DGObject in domain.DGObjectContainer)
                {
                    if (DGObject.Code==Code)
                    {
                        return DGObject;
                    }
                }
            }
            return null;
        }
    }
}
