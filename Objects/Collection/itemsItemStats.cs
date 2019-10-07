namespace BoardGameGeekAPI.BGGObjects
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1590.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class itemsItemStats
    {

        private itemsItemStatsRating[] ratingField;

        private string minplayersField;

        private string maxplayersField;

        private string minplaytimeField;

        private string maxplaytimeField;

        private string playingtimeField;

        private string numownedField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("rating", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public itemsItemStatsRating[] rating
        {
            get
            {
                return this.ratingField;
            }
            set
            {
                this.ratingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string minplayers
        {
            get
            {
                return this.minplayersField;
            }
            set
            {
                this.minplayersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string maxplayers
        {
            get
            {
                return this.maxplayersField;
            }
            set
            {
                this.maxplayersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string minplaytime
        {
            get
            {
                return this.minplaytimeField;
            }
            set
            {
                this.minplaytimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string maxplaytime
        {
            get
            {
                return this.maxplaytimeField;
            }
            set
            {
                this.maxplaytimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string playingtime
        {
            get
            {
                return this.playingtimeField;
            }
            set
            {
                this.playingtimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string numowned
        {
            get
            {
                return this.numownedField;
            }
            set
            {
                this.numownedField = value;
            }
        }
    }
}