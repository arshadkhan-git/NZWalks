using System.Diagnostics;

namespace NZWalks.API.Models.Domain
{
    public class Walk
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Length { get; set; }
        public Guid RegionId { get; set; }
        public Guid WalkDifficultyId { get; set; }

        //Navigation Properties
        public Region Region { get; set; }
        public WalkDifficulty walkDifficulty { get; set; }
    }
}
