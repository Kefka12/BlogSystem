namespace BlogSystem.ViewModels.Admin
{
    public class SiteSettingViewModel:PassBaseViewModel
    {
        public string SiteName { get; set; }
        public string Host { get; set; }
        public string Domain { get; set; }
        public string FashionQuotes { get; set; }
        public bool IsShowSiteName { get; set; }
        public bool IsShowQutoes { get; set; }
        public string Cban { get; set; }
        public string TailContent { get; set; }
        public int OnePageCount { get; set; }
        public string LoginUriValue { get; set; }
        public bool IsShowEdgeSearch { get; set; }
        public bool IsOpenDetailThumb { get; set; }
        public int? LeaveLimitCount { get; set; }
    }
}
