//------------------------------------------------------------------------------
// <auto-generated>
//     Codice generato da un modello.
//
//     Le modifiche manuali a questo file potrebbero causare un comportamento imprevisto dell'applicazione.
//     Se il codice viene rigenerato, le modifiche manuali al file verranno sovrascritte.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class GroupStat
    {
        public int Id { get; set; }
        public long GroupId { get; set; }
        public int GamesPlayed { get; set; }
        public string MostKilledFirstNight { get; set; }
        public Nullable<int> MostKilledFirstPercent { get; set; }
        public string MostLynchedFirstNight { get; set; }
        public Nullable<int> MostLynchFirstPercent { get; set; }
        public string MostDeadFirstDay { get; set; }
        public Nullable<int> MostDeadFirstPercent { get; set; }
        public string BestSurvivor { get; set; }
        public Nullable<int> BestSurvivorPercent { get; set; }
        public Nullable<System.DateTime> LastRun { get; set; }
        public string GroupName { get; set; }
    }
}
