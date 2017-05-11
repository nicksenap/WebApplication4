using System.Collections.Generic;
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
        investor,
        loaner

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
        White,
        Red,
        Orange,
        Yellow,
        Green,
        Brown
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

    }


    public enum LoanRateStatus
    {

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


    public enum LoanPaymentPartStatus
    {
        None = 0,
        Upcoming = 1,
        Paid = 2,
        Unpaid = 3,
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



    public enum InvestmentPaymentStatus
    {

    }
}
