using TryBets.Odds.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Globalization;

namespace TryBets.Odds.Repository;

public class OddRepository : IOddRepository
{
    protected readonly ITryBetsContext _context;
    public OddRepository(ITryBetsContext context)
    {
        _context = context;
    }

    public Match Patch(int MatchId, int TeamId, string BetValue)
    {
        string BetValueConverted = BetValue.Replace(',', '.');
        decimal BetValueDecimal = Decimal.Parse(BetValueConverted, CultureInfo.InvariantCulture);

        var getMatch = _context.Matches.Where(m => m.MatchId == MatchId)
            .Select(m => new Match
            {
                MatchId = m.MatchId,
                MatchTeamAId = m.MatchTeamAId,
                MatchTeamBId = m.MatchTeamBId,
                MatchTeamAValue = m.MatchTeamAValue,
                MatchTeamBValue = m.MatchTeamBValue,
                MatchFinished = m.MatchFinished
            }).FirstOrDefault();

            if (getMatch.MatchTeamAId == TeamId)
            {
                getMatch.MatchTeamAValue += BetValueDecimal;
            }
            else if (getMatch.MatchTeamBId == TeamId)
            {
                getMatch.MatchTeamBValue += BetValueDecimal;
            }
            else
            {
                throw new Exception("Team is not in this match");
            }

            _context.Matches.Update(getMatch);
            _context.SaveChanges();

            return getMatch;
    }
}