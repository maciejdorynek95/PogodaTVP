namespace PogodaTVP.Core.Models.Cumulus_old
{
        // UWAGA: Wygenerowany kod może wymagać co najmniej programu .NET Framework 4.5 lub .NET Core/Standard 2.0.
        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false, ElementName = "meteomax")]
        public partial class MeteoMaxWeather
        {

            private meteomaxMeta metaField;

            private meteomaxDictionaries dictionariesField;

            private meteomaxForecastRecords forecastRecordsField;

            /// <remarks/>
            public meteomaxMeta meta
            {
                get
                {
                    return this.metaField;
                }
                set
                {
                    this.metaField = value;
                }
            }

            /// <remarks/>
            public meteomaxDictionaries dictionaries
            {
                get
                {
                    return this.dictionariesField;
                }
                set
                {
                    this.dictionariesField = value;
                }
            }

            /// <remarks/>
            public meteomaxForecastRecords forecastRecords
            {
                get
                {
                    return this.forecastRecordsField;
                }
                set
                {
                    this.forecastRecordsField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class meteomaxMeta
        {

            private string authorField;

            private string customerField;

            private string updateTimeField;

            private string timeZoneField;

            /// <remarks/>
            public string author
            {
                get
                {
                    return this.authorField;
                }
                set
                {
                    this.authorField = value;
                }
            }

            /// <remarks/>
            public string customer
            {
                get
                {
                    return this.customerField;
                }
                set
                {
                    this.customerField = value;
                }
            }

            /// <remarks/>
            public string updateTime
            {
                get
                {
                    return this.updateTimeField;
                }
                set
                {
                    this.updateTimeField = value;
                }
            }

            /// <remarks/>
            public string timeZone
            {
                get
                {
                    return this.timeZoneField;
                }
                set
                {
                    this.timeZoneField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class meteomaxDictionaries
        {

            private meteomaxDictionariesUnits unitsField;

            private meteomaxDictionariesCloud[] cloudsField;

            private meteomaxDictionariesCondition[] conditionsField;

            /// <remarks/>
            public meteomaxDictionariesUnits units
            {
                get
                {
                    return this.unitsField;
                }
                set
                {
                    this.unitsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("cloud", IsNullable = false)]
            public meteomaxDictionariesCloud[] clouds
            {
                get
                {
                    return this.cloudsField;
                }
                set
                {
                    this.cloudsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("condition", IsNullable = false)]
            public meteomaxDictionariesCondition[] conditions
            {
                get
                {
                    return this.conditionsField;
                }
                set
                {
                    this.conditionsField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class meteomaxDictionariesUnits
        {

            private string temperatureField;

            private string windField;

            private string pressureField;

            /// <remarks/>
            public string temperature
            {
                get
                {
                    return this.temperatureField;
                }
                set
                {
                    this.temperatureField = value;
                }
            }

            /// <remarks/>
            public string wind
            {
                get
                {
                    return this.windField;
                }
                set
                {
                    this.windField = value;
                }
            }

            /// <remarks/>
            public string pressure
            {
                get
                {
                    return this.pressureField;
                }
                set
                {
                    this.pressureField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class meteomaxDictionariesCloud
        {

            private byte valueField;

            private string descriptionField;

            /// <remarks/>
            public byte value
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

            /// <remarks/>
            public string description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class meteomaxDictionariesCondition
        {

            private ushort valueField;

            private string descriptionField;

            /// <remarks/>
            public ushort value
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

            /// <remarks/>
            public string description
            {
                get
                {
                    return this.descriptionField;
                }
                set
                {
                    this.descriptionField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class meteomaxForecastRecords
        {

            private meteomaxForecastRecordsCity cityField;

            /// <remarks/>
            public meteomaxForecastRecordsCity city
            {
                get
                {
                    return this.cityField;
                }
                set
                {
                    this.cityField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class meteomaxForecastRecordsCity
        {

            private meteomaxForecastRecordsCityDay[] dayField;

            private string nameField;

            private string regionField;

            private string countryField;

            private decimal latField;

            private decimal lonField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("day")]
            public meteomaxForecastRecordsCityDay[] day
            {
                get
                {
                    return this.dayField;
                }
                set
                {
                    this.dayField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string region
            {
                get
                {
                    return this.regionField;
                }
                set
                {
                    this.regionField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string country
            {
                get
                {
                    return this.countryField;
                }
                set
                {
                    this.countryField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal lat
            {
                get
                {
                    return this.latField;
                }
                set
                {
                    this.latField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public decimal lon
            {
                get
                {
                    return this.lonField;
                }
                set
                {
                    this.lonField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class meteomaxForecastRecordsCityDay
        {

            private meteomaxForecastRecordsCityDayTime[] timeField;

            private object summaryField;

            private System.DateTime dateField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("time")]
            public meteomaxForecastRecordsCityDayTime[] time
            {
                get
                {
                    return this.timeField;
                }
                set
                {
                    this.timeField = value;
                }
            }

            /// <remarks/>
            public object summary
            {
                get
                {
                    return this.summaryField;
                }
                set
                {
                    this.summaryField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
            public System.DateTime date
            {
                get
                {
                    return this.dateField;
                }
                set
                {
                    this.dateField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class meteomaxForecastRecordsCityDayTime
        {

            private byte tempField;

            private byte windSpeedField;

            private byte windGustField;

            private string windDirectionField;

            private byte cloudsField;

            private ushort conditionsField;

            private string partField;

            /// <remarks/>
            public byte temp
            {
                get
                {
                    return this.tempField;
                }
                set
                {
                    this.tempField = value;
                }
            }

            /// <remarks/>
            public byte windSpeed
            {
                get
                {
                    return this.windSpeedField;
                }
                set
                {
                    this.windSpeedField = value;
                }
            }

            /// <remarks/>
            public byte windGust
            {
                get
                {
                    return this.windGustField;
                }
                set
                {
                    this.windGustField = value;
                }
            }

            /// <remarks/>
            public string windDirection
            {
                get
                {
                    return this.windDirectionField;
                }
                set
                {
                    this.windDirectionField = value;
                }
            }

            /// <remarks/>
            public byte clouds
            {
                get
                {
                    return this.cloudsField;
                }
                set
                {
                    this.cloudsField = value;
                }
            }

            /// <remarks/>
            public ushort conditions
            {
                get
                {
                    return this.conditionsField;
                }
                set
                {
                    this.conditionsField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string part
            {
                get
                {
                    return this.partField;
                }
                set
                {
                    this.partField = value;
                }
            }
        }


    
}
