// Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
using System.Collections.Generic;
using System.Text.Json.Serialization;

public class StrDB
{
    [JsonPropertyName("localeString")]
    public string LocaleString { get; set; }

    [JsonPropertyName("str")]
    public string Str { get; set; }
}

public class CapsuleNameLocalized
{
    [JsonPropertyName("strDB")]
    public List<StrDB> StrDB { get; set; }
}

public class UiName
{
    [JsonPropertyName("strDB")]
    public List<StrDB> StrDB { get; set; }
}

public class UiSuffix
{
    [JsonPropertyName("strDB")]
    public List<object> StrDB { get; set; }
}

public class UiToolTip
{
    [JsonPropertyName("strDB")]
    public List<object> StrDB { get; set; }
}

public class AlternateRectInfo
{
    [JsonPropertyName("compId")]
    public int CompId { get; set; }

    [JsonPropertyName("isEnabled")]
    public bool IsEnabled { get; set; }

    [JsonPropertyName("layerId")]
    public int LayerId { get; set; }
}

public class Fonteditinfo
{
    [JsonPropertyName("capPropFontEdit")]
    public bool CapPropFontEdit { get; set; }

    [JsonPropertyName("capPropFontFauxStyleEdit")]
    public bool CapPropFontFauxStyleEdit { get; set; }

    [JsonPropertyName("capPropFontSizeEdit")]
    public bool CapPropFontSizeEdit { get; set; }

    [JsonPropertyName("fontEditValue")]
    public string FontEditValue { get; set; }

    [JsonPropertyName("fontFSAllCapsValue")]
    public bool FontFSAllCapsValue { get; set; }

    [JsonPropertyName("fontFSBoldValue")]
    public bool FontFSBoldValue { get; set; }

    [JsonPropertyName("fontFSItalicValue")]
    public bool FontFSItalicValue { get; set; }

    [JsonPropertyName("fontFSSmallCapsValue")]
    public bool FontFSSmallCapsValue { get; set; }

    [JsonPropertyName("fontSizeEditValue")]
    public int FontSizeEditValue { get; set; }
}

public class ClientControl
{
    [JsonPropertyName("canAnimate")]
    public bool CanAnimate { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("type")]
    public int Type { get; set; }

    [JsonPropertyName("uiName")]
    public UiName UiName { get; set; }

    [JsonPropertyName("uiSuffix")]
    public UiSuffix UiSuffix { get; set; }

    [JsonPropertyName("uiToolTip")]
    public UiToolTip UiToolTip { get; set; }

    [JsonPropertyName("value")]
    public object Value { get; set; }

    [JsonPropertyName("value")]
    public Value Value2 { get; set; }

    [JsonPropertyName("alternateRectInfo")]
    public AlternateRectInfo AlternateRectInfo { get; set; }

    [JsonPropertyName("fonteditinfo")]
    public Fonteditinfo Fonteditinfo { get; set; }

    [JsonPropertyName("groupexpanded")]
    public bool? Groupexpanded { get; set; }
}

public class Value
{
    [JsonPropertyName("strDB")]
    List<StrDB> StrDB { get; set; }
}


public class MAssetInfo
{
    [JsonPropertyName("mAssetIdentifier")]
    public string MAssetIdentifier { get; set; }

    [JsonPropertyName("mProductionIdentifier")]
    public string MProductionIdentifier { get; set; }

    [JsonPropertyName("mProductionRevision")]
    public string MProductionRevision { get; set; }
}

public class MServerConnectInfo
{
    [JsonPropertyName("mAuthToken")]
    public string MAuthToken { get; set; }

    [JsonPropertyName("mEARPort")]
    public string MEARPort { get; set; }

    [JsonPropertyName("mUserName")]
    public string MUserName { get; set; }
}

public class Anywhereassetrequestinfo
{
    [JsonPropertyName("mAssetInfo")]
    public MAssetInfo MAssetInfo { get; set; }

    [JsonPropertyName("mServerConnectInfo")]
    public MServerConnectInfo MServerConnectInfo { get; set; }
}

public class MProductionInfo
{
    [JsonPropertyName("mDisplayName")]
    public string MDisplayName { get; set; }

    [JsonPropertyName("mProductionIdentifier")]
    public string MProductionIdentifier { get; set; }

    [JsonPropertyName("mRevision")]
    public string MRevision { get; set; }
}

public class Anywhereproductionrequestinfo
{
    [JsonPropertyName("mProductionInfo")]
    public MProductionInfo MProductionInfo { get; set; }

    [JsonPropertyName("mServerConnectInfo")]
    public MServerConnectInfo MServerConnectInfo { get; set; }
}

public class Audiochannellayout
{
    [JsonPropertyName("channellabel")]
    public int Channellabel { get; set; }
}

public class Audiosamplerate
{
    [JsonPropertyName("ticksperframe")]
    public int Ticksperframe { get; set; }
}

public class CapParam
{
    [JsonPropertyName("capPropAnimatable")]
    public bool CapPropAnimatable { get; set; }

    [JsonPropertyName("capPropDefault")]
    public object CapPropDefault { get; set; }

    [JsonPropertyName("capPropMatchName")]
    public string CapPropMatchName { get; set; }

    [JsonPropertyName("capPropType")]
    public int CapPropType { get; set; }

    [JsonPropertyName("capPropUIName")]
    public string CapPropUIName { get; set; }

    [JsonPropertyName("capPropFontEdit")]
    public bool? CapPropFontEdit { get; set; }

    [JsonPropertyName("capPropFontFauxStyleEdit")]
    public bool? CapPropFontFauxStyleEdit { get; set; }

    [JsonPropertyName("capPropFontSizeEdit")]
    public bool? CapPropFontSizeEdit { get; set; }

    [JsonPropertyName("capPropTextRunCount")]
    public int? CapPropTextRunCount { get; set; }

    [JsonPropertyName("fontEditValue")]
    public List<string> FontEditValue { get; set; }

    [JsonPropertyName("fontFSAllCapsValue")]
    public List<bool> FontFSAllCapsValue { get; set; }

    [JsonPropertyName("fontFSBoldValue")]
    public List<bool> FontFSBoldValue { get; set; }

    [JsonPropertyName("fontFSItalicValue")]
    public List<bool> FontFSItalicValue { get; set; }

    [JsonPropertyName("fontFSSmallCapsValue")]
    public List<bool> FontFSSmallCapsValue { get; set; }

    [JsonPropertyName("fontSizeEditValue")]
    public List<int> FontSizeEditValue { get; set; }

    [JsonPropertyName("fontTextRunLength")]
    public List<int> FontTextRunLength { get; set; }

    [JsonPropertyName("textEditValue")]
    public string TextEditValue { get; set; }

    [JsonPropertyName("capPropGroupExpanded")]
    public bool? CapPropGroupExpanded { get; set; }
}

public class Capsuleparams
{
    [JsonPropertyName("capParams")]
    public List<CapParam> CapParams { get; set; }
}

public class BaseColorProfile
{
    [JsonPropertyName("colorProfileName")]
    public string ColorProfileName { get; set; }
}

public class ColorSpace
{
    [JsonPropertyName("baseColorProfile")]
    public BaseColorProfile BaseColorProfile { get; set; }

    [JsonPropertyName("baseProfileType")]
    public int BaseProfileType { get; set; }
}

public class Currenttime
{
    [JsonPropertyName("scale")]
    public int Scale { get; set; }

    [JsonPropertyName("value")]
    public int Value { get; set; }
}

public class Duration
{
    [JsonPropertyName("scale")]
    public int Scale { get; set; }

    [JsonPropertyName("value")]
    public int Value { get; set; }
}

public class Framerate
{
    [JsonPropertyName("ticksperframe")]
    public long Ticksperframe { get; set; }
}

public class Size
{
    [JsonPropertyName("x")]
    public int X { get; set; }

    [JsonPropertyName("y")]
    public int Y { get; set; }
}

public class Topleft
{
    [JsonPropertyName("x")]
    public int X { get; set; }

    [JsonPropertyName("y")]
    public int Y { get; set; }
}

public class Framesize
{
    [JsonPropertyName("size")]
    public Size Size { get; set; }

    [JsonPropertyName("topleft")]
    public Topleft Topleft { get; set; }
}

public class Inpoint
{
    [JsonPropertyName("scale")]
    public int Scale { get; set; }

    [JsonPropertyName("value")]
    public int Value { get; set; }
}

public class Outpoint
{
    [JsonPropertyName("scale")]
    public int Scale { get; set; }

    [JsonPropertyName("value")]
    public int Value { get; set; }
}

public class Pixelaspectratio
{
    [JsonPropertyName("denominator")]
    public int Denominator { get; set; }

    [JsonPropertyName("numerator")]
    public int Numerator { get; set; }
}

public class Pixelformatlist
{
    [JsonPropertyName("fourcc")]
    public int Fourcc { get; set; }

    [JsonPropertyName("properties")]
    public int Properties { get; set; }
}

public class Starttime
{
    [JsonPropertyName("scale")]
    public int Scale { get; set; }

    [JsonPropertyName("value")]
    public int Value { get; set; }
}

public class Workinpoint
{
    [JsonPropertyName("scale")]
    public int Scale { get; set; }

    [JsonPropertyName("value")]
    public int Value { get; set; }
}

public class Workoutpoint
{
    [JsonPropertyName("scale")]
    public int Scale { get; set; }

    [JsonPropertyName("value")]
    public int Value { get; set; }
}

public class EnUS
{
    [JsonPropertyName("alphachanneltype")]
    public int Alphachanneltype { get; set; }

    [JsonPropertyName("alphamattecolorb")]
    public int Alphamattecolorb { get; set; }

    [JsonPropertyName("alphamattecolorg")]
    public int Alphamattecolorg { get; set; }

    [JsonPropertyName("alphamattecolorr")]
    public int Alphamattecolorr { get; set; }

    [JsonPropertyName("anywhereassetrequestinfo")]
    public Anywhereassetrequestinfo Anywhereassetrequestinfo { get; set; }

    [JsonPropertyName("anywhereproductionrequestinfo")]
    public Anywhereproductionrequestinfo Anywhereproductionrequestinfo { get; set; }

    [JsonPropertyName("appspecificsourceinfo")]
    public string Appspecificsourceinfo { get; set; }

    [JsonPropertyName("audiochannellayout")]
    public List<Audiochannellayout> Audiochannellayout { get; set; }

    [JsonPropertyName("audiosamplerate")]
    public Audiosamplerate Audiosamplerate { get; set; }

    [JsonPropertyName("capsuleparams")]
    public Capsuleparams Capsuleparams { get; set; }

    [JsonPropertyName("colorSpace")]
    public ColorSpace ColorSpace { get; set; }

    [JsonPropertyName("currenttime")]
    public Currenttime Currenttime { get; set; }

    [JsonPropertyName("duration")]
    public Duration Duration { get; set; }

    [JsonPropertyName("fieldtype")]
    public int Fieldtype { get; set; }

    [JsonPropertyName("framerate")]
    public Framerate Framerate { get; set; }

    [JsonPropertyName("framesize")]
    public Framesize Framesize { get; set; }

    [JsonPropertyName("hasFrozenUnstretchableRegions")]
    public bool HasFrozenUnstretchableRegions { get; set; }

    [JsonPropertyName("hasaudio")]
    public bool Hasaudio { get; set; }

    [JsonPropertyName("hasvideo")]
    public bool Hasvideo { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("initialcontentstate")]
    public string Initialcontentstate { get; set; }

    [JsonPropertyName("inpoint")]
    public Inpoint Inpoint { get; set; }

    [JsonPropertyName("isdropframe")]
    public bool Isdropframe { get; set; }

    [JsonPropertyName("ismedia")]
    public bool Ismedia { get; set; }

    [JsonPropertyName("isxmpwritable")]
    public bool Isxmpwritable { get; set; }

    [JsonPropertyName("mediaproducerdescription")]
    public string Mediaproducerdescription { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("nativefieldtype")]
    public int Nativefieldtype { get; set; }

    [JsonPropertyName("outpoint")]
    public Outpoint Outpoint { get; set; }

    [JsonPropertyName("parentprojectfile")]
    public string Parentprojectfile { get; set; }

    [JsonPropertyName("pixelaspectratio")]
    public Pixelaspectratio Pixelaspectratio { get; set; }

    [JsonPropertyName("pixelformatlist")]
    public List<Pixelformatlist> Pixelformatlist { get; set; }

    [JsonPropertyName("starttime")]
    public Starttime Starttime { get; set; }

    [JsonPropertyName("supportsvideorenderingsessions")]
    public bool Supportsvideorenderingsessions { get; set; }

    [JsonPropertyName("teamProjectName")]
    public string TeamProjectName { get; set; }

    [JsonPropertyName("workinpoint")]
    public Workinpoint Workinpoint { get; set; }

    [JsonPropertyName("workoutpoint")]
    public Workoutpoint Workoutpoint { get; set; }
}

public class SourceInfoLocalized
{
    [JsonPropertyName("en_US")]
    public EnUS EnUS { get; set; }
}

public class UsedFontsLocalized
{
    [JsonPropertyName("en_US")]
    public List<string> EnUS { get; set; }
}

public class Root
{
    [JsonPropertyName("aelibCompliantVersion")]
    public string AelibCompliantVersion { get; set; }

    [JsonPropertyName("apiVersion")]
    public string ApiVersion { get; set; }

    [JsonPropertyName("authorApp")]
    public string AuthorApp { get; set; }

    [JsonPropertyName("authorID")]
    public string AuthorID { get; set; }

    [JsonPropertyName("capsuleID")]
    public string CapsuleID { get; set; }

    [JsonPropertyName("capsuleName")]
    public string CapsuleName { get; set; }

    [JsonPropertyName("capsuleNameLocalized")]
    public CapsuleNameLocalized CapsuleNameLocalized { get; set; }

    [JsonPropertyName("capsuleTags")]
    public List<object> CapsuleTags { get; set; }

    [JsonPropertyName("clientControls")]
    public List<ClientControl> ClientControls { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("internalEffectsOnlyVersion")]
    public string InternalEffectsOnlyVersion { get; set; }

    [JsonPropertyName("licenseID")]
    public string LicenseID { get; set; }

    [JsonPropertyName("mobileCompatibilityVersion")]
    public string MobileCompatibilityVersion { get; set; }

    [JsonPropertyName("platformSupport")]
    public List<string> PlatformSupport { get; set; }

    [JsonPropertyName("responsiveDesignVersion")]
    public string ResponsiveDesignVersion { get; set; }

    [JsonPropertyName("sourceInfoLocalized")]
    public SourceInfoLocalized SourceInfoLocalized { get; set; }

    [JsonPropertyName("typekitOnlyVersion")]
    public string TypekitOnlyVersion { get; set; }

    [JsonPropertyName("usedCompRenderers")]
    public List<string> UsedCompRenderers { get; set; }

    [JsonPropertyName("usedEffects")]
    public List<string> UsedEffects { get; set; }

    [JsonPropertyName("usedFileTypes")]
    public List<string> UsedFileTypes { get; set; }

    [JsonPropertyName("usedFontsLocalized")]
    public UsedFontsLocalized UsedFontsLocalized { get; set; }
}

