namespace BoardGameGeekAPI.BGGObjects
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1590.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class userBuddies {
        
        private userBuddiesBuddy[] buddyField;
        
        private string pageField;
        
        private string totalField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("buddy", Form=System.Xml.Schema.XmlSchemaForm.Unqualified)]
        public userBuddiesBuddy[] buddy {
            get {
                return this.buddyField;
            }
            set {
                this.buddyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string page {
            get {
                return this.pageField;
            }
            set {
                this.pageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string total {
            get {
                return this.totalField;
            }
            set {
                this.totalField = value;
            }
        }
    }
}