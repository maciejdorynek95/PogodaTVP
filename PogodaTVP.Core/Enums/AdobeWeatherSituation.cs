namespace PogodaTVP.Core.Enums
{
    public enum AdobeWeatherSituation
    {
        SLONCE = 0,
        SLONCE_CHMURY = 1,
        SLONCE_CHMURY_DUZE = 2,
        SLONCE_DESZCZ = 3,
        SLONCE_SNIEG = 4,
        SLONCE_DESZCZ_SNIEG = 5,
        KSIEZYC = 6,
        KSIEZYC_CHMURY = 7,
        KSIEZYC_CHMURY_DUZE = 8,
        KSIEZYC_DESZCZ = 9,
        KSIEZYC_SNIEG = 10,
        KSIEZYC_DESZCZ_SNIEG = 11,
        CHMURY = 12,
        CHMURY_DUZE = 13,
        DESZCZ = 14,
        SNIEG = 15,
        BURZA = 16,
        BURZA_DESZCZ = 17,
        BURZA_SNIEG = 18,
        DESZCZ_SNIEG = 19,
        MGLA = 20
    }
    public static class WeatherSituation
    {
        
        public static AdobeWeatherSituation MapWeatherSituationToAdobeDay(CulumbusWeatherSituation situation)
        {
            switch (situation)
            {
                case CulumbusWeatherSituation.Bezchmurnie:
                    return AdobeWeatherSituation.SLONCE;
                case CulumbusWeatherSituation.Zachmurzenie_małe:
                    return AdobeWeatherSituation.SLONCE_CHMURY;
                case CulumbusWeatherSituation.Zachmurzenie_umiarkowane:
                    return AdobeWeatherSituation.SLONCE_CHMURY;
                case CulumbusWeatherSituation.Zachmurzenie_duże:
                    return AdobeWeatherSituation.SLONCE_CHMURY_DUZE;
                case CulumbusWeatherSituation.Zachmurzenie_pełne:
                    return AdobeWeatherSituation.SLONCE_CHMURY_DUZE;
                case CulumbusWeatherSituation.Zachmurzenie_zmienne_z_opadami_deszczu:
                    return AdobeWeatherSituation.SLONCE_DESZCZ;
                case CulumbusWeatherSituation.Zachmurzenie_zmienne_z_opadami_deszczu_ze_śniegiem:
                    return AdobeWeatherSituation.SLONCE_DESZCZ_SNIEG;
                case CulumbusWeatherSituation.Zachmurzenie_zmienne_z_opadami_śniegu:
                    return AdobeWeatherSituation.SLONCE_SNIEG;
                case CulumbusWeatherSituation.Zachmurzenie_zmienne_z_opadami_marznącymi_gołoledź:
                    return AdobeWeatherSituation.DESZCZ_SNIEG;
                case CulumbusWeatherSituation.Zachmurzenie_zmienne_z_opadami_gradu:
                    return AdobeWeatherSituation.DESZCZ_SNIEG;
                case CulumbusWeatherSituation.Zachmurzenie_zmienne_z_burzą_i_z_opadami_deszczu:
                    return AdobeWeatherSituation.BURZA_DESZCZ;
                case CulumbusWeatherSituation.Zachmurzenie_zmienne_z_burzą_i_z_opadami_śniegu:
                    return AdobeWeatherSituation.BURZA_SNIEG;
                case CulumbusWeatherSituation.Zachmurzenie_zmienne_z_burzą_i_z_opadami_gradu:
                    return AdobeWeatherSituation.BURZA_SNIEG;
                case CulumbusWeatherSituation.Zachmurzenie_duże_z_opadami_deszczu:
                    return AdobeWeatherSituation.DESZCZ;
                case CulumbusWeatherSituation.Zachmurzenie_duże_z_opadami_deszczu_ze_śniegiem:
                    return AdobeWeatherSituation.SNIEG;
                case CulumbusWeatherSituation.Zachmurzenie_duże_z_opadami_śniegu:
                    return AdobeWeatherSituation.SNIEG;
                case CulumbusWeatherSituation.Zachmurzenie_duże_z_opadami_marznącymi_gołoledź:
                    return AdobeWeatherSituation.DESZCZ_SNIEG;
                case CulumbusWeatherSituation.Zachmurzenie_duże_z_opadami_gradu:
                    return AdobeWeatherSituation.DESZCZ_SNIEG;
                case CulumbusWeatherSituation.Zachmurzenie_duże_z_burzą_i_z_opadami_deszczu:
                    return AdobeWeatherSituation.BURZA_DESZCZ;
                case CulumbusWeatherSituation.Zachmurzenie_duże_z_burzą_i_z_opadami_śniegu:
                    return AdobeWeatherSituation.BURZA_SNIEG;
                case CulumbusWeatherSituation.Zachmurzenie_duże_z_burzą_i_z_opadami_gradu:
                    return AdobeWeatherSituation.BURZA_SNIEG;
                case CulumbusWeatherSituation.Zachmurzenie_pełne_z_opadami_deszczu:
                    return AdobeWeatherSituation.DESZCZ;
                case CulumbusWeatherSituation.Zachmurzenie_pełne_z_opadami_deszczu_ze_śniegiem:
                    return AdobeWeatherSituation.DESZCZ_SNIEG;
                case CulumbusWeatherSituation.Zachmurzenie_pełne_z_opadami_śniegu:
                    return AdobeWeatherSituation.SNIEG;
                case CulumbusWeatherSituation.Zachmurzenie_pełne_z_opadami_marznącymi_gołoledź:
                    return AdobeWeatherSituation.SNIEG;
                case CulumbusWeatherSituation.Zachmurzenie_pełne_z_opadami_gradu:
                    return AdobeWeatherSituation.SNIEG;
                case CulumbusWeatherSituation.Zachmurzenie_pełne_z_burzą_i_z_opadami_deszczu:
                    return AdobeWeatherSituation.BURZA_DESZCZ;
                case CulumbusWeatherSituation.Zachmurzenie_pełne_z_burzą_i_z_opadami_śniegu:
                    return AdobeWeatherSituation.BURZA_SNIEG;
                case CulumbusWeatherSituation.Zachmurzenie_pełne_z_burzą_i_z_opadami_gradu:
                    return AdobeWeatherSituation.BURZA_SNIEG;
                default:
                    throw new System.Exception("Brak wartości dla pogody za dnia: " + situation.ToString());
            }
        }
        public static AdobeWeatherSituation MapWeatherSituationToAdobeNight(CulumbusWeatherSituation situation)
        {
            switch (situation)
            {
                case CulumbusWeatherSituation.Bezchmurnie:
                    return AdobeWeatherSituation.KSIEZYC;
                case CulumbusWeatherSituation.Zachmurzenie_małe:
                    return AdobeWeatherSituation.KSIEZYC_CHMURY;
                case CulumbusWeatherSituation.Zachmurzenie_umiarkowane:
                    return AdobeWeatherSituation.KSIEZYC_CHMURY;
                case CulumbusWeatherSituation.Zachmurzenie_duże:
                    return AdobeWeatherSituation.KSIEZYC_CHMURY_DUZE;
                case CulumbusWeatherSituation.Zachmurzenie_pełne:
                    return AdobeWeatherSituation.KSIEZYC_CHMURY_DUZE;
                case CulumbusWeatherSituation.Zachmurzenie_zmienne_z_opadami_deszczu:
                    return AdobeWeatherSituation.KSIEZYC_DESZCZ;
                case CulumbusWeatherSituation.Zachmurzenie_zmienne_z_opadami_deszczu_ze_śniegiem:
                    return AdobeWeatherSituation.KSIEZYC_DESZCZ_SNIEG;
                case CulumbusWeatherSituation.Zachmurzenie_zmienne_z_opadami_śniegu:
                    return AdobeWeatherSituation.KSIEZYC_SNIEG;
                case CulumbusWeatherSituation.Zachmurzenie_zmienne_z_opadami_marznącymi_gołoledź:
                    return AdobeWeatherSituation.KSIEZYC_SNIEG;
                case CulumbusWeatherSituation.Zachmurzenie_zmienne_z_opadami_gradu:
                    return AdobeWeatherSituation.KSIEZYC_SNIEG;
                case CulumbusWeatherSituation.Zachmurzenie_zmienne_z_burzą_i_z_opadami_deszczu:
                    return AdobeWeatherSituation.BURZA_DESZCZ;
                case CulumbusWeatherSituation.Zachmurzenie_zmienne_z_burzą_i_z_opadami_śniegu:
                    return AdobeWeatherSituation.BURZA_SNIEG;
                case CulumbusWeatherSituation.Zachmurzenie_zmienne_z_burzą_i_z_opadami_gradu:
                    return AdobeWeatherSituation.BURZA_SNIEG;
                case CulumbusWeatherSituation.Zachmurzenie_duże_z_opadami_deszczu:
                    return AdobeWeatherSituation.KSIEZYC_DESZCZ;
                case CulumbusWeatherSituation.Zachmurzenie_duże_z_opadami_deszczu_ze_śniegiem:
                    return AdobeWeatherSituation.KSIEZYC_SNIEG;
                case CulumbusWeatherSituation.Zachmurzenie_duże_z_opadami_śniegu:
                    return AdobeWeatherSituation.KSIEZYC_SNIEG;
                case CulumbusWeatherSituation.Zachmurzenie_duże_z_opadami_marznącymi_gołoledź:
                    return AdobeWeatherSituation.KSIEZYC_SNIEG;
                case CulumbusWeatherSituation.Zachmurzenie_duże_z_opadami_gradu:
                    return AdobeWeatherSituation.KSIEZYC_SNIEG;
                case CulumbusWeatherSituation.Zachmurzenie_duże_z_burzą_i_z_opadami_deszczu:
                    return AdobeWeatherSituation.BURZA_DESZCZ;
                case CulumbusWeatherSituation.Zachmurzenie_duże_z_burzą_i_z_opadami_śniegu:
                    return AdobeWeatherSituation.BURZA_SNIEG;
                case CulumbusWeatherSituation.Zachmurzenie_duże_z_burzą_i_z_opadami_gradu:
                    return AdobeWeatherSituation.BURZA_SNIEG;
                case CulumbusWeatherSituation.Zachmurzenie_pełne_z_opadami_deszczu:
                    return AdobeWeatherSituation.KSIEZYC_DESZCZ;
                case CulumbusWeatherSituation.Zachmurzenie_pełne_z_opadami_deszczu_ze_śniegiem:
                    return AdobeWeatherSituation.KSIEZYC_DESZCZ_SNIEG;
                case CulumbusWeatherSituation.Zachmurzenie_pełne_z_opadami_śniegu:
                    return AdobeWeatherSituation.KSIEZYC_SNIEG;
                case CulumbusWeatherSituation.Zachmurzenie_pełne_z_opadami_marznącymi_gołoledź:
                    return AdobeWeatherSituation.KSIEZYC_SNIEG;
                case CulumbusWeatherSituation.Zachmurzenie_pełne_z_opadami_gradu:
                    return AdobeWeatherSituation.KSIEZYC_SNIEG;
                case CulumbusWeatherSituation.Zachmurzenie_pełne_z_burzą_i_z_opadami_deszczu:
                    return AdobeWeatherSituation.BURZA_DESZCZ;
                case CulumbusWeatherSituation.Zachmurzenie_pełne_z_burzą_i_z_opadami_śniegu:
                    return AdobeWeatherSituation.BURZA_SNIEG;
                case CulumbusWeatherSituation.Zachmurzenie_pełne_z_burzą_i_z_opadami_gradu:
                    return AdobeWeatherSituation.BURZA_SNIEG;
                default:
                    throw new System.Exception("Brak wartości dla pogody w nocy: " + situation.ToString());
            }
        }

    }
}


    

