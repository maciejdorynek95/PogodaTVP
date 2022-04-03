using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PogodaTVP.Core.Models.Cumulus2
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class meteomax
    {

        private meteomaxMeta metaField;

        private meteomaxDictionaries dictionariesField;

        private meteomaxCity[] forecastRecordsField;

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
        [System.Xml.Serialization.XmlArrayItemAttribute("city", IsNullable = false)]
        public meteomaxCity[] forecastRecords
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

        private meteomaxDictionariesMoonPhase[] moonPhasesField;

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

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("moonPhase", IsNullable = false)]
        public meteomaxDictionariesMoonPhase[] moonPhases
        {
            get
            {
                return this.moonPhasesField;
            }
            set
            {
                this.moonPhasesField = value;
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

        private sbyte valueField;

        private string descriptionField;

        /// <remarks/>
        public sbyte value
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
    public partial class meteomaxDictionariesMoonPhase
    {

        private sbyte valueField;

        private string descriptionField;

        /// <remarks/>
        public sbyte value
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
    public partial class meteomaxCity
    {

        private meteomaxCityDay[] dayField;

        private string nameField;

        private string regionField;

        private string countryField;

        private decimal latField;

        private decimal lonField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("day")]
        public meteomaxCityDay[] day
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
    public partial class meteomaxCityDay
    {

        private meteomaxCityDayTime[] timeField;

        private meteomaxCityDaySummary summaryField;

        private System.DateTime dateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("time")]
        public meteomaxCityDayTime[] time
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
        public meteomaxCityDaySummary summary
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
    public partial class meteomaxCityDayTime
    {

        private sbyte tempField;

        private byte windSpeedField;

        private byte windGustField;

        private string windDirectionField;

        private byte cloudsField;

        private ushort conditionsField;

        private string pressureSLPField;

        private string pressureTrendField;

        private string partField;

        /// <remarks/>
        public sbyte temp
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
        public string pressureSLP
        {
            get
            {
                return this.pressureSLPField;
            }
            set
            {
                this.pressureSLPField = value;
            }
        }

        /// <remarks/>
        public string pressureTrend
        {
            get
            {
                return this.pressureTrendField;
            }
            set
            {
                this.pressureTrendField = value;
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

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class meteomaxCityDaySummary
    {

        private meteomaxCityDaySummaryTempDayMin tempDayMinField;

        private meteomaxCityDaySummaryTempDayMax tempDayMaxField;

        private System.DateTime sunriseField;

        private System.DateTime sunsetField;

        private System.DateTime dayLengthField;

        private byte moonPhaseField;

        /// <remarks/>
        public meteomaxCityDaySummaryTempDayMin tempDayMin
        {
            get
            {
                return this.tempDayMinField;
            }
            set
            {
                this.tempDayMinField = value;
            }
        }

        /// <remarks/>
        public meteomaxCityDaySummaryTempDayMax tempDayMax
        {
            get
            {
                return this.tempDayMaxField;
            }
            set
            {
                this.tempDayMaxField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "time")]
        public System.DateTime sunrise
        {
            get
            {
                return this.sunriseField;
            }
            set
            {
                this.sunriseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "time")]
        public System.DateTime sunset
        {
            get
            {
                return this.sunsetField;
            }
            set
            {
                this.sunsetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "time")]
        public System.DateTime dayLength
        {
            get
            {
                return this.dayLengthField;
            }
            set
            {
                this.dayLengthField = value;
            }
        }

        /// <remarks/>
        public byte moonPhase
        {
            get
            {
                return this.moonPhaseField;
            }
            set
            {
                this.moonPhaseField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class meteomaxCityDaySummaryTempDayMin
    {

        private meteomaxCityDaySummaryTempDayMinTime timeField;

        private sbyte valueField;

        /// <remarks/>
        public meteomaxCityDaySummaryTempDayMinTime time
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
        public sbyte value
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

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class meteomaxCityDaySummaryTempDayMinTime
    {

        private string hourField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string hour
        {
            get
            {
                return this.hourField;
            }
            set
            {
                this.hourField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class meteomaxCityDaySummaryTempDayMax
    {

        private meteomaxCityDaySummaryTempDayMaxTime timeField;

        private byte valueField;

        /// <remarks/>
        public meteomaxCityDaySummaryTempDayMaxTime time
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
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class meteomaxCityDaySummaryTempDayMaxTime
    {

        private string hourField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string hour
        {
            get
            {
                return this.hourField;
            }
            set
            {
                this.hourField = value;
            }
        }
    }


}
