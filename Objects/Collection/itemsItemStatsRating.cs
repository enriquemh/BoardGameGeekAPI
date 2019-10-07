namespace BoardGameGeekAPI.BGGObjects
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1590.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class itemsItemStatsRating
    {

        private itemsItemStatsRatingUsersrated[] usersratedField;

        private itemsItemStatsRatingAverage[] averageField;

        private itemsItemStatsRatingBayesaverage[] bayesaverageField;

        private itemsItemStatsRatingStddev[] stddevField;

        private itemsItemStatsRatingMedian[] medianField;

        private itemsItemStatsRatingRanksRank[] ranksField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("usersrated", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public itemsItemStatsRatingUsersrated[] usersrated
        {
            get
            {
                return this.usersratedField;
            }
            set
            {
                this.usersratedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("average", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public itemsItemStatsRatingAverage[] average
        {
            get
            {
                return this.averageField;
            }
            set
            {
                this.averageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("bayesaverage", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public itemsItemStatsRatingBayesaverage[] bayesaverage
        {
            get
            {
                return this.bayesaverageField;
            }
            set
            {
                this.bayesaverageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("stddev", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public itemsItemStatsRatingStddev[] stddev
        {
            get
            {
                return this.stddevField;
            }
            set
            {
                this.stddevField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("median", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public itemsItemStatsRatingMedian[] median
        {
            get
            {
                return this.medianField;
            }
            set
            {
                this.medianField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
        [System.Xml.Serialization.XmlArrayItemAttribute("rank", typeof(itemsItemStatsRatingRanksRank), Form = System.Xml.Schema.XmlSchemaForm.Unqualified, IsNullable = false)]
        public itemsItemStatsRatingRanksRank[] ranks
        {
            get
            {
                return this.ranksField;
            }
            set
            {
                this.ranksField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
}