using System.Collections.Generic;

namespace JwtHelper.TokenService
{
    /// <summary>
    /// Application Titles
    /// </summary>
    public static class ApplicationsDatabase
    {
        public static readonly Dictionary<string, string> Applications = new Dictionary<string, string>()
        {
            ["cif"] = "سامانه اطلاعات مشتریان",
            ["organizationcontract"] = "ساماندهی قرارداد",
            ["cbrm"] = "cbrm",
            ["legal"] = "سامانه حقوقی",
            ["usermanagement"] = "مدیریت کاربران و دسترسی ها",
            ["investigation"] = "نظارت غیرحضوری",
            ["workflow"] = "کارتابل",
            ["financialstatement"] = "رتبه بندي - صورت مالي",
            ["request"] = "رتبه بندی - درخواست",
            ["calculation"] = "رتبه بندی - محاسبات",
            ["helpdesk"] = "سامانه خدمات پس از فروش و پشتیبانی",
            ["afra"] = "اپن بانکینگ بخش افرا",
        };
    }
}
