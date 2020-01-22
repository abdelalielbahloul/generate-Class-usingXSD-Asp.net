using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace generateClassFromXSD.Models
{
    public class planetCatalog
    {
    }

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class CATALOG
    {

        private CATALOGPLANT[] pLANTField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PLANT")]
        public CATALOGPLANT[] PLANT
        {
            get
            {
                return this.pLANTField;
            }
            set
            {
                this.pLANTField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class CATALOGPLANT
    {
        [NonSerialized]
        private string cOMMONField;
        [NonSerialized]

        private string bOTANICALField;
        [NonSerialized]

        private string zONEField;
        [NonSerialized]

        private string lIGHTField;
        [NonSerialized]

        private string pRICEField;
        [NonSerialized]

        private uint aVAILABILITYField;

        /// <remarks/>
        public string COMMON
        {
            get
            {
                return this.cOMMONField;
            }
            set
            {
                this.cOMMONField = value;
            }
        }

        /// <remarks/>
        public string BOTANICAL
        {
            get
            {
                return this.bOTANICALField;
            }
            set
            {
                this.bOTANICALField = value;
            }
        }

        /// <remarks/>
        public string ZONE
        {
            get
            {
                return this.zONEField;
            }
            set
            {
                this.zONEField = value;
            }
        }

        /// <remarks/>
        public string LIGHT
        {
            get
            {
                return this.lIGHTField;
            }
            set
            {
                this.lIGHTField = value;
            }
        }

        /// <remarks/>
        public string PRICE
        {
            get
            {
                return this.pRICEField;
            }
            set
            {
                this.pRICEField = value;
            }
        }

        /// <remarks/>
        public uint AVAILABILITY
        {
            get
            {
                return this.aVAILABILITYField;
            }
            set
            {
                this.aVAILABILITYField = value;
            }
        }
    }


}
