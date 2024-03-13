
namespace Mission10_JacobBigler.Models
{
    public class EFBowlerRepository : IBowlerRepository
    {
        private BowlingLeagueContext _leagueContext;
        public EFBowlerRepository(BowlingLeagueContext temp) {
            _leagueContext = temp;
        }
        public IEnumerable<Bowler> Bowlers => _leagueContext.Bowlers;

        public IEnumerable<Team> Teams => _leagueContext.Teams;
    }
}
