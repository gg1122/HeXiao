//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Langben.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class PoliceInsurance
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string InsuranceId { get; set; }
        public string CityId { get; set; }
        public string PoliceAccountNatureId { get; set; }
        public string InsuranceKindId { get; set; }
        public Nullable<System.DateTime> StartTime { get; set; }
        public Nullable<System.DateTime> EndTime { get; set; }
        public Nullable<int> MaxPayMonth { get; set; }
        public Nullable<int> InsuranceAdd { get; set; }
        public Nullable<int> PaymentFrequency { get; set; }
        public Nullable<int> InsuranceReduce { get; set; }
        public Nullable<decimal> CompanyPercent { get; set; }
        public Nullable<decimal> CompanyLowestNumber { get; set; }
        public Nullable<decimal> EmployeeLowestNumber { get; set; }
        public Nullable<decimal> CompanyHighestNumber { get; set; }
        public Nullable<decimal> LowWage { get; set; }
        public Nullable<decimal> SocialWage { get; set; }
        public Nullable<decimal> EmployeeHighestNumber { get; set; }
        public Nullable<decimal> EmployeePercent { get; set; }
        public Nullable<int> CompanySub { get; set; }
        public Nullable<int> CompanyDigit { get; set; }
        public Nullable<int> EmployeeSub { get; set; }
        public Nullable<int> EmployeeDigit { get; set; }
        public string IsDefault { get; set; }
        public string Remark { get; set; }
        public string State { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public string CreatePerson { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
        public string UpdatePerson { get; set; }
        public Nullable<int> Vertion { get; set; }
        public Nullable<decimal> CompanyNumber { get; set; }
        public Nullable<decimal> EmployeeNumber { get; set; }
    
        public virtual Insurance Insurance { get; set; }
    }
}
