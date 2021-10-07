**Scenario:**

A stakeholder came to ask you to create a tournament tracker. They are always playing games and want to determine who is the best. The idea is that you create a bracket tournament system where the computer will tell them who to play in a single-elimination style bracket. At the end, the winner should be identified. Their model is the NCAA Basketball tournament bracket for March Madness



**Requirements:**

1. Tracks games played and their outcome (who won)
2. Multiple competitors play in the tournament
3. Creates a tournament plan (who plays in what order)
4. Schedule games
5. A single loss eliminates a player
6. The last person standing is the winner



**Questions:**

- How many players will the tournament handle? Is it variable?

  - The application should be able to handle a variable number of players in the tournament

- If a tournament has less than the full complement of players, how do we handle it?

  - A tournament with less than the perfect number (a multiple of 2, so 4, 8, 16, 32, etc.) should add in "byes". Basically, certain people selected <u>at random</u> get to skip the first round and act as if they won

- Should the ordering of who plays each other be random or ordered by input order?

  - The ordering of the tournament should be random

- Should we schedule a game or are they just played whenever?

  - The games should be played in whatever order and whenever the players want to play them

- If the games are scheduled, how does the system know when to schedule games for?

  - They are not scheduled so we do not care

- If the games are played whenever, can a game from the second round be played before the first round is complete?

  - No. Each round should be fully completed before the next round is displayed

- Does the system need to store a score of some kind or just who won?

  - Storing a simple score would be nice. Just a number for each player. That way, the tracker can be flexible enough to handle a checkers tournament (the winner would have a 1 and the loser a 0) or a basketball tournament

- What type of front-end should this system have (form, webpage, app, etc.)?

  - The system should be a desktop system for now, but down the road we might want to turn it into an app or website

- Where will the data be stored?

  - Ideally, the data should be stored in a Microsoft SQL database, but please put in an option to store to a text file instead

- Will this system handle entry fees, prizes, or other payouts?

  - Yes. The tournament should have the option of charging an entry fee. Prizes should also be an option, where the tournament admin chooses how much money to award and a variable number of places. The total cash amount should not exceed the income from the tournament. A percentage-based system would also be nice to specify

- What type of reporting is needed?

  - A simple report specifying the outcome of the games per round as well as a report that specifies who won and how much they won. These can just be displayed on a form or they can be emailed to tournament competitors and the admin

- Who can fill in the results of a game?

  - Anyone using the application should be able to fill in the game scores

- Are there varying levels of access?

  - No. The only method of varied access is if the competitors are not allowed into the application and instead, they do everything via email

- Should this system contact users about upcoming games?

  - Yes, the system should email users that they are due to play a round as well as who they are scheduled to play

- Is each player on their own or can teams use this tournament tracker?

  - The tournament tracker should be able to handle the addition of other members. All members should be treated as equal in that they all get tournament emails. Teams should also be able to name their team

    

**Big Picture Design:**

*Structure*: Windows Forms application and Class Library

*Data:* SQL and/or Text File

*Users:* One at a time on one application

*Key Concepts:*

- Email
- SQL
- Custom Events
- Error Handling
- Interfaces
- Random Ordering
- Texting



### Data Design

###### **Mapping the Data**

**Team** (Class)

- TeamMembers(List<Person>)
- TeamName (string)

**Person** (Class)

- FirstName (string)
- LastName (string)
- EmailAddress (string)
- CellPhoneNumber (string)

**Tournament** (Class)

- TournamentName (string)
- EntryFee (decimal)
- EnteredTeams (List<Team>)
- Prizes (List<Prize>)
- Rounds (List<List<Matchup>>)

**Prize** (Class)

- PlaceNumber (int)
- PlaceName (string)
- PrizeAmount (decimal)
- PrizePercentage (double)

**Matchup** (Class)

- Entries (List<MatchupEntry>)
- Winner (Team)
- MatchupRound (int)

**MatchupEntry** (Class)

- TeamCompeting (Team)
- Score (double)
- ParentMatchup (Matchup)

