using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mission10_JacobBigler.Models;

namespace Mission10_JacobBigler.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BowlingController : ControllerBase
    {
        private IBowlerRepository _bowlerRepository;
        public BowlingController(IBowlerRepository temp) { //CONSTRUCTOR BABY
            _bowlerRepository = temp;
        }

        [HttpGet]
        public IEnumerable<Bowler> Get() //Go get all of the bowler's information
        {
            // Join the bowlers table with the teams table on TeamID
            var bowlerData = (from bowler in _bowlerRepository.Bowlers
                              join team in _bowlerRepository.Teams
                              on bowler.TeamId equals team.TeamId
                              select new Bowler
                              {
                                  //Add the stuff to variables
                                  //I only add the information that will be needed.
                                  //Because of this, the bowlerId and TeamId will not be returned in the Json summary.
                                  BowlerId = bowler.BowlerId,
                                  BowlerLastName = bowler.BowlerLastName,
                                  BowlerFirstName = bowler.BowlerFirstName,
                                  BowlerMiddleInit = bowler.BowlerMiddleInit,
                                  BowlerAddress = bowler.BowlerAddress,
                                  BowlerCity = bowler.BowlerCity,
                                  BowlerState = bowler.BowlerState,
                                  BowlerZip = bowler.BowlerZip,
                                  BowlerPhoneNumber = bowler.BowlerPhoneNumber,
                                  TeamId = bowler.TeamId,
                                  // Add Team object to be returned.
                                  Team = team
                              }).ToArray();

            return bowlerData;
        }
    }
}
