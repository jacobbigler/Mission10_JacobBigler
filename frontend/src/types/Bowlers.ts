import { Team } from './Teams';

export type Bowlers = {
  bowlerId: number;
  bowlerFirstName: string;
  bowlerLastName: string;
  bowlerMiddleInit: string;
  bowlerAddress: string;
  bowlerCity: string;
  bowlerState: string;
  bowlerZip: string;
  bowlerPhoneNumber: string;
  teamId: number;
  team: Team;
};
