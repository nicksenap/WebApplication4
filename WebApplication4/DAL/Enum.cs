using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication4.DAL
{

    public enum HairColor
    {
        blonde,
        brunette,
        redhead
    }

    public enum UserStatus
    {
        Deleted = 0,
        Active = 1,
        Inactive = 2
    }

    public enum UserType
    {
        Investor = 0,
        Ioaner = 1,
        Admin = 100

    }

    public enum UserInfoDataStatus
    {
        Deleted = 0,
        Active = 1,
        Inactive = 2
    }

    public enum UserInfoTypeStatus
    {
        Deleted = 0,
        Active = 1,
        Inactive = 2
    }


    public enum CreditFlag
    {
        Black = 0,
        White = 1,
        Red = 2,
        Orange = 3,
        Yellow = 4,
        Green = 5,
        Brown = 6
    }

    public enum LoanAccountStatus
    {
        Deleted = 0,
        Active = 1,
        Inactive = 2
    }

    public enum LoanAccoutType
    {
        Basic = 0,
        Pro = 1,
        Premium = 2
    }

    public enum Currency
    {

    }

    public enum LoanStatus
    {
        Deleted = 0,
        Active = 1,
        Inactive = 2
    }


    public enum LoanType
    {

    }

    public enum LoanRateType
    {
        APR = 0, // Loaner
        EIR = 1,
        Returns = 2,
        Product = 4 // Investor
    }


    public enum LoanRateStatus
    {
        Deprecated = 0,
        Active = 1,
        Inactive = 2
    }

    public enum LoanPaymentStatus
    {
        None = 0,
        Upcoming = 1,
        Paid = 2,
        Unpaid = 3,

    }

    public enum LoanPaymentType
    {
        Planned = 0,
        Extra = 1,
        Late = 2,
    }

    public enum LoanPaymentPartType
    {
        Interest = 0,
        Principle = 1,
        Fees = 2
    }

    public enum LoanApplicationStatus
    {
        Pending = 0,
        Approved = 1,
        Reject = 2,
    }

    public enum LoanPaymentPartStatus
    {
        None = 0,
        Upcoming = 1,
        Paid = 2,
        Unpaid = 3,
    }

    public enum InvestmentApplicationStatus
    {
        Pending = 0,
        Approved = 1,
        Reject = 2,
    }

    public enum InvestAccountStatus
    {
        Interest = 0,
        Principal = 1,
        Fees = 2
    }

    public enum InvestAccountType
    {
        Interest = 0,
        Principal = 1,
        Fees = 2
    }

    public enum InvestAccountDirection
    {
        Interest = 0,
        Principal = 1,
        Fees = 2
    }

    public enum InvestmentAssetStatus
    {

    }

    public enum InvestmentAssetType
    {

    }


    public enum InvestmentType
    {
    }

    public enum InvestmentStatus
    {
    }


    public enum InvestmentPaymentType
    {

    }

    public enum UserInfoTypeType
    {
        String = 0,
        Integer = 1,
        Float = 2,
        Date = 3,
        Bool = 4,
        Enum = 5,
        RegEx = 6
    }

    public enum InvestmentPaymentStatus
    {

    }

    public enum Gender
    {
        Male = 0,
        Female = 1
    }

    //public enum CivilStatus
    //{
    //    Married,
    //    Single,
    //    Divorced,
    //    Widowed
    //}


    public enum JobType
    {
        [Display(Name ="Bygg/Anläggning/infrastruktur")]
        BygoneLaggingInfrastructure = 0,
        [Display(Name = "Data/Teknik/IT")]
        DataTeknikIt = 1,
        [Display(Name = "Drift/Underhåll")]
        DriftUnderhall = 2,
        [Display(Name ="Ekonomi/Finans")]
        EkonomiFinans = 3,
        [Display(Name ="Fastigheter")]
        Fastigheter = 4,
        [Display(Name ="Forskning/R_D/Vetenskap")]
        Forskning_R_D_Vetenskap = 5,
        [Display(Name ="Försäljning/Affärsutveckling")]
        Forsaljning_Affarsutveckling = 6,
        [Display(Name ="Hotell/Restaurang/Turism")]
        Hotell_Restaurang_Turism = 7,
        [Display(Name ="HR/Personal")]
        HR_Personal = 8,
        [Display(Name ="Import/Export/Handel")]
        Import_Export_Handel = 9,
        [Display(Name ="Juridik")]
        Juridik = 10,
        [Display(Name ="Kundsupport/Service")]
        Kundsupport_Service = 11,
        [Display(Name ="Lantbruk/Skogsbruk")]
        Lantbruk_Skogsbruk = 12,
        [Display(Name ="Ledning/Management")]
        Ledning_Management = 13,
        [Display(Name ="Logistik/Transport")]
        Logistik_Transport = 14,
        [Display(Name ="Marknad/Reklam")]
        Marknad_Reklam = 15,
        [Display(Name ="Sjukvård/Hälsa")]
        Sjukvard_Halsa = 16,
        [Display(Name ="Skribent/Publishing")]
        Skribent_Publishing = 17,
        [Display(Name ="Säkerhet/Räddningstjänst")]
        Sakerhet_Raddningstjanst = 18,
        [Display(Name ="Teologi/Psykologi/Filosofi")]
        Teologi_Psykologi_Filosofi = 19,
        [Display(Name ="Tillverkning/Produktion")]
        Tillverkning_Produktion = 20,
        [Display(Name ="Utbildning")]
        Utbildning = 21,
    }

    public enum MaritalStatus
    {
        [Display(Name = "Ensamstående")]
        Ensamstaende = 0,
        [Display(Name = "Gift/registrerad partner")]
        Gift_registrerad_partner = 1,
        [Display(Name = "Sambo")]
        Sambo = 2,
        [Display(Name = "Särbo")]
        Sarbo = 3,
        [Display(Name = "Skild")]
        Skild = 4,
        [Display(Name = "änka/änkling")]
        anka_ankling = 5,
    }
    public enum LivingStatus
    {
        [Display(Name = "Småhus")]
        Smahus = 0,
        [Display(Name = "Bostadsrätt")]
        Bostadsratt = 1,
        [Display(Name = "Hyresrätt")]
        Hyresratt = 2,
        [Display(Name = "Andrahand")]
        Andrahand = 3,
        [Display(Name = "Inneboende")]
        Inneboende = 4,
        [Display(Name = "Fritidshus")]
        Fritidshus = 5,
    }
    public enum JobStatus
    {
        [Display(Name = "Fast anställd")]
        Fast_anstalld = 0,
        [Display(Name = "Egenföretagare")]
        Egenforetagare = 1,
        [Display(Name = "Tidsbegränsad anställning")]
        Tidsbegransad_anstallning = 2,
        [Display(Name = "Timanställd")]
        Timanstalld = 3,
        [Display(Name = "Studerande")]
        Studerande = 4,
        [Display(Name = "Arbetssökande")]
        Arbetssokande = 5,
        [Display(Name = "Pensionär")]
        Pensionar = 6,
        [Display(Name = "Förtidspensionär")]
        Frtidspensionar = 7,
        [Display(Name = "Sjukpensionär")]
        Sjukpensionar = 8,
        [Display(Name = "Provanställd")]
        Provanstalld = 9,
    }
    public enum LoanCategory
    {
        [Display(Name = "Utbildning")]
        Utbildning = 0,
        [Display(Name = "Fordon")]
        Fordon = 1,
        [Display(Name = "Heminredning")]
        Heminredning = 2,
        [Display(Name = "Vitvaror&köksapparater")]
        Vitvaror_koksapparater = 3,
        [Display(Name = "Skilsmässa")]
        Skilsmassa = 4,
        [Display(Name = "Samla lån (skuldkonsolidering)")]
        Samla_lan_skuldkonsolidering = 5,
        [Display(Name = "Flytt")]
        Flytt = 6,
        [Display(Name = "Hemelektronik")]
        Hemelektronik = 7,
        [Display(Name = "Semester")]
        Semester = 8,
        [Display(Name = "Personvård&hälsa")]
        Personvard_halsa = 9,
        [Display(Name = "Giftermål")]
        Giftermal = 10,
        [Display(Name = "Köp av värdepapper")]
        Kop_av_vardepapper = 11,
    }

}
